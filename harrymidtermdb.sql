-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 18, 2023 at 06:21 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `harrymidtermdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `accountingstaff`
--

CREATE TABLE `accountingstaff` (
  `AccountingStaffID` int(11) NOT NULL,
  `Username` varchar(250) NOT NULL,
  `Password` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `accountingstaff`
--

INSERT INTO `accountingstaff` (`AccountingStaffID`, `Username`, `Password`) VALUES
(1, 'CRMC', '123');

-- --------------------------------------------------------

--
-- Table structure for table `addloanrecords`
--

CREATE TABLE `addloanrecords` (
  `addloanrecordID` int(11) NOT NULL,
  `LastName` varchar(250) NOT NULL,
  `FirstName` varchar(250) NOT NULL,
  `Date` varchar(250) NOT NULL,
  `PrincipalAmount` int(250) NOT NULL,
  `AnnualInterestRate` double NOT NULL,
  `LoanTermMonths` varchar(250) DEFAULT NULL,
  `LoanTermDays` varchar(250) DEFAULT NULL,
  `PaymentMonthsDays` double DEFAULT NULL,
  `TotalInterest` double DEFAULT NULL,
  `TotalAmount` double DEFAULT NULL,
  `SalaryLeft` double DEFAULT NULL,
  `Payment` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `addloanrecords`
--

INSERT INTO `addloanrecords` (`addloanrecordID`, `LastName`, `FirstName`, `Date`, `PrincipalAmount`, `AnnualInterestRate`, `LoanTermMonths`, `LoanTermDays`, `PaymentMonthsDays`, `TotalInterest`, `TotalAmount`, `SalaryLeft`, `Payment`) VALUES
(1, 'Dagooc', 'John Harry', '2023-11-01', 3000, 0.04, NULL, '7', NULL, NULL, NULL, 0, NULL),
(38, 'Pianar', 'Harry', '2013-09-29', 3000, 0.03, '3', NULL, NULL, NULL, NULL, 69, NULL),
(39, 'Pianar', 'Harry', '2013-09-29', 3000, 0.03, '3', NULL, 1005, 15.01, 3015.01, 0, NULL),
(40, 'Diaz', 'Denzel Wayne', '2023-12-20', 3000, 0.03, '3', NULL, NULL, NULL, NULL, 0, NULL),
(41, 'Diaz', 'Denzel Wayne', '2023-12-20', 3000, 0.03, '3', NULL, 1005, 15.01, 3015.01, 0, NULL),
(43, 'Diaz', 'Denzel Wayne', '2023-12-07', 5000, 0.03, '5', NULL, 1007.51, 37.56, 5037.56, NULL, NULL),
(44, 'Diaz', 'Denzel Wayne', '2023-12-07', 5000, 0.03, '5', NULL, NULL, NULL, NULL, NULL, NULL),
(45, 'Pianar', 'Harry', '2023-12-08', 18000, 0.03, '3', NULL, 6030.02, 90.07, 18090.07, NULL, NULL),
(46, 'Pianar', 'Harry', '2023-12-08', 18000, 0.03, '3', NULL, NULL, NULL, NULL, NULL, NULL),
(47, 'Regala', 'Kerrence Troy', '2023-12-07', 18000, 0.03, '3', NULL, 6030.02, 90.07, 18090.07, NULL, NULL),
(48, 'Regala', 'Kerrence Troy', '2023-12-07', 18000, 0.03, '3', NULL, NULL, NULL, NULL, NULL, NULL),
(49, 'Inting', 'John Rallen', '2023-12-07', 3000, 0.03, '3', NULL, 1005, 15.01, 3015.01, 8995, NULL),
(50, 'Inting', 'John Rallen', '2023-12-07', 3000, 0.03, '3', NULL, NULL, NULL, NULL, NULL, NULL),
(51, 'Diaz', 'Denzel Wayne', '2023-12-13', 3000, 0.03, '5', NULL, NULL, NULL, NULL, NULL, NULL),
(52, 'Diaz', 'Denzel Wayne', '2023-12-13', 3000, 0.03, '5', NULL, 604.51, 22.54, 3022.54, 9395.49, NULL),
(53, 'Viagedor', 'Ademel Mae', '2023-12-13', 5000, 1.25, '12', NULL, NULL, NULL, NULL, NULL, NULL),
(54, 'Viagedor', 'Ademel Mae', '2023-12-13', 5000, 1.25, '12', NULL, 748.86, 3986.31, 8986.31, 9251.14, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `capital`
--

CREATE TABLE `capital` (
  `CapitalID` int(11) NOT NULL,
  `CapitalAmount` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `capital`
--

INSERT INTO `capital` (`CapitalID`, `CapitalAmount`) VALUES
(1, 2000),
(2, 10000);

-- --------------------------------------------------------

--
-- Table structure for table `cart`
--

CREATE TABLE `cart` (
  `CartId` int(11) NOT NULL,
  `ProdId` int(250) NOT NULL,
  `CQuantity` int(250) NOT NULL,
  `CMockTotal` int(250) NOT NULL,
  `CMockStock` int(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `id` int(11) NOT NULL,
  `name` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`id`, `name`) VALUES
(1, 'Devices'),
(8, 'Educational Supply'),
(9, 'Clothes Brand'),
(11, 'Dessert'),
(16, 'Soap'),
(18, 'Drinks'),
(21, 'John');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `LoginID` int(11) NOT NULL,
  `Username` varchar(250) NOT NULL,
  `Password` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`LoginID`, `Username`, `Password`) VALUES
(1, 'John Harry Dagooc', '12345');

-- --------------------------------------------------------

--
-- Table structure for table `newborrower`
--

CREATE TABLE `newborrower` (
  `NewBorrowerID` int(11) NOT NULL,
  `LastName` varchar(250) NOT NULL,
  `FirstName` varchar(250) NOT NULL,
  `MiddleName` varchar(250) NOT NULL,
  `BirthDate` varchar(250) NOT NULL,
  `BirthPlace` varchar(250) NOT NULL,
  `Sex` varchar(250) NOT NULL,
  `City` varchar(250) NOT NULL,
  `Province` varchar(250) NOT NULL,
  `ZipCode` int(250) NOT NULL,
  `Nationality` varchar(250) NOT NULL,
  `MaritalStatus` varchar(250) NOT NULL,
  `Occupation` varchar(250) NOT NULL,
  `Salary` int(250) NOT NULL,
  `Capital` double NOT NULL,
  `Username` varchar(250) NOT NULL,
  `Password` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `newborrower`
--

INSERT INTO `newborrower` (`NewBorrowerID`, `LastName`, `FirstName`, `MiddleName`, `BirthDate`, `BirthPlace`, `Sex`, `City`, `Province`, `ZipCode`, `Nationality`, `MaritalStatus`, `Occupation`, `Salary`, `Capital`, `Username`, `Password`) VALUES
(28, 'Diaz', 'Denzel Wayne', 'Paclipan', '2023-12-06', 'Pamintao', 'Male', 'Bogo', 'Cebu', 6010, 'Filipino', 'Single', 'Student', 10000, 0, 'Denz', '123'),
(29, 'Pianar', 'Harry', 'Dagooc', '2001-09-29', 'Dakit', 'Male', 'Bogo', 'Cebu', 6010, 'Filipino', 'Single', 'Student', 20000, 0, 'John', '123'),
(32, 'Viagedor', 'Ademel Mae', 'Verdida', '1981-02-21', 'Sudlonon', 'Female', 'Bogo', 'Cebu', 6010, 'Filipino', 'Single', 'Teller', 10000, 20000, 'Ad', 'mel');

-- --------------------------------------------------------

--
-- Table structure for table `orderdetail`
--

CREATE TABLE `orderdetail` (
  `OrderDetailsId` int(11) NOT NULL,
  `OrderId` int(250) NOT NULL,
  `ProductId` int(250) NOT NULL,
  `Quantity` int(250) NOT NULL,
  `ProductTotal` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `orderdetail`
--

INSERT INTO `orderdetail` (`OrderDetailsId`, `OrderId`, `ProductId`, `Quantity`, `ProductTotal`) VALUES
(1, 1, 13, 1, '499'),
(2, 2, 13, 1, '499'),
(3, 3, 13, 1, '499'),
(4, 4, 13, 2, '998'),
(5, 6, 11, 1, '0'),
(6, 6, 12, 4, '3196'),
(7, 6, 3, 1, '799'),
(8, 6, 13, 5, '2495'),
(9, 6, 11, 1, '0'),
(10, 6, 12, 4, '3196'),
(11, 6, 3, 1, '799'),
(12, 6, 13, 5, '2495'),
(13, 7, 13, 494, '246506'),
(14, 8, 12, 1, '799'),
(15, 9, 12, 1, '799'),
(16, 10, 15, 1, '50'),
(17, 11, 15, 2, '100'),
(18, 12, 12, 1, '799'),
(19, 13, 12, 1, '799'),
(20, 14, 13, 1, '499'),
(21, 15, 13, 1, '499'),
(22, 16, 13, 1, '499'),
(23, 17, 13, 1, '499'),
(24, 18, 13, 1, '499'),
(25, 19, 12, 1, '799'),
(26, 20, 15, 3, '150'),
(27, 21, 12, 1, '799'),
(28, 22, 12, 3, '2397'),
(29, 23, 12, 2, '1598'),
(30, 24, 12, 1, '799'),
(31, 25, 12, 1, '799'),
(32, 26, 12, 1, '799'),
(33, 27, 12, 1, '799'),
(34, 28, 12, 1, '799'),
(35, 29, 12, 1, '799'),
(36, 30, 12, 1, '799'),
(37, 31, 12, 1, '799'),
(38, 32, 12, 2, '1598'),
(39, 33, 12, 2, '1598'),
(40, 34, 12, 2, '1598'),
(41, 35, 12, 1, '799'),
(42, 36, 12, 1, '799'),
(43, 36, 11, 2, '28');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `OrderId` int(11) NOT NULL,
  `SubTotal` varchar(250) NOT NULL,
  `DiscountPercent` varchar(250) NOT NULL,
  `Deduction` varchar(250) NOT NULL,
  `TotalAmount` varchar(250) NOT NULL,
  `PaidAmount` varchar(250) NOT NULL,
  `Sukli` varchar(250) NOT NULL,
  `Datepurchased` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`OrderId`, `SubTotal`, `DiscountPercent`, `Deduction`, `TotalAmount`, `PaidAmount`, `Sukli`, `Datepurchased`) VALUES
(1, '499', '20', '99.8', '399.2', '500', '100.80000000000001', '8/18/2023, 11:40:53 AM'),
(2, '499', '10', '49.9', '449.1', '600', '150.89999999999998', '8/24/2023, 10:37:56 AM'),
(3, '499', '12', '59.88', '439.12', '500', '60.879999999999995', '9/7/2023, 12:17:52 PM'),
(4, '998', '0', '0', '998', '1000', '2', '9/13/2023, 1:28:19 PM'),
(5, '6490', '20', '1298', '5192', '6000', '808', '10/4/2023, 10:46:29 AM'),
(6, '6490', '20', '1298', '5192', '6000', '808', '10/4/2023, 10:46:29 AM'),
(7, '246506', '10', '24650.6', '221855.4', '1000000', '778144.6', '10/17/2023, 9:12:06 PM'),
(8, '799', '20', '159.8', '639.2', '700', '60.799999999999955', '10/22/2023, 10:01:23 AM'),
(9, '799', '10', '79.9', '719.1', '800', '80.89999999999998', '10/22/2023, 10:03:22 AM'),
(10, '50', '10', '5', '45', '100', '55', '10/22/2023, 10:04:11 AM'),
(11, '100', '10', '10', '90', '100', '10', '10/22/2023, 10:06:56 AM'),
(12, '799', '50', '399.5', '399.5', '500', '100.5', '10/22/2023, 10:07:54 AM'),
(13, '799', '10', '79.9', '719.1', '800', '80.89999999999998', '10/22/2023, 10:11:05 AM'),
(14, '499', '10', '49.9', '449.1', '599', '149.89999999999998', '10/22/2023, 10:12:26 AM'),
(15, '499', '10', '49.9', '449.1', '500', '50.89999999999998', '10/22/2023, 10:13:02 AM'),
(16, '499', '10', '49.9', '449.1', '500', '50.89999999999998', '10/22/2023, 10:13:16 AM'),
(17, '499', '10', '49.9', '449.1', '500', '50.89999999999998', '10/22/2023, 10:13:31 AM'),
(18, '499', '10', '49.9', '449.1', '500', '50.89999999999998', '10/22/2023, 10:15:59 AM'),
(19, '799', '10', '79.9', '719.1', '800', '80.89999999999998', '10/22/2023, 10:16:30 AM'),
(20, '150', '10', '15', '135', '150', '15', '10/22/2023, 10:18:40 AM'),
(21, '799', '50', '399.5', '399.5', '500', '100.5', '10/22/2023, 10:21:04 AM'),
(22, '2397', '20', '479.4', '1917.6', '2000', '82.40000000000009', '10/22/2023, 10:22:46 AM'),
(23, '1598', '20', '319.6', '1278.4', '1500', '221.5999999999999', '10/22/2023, 10:24:14 AM'),
(24, '799', '20', '159.8', '639.2', '700', '60.799999999999955', '10/22/2023, 10:25:05 AM'),
(25, '799', '10', '79.9', '719.1', '800', '80.89999999999998', '10/22/2023, 10:25:41 AM'),
(26, '799', '10', '79.9', '719.1', '800', '80.89999999999998', '10/22/2023, 10:26:24 AM'),
(27, '799', '10', '79.9', '719.1', '800', '80.89999999999998', '10/22/2023, 10:26:47 AM'),
(28, '799', '10', '79.9', '719.1', '800', '80.89999999999998', '10/22/2023, 10:27:14 AM'),
(29, '799', '10', '79.9', '719.1', '800', '80.89999999999998', '10/22/2023, 10:28:05 AM'),
(30, '799', '10', '79.9', '719.1', '800', '80.89999999999998', '10/22/2023, 10:28:32 AM'),
(31, '799', '10', '79.9', '719.1', '800', '80.89999999999998', '10/22/2023, 10:29:24 AM'),
(32, '1598', '10', '159.8', '1438.2', '1500', '61.799999999999955', '10/22/2023, 10:32:19 AM'),
(33, '1598', '10', '159.8', '1438.2', '1555', '116.79999999999995', '10/22/2023, 10:33:47 AM'),
(34, '1598', '10', '159.8', '1438.2', '1550', '111.79999999999995', '10/22/2023, 10:34:11 AM'),
(35, '799', '20', '159.8', '639.2', '700', '60.799999999999955', '10/22/2023, 10:37:03 AM'),
(36, '827', '10', '82.7', '744.3', '1000', '255.70000000000005', '11/22/2023, 1:17:59 PM');

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `id` int(11) NOT NULL,
  `category` varchar(250) NOT NULL,
  `name` varchar(250) NOT NULL,
  `units` varchar(250) NOT NULL,
  `stock` int(11) NOT NULL,
  `price` varchar(250) NOT NULL,
  `status` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`id`, `category`, `name`, `units`, `stock`, `price`, `status`) VALUES
(3, '9', 'Oxygyn', 'Cotton', 499, '799', 'Active'),
(11, '1', 'RealMe', 'UX11', 497, '14,999', 'Active'),
(12, '9', 'Penshoppe', 'Cotton', 470, '799', 'Active'),
(13, '11', 'Goldilocks Cake', 'Black Forest', 0, '499', 'Active'),
(15, '1', 'Harry', 'Hot', 94, '50', 'Active'),
(16, '1', 'iPhone14', 'Black Forest', 12, '499', 'Inactive'),
(17, '21', 'iPhone ', '11 Pro Max', 99, '29000', 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `schedule`
--

CREATE TABLE `schedule` (
  `ScheduleID` int(11) NOT NULL,
  `Date` varchar(250) NOT NULL,
  `Payment` double DEFAULT NULL,
  `TotalAmount` double NOT NULL,
  `Balance` double NOT NULL,
  `addloanrecordID` int(11) NOT NULL,
  `Type` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `schedule`
--

INSERT INTO `schedule` (`ScheduleID`, `Date`, `Payment`, `TotalAmount`, `Balance`, `addloanrecordID`, `Type`) VALUES
(4, '2013-09-29', 5000, 10000, 5000, 39, 'Paid'),
(5, '2013-09-29', 1011.1, 0, 0, 39, 'Paid'),
(6, '2023-12-07', 11, 3015.01, 0, 49, 'Paid'),
(7, '2023-12-08', 11, 18090.07, 0, 45, 'Unpaid'),
(8, '2023-12-20', 1000, 0, 0, 41, 'Paid'),
(9, '2023-12-20', 1000, 0, 0, 41, 'Paid'),
(10, '2023-12-20', 69, 3015.01, 0, 41, 'Paid'),
(11, '2023-12-20', 700, 3015.01, 0, 41, 'Paid'),
(12, '2023-12-20', 1000, 3015.01, -2015.010009765625, 41, 'Paid'),
(13, '2023-12-20', 2000, 3015.01, -1015.0100000000002, 41, 'Paid'),
(14, '2023-12-20', 1000, 3015.01, -2015.0100000000002, 41, 'Paid'),
(15, '2023-12-07', 1000, 5037.56, -4037.5600000000004, 43, 'Paid'),
(16, '2013-09-29', 1000, 3015.01, -2015.0100000000002, 39, 'Paid'),
(17, '2013-09-29', 500, 3015.01, -2515.01, 39, 'Paid'),
(18, '2013-09-29', 500, 3015.01, -3515.01, 39, 'Paid'),
(19, '2023-12-07', 2000, 5037.56, -7037.56, 43, 'Paid'),
(20, '2023-12-07', 1000, 5037.56, -4037.5600000000004, 43, 'Paid'),
(21, '2023-12-13', 2000, 3022.54, -1022.54, 52, 'Paid'),
(22, '2023-12-13', 500, 3022.54, -2522.54, 52, 'Paid'),
(23, '2023-12-13', 500, 3022.54, -2522.54, 52, 'Paid'),
(24, '2023-12-13', 200, 3022.54, -2822.54, 52, 'Paid'),
(25, '2013-09-29', 2000, 3015.01, 0, 39, 'Paid'),
(26, '2013-09-29', 299, 3015.01, 0, 39, 'Paid'),
(27, '2013-09-29', 1000, 3015.01, 0, 39, 'Paid'),
(28, '2013-09-29', 1000, 3015.01, 0, 39, 'Paid'),
(29, '2023-12-07', 1000, 18090.07, 0, 47, 'Paid'),
(30, '2023-12-07', 1000, 18090.07, -17090.07, 47, 'Paid'),
(31, '2013-09-29', 200, 3015.01, -2815.01, 39, 'Paid'),
(32, '2013-09-29', 2222, 3015.01, -793.0100000000002, 39, 'Paid'),
(33, '2013-09-29', 2222, 3015.01, -793.010009765625, 39, 'Paid'),
(34, '2013-09-29', 2000, 3015.01, -1015.010009765625, 39, 'Paid'),
(35, '2023-12-08', 222, 18090.07, -17868.0703125, 45, 'Paid'),
(36, '2023-12-07', 2000, 5037.56, -3037.56005859375, 43, 'Paid'),
(37, '2023-12-07', 5656456, 5037.56, 5651418.5, 43, 'Paid'),
(38, '2013-09-29', 222, 3015.01, -2793.010009765625, 39, 'Paid');

-- --------------------------------------------------------

--
-- Table structure for table `stockhistory`
--

CREATE TABLE `stockhistory` (
  `a_Stock_ID` int(11) NOT NULL,
  `prodID` int(11) NOT NULL,
  `added_stock` int(11) NOT NULL,
  `date` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `stockhistory`
--

INSERT INTO `stockhistory` (`a_Stock_ID`, `prodID`, `added_stock`, `date`) VALUES
(2, 11, 5, '5/1/2023 9:42:12 PM'),
(3, 11, 3, '5/1/2023 10:32:53 PM'),
(4, 7, 2, '5/1/2023 11:24:03 PM'),
(5, 7, 3, '5/2/2023 10:08:49 AM'),
(6, 1, 2, '5/2/2023 10:09:02 AM'),
(7, 11, 2, '5/2/2023 10:35:25 AM'),
(10, 11, 1, '5/2/2023 10:42:24 AM'),
(11, 11, 1, '5/2/2023 10:43:49 AM'),
(12, 11, 1, '5/2/2023 10:44:25 AM'),
(13, 11, 1, '5/2/2023 10:47:37 AM'),
(14, 3, 1, '5/2/2023 11:07:15 AM'),
(15, 12, 1, '9/12/2023, 2:07:30 PM'),
(16, 13, 1, '9/16/2023, 12:37:00 PM'),
(17, 13, 1, '9/19/2023, 10:40:47 AM'),
(18, 13, 1, '9/19/2023, 6:58:15 PM'),
(19, 13, 1, '10/4/2023, 10:42:27 AM');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `user_id` int(11) NOT NULL,
  `first_name` varchar(250) NOT NULL,
  `last_name` tinyint(1) NOT NULL,
  `role` varchar(250) NOT NULL,
  `email` varchar(250) NOT NULL,
  `password` varchar(250) NOT NULL,
  `delete_status` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accountingstaff`
