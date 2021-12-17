/*
1. MS SQL-de View ve Procedure kecdik, evde bunlari oyrenib elave olaraq MS SQL-de function anlayisini arasdirmaginizi isteyirem

2.Kitabxana database-i qurursunuz

Books:
 - Id
 - Name - max 100, min 2
 - AuthorId
 - PageCount - min 10

Authors:
 - Id
 - Name
 - Surname

Books ve Authors table-lariniz olsun
 (one to many realtion) Id,Name,PageCount ve
 AuthorFullName columnlarinin valuelarini 
qaytaran bir view yaradin

Gonderilmis axtaris deyirene gore hemin axtaris
 deyeri name ve ya authorFullNamelerinde olan Book-lari
 Id,Name,PageCount,AuthorFullName columnlari seklinde
 gostern procedure yazin

Authors tableinin insert,update ve deleti ucun (her biri ucun ayrica) procedure yaradin

Authors-lari Id,FullName,BooksCount,MaxPageCount seklinde qaytaran view yaradirsiniz
Id-author id-si
FullName - Name ve Surname birlesmesi
BooksCount - Hemin authorun elaqeli oldugu kitablarin sayi
MaxPageCount - hemin authorun elaqeli oldugu kitablarin icerisindeki max pagecount deyeri
*/

CREATE DATABASE Kitabxana

USE Kitabxana

--BOOK

CREATE TABLE Book
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(100) CHECK(LEN(Name) BETWEEN 2 AND 100),
	AuthorId INT,
	PageCount INT CHECK(PageCount >= 10)
)

--AUTHOR

CREATE TABLE Author
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(50),
	Surname NVARCHAR(50)
)

ALTER TABLE Book
ADD CONSTRAINT FK_AuthorId_Book FOREIGN KEY (AuthorId) REFERENCES Author(Id)


-- INSERT DATA

INSERT INTO Author
VALUES
('Name1', 'Surname1'),
('Name2', 'Surname2'),
('Name3', 'Surname3'),
('Name4', 'Surname4'),
('Name5', 'Surname5')

SELECT * FROM Author

INSERT INTO Book
VALUES
('Book1', 1, 10),
('Book2', 2, 20),
('Book3', 3, 30),
('Book4', 4, 40),
('Book5', 5, 50),
('Book6', 1, 60),
('Book7', 2, 70),
('Book8', 3, 80),
('Book9', 4, 90),
('Book10', 5, 200)

SELECT * FROM Book


--CREATE CIEW

SELECT B.Id, B.Name, B.PageCount, CONCAT(A.Name,' ',A.Surname) AS 'AuthorFullName' FROM Book AS B
JOIN Author AS A ON A.Id = B.AuthorId



CREATE VIEW VW_AllData
AS
SELECT B.Id, B.Name, B.PageCount, CONCAT(A.Name,' ',A.Surname) AS 'AuthorFullName' FROM Book AS B
JOIN Author AS A ON A.Id = B.AuthorId


SELECT * FROM VW_AllData




--SEARCH

CREATE PROCEDURE USP_Search @value NVARCHAR(100)
AS
SELECT * FROM VW_AllData
WHERE VW_AllData.Name LIKE '%'+@value+'%' OR VW_AllData.AuthorFullName LIKE '%'+@value+'%'

DROP PROCEDURE USP_Search

EXEC USP_Search 'Book1'



--INSERT

CREATE PROCEDURE USP_Author_Inser @AuthorName NVARCHAR(50), @AuthorSurname NVARCHAR(50)
AS
INSERT INTO Author
VALUES
(@AuthorName, @AuthorSurname)

EXEC USP_Author_Inser 'Name6','Surname6'

SELECT * FROM Author




--DELETE

CREATE PROCEDURE USP_Author_DELETE @Id INT
AS
DELETE FROM Author
WHERE Author.Id = @Id

EXEC USP_Author_DELETE 7

SELECT * FROM Author



--UPDATE

CREATE PROCEDURE USP_Author_UpdateName @value NVARCHAR(50), @Id INT
AS
UPDATE Author
SET Name =  @value
WHERE Author.Id = @Id


CREATE PROCEDURE USP_Author_UpdateSurname @value NVARCHAR(50), @Id INT
AS
UPDATE Author
SET Surname =  @value
WHERE Author.Id = @Id

EXEC USP_Author_UpdateSurname 'Surname10', 8
EXEC USP_Author_UpdateName 'Name11', 8


SELECT * FROM Author



-- AUTHOR VIEW

INSERT INTO Book
VALUES
('Book11', 1, 210),
('Book12', 3, 210),
('Book13', 3, 110),
('Book14', 3, 100),
('Book15', 5, 220),
('Book16', 5, 190)


 
SELECT A.Id, A.Name + ' ' + A.Surname AS 'FullName', 
(SELECT COUNT(AuthorId) FROM Book WHERE A.Id = AuthorId) AS 'MaxPageCount',
(SELECT MAX(PageCount) FROM Book WHERE A.Id = AuthorId) AS 'BookCount'
FROM Author AS A  
WHERE EXISTS (SELECT * FROM Book WHERE Book.AuthorId = A.Id )



CREATE VIEW VW_AuthorData
AS
SELECT A.Id, A.Name + ' ' + A.Surname AS 'FullName', 
(SELECT COUNT(AuthorId) FROM Book WHERE A.Id = AuthorId) AS 'MaxPageCount',
(SELECT MAX(PageCount) FROM Book WHERE A.Id = AuthorId) AS 'BookCount'
FROM Author AS A  
WHERE EXISTS (SELECT * FROM Book WHERE Book.AuthorId = A.Id )

SELECT * FROM VW_AuthorData