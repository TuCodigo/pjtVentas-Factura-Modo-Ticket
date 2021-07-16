-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 08-03-2019 a las 18:47:00
-- Versión del servidor: 10.1.21-MariaDB
-- Versión de PHP: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `db_ventas`
--
DROP DATABASE IF EXISTS `db_ventas`;
CREATE DATABASE IF NOT EXISTS `db_ventas` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `db_ventas`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detallaventa`
--

CREATE TABLE `detallaventa` (
  `idDetalleventa` int(11) NOT NULL,
  `idProductofk` int(11) NOT NULL,
  `Cantidad` float NOT NULL,
  `Costo` float NOT NULL,
  `idVentas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `detallaventa`
--

INSERT INTO `detallaventa` (`idDetalleventa`, `idProductofk`, `Cantidad`, `Costo`, `idVentas`) VALUES
(1, 1, 1, 800, 1),
(2, 1, 1, 800, 2),
(3, 1, 2, 800, 3),
(4, 2, 21, 950, 3),
(5, 2, 2, 950, 4),
(6, 2, 3, 950, 5),
(7, 3, 1, 1000, 5),
(8, 3, 1, 1000, 6),
(9, 2, 1, 950, 6),
(10, 2, 1, 950, 7),
(11, 3, 1, 1000, 7),
(12, 1, 2, 800, 8),
(13, 2, 4, 950, 8);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE `producto` (
  `idProducto` int(11) NOT NULL,
  `NombreProducto` varchar(120) NOT NULL,
  `Precio` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`idProducto`, `NombreProducto`, `Precio`) VALUES
(1, 'Pantalon', 800),
(2, 'Camiza', 950),
(3, 'Zapata', 1000);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

CREATE TABLE `ventas` (
  `idVenta` int(11) NOT NULL,
  `Fecha` varchar(25) NOT NULL,
  `Costo` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `ventas`
--

INSERT INTO `ventas` (`idVenta`, `Fecha`, `Costo`) VALUES
(1, '29/12/2018', 800),
(2, '29/12/2018', 800),
(3, '29/12/2018', 21550),
(4, '30/12/2018', 1900),
(5, '30/12/2018', 3850),
(6, '30/12/2018', 1950),
(7, '30/12/2018', 1950),
(8, '30/12/2018', 5400);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `detallaventa`
--
ALTER TABLE `detallaventa`
  ADD PRIMARY KEY (`idDetalleventa`),
  ADD KEY `idProductofk` (`idProductofk`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`idProducto`);

--
-- Indices de la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD PRIMARY KEY (`idVenta`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `detallaventa`
--
ALTER TABLE `detallaventa`
  MODIFY `idDetalleventa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
--
-- AUTO_INCREMENT de la tabla `producto`
--
ALTER TABLE `producto`
  MODIFY `idProducto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `ventas`
--
ALTER TABLE `ventas`
  MODIFY `idVenta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `detallaventa`
--
ALTER TABLE `detallaventa`
  ADD CONSTRAINT `detallaventa_ibfk_1` FOREIGN KEY (`idProductofk`) REFERENCES `producto` (`idProducto`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
