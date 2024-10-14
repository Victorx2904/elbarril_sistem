-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 14, 2024 at 02:34 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `elbarrildb`
--
CREATE DATABASE IF NOT EXISTS `elbarrildb` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `elbarrildb`;

-- --------------------------------------------------------

--
-- Table structure for table `td_categoria`
--

CREATE TABLE `td_categoria` (
  `id_ctg` int(11) NOT NULL,
  `codigo_ctg` int(11) NOT NULL,
  `nombre_ctg` varchar(30) NOT NULL,
  `fecha_creacion` int(11) DEFAULT NULL,
  `fecha_modificacion` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `td_categoria`
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
-- Table structure for table `td_cierre`
--

CREATE TABLE `td_cierre` (
  `id_cierre` int(11) NOT NULL,
  `total_cierre` float NOT NULL,
  `fecha_cierre` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `td_empleados`
--

CREATE TABLE `td_empleados` (
  `id_empleado` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `apellido` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `id_usuario` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `td_lista_metodos`
--

CREATE TABLE `td_lista_metodos` (
  `id_metodo` int(11) NOT NULL,
  `nombre_metodo` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `td_lista_metodos`
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
-- Table structure for table `td_mesas`
--

CREATE TABLE `td_mesas` (
  `id_mesa` int(11) NOT NULL,
  `n_mesa` int(11) NOT NULL,
  `id_empleado` int(11) NOT NULL,
  `n_personas` int(11) NOT NULL,
  `comentario` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `td_moneda`
--

CREATE TABLE `td_moneda` (
  `id_moneda` int(11) NOT NULL,
  `moneda` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `td_moneda`
--

INSERT INTO `td_moneda` (`id_moneda`, `moneda`) VALUES
(1, 'USD'),
(2, 'VES');

-- --------------------------------------------------------

--
-- Table structure for table `td_orden`
--

CREATE TABLE `td_orden` (
  `id_orden` int(11) NOT NULL,
  `n_factura` int(11) NOT NULL,
  `nombre_cliente` varchar(50) DEFAULT NULL,
  `id_mesas` int(11) NOT NULL,
  `id_status` int(11) NOT NULL,
  `id_n_cierre` int(11) DEFAULT NULL,
  `monto_total` decimal(6,2) NOT NULL,
  `fecha_modificacion` datetime DEFAULT NULL,
  `fecha_creacion` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `td_orden_detalle`
--

CREATE TABLE `td_orden_detalle` (
  `id_orden_detalle` int(11) NOT NULL,
  `id_orden` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `comentario_prod` varchar(100) DEFAULT NULL,
  `cantidad_prod` int(11) NOT NULL,
  `monto_prod` decimal(6,2) NOT NULL,
  `fecha_entrada` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `td_pagos`
--

CREATE TABLE `td_pagos` (
  `id_pago` int(11) NOT NULL,
  `id_orden` int(11) NOT NULL,
  `fecha_pago` datetime DEFAULT NULL,
  `id_metodo_pago` int(11) NOT NULL,
  `id_moneda` int(11) NOT NULL,
  `n_ref` int(11) DEFAULT NULL,
  `monto_pagado` float(18,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `td_productos`
--

CREATE TABLE `td_productos` (
  `id_producto` int(11) NOT NULL,
  `codigo_prod` varchar(11) NOT NULL,
  `nombre_prod` varchar(30) NOT NULL,
  `descripcion_prod` varchar(200) DEFAULT NULL,
  `id_ctg` int(11) NOT NULL,
  `precio_prod` float(18,2) NOT NULL,
  `activo` tinyint(1) NOT NULL,
  `fecha_creacion` datetime NOT NULL DEFAULT current_timestamp(),
  `fecha_modificacion` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `td_productos`
--

INSERT INTO `td_productos` (`id_producto`, `codigo_prod`, `nombre_prod`, `descripcion_prod`, `id_ctg`, `precio_prod`, `activo`, `fecha_creacion`, `fecha_modificacion`) VALUES
(5, '0001', 'Plato 1', 'Descripcion Plato 1', 1, 123.00, 1, '2024-10-13 20:12:57', '2024-10-13 20:12:57'),
(6, '0002', 'Plato 2', 'Descripcion Plato 2', 3, 456.00, 1, '2024-10-13 20:12:57', '2024-10-13 20:12:57'),
(7, '0006', 'Plato 13', 'Ejemplo act', 4, 551.00, 1, '2024-10-13 20:12:57', '2024-10-13 20:12:57'),
(8, '0004', 'Plato 11', 'Otra tambien act', 6, 998.00, 1, '2024-10-13 20:12:57', '2024-10-13 20:12:57'),
(9, '0005', 'Plato 10', 'Ejemplo act', 4, 551.00, 1, '2024-10-13 20:12:57', '2024-10-13 20:12:57'),
(10, '000012', 'desde db', 'descripcion db', 1, 123.00, 0, '2024-10-13 20:13:38', '2024-10-13 20:13:38');

-- --------------------------------------------------------

--
-- Table structure for table `td_roll`
--

CREATE TABLE `td_roll` (
  `id_roll` int(11) NOT NULL,
  `roll` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `td_roll`
--

INSERT INTO `td_roll` (`id_roll`, `roll`) VALUES
(1, 'Administrador'),
(2, 'Empleado');

-- --------------------------------------------------------

--
-- Table structure for table `td_status`
--

CREATE TABLE `td_status` (
  `id_status` int(11) NOT NULL,
  `descripcion` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `td_status`
--

INSERT INTO `td_status` (`id_status`, `descripcion`) VALUES
(1, 'Pagado'),
(2, 'Por Cobrar'),
(3, 'Credito'),
(4, 'Anulado');

-- --------------------------------------------------------

--
-- Table structure for table `td_tasa`
--

CREATE TABLE `td_tasa` (
  `id_tasa` int(11) NOT NULL,
  `id_moneda` int(11) NOT NULL,
  `tasa` decimal(6,2) NOT NULL,
  `fecha_creacion` datetime NOT NULL,
  `fecha_modificacion` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `td_usuarios`
--

CREATE TABLE `td_usuarios` (
  `id_usuario` int(11) NOT NULL,
  `user` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `id_roll` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `td_usuarios`
--

INSERT INTO `td_usuarios` (`id_usuario`, `user`, `password`, `id_roll`) VALUES
(1, 'admin', 'admin', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `td_categoria`
--
ALTER TABLE `td_categoria`
  ADD PRIMARY KEY (`id_ctg`);

--
-- Indexes for table `td_cierre`
--
ALTER TABLE `td_cierre`
  ADD PRIMARY KEY (`id_cierre`);

--
-- Indexes for table `td_empleados`
--
ALTER TABLE `td_empleados`
  ADD PRIMARY KEY (`id_empleado`),
  ADD KEY `id_usuario` (`id_usuario`);

--
-- Indexes for table `td_lista_metodos`
--
ALTER TABLE `td_lista_metodos`
  ADD PRIMARY KEY (`id_metodo`);

--
-- Indexes for table `td_mesas`
--
ALTER TABLE `td_mesas`
  ADD PRIMARY KEY (`id_mesa`),
  ADD KEY `id_empleado` (`id_empleado`);

--
-- Indexes for table `td_moneda`
--
ALTER TABLE `td_moneda`
  ADD PRIMARY KEY (`id_moneda`);

--
-- Indexes for table `td_orden`
--
ALTER TABLE `td_orden`
  ADD PRIMARY KEY (`id_orden`),
  ADD KEY `id_status` (`id_status`),
  ADD KEY `id_n_cierre` (`id_n_cierre`),
  ADD KEY `id_mesas` (`id_mesas`);

--
-- Indexes for table `td_orden_detalle`
--
ALTER TABLE `td_orden_detalle`
  ADD PRIMARY KEY (`id_orden_detalle`),
  ADD KEY `id_producto` (`id_producto`),
  ADD KEY `id_orden` (`id_orden`);

--
-- Indexes for table `td_pagos`
--
ALTER TABLE `td_pagos`
  ADD PRIMARY KEY (`id_pago`),
  ADD KEY `id_moneda` (`id_metodo_pago`),
  ADD KEY `id_factura` (`id_orden`,`id_moneda`),
  ADD KEY `id_moneda_2` (`id_moneda`),
  ADD KEY `id_orden` (`id_orden`);

--
-- Indexes for table `td_productos`
--
ALTER TABLE `td_productos`
  ADD PRIMARY KEY (`id_producto`),
  ADD KEY `id_dpto` (`id_ctg`);

--
-- Indexes for table `td_roll`
--
ALTER TABLE `td_roll`
  ADD PRIMARY KEY (`id_roll`);

--
-- Indexes for table `td_status`
--
ALTER TABLE `td_status`
  ADD PRIMARY KEY (`id_status`);

--
-- Indexes for table `td_tasa`
--
ALTER TABLE `td_tasa`
  ADD PRIMARY KEY (`id_tasa`),
  ADD KEY `id_moneda` (`id_moneda`);

--
-- Indexes for table `td_usuarios`
--
ALTER TABLE `td_usuarios`
  ADD PRIMARY KEY (`id_usuario`),
  ADD KEY `id_roll` (`id_roll`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `td_categoria`
--
ALTER TABLE `td_categoria`
  MODIFY `id_ctg` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `td_cierre`
--
ALTER TABLE `td_cierre`
  MODIFY `id_cierre` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `td_empleados`
--
ALTER TABLE `td_empleados`
  MODIFY `id_empleado` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `td_lista_metodos`
--
ALTER TABLE `td_lista_metodos`
  MODIFY `id_metodo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `td_mesas`
--
ALTER TABLE `td_mesas`
  MODIFY `id_mesa` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `td_moneda`
--
ALTER TABLE `td_moneda`
  MODIFY `id_moneda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `td_orden`
--
ALTER TABLE `td_orden`
  MODIFY `id_orden` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `td_orden_detalle`
--
ALTER TABLE `td_orden_detalle`
  MODIFY `id_orden_detalle` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `td_pagos`
--
ALTER TABLE `td_pagos`
  MODIFY `id_pago` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `td_productos`
--
ALTER TABLE `td_productos`
  MODIFY `id_producto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `td_roll`
--
ALTER TABLE `td_roll`
  MODIFY `id_roll` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `td_status`
--
ALTER TABLE `td_status`
  MODIFY `id_status` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `td_tasa`
--
ALTER TABLE `td_tasa`
  MODIFY `id_tasa` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `td_usuarios`
--
ALTER TABLE `td_usuarios`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `td_empleados`
--
ALTER TABLE `td_empleados`
  ADD CONSTRAINT `td_empleados_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `td_usuarios` (`id_usuario`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `td_mesas`
--
ALTER TABLE `td_mesas`
  ADD CONSTRAINT `td_mesas_ibfk_1` FOREIGN KEY (`id_empleado`) REFERENCES `td_empleados` (`id_empleado`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `td_orden`
--
ALTER TABLE `td_orden`
  ADD CONSTRAINT `td_orden_ibfk_3` FOREIGN KEY (`id_n_cierre`) REFERENCES `td_cierre` (`id_cierre`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `td_orden_ibfk_5` FOREIGN KEY (`id_status`) REFERENCES `td_status` (`id_status`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `td_orden_ibfk_6` FOREIGN KEY (`id_mesas`) REFERENCES `td_mesas` (`id_mesa`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `td_orden_detalle`
--
ALTER TABLE `td_orden_detalle`
  ADD CONSTRAINT `td_orden_detalle_ibfk_1` FOREIGN KEY (`id_producto`) REFERENCES `td_productos` (`id_producto`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `td_orden_detalle_ibfk_2` FOREIGN KEY (`id_orden`) REFERENCES `td_orden` (`id_orden`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `td_pagos`
--
ALTER TABLE `td_pagos`
  ADD CONSTRAINT `td_pagos_ibfk_2` FOREIGN KEY (`id_metodo_pago`) REFERENCES `td_lista_metodos` (`id_metodo`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `td_pagos_ibfk_3` FOREIGN KEY (`id_moneda`) REFERENCES `td_moneda` (`id_moneda`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `td_pagos_ibfk_4` FOREIGN KEY (`id_orden`) REFERENCES `td_orden` (`id_orden`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `td_productos`
--
ALTER TABLE `td_productos`
  ADD CONSTRAINT `td_productos_ibfk_1` FOREIGN KEY (`id_ctg`) REFERENCES `td_categoria` (`id_ctg`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `td_tasa`
--
ALTER TABLE `td_tasa`
  ADD CONSTRAINT `td_tasa_ibfk_1` FOREIGN KEY (`id_moneda`) REFERENCES `td_moneda` (`id_moneda`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `td_usuarios`
--
ALTER TABLE `td_usuarios`
  ADD CONSTRAINT `td_usuarios_ibfk_1` FOREIGN KEY (`id_roll`) REFERENCES `td_roll` (`id_roll`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
