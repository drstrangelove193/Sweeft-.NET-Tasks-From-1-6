
--Creating Table for Teachers

CREATE TABLE Teachers (
	TeacherID INT IDENTITY(1,1) PRIMARY KEY,
	FirstName VARCHAR(255),
	LastName VARCHAR(255),
	Gender VARCHAR(10),
	Course VARCHAR(100)
);

--Creating table for Pupils
CREATE TABLE Pupils (
	PupilID INT IDENTITY(1,1) PRIMARY KEY,
	FirstName VARCHAR(255),
	LastName VARCHAR(255),
	Gender VARCHAR(10),
	Class VARCHAR(100)
);

--Creating table for Teacher and Pupil relationship
CREATE TABLE TeacherPupil (
	TeacherPupilID INT IDENTITY(1,1) PRIMARY KEY,
	TeacherID INT,
	PupilID INT,
	FOREIGN KEY (TeacherID) REFERENCES Teachers(TeacherID),
	FOREIGN KEY (PupilID) REFERENCES Pupils(PupilID)
);

--To Return all Teachers that teach the pupil named "Giorgi"

SELECT * FROM Teachers
JOIN TeacherPupil ON TeacherPupil.TeacherID = Teachers.TeacherID
JOIN Pupils ON TeacherPupil.PupilID = Pupils.PupilID
WHERE Pupils.FirstName = "Giorgi";
