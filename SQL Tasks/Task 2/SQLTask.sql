CREATE DATABASE CinemaDB

USE CinemaDB


CREATE TABLE Movies
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(50) NOT NULL,
	RealeDate DATETIME2,
	IMDB DECIMAL(2,1),
	WatchCount INT,
	Budget FLOAT,
	BoxOffiec FLOAT
)



CREATE TABLE ActorList
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(50) NOT NULL,
	Surname NVARCHAR(50) NOT NULL,
	Age TINYINT
)



CREATE TABLE ActorMovie
(
	Id INT IDENTITY PRIMARY KEY,
	ActorId INT CONSTRAINT FK_ACTORS FOREIGN KEY (ActorId) REFERENCES ActorList(Id),
	MovieId INT CONSTRAINT FK_MOVIE FOREIGN KEY(MovieId) REFERENCES Movies(Id)
)

CREATE TABLE Genders
(
	Id INT IDENTITY PRIMARY KEY,
	GenderName NVARCHAR(30) NOT NULL
)


EXEC sp_rename 'Genders', 'Genres'


ALTER TABLE Movies
ADD GenresId INT CONSTRAINT FK_GENRES FOREIGN KEY (GenresId) REFERENCES Genres(Id)


-------------------------------------------------------------------------------------------------


INSERT Genres
VALUES
('Comedy'),
('Drama'),
('Horror'),
('Romantic'),
('Animation')



INSERT ActorList
VALUES
('A', 'B', 20),
('A1', 'B1', 21),
('A2', 'B2', 23),
('A3', 'B3', 24),
('A4', 'B4', 26),
('A5', 'B5', 27),
('A6', 'B6', 28),
('A7', 'B7', 30)

SELECT * FROM Genres


INSERT Movies
VALUES
('Movie', '2019/11/10',8.8,2345,35.756,1235.126,1),
('Movie1', '2020/01/14',8.7,4567,145.435,45.126,2),
('Movie2', '2010/11/15',9.8,234,355.434,4565.676,4),
('Movie3', '2012/03/16',8.7,876,1235.126,45.126,5),
('Movie4', '2003/09/17',3.4,678,4565.676,95.456,1),
('Movie5', '2015/01/20',9.8,2345,325.566,145.4566,3),
('Movie6', '2009/10/03',6.9,9346,145.4566,4565.676,4),
('Movie7', '2011/02/04',9.9,23678,95.456,145.4566,2),
('Movie8', '2010/12/21',5.5,8765,6785.346,145.435,5),
('Movie9', '2012/10/23',4.2,454656,645.236,4565.676,1),
('Movie10', '2001/12/30',7.9,8767,45.126,95.456,2)

SELECT * FROM Movies

INSERT INTO ActorMovie
VALUES
(1,1),
(2,2),
(3,3),
(4,4),
(5,5),
(6,6),
(7,7),
(8,8),
(1,9),
(2,10),
(3,10),
(4,1),
(5,2),
(6,3),
(7,4),
(8,5)


-- Janrların siyajısı üçün select query -  bu querydə janrların öz columnlarəından əlavə həmin janrda neçə film oduğu da görsənməlidir



-- Bütün Actors datalarını select edən query - hansıların ki yaşları ümümu bütün aktyorların yaş ortalamasından böyükdür
SELECT * FROM ActorList 
WHERE Age > (SELECT AVG(Age) FROM ActorList)


-- ActorMovies datalarını select eden query - bu query əlaqəli Actorsların Name,Surname,Age deyerleri və oynadıqları Movies datalarının adlarını göstərməlidir , 
--yəni selectin resultında Aktyorların  adı,soyadı,yaşı və oynadığı filmin adı olmalıdır.





-- Hər hansısa bir filmdə oynamış Actors dalarını select edən query, əgər Actor datası heç bir filmdə oynamayıbsa bu selectdə çıxmamalıdır

INSERT INTO ActorList
VALUES
('A8', 'B8', 32)

SELECT * FROM ActorList
WHERE EXISTS (SELECT * FROM ActorMovie WHERE ActorId = ActorList.Id)
