USE `evodbserver`;
INSERT INTO `evodbserver`.`Departamentos` (`ID`, `Nome`, `Sigla`) VALUES (1, 'Financas', 'FNC');
INSERT INTO `evodbserver`.`Departamentos` (`ID`, `Nome`, `Sigla`) VALUES (2, 'Juridico', 'JRD');
INSERT INTO `evodbserver`.`Departamentos` (`ID`, `Nome`, `Sigla`) VALUES (3, 'Vendas', 'VND');

USE `evodbserver`;
INSERT INTO `evodbserver`.`Funcionarios` (`ID`, `Nome`, `RG`, `Foto`, `DepartamentoID`) VALUES (1, 'Marcos', 289336454, NULL, 1);
INSERT INTO `evodbserver`.`Funcionarios` (`ID`, `Nome`, `RG`, `Foto`, `DepartamentoID`) VALUES (2, 'Maria', 135816919, NULL, 2);
INSERT INTO `evodbserver`.`Funcionarios` (`ID`, `Nome`, `RG`, `Foto`, `DepartamentoID`) VALUES (3, 'Joao', 155775856, NULL, 1);
INSERT INTO `evodbserver`.`Funcionarios` (`ID`, `Nome`, `RG`, `Foto`, `DepartamentoID`) VALUES (4, 'Helena', 329625159, NULL, 2);
INSERT INTO `evodbserver`.`Funcionarios` (`ID`, `Nome`, `RG`, `Foto`, `DepartamentoID`) VALUES (5, 'Lucas', 283052193, NULL, 3);
INSERT INTO `evodbserver`.`Funcionarios` (`ID`, `Nome`, `RG`, `Foto`, `DepartamentoID`) VALUES (6, 'Pedro', 271351135, NULL, 3);
INSERT INTO `evodbserver`.`Funcionarios` (`ID`, `Nome`, `RG`, `Foto`, `DepartamentoID`) VALUES (7, 'Laura', 287825334, NULL, 1);

COMMIT;
