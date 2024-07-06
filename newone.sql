USE [School Management System];

DROP TABLE students;
DROP TABLE subjects;
DROP TABLE grades;
DROP TABLE student_subject;
DROP TABLE grade_subject;

-- Create grades Table
CREATE TABLE grades (
    id INT PRIMARY KEY IDENTITY(1,1),
    grade_name VARCHAR(20) UNIQUE,
    grade_group VARCHAR(15),
    grade_order INT,
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    deleted_at DATETIME
);

-- Create subjects Table
CREATE TABLE subjects (
    id INT PRIMARY KEY IDENTITY(1,1),
    subject_name VARCHAR(15),
    subject_index INT,
    subject_number INT,
    subject_order INT,
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    deleted_at DATETIME
);


-- Create students Table
CREATE TABLE students (
    id INT PRIMARY KEY IDENTITY(1,1),
    admission_no VARCHAR(20) UNIQUE,
    first_name VARCHAR(20),
    last_name VARCHAR(20),
    full_name VARCHAR(40),
    gender VARCHAR(10),
    date_of_birth DATE,
    student_nic_no VARCHAR(15),
    tp_no VARCHAR(15),
    grade_id INT,
    medium VARCHAR(10),
    date_of_admission DATE,
    resident_address VARCHAR(50),
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    deleted_at DATETIME,
    CONSTRAINT FK_students_grades FOREIGN KEY (grade_id) REFERENCES grades(id)
);

/*-- Create student_subjects Table
CREATE TABLE student_subject (
    id INT,
    subject_id INT,
    admission_no VARCHAR(20),
    PRIMARY KEY (id, subject_id),
    FOREIGN KEY (id) REFERENCES students(id),
    FOREIGN KEY (subject_id) REFERENCES subjects(id),
    FOREIGN KEY (admission_no) REFERENCES students(admission_no)
);*/
CREATE TABLE student_subject (
    id INT,
    subject_id INT,
    admission_no VARCHAR(20),
    PRIMARY KEY (id, subject_id),
    FOREIGN KEY (id) REFERENCES students(id),
    FOREIGN KEY (subject_id) REFERENCES subjects(id),
    FOREIGN KEY (admission_no) REFERENCES students(admission_no),
    UNIQUE (admission_no, subject_id)
);


-- Create grade_subjects Table
CREATE TABLE grade_subject(
    id INT PRIMARY KEY IDENTITY(1,1),
    grade_id INT,
    subject_id INT,
    CONSTRAINT FK_grade_subjects_grades FOREIGN KEY (grade_id) REFERENCES grades(id),
    CONSTRAINT FK_grade_subjects_subjects FOREIGN KEY (subject_id) REFERENCES subjects(id)
);

SELECT * FROM students;
SELECT * FROM subjects;
SELECT * FROM grades;
SELECT * FROM student_subject;
SELECT * FROM grade_subject;

INSERT INTO students (admission_no, first_name, last_name, full_name, gender, date_of_birth, tp_no, grade_id, medium, date_of_admission, resident_address)
VALUES
('SSH4', 'SHANTH', 'PIRASHANTH', 'SHANTH PIRASHANTH', 'Male', '1999-03-05', '0779214020', 1030, 'TAMIL', '2024-01-01', 'JAFFNA'),
('SSH5', 'SHANTH', 'PIRASHANTH', 'SHANTH PIRASHANTH', 'Male', '1999-03-05', '0779214020', 1030, 'TAMIL', '2024-01-01', 'JAFFNA'),
('SSH6', 'SHANTH', 'PIRASHANTH', 'SHANTH PIRASHANTH', 'Male', '1999-03-05', '0779214020', 1033, 'TAMIL', '2024-01-01', 'JAFFNA');

SELECT * FROM students;
SELECT * FROM grades;

INSERT INTO grades(grade_name,grade_group,grade_order)
VALUES ('maths','b',5)




