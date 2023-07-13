-- MySQL dump 10.16  Distrib 10.1.48-MariaDB, for debian-linux-gnu (x86_64)
--
-- Host: localhost    Database: db
-- ------------------------------------------------------
-- Server version	10.1.48-MariaDB-0+deb9u2

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `dbo.AspNetRoleClaims`
--

DROP TABLE IF EXISTS `dbo.AspNetRoleClaims`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.AspNetRoleClaims` (
  `Id` varchar(0) DEFAULT NULL,
  `RoleId` varchar(0) DEFAULT NULL,
  `ClaimType` varchar(0) DEFAULT NULL,
  `ClaimValue` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.AspNetRoleClaims`
--

LOCK TABLES `dbo.AspNetRoleClaims` WRITE;
/*!40000 ALTER TABLE `dbo.AspNetRoleClaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.AspNetRoleClaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.AspNetRoles`
--

DROP TABLE IF EXISTS `dbo.AspNetRoles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.AspNetRoles` (
  `Id` varchar(0) DEFAULT NULL,
  `Name` varchar(0) DEFAULT NULL,
  `NormalizedName` varchar(0) DEFAULT NULL,
  `ConcurrencyStamp` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.AspNetRoles`
--

LOCK TABLES `dbo.AspNetRoles` WRITE;
/*!40000 ALTER TABLE `dbo.AspNetRoles` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.AspNetRoles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.AspNetUserClaims`
--

DROP TABLE IF EXISTS `dbo.AspNetUserClaims`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.AspNetUserClaims` (
  `Id` varchar(0) DEFAULT NULL,
  `UserId` varchar(0) DEFAULT NULL,
  `ClaimType` varchar(0) DEFAULT NULL,
  `ClaimValue` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.AspNetUserClaims`
--

LOCK TABLES `dbo.AspNetUserClaims` WRITE;
/*!40000 ALTER TABLE `dbo.AspNetUserClaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.AspNetUserClaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.AspNetUserLogins`
--

DROP TABLE IF EXISTS `dbo.AspNetUserLogins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.AspNetUserLogins` (
  `LoginProvider` varchar(0) DEFAULT NULL,
  `ProviderKey` varchar(0) DEFAULT NULL,
  `ProviderDisplayName` varchar(0) DEFAULT NULL,
  `UserId` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.AspNetUserLogins`
--

LOCK TABLES `dbo.AspNetUserLogins` WRITE;
/*!40000 ALTER TABLE `dbo.AspNetUserLogins` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.AspNetUserLogins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.AspNetUserRiddles`
--

DROP TABLE IF EXISTS `dbo.AspNetUserRiddles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.AspNetUserRiddles` (
  `AspNetUserId` varchar(36) DEFAULT NULL,
  `RiddleId` varchar(36) DEFAULT NULL,
  `DateStarted` varchar(19) DEFAULT NULL,
  `DateEnded` varchar(19) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.AspNetUserRiddles`
--

LOCK TABLES `dbo.AspNetUserRiddles` WRITE;
/*!40000 ALTER TABLE `dbo.AspNetUserRiddles` DISABLE KEYS */;
INSERT INTO `dbo.AspNetUserRiddles` VALUES ('dcc59085-0e26-42cf-bf7e-a5cafd1827bb','7B0B753C-0A83-49E4-A353-3FF4BDA73C34','2023-07-13 16:12:44','2023-07-13 16:12:49'),('dcc59085-0e26-42cf-bf7e-a5cafd1827bb','79F90897-71C5-4E87-AB1C-724FE4F4616A','2023-07-13 16:12:53','2023-07-13 16:12:59'),('dcc59085-0e26-42cf-bf7e-a5cafd1827bb','0C6D3A5C-EA45-43DF-BA6C-7EB6A4D67663','2023-07-13 16:12:40','2023-07-13 16:12:44'),('dcc59085-0e26-42cf-bf7e-a5cafd1827bb','79783D19-DAE2-4760-9C0E-86D1B8B0AC1A','2023-07-13 16:13:08',''),('dcc59085-0e26-42cf-bf7e-a5cafd1827bb','CF1166EB-30D4-4788-9FF6-E061315AD489','2023-07-13 16:12:59','2023-07-13 16:13:08'),('dcc59085-0e26-42cf-bf7e-a5cafd1827bb','52A93A62-D820-4438-A25B-EC9960A2617C','2023-07-13 16:12:49','2023-07-13 16:12:53');
/*!40000 ALTER TABLE `dbo.AspNetUserRiddles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.AspNetUserRoles`
--

DROP TABLE IF EXISTS `dbo.AspNetUserRoles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.AspNetUserRoles` (
  `UserId` varchar(0) DEFAULT NULL,
  `RoleId` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.AspNetUserRoles`
--

LOCK TABLES `dbo.AspNetUserRoles` WRITE;
/*!40000 ALTER TABLE `dbo.AspNetUserRoles` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.AspNetUserRoles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.AspNetUserTokens`
--

DROP TABLE IF EXISTS `dbo.AspNetUserTokens`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.AspNetUserTokens` (
  `UserId` varchar(0) DEFAULT NULL,
  `LoginProvider` varchar(0) DEFAULT NULL,
  `Name` varchar(0) DEFAULT NULL,
  `Value` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.AspNetUserTokens`
--

LOCK TABLES `dbo.AspNetUserTokens` WRITE;
/*!40000 ALTER TABLE `dbo.AspNetUserTokens` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.AspNetUserTokens` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.AspNetUsers`
--

DROP TABLE IF EXISTS `dbo.AspNetUsers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.AspNetUsers` (
  `Id` varchar(36) DEFAULT NULL,
  `Discriminator` varchar(12) DEFAULT NULL,
  `UserName` varchar(21) DEFAULT NULL,
  `NormalizedUserName` varchar(21) DEFAULT NULL,
  `Email` varchar(21) DEFAULT NULL,
  `NormalizedEmail` varchar(21) DEFAULT NULL,
  `EmailConfirmed` tinyint(4) DEFAULT NULL,
  `PasswordHash` varchar(84) DEFAULT NULL,
  `SecurityStamp` varchar(32) DEFAULT NULL,
  `ConcurrencyStamp` varchar(36) DEFAULT NULL,
  `PhoneNumber` varchar(0) DEFAULT NULL,
  `PhoneNumberConfirmed` tinyint(4) DEFAULT NULL,
  `TwoFactorEnabled` tinyint(4) DEFAULT NULL,
  `LockoutEnd` varchar(36) DEFAULT NULL,
  `LockoutEnabled` tinyint(4) DEFAULT NULL,
  `AccessFailedCount` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.AspNetUsers`
--

LOCK TABLES `dbo.AspNetUsers` WRITE;
/*!40000 ALTER TABLE `dbo.AspNetUsers` DISABLE KEYS */;
INSERT INTO `dbo.AspNetUsers` VALUES ('b8647526-6914-40bb-b4a3-f8bdd1a812bc','IdentityUser','test@onet.pl','TEST@ONET.PL','test@onet.pl','TEST@ONET.PL',1,'AQAAAAIAAYagAAAAEJK5Er+PoNPw3FMidpml4cqkM4OiylGPfANM7A1w3LNkA4w3B8iVM1/Y/cVrWEDNAQ==','SEAUNW3HHSCMIA7UFK67B3CUNJNCJF4N','937e5096-2428-43b5-bfde-1e135b9257e2','',0,0,'unknown_value_please_contact_support',1,0),('dcc59085-0e26-42cf-bf7e-a5cafd1827bb','IdentityUser','mikolajbialek@onet.pl','MIKOLAJBIALEK@ONET.PL','mikolajbialek@onet.pl','MIKOLAJBIALEK@ONET.PL',1,'AQAAAAIAAYagAAAAEF/05GGFKKtK3IhP8luh3HCZC1ySYOz1mKaahzMFA7x8CXpRzy2GMWqIRD4oJwAeag==','3HC5I3CAPYHFB2MHEUHSRHRKIX46NDJV','df1adabe-ec70-46bc-9afe-e4b07dcf1712','',0,0,'unknown_value_please_contact_support',1,0);
/*!40000 ALTER TABLE `dbo.AspNetUsers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.Riddles`
--

DROP TABLE IF EXISTS `dbo.Riddles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.Riddles` (
  `Id` varchar(36) DEFAULT NULL,
  `Number` tinyint(4) DEFAULT NULL,
  `Url` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.Riddles`
--

LOCK TABLES `dbo.Riddles` WRITE;
/*!40000 ALTER TABLE `dbo.Riddles` DISABLE KEYS */;
INSERT INTO `dbo.Riddles` VALUES ('7B0B753C-0A83-49E4-A353-3FF4BDA73C34',2,'Nic'),('79F90897-71C5-4E87-AB1C-724FE4F4616A',4,'StrusAfrykanski'),('0C6D3A5C-EA45-43DF-BA6C-7EB6A4D67663',1,'Start'),('79783D19-DAE2-4760-9C0E-86D1B8B0AC1A',6,'Szpaku'),('CF1166EB-30D4-4788-9FF6-E061315AD489',5,'Bajka'),('52A93A62-D820-4438-A25B-EC9960A2617C',3,'Orzel');
/*!40000 ALTER TABLE `dbo.Riddles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.__EFMigrationsHistory`
--

DROP TABLE IF EXISTS `dbo.__EFMigrationsHistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.__EFMigrationsHistory` (
  `MigrationId` varchar(22) DEFAULT NULL,
  `ProductVersion` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.__EFMigrationsHistory`
--

LOCK TABLES `dbo.__EFMigrationsHistory` WRITE;
/*!40000 ALTER TABLE `dbo.__EFMigrationsHistory` DISABLE KEYS */;
INSERT INTO `dbo.__EFMigrationsHistory` VALUES ('20230713141043_Initial','7.0.8');
/*!40000 ALTER TABLE `dbo.__EFMigrationsHistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dbo.sysdiagrams`
--

DROP TABLE IF EXISTS `dbo.sysdiagrams`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dbo.sysdiagrams` (
  `name` varchar(0) DEFAULT NULL,
  `principal_id` varchar(0) DEFAULT NULL,
  `diagram_id` varchar(0) DEFAULT NULL,
  `version` varchar(0) DEFAULT NULL,
  `definition` varchar(0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dbo.sysdiagrams`
--

LOCK TABLES `dbo.sysdiagrams` WRITE;
/*!40000 ALTER TABLE `dbo.sysdiagrams` DISABLE KEYS */;
/*!40000 ALTER TABLE `dbo.sysdiagrams` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-12-27 22:44:48
