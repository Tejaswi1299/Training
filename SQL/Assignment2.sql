create database Assignment2_sql

Create table Department (
Deptno int primary key,
Dname varchar(20),
Loc varchar(15),
)

Create table Employee
(
Empno int primary key,
Ename varchar(20),
Job varchar(20),
Mgrid int ,
Hiredate Date,
Salary float,
Comm float,
Deptno int foreign key references Department(Deptno)
)

alter table Employee
drop column Gender

select * from Employee
select * from Department

--insert values into department table
insert into Department values(10,'Accounting','New-york'),(20,'Research','Dallas'),(30,'Sales','Chicago'),(40,'Operations','Botson')

alter table Employee
drop Constraint UQ__Employee__B7245FDC9F861961 


insert into Employee values(
7369,'SMITH','CLERK',7902,'17-DEC-80',800,null,20),
(7499,'ALLEN','SALESMAN',7698,'20-FEB-81',1600,300,30),
(7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30),
(7566,'JONES','MANAGER',7839,'02-APR-81',2975,null,20),
(7654,'MARTIN','SALESMAN',7698,'28-SEP-81',1250,1400,30),
(7698,'BLAKE', 'MANAGER',7839,'01-MAY-81',2850,null,30),
(7782,'CLARK','MANAGER',7839,'09-JUN-81',2450,null,10),
(7788,'SCOTT','ANALYST',7566 ,'19-APR-87',3000,null,20),
(7839 ,'KING','PRESIDENT',null,'17-NOV-81',5000,null,10),
(7844,'TURNER','SALESMAN',7698,'08-SEP-81',1500 ,0,  30 ),
(7876,'ADAMS ','CLERK', 7788 ,'23-MAY-87',   1100,null , 20),
(7900,'JAMES ','CLERK', 7698 ,' 03-DEC-81', 950,null,30 ),
(7902,'FORD','ANALYST', 7566 ,' 03-DEC-81',3000,null , 20 ),
(7934,'MILLER','CLERK', 7782 ,'23-JAN-82', 1300 ,null , 10) 

select getdate()

select * from Employee
Select * from Department

--1. List all employees whose name begins with 'A'. 
select * from Employee
Where Ename like 'A%'

--2. Select all those employees who don't have a manager. 
select * from Employee where Mgrid is null

--3. List employee name, number and salary for those employees who earn in the range 1200 to 1400. 
select Ename,Deptno, Salary from Employee where Salary between 1200 and 1400

/*4. Give all the employees in the RESEARCH department a 10% pay rise. 
Verify that this has been done by listing all their details before and after the rise. */

select Ename, Salary,  (Salary*10)/100+Salary as 'Revised Salary'
from Department d,Employee e
where d.Deptno = e.Deptno and  Dname = 'Research'

select * from Employee
Select * from Department

--5. Find the number of CLERKS employed. Give it a descriptive heading. 
Select Job, Count(Job) as 'Clerk Employees'
from Employee
where Job = 'CLERK'
Group by Job

select * from Employee
--6. Find the average salary for each job type and the number of people employed in each job. 
Select Job,avg(Salary) as 'average salary',count(Job) as 'Employee count in Each Job'
from Employee
Group by Job

--7. List the employees with the lowest and highest salary. 
Select (Select Ename from Employee where Salary = (select Min(Salary) from Employee))as 'Min Empname',Min(Salary) as 'Lowest Sal Employee',
(Select Ename from Employee where Salary = (Select Max(Salary)from Employee))  as 'Max Empname' ,Max(Salary) as 'Highest Sal Employee' 
from Employee 

select Ename,Salary from Employee where Salary in( select  Max(Salary) from Employee ) 
union all
select Ename,Salary from Employee where Salary in( select  Min(Salary)  from Employee )

--8. List full details of departments that don't have any employees.
select * from Department where Deptno not in(
Select Distinct Deptno from Employee)

Select *
from Employee e left join Department d
 on d.Deptno = e.Deptno


/*9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. 
Sort the answer by ascending order of name. */

Select Ename,Salary
from Employee
where Job = 'ANALYST' and Salary>1200 and Deptno =20
Order by Ename 


--10. For each department, list its name and number together with the total salary paid to employees in that department. 
select Dname,d.Deptno,Count(d.Deptno) as 'Employees',Sum(Salary) as 'Total salary'
from Department d, Employee e
where d.Deptno = e.Deptno
group by d.Deptno,Dname

select * from Department
Select * from Employee

--11. Find out salary of both MILLER and SMITH.
select Ename,Salary
from Employee
where Ename in('MILLER','SMITH')

--12. Find out the names of the employees whose name begin with ‘A’ or ‘M’. 
Select Ename
from Employee
where Ename like '[AM]%'

--13. Compute yearly salary of SMITH. 
Select Salary, Salary*12 as 'Yearly Salary'
from Employee
Where Ename ='SMITH'

--14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 
Select Ename,Salary 
from Employee
Where Salary  not between 1500 and 2850

