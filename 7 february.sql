USE [Lavka]
GO
/****** Object:  Table [dbo].[condition]    Script Date: 07.02.2021 15:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[condition](
	[condition] [int] IDENTITY(1,1) NOT NULL,
	[descriptionofcondition] [nvarchar](max) NULL,
 CONSTRAINT [PK_condition] PRIMARY KEY CLUSTERED 
(
	[condition] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[things]    Script Date: 07.02.2021 15:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[things](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[description] [nvarchar](max) NULL,
	[count] [int] NOT NULL,
	[condition] [int] NOT NULL,
	[price] [money] NOT NULL,
	[image] [varbinary](max) NULL,
 CONSTRAINT [PK_things] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 07.02.2021 15:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [nvarchar](max) NOT NULL,
	[lastname] [nvarchar](max) NOT NULL,
	[login] [nvarchar](max) NOT NULL,
	[password] [nvarchar](max) NOT NULL,
	[role] [int] NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[condition] ON 

INSERT [dbo].[condition] ([condition], [descriptionofcondition]) VALUES (1, N'Отличное')
INSERT [dbo].[condition] ([condition], [descriptionofcondition]) VALUES (2, N'Среднее')
INSERT [dbo].[condition] ([condition], [descriptionofcondition]) VALUES (3, N'Плохое')
SET IDENTITY_INSERT [dbo].[condition] OFF
GO
SET IDENTITY_INSERT [dbo].[things] ON 

INSERT [dbo].[things] ([id], [name], [description], [count], [condition], [price], [image]) VALUES (1, N' Патефон Малютка', N' Предназначен для воспроизведения пластинок', 1, 1, 6500.0000, NULL)
INSERT [dbo].[things] ([id], [name], [description], [count], [condition], [price], [image]) VALUES (2, N' Самовар Жар Птица', N' Чай из него получается просто сказочным!', 2, 1, 2300.0000, NULL)
INSERT [dbo].[things] ([id], [name], [description], [count], [condition], [price], [image]) VALUES (3, N' Монета Царская', N' Почувствуй себя царем', 15, 3, 500.0000, NULL)
INSERT [dbo].[things] ([id], [name], [description], [count], [condition], [price], [image]) VALUES (4, N' Видеомагнитофон VS-203', N' Для ценителей одноголосых переводов старых фильмов', 3, 2, 1000.0000, NULL)
INSERT [dbo].[things] ([id], [name], [description], [count], [condition], [price], [image]) VALUES (5, N' Игровая приставка Денди', N' Мечта подростка 90-х', 1, 2, 1200.0000, NULL)
INSERT [dbo].[things] ([id], [name], [description], [count], [condition], [price], [image]) VALUES (6, N' Мобильный телефон моторола с350', N' Классика не выходит из моды', 7, 1, 800.0000, NULL)
INSERT [dbo].[things] ([id], [name], [description], [count], [condition], [price], [image]) VALUES (7, N' Фотоаппарат Регина', N' Когда-то люди делали фото не для Инстаграмма', 1, 1, 8000.0000, NULL)
INSERT [dbo].[things] ([id], [name], [description], [count], [condition], [price], [image]) VALUES (8, N' Печатная машинка Олимпия', N' Для написания бестселлера', 1, 2, 7500.0000, NULL)
INSERT [dbo].[things] ([id], [name], [description], [count], [condition], [price], [image]) VALUES (9, N' Утюг ручной', N' Когда нет электиречества но в мятом идти не вариант', 4, 3, 4100.0000, NULL)
INSERT [dbo].[things] ([id], [name], [description], [count], [condition], [price], [image]) VALUES (10, N' Подстаканник Советский', N' Ощути романтику чая в поезде', 17, 1, 750.0000, NULL)
INSERT [dbo].[things] ([id], [name], [description], [count], [condition], [price], [image]) VALUES (11, N' Портсигар серебрянный', N' Для настоящих ценителей', 9, 1, 650.0000, NULL)
INSERT [dbo].[things] ([id], [name], [description], [count], [condition], [price], [image]) VALUES (12, N' Китайский чайник', N' Настоящий чай из настоящего чайника', 5, 2, 200.0000, NULL)
INSERT [dbo].[things] ([id], [name], [description], [count], [condition], [price], [image]) VALUES (13, N' Стационарный телефон Красная Заря', N' Для деловых переговоров', 2, 3, 3200.0000, NULL)
INSERT [dbo].[things] ([id], [name], [description], [count], [condition], [price], [image]) VALUES (14, N' Часы настольные', N' Чтобы точно знать время', 4, 1, 500.0000, NULL)
INSERT [dbo].[things] ([id], [name], [description], [count], [condition], [price], [image]) VALUES (15, N' Пудреница Роза', N' Дамские штучки', 10, 2, 350.0000, NULL)
INSERT [dbo].[things] ([id], [name], [description], [count], [condition], [price], [image]) VALUES (16, N' Шкатулка Ангельская', N' Ваши вещи под божественной охраной', 1, 1, 4600.0000, NULL)
INSERT [dbo].[things] ([id], [name], [description], [count], [condition], [price], [image]) VALUES (17, N' Театральный бинокль', N' Если билеты остались только на балкон', 8, 2, 980.0000, NULL)
INSERT [dbo].[things] ([id], [name], [description], [count], [condition], [price], [image]) VALUES (18, N' Сахарница Ленинград', N' И пусть соседка позавидует', 15, 1, 1000.0000, NULL)
INSERT [dbo].[things] ([id], [name], [description], [count], [condition], [price], [image]) VALUES (19, N' Швейная машинка', N' Если ваши вещи опять порвались', 6, 1, 3000.0000, NULL)
SET IDENTITY_INSERT [dbo].[things] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([id], [firstname], [lastname], [login], [password], [role]) VALUES (1, N'Дарина', N'Григорьева', N'admin', N'admin', 1)
INSERT [dbo].[users] ([id], [firstname], [lastname], [login], [password], [role]) VALUES (2, N'Иван', N'Поддубный', N'admin2', N'admin2', 1)
INSERT [dbo].[users] ([id], [firstname], [lastname], [login], [password], [role]) VALUES (3, N'Студент', N'314', N'student', N'student', 0)
INSERT [dbo].[users] ([id], [firstname], [lastname], [login], [password], [role]) VALUES (5, N'tesst', N'Тестовый', N'test', N'test', 0)
SET IDENTITY_INSERT [dbo].[users] OFF
GO
ALTER TABLE [dbo].[things]  WITH CHECK ADD  CONSTRAINT [FK_things_condition] FOREIGN KEY([condition])
REFERENCES [dbo].[condition] ([condition])
GO
ALTER TABLE [dbo].[things] CHECK CONSTRAINT [FK_things_condition]
GO
