--CREATE DATABASE STUDENTdb;


--USE STUDENTdb;

--DROP TABLE STUDENT;


CREATE TABLE STUDENT(
ID INT PRIMARY KEY IDENTITY(1,1),
NAME NVARCHAR(250) NOT NULL,
ROLL_NO INT NOT NULL,
DEPT VARCHAR(105) NOT NULL,
SESSION VARCHAR(7) NOT NULL
);

ALTER TABLE STUDENT 
ADD DoA date not null; 


create table Subject(
id int primary key identity(1,1),
Name varchar(250) not null,
credit int not null
);

INSERT INTO Subject VALUES ('Computer', 4);
INSERT INTO Subject VALUES ('Physics', 3);
INSERT INTO SUBJECT VALUES ('Chemistry',3);
INSERT INTO Subject VALUES ('Mathematics', 5);
INSERT INTO Subject VALUES ('Electrical & elctronics Engineering', 5);
INSERT INTO Subject VALUES ('Civil Engineering', 5);
INSERT INTO Subject VALUES ('Mechanical Engineering', 4);
INSERT INTO Subject VALUES ('Petrolium & Mining Engineering', 5);


select * from Subject;

select id, name as Subject_Name,credit
from Subject
where id>4;

select id, name as Subject_Name,credit
from Subject
where name like '%ing';

select id, name as Subject_Name,credit
from Subject
where name = 'Civil Engineering';