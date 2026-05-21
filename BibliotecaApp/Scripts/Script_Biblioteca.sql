CREATE DATABASE BibliotecaDB;
USE BibliotecaDB;

CREATE TABLE Categoria (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Descricao VARCHAR(100) NOT NULL
);

CREATE TABLE Autor (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(150) NOT NULL,
    Nacionalidade VARCHAR(100)
);

CREATE TABLE Livro (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Titulo VARCHAR(200) NOT NULL,
    AnoPublicacao INT,
    CategoriaId INT,
    FOREIGN KEY (CategoriaId) REFERENCES Categoria(Id)
);

CREATE TABLE Livro_Autor (
    LivroId INT,
    AutorId INT,
    PRIMARY KEY (LivroId, AutorId),
    FOREIGN KEY (LivroId) REFERENCES Livro(Id),
    FOREIGN KEY (AutorId) REFERENCES Autor(Id)
);

CREATE TABLE Usuario (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(150) NOT NULL,
    Cpf VARCHAR(14) NOT NULL UNIQUE,
    Matricula VARCHAR(50) NOT NULL,
    Telefone VARCHAR(20)
);

CREATE TABLE Emprestimo (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    LivroId INT,
    UsuarioId INT,
    DataEmprestimo DATETIME NOT NULL,
    DataDevolucao DATETIME,
    FOREIGN KEY (LivroId) REFERENCES Livro(Id),
    FOREIGN KEY (UsuarioId) REFERENCES Usuario(Id)
);