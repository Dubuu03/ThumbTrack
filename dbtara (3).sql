-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 09, 2024 at 01:53 PM
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
-- Database: `dbtara`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblbookings`
--

CREATE TABLE `tblbookings` (
  `BookingID` int(11) NOT NULL,
  `UserID` int(11) NOT NULL,
  `Place` varchar(50) NOT NULL,
  `Date` varchar(50) NOT NULL,
  `Adult` int(11) NOT NULL,
  `Children` int(11) NOT NULL,
  `Payment` varchar(50) NOT NULL,
  `TotalPrice` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblbookings`
--

INSERT INTO `tblbookings` (`BookingID`, `UserID`, `Place`, `Date`, `Adult`, `Children`, `Payment`, `TotalPrice`) VALUES
(66, 2, 'Siargao', '2024-06-04', 4, 4, 'Banko de Oro', 19760.00),
(71, 2, 'Boracay', '2024-06-01', 1, 0, 'Paymaya', 1079.00),
(72, 125, 'Boracay', '2024-06-01', 1, 2, 'Gcash', 3021.20),
(78, 122, 'Bohol', '2024-06-01', 1, 2, 'Paymaya', 20529.60),
(84, 122, 'Siargao', '2024-11-26', 1, 9, 'Banko de Oro', 23660.00);

-- --------------------------------------------------------

--
-- Table structure for table `tblcars`
--

CREATE TABLE `tblcars` (
  `CarID` int(11) NOT NULL,
  `UserID` int(11) NOT NULL,
  `Pickup` varchar(50) NOT NULL,
  `Dropoff` varchar(50) NOT NULL,
  `Date` varchar(50) NOT NULL,
  `CarType` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblcars`
--

INSERT INTO `tblcars` (`CarID`, `UserID`, `Pickup`, `Dropoff`, `Date`, `CarType`) VALUES
(66, 122, 'Mayon Volcano', '', '2024-06-25', '4-seater');

-- --------------------------------------------------------

--
-- Table structure for table `tblhotels`
--

CREATE TABLE `tblhotels` (
  `HotelID` int(11) NOT NULL,
  `UserID` int(11) NOT NULL,
  `Check-in` varchar(50) NOT NULL,
  `Check-out` varchar(50) NOT NULL,
  `RoomType` varchar(50) NOT NULL,
  `Destination` varchar(100) NOT NULL,
  `TotalPrice` decimal(10,2) NOT NULL,
  `Payment` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblhotels`
--

INSERT INTO `tblhotels` (`HotelID`, `UserID`, `Check-in`, `Check-out`, `RoomType`, `Destination`, `TotalPrice`, `Payment`) VALUES
(96, 123, '2024-06-14', '2024-06-28', 'Family', 'City Center Hotel with Rooftop Pool', 112000.00, 'PayMaya'),
(97, 122, '2024-05-30', '2024-06-14', 'Single', 'City Center Hotel with Rooftop Pool', 112500.00, 'GCash');

-- --------------------------------------------------------

--
-- Table structure for table `tblratings`
--

CREATE TABLE `tblratings` (
  `RatingID` int(11) NOT NULL,
  `UserID` int(11) NOT NULL,
  `HotelName` varchar(100) NOT NULL,
  `Stars` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblratings`
--

INSERT INTO `tblratings` (`RatingID`, `UserID`, `HotelName`, `Stars`) VALUES
(35, 122, 'Boutique Hotel with Garden View', 4),
(36, 122, 'Luxury Beachfront Hotel with Pool', 3),
(44, 123, 'Luxury Beachfront Hotel with Pool', 5),
(45, 123, 'Historical Hotel in the Heart of Manila', 5),
(46, 123, 'Historical Hotel in the Heart of Manila', 1),
(47, 123, 'Luxury Beachfront Hotel with Pool', 5),
(48, 123, 'Beach Resort with Private Villas', 4),
(49, 123, 'Beach Resort with Private Villas', 2);

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE `tbluser` (
  `UserID` int(11) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `AccessLevel` varchar(50) NOT NULL,
  `UserImage` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbluser`
--

INSERT INTO `tbluser` (`UserID`, `LastName`, `FirstName`, `Email`, `Password`, `AccessLevel`, `UserImage`) VALUES
(122, 'Admin', 'Trial', 'Admin', '$2y$10$gpQssA1IGcU6ls5cJuzlv.dgqNqfgeSH6cwjg6ADnACFiY1PNz0iO', 'Admin', 'user-images/luffyy.jpg'),
(123, 'User', 'Trial', 'User', '$2y$10$Msgog3orKT4yY2eY3g8TZOW1sSskSIZX75fTF9AfjXLz8occy0De.', 'User', 'user-images/default.png'),
(128, 'Narciso', 'Drix', 'narcisodrix@gmail.com', '$2y$10$Yk8DmcfRNzHoPsdzWu0Phu7I6jNP7xgztojRIILwjz8Cs/0bmABQe', 'User', 'user-images/zoroo.jpg'),
(130, 'Abinoja', 'Mechelle', 'abinojamechelle@gmail.com', '$2y$10$q4HP.1PCTZPrn1Vplo1bte1AA4Dy0pDoUaGUPu2qIvV4aK8gihVg6', 'Admin', 'user-images/robin.jpg'),
(131, 'Ongkiko', 'Patrick', 'pat@gmail.com', '$2y$10$hFPlkEJoDXTNiF86rucevOs3XQklRXU8hPWTELGg2BBVqiVmW/hU2', 'User', 'user-images/chopper.jpg'),
(132, 'Fabia', 'Jestin', 'jestin@gmail.com', '$2y$10$ao5dwzWmh2zHiZ7q5X9Yfuy4zFddhS8fhbhTqZlFjYUG0jyc3rncq', 'User', 'user-images/rimuru.jpg'),
(133, 'Domingo', 'Kaezele', 'kae@gmail.com', '$2y$10$y7qHRv8l3jT6MctFd1N/7OUyF48gcYTEfa6p.VGxQdhAIipYmPlFi', 'User', 'user-images/nami.png'),
(142, 'Narciso', 'Drix', '23@gmai', '$2y$10$ZrEqC8A6XqgAgBpyMTUQkO4Rtz.9WMNFFiGk8LKaU38jklRPjK6yC', 'User', 'user-images/default.png');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblbookings`
--
ALTER TABLE `tblbookings`
  ADD PRIMARY KEY (`BookingID`);

--
-- Indexes for table `tblcars`
--
ALTER TABLE `tblcars`
  ADD PRIMARY KEY (`CarID`);

--
-- Indexes for table `tblhotels`
--
ALTER TABLE `tblhotels`
  ADD PRIMARY KEY (`HotelID`);

--
-- Indexes for table `tblratings`
--
ALTER TABLE `tblratings`
  ADD PRIMARY KEY (`RatingID`);

--
-- Indexes for table `tbluser`
--
ALTER TABLE `tbluser`
  ADD PRIMARY KEY (`UserID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblbookings`
--
ALTER TABLE `tblbookings`
  MODIFY `BookingID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=90;

--
-- AUTO_INCREMENT for table `tblcars`
--
ALTER TABLE `tblcars`
  MODIFY `CarID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=67;

--
-- AUTO_INCREMENT for table `tblhotels`
--
ALTER TABLE `tblhotels`
  MODIFY `HotelID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=99;

--
-- AUTO_INCREMENT for table `tblratings`
--
ALTER TABLE `tblratings`
  MODIFY `RatingID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;

--
-- AUTO_INCREMENT for table `tbluser`
--
ALTER TABLE `tbluser`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=143;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
