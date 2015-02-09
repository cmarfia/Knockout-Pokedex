/****** Remove Constraints ******/
ALTER TABLE [dbo].[DescriptionGame] DROP CONSTRAINT [FK_DescriptionGame_Game]
GO

ALTER TABLE [dbo].[DescriptionGame] DROP CONSTRAINT [FK_DescriptionGame_Description]
GO

ALTER TABLE [dbo].[TypeToTypeEffect] DROP CONSTRAINT [FK_TypeToTypeEffect_TypeEffect]
GO

ALTER TABLE [dbo].[TypeToTypeEffect] DROP CONSTRAINT [FK_TypeToTypeEffect_Type1]
GO

ALTER TABLE [dbo].[TypeToTypeEffect] DROP CONSTRAINT [FK_TypeToTypeEffect_Type]
GO

ALTER TABLE [dbo].[PokemonAbility] DROP CONSTRAINT [FK_PokemonAbility_Pokemon]
GO

ALTER TABLE [dbo].[PokemonAbility] DROP CONSTRAINT [FK_PokemonAbility_Ability]
GO

ALTER TABLE [dbo].[PokemonDescription] DROP CONSTRAINT [FK_PokemonDescription_Pokemon]
GO

ALTER TABLE [dbo].[PokemonDescription] DROP CONSTRAINT [FK_PokemonDescription_Description]
GO

ALTER TABLE [dbo].[PokemonEvolution] DROP CONSTRAINT [FK_PokemonEvolution_Pokemon1]
GO

ALTER TABLE [dbo].[PokemonEvolution] DROP CONSTRAINT [FK_PokemonEvolution_Pokemon]
GO

ALTER TABLE [dbo].[PokemonMove] DROP CONSTRAINT [FK_PokemonMove_Pokemon]
GO

ALTER TABLE [dbo].[PokemonMove] DROP CONSTRAINT [FK_PokemonMove_Move]
GO

ALTER TABLE [dbo].[PokemonSprite] DROP CONSTRAINT [FK_PokemonSprite_Sprite]
GO

ALTER TABLE [dbo].[PokemonSprite] DROP CONSTRAINT [FK_PokemonSprite_Pokemon]
GO

ALTER TABLE [dbo].[PokemonType] DROP CONSTRAINT [FK_PokemonType_Type]
GO

ALTER TABLE [dbo].[PokemonType] DROP CONSTRAINT [FK_PokemonType_Pokemon]
GO

/****** Drop Tables ******/
DROP TABLE [dbo].[Ability]
GO

DROP TABLE [dbo].[DescriptionGame]
GO

DROP TABLE [dbo].[Description]
GO

DROP TABLE [dbo].[Game]
GO

DROP TABLE [dbo].[Move]
GO

DROP TABLE [dbo].[Sprite]
GO

DROP TABLE [dbo].[TypeToTypeEffect]
GO

DROP TABLE [dbo].[Type]
GO

DROP TABLE [dbo].[TypeEffect]
GO

DROP TABLE [dbo].[PokemonAbility]
GO

DROP TABLE [dbo].[PokemonDescription]
GO

DROP TABLE [dbo].[Pokemon]
GO

DROP TABLE [dbo].[PokemonEvolution]
GO

DROP TABLE [dbo].[PokemonMove]
GO

DROP TABLE [dbo].[PokemonSprite]
GO

DROP TABLE [dbo].[PokemonType]
GO

