CREATE DATABASE ContactoFormBD;


USE ContactoFormBD;


-- Crear la tabla Contactos
CREATE TABLE Contactos (
    idContacto INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    telefono VARCHAR(20) NULL,
    email VARCHAR(150) UNIQUE NULL
);

