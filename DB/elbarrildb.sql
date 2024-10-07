-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 07-10-2024 a las 23:14:39
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `td_pagos`
--

INSERT INTO `td_pagos` (`id_pago`, `id_factura`, `fecha_pago`, `id_metodo_pago`, `id_moneda`, `n_ref`, `monto_pagado`) VALUES
(1, 1, '2024-10-06 13:17:46', 3, 1, NULL, 30.00);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `td_pagos`
--
ALTER TABLE `td_pagos`
  ADD PRIMARY KEY (`id_pago`),
  ADD KEY `id_moneda` (`id_metodo_pago`),
  ADD KEY `id_factura` (`id_factura`,`id_moneda`),
  ADD KEY `id_moneda_2` (`id_moneda`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `td_pagos`
--
ALTER TABLE `td_pagos`
  MODIFY `id_pago` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restricciones para tablas volcadas
--

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