/****** Set Identifiers ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Create Tables ******/
CREATE TABLE [dbo].[Pokemon](
[PokemonId] [int] IDENTITY(1,1) NOT NULL,
[PkApiId] [int] NOT NULL,
[Name] [nvarchar](255) NOT NULL,
[Hp] [int] NOT NULL,
[Attack] [int] NOT NULL,
[Defense] [int] NOT NULL,
[SpAttack] [int] NOT NULL,
[SpDefense] [int] NOT NULL,
[Speed] [int] NOT NULL,
[Height] [nvarchar](255) NOT NULL,
[Weight] [nvarchar](255) NOT NULL,
[Species] [nvarchar](255) NOT NULL,
[CatchRate] [int] NOT NULL,
[Happiness] [int] NOT NULL,
[MaleToFemale] [nvarchar](255) NOT NULL,
[ModifiedDate] [date] NOT NULL,
[ResourceUri] [nvarchar](255) NOT NULL,
CONSTRAINT [PK_Pokemon] PRIMARY KEY CLUSTERED
(
[PokemonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Ability](
[AbilityId] [int] IDENTITY(1,1) NOT NULL,
[PkApiId] [int] NOT NULL,
[Name] [nvarchar](255) NOT NULL,
[Description] [nvarchar](max) NOT NULL,
[ModifiedDate] [date] NOT NULL,
[ResourceUri] [nvarchar](255) NOT NULL,
CONSTRAINT [PK_Ability] PRIMARY KEY CLUSTERED
(
[AbilityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Description](
[DescriptionId] [int] IDENTITY(1,1) NOT NULL,
[PkApiId] [int] NOT NULL,
[Description] [nvarchar](max) NOT NULL,
[ModifiedDate] [date] NOT NULL,
[ResourceUri] [nvarchar](255) NOT NULL,
CONSTRAINT [PK_Description] PRIMARY KEY CLUSTERED
(
[DescriptionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[DescriptionGame](
[DescriptionGameId] [int] IDENTITY(1,1) NOT NULL,
[DescriptionId] [int] NOT NULL,
[GameId] [int] NOT NULL,
CONSTRAINT [PK_DescriptionGame] PRIMARY KEY CLUSTERED
(
[DescriptionGameId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Game](
[GameId] [int] IDENTITY(1,1) NOT NULL,
[PkApiId] [int] NOT NULL,
[Name] [nvarchar](255) NOT NULL,
[Generation] [int] NOT NULL,
[ReleaseYear] [int] NOT NULL,
[ModifiedDate] [date] NOT NULL,
[ResourceUri] [nvarchar](255) NOT NULL,
CONSTRAINT [PK_Game] PRIMARY KEY CLUSTERED
(
[GameId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Move](
[MoveId] [int] IDENTITY(1,1) NOT NULL,
[PkApiId] [int] NOT NULL,
[Name] [nvarchar](255) NOT NULL,
[Description] [nvarchar](max) NOT NULL,
[Category] [nvarchar](255) NOT NULL,
[Power] [int] NOT NULL,
[PP] [int] NOT NULL,
[Accuracy] [int] NOT NULL,
[ModifiedDate] [date] NOT NULL,
[ResourceUri] [nvarchar](255) NOT NULL,
CONSTRAINT [PK_Move] PRIMARY KEY CLUSTERED
(
[MoveId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Sprite](
[SpriteId] [int] IDENTITY(1,1) NOT NULL,
[PkApiId] [int] NOT NULL,
[Image] [nvarchar](max) NOT NULL,
[ModifiedDate] [date] NOT NULL,
[ResourceUri] [nvarchar](255) NOT NULL,
CONSTRAINT [PK_Sprite] PRIMARY KEY CLUSTERED
(
[SpriteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[Type](
[TypeId] [int] IDENTITY(1,1) NOT NULL,
[PkApiId] [int] NOT NULL,
[Name] [nvarchar](255) NOT NULL,
[ModifiedDate] [date] NOT NULL,
[ResourceUri] [nvarchar](255) NOT NULL,
CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED
(
[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TypeEffect](
[TypeEffectId] [int] IDENTITY(1,1) NOT NULL,
[Name] [nvarchar](255) NOT NULL,
CONSTRAINT [PK_TypeEffect] PRIMARY KEY CLUSTERED
(
[TypeEffectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TypeToTypeEffect](
[TypeToTypeEffectId] [int] IDENTITY(1,1) NOT NULL,
[TypeId] [int] NOT NULL,
[AgainstTypeId] [int] NOT NULL,
[TypeEffectId] [int] NOT NULL,
CONSTRAINT [PK_TypeToTypeEffect] PRIMARY KEY CLUSTERED
(
[TypeToTypeEffectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PokemonAbility](
[PokemonAbilityId] [int] IDENTITY(1,1) NOT NULL,
[PokemonId] [int] NOT NULL,
[AbilityId] [int] NOT NULL
CONSTRAINT [PK_PokemonAbility] PRIMARY KEY CLUSTERED
(
[PokemonAbilityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PokemonDescription](
[PokemonDescriptionId] [int] IDENTITY(1,1) NOT NULL,
[PokemonId] [int] NOT NULL,
[DescriptionId] [int] NOT NULL
CONSTRAINT [PK_PokemonDescription] PRIMARY KEY CLUSTERED
(
[PokemonDescriptionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PokemonEvolution](
[EvolutionId] [int] IDENTITY(1,1) NOT NULL,
[FromPokemonId] [int] NOT NULL,
[ToPokemonId] [int] NOT NULL,
[PokemonLevel] [int] NULL,
[Method] [nvarchar](500) NOT NULL,
CONSTRAINT [PK_PokemonEvolution] PRIMARY KEY CLUSTERED
(
[EvolutionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PokemonMove](
[PokemonMoveId] [int] IDENTITY(1,1) NOT NULL,
[PokemonId] [int] NOT NULL,
[MoveId] [int] NOT NULL,
[LearnType] [nvarchar](255) NOT NULL,
[PokemonLevel] [int] NULL,
CONSTRAINT [PK_PokemonMove] PRIMARY KEY CLUSTERED
(
[PokemonMoveId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PokemonSprite](
[PokemonSpriteId] [int] IDENTITY(1,1) NOT NULL,
[PokemonId] [int] NOT NULL,
[SpriteId] [int] NOT NULL
CONSTRAINT [PK_PokemonSprite] PRIMARY KEY CLUSTERED
(
[PokemonSpriteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PokemonType](
[PokemonTypeId] [int] IDENTITY(1,1) NOT NULL,
[PokemonId] [int] NOT NULL,
[TypeId] [int] NOT NULL
CONSTRAINT [PK_PokemonType] PRIMARY KEY CLUSTERED
(
[PokemonTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Add Constraints ******/
ALTER TABLE [dbo].[DescriptionGame]  WITH CHECK ADD  CONSTRAINT [FK_DescriptionGame_Description] FOREIGN KEY([DescriptionId])
REFERENCES [dbo].[Description] ([DescriptionId])
GO

ALTER TABLE [dbo].[DescriptionGame] CHECK CONSTRAINT [FK_DescriptionGame_Description]
GO

ALTER TABLE [dbo].[DescriptionGame]  WITH CHECK ADD  CONSTRAINT [FK_DescriptionGame_Game] FOREIGN KEY([GameId])
REFERENCES [dbo].[Game] ([GameId])
GO

ALTER TABLE [dbo].[DescriptionGame] CHECK CONSTRAINT [FK_DescriptionGame_Game]
GO

ALTER TABLE [dbo].[TypeToTypeEffect]  WITH CHECK ADD  CONSTRAINT [FK_TypeToTypeEffect_Type] FOREIGN KEY([TypeId])
REFERENCES [dbo].[Type] ([TypeId])
GO

ALTER TABLE [dbo].[TypeToTypeEffect] CHECK CONSTRAINT [FK_TypeToTypeEffect_Type]
GO

ALTER TABLE [dbo].[TypeToTypeEffect]  WITH CHECK ADD  CONSTRAINT [FK_TypeToTypeEffect_Type1] FOREIGN KEY([AgainstTypeId])
REFERENCES [dbo].[Type] ([TypeId])
GO

ALTER TABLE [dbo].[TypeToTypeEffect] CHECK CONSTRAINT [FK_TypeToTypeEffect_Type1]
GO

ALTER TABLE [dbo].[TypeToTypeEffect]  WITH CHECK ADD  CONSTRAINT [FK_TypeToTypeEffect_TypeEffect] FOREIGN KEY([TypeEffectId])
REFERENCES [dbo].[TypeEffect] ([TypeEffectId])
GO

ALTER TABLE [dbo].[TypeToTypeEffect] CHECK CONSTRAINT [FK_TypeToTypeEffect_TypeEffect]
GO

ALTER TABLE [dbo].[PokemonAbility]  WITH CHECK ADD  CONSTRAINT [FK_PokemonAbility_Ability] FOREIGN KEY([AbilityId])
REFERENCES [dbo].[Ability] ([AbilityId])
GO

ALTER TABLE [dbo].[PokemonAbility] CHECK CONSTRAINT [FK_PokemonAbility_Ability]
GO

ALTER TABLE [dbo].[PokemonAbility]  WITH CHECK ADD  CONSTRAINT [FK_PokemonAbility_Pokemon] FOREIGN KEY([PokemonId])
REFERENCES [dbo].[Pokemon] ([PokemonId])
GO

ALTER TABLE [dbo].[PokemonAbility] CHECK CONSTRAINT [FK_PokemonAbility_Pokemon]
GO

ALTER TABLE [dbo].[PokemonDescription]  WITH CHECK ADD  CONSTRAINT [FK_PokemonDescription_Description] FOREIGN KEY([DescriptionId])
REFERENCES [dbo].[Description] ([DescriptionId])
GO

ALTER TABLE [dbo].[PokemonDescription] CHECK CONSTRAINT [FK_PokemonDescription_Description]
GO

ALTER TABLE [dbo].[PokemonDescription]  WITH CHECK ADD  CONSTRAINT [FK_PokemonDescription_Pokemon] FOREIGN KEY([PokemonId])
REFERENCES [dbo].[Pokemon] ([PokemonId])
GO

ALTER TABLE [dbo].[PokemonDescription] CHECK CONSTRAINT [FK_PokemonDescription_Pokemon]
GO

ALTER TABLE [dbo].[PokemonEvolution]  WITH CHECK ADD  CONSTRAINT [FK_PokemonEvolution_Pokemon] FOREIGN KEY([FromPokemonId])
REFERENCES [dbo].[Pokemon] ([PokemonId])
GO

ALTER TABLE [dbo].[PokemonEvolution] CHECK CONSTRAINT [FK_PokemonEvolution_Pokemon]
GO

ALTER TABLE [dbo].[PokemonEvolution]  WITH CHECK ADD  CONSTRAINT [FK_PokemonEvolution_Pokemon1] FOREIGN KEY([ToPokemonId])
REFERENCES [dbo].[Pokemon] ([PokemonId])
GO

ALTER TABLE [dbo].[PokemonEvolution] CHECK CONSTRAINT [FK_PokemonEvolution_Pokemon1]
GO

ALTER TABLE [dbo].[PokemonMove]  WITH CHECK ADD  CONSTRAINT [FK_PokemonMove_Move] FOREIGN KEY([MoveId])
REFERENCES [dbo].[Move] ([MoveId])
GO

ALTER TABLE [dbo].[PokemonMove] CHECK CONSTRAINT [FK_PokemonMove_Move]
GO

ALTER TABLE [dbo].[PokemonMove]  WITH CHECK ADD  CONSTRAINT [FK_PokemonMove_Pokemon] FOREIGN KEY([PokemonId])
REFERENCES [dbo].[Pokemon] ([PokemonId])
GO

ALTER TABLE [dbo].[PokemonMove] CHECK CONSTRAINT [FK_PokemonMove_Pokemon]
GO

ALTER TABLE [dbo].[PokemonSprite]  WITH CHECK ADD  CONSTRAINT [FK_PokemonSprite_Pokemon] FOREIGN KEY([PokemonId])
REFERENCES [dbo].[Pokemon] ([PokemonId])
GO

ALTER TABLE [dbo].[PokemonSprite] CHECK CONSTRAINT [FK_PokemonSprite_Pokemon]
GO

ALTER TABLE [dbo].[PokemonSprite]  WITH CHECK ADD  CONSTRAINT [FK_PokemonSprite_Sprite] FOREIGN KEY([SpriteId])
REFERENCES [dbo].[Sprite] ([SpriteId])
GO

ALTER TABLE [dbo].[PokemonSprite] CHECK CONSTRAINT [FK_PokemonSprite_Sprite]
GO

ALTER TABLE [dbo].[PokemonType]  WITH CHECK ADD  CONSTRAINT [FK_PokemonType_Pokemon] FOREIGN KEY([PokemonId])
REFERENCES [dbo].[Pokemon] ([PokemonId])
GO

ALTER TABLE [dbo].[PokemonType] CHECK CONSTRAINT [FK_PokemonType_Pokemon]
GO

ALTER TABLE [dbo].[PokemonType]  WITH CHECK ADD  CONSTRAINT [FK_PokemonType_Type] FOREIGN KEY([TypeId])
REFERENCES [dbo].[Type] ([TypeId])
GO

ALTER TABLE [dbo].[PokemonType] CHECK CONSTRAINT [FK_PokemonType_Type]
GO

/****** Insert Type Data ******/
Insert INTO [dbo].[TypeEffect] ([Name]) VALUES ('ineffective')
Insert INTO [dbo].[TypeEffect] ([Name]) VALUES ('no_effect')
Insert INTO [dbo].[TypeEffect] ([Name]) VALUES ('resistance')
Insert INTO [dbo].[TypeEffect] ([Name]) VALUES ('super_effective')
Insert INTO [dbo].[TypeEffect] ([Name]) VALUES ('weakness')