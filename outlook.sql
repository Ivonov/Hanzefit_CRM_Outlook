-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Machine: 127.0.0.1
-- Gegenereerd op: 10 dec 2014 om 21:01
-- Serverversie: 5.6.17
-- PHP-versie: 5.5.12

-- SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
-- SET time_zone = "+00:00";



/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Databank: `outlook`
--
CREATE DATABASE IF NOT EXISTS outlook;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `afspraakoverzicht`
--

CREATE TABLE IF NOT EXISTS outlook.`afspraak overzicht` (
  `Begin tijd` datetime NOT NULL,
  `Eind tijd` datetime NOT NULL,
  `Dienst` char(255) NOT NULL,
  `Vierletter code` char(255) NOT NULL,
  `Opmerking` char(255) NOT NULL DEFAULT 'n.v.t.'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `dienstgroepen`
--

CREATE TABLE IF NOT EXISTS outlook.`dienst groepen` (
  `Dienst groep` char(255) NOT NULL,
  `Omschrijving` char(255) NOT NULL,
  PRIMARY KEY (`Dienst groep`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `dienstoverzicht`
--

CREATE TABLE IF NOT EXISTS outlook.`dienst overzicht` (
  `Dienst groep` char(255) NOT NULL,
  `Dienst` char(255) NOT NULL,
  `Omschrijving` char(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `gebruikeroverzicht`
--

CREATE TABLE IF NOT EXISTS outlook.`gebruiker overzicht` (
  `Voornaam` char(255) NOT NULL,
  `Achternaam` char(255) NOT NULL,
  `Email adres` char(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `klantenoverzicht`
--

CREATE TABLE IF NOT EXISTS outlook.`klanten overzicht` (
  `Vierletter code` char(255) NOT NULL,
  `Voornaam` char(255) NOT NULL,
  `Achternaam` char(255) NOT NULL,
  `Telefoonnummer` int(11) NOT NULL,
  `Email adres` char(255) NOT NULL,
  `Functie` char(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `klantenoverzicht`
--

INSERT INTO outlook.`klanten overzicht` (`Vierletter code`, `Voornaam`, `Achternaam`, `Telefoonnummer`, `Email adres`, `Functie`) VALUES
('LSID', 'Lisette', 'Achterhuis', 501234567, 'email@emailadres.nl', 'Whatever');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `vervolgdiensten`
--

CREATE TABLE IF NOT EXISTS outlook.`vervolg diensten` (
  `Dienst groep` char(255) NOT NULL,
  `Dienst` char(255) NOT NULL,
  `Omschrijving` char(255) NOT NULL,
  `Kosten` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
