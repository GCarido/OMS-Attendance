CREATE TABLE employeerec(
R0WS INT AUTO_INCREMENT, 
Full_Name VARCHAR(50) NOT NULL,
Pass VARCHAR(50) NOT NULL,
ID VARCHAR(50) NOT NULL,
Contact VARCHAR(50) NOT NULL,
Age VARCHAR(50) NOT NULL,
City VARCHAR(50) NOT NULL,
Postal VARCHAR(50) NOT NULL,
Designation VARCHAR(50) NOT NULL,
Department VARCHAR(50) NOT NULL,
PRIMARY KEY(R0WS));



INSERT INTO employeerec(Full_Name, Pass, ID, Contact, Age, City, Postal, Designation, Department) VALUES('Paulo Amarsolo', '2314', '19-333-44' ,'09991547254', '31', 'Talisay', '6045', 'Software Engr.', 'A');
DROP TABLE employeerec;