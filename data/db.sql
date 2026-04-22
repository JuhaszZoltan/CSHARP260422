CREATE DATABASE people;
GO;

USE people;
GO;

CREATE TABLE contacts (
  id INT PRIMARY KEY IDENTITY,
  name VARCHAR(100) NOT NULL,
  email VARCHAR(100) UNIQUE,
  phone VARCHAR(100) UNIQUE);

INSERT INTO contacts VALUES
('Viz Elek', 'elek@email.com', '+36201234567'),
('Para Zita', 'zita@email.com', '+36301234567'),
('Cserepes Virág', 'virag@email.com', '+36701234567');