CREATE DATABASE IF NOT EXISTS db;
USE db;

CREATE TABLE db.User
(
	Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	Username nvarchar(128) NOT NULL,
	Password nvarchar(128) NOT NULL,
	Firstname nvarchar(50) NOT NULL,
	Lastname nvarchar(50) NOT NULL,
	Email nvarchar(256) NOT NULL,
	UpdateTime datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
	CreateTime datetime NOT NULL  DEFAULT CURRENT_TIMESTAMP,
    phone VARCHAR(50)
);