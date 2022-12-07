

CREATE DATABASE DB



USE ProductDB



CREATE TABLE Product(

Product_Number nchar(5) primary key

,Description nvarchar(50) not null

, Units_On_Hand int not null

, Price money not null

)

INSERT INTO Product(Product_Number, Description, Units_On_Hand, Price)

VALUES('P1234', 'HP Laptop', 20, 560.66)

INSERT INTO Product(Product_Number, Description, Units_On_Hand, Price)

VALUES('P1235', 'Apple MacBook Pro Laptop', 25, 1577.50)

INSERT INTO Product(Product_Number, Description, Units_On_Hand, Price)

VALUES('P1236', 'Dell Laptop', 10, 450.50)

SELECT * FROM Product;