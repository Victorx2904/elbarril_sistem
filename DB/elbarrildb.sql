-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 07-10-2024 a las 04:28:58
-- Versión del servidor: 8.0.39
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `elbarrildb`
--
CREATE DATABASE IF NOT EXISTS `elbarrildb` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `elbarrildb`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `td_cierre`
--

CREATE TABLE `td_cierre` (
  `id_cierre` int NOT NULL,
  `total_cierre` float NOT NULL,
  `fecha_cierre` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `td_facturas`
--

CREATE TABLE `td_facturas` (
  `id_factura` int NOT NULL,
  `n_factura` int NOT NULL,
  `descripcion_orden` varchar(30) DEFAULT NULL,
  `fecha_entrada` date NOT NULL,
  `monto_total` float(18,2) DEFAULT NULL,
  `n_cierre_id` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `td_factura_detalle`
--

CREATE TABLE `td_factura_detalle` (
  `id_factura_detalle` int NOT NULL,
  `id_factura` int NOT NULL,
  `id_producto` int NOT NULL,
  `descripcion_prod` varchar(200) DEFAULT NULL,
  `cantidad_prod` int NOT NULL,
  `monto_prod` float(18,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `td_lista_metodos`
--

CREATE TABLE `td_lista_metodos` (
  `id_metodo` int NOT NULL,
  `nombre_metodo` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `td_moneda`
--

CREATE TABLE `td_moneda` (
  `id_moneda` int NOT NULL,
  `moneda` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `td_moneda`
--

INSERT INTO `td_moneda` (`id_moneda`, `moneda`) VALUES
(1, 'USD'),
(2, 'VES');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `td_pagos`
--

CREATE TABLE `td_pagos` (
  `id_pago` int NOT NULL,
  `id_factura` int NOT NULL,
  `id_metodo_pago` int NOT NULL,
  `id_moneda` int NOT NULL,
  `referancia` int DEFAULT NULL,
  `monto_pagado` float(18,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `td_productos`
--

CREATE TABLE `td_productos` (
  `id_producto` int NOT NULL,
  `codigo_prod` int NOT NULL,
  `nombre_prod` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `descripcion_prod` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `precio_prod` float(18,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `td_cierre`
--
ALTER TABLE `td_cierre`
  ADD PRIMARY KEY (`id_cierre`);

--
-- Indices de la tabla `td_facturas`
--
ALTER TABLE `td_facturas`
  ADD PRIMARY KEY (`id_factura`),
  ADD KEY `n_cierre_id` (`n_cierre_id`);

--
-- Indices de la tabla `td_factura_detalle`
--
ALTER TABLE `td_factura_detalle`
  ADD PRIMARY KEY (`id_factura_detalle`),
  ADD KEY `id_producto` (`id_producto`),
  ADD KEY `id_factura` (`id_factura`);

--
-- Indices de la tabla `td_lista_metodos`
--
ALTER TABLE `td_lista_metodos`
  ADD PRIMARY KEY (`id_metodo`);

--
-- Indices de la tabla `td_moneda`
--
ALTER TABLE `td_moneda`
  ADD PRIMARY KEY (`id_moneda`);

--
-- Indices de la tabla `td_pagos`
--
ALTER TABLE `td_pagos`
  ADD PRIMARY KEY (`id_pago`),
  ADD KEY `id_moneda` (`id_metodo_pago`),
  ADD KEY `id_factura` (`id_factura`,`id_moneda`),
  ADD KEY `id_moneda_2` (`id_moneda`);

--
-- Indices de la tabla `td_productos`
--
ALTER TABLE `td_productos`
  ADD PRIMARY KEY (`id_producto`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `td_cierre`
--
ALTER TABLE `td_cierre`
  MODIFY `id_cierre` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `td_facturas`
--
ALTER TABLE `td_facturas`
  MODIFY `id_factura` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `td_factura_detalle`
--
ALTER TABLE `td_factura_detalle`
  MODIFY `id_factura_detalle` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `td_lista_metodos`
--
ALTER TABLE `td_lista_metodos`
  MODIFY `id_metodo` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `td_moneda`
--
ALTER TABLE `td_moneda`
  MODIFY `id_moneda` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `td_pagos`
--
ALTER TABLE `td_pagos`
  MODIFY `id_pago` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `td_productos`
--
ALTER TABLE `td_productos`
  MODIFY `id_producto` int NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `td_cierre`
--
ALTER TABLE `td_cierre`
  ADD CONSTRAINT `td_cierre_ibfk_1` FOREIGN KEY (`id_cierre`) REFERENCES `td_facturas` (`n_cierre_id`);

--
-- Filtros para la tabla `td_factura_detalle`
--
ALTER TABLE `td_factura_detalle`
  ADD CONSTRAINT `td_factura_detalle_ibfk_1` FOREIGN KEY (`id_producto`) REFERENCES `td_productos` (`id_producto`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `td_factura_detalle_ibfk_2` FOREIGN KEY (`id_factura`) REFERENCES `td_facturas` (`id_factura`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `td_pagos`
--
ALTER TABLE `td_pagos`
  ADD CONSTRAINT `td_pagos_ibfk_1` FOREIGN KEY (`id_factura`) REFERENCES `td_facturas` (`id_factura`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `td_pagos_ibfk_2` FOREIGN KEY (`id_metodo_pago`) REFERENCES `td_lista_metodos` (`id_metodo`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `td_pagos_ibfk_3` FOREIGN KEY (`id_moneda`) REFERENCES `td_moneda` (`id_moneda`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
