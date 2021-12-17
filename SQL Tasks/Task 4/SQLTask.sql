CREATE DATABASE CinemaDB


USE CinemaDB


CREATE TABLE Movies
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(50) NOT NULL
)


CREATE TABLE Language
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(50) NOT NULL
)


CREATE TABLE Branches
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(50) NOT NULL
)

CREATE TABLE MoviesLanguages
(
	Id INT IDENTITY PRIMARY KEY,
	MoviesId INT CONSTRAINT FK_ML_Movies FOREIGN KEY (MoviesId) REFERENCES Movies(Id),
	LanguageId INT CONSTRAINT FK_ML_Languages FOREIGN KEY (LanguageId) REFERENCES Language(Id)
)

CREATE TABLE Halls
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(50) NOT NULL,
	BranchesId INT CONSTRAINT FK_Halls_Branches FOREIGN KEY (BranchesId) REFERENCES Branches(Id)
)


CREATE TABLE Seanses
(
	Id INT IDENTITY PRIMARY KEY,
	MoviesLanguagesId INT CONSTRAINT FK_Seanses_ML FOREIGN KEY(MoviesLanguagesId) REFERENCES MoviesLanguages(Id),
	HallsId INT CONSTRAINT FK_Seanses_Halls FOREIGN KEY(HallsId) REFERENCES Halls(Id),
	Time DATETIME2,
	SubtitleLanguagesId INT CONSTRAINT FK_Seanses_Languages FOREIGN KEY(SubtitleLanguagesId) REFERENCES Language(Id),
	Price INT CONSTRAINT FK_SeansesPrice_Languages FOREIGN KEY(Price) REFERENCES Language(Id)
)

ALTER TABLE Seanses
DROP CONSTRAINT FK_SeansesPrice_Languages


EXEC sp_rename 'SEANSES', 'Seanses'


INSERT INTO Movies
VALUES
('Movie1'),
('Movie2'),
('Movie3'),
('Movie4'),
('Movie5')


INSERT INTO Language
VALUES
('Language1'),
('Language2'),
('Language3'),
('Language4'),
('Language5')

INSERT INTO MoviesLanguages
VALUES
(1,1),
(2,1),
(3,2),
(3,3),
(3,4),
(4,1),
(4,2),
(5,1),
(5,5)	

INSERT INTO Branches
VALUES
('Branche1'),
('Branche2'),
('Branche3'),
('Branche4'),
('Branche5')

INSERT INTO Halls
VALUES
('Hall1', 1),
('Hall2', 2),
('Hall3', 3),
('Hall4', 4),
('Hall5', 5)


INSERT INTO Seanses
VALUES
(1,1,'10/10/2021',1,10),
(2,2,'12/20/2021',2,12),
(3,3,'03/08/2021',3,13),
(4,4,'10/10/2021',1,14),
(5,5,'10/06/2021',1,15)


-- 2 ay öncə həmin gün olmuş seansların siyahısını gətirən select querysi
SELECT * FROM Seanses
WHERE Time LIKE '2021-10-10%'


-- bütün filmləri gətirən select query-si hansı ki, o filmin heç olmasa 1 seansı olsun (seansı olmayan filmlər gəlməsin)
SELECT * FROM Movies
JOIN MoviesLanguages ON MoviesId = Movies.Id
WHERE EXISTS (SELECT * FROM Seanses WHERE MoviesLanguagesId = MoviesLanguages.Id)


INSERT INTO Seanses
VALUES
(9,1,'03/10/2021',1,10)




/*
Seans datalarını gətirən select querysi hansı ki, hər seans datasının yanında seans table-ında olan columnlardan əlavə 
HallName və BrancName dataları da görsənsin
*/

SELECT S.Time, H.Name, B.Name  FROM Seanses AS S
JOIN Halls AS H ON HallsId = H.Id
JOIN Branches AS B ON BranchesId = B.Id


/*
Bütün hall datalarını select edən query - hansı ki halls tableındakı columnlardan əlavə hər hall datası üçün o hall-da 
olan seansların sayını da göstərsin
*/

SELECT H.Name, (SELECT COUNT(HallsId) FROM Seanses WHERE HallsId = H.Id) AS 'Count' FROM Halls AS H


INSERT INTO Seanses
VALUES
(1,2,'11/21/2021',1,10)



/*
Bugün baş tutacaq seanslarının sayı 3-dən çox olan hall-ların siyahısını göstərən select querysi
*/

CREATE VIEW VW_Hall_Count
 AS
SELECT H.Name, (SELECT COUNT(HallsId) FROM Seanses WHERE HallsId = H.Id ) AS 'Count' FROM Halls AS H


SELECT COUNT(Count) AS 'HallCount' FROM VW_Hall_Count WHERE Count > 3


INSERT INTO Seanses
VALUES
(1,2,'11/23/2021',2,10),
(1,2,'12/24/2021',3,20)