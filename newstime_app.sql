-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         Microsoft SQL Server 2019 (RTM-GDR) (KB4583458) - 15.0.2080.9
-- SO del servidor:              Windows 10 Pro 10.0 <X64> (Build 19043: )
-- HeidiSQL Versión:             11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES  */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para newstime_app
CREATE DATABASE IF NOT EXISTS "newstime_app";
USE "newstime_app";

-- Volcando estructura para tabla newstime_app.histories
CREATE TABLE IF NOT EXISTS "histories" (
	"Id" INT NOT NULL,
	"UserID" VARCHAR(255) NULL DEFAULT NULL COLLATE 'Latin1_General_CI_AI',
	"City" VARCHAR(100) NULL DEFAULT NULL COLLATE 'Latin1_General_CI_AI',
	"ObservationTime" VARCHAR(100) NULL DEFAULT NULL COLLATE 'Latin1_General_CI_AI',
	"Temperature" DECIMAL(5,2) NULL DEFAULT NULL,
	"WeatherDescriptions" VARCHAR(255) NULL DEFAULT NULL COLLATE 'Latin1_General_CI_AI',
	"WindSpeed" DECIMAL(5,2) NULL DEFAULT NULL,
	"WindDegree" INT NULL DEFAULT NULL,
	"WindDir" VARCHAR(20) NULL DEFAULT NULL COLLATE 'Latin1_General_CI_AI',
	"Pressure" INT NULL DEFAULT NULL,
	"Precip" INT NULL DEFAULT NULL,
	"Humidity" INT NULL DEFAULT NULL,
	"Cloudcover" INT NULL DEFAULT NULL,
	"Feelslike" INT NULL DEFAULT NULL,
	"UvIndex" INT NULL DEFAULT NULL,
	"Visibility" INT NULL DEFAULT NULL,
	PRIMARY KEY ("Id")
);

-- Volcando datos para la tabla newstime_app.histories: -1 rows
/*!40000 ALTER TABLE "histories" DISABLE KEYS */;
INSERT IGNORE INTO "histories" ("Id", "UserID", "City", "ObservationTime", "Temperature", "WeatherDescriptions", "WindSpeed", "WindDegree", "WindDir", "Pressure", "Precip", "Humidity", "Cloudcover", "Feelslike", "UvIndex", "Visibility") VALUES
	(0, NULL, 'cali', '28/10/2021', 292.15, 'moderate rain', 3.09, 360, 'N', 1010, 1, 94, 75, 0, 4, 10000),
	(1, NULL, 'cali', '29/10/2021', 292.15, 'broken clouds', 2.57, 340, 'N', 1017, -1, 94, 75, 0, 4, 10000),
	(2, NULL, 'bogota', '29/10/2021', 283.88, 'broken clouds', 1.03, 0, 'N', 1028, -1, 93, 75, 0, 4, 10000),
	(3, NULL, 'cali', '29/10/2021', 292.15, 'broken clouds', 2.57, 340, 'N', 1017, -1, 94, 75, 0, 4, 10000),
	(4, NULL, 'cali', '29/10/2021', 292.15, 'broken clouds', 2.57, 340, 'N', 1017, -1, 94, 75, 0, 4, 10000),
	(5, NULL, 'cali', '29/10/2021', 301.11, 'broken clouds', 2.06, 0, 'N', 906, -1, 54, 75, 0, 4, 10000),
	(6, NULL, 'cal', '29/10/2021', 305.81, 'scattered clouds', 1.59, 195, 'N', 1013, -1, 49, 37, 0, 4, 10000),
	(7, NULL, 'cal', '29/10/2021', 305.81, 'scattered clouds', 1.59, 195, 'N', 1013, -1, 49, 37, 0, 4, 10000),
	(8, NULL, 'cali', '29/10/2021', 301.11, 'broken clouds', 2.06, 0, 'N', 906, -1, 54, 75, 0, 4, 10000),
	(9, NULL, 'cali', '29/10/2021', 301.11, 'broken clouds', 2.06, 0, 'N', 906, -1, 54, 75, 0, 4, 10000),
	(10, NULL, 'cal', '29/10/2021', 305.81, 'scattered clouds', 1.59, 195, 'N', 1013, -1, 49, 37, 0, 4, 10000),
	(11, NULL, 'cal', '29/10/2021', 305.81, 'scattered clouds', 1.59, 195, 'N', 1013, -1, 49, 37, 0, 4, 10000),
	(12, NULL, 'cal', '29/10/2021', 305.81, 'scattered clouds', 1.59, 195, 'N', 1013, -1, 49, 37, 0, 4, 10000),
	(13, NULL, 'cali', '29/10/2021', 301.11, 'broken clouds', 2.06, 0, 'N', 906, -1, 54, 75, 0, 4, 10000),
	(14, NULL, 'cali', '29/10/2021', 301.11, 'broken clouds', 2.06, 0, 'N', 906, -1, 54, 75, 0, 4, 10000),
	(15, NULL, 'cali', '29/10/2021', 301.11, 'broken clouds', 2.06, 0, 'N', 906, -1, 54, 75, 0, 4, 10000),
	(16, NULL, 'cali', '29/10/2021', 301.11, 'broken clouds', 2.06, 0, 'N', 906, -1, 54, 75, 0, 4, 10000),
	(17, NULL, 'cal', '29/10/2021', 305.81, 'scattered clouds', 1.59, 195, 'N', 1013, -1, 49, 37, 0, 4, 10000),
	(18, NULL, 'cali', '29/10/2021', 301.11, 'broken clouds', 2.57, 350, 'N', 906, -1, 54, 75, 0, 4, 10000),
	(19, NULL, 'cali', '29/10/2021', 301.11, 'broken clouds', 2.57, 350, 'N', 906, -1, 54, 75, 0, 4, 10000),
	(20, NULL, 'cal', '29/10/2021', 305.81, 'scattered clouds', 1.59, 195, 'N', 1013, -1, 49, 37, 0, 4, 10000),
	(21, NULL, 'cal', '29/10/2021', 305.81, 'scattered clouds', 1.59, 195, 'N', 1013, -1, 49, 37, 0, 4, 10000),
	(22, NULL, 'cali', '29/10/2021', 301.11, 'broken clouds', 2.57, 350, 'N', 906, -1, 54, 75, 0, 4, 10000),
	(23, NULL, 'cali', '29/10/2021', 301.11, 'broken clouds', 2.57, 350, 'N', 906, -1, 54, 75, 0, 4, 10000),
	(24, NULL, 'cali', '29/10/2021', 301.11, 'broken clouds', 2.57, 350, 'N', 905, -1, 53, 75, 0, 4, 10000),
	(25, NULL, 'cali', '29/10/2021', 301.11, 'broken clouds', 2.57, 350, 'N', 905, -1, 53, 75, 0, 4, 10000),
	(26, NULL, 'cali', '29/10/2021', 301.11, 'broken clouds', 2.57, 350, 'N', 905, -1, 53, 75, 0, 4, 10000),
	(27, NULL, 'cali', '29/10/2021', 301.11, 'broken clouds', 2.57, 350, 'N', 905, -1, 53, 75, 0, 4, 10000),
	(28, NULL, 'cali', '29/10/2021', 301.11, 'broken clouds', 2.57, 350, 'N', 905, -1, 53, 75, 0, 4, 10000),
	(29, NULL, 'cali', '29/10/2021', 301.11, 'broken clouds', 2.57, 350, 'N', 905, -1, 53, 75, 0, 4, 10000),
	(30, NULL, 'cali', '29/10/2021', 301.11, 'broken clouds', 2.57, 350, 'N', 905, -1, 53, 75, 0, 4, 10000),
	(31, NULL, 'cali', '29/10/2021', 301.11, 'broken clouds', 2.57, 350, 'N', 905, -1, 53, 75, 0, 4, 10000),
	(32, NULL, 'cali', '29/10/2021', 301.11, 'broken clouds', 2.57, 350, 'N', 905, -1, 53, 75, 0, 4, 10000),
	(33, NULL, 'cali', '29/10/2021', 301.11, 'broken clouds', 2.57, 350, 'N', 905, -1, 53, 75, 0, 4, 10000);
