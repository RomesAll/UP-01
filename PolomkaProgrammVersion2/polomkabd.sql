-- MySQL dump 10.13  Distrib 8.0.26, for Win64 (x86_64)
--
-- Host: localhost    Database: polomkabd
-- ------------------------------------------------------
-- Server version	8.0.26

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `attachedproduct`
--

DROP TABLE IF EXISTS `attachedproduct`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `attachedproduct` (
  `MainProductID` int NOT NULL,
  `AttachedProductID` int NOT NULL,
  PRIMARY KEY (`MainProductID`,`AttachedProductID`),
  KEY `FK_AttachedProduct_Product1` (`AttachedProductID`),
  CONSTRAINT `FK_AttachedProduct_Product` FOREIGN KEY (`MainProductID`) REFERENCES `product` (`ID`),
  CONSTRAINT `FK_AttachedProduct_Product1` FOREIGN KEY (`AttachedProductID`) REFERENCES `product` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `attachedproduct`
--

LOCK TABLES `attachedproduct` WRITE;
/*!40000 ALTER TABLE `attachedproduct` DISABLE KEYS */;
/*!40000 ALTER TABLE `attachedproduct` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `client` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `LastName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `Patronymic` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `Birthday` date DEFAULT NULL,
  `RegistrationDate` datetime(6) DEFAULT NULL,
  `Email` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `Phone` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `GenderCode` char(1) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `PhotoPath` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_Client_Gender` (`GenderCode`),
  CONSTRAINT `FK_Client_Gender` FOREIGN KEY (`GenderCode`) REFERENCES `gender` (`Code`)
) ENGINE=InnoDB AUTO_INCREMENT=186 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES (43,'Гле','Селиверстов','Максимович','1999-06-20','2022-02-17 00:00:00.000000','jigsaw@sbcglobal.net','7(20)554-28-68 ','1',''),(44,'Юстини','Агафонов','Олегович','1997-02-14','2022-02-18 00:00:00.000000','staffelb@sbcglobal.net','7(303)810-28-78 ','1','C:/Users/79533/Source/Repos/UP-01/PolomkaProgrammVersion2/Клиенты/m1.jpg'),(45,'Злата','Колобова','Романовна','1994-08-25','2022-02-17 00:00:00.000000','sinkou@aol.com','7(50)884-07-35 ','2','C:/Users/79533/Desktop/УП-02  Задание-4/UP_PM2_Task_4/Задание-4 Клиенты автосервиса/Сессия 1/clients_import/Клиенты/1.jpg'),(46,'Дарина','Сысоева','Ярославовна','1982-02-03','2016-05-13 00:00:00.000000','treit@verizon.net','7(0698)387-96-04 ','2','C:\\Users\\79533\\Source\\Repos\\UP-01\\PolomkaProgrammVersion2\\Клиенты\\32.jpg'),(47,'Варлам','Некрасов','Михайлович','2000-11-12','2017-12-03 00:00:00.000000','dogdude@verizon.net','7(019)258-06-35 ','1','C:\\Users\\79533\\Source\\Repos\\UP-01\\PolomkaProgrammVersion2\\Клиенты\\m42.jpg'),(48,'Наум','Крюков','Ильяович','1993-11-17','2017-02-01 00:00:00.000000','floxy@hotmail.com','7(81)657-88-92 ','1','C:\\Users\\79533\\Source\\Repos\\UP-01\\PolomkaProgrammVersion2\\Клиенты\\m30.jpg'),(49,'Татьяна','Сидорова','Михайловна','1974-04-24','2018-10-03 00:00:00.000000','tbeck@mac.com','7(51)732-91-79 ','2','C:\\Users\\79533\\Source\\Repos\\UP-01\\PolomkaProgrammVersion2\\Клиенты\\42.jpg'),(50,'Альжбета','Трофимова','Якововна','1988-10-22','2017-09-21 00:00:00.000000','gbacon@mac.com','7(1084)658-92-95 ','2','C:\\Users\\79533\\Source\\Repos\\UP-01\\PolomkaProgrammVersion2\\Клиенты\\25.jpg'),(51,'Адриан','Новиков','Аркадьевич','1974-01-15','2018-11-23 00:00:00.000000','multiplx@verizon.net','7(70)572-33-62 ','1','C:\\Users\\79533\\Source\\Repos\\UP-01\\PolomkaProgrammVersion2\\Клиенты\\m40.jpg'),(52,'Иветта','Мишина','Андреевна','2002-10-05','2016-01-24 00:00:00.000000','aukjan@yahoo.com','7(3926)244-81-96 ','2','C:\\Users\\79533\\Source\\Repos\\UP-01\\PolomkaProgrammVersion2\\Клиенты\\30.jpg'),(53,'Геннадий','Шестаков','Рубенович','2001-07-01','2018-12-08 00:00:00.000000','tokuhirom@live.com','7(2066)037-11-60 ','1','C:\\Users\\79533\\Source\\Repos\\UP-01\\PolomkaProgrammVersion2\\Клиенты\\m41.jpg'),(54,'Матвей','Зуев','Иванович','1981-03-28','2018-12-18 00:00:00.000000','brickbat@verizon.net','7(5383)893-04-66 ','1','C:\\Users\\79533\\Source\\Repos\\UP-01\\PolomkaProgrammVersion2\\Клиенты\\m38.jpg'),(55,'Георгина','Турова','Семёновна','1974-05-28','2018-02-22 00:00:00.000000','yruan@optonline.net','7(555)321-42-99 ','2','C:\\Users\\79533\\Source\\Repos\\UP-01\\PolomkaProgrammVersion2\\Клиенты\\27.jpg'),(56,'Валентин','Анисимов','Пантелеймонович','2000-12-10','2018-01-20 00:00:00.000000','aaribaud@hotmail.com','7(700)326-70-24 ','1','C:\\Users\\79533\\Source\\Repos\\UP-01\\PolomkaProgrammVersion2\\Клиенты\\m99.jpg'),(57,'Тамара','Анисимова','Витальевна','1988-06-16','2016-02-25 00:00:00.000000','schwaang@mac.com','7(66)128-04-10 ','2','C:\\Users\\79533\\Source\\Repos\\UP-01\\PolomkaProgrammVersion2\\Клиенты\\2.jpg'),(58,'Орест','Колобов','Юлианович','2001-07-14','2017-01-01 00:00:00.000000','parkes@verizon.net','7(1680)508-58-26 ','1','C:\\Users\\79533\\Source\\Repos\\UP-01\\PolomkaProgrammVersion2\\Клиенты\\m27.jpg'),(59,'Аристарх','Филатов','Дмитриевич','1989-05-29','2017-01-11 00:00:00.000000','hampton@att.net','7(696)235-29-24 ','1','C:\\Users\\79533\\Source\\Repos\\UP-01\\PolomkaProgrammVersion2\\Клиенты\\m43.jpg'),(60,'Влада','Орлова','Мартыновна','1990-06-26','2016-03-21 00:00:00.000000','rnelson@yahoo.ca','7(2506)433-38-35 ','2','C:\\Users\\79533\\Source\\Repos\\UP-01\\PolomkaProgrammVersion2\\Клиенты\\22.jpg'),(61,'Элина','Алексеева','Матвеевна','2002-05-07','2018-03-28 00:00:00.000000','pthomsen@verizon.net','7(8086)245-64-81 ','2','C:\\Users\\79533\\Source\\Repos\\UP-01\\PolomkaProgrammVersion2\\Клиенты\\1.jpg'),(62,'Агафон','Бобров','Лаврентьевич','1995-07-29','2017-05-09 00:00:00.000000','petersen@comcast.net','7(2159)507-39-57 ','1','C:\\Users\\79533\\Source\\Repos\\UP-01\\PolomkaProgrammVersion2\\Клиенты\\m35.jpg'),(63,'Инара','Бирюкова','Улебовна','1978-07-21','2017-10-01 00:00:00.000000','smpeters@hotmail.com','7(098)346-50-58 ','2','C:\\Users\\79533\\Source\\Repos\\UP-01\\PolomkaProgrammVersion2\\Клиенты\\5.jpg'),(64,'Марк','Панфилов','Рудольфович','1991-04-13','2016-02-23 00:00:00.000000','cremonini@optonline.net','7(764)282-55-22 ','1','C:\\Users\\79533\\Source\\Repos\\UP-01\\PolomkaProgrammVersion2\\Клиенты\\m45.jpg'),(65,'Алина','Колесникова','Еремеевна','2001-04-19','2017-01-18 00:00:00.000000','gfxguy@outlook.com','7(74)977-39-71 ','2','C:\\Users\\79533\\Source\\Repos\\UP-01\\PolomkaProgrammVersion2\\Клиенты\\40.jpg'),(66,'Наум','Морозов','Валерьянович','1985-07-04','2016-05-02 00:00:00.000000','salesgeek@mac.com','7(636)050-96-13 ','1','C:\\Users\\79533\\Source\\Repos\\UP-01\\PolomkaProgrammVersion2\\Клиенты\\m49.jpg'),(67,'Давид','Горбачёв','Тимурович','1983-05-22','2018-12-17 00:00:00.000000','hedwig@att.net','7(53)602-85-41 ','1','C:\\Users\\79533\\Source\\Repos\\UP-01\\PolomkaProgrammVersion2\\Клиенты\\m36.jpg'),(68,'Оскар','Васильев','Богданович','1971-01-30','2017-05-28 00:00:00.000000','miturria@verizon.net','7(585)801-94-29 ','1','C:\\Users\\79533\\Source\\Repos\\UP-01\\PolomkaProgrammVersion2\\Клиенты\\m15.jpg'),(69,'Номи','Ершова','Андреевна','2001-09-13','2016-06-30 00:00:00.000000','miltchev@mac.com','7(7757)315-90-99 ','2','Клиенты\\14.jpg'),(70,'Святослав','Медведев','Юлианович','1972-10-04','2018-10-13 00:00:00.000000','hllam@comcast.net','7(3520)435-21-20 ','1','Клиенты\\m13.jpg'),(71,'Эльмира','Баранова','Дмитриевна','1977-01-15','2016-07-08 00:00:00.000000','jgmyers@comcast.net','7(9240)643-15-50 ','2','Клиенты\\4.jpg'),(72,'Харита','Попова','Якуновна','1997-12-16','2016-07-05 00:00:00.000000','firstpr@verizon.net','7(335)386-81-06 ','2','Клиенты\\36.jpg'),(73,'Аверкий','Кудряшов','Константинович','1991-07-26','2018-03-08 00:00:00.000000','nanop@msn.com','7(88)732-96-30 ','1','Клиенты\\m33.jpg'),(74,'Марта','Горшкова','Иосифовна','2001-02-13','2016-08-04 00:00:00.000000','gbacon@mac.com','7(544)650-59-03','2','Клиенты\\9.jpg'),(75,'Богдан','Кудрявцев','Христофорович','1988-02-27','2016-10-07 00:00:00.000000','lukka@hotmail.com','7(20)131-84-09 ','1','Клиенты\\m31.jpg'),(76,'Яков','Гусев','Авксентьевич','1995-12-10','2017-11-20 00:00:00.000000','jdhedden@icloud.com','7(0972)781-11-37 ','1','Клиенты\\m20.jpg'),(77,'Авигея','Крюкова','Святославовна','2000-08-10','2018-01-03 00:00:00.000000','simone@gmail.com','7(499)318-88-53 ','2','Клиенты\\19.jpg'),(78,'Амелия','Степанова','Робертовна','1970-06-06','2017-09-27 00:00:00.000000','rasca@hotmail.com','7(1217)441-28-42 ','2','Клиенты\\15.jpg'),(79,'Божена','Суворова','Анатольевна','1981-03-09','2016-01-28 00:00:00.000000','attwood@aol.com','7(347)895-86-57 ','2','Клиенты\\34.jpg'),(80,'Аввакум','Борисов','Артемович','1974-04-25','2017-03-11 00:00:00.000000','chlim@live.com','7(2296)930-08-88 ','1','Клиенты\\m12.jpg'),(81,'Георгий','Бобылёв','Витальевич','1983-12-19','2018-04-06 00:00:00.000000','csilvers@mac.com','7(88)685-13-51 ','1','Клиенты\\m11.jpg'),(82,'Вольдемар','Дроздов','Артемович','1976-02-07','2017-07-18 00:00:00.000000','smpeters@me.com','7(307)456-99-05 ','1','Клиенты\\m21.jpg'),(83,'Сабрина','Беляева','Федосеевна','1972-07-26','2017-06-14 00:00:00.000000','agapow@gmail.com','7(6580)534-32-58 ','2','Клиенты\\47.jpg'),(84,'Пантелеймон','Блохин','Феликсович','1978-03-06','2018-02-14 00:00:00.000000','balchen@comcast.net','7(9524)556-48-98 ','1','Клиенты\\m8.jpg'),(85,'Гелла','Шашкова','Эдуардовна','1979-02-24','2016-11-16 00:00:00.000000','jadavis@mac.com','7(57)446-21-04 ','2','Клиенты\\43.jpg'),(86,'Артур','Калашников','Юрьевич','1972-12-13','2017-08-20 00:00:00.000000','oevans@aol.com','7(147)947-47-21 ','1','Клиенты\\m10.jpg'),(87,'Анэля','Корнилова','Михайловна','1973-04-02','2016-05-22 00:00:00.000000','jonathan@aol.com','7(20)980-01-60 ','2','Клиенты\\26.jpg'),(88,'Янита','Гущина','Федоровна','1999-03-02','2018-02-01 00:00:00.000000','lishoy@att.net','7(4544)716-68-96 ','2','Клиенты\\11.jpg'),(89,'Людвиг','Волков','Витальевич','1977-12-27','2016-04-27 00:00:00.000000','jrkorson@msn.com','7(8459)592-05-58 ','1','Клиенты\\m50.jpg'),(90,'Терентий','Князев','Валерьевич','1991-06-19','2018-06-25 00:00:00.000000','rjones@aol.com','7(98)397-23-23 ','1','Клиенты\\m26.jpg'),(91,'Гаянэ','Силин','Анатольевич','1976-05-27','2017-05-05 00:00:00.000000','multiplx@comcast.net','7(4547)615-22-69 ','1','Клиенты\\m46.jpg'),(92,'Дмитрий','Казаков','Русланович','1978-12-15','2016-05-21 00:00:00.000000','ozawa@verizon.net','7(51)682-19-40 ','2','Клиенты\\m44.jpg'),(93,'Роза','Гусева','Дмитриевна','1999-02-13','2017-12-12 00:00:00.000000','martyloo@live.com','7(23)064-51-84 ','2','Клиенты\\10.jpg'),(94,'Марфа','Мамонтова','Мироновна','1984-10-19','2018-02-27 00:00:00.000000','rfoley@verizon.net','7(38)095-64-18 ','2','Клиенты\\29.jpg'),(95,'Эрик','Галкин','Онисимович','1975-01-18','2016-07-19 00:00:00.000000','snunez@verizon.net','7(759)873-77-39 ','1','Клиенты\\m16.jpg'),(96,'Прасковья','Архипова','Валерьевна','1979-01-09','2018-07-23 00:00:00.000000','cgcra@live.com','7(86)540-10-21 ','2','Клиенты\\33.jpg'),(97,'Лаура','Овчинникова','Еремеевна','1992-04-03','2018-11-24 00:00:00.000000','carcus@yahoo.ca','7(85)829-33-79 ','2','Клиенты\\35.jpg'),(98,'Патрисия','Андреева','Валерьевна','1993-11-18','2016-07-17 00:00:00.000000','jigsaw@aol.com','7(9648)953-81-26 ','2','Клиенты\\37.jpg'),(99,'Самуил','Авдеев','Улебович','1996-07-04','2016-02-11 00:00:00.000000','cliffordj@mac.com','7(3168)043-63-31 ','1','Клиенты\\m96.jpg'),(100,'Светлана','Бурова','Лукьевна','1979-01-04','2016-10-13 00:00:00.000000','wsnyder@aol.com','7(358)173-82-21 ','2','Клиенты\\39.jpg'),(101,'Глеб','Ершов','Федорович','1970-06-14','2016-09-14 00:00:00.000000','sjava@aol.com','7(2608)298-40-82 ','1','Клиенты\\m23.jpg'),(102,'Захар','Игнатов','Павлович','1998-10-07','2017-11-10 00:00:00.000000','dieman@icloud.com','7(578)574-73-36 ','1','Клиенты\\m98.jpg'),(103,'Амалия','Комиссарова','Робертовна','1971-08-18','2017-08-04 00:00:00.000000','jorgb@msn.com','7(22)647-46-32 ','2','Клиенты\\17.jpg'),(104,'Трофим','Быков','Константинович','1994-12-20','2016-04-17 00:00:00.000000','jguyer@aol.com','7(3414)460-12-05 ','1','Клиенты\\m14.jpg'),(105,'Леонтий','Кузьмин','Валерьянович','2000-05-05','2017-10-12 00:00:00.000000','msloan@hotmail.com','7(1340)148-90-68 ','1','Клиенты\\m17.jpg'),(106,'Диана','Белозёрова','Антоновна','1989-02-27','2017-01-30 00:00:00.000000','dialworld@aol.com','7(9900)174-59-87 ','1','Клиенты\\7.jpg'),(107,'Евгений','Блинов','Мэлсович','1994-01-05','2017-05-07 00:00:00.000000','moxfulder@outlook.com','7(0852)321-82-64 ','1','Клиенты\\m7.jpg'),(108,'Алексей','Лазарев','Богданович','1977-03-10','2017-01-02 00:00:00.000000','claesjac@me.com','7(0055)737-37-48 ','1','Клиенты\\m48.jpg'),(109,'Розалия','Афанасьева','Макаровна','1977-05-01','2017-09-06 00:00:00.000000','malattia@hotmail.com','7(0661)413-23-32 ','2','Клиенты\\31.jpg'),(110,'Эдита','Дементьева','Онисимовна','1975-09-17','2018-11-24 00:00:00.000000','frosal@hotmail.com','7(198)922-28-76 ','2','Клиенты\\38.jpg'),(111,'Петр','Калинин','Иванович','1993-09-08','2016-05-26 00:00:00.000000','aschmitz@hotmail.com','7(90)316-07-17 ','1','Клиенты\\m47.jpg'),(112,'Станислав','Андреев','Максович','1975-10-10','2017-12-26 00:00:00.000000','budinger@mac.com','7(02)993-91-28 ','1','Клиенты\\m3.jpg'),(113,'Устин','Киселёв','Яковлевич','1985-01-08','2018-06-21 00:00:00.000000','dalamb@verizon.net','7(83)334-52-76 ','1','Клиенты\\m25.jpg'),(114,'Павел','Гордеев','Семенович','1984-09-06','2016-07-19 00:00:00.000000','dawnsong@verizon.net','7(5243)599-66-72 ','1','Клиенты\\m19.jpg'),(115,'Никки','Горбачёва','Еремеевна','1987-04-21','2018-08-16 00:00:00.000000','chinthaka@att.net','7(94)789-69-20 ','2','Клиенты\\8.jpg'),(116,'Касьян','Копылов','Робертович','1983-08-04','2018-03-18 00:00:00.000000','crobles@sbcglobal.net','7(5774)679-82-06 ','1','Клиенты\\m29.jpg'),(117,'Витольд','Ефремов','Авксентьевич','1975-12-02','2018-04-09 00:00:00.000000','kwilliams@yahoo.ca','7(93)922-14-03 ','1','Клиенты\\m28.jpg'),(118,'Михаил','Баранов','Романович','1997-07-12','2018-10-07 00:00:00.000000','bigmauler@outlook.com','7(750)985-94-13 ','1','Клиенты\\m5.jpg'),(119,'Элина','Дмитриева','Даниловна','1988-12-10','2017-02-11 00:00:00.000000','vmalik@live.com','7(787)140-48-84 ','2','Клиенты\\12.jpg'),(120,'Осип','Федотов','Анатольевич','1971-04-13','2018-07-23 00:00:00.000000','breegster@hotmail.com','7(590)702-33-06 ','1','Клиенты\\m9.jpg'),(121,'Тала','Быкова','Георгьевна','2000-02-22','2016-08-13 00:00:00.000000','ganter@optonline.net','7(13)915-53-53 ','2','Клиенты\\6.jpg'),(122,'Вадим','Дементьев','Ростиславович','1993-07-10','2018-03-05 00:00:00.000000','jacks@aol.com','7(79)330-46-15 ','1','Клиенты\\m39.jpg'),(123,'Макар','Евсеев','Васильевич','1977-09-13','2018-12-05 00:00:00.000000','parsimony@sbcglobal.net','7(2141)077-85-70 ','1','Клиенты\\m22.jpg'),(124,'Станислав','Абрамов','Филатович','1989-05-18','2016-12-08 00:00:00.000000','solomon@att.net','7(6545)478-87-79 ','1','Клиенты\\m32.jpg'),(125,'Лиза','Артемьева','Максимовна','1996-05-17','2018-10-07 00:00:00.000000','snunez@yahoo.ca','7(696)972-70-21 ','2','Клиенты\\3.jpg'),(126,'Дэнна','Кузьмина','Витальевна','1993-08-24','2016-03-27 00:00:00.000000','nichoj@mac.com','7(9940)977-45-73 ','2','Клиенты\\20.jpg'),(127,'Магда','Ефимова','Платоновна','1995-08-16','2017-08-01 00:00:00.000000','rbarreira@me.com','7(9261)386-15-92 ','2','Клиенты\\16.jpg'),(128,'Альберт','Ефимов','Проклович','1997-10-29','2018-06-21 00:00:00.000000','houle@live.com','7(416)375-97-19 ','1','Клиенты\\m6.jpg'),(129,'Эльвина','Лазарева','Робертовна','1996-02-16','2018-04-11 00:00:00.000000','ahuillet@comcast.net','7(5564)609-81-37 ','2','Клиенты\\28.jpg'),(130,'Изабелла','Воронова','Вячеславовна','1999-09-24','2017-12-21 00:00:00.000000','kildjean@sbcglobal.net','7(17)433-44-98 ','2','Клиенты\\21.jpg'),(131,'Эвелина','Куликова','Вячеславовна','1997-11-14','2018-02-01 00:00:00.000000','ilikered@hotmail.com','7(0236)682-42-78 ','2','Клиенты\\23.jpg'),(132,'Амалия','Егорова','Дамировна','1999-09-28','2016-06-30 00:00:00.000000','drezet@yahoo.com','7(7486)408-12-26 ','2','Клиенты\\13.jpg'),(133,'Станислав','Александров','Эдуардович','1981-07-04','2018-11-08 00:00:00.000000','bigmauler@aol.com','7(18)164-05-12 ','1','Клиенты\\m2.jpg'),(134,'Демьян','Цветков','Львович','1996-03-29','2016-02-12 00:00:00.000000','hauma@icloud.com','7(93)546-43-73 ','1','Клиенты\\m4.jpg'),(135,'Юнона','Устинова','Валентиновна','1982-08-08','2017-05-28 00:00:00.000000','kempsonc@live.com','7(33)367-13-07','2','Клиенты\\44.jpg'),(136,'Любава','Костина','Авксентьевна','1972-07-13','2016-02-26 00:00:00.000000','gordonjcp@hotmail.com','7(6419)959-21-87 ','2','Клиенты\\41.jpg'),(137,'Мартын','Смирнов','Арсеньевич','1996-06-25','2017-02-07 00:00:00.000000','haddawy@live.com','7(6251)589-02-43 ','1','Клиенты\\m34.jpg'),(138,'Сандра','Федотова','Владленовна','1985-03-29','2016-11-08 00:00:00.000000','penna@verizon.net','7(126)195-25-86 ','2','Клиенты\\24.jpg'),(139,'Леонтий','Журавлёв','Яковлевич','2000-03-02','2018-01-15 00:00:00.000000','cmdrgravy@me.com','7(4403)308-56-96 ','1','Клиенты\\m24.jpg'),(140,'Вадим','Большаков','Данилович','1970-05-15','2018-08-04 00:00:00.000000','uncle@gmail.com','7(386)641-13-37 ','1','Клиенты\\m97.jpg'),(143,'asdasd','sdasd','asd',NULL,NULL,NULL,NULL,'2',NULL),(144,'sdfsdf','sdfsdf','sdfsd','2014-02-20',NULL,NULL,NULL,'1',NULL),(145,'asdasd','asdasd','asdasd','2014-02-20','2022-02-14 00:00:00.000000',NULL,NULL,'2',NULL),(146,'dasd','asdasd','asdads','2014-02-20','2022-02-14 00:00:00.000000','adsd@das.sdas',NULL,'1',NULL),(147,'weasd','asdasd','asdasd','2014-02-20','2022-02-14 00:00:00.000000','dasda@das.dasd','+7 111-111-11-11','2',NULL),(148,'asd','asdasd','asds','2014-02-20','2022-02-14 00:00:00.000000','sadasd@dasd.asdas','+7 111-111-11-11','1',NULL),(149,'asdasd','asdasd','asdasd','2014-02-20','2022-02-14 00:00:00.000000','asdasd@das.asd','+7 111-111-11-11','1','1.jpg'),(150,'ASD','ASD','DASD','2014-02-20','2022-02-14 00:00:00.000000','asd@dsd.ts','+7 111-111-11-11','1','Клиенты 9.jpg'),(151,'czxc','zxczxc','xczxc','2014-02-20','2022-02-14 00:00:00.000000','dd@ds.dsf','+7 111-111-11-11','1','Клиенты 9.jpg'),(152,'df','fd','dfg','2014-02-20','2022-02-14 00:00:00.000000','fdg@sdf.sdf','+7 111-111-11-11','1','Клиенты8.jpg'),(162,'sdf','fsdf','sdf','2018-02-20','2022-02-18 00:00:00.000000','sfd@das.sdf','+7 111-111-11-11','1','C:/Users/79533/Desktop/УП-02  Задание-4/UP_PM2_Task_4/Задание-4 Клиенты автосервиса/Сессия 1/clients_import/Клиенты/8.jpg'),(163,'sda','dasd','asd','2018-02-20','2022-02-18 00:00:00.000000','ok@dsa.sad','+7 111-111-11-11','1','C:/Users/79533/Desktop/УП-02  Задание-4/UP_PM2_Task_4/Задание-4 Клиенты автосервиса/Сессия 1/clients_import/Клиенты/3.jpg'),(164,'asd','asd','asd','2018-02-20','2022-02-18 00:00:00.000000','ads@das.sad','+7 111-111-11-11','2','C:/Users/79533/Desktop/УП-02  Задание-4/UP_PM2_Task_4/Задание-4 Клиенты автосервиса/Сессия 1/clients_import/Клиенты/18.jpg'),(165,'sdf','sdf','fsd','2018-02-20','2022-02-18 00:00:00.000000','fsd@fsd.sd','+7 111-111-11-11','1','C:/Users/79533/Desktop/УП-02  Задание-4/UP_PM2_Task_4/Задание-4 Клиенты автосервиса/Сессия 1/clients_import/Клиенты/10.jpg'),(166,'ewr','werwer','wer','2018-02-20','2022-02-18 00:00:00.000000','fsd@dsa.da','+7 111-111-11-11','1','C:/Users/79533/Desktop/УП-02  Задание-4/UP_PM2_Task_4/Задание-4 Клиенты автосервиса/Сессия 1/clients_import/Клиенты/10.jpg'),(167,'asd','asd','asd','2018-02-20','2022-02-18 00:00:00.000000','da@das.asd','+7 111-111-11-11','2','C:/Users/79533/Desktop/УП-02  Задание-4/UP_PM2_Task_4/Задание-4 Клиенты автосервиса/Сессия 1/clients_import/Клиенты/19.jpg'),(168,'sdf','sdf','sdfsdf','2018-02-20','2022-02-18 00:00:00.000000','fsdf@das.das','+7 111-111-11-11','2','C:/Users/79533/Desktop/УП-02  Задание-4/UP_PM2_Task_4/Задание-4 Клиенты автосервиса/Сессия 1/clients_import/Клиенты/17.jpg'),(169,'фвфы','фыв','фыв','2018-02-20','2022-02-18 00:00:00.000000','вфы@das.das','+7 111-111-11-11','1','C:/Users/79533/Desktop/УП-02  Задание-4/UP_PM2_Task_4/Задание-4 Клиенты автосервиса/Сессия 1/clients_import/Клиенты/18.jpg'),(170,'sdf','sdf','sdf','2018-02-20','2022-02-18 00:00:00.000000','fsdf@fsdf.sdf','+7 111-111-11-11','2','C:/Users/79533/Desktop/УП-02  Задание-4/UP_PM2_Task_4/Задание-4 Клиенты автосервиса/Сессия 1/clients_import/Клиенты/17.jpg'),(171,'qweqw','q','qwq','2018-02-20','2022-02-18 00:00:00.000000','qSD@DAS.DAS','+7 111-111-11-11','2','C:/Users/79533/Desktop/УП-02  Задание-4/UP_PM2_Task_4/Задание-4 Клиенты автосервиса/Сессия 1/clients_import/Клиенты/10.jpg'),(172,'asd','asd','asd','2018-02-20','2022-02-18 00:00:00.000000','asda@adsd.das','+7 111-111-11-11','1','C:/Users/79533/Desktop/УП-02  Задание-4/UP_PM2_Task_4/Задание-4 Клиенты автосервиса/Сессия 1/clients_import/Клиенты/10.jpg'),(173,'dasd','asd','asdasd','2018-02-20','2022-02-18 00:00:00.000000','asd@das.asd','+7 111-111-11-11','1','C:/Users/79533/Desktop/УП-02  Задание-4/UP_PM2_Task_4/Задание-4 Клиенты автосервиса/Сессия 1/clients_import/Клиенты/17.jpg'),(174,'asd','asd','asd','2018-02-20','2022-02-18 00:00:00.000000','ad@dsa.das','+7 111-111-11-11','1','C:/Users/79533/Desktop/УП-02  Задание-4/UP_PM2_Task_4/Задание-4 Клиенты автосервиса/Сессия 1/clients_import/Клиенты/10.jpg'),(175,'rwe','wer','wer','2018-02-20','2022-02-18 00:00:00.000000','rwer@SD.DSFA','+7 111-111-11-11','2','C:/Users/79533/Desktop/УП-02  Задание-4/UP_PM2_Task_4/Задание-4 Клиенты автосервиса/Сессия 1/clients_import/Клиенты/9.jpg'),(176,'dsf','sdf','sdf','2018-02-20','2022-02-18 00:00:00.000000','fsd@as.sda','+7 111-111-11-11','1','C:/Users/79533/Desktop/УП-02  Задание-4/UP_PM2_Task_4/Задание-4 Клиенты автосервиса/Сессия 1/clients_import/Клиенты/17.jpg'),(177,'SDF','SDF','DSF','2018-02-20','2022-02-18 00:00:00.000000','SDF@DS.ASD','+7 111-111-11-11','1','C:/Users/79533/Desktop/УП-02  Задание-4/UP_PM2_Task_4/Задание-4 Клиенты автосервиса/Сессия 1/clients_import/Клиенты/11.jpg'),(178,'DSF','FSDF','SDFSD','2018-02-20','2022-02-18 00:00:00.000000','SFD@DAS.DAS','+7 111-111-11-11','1','C:/Users/79533/Desktop/УП-02  Задание-4/UP_PM2_Task_4/Задание-4 Клиенты автосервиса/Сессия 1/clients_import/Клиенты/10.jpg'),(179,'XZ','ZXC','ZXC','2018-02-20','2022-02-18 00:00:00.000000','SDF@DSA.ADS','+7 111-111-11-11','1','C:/Users/79533/Desktop/УП-02  Задание-4/UP_PM2_Task_4/Задание-4 Клиенты автосервиса/Сессия 1/clients_import/Клиенты/9.jpg'),(180,'sdsad','111sd','asd','2018-02-20','2022-02-18 00:00:00.000000','dsdas@dasd.das','+7 111-111-11-11','1','C:/Users/79533/Desktop/УП-02  Задание-4/UP_PM2_Task_4/Задание-4 Клиенты автосервиса/Сессия 1/clients_import/Клиенты/9.jpg'),(181,'sdas','dasd','asd','2018-02-20','2022-02-18 00:00:00.000000','dfas@das.asd','+7 111-111-11-11','1','C:/Users/79533/Desktop/УП-02  Задание-4/UP_PM2_Task_4/Задание-4 Клиенты автосервиса/Сессия 1/clients_import/Клиенты/10.jpg'),(182,'sdas','dasd','asd','2018-02-20','2022-02-18 00:00:00.000000','dfas@das.asd','+7 111-111-11-11','2','C:/Users/79533/Desktop/УП-02  Задание-4/UP_PM2_Task_4/Задание-4 Клиенты автосервиса/Сессия 1/clients_import/Клиенты/10.jpg'),(183,'dsad','asd','asddasd','2021-02-20','2022-02-21 00:00:00.000000','asd@das.das','+7 111-111-11-11','1','C:/Users/79533/Desktop/УП-02  Задание-4/UP_PM2_Task_4/Задание-4 Клиенты автосервиса/Сессия 1/clients_import/Клиенты/9.jpg'),(184,'asd','asd','asd','2021-02-20','2022-02-21 00:00:00.000000','asdf@das.das','+7 111-111-11-11','1','C:/Users/79533/Desktop/УП-02  Задание-4/UP_PM2_Task_4/Задание-4 Клиенты автосервиса/Сессия 1/clients_import/Клиенты/10.jpg'),(185,'asdas','asdas','asd','2005-04-20','2022-04-05 00:00:00.000000','asd@dsa.asd','+7 111-111-11-11','2','C:/Users/79533/Desktop/УП-02  Задание-4/UP_PM2_Task_4/Задание-4 Клиенты автосервиса/Сессия 1/clients_import/Клиенты/9.jpg');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientservice`
--

DROP TABLE IF EXISTS `clientservice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientservice` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `ClientID` int NOT NULL,
  `ServiceID` int NOT NULL,
  `StartTime` datetime(6) NOT NULL,
  `Comment` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`ID`),
  KEY `FK_ClientService_Client` (`ClientID`),
  KEY `FK_ClientService_Service` (`ServiceID`),
  CONSTRAINT `FK_ClientService_Client` FOREIGN KEY (`ClientID`) REFERENCES `client` (`ID`),
  CONSTRAINT `FK_ClientService_Service` FOREIGN KEY (`ServiceID`) REFERENCES `service` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientservice`
--

LOCK TABLES `clientservice` WRITE;
/*!40000 ALTER TABLE `clientservice` DISABLE KEYS */;
INSERT INTO `clientservice` VALUES (3,43,16,'2019-06-21 14:50:00.000000',NULL),(4,44,17,'2019-10-14 12:00:00.000000',NULL),(5,45,18,'2019-04-22 11:30:00.000000',NULL),(6,46,19,'2019-06-22 13:00:00.000000',NULL),(7,47,20,'2019-04-21 12:40:00.000000',NULL),(8,48,21,'2019-10-05 18:30:00.000000',NULL),(9,49,22,'2019-12-05 18:10:00.000000',NULL),(10,50,23,'2019-09-17 11:30:00.000000',NULL),(11,51,24,'2019-07-07 09:30:00.000000',NULL),(12,52,25,'2019-05-28 11:10:00.000000',NULL),(13,53,26,'2019-05-01 10:20:00.000000',NULL),(14,54,27,'2019-04-15 13:30:00.000000',NULL),(15,55,28,'2019-10-16 18:20:00.000000',NULL),(16,56,29,'2019-07-09 18:50:00.000000',NULL),(17,57,30,'2019-03-23 16:40:00.000000',NULL),(18,58,31,'2019-05-23 11:40:00.000000',NULL),(19,59,32,'2019-07-30 12:10:00.000000',NULL),(20,60,33,'2019-08-24 11:20:00.000000',NULL),(21,61,34,'2019-12-23 15:30:00.000000',NULL),(22,62,35,'2019-08-02 18:50:00.000000',NULL),(23,63,36,'2019-02-15 17:30:00.000000',NULL),(24,64,37,'2019-12-28 17:10:00.000000',NULL),(25,65,38,'2019-04-14 15:00:00.000000',NULL),(26,66,39,'2019-12-18 10:30:00.000000',NULL),(27,67,40,'2019-07-30 10:10:00.000000',NULL),(28,68,41,'2019-06-15 09:30:00.000000',NULL),(29,69,42,'2019-07-28 12:50:00.000000',NULL),(30,70,43,'2019-07-12 19:30:00.000000',NULL),(31,71,44,'2019-07-02 15:30:00.000000',NULL),(32,72,45,'2019-09-09 17:40:00.000000',NULL),(33,73,46,'2019-01-29 16:10:00.000000',NULL),(34,74,47,'2019-01-19 11:50:00.000000',NULL),(35,75,48,'2019-07-05 13:40:00.000000',NULL),(36,76,49,'2019-10-10 13:40:00.000000',NULL),(37,77,50,'2019-12-07 17:00:00.000000',NULL),(38,78,51,'2019-06-05 10:50:00.000000',NULL),(39,79,52,'2019-04-05 10:10:00.000000',NULL),(40,80,53,'2019-06-24 14:10:00.000000',NULL),(41,81,54,'2019-09-05 19:30:00.000000',NULL),(42,82,55,'2019-11-27 09:00:00.000000',NULL),(43,83,14,'2019-02-21 08:20:00.000000',NULL),(44,84,15,'2019-11-26 10:30:00.000000',NULL),(45,85,16,'2019-04-26 10:20:00.000000',NULL),(46,86,17,'2019-11-23 14:30:00.000000',NULL),(47,87,18,'2019-08-25 08:50:00.000000',NULL),(48,88,19,'2019-05-09 10:00:00.000000',NULL),(49,89,20,'2019-08-08 17:20:00.000000',NULL),(50,90,21,'2019-12-30 08:10:00.000000',NULL),(51,91,22,'2019-09-05 14:10:00.000000',NULL),(52,92,23,'2019-12-24 09:30:00.000000',NULL),(53,93,24,'2019-04-06 11:50:00.000000',NULL),(54,94,25,'2019-08-12 11:50:00.000000',NULL),(55,95,26,'2019-08-12 15:40:00.000000',NULL),(56,96,27,'2019-07-29 10:30:00.000000',NULL),(57,97,28,'2019-04-14 14:20:00.000000',NULL),(58,98,29,'2019-03-19 09:40:00.000000',NULL),(59,99,30,'2019-12-15 19:50:00.000000',NULL),(60,100,31,'2019-11-30 18:00:00.000000',NULL),(61,101,32,'2019-11-14 15:00:00.000000',NULL),(62,102,33,'2019-06-14 18:30:00.000000',NULL),(63,103,34,'2019-03-22 15:20:00.000000',NULL),(64,104,35,'2019-10-09 18:30:00.000000',NULL),(65,105,36,'2019-03-16 10:20:00.000000',NULL),(66,106,37,'2019-12-16 19:40:00.000000',NULL),(67,107,38,'2019-08-15 18:30:00.000000',NULL),(68,108,39,'2019-09-20 08:20:00.000000',NULL),(69,109,40,'2019-04-15 11:50:00.000000',NULL),(70,110,41,'2019-08-12 08:50:00.000000',NULL),(71,111,42,'2019-03-04 11:30:00.000000',NULL),(72,112,43,'2019-02-24 13:50:00.000000',NULL),(73,113,44,'2019-12-06 09:40:00.000000',NULL),(74,114,45,'2019-08-05 10:10:00.000000',NULL),(75,115,46,'2019-05-19 16:50:00.000000',NULL),(76,116,47,'2019-12-30 14:30:00.000000',NULL),(77,117,48,'2019-06-28 10:10:00.000000',NULL),(78,118,49,'2019-11-05 12:10:00.000000',NULL),(79,119,50,'2019-09-19 16:10:00.000000',NULL),(80,120,51,'2019-02-26 17:40:00.000000',NULL),(81,121,52,'2019-09-13 10:10:00.000000',NULL),(82,122,53,'2019-10-14 19:40:00.000000',NULL),(83,123,54,'2019-04-11 16:20:00.000000',NULL),(84,124,55,'2019-03-06 12:10:00.000000',NULL),(85,125,14,'2019-08-21 17:20:00.000000',NULL),(86,126,15,'2019-06-29 17:20:00.000000',NULL),(87,127,16,'2019-02-04 19:50:00.000000',NULL),(88,128,17,'2019-07-09 16:50:00.000000',NULL),(89,129,18,'2019-06-16 12:00:00.000000',NULL),(90,130,19,'2019-11-27 13:30:00.000000',NULL),(91,131,20,'2019-05-27 08:00:00.000000',NULL),(92,132,21,'2019-12-15 14:30:00.000000',NULL),(93,133,22,'2019-10-17 19:00:00.000000',NULL),(94,134,23,'2019-11-15 15:40:00.000000',NULL),(95,135,24,'2019-08-24 17:00:00.000000',NULL),(96,136,25,'2019-05-27 14:20:00.000000',NULL),(97,137,26,'2019-08-19 17:50:00.000000',NULL),(98,138,27,'2019-08-08 19:00:00.000000',NULL),(99,139,28,'2019-02-24 13:00:00.000000',NULL),(100,140,29,'2019-12-19 15:00:00.000000',NULL);
/*!40000 ALTER TABLE `clientservice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `documentbyservice`
--

DROP TABLE IF EXISTS `documentbyservice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `documentbyservice` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `ClientServiceID` int NOT NULL,
  `DocumentPath` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_DocumentByService_ClientService` (`ClientServiceID`),
  CONSTRAINT `FK_DocumentByService_ClientService` FOREIGN KEY (`ClientServiceID`) REFERENCES `clientservice` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `documentbyservice`
--

LOCK TABLES `documentbyservice` WRITE;
/*!40000 ALTER TABLE `documentbyservice` DISABLE KEYS */;
/*!40000 ALTER TABLE `documentbyservice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gender`
--

DROP TABLE IF EXISTS `gender`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gender` (
  `Code` char(1) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Name` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  PRIMARY KEY (`Code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gender`
--

LOCK TABLES `gender` WRITE;
/*!40000 ALTER TABLE `gender` DISABLE KEYS */;
INSERT INTO `gender` VALUES ('1','м'),('2','ж');
/*!40000 ALTER TABLE `gender` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `manufacturer`
--

DROP TABLE IF EXISTS `manufacturer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `manufacturer` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `StartDate` date DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `manufacturer`
--

LOCK TABLES `manufacturer` WRITE;
/*!40000 ALTER TABLE `manufacturer` DISABLE KEYS */;
/*!40000 ALTER TABLE `manufacturer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `meneger`
--

DROP TABLE IF EXISTS `meneger`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `meneger` (
  `idmeneger` int NOT NULL AUTO_INCREMENT,
  `FIO` varchar(45) DEFAULT NULL,
  `login` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idmeneger`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `meneger`
--

LOCK TABLES `meneger` WRITE;
/*!40000 ALTER TABLE `meneger` DISABLE KEYS */;
INSERT INTO `meneger` VALUES (1,'Тест','1','c4ca4238a0b923820dcc509a6f75849b');
/*!40000 ALTER TABLE `meneger` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Title` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Cost` decimal(19,4) NOT NULL,
  `Description` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `MainImagePath` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `IsActive` tinyint(1) NOT NULL,
  `ManufacturerID` int DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_Product_Manufacturer` (`ManufacturerID`),
  CONSTRAINT `FK_Product_Manufacturer` FOREIGN KEY (`ManufacturerID`) REFERENCES `manufacturer` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productphoto`
--

DROP TABLE IF EXISTS `productphoto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productphoto` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `ProductID` int NOT NULL,
  `PhotoPath` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_ProductPhoto_Product` (`ProductID`),
  CONSTRAINT `FK_ProductPhoto_Product` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productphoto`
--

LOCK TABLES `productphoto` WRITE;
/*!40000 ALTER TABLE `productphoto` DISABLE KEYS */;
/*!40000 ALTER TABLE `productphoto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productsale`
--

DROP TABLE IF EXISTS `productsale`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productsale` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `SaleDate` datetime(6) NOT NULL,
  `ProductID` int NOT NULL,
  `Quantity` int NOT NULL,
  `ClientServiceID` int DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_ProductSale_Product` (`ProductID`),
  KEY `FK_ProductSale_ClientService` (`ClientServiceID`),
  CONSTRAINT `FK_ProductSale_ClientService` FOREIGN KEY (`ClientServiceID`) REFERENCES `clientservice` (`ID`),
  CONSTRAINT `FK_ProductSale_Product` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productsale`
--

LOCK TABLES `productsale` WRITE;
/*!40000 ALTER TABLE `productsale` DISABLE KEYS */;
/*!40000 ALTER TABLE `productsale` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `service`
--

DROP TABLE IF EXISTS `service`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `service` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Title` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Cost` decimal(19,4) NOT NULL,
  `DurationInSeconds` int NOT NULL,
  `Description` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Discount` double DEFAULT NULL,
  `MainImagePath` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=56 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `service`
--

LOCK TABLES `service` WRITE;
/*!40000 ALTER TABLE `service` DISABLE KEYS */;
INSERT INTO `service` VALUES (14,'Замена сальника привода',3820.0000,34200,NULL,15,NULL),(15,'Замена кулисы АКПП',3250.0000,21600,NULL,10,NULL),(16,'Замена тормозной жидкости',2200.0000,21600,NULL,10,NULL),(17,'Ремонт компрессора кондиционера',4760.0000,9000,NULL,45,NULL),(18,'Ремонт автоэлектрики',4230.0000,27000,NULL,25,NULL),(19,'Наращивание ресниц',1430.0000,2400,NULL,5,NULL),(20,'Замена лямбда зонда',770.0000,16200,NULL,5,NULL),(21,'Кузовной ремонт',2750.0000,9000,NULL,5,NULL),(22,'Замена подшипника задней ступицы',1860.0000,16200,NULL,54,NULL),(23,'Замена заднего сальника АКПП',1510.0000,23400,NULL,76,NULL),(24,'Замена охлаждающей жидкости',1590.0000,12600,NULL,0,NULL),(25,'Замена масла АКПП',2430.0000,27000,NULL,76,NULL),(26,'Испанский массаж',2190.0000,2400,NULL,76,NULL),(27,'Балансировка колес',4690.0000,23400,NULL,54,NULL),(28,'Замена подшипника передней ступицы',4020.0000,19800,NULL,54,NULL),(29,'Замена сцепления',4320.0000,19800,NULL,0,NULL),(30,'Интенсивный курс с преподавателем-носителем португальского языка для компаний',1580.0000,1800,NULL,0,NULL),(31,'Замена подшипника компрессора кондиционера',1110.0000,19800,NULL,10,NULL),(32,'Замена фильтров',530.0000,19800,NULL,10,NULL),(33,'Ремонт глушителя',2100.0000,27000,NULL,10,NULL),(34,'Чистка форсунок ультразвуком',3920.0000,21600,NULL,5,NULL),(35,'Замена масла заднего редуктора (моста)',840.0000,21600,NULL,5,NULL),(36,'Антибактериальная обработка кондиционера',4580.0000,16200,NULL,5,NULL),(37,'Замена ремня кондиционера',4650.0000,21600,NULL,0,NULL),(38,'Ремонт и замена катализатора',500.0000,27000,NULL,10,NULL),(39,'Ремонт карданного вала',780.0000,16200,NULL,10,NULL),(40,'Установка сигнализации',1760.0000,27000,NULL,0,NULL),(41,'Ремонт кронштейна глушителя',1410.0000,16200,NULL,0,NULL),(42,'Замена трубки кондиционера',2810.0000,16200,NULL,10,NULL),(43,'Замена масла в вариаторе',4720.0000,34200,NULL,15,NULL),(44,'Замена тормозных колодок',4260.0000,34200,NULL,15,NULL),(45,'Покраска',2370.0000,16200,NULL,45,NULL),(46,'Ремонт сцепления',3290.0000,16200,NULL,25,NULL),(47,'Диагностика трансмиссии',2790.0000,16200,NULL,45,NULL),(48,'Диагностика выхлопной системы автомобиля',2550.0000,16200,NULL,15,NULL),(49,'Диагностика инжектора',3390.0000,16200,NULL,15,NULL),(50,'Ремонт стартера',2680.0000,16200,NULL,0,NULL),(51,'Снятие/установка форсунок',1470.0000,16200,NULL,15,NULL),(52,'Замена ремня привода ГУР',3350.0000,16200,NULL,0,NULL),(53,'Замена свечей',2240.0000,9000,NULL,15,NULL),(54,'Развал-схождение',3890.0000,9000,NULL,0,NULL),(55,'Замена рулевой тяги',570.0000,9000,NULL,0,NULL);
/*!40000 ALTER TABLE `service` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `servicephoto`
--

DROP TABLE IF EXISTS `servicephoto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `servicephoto` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `ServiceID` int NOT NULL,
  `PhotoPath` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_ServicePhoto_Service` (`ServiceID`),
  CONSTRAINT `FK_ServicePhoto_Service` FOREIGN KEY (`ServiceID`) REFERENCES `service` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `servicephoto`
--

LOCK TABLES `servicephoto` WRITE;
/*!40000 ALTER TABLE `servicephoto` DISABLE KEYS */;
/*!40000 ALTER TABLE `servicephoto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tag`
--

DROP TABLE IF EXISTS `tag`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tag` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Title` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Color` char(11) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tag`
--

LOCK TABLES `tag` WRITE;
/*!40000 ALTER TABLE `tag` DISABLE KEYS */;
INSERT INTO `tag` VALUES (3,'Тег 1','72,209,204'),(4,'Тег 2','128,128,0'),(5,'Тег 3 ','205,133,63'),(6,'Тег 4','205,92,92');
/*!40000 ALTER TABLE `tag` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tagofclient`
--

DROP TABLE IF EXISTS `tagofclient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tagofclient` (
  `ClientID` int NOT NULL,
  `TagID` int NOT NULL,
  PRIMARY KEY (`ClientID`,`TagID`),
  KEY `FK_TagOfClient_Tag` (`TagID`),
  CONSTRAINT `FK_TagOfClient_Client` FOREIGN KEY (`ClientID`) REFERENCES `client` (`ID`),
  CONSTRAINT `FK_TagOfClient_Tag` FOREIGN KEY (`TagID`) REFERENCES `tag` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tagofclient`
--

LOCK TABLES `tagofclient` WRITE;
/*!40000 ALTER TABLE `tagofclient` DISABLE KEYS */;
INSERT INTO `tagofclient` VALUES (46,3),(183,3),(184,3),(185,3),(44,4),(180,4),(181,4),(183,4),(184,4),(185,4),(44,5),(178,5),(180,5),(181,5),(184,5),(45,6),(184,6);
/*!40000 ALTER TABLE `tagofclient` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-04-05 14:07:37
