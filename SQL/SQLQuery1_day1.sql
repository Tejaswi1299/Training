--create database Infinitedb


use Infinitedb

Create table Department (
Deptid int primary key,
Deptname varchar(20) not null,
Budget float
)

Create table Employee
(
Empid int primary key,
Empname varchar(20),
Salary float,
Gender char(7),
Deptid int foreign key references Department(Deptid)
)

--to check the table structure

sp_help Employee
sp_help Department