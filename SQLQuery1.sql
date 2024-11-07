CREATE TABLE Students (
    StudentId INT PRIMARY KEY,              -- Unique identifier for each student
    FirstName NVARCHAR(50) NOT NULL,         -- First name of the student (duplicates allowed)
    LastName NVARCHAR(50) NOT NULL,          -- Last name of the student (duplicates allowed)
    Email NVARCHAR(100) NOT NULL,     -- Unique email address
    UserName VARCHAR(50) NOT NULL,   -- Unique username for the student
    Password VARCHAR(100) NOT NULL,         -- Password (hashed for security)
    EnrollmentDate DATE NOT NULL,           -- Date of enrollment
    Program VARCHAR(100) NOT NULL           -- Program or course of study
);


INSERT INTO Students (StudentId, FirstName, LastName, Email, UserName, Password, EnrollmentDate, Program) VALUES
(1002, 'Pat', 'Smith', 'pat.smith@mcm.edu.ph', 'patsmith', 'Pass0002!', '2024-02-19', 'Business'),
(1003, 'Taylor', 'Taylor', 'taylor.taylor@mcm.edu.ph', 'taylortaylor', 'Pass0003!', '2022-06-13', 'History'),
(1004, 'Casey', 'Smith', 'casey.smith@mcm.edu.ph', 'caseysmith', 'Pass0004!', '2022-04-08', 'Mathematics'),
(1005, 'Jane', 'Smith', 'jane.smith@mcm.edu.ph', 'janesmith', 'Pass0005!', '2024-06-22', 'Computer Science'),
(1006, 'Chris', 'Miller', 'chris.miller@mcm.edu.ph', 'chrismiller', 'Pass0006!', '2024-08-17', 'Engineering'),
(1007, 'John', 'Taylor', 'john.taylor@mcm.edu.ph', 'johntaylor', 'Pass0007!', '2022-02-12', 'Business'),
(1008, 'Pat', 'Moore', 'pat.moore@mcm.edu.ph', 'patmoore', 'Pass0008!', '2023-09-18', 'Biology'),
(1009, 'Chris', 'Brown', 'chris.brown@mcm.edu.ph', 'chrisbrown', 'Pass0009!', '2024-01-24', 'Computer Science'),
(1010, 'John', 'Smith', 'john.smith@mcm.edu.ph', 'johnsmith', 'Pass0010!', '2023-06-11', 'Business'),
(1011, 'John', 'Johnson', 'john.johnson@mcm.edu.ph', 'johnjohnson', 'Pass0011!', '2024-03-30', 'History'),
(1012, 'Taylor', 'Davis', 'taylor.davis@mcm.edu.ph', 'taylordavis', 'Pass0012!', '2024-09-10', 'Biology'),
(1013, 'Alex', 'Johnson', 'alex.johnson@mcm.edu.ph', 'alexjohnson', 'Pass0013!', '2024-03-16', 'Computer Science'),
(1014, 'Jordan', 'Brown', 'jordan.brown@mcm.edu.ph', 'jordanbrown', 'Pass0014!', '2024-09-29', 'Mathematics'),
(1015, 'Taylor', 'Moore', 'taylor.moore@mcm.edu.ph', 'taylormoore', 'Pass0015!', '2024-01-10', 'Engineering'),
(1016, 'John', 'Brown', 'john.brown@mcm.edu.ph', 'johnbrown', 'Pass0016!', '2023-11-11', 'Business'),
(1017, 'Casey', 'Thomas', 'casey.thomas@mcm.edu.ph', 'caseythomas', 'Pass0017!', '2024-09-07', 'Biology'),
(1018, 'Chris', 'Davis', 'chris.davis@mcm.edu.ph', 'chrisdavis', 'Pass0018!', '2022-05-04', 'Engineering'),
(1019, 'Chris', 'Wilson', 'chris.wilson@mcm.edu.ph', 'chriswilson', 'Pass0019!', '2022-08-10', 'Computer Science'),
(1020, 'Chris', 'Wilson', 'chris.wilson@mcm.edu.ph', 'chriswilson', 'Pass0020!', '2023-05-03', 'Biology'),
(1021, 'Chris', 'Anderson', 'chris.anderson@mcm.edu.ph', 'chrisanderson', 'Pass0021!', '2022-03-11', 'Business'),
(1022, 'Taylor', 'Johnson', 'taylor.johnson@mcm.edu.ph', 'taylorjohnson', 'Pass0022!', '2023-10-28', 'Mathematics'),
(1023, 'Lee', 'Anderson', 'lee.anderson@mcm.edu.ph', 'leeanderson', 'Pass0023!', '2024-09-24', 'Business'),
(1024, 'Jordan', 'Smith', 'jordan.smith@mcm.edu.ph', 'jordansmith', 'Pass0024!', '2024-06-13', 'Biology'),
(1025, 'Lee', 'Davis', 'lee.davis@mcm.edu.ph', 'leedavis', 'Pass0025!', '2024-09-16', 'Biology'),
(1026, 'Casey', 'Wilson', 'casey.wilson@mcm.edu.ph', 'caseywilson', 'Pass0026!', '2023-06-10', 'Biology'),
(1027, 'Lee', 'Wilson', 'lee.wilson@mcm.edu.ph', 'leewilson', 'Pass0027!', '2022-05-25', 'Mathematics'),
(1028, 'Chris', 'Brown', 'chris.brown@mcm.edu.ph', 'chrisbrown', 'Pass0028!', '2024-10-03', 'Computer Science'),
(1029, 'Jane', 'Brown', 'jane.brown@mcm.edu.ph', 'janebrown', 'Pass0029!', '2024-10-12', 'Engineering'),
(1030, 'Taylor', 'Smith', 'taylor.smith@mcm.edu.ph', 'taylorsmith', 'Pass0030!', '2022-05-28', 'History'),
(1031, 'Jane', 'Moore', 'jane.moore@mcm.edu.ph', 'janemoore', 'Pass0031!', '2023-12-03', 'Biology'),
(1032, 'Jane', 'Moore', 'jane.moore@mcm.edu.ph', 'janemoore', 'Pass0032!', '2023-10-16', 'Business'),
(1033, 'Alex', 'Anderson', 'alex.anderson@mcm.edu.ph', 'alexanderson', 'Pass0033!', '2023-03-27', 'History'),
(1034, 'Jordan', 'Davis', 'jordan.davis@mcm.edu.ph', 'jordandavis', 'Pass0034!', '2024-10-17', 'Business'),
(1035, 'Alex', 'Johnson', 'alex.johnson@mcm.edu.ph', 'alexjohnson', 'Pass0035!', '2022-03-06', 'Computer Science'),
(1036, 'Pat', 'Wilson', 'pat.wilson@mcm.edu.ph', 'patwilson', 'Pass0036!', '2022-05-25', 'History'),
(1037, 'Morgan', 'Smith', 'morgan.smith@mcm.edu.ph', 'morgansmith', 'Pass0037!', '2023-12-08', 'Business'),
(1038, 'Jordan', 'Thomas', 'jordan.thomas@mcm.edu.ph', 'jordanthomas', 'Pass0038!', '2023-08-19', 'Biology'),
(1039, 'Casey', 'Smith', 'casey.smith@mcm.edu.ph', 'caseysmith', 'Pass0039!', '2023-11-30', 'Engineering'),
(1040, 'John', 'Davis', 'john.davis@mcm.edu.ph', 'johndavis', 'Pass0040!', '2022-11-28', 'Biology'),
(1041, 'Jordan', 'Wilson', 'jordan.wilson@mcm.edu.ph', 'jordanwilson', 'Pass0041!', '2023-04-01', 'History'),
(1042, 'Taylor', 'Anderson', 'taylor.anderson@mcm.edu.ph', 'tayloranderson', 'Pass0042!', '2024-03-16', 'Mathematics'),
(1043, 'Chris', 'Brown', 'chris.brown@mcm.edu.ph', 'chrisbrown', 'Pass0043!', '2024-06-10', 'Business'),
(1044, 'Chris', 'Johnson', 'chris.johnson@mcm.edu.ph', 'chrisjohnson', 'Pass0044!', '2023-10-13', 'Computer Science'),
(1045, 'Morgan', 'Thomas', 'morgan.thomas@mcm.edu.ph', 'morganthomas', 'Pass0045!', '2023-09-03', 'Computer Science'),
(1046, 'Chris', 'Taylor', 'chris.taylor@mcm.edu.ph', 'christaylor', 'Pass0046!', '2024-04-18', 'Computer Science'),
(1047, 'Jordan', 'Wilson', 'jordan.wilson@mcm.edu.ph', 'jordanwilson', 'Pass0047!', '2022-09-17', 'Business'),
(1048, 'Taylor', 'Taylor', 'taylor.taylor@mcm.edu.ph', 'taylortaylor', 'Pass0048!', '2023-01-30', 'Engineering'),
(1049, 'Jordan', 'Taylor', 'jordan.taylor@mcm.edu.ph', 'jordantaylor', 'Pass0049!', '2023-12-28', 'Mathematics'),
(1050, 'Chris', 'Smith', 'chris.smith@mcm.edu.ph', 'chrissmith', 'Pass0050!', '2023-10-13', 'Computer Science'),
(1051, 'Taylor', 'Wilson', 'taylor.wilson@mcm.edu.ph', 'taylorwilson', 'Pass0051!', '2022-07-14', 'Engineering');

