-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 29, 2018 at 04:50 AM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `karyadipa_payroll`
--

-- --------------------------------------------------------

--
-- Table structure for table `databarang`
--

CREATE TABLE `databarang` (
  `kd_barang` varchar(10) NOT NULL,
  `namabarang` varchar(60) NOT NULL,
  `jenisbarang` varchar(60) NOT NULL,
  `jumlah` varchar(60) NOT NULL,
  `catatan` varchar(120) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `databarang`
--

INSERT INTO `databarang` (`kd_barang`, `namabarang`, `jenisbarang`, `jumlah`, `catatan`) VALUES
('4512', 'Udud', 'SDMs', '5', 'Nihil'),
('9868', 'Motor', 'Kendaraan', '5', 'Nihil');

-- --------------------------------------------------------

--
-- Table structure for table `datagaji`
--

CREATE TABLE `datagaji` (
  `kd_gaji` varchar(10) NOT NULL,
  `namapekerja` varchar(60) NOT NULL,
  `kehadiran` varchar(60) NOT NULL,
  `total` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `datagaji`
--

INSERT INTO `datagaji` (`kd_gaji`, `namapekerja`, `kehadiran`, `total`) VALUES
('12452', 'sdd', '7', '350000'),
('7767', 'ter', '13', '650000'),
('87687', 'amama', '7', '350000');

-- --------------------------------------------------------

--
-- Table structure for table `datapekerja`
--

CREATE TABLE `datapekerja` (
  `kd_pekerja` varchar(10) NOT NULL,
  `namapekerja` varchar(60) NOT NULL,
  `noktp` varchar(60) NOT NULL,
  `anak` varchar(60) NOT NULL,
  `istri` varchar(60) NOT NULL,
  `lainya` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `datapekerja`
--

INSERT INTO `datapekerja` (`kd_pekerja`, `namapekerja`, `noktp`, `anak`, `istri`, `lainya`) VALUES
('1234', 'udud', '99987', '99', '2', '0'),
('12452', 'sdd', '675', '1', '1', '1'),
('2223', 'qqwe', '123', '1', '1', '1'),
('7767', 'ter', '3342', '1', '1', '1'),
('87687', 'amama', '87987', '987', '65465', '8798');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `kd_user` varchar(10) NOT NULL,
  `username` varchar(60) NOT NULL,
  `password` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`kd_user`, `username`, `password`) VALUES
('0001', 'admin', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `databarang`
--
ALTER TABLE `databarang`
  ADD PRIMARY KEY (`kd_barang`);

--
-- Indexes for table `datagaji`
--
ALTER TABLE `datagaji`
  ADD PRIMARY KEY (`kd_gaji`);

--
-- Indexes for table `datapekerja`
--
ALTER TABLE `datapekerja`
  ADD PRIMARY KEY (`kd_pekerja`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`kd_user`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
