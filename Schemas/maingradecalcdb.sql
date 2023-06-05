CREATE TABLE studentinfo(
R0WS INT AUTO_INCREMENT, 
Full_Name VARCHAR(50) NOT NULL,
Student_ID VARCHAR(50) NOT NULL,
Course VARCHAR(50) NOT NULL,
Subject_ VARCHAR(50) NOT NULL,
Grade_Type VARCHAR(50) NOT NULL,
Grade VARCHAR(50) NOT NULL,
PRIMARY KEY(R0WS));



DROP TABLE studentinfo;



INSERT INTO studentinfo(Full_Name, Student_ID, Course, Subject_, Grade_Type, Grade) VALUES('Paulo Amarsolo', '12-33-421', 'BSCPE-1', 'Philosophy', 'Midterm', '90.32');
INSERT INTO studentinfo(Full_Name, Student_ID, Course, Subject_, Grade_Type, Grade) VALUES('Gerald C. Carido', '18-1154-645', 'BSCPE-2', 'CPE262', 'Midterm', '85.67');
INSERT INTO studentinfo(Full_Name, Student_ID, Course, Subject_, Grade_Type, Grade) VALUES('Roben D. Reyes', '14-332-142', 'BSIT', 'Data Structure 1', 'Final', '89.98');
INSERT INTO studentinfo(Full_Name, Student_ID, Course, Subject_, Grade_Type, Grade) VALUES('Millie Ocampo', '14-332-142', 'BFA-2', 'Photography', 'Midterm', '95.66');
INSERT INTO studentinfo(Full_Name, Student_ID, Course, Subject_, Grade_Type, Grade) VALUES('Roger Adlawan', '12-423-122', 'BS Economics', 'Introduction to Finance', 'Midterm', '89.00');
INSERT INTO studentinfo(Full_Name, Student_ID, Course, Subject_, Grade_Type, Grade) VALUES('Lucila Abracosa', '35-423-331', 'Linguistics', 'Phonology', 'Final', '85.63');
INSERT INTO studentinfo(Full_Name, Student_ID, Course, Subject_, Grade_Type, Grade) VALUES('Mandy Abaya', '41-612-321', 'Political Science', 'Political Theory', 'Midterm', '82.47');
INSERT INTO studentinfo(Full_Name, Student_ID, Course, Subject_, Grade_Type, Grade) VALUES('Tyrone Barrientos', '33-423-123', 'Literature', 'Literary Research', 'Final', '94.00');
INSERT INTO studentinfo(Full_Name, Student_ID, Course, Subject_, Grade_Type, Grade) VALUES('Maverick Buenaventura', '19-452-64', 'BS Forestry', 'Forest Governance', 'Final', '92.88');
INSERT INTO studentinfo(Full_Name, Student_ID, Course, Subject_, Grade_Type, Grade) VALUES('Iris Martinez', '15-234-211', 'Applied Physics', 'General Physics', 'Final', '94.58');
INSERT INTO studentinfo(Full_Name, Student_ID, Course, Subject_, Grade_Type, Grade) VALUES('Arcadia Bañaga', '34-512-312', 'Literature', 'Modern Drama', 'Midterm', '87.29');
INSERT INTO studentinfo(Full_Name, Student_ID, Course, Subject_, Grade_Type, Grade) VALUES('Sean Macalintal', '33-441-351', 'Applied Physics', 'Quantum Mechanics', 'Midterm', '85.00');
INSERT INTO studentinfo(Full_Name, Student_ID, Course, Subject_, Grade_Type, Grade) VALUES('Adonis Barerra', '64-724-732', 'BS Forestry', 'Resource Management', 'Final', '87.00');
INSERT INTO studentinfo(Full_Name, Student_ID, Course, Subject_, Grade_Type, Grade) VALUES('Camden Belmonte', '51-211-612', 'Applied Physics', 'Electromagnetic Theory', 'Midterm', '90.44');
INSERT INTO studentinfo(Full_Name, Student_ID, Course, Subject_, Grade_Type, Grade) VALUES('Elvin Buñag', '65-432-317', 'BS Chemistry', 'Organic Chemistry', 'Final', '97.55');
INSERT INTO studentinfo(Full_Name, Student_ID, Course, Subject_, Grade_Type, Grade) VALUES('Quincy Sanchez', '16-412-443', 'Literature', 'Reading Fiction', 'Midterm', '88');
INSERT INTO studentinfo(Full_Name, Student_ID, Course, Subject_, Grade_Type, Grade) VALUES('Gian Mark Matias', '34-231-762', 'BS Chemistry', 'Analytical Chemistry', 'Midterm', '88.79');
INSERT INTO studentinfo(Full_Name, Student_ID, Course, Subject_, Grade_Type, Grade) VALUES('Alia Medina', '79-312-552', 'BS Chemistry', 'Physical Chemistry', 'Final', '91.00');
INSERT INTO studentinfo(Full_Name, Student_ID, Course, Subject_, Grade_Type, Grade) VALUES('Adrienne Dulay', '32-555-216', 'BS Forestry', 'Product Utilization', 'Final', '92.73');
INSERT INTO studentinfo(Full_Name, Student_ID, Course, Subject_, Grade_Type, Grade) VALUES('Julianne Vitug', '12-5523-161', 'BS Chemistry', 'ISMOA-231', 'Final', '82.89');
SELECT * FROM studentinfo WHERE Full_Name = 'Gerald C. Carido' or Student_ID like @Student_ID;

DELETE FROM gradecalc.studentinfo WHERE Student_Loc = @Student_Loc;



SELECT * FROM gradecalc.studentinfo 
ORDER BY Student_Loc, Full_Name;


DELETE FROM studentinfo
WHERE student_prim = 3;


UPDATE studentinfo
SET fullname = 'Remoba Flores', course = 'BSBMA'
WHERE student_prim = 1;

UPDATE gradecalc.studentinfo 
SET student_prim = @student_prim,
fullname = @fullname,
student_id = @student_id, 
course = @course,
sub_comp = @sub_comp
WHERE student_prim = @student_prim ;

UPDATE gradecalc.studentinfo SET Full_Name = @Full_Name, Student_ID = @Student_ID, Course = @Course, Subject_ = @Subject_, Grade = @Grade 
WHERE Student_Loc = @Student_Loc;

SELECT * FROM studentinfo WHERE Full_Name = 'Paulo Amarsolo';

SELECT * FROM gradecalc.studentinfo WHERE Student_ID = @Student_ID OR Full_Name LIKE @Full_Name ORDER BY Full_Name, R0WS;
