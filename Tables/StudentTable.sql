CREATE TABLE Students (
    StudentId VARCHAR(50) PRIMARY KEY,
    FirstName VARCHAR(100) NOT NULL,
    LastName VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    Username VARCHAR(100) NOT NULL UNIQUE,
    EnrollmentDate DATETIME NOT NULL,
    Course VARCHAR(100) -- This could reference a Course table if you want to normalize the schema
);

