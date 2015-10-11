CREATE TABLE agenda
(
    [id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [nome] VARCHAR(100) NOT NULL, 
    [telefone] VARCHAR(100) NOT NULL
);

INSERT INTO agenda (nome, telefone) VALUES ('Tadeu', '98124-7542');