-- MySQL dump 10.13  Distrib 8.3.0, for Win64 (x86_64)
--
-- Host: localhost    Database: school_csbca2402
-- ------------------------------------------------------
-- Server version	8.3.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `student` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) DEFAULT NULL,
  `gender` char(1) DEFAULT NULL,
  `class_roll_no` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `student_chk_1` CHECK (((`class_roll_no` >= 1) and (`class_roll_no` <= 60)))
) ENGINE=InnoDB AUTO_INCREMENT=92 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student`
--

LOCK TABLES `student` WRITE;
/*!40000 ALTER TABLE `student` DISABLE KEYS */;
INSERT INTO `student` VALUES (1,'John Doe','M',1),(2,'Shubham Kumar','M',45),(3,'Iarbor Majaw','M',5),(4,'koji kun','M',6),(5,'Shreenidhi','F',18),(6,'Peter Parker','M',22),(7,'Maxwel','M',6),(8,'Robbin Ransom','M',23),(9,'Harry Porter','M',24),(10,'James Fischer','M',24),(11,'Gojo Saturo','M',9),(12,'Aditya Kumar','M',4),(13,'Amit','M',7),(14,'Rakesh','M',12),(15,'Vishal','M',8),(16,'Kai','F',7),(17,'Shubham','M',9),(18,'Gren','F',2),(19,'Adarsh','m',10),(20,'Gurpreet Kaur','F',8),(21,'Afnan Irfan','M',27),(22,'Kashif Alam','M',28),(23,'Saif','M',1),(24,'Afnan','M',6),(25,'Taushif','M',4),(26,'Rock','M',8),(27,'Cassandra Hynnewta','F',18),(28,'Sahil','M',13),(29,'Vaishali','F',11),(30,'Priyanka Agarwal','F',18),(31,'Zain','M',19),(32,'Rakhi Surana','F',45),(33,'Ritik Kumar','M',27),(34,'Vishwajeet Kumar','M',29),(35,'Haider','M',29),(36,'Muskaan','F',39),(37,'Tanveer','M',31),(38,'Salman Rahmani','M',32),(39,'Shubham Kumar','M',30),(40,'Rakesh','M',12),(41,'Ranjan','M',15),(42,'Max','M',34),(43,'Harry','M',38),(44,'Anjana','F',25),(45,'Shurili','F',29),(46,'Manisha','F',12),(47,'Ada','F',33),(48,'Kanchan','F',13),(49,'Sadiya','F',14),(50,'Perk Peterson','M',37),(51,'Emma Whatson','F',35),(52,'Kamla Harris','F',36),(53,'David Miller','M',38),(54,'Shan Whatson','M',39),(55,'Sam','F',40),(56,'Resham','F',14),(57,'Lami','F',41),(58,'Tanvi','F',15),(59,'Liza','F',42),(60,'Aliza','F',43),(61,'Yusuf Pathan','M',11),(62,'Suman Kumari','F',56),(63,'Virat Kohli','M',40),(64,'Rahul Dravid','M',41),(65,'Sunita Williams','F',42),(66,'RD Sharma','M',43),(67,'M S Dhoni','M',44),(68,'jenna','F',44),(69,'Alia Bhatt','F',16),(70,'Suman Jain','F',23),(71,'Samii','F',45),(72,'Suman meri jaan','F',46),(73,'Michael','M',41),(74,'Deepika','F',17),(75,'prakash deep','F',17),(76,'Nal','F',46),(77,'Ranjanaa','F',11),(78,'Rani','F',18),(79,'Virat Thakur','M',12),(80,'prakash deep','M',19),(81,'Sakayanagi','F',47),(82,'Raju','M',20),(83,'Mani','M',6),(84,'Magnus Karlson','M',49),(85,'David Warner','M',48),(86,'Sakshi Mallik','F',47),(87,'sonu Kumar','M',46),(88,'Ravindra Jadeja','M',45),(89,'MANSHI SHUKLA','F',49),(90,'Rakhi Goenka','F',15),(91,'Virat Thakur','M',12);
/*!40000 ALTER TABLE `student` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-07-25 11:37:16
