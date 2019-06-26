CREATE TABLE LIVRARIA_AUTOR(
	IDAUTOR UNIQUEIDENTIFIER NOT NULL,
	NOME VARCHAR(200) NOT NULL,
	SOBRE VARCHAR(300)
	CONSTRAINT PK_AUTOR PRIMARY KEY(IDAUTOR),
	CONSTRAINT UNIQUE_AUTOR_NOME UNIQUE(NOME)
)
GO

CREATE TABLE LIVRARIA_EDITORA(
	IDEDITORA UNIQUEIDENTIFIER NOT NULL,
	NOME VARCHAR(100) NOT NULL,
	ENDERECO VARCHAR(200) NOT NULL,
	TELEFONE VARCHAR(20)
	CONSTRAINT PK_EDITORA PRIMARY KEY(IDEDITORA),
	CONSTRAINT UNIQUE_EDITORA_NOME UNIQUE(NOME)
)
GO

CREATE TABLE LIVRARIA_CARACTERISTICASLIVRO(
	IDCARACTERISTICAS UNIQUEIDENTIFIER NOT NULL,
	GENERO INT NOT NULL,
	IDIOMA INT NOT NULL,
	ACABAMENTO INT NOT NULL
	CONSTRAINT PK_CARACTERISTICASLIVRO PRIMARY KEY(IDCARACTERISTICAS)
)
GO

CREATE TABLE LIVRARIA_LIVRO(
	IDLIVRO UNIQUEIDENTIFIER NOT NULL,
	IDEDITORA UNIQUEIDENTIFIER NOT NULL,
	IDAUTOR UNIQUEIDENTIFIER NOT NULL,
	IDCARACTERISTICAS UNIQUEIDENTIFIER NOT NULL,
	NOME VARCHAR(100) NOT NULL,
	ANOEDICAO INT NOT NULL,
	NUMPAGINAS INT NOT NULL,
	EDICAO INT,
	PRECO DECIMAL NOT NULL,
	PESO DECIMAL,
	ALTURA DECIMAL NOT NULL,
	CONSTRAINT PK_LIVRO PRIMARY KEY(IDLIVRO),
	CONSTRAINT FK_LIVRO_AUTOR FOREIGN KEY(IDAUTOR) REFERENCES LIVRARIA_AUTOR(IDAUTOR),
	CONSTRAINT FK_LIVRO_EDITORA FOREIGN KEY(IDEDITORA) REFERENCES LIVRARIA_EDITORA(IDEDITORA),
	CONSTRAINT FK_LIVRO_CARACTERISTICAS FOREIGN KEY(IDCARACTERISTICAS) REFERENCES LIVRARIA_CARACTERISTICASLIVRO(IDCARACTERISTICAS),
	CONSTRAINT UNIQUE_LIVRO_CARACTERISTICAS UNIQUE(IDCARACTERISTICAS),
	CONSTRAINT UNIQUE_LIVRO_NOME UNIQUE(NOME),
)
GO