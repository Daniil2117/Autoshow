USE [master]
GO
/****** Object:  Database [Autoshow]    Script Date: 13.12.2021 0:15:17 ******/
CREATE DATABASE [Autoshow]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Autoshow', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Autoshow.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Autoshow_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Autoshow_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Autoshow] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Autoshow].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Autoshow] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Autoshow] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Autoshow] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Autoshow] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Autoshow] SET ARITHABORT OFF 
GO
ALTER DATABASE [Autoshow] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Autoshow] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Autoshow] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Autoshow] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Autoshow] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Autoshow] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Autoshow] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Autoshow] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Autoshow] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Autoshow] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Autoshow] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Autoshow] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Autoshow] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Autoshow] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Autoshow] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Autoshow] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Autoshow] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Autoshow] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Autoshow] SET  MULTI_USER 
GO
ALTER DATABASE [Autoshow] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Autoshow] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Autoshow] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Autoshow] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Autoshow] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Autoshow] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Autoshow] SET QUERY_STORE = OFF
GO
USE [Autoshow]
GO
/****** Object:  Table [dbo].[Carmodels]    Script Date: 13.12.2021 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carmodels](
	[key_model] [int] NOT NULL,
	[modelcar] [nvarchar](55) NULL,
	[speed_km/h] [int] NULL,
	[fuel_consumption_л/100km] [decimal](3, 1) NULL,
	[transmission] [nvarchar](30) NULL,
	[engines_type] [nvarchar](30) NULL,
	[photocar] [nvarchar](100) NULL,
	[year_of_issue] [int] NULL,
	[CountryCode] [nvarchar](3) NULL,
PRIMARY KEY CLUSTERED 
(
	[key_model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contracts]    Script Date: 13.12.2021 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contracts](
	[num_contracts] [int] NOT NULL,
	[key_customers] [int] NULL,
	[key_model] [int] NULL,
	[datezakaz] [date] NULL,
	[carprice] [money] NULL,
	[datepayment] [date] NULL,
	[key_employee] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[num_contracts] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 13.12.2021 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[CountryCode] [nvarchar](3) NOT NULL,
	[CountryName] [nvarchar](35) NULL,
PRIMARY KEY CLUSTERED 
(
	[CountryCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 13.12.2021 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[key_customers] [int] IDENTITY(1,1) NOT NULL,
	[lastname] [nvarchar](60) NULL,
	[city] [nvarchar](35) NULL,
	[address] [nvarchar](75) NULL,
	[tel] [nvarchar](11) NULL,
	[email] [nvarchar](300) NULL,
	[firsname] [nvarchar](80) NULL,
PRIMARY KEY CLUSTERED 
(
	[key_customers] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 13.12.2021 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[key_employee] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [nvarchar](40) NULL,
	[lastname] [nvarchar](60) NULL,
	[patronymic] [nvarchar](40) NULL,
	[position] [nvarchar](35) NULL,
	[datehiring] [date] NULL,
	[tel] [nvarchar](11) NULL,
	[email] [nvarchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[key_employee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 13.12.2021 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleId] [nchar](1) NOT NULL,
	[RoleName] [nvarchar](35) NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 13.12.2021 0:15:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Email] [nvarchar](300) NOT NULL,
	[Password] [nvarchar](50) NULL,
	[FirstName] [nvarchar](35) NULL,
	[LastName] [nvarchar](35) NULL,
	[RoleId] [nchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Carmodels] ([key_model], [modelcar], [speed_km/h], [fuel_consumption_л/100km], [transmission], [engines_type], [photocar], [year_of_issue], [CountryCode]) VALUES (23456, N'Audi Q7', 245, CAST(10.7 AS Decimal(3, 1)), N'automatic', N'petrol', N'AudiQ7.jpg', 2005, N'GER')
INSERT [dbo].[Carmodels] ([key_model], [modelcar], [speed_km/h], [fuel_consumption_л/100km], [transmission], [engines_type], [photocar], [year_of_issue], [CountryCode]) VALUES (23488, N'Bentley Mulsanne
', 296, CAST(16.9 AS Decimal(3, 1)), N'automatic', N'petrol', N'BentleyMulsanne.jpg', 2010, N'GBR')
INSERT [dbo].[Carmodels] ([key_model], [modelcar], [speed_km/h], [fuel_consumption_л/100km], [transmission], [engines_type], [photocar], [year_of_issue], [CountryCode]) VALUES (43256, N'Toyota Prius
', 180, CAST(3.9 AS Decimal(3, 1)), N'automatic', N'petrol', N'ToyotaPrius.jpg', 2009, N'JPN')
INSERT [dbo].[Carmodels] ([key_model], [modelcar], [speed_km/h], [fuel_consumption_л/100km], [transmission], [engines_type], [photocar], [year_of_issue], [CountryCode]) VALUES (44566, N'Porsche Panamera
', 285, CAST(12.5 AS Decimal(3, 1)), N'automatic', N'petrol', N'PorschePanamera.jpg', 2009, N'GER')
INSERT [dbo].[Carmodels] ([key_model], [modelcar], [speed_km/h], [fuel_consumption_л/100km], [transmission], [engines_type], [photocar], [year_of_issue], [CountryCode]) VALUES (45645, N'BMW M3
', 250, CAST(12.4 AS Decimal(3, 1)), N'automatic', N'petrol', N'BMWM3.jpg', 2007, N'GER')
INSERT [dbo].[Carmodels] ([key_model], [modelcar], [speed_km/h], [fuel_consumption_л/100km], [transmission], [engines_type], [photocar], [year_of_issue], [CountryCode]) VALUES (45664, N'Ford Kuga
', 192, CAST(7.7 AS Decimal(3, 1)), N'mechanical', N'diesel', N'FordKuga.jpg', 2012, N'USA')
INSERT [dbo].[Carmodels] ([key_model], [modelcar], [speed_km/h], [fuel_consumption_л/100km], [transmission], [engines_type], [photocar], [year_of_issue], [CountryCode]) VALUES (45679, N'Cadillac Escalade
', 200, CAST(14.0 AS Decimal(3, 1)), N'automatic', N'petrol', N'CadillacEscalade.jpg', 1998, N'USA')
INSERT [dbo].[Carmodels] ([key_model], [modelcar], [speed_km/h], [fuel_consumption_л/100km], [transmission], [engines_type], [photocar], [year_of_issue], [CountryCode]) VALUES (54656, N'Jaguar XKR
', 300, CAST(16.8 AS Decimal(3, 1)), N'automatic', N'petrol', N'JaguarXKR.jpg', 1998, N'GBR')
INSERT [dbo].[Carmodels] ([key_model], [modelcar], [speed_km/h], [fuel_consumption_л/100km], [transmission], [engines_type], [photocar], [year_of_issue], [CountryCode]) VALUES (59956, N'Honda Jazz
', 175, CAST(3.6 AS Decimal(3, 1)), N'automatic', N'petrol', N'HondaJazz.jpg', 2001, N'JPN')
INSERT [dbo].[Carmodels] ([key_model], [modelcar], [speed_km/h], [fuel_consumption_л/100km], [transmission], [engines_type], [photocar], [year_of_issue], [CountryCode]) VALUES (64656, N'Renault Duster
', 194, CAST(5.3 AS Decimal(3, 1)), N'automatic', N'petrol', N'RenaultDuster.jpg', 2009, N'FRA')
INSERT [dbo].[Carmodels] ([key_model], [modelcar], [speed_km/h], [fuel_consumption_л/100km], [transmission], [engines_type], [photocar], [year_of_issue], [CountryCode]) VALUES (68767, N'Lexus SC
', 250, CAST(13.8 AS Decimal(3, 1)), N'automatic', N'petrol', N'LexusSC.jpg', 2001, N'JPN')
INSERT [dbo].[Carmodels] ([key_model], [modelcar], [speed_km/h], [fuel_consumption_л/100km], [transmission], [engines_type], [photocar], [year_of_issue], [CountryCode]) VALUES (76687, N'Dodge Nitro
', 200, CAST(13.8 AS Decimal(3, 1)), N'automatic', N'petrol', N'DodgeNitro.jpg', 2006, N'USA')
INSERT [dbo].[Carmodels] ([key_model], [modelcar], [speed_km/h], [fuel_consumption_л/100km], [transmission], [engines_type], [photocar], [year_of_issue], [CountryCode]) VALUES (78678, N'Mercedes S
', 190, CAST(9.3 AS Decimal(3, 1)), N'automatic', N'petrol', N'MercedesS.jpg', 2013, N'GER')
INSERT [dbo].[Carmodels] ([key_model], [modelcar], [speed_km/h], [fuel_consumption_л/100km], [transmission], [engines_type], [photocar], [year_of_issue], [CountryCode]) VALUES (78789, N'BMW X6M
', 250, CAST(10.0 AS Decimal(3, 1)), N'automatic', N'diesel', N'BMWX6M.jpg', 2008, N'GER')
INSERT [dbo].[Carmodels] ([key_model], [modelcar], [speed_km/h], [fuel_consumption_л/100km], [transmission], [engines_type], [photocar], [year_of_issue], [CountryCode]) VALUES (98009, N'Chevrolet Camaro
', 250, CAST(14.0 AS Decimal(3, 1)), N'automatic', N'petrol', N'ChevroletCamaro.jpg', 1966, N'USA')
GO
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'AND', N'Andorra')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'ARG', N'Argentina')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'AUS', N'Australia')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'AUT', N'Austria')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'BEL', N'Belgium')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'BOT', N'Botswana')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'BRA', N'Brazil')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'BUL', N'Bulgaria')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'CAF', N'Central African Republic')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'CAN', N'Canada')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'CHI', N'Chile')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'CHN', N'China')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'CIV', N'Ivory Coast')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'CMR', N'Cameroon')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'COL', N'Colombia')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'CRO', N'Croatia')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'CZE', N'Czech Republic')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'DEN', N'Denmark')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'DOM', N'Dominican Republic')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'ECU', N'Ecuador')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'EGY', N'Egypt')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'ESA', N'El Salvador')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'ESP', N'Spain')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'EST', N'Estonia')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'FIN', N'Finland')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'FRA', N'France')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'GBR', N'United Kingdom')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'GBS', N'Guinea-Bissau')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'GEQ', N'Equatorial Guinea')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'GER', N'Germany')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'GRE', N'Greece')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'GUA', N'Guatemala')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'GUI', N'Guinea')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'HKG', N'Hong Kong')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'HON', N'Honduras')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'HUN', N'Hungary')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'INA', N'Indonesia')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'IND', N'India')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'IRL', N'Ireland')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'ISR', N'Israel')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'ITA', N'Italy')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'JAM', N'Jamaica')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'JOR', N'Jordan')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'JPN', N'Japan')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'KEN', N'Kenya')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'KOR', N'South Korea')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'KSA', N'Saudi Arabia')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'LAT', N'Latvia')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'LIE', N'Liechtenstein')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'LTU', N'Lithuania')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'LUX', N'Luxembourg')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'MAC', N'Macau')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'MAD', N'Madagascar')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'MAS', N'Malaysia')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'MDA', N'Moldova')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'MEX', N'Mexico')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'MKD', N'Macedonia')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'MLI', N'Mali')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'MLT', N'Malta')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'MNE', N'Montenegro')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'MON', N'Monaco')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'MRI', N'Mauritius')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'NCA', N'Nicaragua')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'NED', N'Netherlands')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'NIG', N'Niger')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'NOR', N'Norway')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'NZL', N'New Zealand')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'PAN', N'Panama')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'PAR', N'Paraguay')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'PER', N'Peru')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'PHI', N'Philippines')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'POL', N'Poland')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'POR', N'Portugal')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'PUR', N'Puerto Rico')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'QAT', N'Qatar')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'ROU', N'Romania')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'RSA', N'South Africa')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'RUS', N'Russia')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'SEN', N'Senegal')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'SIN', N'Singapore')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'SUI', N'Switzerland')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'SVK', N'Slovakia')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'SWE', N'Sweden')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'THA', N'Thailand')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'TPE', N'Chinese Taipei')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'TUR', N'Turkey')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'UAE', N'United Arab Emirates')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'URU', N'Uruguay')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'USA', N'United States')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'VAT', N'Vatican')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'VEN', N'Venezuela')
INSERT [dbo].[Country] ([CountryCode], [CountryName]) VALUES (N'VIE', N'Vietnam')
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([key_customers], [lastname], [city], [address], [tel], [email], [firsname]) VALUES (2, N'Журавлев ', N'Санкт-Петербург', N'Кондратевский д.78', N'795434543', N'juravlev@mail.ru', N'Никита')
INSERT [dbo].[Customers] ([key_customers], [lastname], [city], [address], [tel], [email], [firsname]) VALUES (3, N'Компотов', N'Санкт-Петербург', N'Большевиков д.56', N'794234321', N'compot22@mail.ru', N'Александр')
INSERT [dbo].[Customers] ([key_customers], [lastname], [city], [address], [tel], [email], [firsname]) VALUES (4, N'Дмитриев', N'Всеволожск', N'Шишканя д.33', N'799903267', N'dmit25@mail.ru', N'Артём')
INSERT [dbo].[Customers] ([key_customers], [lastname], [city], [address], [tel], [email], [firsname]) VALUES (5, N'Вайнбергер', N'Санкт-Петербург', N'Лисий нос д.55', N'794342466', N'granada2@mail.ru', N'Эвальд')
INSERT [dbo].[Customers] ([key_customers], [lastname], [city], [address], [tel], [email], [firsname]) VALUES (6, N'Прокоп', N'Санкт-Петербург', N'Кондрат д.95', N'79650023344', N'prokop22@mail.ru', NULL)
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([key_employee], [firstname], [lastname], [patronymic], [position], [datehiring], [tel], [email]) VALUES (6, N'Даниил', N'Божко', N'Артёмович', N'владелец', CAST(N'2020-07-21' AS Date), N'896500177', N'bozhko2003@mail.ru')
INSERT [dbo].[Employees] ([key_employee], [firstname], [lastname], [patronymic], [position], [datehiring], [tel], [email]) VALUES (7, N'Мухаммед', N'Вохидов', N'Муродович', N'управляющий', CAST(N'2020-10-07' AS Date), N'895433232', N'muh33@mail.ru')
INSERT [dbo].[Employees] ([key_employee], [firstname], [lastname], [patronymic], [position], [datehiring], [tel], [email]) VALUES (8, N'Анастасия', N'Смирнова', N'Владимировна', N'менеджер', CAST(N'2020-12-11' AS Date), N'894545433', N'smirnov21@mail.ru')
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (N'C', N'Customer')
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (N'E', N'Employee')
GO
INSERT [dbo].[User] ([Email], [Password], [FirstName], [LastName], [RoleId]) VALUES (N'bozhko2003@mail.ru', N'Ige4sauD$', N'Даниил', N'Божко', N'E')
INSERT [dbo].[User] ([Email], [Password], [FirstName], [LastName], [RoleId]) VALUES (N'compot22@mail.ru', N'Com33pot$$', N'Александр', N'Компотов', N'C')
INSERT [dbo].[User] ([Email], [Password], [FirstName], [LastName], [RoleId]) VALUES (N'dmit25@mail.ru', N'Dmit25#', N'Артём', N'Дмитриев', N'C')
INSERT [dbo].[User] ([Email], [Password], [FirstName], [LastName], [RoleId]) VALUES (N'granada2@mail.ru', N'Grand3#', N'Эвальд', N'Вайнбергер', N'C')
INSERT [dbo].[User] ([Email], [Password], [FirstName], [LastName], [RoleId]) VALUES (N'juravlev@mail.ru', N'Jur34sd!', N'Никита', N'Журавлев', N'C')
INSERT [dbo].[User] ([Email], [Password], [FirstName], [LastName], [RoleId]) VALUES (N'muh33@mail.ru', N'Muh25$', N'Мухаммед', N'Вохидов', N'E')
INSERT [dbo].[User] ([Email], [Password], [FirstName], [LastName], [RoleId]) VALUES (N'prokop@mail.ru', N'Ige4saUdd#', N'Святослав', N'Прокопов', N'C')
INSERT [dbo].[User] ([Email], [Password], [FirstName], [LastName], [RoleId]) VALUES (N'prokop2@mail.ru', N'Ige4saUdd#', N'Святослав', N'Прокопов', N'C')
INSERT [dbo].[User] ([Email], [Password], [FirstName], [LastName], [RoleId]) VALUES (N'prokop22@mail.ru', N'Ige4saUDD#', N'Святослав', N'Прокоп', N'C')
INSERT [dbo].[User] ([Email], [Password], [FirstName], [LastName], [RoleId]) VALUES (N'smirnov21@mail.ru', N'Smir56ff@', N'Анастасия', N'Смирнова', N'E')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__User__A9D10534F3F0C8C8]    Script Date: 13.12.2021 0:15:17 ******/
ALTER TABLE [dbo].[User] ADD UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Carmodels]  WITH CHECK ADD FOREIGN KEY([CountryCode])
REFERENCES [dbo].[Country] ([CountryCode])
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD FOREIGN KEY([key_customers])
REFERENCES [dbo].[Customers] ([key_customers])
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD FOREIGN KEY([key_employee])
REFERENCES [dbo].[Employees] ([key_employee])
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD FOREIGN KEY([key_model])
REFERENCES [dbo].[Carmodels] ([key_model])
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD FOREIGN KEY([email])
REFERENCES [dbo].[User] ([Email])
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD FOREIGN KEY([email])
REFERENCES [dbo].[User] ([Email])
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([RoleId])
GO
USE [master]
GO
ALTER DATABASE [Autoshow] SET  READ_WRITE 
GO
