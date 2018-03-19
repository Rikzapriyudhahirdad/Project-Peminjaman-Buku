-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 09, 2017 at 06:31 AM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tbuku`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_pinjam` (IN `judulbuku` VARCHAR(50))  NO SQL
DELETE FROM tbuku WHERE judul = judulbuku$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `peminjam`
--

CREATE TABLE `peminjam` (
  `idbuku` int(11) NOT NULL,
  `nama_peminjam` varchar(100) NOT NULL,
  `alamat_peminjam` varchar(100) NOT NULL,
  `no_telp` varchar(20) NOT NULL,
  `judul` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `peminjam`
--

INSERT INTO `peminjam` (`idbuku`, `nama_peminjam`, `alamat_peminjam`, `no_telp`, `judul`) VALUES
(0, 'Andri', 'ikan kakpa', '09992312', 'Indonesia Android Kejar'),
(0, 'Andri', 'sdaw', '097721', 'Sewindu Menata Rindu'),
(0, 'andri', 'ikan kakap', '088821', 'Indonesia Android Kejar'),
(0, 'andri', 'ikan kakap', '23412124', 'Indonesia Android Kejar'),
(0, 'andri', 'ikan kakap', '312412', 'Sewindu Menata Rindu'),
(0, 'andri', 'ikan kakap', '312412', 'Sewindu Menata Rindu'),
(0, 'andri', 'ikan ikan', '091293123', 'Bikin Laris Restoran');

-- --------------------------------------------------------

--
-- Table structure for table `stock`
--

CREATE TABLE `stock` (
  `idstock` int(11) NOT NULL,
  `namabarang` varchar(100) NOT NULL,
  `stok` int(11) NOT NULL DEFAULT '0' COMMENT 'stok barang'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbuku`
--

CREATE TABLE `tbuku` (
  `ID` int(11) NOT NULL,
  `kode_buku` varchar(50) NOT NULL,
  `judul` varchar(50) NOT NULL,
  `pengarang` varchar(50) NOT NULL,
  `penerbit` varchar(50) NOT NULL,
  `isbn` varchar(50) NOT NULL,
  `tahun_terbit` int(11) NOT NULL,
  `klasifikasi` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbuku`
--

INSERT INTO `tbuku` (`ID`, `kode_buku`, `judul`, `pengarang`, `penerbit`, `isbn`, `tahun_terbit`, `klasifikasi`) VALUES
(1, 'NPS1', 'Sewindu Menata Rindu', 'AZMUL PAWZI', 'MEDIAKITA', '9789797945411', 2017, 'Novel Puisi dan Sastra'),
(2, 'ND1', 'Tidak Ada New York Hari Ini', 'M AAN MANSYUR', 'GRAMEDIA PUSTAKA UTAMA (GPU)', '9786020327235', 2017, 'Novel Dewasa'),
(3, 'NF1', 'Bintang', 'Tere Liye', 'Gramedia Pustaka Utama', '9786020351179', 2017, 'Novel Fantasi'),
(4, 'NI1', 'Ayat-ayat Cinta 2', 'HABIBURRAHMAN EL SHIRAZY', 'REPUBLIKA', '9786020822150', 2000, 'Novel Islami'),
(5, 'NMT1', 'PETER', ' RISA SARASWATI', 'BUKUNE', '9786022201885', 2002, 'Novel Misteri dan Thriller'),
(6, 'NR1', 'Ada Cinta di SMA', 'HAQI ACHMAD & PATRICK EFFENDY', 'GAGAS MEDIA', '9789797808655', 2010, 'Novel Remaja'),
(7, 'NFH1', 'Politik Hukum Pilkada Serentak', 'TJAHJO KUMOLO', 'EXPOSE PUBLIKA', '9786027829329', 2015, 'Non-Fiksi Hukum'),
(8, 'NFIS1', 'The Post - American World', 'FAREED ZAKARIA', 'BENTANG PUSTAKA', '9786022910602', 2015, 'Non-Fiksi Ilmu Sosial'),
(9, 'NFK1', '52 Aktivitas untuk Memacu Otak Anak Berpikir Cepat', 'KUSUMASTUTI', 'BHUANA ILMU POPULER', '9789790749559', 2013, 'Non-Fiksi Kewanitaan'),
(10, 'NFM', '123 Penyakit & Gangguan Pada Ana', 'DR. HANIFAH OSWARI, SP.A(K), DR. RUDIANTO SOFWAN', 'Buana Ilmu Populer', '9789797989958', 2009, 'Non-Fiksi Medis'),
(11, 'NFP1', 'Evaluasi Kesesuaian Lahan Dan Perencanaan Tataguna', ' SARWONO HARDJOWIGENO & WIDIATMAKA', 'UGM PRESS', '9794206628', 2015, 'Non-Fiksi Pertanian'),
(12, 'NFP1', 'Psikologi Kepemimpinan & Inovasi', 'DJAMALUDIN ANCOK', 'Penerbit Erlangga', '9789790995024', 2012, 'Non-Fiksi Psikologi'),
(13, 'NFSIA1', 'Fisika Universitas Jilid 1 Edisi 10', 'HUGH D. YOUNG', 'Gudang Penerbit', '9796884720', 2002, 'Non-Fiksi Sains dan Ilmu Alam'),
(14, 'NFT1', 'Termodinamika Teknik Jilid 1 Edisi 4', 'MICHAEL J. MORAN & HOWARD N. SHAPIRO', 'Gudang Penerbit', '37010108', 2004, 'Non-Fiksi Teknik'),
(15, 'PDI1', 'The Naked Traveler 7', 'TRINITY', 'BENTANG PUSTAKA', '9786021246986', 2016, 'Pengembangan Diri Inspirasi'),
(16, 'PDM1', 'Change Your Life Now ! Rahasia Menggapai Kebahagia', 'NATHALIA SUNAIDI', 'BHUANA ILMU POPULER (BIP)', '9789790741089', 2009, 'Pengembangan Diri Motivasi'),
(17, 'BA1', 'Administrasi Perpajakan', 'LIBERTI PANDIANGAN', 'Gudang Penerbit', '9786022980131', 2014, 'Buku Akuntansi'),
(18, 'BE1', 'Akuntansi Keuangan Lanjutan Edisi IFRS', 'GOLRIDA KARYAWATI', 'Gudang Penerbit', '9789790997639', 2012, 'Buku Ekonomi'),
(19, 'BK1', 'Kece Tanpa Kere', 'TIM BANK PERMATA', 'GRAMEDIA PUSTAKA UTAMA (GPU)', '9786020353401', 2012, 'Buku Keuangan'),
(20, 'BMK1', 'Professional General Affair #1 : Panduan Bagian Um', 'TEGUH HAMBUDI', 'VISIMEDIA', '9789790652415', 2015, 'Buku Manajemen dan Kepemimpinan'),
(21, 'BPP1', 'Milenial Nusantara', 'HASANUDDIN ALI & LILIK PURWANDI', 'GRAMEDIA PUSTAKA UTAMA (GPU)', '9786020375304', 2017, 'Buku Pemasaran dan Penjualan'),
(22, 'BP1', 'Perpajakan Edisi Terbaru 2016', 'PROF. DR. MARDIASMO, MBA., AK', 'ANDIPUBLISHER', '9789792953244', 2016, 'Buku Perpajakan'),
(23, 'BUKK1', 'Bikin Laris Restoran', 'AKIRA HARADA, MORIHIKO ISHIKAWA', 'GRAMEDIA PUSTAKA UTAMA (GPU)', '9786020313368', 2015, 'Buku Usaha Kecil dan Kewirausahaan'),
(24, 'edu-Andri', 'Indonesia Android Kejar', 'Google developers', 'Google.inc', '99928881002', 2017, 'Edukasi');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `stock`
--
ALTER TABLE `stock`
  ADD PRIMARY KEY (`idstock`),
  ADD KEY `FKEY1` (`namabarang`);

--
-- Indexes for table `tbuku`
--
ALTER TABLE `tbuku`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbuku`
--
ALTER TABLE `tbuku`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
