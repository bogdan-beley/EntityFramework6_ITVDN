CREATE TABLE Sections(
	Id int IDENTITY NOT NULL CONSTRAINT PK_Sections_Id PRIMARY KEY
	,[Name] nvarchar(50)
);
GO

CREATE TABLE [Types](
	Id int IDENTITY NOT NULL CONSTRAINT PK_Types_Id PRIMARY KEY
	,[Name] nvarchar(50)
);
GO

CREATE TABLE Products(
	Id int IDENTITY NOT NULL CONSTRAINT PK_Products_Id PRIMARY KEY
	,[Name] nvarchar(50)
);
GO

CREATE TABLE SectionsTypes(
	SectionId int NOT NULL
	,TypeId int NOT NULL
	,CONSTRAINT PK_SectionsTypes_SectionId_TypeId PRIMARY KEY (SectionId, TypeId)
	,CONSTRAINT FK_SectionsTypes_Sections FOREIGN KEY (SectionId) REFERENCES Sections(Id)
		ON DELETE CASCADE
	,CONSTRAINT FK_SectionsTypes_Types FOREIGN KEY (TypeId) REFERENCES [Types](Id)
		ON DELETE CASCADE
);
GO

CREATE TABLE ProductsTypes(
	ProductId int NOT NULL
	,TypeId int NOT NULL
	,CONSTRAINT PK_ProductsTypes_ProductId_TypeId PRIMARY KEY (ProductId, TypeId)
	,CONSTRAINT FK_ProductsTypes_Products FOREIGN KEY (ProductId) REFERENCES Products(Id)
	,CONSTRAINT FK_ProductsTypes_Types FOREIGN KEY (TypeId) REFERENCES [Types](Id)
);
GO