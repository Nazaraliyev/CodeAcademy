-- #Market adli Database yaradin
-- #Icinde Products Table-i yaradin.Product table-inda Id,Name,Price columnlari olsun
-- #Brands table yaradirsiniz (Id,Name)
-- #Products table BrandId column elave edirsiz (foreign key)
-- #Products table-a value-lar insert edin (10-15 dene product datasi kifayetdir)
-- #Qiymeti 10-dan yuxari olan Product datalarinin siyahisini getiren query yazin
-- #Qiymeti Productlarin price-larinin average-den kicik olan Products datalarinin siyahisini getiren query yazin
-- #Brand uzunlugu 5-den boyuk olan Brandlerin siyahisini getiren query.


-- #Market adli Database yaradin
CREATE DATABASE Market

USE Market


-- #Icinde Products Table-i yaradin.Product table-inda Id,Name,Price columnlari olsun
CREATE TABLE Product
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(30) NOT NULL,
	Price INT
)


-- #Brands table yaradirsiniz (Id,Name)
CREATE TABLE Brand
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(30)
)


-- #Products table BrandId column elave edirsiz (foreign key)
ALTER TABLE Product
ADD BrandId INT CONSTRAINT FK_PRODUCT_BRAND FOREIGN KEY (BrandId) REFERENCES BRAND(Id)



-- #Products table-a value-lar insert edin (10-15 dene product datasi kifayetdir)
INSERT Brand
VALUES 
('Phone'),
('Notebook'),
('Watch')


INSERT Product
VALUES
('NoPhone', 100, 1 ),
('OldPhone', 100, 1 ),
('SmartPhone', 200, 1 ),
('TouchPhone', 250, 1 ),
('UltraPhone', 300, 1 ),
('Iphone', 500, 1 ),
('Laptop', 600, 2 ),
('Notebook', 700, 2 ),
('UltraBook', 800, 2 ),
('ChromeBook', 650, 2 ),
('Watch', 100, 3 ),
('SmartWatch', 400, 3 ),
('Band', 200, 3 )


-- #Qiymeti 10-dan yuxari olan Product datalarinin siyahisini getiren query yazin
SELECT * FROM Product WHERE Price > 300



-- #Qiymeti Productlarin price-larinin average-den kicik olan Products datalarinin siyahisini getiren query yazin
SELECT AVG(Price) FROM Product

SELECT * FROM Product WHERE Price < (SELECT AVG(Price) FROM Product)



-- #Brand uzunlugu 5-den boyuk olan Brandlerin siyahisini getiren query.
SELECT * FROM Brand WHERE LEN(Name) > 5