-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 07-06-2025 a las 03:34:23
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

CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistrarPago` (IN `p_documento` VARCHAR(20), IN `p_monto` DECIMAL(10,2), IN `p_metodo_pago` VARCHAR(50))   BEGIN
    INSERT INTO pagos (documento, monto, metodo_pago)
    VALUES (p_documento, p_monto, p_metodo_pago);
    
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
(5, '123456789', '2025-05-28', '15000.00', 'Transferencia'),
(6, '23456789', '2025-05-29', '20000.00', 'Efectivo'),
(8, '34567890', '2025-06-06', '15000.00', 'Efectivo'),
(9, '78979845123312', '2025-06-06', '15000.00', 'Efectivo'),
(10, '7896312456789', '2025-06-06', '13333.00', 'Efectivo'),
(11, '789879645', '2025-06-06', '45000.00', 'Efectivo');

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
(1, 'Juan Pérez', '12345678', '2023-01-15', 'activo', 'no socio', 0),
(2, 'María González', '87654321', '2024-03-10', 'activo', 'socio', 0),
(3, 'Carlos López', '23456789', '2022-07-25', 'activo', 'socio', 0),
(4, 'Ana Rodríguez', '34567890', '2025-01-01', 'activo', 'socio', 0),
(5, 'Pedro Ramírez', '56789012', '2023-09-30', 'inactivo', 'socio', 0),
(13, 'franquito', '333333333', '2025-05-28', 'inactivo', 'socio', 0),
(14, '33366', 'franquito', '2025-05-28', 'inactivo', 'socio', 0),
(15, 'Franquito lala', '123456789', '2025-05-28', 'activo', 'socio', 0),
(16, 'franquete', '3640085555', '2025-05-29', 'inactivo', 'socio', 0),
(17, 'fraaaaaaaaaaa', '123123123', '2025-05-29', 'inactivo', 'socio', 0),
(18, 'Juan Test', '11223344', '2025-05-29', 'inactivo', 'socio', 0),
(20, 'Juan agustin', '111111111', '2025-05-29', 'inactivo', 'socio', 0),
(21, 'Juan roman', '11111', '2025-05-29', 'inactivo', 'socio', 0),
(22, '1233f', '12334', '2025-05-29', 'inactivo', 'socio', 0),
(23, 'asdajad', '12345', '2025-05-29', 'inactivo', 'socio', 0),
(24, 'juancho', '123451', '2025-05-29', 'inactivo', 'socio', 0),
(25, 'Roman', '123456', '2025-05-29', 'inactivo', 'no socio', 0),
(26, 'roman', '123456781', '2025-05-29', 'inactivo', 'no socio', 0),
(27, 'roman', '1234567811', '2025-05-29', 'inactivo', 'no socio', 0),
(28, 'fraaaaaaa', '33333333333333', '2025-06-05', 'inactivo', 'socio', 0),
(29, 'ffffffffffffffffffffffff', '33333333333333333333', '2025-06-05', 'inactivo', 'socio', 0),
(30, 'aaaaaaaaaa', '1111111111111111', '2025-06-05', 'inactivo', 'socio', 0),
(31, 'qqqqqqqqqqqqqqqq', '22222222222222222222', '2025-06-05', 'inactivo', 'socio', 1),
(32, 'aaaaaaaaaaaaaaa', '55555555555', '2025-06-05', 'inactivo', 'socio', 0),
(33, 'adsaddsasad', '5665445665', '2025-06-06', 'inactivo', 'socio', 0),
(34, 'asdsddsasad', '44667989879', '2025-06-06', 'inactivo', 'socio', 1),
(35, 'adsdadasdasd', '798798987987789', '2025-06-06', 'inactivo', '', 0),
(36, 'asdasdasd', '789987987879879987', '2025-06-06', 'inactivo', '', 0),
(37, 'dasdasda', '364445464478789', '2025-06-06', 'inactivo', '', 0),
(38, 'asdasdasd', '4561313245', '2025-06-06', 'inactivo', '', 0),
(39, 'asdasdssdadsa', '879879879987', '2025-06-06', 'inactivo', 'socio', 0),
(40, 'adssadsdasadsad', '78989789787987978979', '2025-06-06', 'inactivo', '', 0),
(41, 'dasdasdasd', '78978978978979898787', '2025-06-06', 'inactivo', '', 0),
(42, 'asdsadsa', '31232123321231', '2025-06-06', 'inactivo', 'socio', 0),
(43, 'wqeasasdzxc', '454357577', '2025-06-06', 'inactivo', 'no socio', 0),
(44, 'asdaszzxc', '1323466541132', '2025-06-06', 'inactivo', '', 0),
(45, 'asdsaddsadsa', '1322123123123', '2025-06-06', 'inactivo', 'socio', 0),
(46, 'dasdsads', '213123132312', '2025-06-06', 'inactivo', 'socio', 0),
(47, 'adsdassda', '7889787998644', '2025-06-06', 'inactivo', 'no socio', 0),
(48, 'qewwqer', '331231213123123', '2025-06-06', 'inactivo', 'socio', 1),
(49, 'dasdasd', '78979845123312', '2025-06-06', 'activo', 'no socio', 0),
(50, 'daadswqe', '7896312456789', '2025-06-06', 'activo', 'no socio', 0),
(51, 'saddsasda', '1123132136', '2025-06-06', 'activo', 'socio', 1),
(52, 'sadasd', '789879645', '2025-06-06', 'activo', 'no socio', 0);

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de la tabla `personas`
--
ALTER TABLE `personas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=53;

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
