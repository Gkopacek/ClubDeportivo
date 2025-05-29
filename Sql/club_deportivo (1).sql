-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 29-05-2025 a las 04:07:50
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
-- Base de datos: `club_deportivo`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `ActualizarDeudores` ()   BEGIN
    UPDATE socios
    SET estado = 'inactivo'
    WHERE estado = 'activo'
      AND documento NOT IN (
          SELECT documento
          FROM pagos
          WHERE fecha_pago >= CURDATE() - INTERVAL 30 DAY
      );
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ActualizarSocio` (IN `socio_id` INT, IN `nuevo_nombre` VARCHAR(100), IN `nuevo_documento` VARCHAR(20), IN `nuevo_estado` ENUM('activo','inactivo'))   BEGIN
    UPDATE socios 
    SET nombre = nuevo_nombre, documento = nuevo_documento, estado = nuevo_estado 
    WHERE id = socio_id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `BuscarSocioPorDocumento` (IN `p_documento` VARCHAR(20))   BEGIN
    SELECT *
    FROM socios
    WHERE documento = p_documento;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `EliminarSocio` (IN `socio_id` INT)   BEGIN
    DELETE FROM socios WHERE id = socio_id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoLogin` (IN `Usu` VARCHAR(50), IN `Pass` VARCHAR(50))   BEGIN
    SELECT * FROM usuarios WHERE usuario = Usu AND contraseña = Pass;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarSocio` (IN `nombre` VARCHAR(100), IN `documento` VARCHAR(20), IN `fecha` DATE, IN `estado` ENUM('activo','inactivo'))   BEGIN
    INSERT INTO socios (nombre, documento, fecha_inscripcion, estado)
    VALUES (nombre, documento, CURDATE(), 'activo');
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerSocios` ()   BEGIN
    SELECT * FROM socios;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistrarPago` (IN `p_documento` VARCHAR(20), IN `p_monto` DECIMAL(10,2), IN `p_metodo_pago` VARCHAR(50))   BEGIN
    INSERT INTO pagos (documento, monto, metodo_pago)
    VALUES (p_documento, p_monto, p_metodo_pago);
    
    -- Actualizar el estado del socio a 'activo'
    UPDATE socios
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
  `metodo_pago` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `pagos`
--

INSERT INTO `pagos` (`id`, `documento`, `fecha_pago`, `monto`, `metodo_pago`) VALUES
(1, '12345678', '2025-05-27', '15000.00', 'Efectivo'),
(2, '23456789', '2025-05-27', '15000.00', 'Transferencia'),
(3, '23456789', '2025-05-27', '1.00', 'Efectivo'),
(4, '87654321', '2025-05-28', '15000.00', 'Efectivo'),
(5, '123456789', '2025-05-28', '15000.00', 'Transferencia');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `socios`
--

CREATE TABLE `socios` (
  `id` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL CHECK (char_length(`nombre`) > 4),
  `documento` varchar(20) NOT NULL CHECK (char_length(`documento`) > 4),
  `fecha_inscripcion` date NOT NULL,
  `estado` enum('activo','inactivo') DEFAULT 'activo'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `socios`
--

INSERT INTO `socios` (`id`, `nombre`, `documento`, `fecha_inscripcion`, `estado`) VALUES
(1, 'Juan Pérez', '12345678', '2023-01-15', 'activo'),
(2, 'María González', '87654321', '2024-03-10', 'activo'),
(3, 'Carlos López', '23456789', '2022-07-25', 'activo'),
(4, 'Ana Rodríguez', '34567890', '2025-01-01', 'inactivo'),
(5, 'Pedro Ramírez', '56789012', '2023-09-30', 'inactivo'),
(6, 'prueba', '3333', '2025-05-27', 'inactivo'),
(13, 'franquito', '333333333', '2025-05-28', 'inactivo'),
(14, '33366', 'franquito', '2025-05-28', 'inactivo'),
(15, 'Franquito lala', '123456789', '2025-05-28', 'activo');

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
-- Indices de la tabla `socios`
--
ALTER TABLE `socios`
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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `socios`
--
ALTER TABLE `socios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

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
  ADD CONSTRAINT `pagos_ibfk_1` FOREIGN KEY (`documento`) REFERENCES `socios` (`documento`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
