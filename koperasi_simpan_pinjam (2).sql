-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 07, 2024 at 07:42 AM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `koperasi_simpan_pinjam`
--

-- --------------------------------------------------------

--
-- Table structure for table `anggota`
--

CREATE TABLE `anggota` (
  `id_anggota` int(11) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `alamat` varchar(255) NOT NULL,
  `no_telepon` varchar(15) DEFAULT NULL,
  `tanggal_daftar` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `anggota`
--

INSERT INTO `anggota` (`id_anggota`, `nama`, `alamat`, `no_telepon`, `tanggal_daftar`) VALUES
(1, 'Rolly', 'Unklab', '08079798', '2024-07-18'),
(4, 'budi', 'Airmadidi', '0876786786', '2024-07-18');

-- --------------------------------------------------------

--
-- Table structure for table `pinjaman`
--

CREATE TABLE `pinjaman` (
  `id_pinjaman` int(11) NOT NULL,
  `id_anggota` int(11) NOT NULL,
  `tanggal_transaksi` date NOT NULL,
  `pinjaman` decimal(15,2) NOT NULL,
  `bunga` decimal(5,2) NOT NULL,
  `jangka_waktu` int(11) NOT NULL,
  `total_pinjaman` int(11) NOT NULL,
  `setoran` int(11) NOT NULL,
  `status` enum('aktif','selesai') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pinjaman`
--

INSERT INTO `pinjaman` (`id_pinjaman`, `id_anggota`, `tanggal_transaksi`, `pinjaman`, `bunga`, `jangka_waktu`, `total_pinjaman`, `setoran`, `status`) VALUES
(1, 4, '2024-07-21', '1000000.00', '20.00', 12, 1200000, 100000, 'aktif'),
(23, 4, '2024-06-21', '2000000.00', '20.00', 3, 2100000, 700000, 'aktif');

-- --------------------------------------------------------

--
-- Table structure for table `setoran`
--

CREATE TABLE `setoran` (
  `id_setoran` int(11) NOT NULL,
  `id_pinjaman` int(11) NOT NULL,
  `tgl_setoran` date NOT NULL,
  `setoran` int(11) NOT NULL,
  `denda` int(11) NOT NULL,
  `biaya_admin` int(11) NOT NULL,
  `total_setoran` int(11) NOT NULL,
  `di_setor` int(11) NOT NULL,
  `kekurangan` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `setoran`
--

INSERT INTO `setoran` (`id_setoran`, `id_pinjaman`, `tgl_setoran`, `setoran`, `denda`, `biaya_admin`, `total_setoran`, `di_setor`, `kekurangan`) VALUES
(8, 23, '2024-07-21', 700000, 0, 5000, 705000, 700000, 5000),
(9, 23, '2024-07-21', 700000, 0, 5000, 710000, 700000, 10000),
(10, 23, '2024-07-21', 700000, 0, 5000, 710000, 705000, 5000),
(11, 23, '2024-07-21', 700000, 0, 5000, 710000, 5000, 705000),
(12, 23, '2024-08-05', 700000, 0, 5000, 710000, 0, 710000),
(13, 23, '2024-08-05', 700000, 0, 5000, 710000, 0, 710000);

-- --------------------------------------------------------

--
-- Table structure for table `simpanan`
--

CREATE TABLE `simpanan` (
  `id_simpanan` int(11) NOT NULL,
  `id_anggota` int(11) NOT NULL,
  `tanggal_transaksi` date NOT NULL,
  `simpanan` int(11) DEFAULT NULL,
  `pengambilan` int(11) DEFAULT NULL,
  `status` enum('aktif','tidak') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `simpanan`
--

INSERT INTO `simpanan` (`id_simpanan`, `id_anggota`, `tanggal_transaksi`, `simpanan`, `pengambilan`, `status`) VALUES
(1, 4, '2024-07-20', 1000000, 0, 'tidak'),
(2, 4, '2024-07-20', 500000, 0, 'tidak'),
(5, 1, '2024-07-20', 1000000, 0, 'aktif'),
(9, 4, '2024-07-28', 0, 1725000, 'tidak');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user`
--

CREATE TABLE `tbl_user` (
  `id_user` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `role` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_user`
--

INSERT INTO `tbl_user` (`id_user`, `username`, `password`, `role`) VALUES
(1, 'admin', 'admin', 1);

-- --------------------------------------------------------

--
-- Table structure for table `transaksi`
--

CREATE TABLE `transaksi` (
  `id_transaksi` int(11) NOT NULL,
  `id_anggota` int(11) NOT NULL,
  `tanggal_transaksi` date NOT NULL,
  `jenis_transaksi` varchar(50) NOT NULL,
  `jumlah` decimal(15,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `anggota`
--
ALTER TABLE `anggota`
  ADD PRIMARY KEY (`id_anggota`);

--
-- Indexes for table `pinjaman`
--
ALTER TABLE `pinjaman`
  ADD PRIMARY KEY (`id_pinjaman`),
  ADD KEY `id_anggota` (`id_anggota`);

--
-- Indexes for table `setoran`
--
ALTER TABLE `setoran`
  ADD PRIMARY KEY (`id_setoran`);

--
-- Indexes for table `simpanan`
--
ALTER TABLE `simpanan`
  ADD PRIMARY KEY (`id_simpanan`),
  ADD KEY `id_anggota` (`id_anggota`);

--
-- Indexes for table `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`id_user`);

--
-- Indexes for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`id_transaksi`),
  ADD KEY `id_anggota` (`id_anggota`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `anggota`
--
ALTER TABLE `anggota`
  MODIFY `id_anggota` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `pinjaman`
--
ALTER TABLE `pinjaman`
  MODIFY `id_pinjaman` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;
--
-- AUTO_INCREMENT for table `setoran`
--
ALTER TABLE `setoran`
  MODIFY `id_setoran` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
--
-- AUTO_INCREMENT for table `simpanan`
--
ALTER TABLE `simpanan`
  MODIFY `id_simpanan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `tbl_user`
--
ALTER TABLE `tbl_user`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `transaksi`
--
ALTER TABLE `transaksi`
  MODIFY `id_transaksi` int(11) NOT NULL AUTO_INCREMENT;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `pinjaman`
--
ALTER TABLE `pinjaman`
  ADD CONSTRAINT `pinjaman_ibfk_1` FOREIGN KEY (`id_anggota`) REFERENCES `anggota` (`id_anggota`);

--
-- Constraints for table `simpanan`
--
ALTER TABLE `simpanan`
  ADD CONSTRAINT `simpanan_ibfk_1` FOREIGN KEY (`id_anggota`) REFERENCES `anggota` (`id_anggota`);

--
-- Constraints for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD CONSTRAINT `transaksi_ibfk_1` FOREIGN KEY (`id_anggota`) REFERENCES `anggota` (`id_anggota`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
