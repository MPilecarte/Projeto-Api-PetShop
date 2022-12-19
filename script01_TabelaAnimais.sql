IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Animais] (
    [id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NULL,
    [Especie] nvarchar(max) NOT NULL,
    [Porte] int NOT NULL,
    [Idade] nvarchar(max) NOT NULL,
    [Genero] int NOT NULL,
    [RGA] nvarchar(max) NOT NULL,
    [DataUltVacina] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Animais] PRIMARY KEY ([id])
);
GO

CREATE TABLE [Servicos] (
    [id] int NOT NULL IDENTITY,
    [ServicoPrestado] int NOT NULL,
    [ValorServico] real NOT NULL,
    [DataAgendada] datetime2 NULL,
    CONSTRAINT [PK_Servicos] PRIMARY KEY ([id])
);
GO

CREATE TABLE [TutorAnimais] (
    [id] int NOT NULL IDENTITY,
    [NomeDono] nvarchar(max) NOT NULL,
    [DataNasc] datetime2 NULL,
    [CPF] int NOT NULL,
    [Telefone] int NOT NULL,
    [Endereco] nvarchar(max) NOT NULL,
    [Bairro] nvarchar(max) NOT NULL,
    [NroCasa] nvarchar(max) NOT NULL,
    [CEP] int NOT NULL,
    CONSTRAINT [PK_TutorAnimais] PRIMARY KEY ([id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'DataUltVacina', N'Especie', N'Genero', N'Idade', N'Nome', N'Porte', N'RGA') AND [object_id] = OBJECT_ID(N'[Animais]'))
    SET IDENTITY_INSERT [Animais] ON;
INSERT INTO [Animais] ([id], [DataUltVacina], [Especie], [Genero], [Idade], [Nome], [Porte], [RGA])
VALUES (1, N'20-02-2022', N'Cão', 2, N'2 anos', N'Yotan', 3, N'31-121-995'),
(2, N'05-09-2022', N'Cão', 2, N'7 meses', N'RapMon', 3, N'12-091-994'),
(3, N'13-05-2022', N'Cão', 2, N'3 meses', N'Geurem', 2, N'01-091-997'),
(4, N'07-12-2022', N'Cão', 2, N'5 anos', N'Mickey', 1, N'18-021-994'),
(5, N'03-04-2022', N'Cão', 1, N'1 ano', N'Holly', 1, N'04-121-992'),
(6, N'19-08-2022', N'Gato', 2, N'4 meses', N'Curry', 1, N'13-121-995'),
(7, N'25-03-2022', N'Petauro-do-açucar', 2, N'2 anos', N'Odeg', 1, N'04-121-992');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id', N'DataUltVacina', N'Especie', N'Genero', N'Idade', N'Nome', N'Porte', N'RGA') AND [object_id] = OBJECT_ID(N'[Animais]'))
    SET IDENTITY_INSERT [Animais] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221219203013_InitialCreate', N'7.0.1');
GO

COMMIT;
GO

