CREATE TABLE attendancerec(
R0WS INT AUTO_INCREMENT, 
Full_Name VARCHAR(50) NOT NULL,
Clock_in VARCHAR(50) NOT NULL,
Clock_out VARCHAR(50) NOT NULL,
Login_Date VARCHAR(50) NOT NULL,
Total_Hours VARCHAR(50) NOT NULL,
PRIMARY KEY(R0WS));

INSERT INTO attendancerec(Full_Name, Clock_in, Clock_out, Login_Date) VALUES('Paulo Amarsolo', '12:14 PM', '' ,'July 18, 2022');
INSERT INTO attendancerec(Full_Name, Clock_in, Clock_out, Login_Date) VALUES('Paulo Amarsolo', '', '5:05 PM' ,'July 18, 2022');
SELECT * FROM attendancerec WHERE Full_Name ='admin';
DROP TABLE attendancerec;

UPDATE employee.employeerec SET Clock_out = {} WHERE Full_Name = {};
UPDATE attendance.attendancerec SET Clock_out = 'try' WHERE Full_Name = Vance Tamayo;
UPDATE attendance.attendancerec
SET Clock_out = 'Try'
WHERE R0WS = 1;

INSERT INTO attendancerec(Full_Name, Clock_in, Clock_out, Login_Date, Total_Hours) VALUES('Eric Aldo', '18:30', '' , '27/07/2022', 'NULL');
