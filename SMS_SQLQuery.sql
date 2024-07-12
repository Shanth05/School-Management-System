USE [School Management System];

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
    created_at TIMESTAMP,
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
    row_version TIMESTAMP,
    updated_at DATETIME DEFAULT GETDATE(),
    deleted_at DATETIME,
    CONSTRAINT FK_students_grades FOREIGN KEY (grade_id) REFERENCES grades(id)
);

-- Create student_subjects Table
CREATE TABLE student_subjects (
    id INT,
    subject_id INT,
    admission_no VARCHAR(20),
    PRIMARY KEY (id, subject_id),
    FOREIGN KEY (id) REFERENCES students(id),
    FOREIGN KEY (subject_id) REFERENCES subjects(id),
    FOREIGN KEY (admission_no) REFERENCES students(admission_no)
);

-- Create grade_subjects Table
CREATE TABLE grade_subjects (
    id INT PRIMARY KEY IDENTITY(1,1),
    grade_id INT,
    subject_id INT,
    CONSTRAINT FK_grade_subjects_grades FOREIGN KEY (grade_id) REFERENCES grades(id),
    CONSTRAINT FK_grade_subjects_subjects FOREIGN KEY (subject_id) REFERENCES subjects(id)
);

SELECT * FROM students;
SELECT * FROM subjects;
SELECT * FROM grades;
SELECT * FROM student_subjects;
SELECT * FROM grade_subjects;

INSERT INTO students (admission_no, first_name, last_name, full_name, gender, date_of_birth, tp_no, grade_id, medium, date_of_admission, resident_address)
VALUES
('SSH4', 'SHANTH', 'PIRASHANTH', 'SHANTH PIRASHANTH', 'Male', '1999-03-05', '0779214020', 1030, 'TAMIL', '2024-01-01', 'JAFFNA'),
('SSH5', 'SHANTH', 'PIRASHANTH', 'SHANTH PIRASHANTH', 'Male', '1999-03-05', '0779214020', 1030, 'TAMIL', '2024-01-01', 'JAFFNA'),
('SSH6', 'SHANTH', 'PIRASHANTH', 'SHANTH PIRASHANTH', 'Male', '1999-03-05', '0779214020', 1033, 'TAMIL', '2024-01-01', 'JAFFNA');

SELECT * FROM students;
SELECT * FROM grades;

INSERT INTO grades(grade_name,grade_group,grade_order)
VALUES ('maths','b',5)
