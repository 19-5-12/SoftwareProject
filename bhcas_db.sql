-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 30, 2024 at 12:11 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bhcas.db`
--
CREATE DATABASE IF NOT EXISTS `bhcas.db` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `bhcas.db`;

-- --------------------------------------------------------

--
-- Table structure for table `med_services`
--

DROP TABLE IF EXISTS `med_services`;
CREATE TABLE `med_services` (
  `id` int(11) NOT NULL,
  `medication` int(11) NOT NULL,
  `vitamin` int(11) NOT NULL,
  `supplement` int(11) NOT NULL,
  `immunization` int(11) NOT NULL,
  `med_assistance` int(11) NOT NULL,
  `nutrition` int(11) NOT NULL,
  `health_ed` int(11) NOT NULL,
  `maternal_id` int(11) NOT NULL,
  `child_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `resident_form`
--

DROP TABLE IF EXISTS `resident_form`;
CREATE TABLE `resident_form` (
  `id` int(11) NOT NULL,
  `res_name` varchar(100) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  `pref_date` date DEFAULT NULL,
  `pref_time` time DEFAULT NULL,
  `bio_sex` varchar(10) DEFAULT NULL,
  `age` int(100) DEFAULT NULL,
  `nationality` varchar(100) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `mobile_no` varchar(100) DEFAULT NULL,
  `med_services_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `staff_login`
--

DROP TABLE IF EXISTS `staff_login`;
CREATE TABLE `staff_login` (
  `id` int(11) NOT NULL,
  `user` varchar(100) DEFAULT NULL,
  `pass` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `staff_role`
--

DROP TABLE IF EXISTS `staff_role`;
CREATE TABLE `staff_role` (
  `id` int(11) NOT NULL,
  `doctor_id` int(11) NOT NULL,
  `nurse_id` int(11) NOT NULL,
  `med_assistant_id` int(11) NOT NULL,
  `manager_id` int(11) NOT NULL,
  `receptonist_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `med_services`
--
ALTER TABLE `med_services`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `resident_form`
--
ALTER TABLE `resident_form`
  ADD PRIMARY KEY (`id`),
  ADD KEY `res_name_id` (`res_name`),
  ADD KEY `resident_form_ibfk_1` (`med_services_id`);

--
-- Indexes for table `staff_login`
--
ALTER TABLE `staff_login`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `staff_role`
--
ALTER TABLE `staff_role`
  ADD PRIMARY KEY (`id`),
  ADD KEY `doctor_id` (`doctor_id`),
  ADD KEY `manager_id` (`manager_id`),
  ADD KEY `med_assistant_id` (`med_assistant_id`),
  ADD KEY `nurse_id` (`nurse_id`),
  ADD KEY `receptonist_id` (`receptonist_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `med_services`
--
ALTER TABLE `med_services`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `resident_form`
--
ALTER TABLE `resident_form`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `staff_role`
--
ALTER TABLE `staff_role`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `resident_form`
--
ALTER TABLE `resident_form`
  ADD CONSTRAINT `resident_form_ibfk_1` FOREIGN KEY (`med_services_id`) REFERENCES `med_services` (`id`);

--
-- Constraints for table `staff_role`
--
ALTER TABLE `staff_role`
  ADD CONSTRAINT `staff_role_ibfk_1` FOREIGN KEY (`doctor_id`) REFERENCES `staff_login` (`id`),
  ADD CONSTRAINT `staff_role_ibfk_2` FOREIGN KEY (`manager_id`) REFERENCES `staff_login` (`id`),
  ADD CONSTRAINT `staff_role_ibfk_3` FOREIGN KEY (`med_assistant_id`) REFERENCES `staff_login` (`id`),
  ADD CONSTRAINT `staff_role_ibfk_4` FOREIGN KEY (`nurse_id`) REFERENCES `staff_login` (`id`),
  ADD CONSTRAINT `staff_role_ibfk_5` FOREIGN KEY (`receptonist_id`) REFERENCES `staff_login` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