CREATE TABLE Courses (
    CourseId INT PRIMARY KEY IDENTITY(1,1),
    CourseName NVARCHAR(100) NOT NULL,
    CourseCode NVARCHAR(20) NOT NULL UNIQUE,
    Credits INT NOT NULL,
    Description NVARCHAR(MAX)
);


INSERT INTO Courses (CourseId, CourseName, CourseCode, Credits, Description) VALUES
('C101', 'Introduction to Programming', 'IN001', 3, 'An introductory course in introduction to programming.'),
('C102', 'Data Structures', 'DA002', 1, 'An introductory course in data structures.'),
('C103', 'Algorithms', 'AL003', 4, 'An introductory course in algorithms.'),
('M104', 'Calculus', 'CA004', 4, 'An introductory course in calculus.'),
('E105', 'Physics', 'PH005', 1, 'An introductory course in physics.'),
('S106', 'Chemistry', 'CH006', 2, 'An introductory course in chemistry.'),
('A107', 'Art History', 'AR007', 3, 'An introductory course in art history.'),
('H108', 'Psychology', 'PS008', 3, 'An introductory course in psychology.'),
('B109', 'Economics', 'EC009', 5, 'An introductory course in economics.'),
('H110', 'Philosophy', 'PH010', 5, 'An introductory course in philosophy.'),
('A111', 'Literature', 'LI011', 3, 'An introductory course in literature.'),
('M112', 'Statistics', 'ST012', 3, 'An introductory course in statistics.'),
('S113', 'Biology', 'BI013', 1, 'An introductory course in biology.'),
('C114', 'Web Development', 'WE014', 3, 'An introductory course in web development.'),
('C115', 'Database Systems', 'DA015', 1, 'An introductory course in database systems.'),
('C116', 'Operating Systems', 'OP016', 5, 'An introductory course in operating systems.'),
('C117', 'Networking', 'NE017', 2, 'An introductory course in networking.'),
('C118', 'Artificial Intelligence', 'AR018', 3, 'An introductory course in artificial intelligence.'),
('C119', 'Machine Learning', 'MA019', 1, 'An introductory course in machine learning.'),
('C120', 'Ethics in Tech', 'ET020', 1, 'An introductory course in ethics in tech.'),
('C121', 'Cloud Computing', 'CL021', 5, 'An introductory course in cloud computing.'),
('C122', 'Cybersecurity', 'CY022', 4, 'An introductory course in cybersecurity.'),
('C123', 'Digital Marketing', 'DI023', 1, 'An introductory course in digital marketing.'),
('B124', 'Finance', 'FI024', 3, 'An introductory course in finance.'),
('B125', 'Accounting', 'AC025', 4, 'An introductory course in accounting.'),
('H126', 'Human Resources', 'HU026', 3, 'An introductory course in human resources.'),
('H127', 'Management', 'MA027', 4, 'An introductory course in management.'),
('A128', 'English Composition', 'EN028', 1, 'An introductory course in english composition.'),
('A129', 'History', 'HI029', 3, 'An introductory course in history.'),
('H130', 'Political Science', 'PO030', 3, 'An introductory course in political science.');

