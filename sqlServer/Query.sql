CREATE TABLE Envase (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(255) NOT NULL
);

CREATE TABLE Producto (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(255) NOT NULL
);

CREATE TABLE Cilindro (
    id INT PRIMARY KEY IDENTITY(1,1),
    serie VARCHAR(50) NOT NULL,
    idenvase INT,
    idproducto INT,
    capacidad INT,
    FOREIGN KEY (idenvase) REFERENCES Envase(id),
    FOREIGN KEY (idproducto) REFERENCES Producto(id)
);

-- PARA ELIMINAR
ALTER TABLE Cilindro DROP CONSTRAINT FK_Cilindro_Envase;
ALTER TABLE Cilindro DROP CONSTRAINT FK_Cilindro_Producto;

-- Eliminar tablas
DROP TABLE Cilindro;
DROP TABLE Producto;
DROP TABLE Envase;


-- Insertar productos en la tabla Producto
INSERT INTO Producto (descripcion) 
VALUES ('Producto 1'), 
       ('Producto 2'), 
       ('Producto 3');

-- Insertar envases en la tabla Envase
INSERT INTO Envase (descripcion) 
VALUES ('A'), 
       ('B'), 
       ('C');