--
ALTER TABLE `accountingstaff`
  ADD PRIMARY KEY (`AccountingStaffID`);

--
-- Indexes for table `addloanrecords`
--
ALTER TABLE `addloanrecords`
  ADD PRIMARY KEY (`addloanrecordID`);

--
-- Indexes for table `capital`
--
ALTER TABLE `capital`
  ADD PRIMARY KEY (`CapitalID`);

--
-- Indexes for table `cart`
--
ALTER TABLE `cart`
  ADD PRIMARY KEY (`CartId`);

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`LoginID`);

--
-- Indexes for table `newborrower`
--
ALTER TABLE `newborrower`
  ADD PRIMARY KEY (`NewBorrowerID`);

--
-- Indexes for table `orderdetail`
--
ALTER TABLE `orderdetail`
  ADD PRIMARY KEY (`OrderDetailsId`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`OrderId`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `schedule`
--
ALTER TABLE `schedule`
  ADD PRIMARY KEY (`ScheduleID`);

--
-- Indexes for table `stockhistory`
--
ALTER TABLE `stockhistory`
  ADD PRIMARY KEY (`a_Stock_ID`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accountingstaff`
--
ALTER TABLE `accountingstaff`
  MODIFY `AccountingStaffID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `addloanrecords`
--
ALTER TABLE `addloanrecords`
  MODIFY `addloanrecordID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=55;

--
-- AUTO_INCREMENT for table `capital`
--
ALTER TABLE `capital`
  MODIFY `CapitalID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `cart`
--
ALTER TABLE `cart`
  MODIFY `CartId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- AUTO_INCREMENT for table `category`
--
ALTER TABLE `category`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `LoginID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `newborrower`
--
ALTER TABLE `newborrower`
  MODIFY `NewBorrowerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT for table `orderdetail`
--
ALTER TABLE `orderdetail`
  MODIFY `OrderDetailsId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=44;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `OrderId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `schedule`
--
ALTER TABLE `schedule`
  MODIFY `ScheduleID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- AUTO_INCREMENT for table `stockhistory`
--
ALTER TABLE `stockhistory`
  MODIFY `a_Stock_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
