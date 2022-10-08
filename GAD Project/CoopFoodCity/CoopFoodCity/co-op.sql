CREATE DATABASE CoopFoodCity;

DROP DATABASE CoopFoodCity;

USE CoopFoodCity;


CREATE TABLE Employee
(
	empid		INT		IDENTITY(54001,999) PRIMARY KEY,
	ename		VARCHAR(25)		NOT NULL,
	dob			VARCHAR(20)		NOT NULL,
	gender		VARCHAR(6)		NOT NULL,
	nic			CHAR(12)		NOT NULL UNIQUE,
	add_line1   VARCHAR(20),
	add_line2   VARCHAR(20),
	add_line3   VARCHAR(20)		NOT NULL,
	etp			CHAR(10),
	jobroll		VARCHAR(20)		NOT NULL,
	dept		VARCHAR(20)		NOT NULL,
	doa			VARCHAR(20)		NOT NULL,
	email		VARCHAR(50)		NOT NULL

);

SELECT * from Employee;

CREATE TABLE Login_User
(
	userid		INT,
	passwd		VARCHAR(20),
	jobroll		VARCHAR(20),
	--email		VARCHAR(50),
	PRIMARY KEY (userid,passwd),
	CONSTRAINT fk_le FOREIGN KEY  (userid) REFERENCES Employee(empid) ON DELETE CASCADE ON UPDATE CASCADE
);


SELECT * from Login_User;

SELECT jobroll FROM Employee WHERE empid = 'Adm01';


CREATE TABLE employee_picture

(empid INT primary key,
propic IMAGE,


);
CREATE TABLE Salary
(
	empid			INT,
	paydate			DATE,
	basic_salary	DEC(10,2),
	adjustmentall   DEC(10,2),
	livingallo		DEC(10,2),
	earnigs			DEC(10,2),
	insurance       DEC(10,2),
	loanamount		DEC(10,2),
	welfare			DEc(10,2),
	deductions		DEC(10,2),
	netsalary		DEC(10,2),


	PRIMARY KEY (empid,paydate),

	FOREIGN KEY (empid) REFERENCES Employee(empid) ON DELETE CASCADE ON UPDATE CASCADE


);


SELECT * FROM Salary;

DROP TABLE Salary;

CREATE TABLE Attendance
(
	date		DATE,
	empid		INT,
	schedule    VARCHAR(10),
	timein      VARCHAR(6),
	timeout     VARCHAR(6),
	
	PRIMARY KEY  (empid,date),

	FOREIGN KEY (empid) REFERENCES Employee(empid) ON DELETE CASCADE ON UPDATE CASCADE
);

SELECT * FROM Attendance;
 DROP TABLE Attendance;
