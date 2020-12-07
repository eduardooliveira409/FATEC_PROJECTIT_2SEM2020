CREATE TABLE PET(
	CODIGO INT NOT NULL IDENTITY,
	NOME_PET VARCHAR(50) NOT NULL,
	DATA_NASCIMENTO DATE NULL,
	SEXO CHAR(1) NOT NULL,
	TAMANHO VARCHAR(50) NULL,
	RACA VARCHAR(50) NULL,
	RESTRICOES CHAR(1) NOT NULL,
	DESC_RESTRICOES VARCHAR(200) NULL,
	CODIGO_CLIENTE INT NOT NULL,
	CONSTRAINT PK_PET PRIMARY KEY(CODIGO),
	CONSTRAINT FK_CLIENTE_PET FOREIGN KEY(CODIGO_CLIENTE)
	REFERENCES CLIENTE(CODIGO)
);
GO
CREATE TABLE CLIENTE(
	CODIGO INT NOT NULL IDENTITY,
	NOME_CLI VARCHAR(50) NOT NULL,
	DATA_NASCIMENTO DATE NOT NULL,
	SEXO CHAR(1) NOT NULL,
	CPF VARCHAR(50) NOT NULL,
	EMAIL VARCHAR(50) NOT NULL,
	TELEFONE VARCHAR(50) NOT NULL,
	CONSTRAINT PK_FUNCIONARIO1 PRIMARY KEY(CODIGO),
);