CREATE TABLE Enrollments (
    EnrollmentId INT PRIMARY KEY IDENTITY(1,1),
    StudentId INT NOT NULL,
    CourseId INT NOT NULL,
    EnrollmentDate DATE NOT NULL,
    UNIQUE (EnrollmentId),
    UNIQUE (StudentId, CourseId)
);
   

INSERT INTO Enrollments (EnrollmentId, StudentId, CourseId, EnrollmentDate) VALUES
('E001', 'S001', 'C001', '2023-01-10'),
('E002', 'S001', 'C002', '2023-01-10'),
('E003', 'S002', 'C001', '2023-01-11'),
('E004', 'S002', 'C003', '2023-01-11'),
('E005', 'S003', 'C004', '2023-01-12'),
('E006', 'S004', 'C005', '2023-01-13'),
('E007', 'S005', 'C006', '2023-01-14'),
('E008', 'S006', 'C007', '2023-01-15'),
('E009', 'S007', 'C008', '2023-01-16'),
('E010', 'S008', 'C009', '2023-01-17');

CREATE TABLE Admins (
    AdminId INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(255) NOT NULL
);


INSERT INTO Admins (AdminId, FirstName, LastName, Email, Username, Password) VALUES
('A101', 'John', 'Smith', 'john.smith@mcm.edu.ph', 'johnsmith', 'Pass9859'),
('A102', 'Jane', 'Johnson', 'jane.johnson@mcm.edu.ph', 'janejohnson', 'Pass3776'),
('A103', 'Alice', 'Williams', 'alice.williams@mcm.edu.ph', 'alicewilliams', 'Pass9583'),
('A104', 'Bob', 'Jones', 'bob.jones@mcm.edu.ph', 'bobjones', 'Pass1329'),
('A105', 'Michael', 'Brown', 'michael.brown@mcm.edu.ph', 'michaelbrown', 'Pass5564'),
('A106', 'Sarah', 'Davis', 'sarah.davis@mcm.edu.ph', 'sarahdavis', 'Pass5721'),
('A107', 'David', 'Miller', 'david.miller@mcm.edu.ph', 'davidmiller', 'Pass2122'),
('A108', 'Laura', 'Wilson', 'laura.wilson@mcm.edu.ph', 'laurawilson', 'Pass4166'),
('A109', 'Chris', 'Moore', 'chris.moore@mcm.edu.ph', 'chrismoore', 'Pass4708'),
('A110', 'Sophia', 'Taylor', 'sophia.taylor@mcm.edu.ph', 'sophiataylor', 'Pass1716'),
('A111', 'Ethan', 'Anderson', 'ethan.anderson@mcm.edu.ph', 'ethananderson', 'Pass8382'),
('A112', 'Emma', 'Thomas', 'emma.thomas@mcm.edu.ph', 'emmathomas', 'Pass3032'),
('A113', 'Daniel', 'Jackson', 'daniel.jackson@mcm.edu.ph', 'danieljackson', 'Pass5983'),
('A114', 'Olivia', 'White', 'olivia.white@mcm.edu.ph', 'oliviawhite', 'Pass4881'),
('A115', 'James', 'Harris', 'james.harris@mcm.edu.ph', 'jamesharris', 'Pass2662');