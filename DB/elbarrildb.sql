-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 08-10-2024 a las 18:37:05
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
CREATE DATABASE IF NOT EXISTS `elbarrildb` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `elbarrildb`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `td_categoria`
--

CREATE TABLE `td_categoria` (
  `id_ctg` int NOT NULL,
  `codigo_ctg` int NOT NULL,
  `nombre_ctg` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `fecha_creacion` int DEFAULT NULL,
  `fecha_modificacion` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `td_categoria`
--

INSERT INTO `td_categoria` (`id_ctg`, `codigo_ctg`, `nombre_ctg`, `fecha_creacion`, `fecha_modificacion`) VALUES
(1, 101, 'Cachapas', NULL, NULL),
(2, 102, 'Pepitos', NULL, NULL),
(3, 103, 'Hamburguesas', NULL, NULL),
(4, 104, 'Perros Calientes', NULL, NULL),
(5, 105, 'Bebidas', NULL, NULL),
(6, 106, 'Raciones/Extras', NULL, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `td_cierre`
--

CREATE TABLE `td_cierre` (
  `id_cierre` int NOT NULL,
  `total_cierre` float NOT NULL,
  `fecha_cierre` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `td_facturas`
--

CREATE TABLE `td_facturas` (
  `id_factura` int NOT NULL,
  `n_factura` int NOT NULL,
  `nombre_cliente` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `fecha_entrada` date NOT NULL,
  `monto_total` float(18,2) DEFAULT NULL,
  `id_status` int DEFAULT NULL,
  `n_cierre_id` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `td_facturas`
--

INSERT INTO `td_facturas` (`id_factura`, `n_factura`, `nombre_cliente`, `fecha_entrada`, `monto_total`, `id_status`, `n_cierre_id`) VALUES
(1, 101, 'juan perez', '2024-10-06', 30.00, 1, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `td_lista_metodos`
--

CREATE TABLE `td_lista_metodos` (
  `id_metodo` int NOT NULL,
  `nombre_metodo` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `td_lista_metodos`
--

INSERT INTO `td_lista_metodos` (`id_metodo`, `nombre_metodo`) VALUES
(1, 'Pago Movil'),
(2, 'Transferencia'),
(3, 'Efectivo Dolares'),
(4, 'Punto de Venta'),
(5, 'Efectivo Bolivares'),
(6, 'Credito');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `td_mesas`
--

CREATE TABLE `td_mesas` (
  `id_mesa` int NOT NULL,
  `n_mesa` int NOT NULL,
  `id_empleado` int NOT NULL,
  `n_personas` int NOT NULL,
  `comentario` varchar(100) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `sub_total` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `td_moneda`
--

CREATE TABLE `td_moneda` (
  `id_moneda` int NOT NULL,
  `moneda` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `td_moneda`
--

INSERT INTO `td_moneda` (`id_moneda`, `moneda`) VALUES
(1, 'USD'),
(2, 'VES');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `td_orden`
--

CREATE TABLE `td_orden` (
  `id_orden` int NOT NULL,
  `id_producto` int NOT NULL,
  `id_mesa` int NOT NULL,
  `comentario_prod` int NOT NULL,
  `cantidad_prod` int NOT NULL,
  `monto_prod` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `td_orden_detalle`
--

CREATE TABLE `td_orden_detalle` (
  `id_orden_detalle` int NOT NULL,
  `id_factura` int NOT NULL,
  `id_orden` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `td_pagos`
--

CREATE TABLE `td_pagos` (
  `id_pago` int NOT NULL,
  `id_factura` int NOT NULL,
  `fecha_pago` datetime DEFAULT NULL,
  `id_metodo_pago` int NOT NULL,
  `id_moneda` int NOT NULL,
  `n_ref` int DEFAULT NULL,
  `monto_pagado` float(18,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `td_pagos`
--

INSERT INTO `td_pagos` (`id_pago`, `id_factura`, `fecha_pago`, `id_metodo_pago`, `id_moneda`, `n_ref`, `monto_pagado`) VALUES
(1, 1, '2024-10-06 13:17:46', 3, 1, NULL, 30.00);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `td_productos`
--

CREATE TABLE `td_productos` (
  `id_producto` int NOT NULL,
  `codigo_prod` int NOT NULL,
  `nombre_prod` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `descripcion_prod` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `id_ctg` int NOT NULL,
  `precio_prod` float(18,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `td_productos`
--

INSERT INTO `td_productos` (`id_producto`, `codigo_prod`, `nombre_prod`, `descripcion_prod`, `id_ctg`, `precio_prod`) VALUES
(1, 1010, 'Cachapa Con Queso De Mano', '150g de queso de mano con natilla ', 1, 3.00);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `td_status`
--

CREATE TABLE `td_status` (
  `id_status` int NOT NULL,
  `descripcion` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `td_status`
--

INSERT INTO `td_status` (`id_status`, `descripcion`) VALUES
(1, 'Pagado'),
(2, 'Por Cobrar'),
(3, 'Credito'),
(4, 'Anulado');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `td_tasa`
--

CREATE TABLE `td_tasa` (
  `id_tasa` int NOT NULL,
  `id_moneda` int NOT NULL,
  `tasa` decimal(6,2) NOT NULL,
  `fecha_creacion` datetime NOT NULL,
  `fecha_modificacion` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `td_categoria`
--
ALTER TABLE `td_categoria`
  ADD PRIMARY KEY (`id_ctg`);

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
  ADD KEY `n_cierre_id` (`n_cierre_id`),
  ADD KEY `id_status` (`id_status`);

--
-- Indices de la tabla `td_lista_metodos`
--
ALTER TABLE `td_lista_metodos`
  ADD PRIMARY KEY (`id_metodo`);

--
-- Indices de la tabla `td_mesas`
--
ALTER TABLE `td_mesas`
  ADD PRIMARY KEY (`id_mesa`);

--
-- Indices de la tabla `td_moneda`
--
ALTER TABLE `td_moneda`
  ADD PRIMARY KEY (`id_moneda`);

--
-- Indices de la tabla `td_orden`
--
ALTER TABLE `td_orden`
  ADD PRIMARY KEY (`id_orden`),
  ADD KEY `id_mesa` (`id_mesa`),
  ADD KEY `id_producto` (`id_producto`);

--
-- Indices de la tabla `td_orden_detalle`
--
ALTER TABLE `td_orden_detalle`
  ADD PRIMARY KEY (`id_orden_detalle`),
  ADD KEY `id_factura` (`id_factura`),
  ADD KEY `id_orden` (`id_orden`);

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
  ADD PRIMARY KEY (`id_producto`),
  ADD KEY `id_dpto` (`id_ctg`);

--
-- Indices de la tabla `td_status`
--
ALTER TABLE `td_status`
  ADD PRIMARY KEY (`id_status`);

--
-- Indices de la tabla `td_tasa`
--
ALTER TABLE `td_tasa`
  ADD PRIMARY KEY (`id_tasa`),
  ADD KEY `id_moneda` (`id_moneda`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `td_categoria`
--
ALTER TABLE `td_categoria`
  MODIFY `id_ctg` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `td_cierre`
--
ALTER TABLE `td_cierre`
  MODIFY `id_cierre` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `td_facturas`
--
ALTER TABLE `td_facturas`
  MODIFY `id_factura` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `td_lista_metodos`
--
ALTER TABLE `td_lista_metodos`
  MODIFY `id_metodo` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `td_mesas`
--
ALTER TABLE `td_mesas`
  MODIFY `id_mesa` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `td_moneda`
--
ALTER TABLE `td_moneda`
  MODIFY `id_moneda` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `td_orden`
--
ALTER TABLE `td_orden`
  MODIFY `id_orden` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `td_orden_detalle`
--
ALTER TABLE `td_orden_detalle`
  MODIFY `id_orden_detalle` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `td_pagos`
--
ALTER TABLE `td_pagos`
  MODIFY `id_pago` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `td_productos`
--
ALTER TABLE `td_productos`
  MODIFY `id_producto` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `td_status`
--
ALTER TABLE `td_status`
  MODIFY `id_status` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `td_tasa`
--
ALTER TABLE `td_tasa`
  MODIFY `id_tasa` int NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `td_cierre`
--
ALTER TABLE `td_cierre`
  ADD CONSTRAINT `td_cierre_ibfk_1` FOREIGN KEY (`id_cierre`) REFERENCES `td_facturas` (`n_cierre_id`);

--
-- Filtros para la tabla `td_facturas`
--
ALTER TABLE `td_facturas`
  ADD CONSTRAINT `td_facturas_ibfk_1` FOREIGN KEY (`id_status`) REFERENCES `td_status` (`id_status`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `td_orden`
--
ALTER TABLE `td_orden`
  ADD CONSTRAINT `td_orden_ibfk_1` FOREIGN KEY (`id_mesa`) REFERENCES `td_mesas` (`id_mesa`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `td_orden_ibfk_2` FOREIGN KEY (`id_producto`) REFERENCES `td_productos` (`id_producto`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `td_orden_detalle`
--
ALTER TABLE `td_orden_detalle`
  ADD CONSTRAINT `td_orden_detalle_ibfk_1` FOREIGN KEY (`id_orden`) REFERENCES `td_orden` (`id_orden`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `td_orden_detalle_ibfk_2` FOREIGN KEY (`id_factura`) REFERENCES `td_facturas` (`id_factura`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `td_pagos`
--
ALTER TABLE `td_pagos`
  ADD CONSTRAINT `td_pagos_ibfk_1` FOREIGN KEY (`id_factura`) REFERENCES `td_facturas` (`id_factura`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `td_pagos_ibfk_2` FOREIGN KEY (`id_metodo_pago`) REFERENCES `td_lista_metodos` (`id_metodo`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `td_pagos_ibfk_3` FOREIGN KEY (`id_moneda`) REFERENCES `td_moneda` (`id_moneda`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `td_productos`
--
ALTER TABLE `td_productos`
  ADD CONSTRAINT `td_productos_ibfk_1` FOREIGN KEY (`id_ctg`) REFERENCES `td_categoria` (`id_ctg`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `td_tasa`
--
ALTER TABLE `td_tasa`
  ADD CONSTRAINT `td_tasa_ibfk_1` FOREIGN KEY (`id_moneda`) REFERENCES `td_moneda` (`id_moneda`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
