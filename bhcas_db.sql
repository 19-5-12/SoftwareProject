-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 22, 2024 at 07:18 AM
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

-- --------------------------------------------------------

--
-- Table structure for table `immunization`
--

CREATE TABLE `immunization` (
  `id` int(11) NOT NULL,
  `anti_rabies` int(11) NOT NULL,
  `polio` int(11) NOT NULL,
  `hepatitis` int(11) NOT NULL,
  `influenza` int(11) NOT NULL,
  `tetanus` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `medication`
--

CREATE TABLE `medication` (
  `id` int(11) NOT NULL,
  `prescription_image` blob DEFAULT NULL,
  `allergies` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `med_services`
--

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

CREATE TABLE `resident_form` (
  `id` int(11) NOT NULL,
  `res_name` varchar(100) DEFAULT NULL,
  `address` varchar(50) DEFAULT NULL,
  `pref_date` date DEFAULT NULL,
  `pref_time` enum('8:00 am','9:00 am','10:00 am','11:00 am','12:00 pm','1:00 pm','2:00 pm','3:00 pm','4:00 pm','5:00 pm') DEFAULT NULL,
  `bio_sex` enum('male','female','','') DEFAULT NULL,
  `age` int(100) DEFAULT NULL,
  `mobile_no` varchar(100) DEFAULT NULL,
  `med_services_id` int(11) NOT NULL,
  `valid_id` blob DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `staff_login`
--

CREATE TABLE `staff_login` (
  `id` int(11) NOT NULL,
  `user` varchar(100) DEFAULT NULL,
  `pass` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `staff_profile`
--

CREATE TABLE `staff_profile` (
  `id` int(11) NOT NULL,
  `staff_name` varchar(100) NOT NULL,
  `staff_birth` date NOT NULL,
  `staff_email` varchar(100) NOT NULL,
  `staff_role_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `staff_role`
--

CREATE TABLE `staff_role` (
  `id` int(11) NOT NULL,
  `doctor_id` int(11) NOT NULL,
  `nurse_id` int(11) NOT NULL,
  `med_assistant_id` int(11) NOT NULL,
  `manager_id` int(11) NOT NULL,
  `receptonist_id` int(11) NOT NULL,
  `staff_login_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `vitamin`
--

CREATE TABLE `vitamin` (
  `id` int(11) NOT NULL,
  `vitamin_name` varchar(50) DEFAULT NULL,
  `quantity` int(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `immunization`
--
ALTER TABLE `immunization`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `medication`
--
ALTER TABLE `medication`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `med_services`
--
ALTER TABLE `med_services`
  ADD PRIMARY KEY (`id`),
  ADD KEY `immunization` (`immunization`),
  ADD KEY `medication` (`medication`),
  ADD KEY `vitamin` (`vitamin`);

--
-- Indexes for table `resident_form`
--
ALTER TABLE `resident_form`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `staff_login`
--
ALTER TABLE `staff_login`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `staff_profile`
--
ALTER TABLE `staff_profile`
  ADD KEY `staff_role_id` (`staff_role_id`);

--
-- Indexes for table `staff_role`
--
ALTER TABLE `staff_role`
  ADD PRIMARY KEY (`id`),
  ADD KEY `doctor_id` (`doctor_id`),
  ADD KEY `manager_id` (`manager_id`),
  ADD KEY `med_assistant_id` (`med_assistant_id`),
  ADD KEY `nurse_id` (`nurse_id`),
  ADD KEY `receptonist_id` (`receptonist_id`),
  ADD KEY `staff_login_id` (`staff_login_id`);

--
-- Indexes for table `vitamin`
--
ALTER TABLE `vitamin`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `immunization`
--
ALTER TABLE `immunization`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `medication`
--
ALTER TABLE `medication`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

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
-- AUTO_INCREMENT for table `vitamin`
--
ALTER TABLE `vitamin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `med_services`
--
ALTER TABLE `med_services`
  ADD CONSTRAINT `med_services_ibfk_1` FOREIGN KEY (`immunization`) REFERENCES `immunization` (`id`),
  ADD CONSTRAINT `med_services_ibfk_2` FOREIGN KEY (`medication`) REFERENCES `medication` (`id`),
  ADD CONSTRAINT `med_services_ibfk_3` FOREIGN KEY (`vitamin`) REFERENCES `vitamin` (`id`);

--
-- Constraints for table `resident_form`
--
ALTER TABLE `resident_form`
  ADD CONSTRAINT `resident_form_ibfk_1` FOREIGN KEY (`med_services_id`) REFERENCES `med_services` (`id`);

--
-- Constraints for table `staff_profile`
--
ALTER TABLE `staff_profile`
  ADD CONSTRAINT `staff_profile_ibfk_1` FOREIGN KEY (`staff_role_id`) REFERENCES `staff_role` (`id`);

--
-- Constraints for table `staff_role`
--
ALTER TABLE `staff_role`
  ADD CONSTRAINT `staff_role_ibfk_1` FOREIGN KEY (`doctor_id`) REFERENCES `staff_login` (`id`),
  ADD CONSTRAINT `staff_role_ibfk_2` FOREIGN KEY (`manager_id`) REFERENCES `staff_login` (`id`),
  ADD CONSTRAINT `staff_role_ibfk_3` FOREIGN KEY (`med_assistant_id`) REFERENCES `staff_login` (`id`),
  ADD CONSTRAINT `staff_role_ibfk_4` FOREIGN KEY (`nurse_id`) REFERENCES `staff_login` (`id`),
  ADD CONSTRAINT `staff_role_ibfk_5` FOREIGN KEY (`receptonist_id`) REFERENCES `staff_login` (`id`),
  ADD CONSTRAINT `staff_role_ibfk_6` FOREIGN KEY (`staff_login_id`) REFERENCES `staff_login` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
