CREATE TABLE `etterem` (
  `Nev` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `Tipus` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `Cim` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `Id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

ALTER TABLE `etterem`
  ADD PRIMARY KEY (`Id`);

INSERT INTO `etterem` (`Nev`, `Tipus`, `Cim`, `Id`) VALUES
('Pizzatorony', 'Pizza', 'Szamos u. 4, 6723', 1),
('Pizzaguru', 'Pizza', 'Oskola u. 8, 6720', 2),
('Pizza monkey', 'Pizza', 'Pille u. 15, 6722', 3),
('McDonalds', 'Gyorsetterem', 'Kárász u. 11, 6720', 4),
('KFC', 'Gyorsetterem', 'Londoni körút 3', 5),
('BurgerKing', 'Gyorsetterem', 'Jókai utca 1', 6);