INSERT INTO grades (grade_name, grade_group, grade_order)
VALUES 
('Grade 1', 'Primary', 1),
('Grade 2', 'Primary', 2),
('Grade 3', 'Primary', 3),
('Grade 4', 'Primary', 4),
('Grade 5', 'Primary', 5),
('Grade 6', 'Secondary', 6),
('Grade 7', 'Secondary', 7),
('Grade 8', 'Secondary', 8),
('Grade 9', 'Secondary', 9),
('Grade 10', 'Secondary', 10),
('Grade 11', 'Secondary', 11),
('Grade 12', 'Advanced Level', 12),
('Grade 13', 'Advanced Level', 13);


INSERT INTO grades (grade_name, grade_group, grade_order)
VALUES 
('Grade 12', NULL, 56),
('Grade 13', NULL, 57);



ALTER TABLE subjects
ALTER COLUMN subject_name VARCHAR(30);

INSERT INTO subjects (subject_name, subject_index, subject_number, subject_order)
VALUES
('Mathematics', 101, 1, 1),
('Science', 102, 2, 2),
('Sinhala', 103, 3, 3),
('Tamil', 104, 4, 4),
('English', 105, 5, 5),
('History', 106, 6, 6),
('Geography', 107, 7, 7),
('Civics', 108, 8, 8),
('Information Technology', 109, 9, 9),
('Health and Physical Education', 110, 10, 10),
('Commerce', 111, 11, 11),
('Art', 112, 12, 12),
('Music', 113, 13, 13),
('Drama', 114, 14, 14),
('Buddhism', 115, 15, 15),
('Islam', 116, 16, 16),
('Christianity', 117, 17, 17),
('Hinduism', 118, 18, 18);



INSERT INTO students (admission_no, first_name, last_name, full_name, gender, date_of_birth, student_nic_no, tp_no, grade_id, medium, date_of_admission, resident_address)
VALUES
('2024/001', 'Lavan', 'Sivalingam', 'Sivalingam Lavan', 'Male', '1999-02-10', '199912345V', '0712345678', 7, 'TAMIL', '2011-01-15', 'Colombo');
/*('2024/002', 'Nimal', 'Perera', 'Nimal Perera', 'Male', '2004-08-22', '200412346V', '0723456789', 2, 'SINHALA', '2010-03-20', 'Kandy'),
('2024/003', 'Samantha', 'Rajapakse', 'Samantha Rajapakse', 'Female', '2003-11-30', '200312347V', '0774567890', 3, 'ENGLISH', '2009-05-10', 'Galle'),
('2024/004', 'Mala', 'De Silva', 'Mala De Silva', 'Female', '2002-05-14', '200212348V', '0765678901', 4, 'SINHALA', '2008-09-25', 'Kurunegala'),
('2024/005', 'Ravi', 'Fernando', 'Ravi Fernando', 'Male', '2001-07-05', '200112349V', '0756789012', 5, 'ENGLISH', '2007-01-05', 'Matara'),
('2024/006', 'Anjali', 'Wijesinghe', 'Anjali Wijesinghe', 'Female', '2000-03-18', '200012350V', '0747890123', 6, 'TAMIL', '2006-04-14', 'Jaffna'),
('2024/007', 'Gayan', 'Herath', 'Gayan Herath', 'Male', '1999-10-10', '199912351V', '0738901234', 7, 'SINHALA', '2005-07-07', 'Anuradhapura'),
('2024/008', 'Sithara', 'Jayawardena', 'Sithara Jayawardena', 'Female', '1998-12-01', '199812352V', '0729012345', 8, 'ENGLISH', '2004-11-22', 'Badulla'),
('2024/009', 'Nirosh', 'Gunasekara', 'Nirosh Gunasekara', 'Male', '1997-06-20', '199712353V', '0710123456', 9, 'TAMIL', '2003-02-13', 'Trincomalee'),
('2024/010', 'Piumi', 'Rathnayake', 'Piumi Rathnayake', 'Female', '1996-04-11', '199612354V', '0701234567', 10, 'SINHALA', '2002-08-19', 'Ratnapura');
*/