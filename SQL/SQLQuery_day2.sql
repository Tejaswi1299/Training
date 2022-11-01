select * from Employee
select * from Department

--inserting rows/tuples
insert into Department(Deptid,Deptname)values(5,'IT')

--insert multiple records in department table
insert into Department values (1,'Operations',200000),(2,'Support',300000),(3,'Sales',400000)

sp_help Employee

--insert records into Employee table

insert into Employee values(1,'Anushree',15000,'Female',2),(2,'Tejaswi',16000,'Female',3),(3,'Shreedhar',17000,'Male',3),
(4,'Anupa',20000,'Male',4) --departmentId not valid

insert into Employee values(1,'Anushree',15000,'Female',2),(2,'Tejaswi',16000,'Female',3),(3,'Shreedhar',17000,'Male',3),
(4,'Anupa',20000,'Male',2)

--To insert one more record with null value
insert into Employee values(5,'Ramya',20000,'Female',null)

--to add column after table created and values inserted
alter table Employee
add Phone varchar(13) Unique -- can't executed bcaz of null values

--to drop table
drop table Employee

--create table
create table Employee
(Empid int primary key,
Empname varchar(30),
Salary float,
Gender char(7),
DeptId int foreign key references Department(DeptId))

select * from Employee

--to add a column and unique key constraint
alter table Employee
add Phone varchar(13) Unique 


insert into Employee values(1,'Anushree',15000,'Female',2,'123456'),(2,'Tejaswi',16000,'Female',3,null),(3,'Shreedhar',17000,'Male',3,'5678990'),
(4,'Anupa',20000,'Male',2,'123456'),(5,'Ramya',20000,'Female',null,'222222') --duplicates cann't be executed


insert into Employee values(1,'Anushree',15000,'Female',2,'123456'),(2,'Tejaswi',16000,'Female',3,null),(3,'Shreedhar',17000,'Male',3,'5678990'),
(4,'Anupa',20000,'Male',2,'1234256'),(5,'Ramya',20000,'Female',null,'222222') 

--to drop a column from table
alter table Employee
drop column Phone

--drop constraint from table
alter table Employee
drop constraint UQ__Employee__5C7E359EEBBBBD4F --System defined constraint

--to add a constraint
alter table Employee
add Constraint unqphone unique(Phone) --userdefined constraint

 --drop constraint <constraintname>
alter table Employee
drop constraint unqphone     --(user defined constraint name)

--Check constraint
alter table Employee
add constraint chksal Check(Salary>15000) --can't executed as already inserted salary is 15000

alter table Employee
add constraint chksal Check(Salary>=15000)

--Default Constraint
alter table Department
add City varchar(25)

alter table Department
add Constraint Defcity Default 'Banglore' for City

insert into Department(Deptid,DeptName)
values(7,'Development')

alter table Department
drop Constraint Defcity

alter table Department
drop Column City

select * from Department
--inserting a record to check default values
insert into Department(Deptid,DeptName)
values(6,'Accounts')

--to delete records from a table
delete from Department

select * from Employee
--to update values of a row/s in table
update Employee set Phone=100789 
where Empid=2

insert into Employee values(6,'Bramhaji',17000,'Male',1,323298)
 
--before deleting table permanantly will create dummy and drop it

create table dummy(dummyid int, dummyname varchar(10))
insert into dummy values(1,'Dummy1'),(2,'Dummy2')

select * from dummy
drop table dummy
select * from dummy -- error:Invalid object name 'dummy'.table deleted

create table dummy(dummyid int, dummyname varchar(10))
insert into dummy values(1,'Dummy1'),(2,'Dummy2')

delete from dummy
select * from dummy
truncate table dummy

--Disabling check constraint
Alter table Employee  Nocheck Constraint chksal

--Enable check constraint
Alter table Employee  check Constraint chksal

--select options queries
--restriction
select * from Employee where Gender='Male'
--projection

select Empid,Empname from Employee

--projection and restriction
select Empname,salary from Employee where gender='Female'

--select top few records
select top 3 *from Employee

--select top percentage of records
select top 20 percent * from Employee