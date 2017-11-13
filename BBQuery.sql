CREATE TABLE Student(
Student_ID varchar (10),
Student_First_Name varchar(50),
Student_Last_Name varchar (50),
Mobile_Phone varchar (10),
PRIMARY KEY(Student_ID)
);
CREATE TABLE Class(
Course_ID varchar(10),
Course_Number varchar(4),
Course_Name varchar (50),
Semester varchar(20),
Instructor varchar(50),
PRIMARY KEY(Course_ID)
);
CREATE TABLE Grade(
Assignment_Name varchar(50),
Assignment_Weight varchar(3),
Assignment_Grade varchar(3),
Assignment_Due_Date varchar(50),
Primary Key(Assignment_Name)
);
ALTER TABLE Student
ADD CONSTRAINT FK_Class_Grade FOREIGN KEY (Class_ID)
REFERENCES Class(Class_ID)
ON DELETE SET NULL
ON UPDATE CASCADE;
ALTER TABLE Class
ADD CONSTRAINT FK_Class_Grade FOREIGN KEY(Class_ID)
REFERENCES Class(Class_ID)
ON DELETE SET NULL
ON UPDATE CASCADE;
ALTER TABLE Grade
ADD CONSTRAINT FK_Grade_Class FOREIGN KEY(Assignment_Name)
REFERENCES Grade(Assignment_Name)
ON DELETE SET NULL
ON UPDATE CASCADE;
