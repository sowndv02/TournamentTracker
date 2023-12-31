USE [TournamentTracker]
GO
/****** Object:  Table [dbo].[MatchupEntries]    Script Date: 22/07/2023 9:13:07 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatchupEntries](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MatchupId] [int] NOT NULL,
	[ParentMatchupId] [int] NULL,
	[TeamCompetingId] [int] NULL,
	[Score] [float] NULL,
 CONSTRAINT [PK_MatchupEntries] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Matchups]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Matchups](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TournamentId] [int] NOT NULL,
	[WinnerId] [int] NULL,
	[MatchupRound] [int] NOT NULL,
 CONSTRAINT [PK_Matchups] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[People]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[EmailAddress] [nvarchar](200) NOT NULL,
	[PhoneNumber] [varchar](20) NOT NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prizes]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prizes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[PlaceNumber] [int] NOT NULL,
	[PiaceName] [nvarchar](50) NOT NULL,
	[PrizeAmount] [money] NOT NULL,
	[PrizePercentage] [float] NOT NULL,
 CONSTRAINT [PK_Prizes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TeamMembers]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeamMembers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TeamId] [int] NOT NULL,
	[PersonId] [int] NOT NULL,
 CONSTRAINT [PK_TeamMembers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teams]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teams](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TeamName] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Teams] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tournament]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tournament](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TournamentName] [nvarchar](200) NOT NULL,
	[EntryFee] [money] NOT NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_Tournament] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TournamentEntries]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TournamentEntries](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TournamentId] [int] NOT NULL,
	[TeamId] [int] NOT NULL,
 CONSTRAINT [PK_TournamentEntries] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TournamentPrizes]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TournamentPrizes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TournamentId] [int] NOT NULL,
	[PrizeId] [int] NOT NULL,
 CONSTRAINT [PK_TournamentPrizes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[MatchupEntries] ON 

INSERT [dbo].[MatchupEntries] ([id], [MatchupId], [ParentMatchupId], [TeamCompetingId], [Score]) VALUES (119, 145, NULL, 8, 1)
INSERT [dbo].[MatchupEntries] ([id], [MatchupId], [ParentMatchupId], [TeamCompetingId], [Score]) VALUES (120, 145, NULL, 6, 0)
INSERT [dbo].[MatchupEntries] ([id], [MatchupId], [ParentMatchupId], [TeamCompetingId], [Score]) VALUES (121, 146, NULL, 7, 1)
INSERT [dbo].[MatchupEntries] ([id], [MatchupId], [ParentMatchupId], [TeamCompetingId], [Score]) VALUES (122, 146, NULL, 5, 0)
INSERT [dbo].[MatchupEntries] ([id], [MatchupId], [ParentMatchupId], [TeamCompetingId], [Score]) VALUES (123, 147, 145, 8, 1)
INSERT [dbo].[MatchupEntries] ([id], [MatchupId], [ParentMatchupId], [TeamCompetingId], [Score]) VALUES (124, 147, 146, 7, 0)
INSERT [dbo].[MatchupEntries] ([id], [MatchupId], [ParentMatchupId], [TeamCompetingId], [Score]) VALUES (125, 148, NULL, 7, 12)
INSERT [dbo].[MatchupEntries] ([id], [MatchupId], [ParentMatchupId], [TeamCompetingId], [Score]) VALUES (126, 148, NULL, 8, 0)
INSERT [dbo].[MatchupEntries] ([id], [MatchupId], [ParentMatchupId], [TeamCompetingId], [Score]) VALUES (127, 149, NULL, 5, 12)
INSERT [dbo].[MatchupEntries] ([id], [MatchupId], [ParentMatchupId], [TeamCompetingId], [Score]) VALUES (128, 149, NULL, 6, 0)
INSERT [dbo].[MatchupEntries] ([id], [MatchupId], [ParentMatchupId], [TeamCompetingId], [Score]) VALUES (129, 150, 148, 7, 123)
INSERT [dbo].[MatchupEntries] ([id], [MatchupId], [ParentMatchupId], [TeamCompetingId], [Score]) VALUES (130, 150, 149, 5, 0)
INSERT [dbo].[MatchupEntries] ([id], [MatchupId], [ParentMatchupId], [TeamCompetingId], [Score]) VALUES (131, 151, NULL, 5, NULL)
INSERT [dbo].[MatchupEntries] ([id], [MatchupId], [ParentMatchupId], [TeamCompetingId], [Score]) VALUES (132, 151, NULL, 6, NULL)
INSERT [dbo].[MatchupEntries] ([id], [MatchupId], [ParentMatchupId], [TeamCompetingId], [Score]) VALUES (133, 152, NULL, 8, NULL)
INSERT [dbo].[MatchupEntries] ([id], [MatchupId], [ParentMatchupId], [TeamCompetingId], [Score]) VALUES (134, 152, NULL, 7, NULL)
INSERT [dbo].[MatchupEntries] ([id], [MatchupId], [ParentMatchupId], [TeamCompetingId], [Score]) VALUES (135, 153, 151, NULL, NULL)
INSERT [dbo].[MatchupEntries] ([id], [MatchupId], [ParentMatchupId], [TeamCompetingId], [Score]) VALUES (136, 153, 152, NULL, NULL)
INSERT [dbo].[MatchupEntries] ([id], [MatchupId], [ParentMatchupId], [TeamCompetingId], [Score]) VALUES (137, 154, NULL, 5, NULL)
INSERT [dbo].[MatchupEntries] ([id], [MatchupId], [ParentMatchupId], [TeamCompetingId], [Score]) VALUES (138, 154, NULL, 7, NULL)
INSERT [dbo].[MatchupEntries] ([id], [MatchupId], [ParentMatchupId], [TeamCompetingId], [Score]) VALUES (139, 155, NULL, 6, NULL)
INSERT [dbo].[MatchupEntries] ([id], [MatchupId], [ParentMatchupId], [TeamCompetingId], [Score]) VALUES (140, 155, NULL, 8, NULL)
INSERT [dbo].[MatchupEntries] ([id], [MatchupId], [ParentMatchupId], [TeamCompetingId], [Score]) VALUES (141, 156, 154, NULL, NULL)
INSERT [dbo].[MatchupEntries] ([id], [MatchupId], [ParentMatchupId], [TeamCompetingId], [Score]) VALUES (142, 156, 155, NULL, NULL)
SET IDENTITY_INSERT [dbo].[MatchupEntries] OFF
GO
SET IDENTITY_INSERT [dbo].[Matchups] ON 

INSERT [dbo].[Matchups] ([id], [TournamentId], [WinnerId], [MatchupRound]) VALUES (145, 70, 8, 1)
INSERT [dbo].[Matchups] ([id], [TournamentId], [WinnerId], [MatchupRound]) VALUES (146, 70, 7, 1)
INSERT [dbo].[Matchups] ([id], [TournamentId], [WinnerId], [MatchupRound]) VALUES (147, 70, 8, 2)
INSERT [dbo].[Matchups] ([id], [TournamentId], [WinnerId], [MatchupRound]) VALUES (148, 71, 7, 1)
INSERT [dbo].[Matchups] ([id], [TournamentId], [WinnerId], [MatchupRound]) VALUES (149, 71, 5, 1)
INSERT [dbo].[Matchups] ([id], [TournamentId], [WinnerId], [MatchupRound]) VALUES (150, 71, 7, 2)
INSERT [dbo].[Matchups] ([id], [TournamentId], [WinnerId], [MatchupRound]) VALUES (151, 72, 5, 1)
INSERT [dbo].[Matchups] ([id], [TournamentId], [WinnerId], [MatchupRound]) VALUES (152, 72, 8, 1)
INSERT [dbo].[Matchups] ([id], [TournamentId], [WinnerId], [MatchupRound]) VALUES (153, 72, 5, 2)
INSERT [dbo].[Matchups] ([id], [TournamentId], [WinnerId], [MatchupRound]) VALUES (154, 73, NULL, 1)
INSERT [dbo].[Matchups] ([id], [TournamentId], [WinnerId], [MatchupRound]) VALUES (155, 73, NULL, 1)
INSERT [dbo].[Matchups] ([id], [TournamentId], [WinnerId], [MatchupRound]) VALUES (156, 73, NULL, 2)
SET IDENTITY_INSERT [dbo].[Matchups] OFF
GO
SET IDENTITY_INSERT [dbo].[People] ON 

INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (1, N'Ginger', N'Huang', N'qkifywk.ispnqx@fmiaqo.rhmawj.net', N'9053884203')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (2, N'Jami', N'Watts', N'kvqzdpnb.jgzdpn@cfiwe.vpmpii.net', N'4222781136')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (3, N'Erika', N'English', N'qreszyw4@fgsosz.net', N'944-887-8147')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (4, N'Jeffrey', N'Cole', N'gnsoqqdn@tdqhyw.com', N'466-595-1273')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (5, N'Tania', N'Hardin', N'vbnxbtt.yxjp@cyqbhv.com', N'151-0886410')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (6, N'Ginger', N'Torres', N'ttps3@ljiezu.com', N'1305590936')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (7, N'Frank', N'Todd', N'xoqd60@khufnl.tdlaqy.com', N'604-2926796')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (8, N'Alan', N'Faulkner', N'byehtdd427@kzpwc-.org', N'074-817-6620')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (9, N'Norma', N'York', N'fwycfqav1@iluljg.org', N'141-506-1031')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (10, N'Claudia', N'Aguilar', N'ugrhat78@ashjrxmdj.rq-tan.net', N'852249-4294')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (11, N'Esther', N'Charles', N'ttellq@oklt.uzqdku.com', N'5721590100')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (12, N'Alfred', N'Petty', N'zfpob695@tvohrdwso.zsx-fu.com', N'776-1466583')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (13, N'Wallace', N'Bonilla', N'lqhyfgv592@aqwzkj.com', N'202-477-2660')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (14, N'Marla', N'Cuevas', N'ytfkfwq425@uuqil.yhthzd.com', N'139-757-1038')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (15, N'Carolyn', N'Rowland', N'ehjaxds.uaykd@zbqhwa.com', N'676985-0921')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (16, N'Barry', N'Wade', N'ywiqzwlb87@qabgbvhn.utfiwn.com', N'575357-6207')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (17, N'Terence', N'Phelps', N'cyhcavb.jysa@ltmqg.-mujrn.net', N'349-5972772')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (18, N'Paula', N'Bolton', N'nonwz.udpez@liudmx.net', N'836-354-0920')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (19, N'Frankie', N'Schmidt', N'kxcuc63@ujvlwbna.owlfxv.org', N'6785095097')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (20, N'Lara', N'Myers', N'poayzx7@jimhxu.vqxycz.net', N'574-368-8986')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (21, N'Marisa', N'Carroll', N'anlwxhka@vlrucwxr.cpnl--.com', N'6775828309')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (22, N'Dexter', N'Velazquez', N'qlbbvx.xhjyikmqn@zdwgcfw.yxjwg-.com', N'357258-0931')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (23, N'Joni', N'Rowe', N'jfeanb.ontztcyyy@kudywz.org', N'522-820-6569')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (24, N'Kim', N'Hawkins', N'hnkcy.dkib@nqsnlx.org', N'9582100865')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (25, N'Margaret', N'Garrison', N'ylyq.qegiamjhsd@cuznp.tlxclk.com', N'540-618-0548')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (26, N'Kyle', N'Collins', N'wwibmliv@ajofyocru.wkvbxc.org', N'798505-4160')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (27, N'Willie', N'Rowe', N'swxyqn.rzlgma@vjxrex.sgmzxe.com', N'955245-7660')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (28, N'Valerie', N'Brandt', N'fsughd0@xcgowvag.nelivn.org', N'662-198-4986')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (29, N'Connie', N'Noble', N'dnblh577@tqwkwzf.tpcxyc.org', N'558405-3373')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (30, N'Elisa', N'Gomez', N'glktykpn@-zdaxu.com', N'845-7940740')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (31, N'Sabrina', N'Johnson', N'ibmv9@dmckfh.org', N'258280-6179')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (32, N'Tamika', N'Wang', N'kniajez4@bzcqcq.org', N'725-9356120')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (33, N'Jasmine', N'Walter', N'okgm035@rxrnh.wzwmmt.org', N'665759-0338')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (34, N'Trevor', N'Cross', N'bhejmhod@wxfbov.org', N'614-720-9081')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (35, N'Edgar', N'Chan', N'cnkmw63@qbiavybay.npwn-h.net', N'050-062-1329')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (36, N'Cathy', N'Foley', N'uxqll8@zzxuvs.com', N'696467-4645')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (37, N'Tonia', N'Crawford', N'nxleoujn.ozve@nole.gmygna.net', N'777430-0831')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (38, N'Bryce', N'Frank', N'stdevub3@ympirq.net', N'400-939-4763')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (39, N'Darrick', N'Goodman', N'zhhhe.jmxztkgwe@akhqy.pbrtxp.com', N'416-4532948')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (40, N'Toby', N'Andersen', N'ghil@mrvrjb.com', N'525353-3769')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (41, N'Sonja', N'Pearson', N'qlyxq33@cxmmx.bnbxkr.com', N'6768239755')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (42, N'Dwight', N'Sims', N'uxqu@zclqqf.net', N'091-1189740')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (43, N'Suzanne', N'White', N'zcle.aeyjhoou@kcvnt.cfdqxi.org', N'684526-3906')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (44, N'Cari', N'Welch', N'svseyhg@lwwo.wexsgn.com', N'698-4664889')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (45, N'Anthony', N'Mc Intyre', N'fkzeagk.sqlwkvxna@qhrgsgt.lhyckk.net', N'072-0297298')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (46, N'Shane', N'Hamilton', N'ibjqbf210@zegjaqx.tltmse.net', N'112-992-9287')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (47, N'Jessica', N'Frederick', N'nzllh.roilbna@ghlcsu.com', N'747-566-3926')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (48, N'Rosemary', N'Larsen', N'buopp03@dqbck.ousewf.net', N'1773661525')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (49, N'Quincy', N'Fischer', N'pfjt.spqknawblz@bhmng.ajc-rp.org', N'842-3544406')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (50, N'Alyssa', N'Rose', N'vszyzh.anaqojwn@ueemk.zcrjwr.net', N'966142-0716')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (51, N'Irma', N'Kirby', N'fyfebmad2@orsnqq.net', N'0419796391')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (52, N'Adriana', N'Rich', N'akih.vpfn@zkqdrl.sqamel.com', N'8594853101')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (53, N'Mia', N'French', N'lzvgaxf8@ndnwcz.org', N'5470241787')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (54, N'Janelle', N'Harrison', N'ebpwfv981@ojpjgg.net', N'851-4731931')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (55, N'Donovan', N'Khan', N'gbgvg0@fecfkjz.eqaers.org', N'878-2515107')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (56, N'Owen', N'Kaufman', N'zvyn.ptyaja@saulyq.org', N'7078007083')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (57, N'Monte', N'Yu', N'zgkhbbs57@seronojh.-yasy-.com', N'192487-2329')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (58, N'Colby', N'Brock', N'uksrvrc.oaxqwh@-xcxkb.net', N'375-0148797')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (59, N'Dora', N'Trujillo', N'oflficsp3@wmo-w-.com', N'1785838340')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (60, N'Louis', N'Mosley', N'termoyc33@glrihl.com', N'570-0459462')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (61, N'Rex', N'Christian', N'mdyxndk.nclr@tsudoh.net', N'7995544480')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (62, N'Anita', N'Morrow', N'atbpbxr.zbhbtoa@rkvfly.com', N'774-0686126')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (63, N'Kara', N'Ramos', N'xqnhtz.xemnj@ymlpm-.net', N'021-937-0209')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (64, N'Brandon', N'Meyers', N'tjwqlmuh690@gbrgwkoh.-dwszh.net', N'654103-0010')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (65, N'Nicole', N'Carpenter', N'xmtyxje833@exfenw.net', N'3282244904')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (66, N'Marcella', N'Wagner', N'tfbnpgpc@bnijjsmx.nfyphz.net', N'759-066-0872')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (67, N'Jeffrey', N'Curtis', N'uucqut.jtys@nfmqsp.wvjwie.net', N'816-7413186')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (68, N'Ralph', N'Cabrera', N'xhhqpnac.tumzzofuz@cqgjpx.net', N'199-407-7630')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (69, N'Roman', N'Nicholson', N'tloot60@ndwkyvkxv.qoegjt.com', N'452-2363421')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (70, N'Marc', N'Fleming', N'gzqcjwue4@cizepg.org', N'9890838464')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (71, N'Celeste', N'Gordon', N'pgadwcw37@vkjkt-.com', N'1018858292')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (72, N'Lance', N'Simpson', N'prkhy.fcumjsrtq@txuyht.net', N'085-968-5143')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (73, N'Pamela', N'Singleton', N'hyptwfr.opvx@ddpfkx.org', N'861-235-1249')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (74, N'Chester', N'Matthews', N'tlghr.iqnqgh@ygscrd.org', N'7909825275')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (75, N'Eric', N'Zuniga', N'pegqutnj283@zqhfyh.org', N'642-217-7214')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (76, N'Gloria', N'Riggs', N'kovrzst7@clhxpd.ecau-h.org', N'618617-9353')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (77, N'Fred', N'Bradshaw', N'nkycv@ybnqrq.net', N'050-601-6178')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (78, N'Allyson', N'Grant', N'zywoikqu237@rzfbnp.com', N'678332-5678')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (79, N'Malcolm', N'Hampton', N'gpeynpn.hrajmee@greqli.org', N'854228-6079')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (80, N'Bruce', N'Shaffer', N'wrkoe.qpyelcf@sabtye.net', N'439-258-6297')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (81, N'Keri', N'Chen', N'cfiudpdv.twdxd@twfaog.bqxkfj.net', N'932-1794966')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (82, N'Christa', N'Mccarty', N'vimze.aviqjlt@yygfi.bnzfsl.net', N'363-173-3727')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (83, N'Katherine', N'Logan', N'pkyca.ezvgwjr@qhecmh.org', N'920-374-6494')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (84, N'Doris', N'Heath', N'iffyz.aidt@jsqjtyk.lgkqbp.com', N'3910852906')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (85, N'Rachael', N'Yates', N'ofhgitv.ebwgnfx@gpotsi.net', N'3511815117')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (86, N'Jamal', N'Bush', N'wyuhw7@lzapxa.net', N'7784560639')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (87, N'Brock', N'Mayo', N'xnrybn.hurvmy@xwufht.mtflrk.net', N'4671224764')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (88, N'Andrea', N'Ochoa', N'nxdlf.xhig@bymnn.sagpgd.org', N'868-401-8815')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (89, N'Jacob', N'Strong', N'eubhfqcd.mgrzymxa@kutxd-.net', N'551934-4538')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (90, N'Tiffany', N'Poole', N'giwhz.cgabk@adafss.org', N'692479-3438')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (91, N'Cory', N'Kent', N'sglrt111@womegw.org', N'3168604241')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (92, N'Dewayne', N'Marks', N'fwzi.tpwxhgo@pwibjc.wwtfam.net', N'862963-7600')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (93, N'Ivan', N'Rollins', N'zvlg.hdugq@fwkwkzxi.vxtbzb.com', N'406-286-0856')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (94, N'Marie', N'Lester', N'lgyay@tisn.trwq-i.com', N'137628-6842')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (95, N'Brandie', N'Dawson', N'nunaa.mweodvj@hkpnnfop.-cbfhb.org', N'159-464-0094')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (96, N'Mandi', N'Melendez', N'usenxlg.xdejzjf@otvche.net', N'016-383-2115')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (97, N'Scott', N'Vasquez', N'zlkfoc@irkzjr.hkkaat.net', N'4444835946')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (98, N'Darrick', N'Yates', N'ymlmqk.imvmfj@nysx.zpkdbz.net', N'623-5193154')
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (99, N'Joanna', N'Evans', N'nxqnqp.jkgj@nofwykood.zpywah.com', N'248-6541781')
GO
INSERT [dbo].[People] ([id], [FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (100, N'Nathan', N'Abbott', N'eeuoey.lzenm@xcwyfa.com', N'436970-3440')
SET IDENTITY_INSERT [dbo].[People] OFF
GO
SET IDENTITY_INSERT [dbo].[Prizes] ON 

INSERT [dbo].[Prizes] ([id], [PlaceNumber], [PiaceName], [PrizeAmount], [PrizePercentage]) VALUES (25, 1, N'Prize 1', 1999.0000, 0)
INSERT [dbo].[Prizes] ([id], [PlaceNumber], [PiaceName], [PrizeAmount], [PrizePercentage]) VALUES (26, 6, N'Prize 6', 19999.0000, 0)
INSERT [dbo].[Prizes] ([id], [PlaceNumber], [PiaceName], [PrizeAmount], [PrizePercentage]) VALUES (27, 9, N'Prize 9', 1999.0000, 0)
INSERT [dbo].[Prizes] ([id], [PlaceNumber], [PiaceName], [PrizeAmount], [PrizePercentage]) VALUES (28, 8, N'Prize 8', 1000.0000, 0)
INSERT [dbo].[Prizes] ([id], [PlaceNumber], [PiaceName], [PrizeAmount], [PrizePercentage]) VALUES (29, 12, N'Prize 12', 1213.0000, 0)
SET IDENTITY_INSERT [dbo].[Prizes] OFF
GO
SET IDENTITY_INSERT [dbo].[TeamMembers] ON 

INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (1, 77, 73)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (2, 86, 82)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (3, 81, 77)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (4, 60, 56)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (5, 25, 21)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (6, 60, 56)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (7, 95, 91)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (8, 49, 45)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (9, 102, 98)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (10, 32, 28)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (11, 34, 30)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (12, 51, 47)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (13, 68, 64)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (14, 51, 47)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (15, 103, 99)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (16, 8, 4)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (17, 91, 87)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (18, 104, 100)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (19, 72, 68)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (20, 36, 32)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (21, 86, 82)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (22, 89, 85)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (23, 104, 100)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (24, 8, 4)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (25, 74, 70)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (26, 57, 53)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (27, 98, 94)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (28, 73, 69)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (29, 59, 55)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (30, 13, 9)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (31, 23, 19)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (32, 50, 46)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (33, 34, 30)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (34, 103, 99)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (35, 69, 65)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (36, 81, 77)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (37, 8, 4)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (38, 43, 39)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (39, 39, 35)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (40, 100, 96)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (41, 55, 51)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (42, 76, 72)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (43, 16, 12)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (44, 32, 28)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (45, 95, 91)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (46, 84, 80)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (47, 38, 34)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (48, 50, 46)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (49, 19, 15)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (50, 27, 23)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (51, 46, 42)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (52, 76, 72)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (53, 66, 62)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (54, 53, 49)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (55, 24, 20)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (56, 92, 88)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (57, 87, 83)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (58, 78, 74)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (59, 90, 86)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (60, 72, 68)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (61, 67, 63)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (62, 26, 22)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (63, 94, 90)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (64, 94, 90)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (65, 13, 9)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (66, 88, 84)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (67, 22, 18)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (68, 69, 65)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (69, 87, 83)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (70, 26, 22)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (71, 104, 100)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (72, 53, 49)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (73, 70, 66)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (74, 76, 72)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (75, 85, 81)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (76, 15, 11)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (77, 77, 73)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (78, 76, 72)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (79, 17, 13)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (80, 95, 91)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (81, 23, 19)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (82, 52, 48)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (83, 59, 55)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (84, 37, 33)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (85, 72, 68)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (86, 51, 47)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (87, 88, 84)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (88, 85, 81)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (89, 84, 80)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (90, 81, 77)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (91, 98, 94)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (92, 34, 30)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (93, 57, 53)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (94, 71, 67)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (95, 38, 34)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (96, 33, 29)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (97, 87, 83)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (98, 27, 23)
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (99, 23, 19)
GO
INSERT [dbo].[TeamMembers] ([id], [TeamId], [PersonId]) VALUES (100, 11, 7)
SET IDENTITY_INSERT [dbo].[TeamMembers] OFF
GO
SET IDENTITY_INSERT [dbo].[Teams] ON 

INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (5, N'Jeanine25')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (6, N'Valerie')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (7, N'Roy5')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (8, N'Ron506')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (9, N'Roberta503')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (10, N'Guy240')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (11, N'Roderick76')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (12, N'Donna73')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (13, N'Bridgette76')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (14, N'Damian36')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (15, N'Lewis07')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (16, N'Glen6')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (17, N'Demond03')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (18, N'Tim75')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (19, N'Misti')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (20, N'Eva997')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (21, N'Elisabeth979')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (22, N'Guillermo')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (23, N'Lorraine166')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (24, N'Damion')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (25, N'Jenny1')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (26, N'Christa1')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (27, N'Kelly')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (28, N'Candy')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (29, N'Joel')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (30, N'Mandi')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (31, N'Caroline')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (32, N'Andrea61')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (33, N'Billy')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (34, N'Nathaniel697')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (35, N'Abel')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (36, N'Claude747')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (37, N'Jayson19')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (38, N'Karen')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (39, N'Sonya2')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (40, N'Deanna1')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (41, N'Adrian')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (42, N'Gloria83')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (43, N'Tasha827')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (44, N'Myron73')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (45, N'Julie792')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (46, N'Karen246')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (47, N'Ethan')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (48, N'Daphne3')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (49, N'Rebecca')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (50, N'Kimberly07')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (51, N'Megan37')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (52, N'Joey84')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (53, N'Doris565')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (54, N'Bryce49')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (55, N'Sara')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (56, N'Dan6')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (57, N'Nikki3')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (58, N'Charlie56')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (59, N'Marty9')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (60, N'Jayson1')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (61, N'Melanie25')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (62, N'Paul705')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (63, N'Melody29')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (64, N'Emma906')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (65, N'Chadwick868')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (66, N'Angela9')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (67, N'Deana')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (68, N'Roberto6')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (69, N'Tera679')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (70, N'Bryce')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (71, N'Randolph9')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (72, N'Shannon799')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (73, N'Kari4')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (74, N'Leo2')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (75, N'Shauna20')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (76, N'Mark')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (77, N'Janelle793')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (78, N'Walter423')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (79, N'Glenn219')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (80, N'Dennis230')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (81, N'Gary4')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (82, N'Tim80')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (83, N'Lance53')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (84, N'Seth89')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (85, N'Darryl')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (86, N'Leticia255')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (87, N'Ernest426')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (88, N'Timmy14')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (89, N'Jill5')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (90, N'Ismael69')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (91, N'Damien9')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (92, N'Mia603')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (93, N'Darrin12')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (94, N'Nora015')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (95, N'Clayton')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (96, N'Jordan11')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (97, N'Cary213')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (98, N'Cody')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (99, N'Marcia9')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (100, N'Harry6')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (101, N'Jasmine')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (102, N'Latonya003')
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (103, N'Kristine964')
GO
INSERT [dbo].[Teams] ([id], [TeamName]) VALUES (104, N'Katie07')
SET IDENTITY_INSERT [dbo].[Teams] OFF
GO
SET IDENTITY_INSERT [dbo].[Tournament] ON 

INSERT [dbo].[Tournament] ([id], [TournamentName], [EntryFee], [Active]) VALUES (70, N'Tournament 1', 121.0000, 0)
INSERT [dbo].[Tournament] ([id], [TournamentName], [EntryFee], [Active]) VALUES (71, N'Tournament 2', 5124.0000, 0)
INSERT [dbo].[Tournament] ([id], [TournamentName], [EntryFee], [Active]) VALUES (72, N'134132', 223.0000, 0)
INSERT [dbo].[Tournament] ([id], [TournamentName], [EntryFee], [Active]) VALUES (73, N'214213', 124.0000, 1)
SET IDENTITY_INSERT [dbo].[Tournament] OFF
GO
SET IDENTITY_INSERT [dbo].[TournamentEntries] ON 

INSERT [dbo].[TournamentEntries] ([id], [TournamentId], [TeamId]) VALUES (213, 70, 5)
INSERT [dbo].[TournamentEntries] ([id], [TournamentId], [TeamId]) VALUES (214, 70, 6)
INSERT [dbo].[TournamentEntries] ([id], [TournamentId], [TeamId]) VALUES (215, 70, 7)
INSERT [dbo].[TournamentEntries] ([id], [TournamentId], [TeamId]) VALUES (216, 70, 8)
INSERT [dbo].[TournamentEntries] ([id], [TournamentId], [TeamId]) VALUES (217, 71, 5)
INSERT [dbo].[TournamentEntries] ([id], [TournamentId], [TeamId]) VALUES (218, 71, 6)
INSERT [dbo].[TournamentEntries] ([id], [TournamentId], [TeamId]) VALUES (219, 71, 7)
INSERT [dbo].[TournamentEntries] ([id], [TournamentId], [TeamId]) VALUES (220, 71, 8)
INSERT [dbo].[TournamentEntries] ([id], [TournamentId], [TeamId]) VALUES (221, 72, 5)
INSERT [dbo].[TournamentEntries] ([id], [TournamentId], [TeamId]) VALUES (222, 72, 6)
INSERT [dbo].[TournamentEntries] ([id], [TournamentId], [TeamId]) VALUES (223, 72, 7)
INSERT [dbo].[TournamentEntries] ([id], [TournamentId], [TeamId]) VALUES (224, 72, 8)
INSERT [dbo].[TournamentEntries] ([id], [TournamentId], [TeamId]) VALUES (225, 73, 5)
INSERT [dbo].[TournamentEntries] ([id], [TournamentId], [TeamId]) VALUES (226, 73, 6)
INSERT [dbo].[TournamentEntries] ([id], [TournamentId], [TeamId]) VALUES (227, 73, 7)
INSERT [dbo].[TournamentEntries] ([id], [TournamentId], [TeamId]) VALUES (228, 73, 8)
SET IDENTITY_INSERT [dbo].[TournamentEntries] OFF
GO
ALTER TABLE [dbo].[Prizes] ADD  CONSTRAINT [DF_Prizes_Amount]  DEFAULT ((0)) FOR [PrizeAmount]
GO
ALTER TABLE [dbo].[Prizes] ADD  CONSTRAINT [DF_Prizes_PrizePercentage]  DEFAULT ((0)) FOR [PrizePercentage]
GO
ALTER TABLE [dbo].[MatchupEntries]  WITH CHECK ADD  CONSTRAINT [FK_MatchupEntries_Matchups] FOREIGN KEY([MatchupId])
REFERENCES [dbo].[Matchups] ([id])
GO
ALTER TABLE [dbo].[MatchupEntries] CHECK CONSTRAINT [FK_MatchupEntries_Matchups]
GO
ALTER TABLE [dbo].[MatchupEntries]  WITH CHECK ADD  CONSTRAINT [FK_MatchupEntries_Teams] FOREIGN KEY([TeamCompetingId])
REFERENCES [dbo].[Teams] ([id])
GO
ALTER TABLE [dbo].[MatchupEntries] CHECK CONSTRAINT [FK_MatchupEntries_Teams]
GO
ALTER TABLE [dbo].[Matchups]  WITH CHECK ADD  CONSTRAINT [FK_Matchups_Teams] FOREIGN KEY([WinnerId])
REFERENCES [dbo].[Teams] ([id])
GO
ALTER TABLE [dbo].[Matchups] CHECK CONSTRAINT [FK_Matchups_Teams]
GO
ALTER TABLE [dbo].[TeamMembers]  WITH CHECK ADD  CONSTRAINT [FK_TeamMembers_People] FOREIGN KEY([PersonId])
REFERENCES [dbo].[People] ([id])
GO
ALTER TABLE [dbo].[TeamMembers] CHECK CONSTRAINT [FK_TeamMembers_People]
GO
ALTER TABLE [dbo].[TeamMembers]  WITH CHECK ADD  CONSTRAINT [FK_TeamMembers_Teams] FOREIGN KEY([TeamId])
REFERENCES [dbo].[Teams] ([id])
GO
ALTER TABLE [dbo].[TeamMembers] CHECK CONSTRAINT [FK_TeamMembers_Teams]
GO
ALTER TABLE [dbo].[TournamentEntries]  WITH CHECK ADD  CONSTRAINT [FK_TournamentEntries_Teams] FOREIGN KEY([TeamId])
REFERENCES [dbo].[Teams] ([id])
GO
ALTER TABLE [dbo].[TournamentEntries] CHECK CONSTRAINT [FK_TournamentEntries_Teams]
GO
ALTER TABLE [dbo].[TournamentEntries]  WITH CHECK ADD  CONSTRAINT [FK_TournamentEntries_Tournament] FOREIGN KEY([TournamentId])
REFERENCES [dbo].[Tournament] ([id])
GO
ALTER TABLE [dbo].[TournamentEntries] CHECK CONSTRAINT [FK_TournamentEntries_Tournament]
GO
ALTER TABLE [dbo].[TournamentPrizes]  WITH CHECK ADD  CONSTRAINT [FK_TournamentPrizes_Prizes] FOREIGN KEY([PrizeId])
REFERENCES [dbo].[Prizes] ([id])
GO
ALTER TABLE [dbo].[TournamentPrizes] CHECK CONSTRAINT [FK_TournamentPrizes_Prizes]
GO
ALTER TABLE [dbo].[TournamentPrizes]  WITH CHECK ADD  CONSTRAINT [FK_TournamentPrizes_Tournaments] FOREIGN KEY([TournamentId])
REFERENCES [dbo].[Tournament] ([id])
GO
ALTER TABLE [dbo].[TournamentPrizes] CHECK CONSTRAINT [FK_TournamentPrizes_Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spMatchupEntries_GetByMatchup]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchupEntries_GetByMatchup]
	@MatchupId INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM dbo.MatchupEntries 
	WHERE MatchupEntries.MatchupId = @MatchupId
END

GO
/****** Object:  StoredProcedure [dbo].[spMatchupEntries_Insert]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchupEntries_Insert]
	@MatchupId INT,
	@ParentMatchupId Int,
	@TeamCompetingId INT, 
	@id int = 0 OUTPUT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.MatchupEntries(MatchupId, ParentMatchupId, TeamCompetingId)
	VALUES(@MatchupId, @ParentMatchupId, @TeamCompetingId)

	SELECT @id = SCOPE_IDENTITY();
END

GO
/****** Object:  StoredProcedure [dbo].[spMatchupEntries_Update]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchupEntries_Update]
	@id INT,
	@TeamCompetingId INT = 0,
	@Score FLOAT = 0
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE dbo.MatchupEntries SET 
	TeamCompetingId = @TeamCompetingId, Score = @Score  WHERE id = @id
END

GO
/****** Object:  StoredProcedure [dbo].[spMatchups_GetByTournament]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchups_GetByTournament]
	@TournamentId INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Matchups.*, Teams.TeamName FROM dbo.Matchups LEFT JOIN dbo.Teams 
	ON Teams.id = Matchups.WinnerId
	WHERE TournamentId = @TournamentId
END

GO
/****** Object:  StoredProcedure [dbo].[spMatchups_Insert]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchups_Insert]
	@TournamentId INT,
	@MatchupRound Int,
	@id int = 0 OUTPUT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.Matchups(TournamentId,MatchupRound)
	VALUES(@TournamentId, @MatchupRound)

	SELECT @id = SCOPE_IDENTITY();
END

GO
/****** Object:  StoredProcedure [dbo].[spMatchups_Update]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMatchups_Update]
	@id INT,
	@WinnerId INT 
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE dbo.Matchups SET WinnerId = @WinnerId WHERE id = @id
END

GO
/****** Object:  StoredProcedure [dbo].[spPeople_GetAll]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPeople_GetAll]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM dbo.People
END

GO
/****** Object:  StoredProcedure [dbo].[spPeople_Insert]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPeople_Insert]
	@FirstName NVARCHAR(100), 
	@LastName nvarchar(50),
	@EmailAddress NVARCHAR(200),
	@PhoneNumber VARCHAR(20),
	@id int = 0 OUTPUT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.People(FirstName, LastName, EmailAddress, PhoneNumber)
	VALUES(@FirstName, @LastName, @EmailAddress, @PhoneNumber);

	SELECT @id = SCOPE_IDENTITY();
END

GO
/****** Object:  StoredProcedure [dbo].[spPrizes_GetByTournament]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPrizes_GetByTournament]
	@TournamentId INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Prizes.* FROM dbo.TournamentPrizes INNER JOIN dbo.Prizes 
	ON Prizes.Id = TournamentPrizes.PrizeId
	WHERE TournamentPrizes.TournamentId = @TournamentId
END

GO
/****** Object:  StoredProcedure [dbo].[spPrizes_Insert]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPrizes_Insert]
	@PlaceNumber int, 
	@PlaceName nvarchar(50),
	@PrizeAmount money,
	@PrizePercentage float,
	@id int = 0 OUTPUT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.Prizes(PlaceNumber, PiaceName, PrizeAmount, PrizePercentage)
	VALUES(@PlaceNumber, @PlaceName, @PrizeAmount, @PrizePercentage);

	SELECT @id = SCOPE_IDENTITY();
END

GO
/****** Object:  StoredProcedure [dbo].[spTeam_GetAll]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTeam_GetAll]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM dbo.Teams
END

GO
/****** Object:  StoredProcedure [dbo].[spTeam_GetByTournament]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTeam_GetByTournament]
	@TournamentId INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Teams.* FROM dbo.TournamentEntries INNER JOIN dbo.Teams 
	ON Teams.Id = TournamentEntries.TeamId
	WHERE TournamentEntries.TournamentId = @TournamentId
END

GO
/****** Object:  StoredProcedure [dbo].[spTeamMembers_GetByTeam]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTeamMembers_GetByTeam]
	@TeamId INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT People.* FROM dbo.People INNER JOIN TeamMembers ON TeamMembers.PersonId = People.id
	WHERE dbo.TeamMembers.TeamId = @TeamId
END

GO
/****** Object:  StoredProcedure [dbo].[spTeamMembers_Insert]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTeamMembers_Insert]
	@TeamId INT,
	@PersonId INT,
	@id int = 0 OUTPUT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.TeamMembers(TeamId, PersonId)
	VALUES(@TeamId, @PersonId);

	SELECT @id = SCOPE_IDENTITY();
END

GO
/****** Object:  StoredProcedure [dbo].[spTeams_GetAll]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTeams_GetAll]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM dbo.Teams
END

GO
/****** Object:  StoredProcedure [dbo].[spTeams_Insert]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTeams_Insert]
	@TeamName NVARCHAR(200), 
	@id int = 0 OUTPUT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.Teams(TeamName)
	VALUES(@TeamName);

	SELECT @id = SCOPE_IDENTITY();
END

GO
/****** Object:  StoredProcedure [dbo].[spTournamentEntries_Insert]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTournamentEntries_Insert]
	@TournamentId INT,
	@TeamId Int,
	@id int = 0 OUTPUT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.TournamentEntries
	(TournamentId, TeamId)
	VALUES(@TournamentId, @TeamId)

	SELECT @id = SCOPE_IDENTITY();
END

GO
/****** Object:  StoredProcedure [dbo].[spTournamentPrizes_Insert]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTournamentPrizes_Insert]
	@TournamentId INT,
	@PrizeId Int,
	@id int = 0 OUTPUT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.TournamentPrizes
	(TournamentId,PrizeId)
	VALUES(@TournamentId,@PrizeId)
	SELECT @id = SCOPE_IDENTITY();
END

GO
/****** Object:  StoredProcedure [dbo].[spTournaments_Complete]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTournaments_Complete]
	@id INT
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE dbo.Tournament SET 
	Active = 0 WHERE id = @id
END

GO
/****** Object:  StoredProcedure [dbo].[spTournaments_GetAll]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTournaments_GetAll]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM dbo.Tournament WHERE Active = 1 
END

GO
/****** Object:  StoredProcedure [dbo].[spTournaments_Insert]    Script Date: 22/07/2023 9:13:08 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTournaments_Insert]
	@TournamentName NVARCHAR(200),
	@EntryFee Money,
	@id int = 0 OUTPUT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.Tournament(TournamentName, EntryFee, Active)
	VALUES(@TournamentName, @EntryFee, 1);

	SELECT @id = SCOPE_IDENTITY();
END

GO
