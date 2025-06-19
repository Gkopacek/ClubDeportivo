-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 19-06-2025 a las 02:06:37
-- Versión del servidor: 10.4.24-MariaDB
-- Versión de PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `club_deportivo_2`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `ActualizarDeudores` ()   BEGIN
    UPDATE personas
    SET estado = 'inactivo'
    WHERE estado = 'activo'
      AND documento NOT IN (
          SELECT documento
          FROM pagos
          WHERE fecha_pago >= CURDATE() - INTERVAL 30 DAY
      );
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `BuscarPersonaPorDocumento` (IN `p_documento` VARCHAR(20))   BEGIN
    SELECT *
    FROM personas
    WHERE documento = p_documento;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `BuscarSocios` ()   BEGIN
    SELECT * FROM personas
    WHERE tipo = 'socio';
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoLogin` (IN `Usu` VARCHAR(50), IN `Pass` VARCHAR(50))   BEGIN
    SELECT * FROM usuarios WHERE usuario = Usu AND contraseña = Pass;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarPersona` (IN `p_nombre` VARCHAR(100), IN `p_documento` VARCHAR(20), IN `p_fecha` DATE, IN `p_estado` ENUM('activo','inactivo'), IN `p_tipo` ENUM('socio','no socio'), IN `p_apto` TINYINT)   BEGIN
    INSERT INTO personas (nombre, documento, fecha_inscripcion, estado, tipo, presento_apto_fisico)
    VALUES (p_nombre, p_documento, p_fecha, p_estado, p_tipo, p_apto);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerPersonas` ()   BEGIN
    SELECT * FROM personas;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistrarPago` (IN `p_documento` VARCHAR(20), IN `p_monto` DECIMAL(10,2), IN `p_concepto` VARCHAR(50))   BEGIN
    INSERT INTO pagos (documento, monto, concepto)
    VALUES (p_documento, p_monto, p_concepto);
    
    -- Actualizar el estado del socio a 'activo'
    UPDATE personas
    SET estado = 'activo'
    WHERE documento = p_documento;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pagos`
--

CREATE TABLE `pagos` (
  `id` int(11) NOT NULL,
  `documento` varchar(20) NOT NULL,
  `fecha_pago` date NOT NULL DEFAULT curdate(),
  `monto` decimal(10,2) NOT NULL,
  `concepto` varchar(55) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `pagos`
--

INSERT INTO `pagos` (`id`, `documento`, `fecha_pago`, `monto`, `concepto`) VALUES
(36, '364008555', '2025-06-18', '30000.00', 'mensualidad'),
(37, '364008557', '2025-06-18', '15000.00', 'actividad');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `personas`
--

CREATE TABLE `personas` (
  `id` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL CHECK (char_length(`nombre`) > 4),
  `documento` varchar(20) NOT NULL CHECK (char_length(`documento`) > 4),
  `fecha_inscripcion` date NOT NULL,
  `estado` enum('activo','inactivo') DEFAULT 'activo',
  `tipo` enum('socio','no socio') NOT NULL DEFAULT 'socio',
  `presento_apto_fisico` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `personas`
--

INSERT INTO `personas` (`id`, `nombre`, `documento`, `fecha_inscripcion`, `estado`, `tipo`, `presento_apto_fisico`) VALUES
(80, 'franco perrone', '364008555', '2025-06-18', 'activo', 'socio', 1),
(81, 'franco rey', '364008556', '2025-06-18', 'inactivo', 'socio', 0),
(82, 'fran rey', '364008557', '2025-06-18', 'activo', 'no socio', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `contraseña` varchar(255) NOT NULL,
  `rol` enum('admin','usuario') NOT NULL DEFAULT 'usuario',
  `fecha_creacion` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `usuario`, `contraseña`, `rol`, `fecha_creacion`) VALUES
(1, 'admin', 'admin123', 'admin', '2025-05-22 08:07:45');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `pagos`
--
ALTER TABLE `pagos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `documento` (`documento`);

--
-- Indices de la tabla `personas`
--
ALTER TABLE `personas`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `documento` (`documento`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `usuario` (`usuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `pagos`
--
ALTER TABLE `pagos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- AUTO_INCREMENT de la tabla `personas`
--
ALTER TABLE `personas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=83;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `pagos`
--
ALTER TABLE `pagos`
  ADD CONSTRAINT `pagos_ibfk_1` FOREIGN KEY (`documento`) REFERENCES `personas` (`documento`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