/*!40000 ALTER TABLE "histories" ENABLE KEYS */;

-- Volcando estructura para tabla newstime_app.news
CREATE TABLE IF NOT EXISTS "news" (
	"NewId" INT NOT NULL,
	"Author" VARCHAR(255) NULL DEFAULT NULL COLLATE 'Latin1_General_CI_AI',
	"Title" VARCHAR(255) NULL DEFAULT NULL COLLATE 'Latin1_General_CI_AI',
	"Description" VARCHAR(255) NULL DEFAULT NULL COLLATE 'Latin1_General_CI_AI',
	"Url" VARCHAR(255) NULL DEFAULT NULL COLLATE 'Latin1_General_CI_AI',
	"UrlToImage" VARCHAR(255) NULL DEFAULT NULL COLLATE 'Latin1_General_CI_AI',
	"PublishedAt" VARCHAR(255) NULL DEFAULT NULL COLLATE 'Latin1_General_CI_AI',
	"Content" VARCHAR(255) NULL DEFAULT NULL COLLATE 'Latin1_General_CI_AI',
	"HistoryId" INT NULL DEFAULT NULL,
	PRIMARY KEY ("NewId"),
	FOREIGN KEY INDEX "FK__news__HistoryId__267ABA7A" ("HistoryId"),
	CONSTRAINT "FK__news__HistoryId__267ABA7A" FOREIGN KEY ("HistoryId") REFERENCES "histories" ("Id") ON UPDATE NO_ACTION ON DELETE NO_ACTION
);

-- Volcando datos para la tabla newstime_app.news: -1 rows
/*!40000 ALTER TABLE "news" DISABLE KEYS */;
/*!40000 ALTER TABLE "news" ENABLE KEYS */;

-- Volcando estructura para tabla newstime_app.w_descriptions
CREATE TABLE IF NOT EXISTS "w_descriptions" (
	"WDescId" INT NOT NULL,
	"Author" VARCHAR(255) NULL DEFAULT NULL COLLATE 'Latin1_General_CI_AI',
	"NewId" INT NULL DEFAULT NULL,
	PRIMARY KEY ("WDescId"),
	FOREIGN KEY INDEX "FK__w_descrip__NewId__29572725" ("NewId"),
	CONSTRAINT "FK__w_descrip__NewId__29572725" FOREIGN KEY ("NewId") REFERENCES "news" ("NewId") ON UPDATE NO_ACTION ON DELETE NO_ACTION
);

-- Volcando datos para la tabla newstime_app.w_descriptions: -1 rows
/*!40000 ALTER TABLE "w_descriptions" DISABLE KEYS */;
/*!40000 ALTER TABLE "w_descriptions" ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
