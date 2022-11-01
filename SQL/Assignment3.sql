--1. Retrieve a list of MANAGERS. 
Select *
from Employee 
where Job= 'MANAGER'

--2. Find out the names and salaries of all employees earning more than 1000 per month. 
select Ename,Salary
from Employee
where Salary >1000

--3. Display the names and salaries of all employees except JAMES.

Select Ename,Salary
from Employee
where Ename !='JAMES'

--4. Find out the details of employees whose names begin with ‘S’. 
Select * from Employee
where Ename like 'S%'

--5. Find out the names of all employees that have ‘A’ anywhere in their name. 
Select Ename from Employee
where Ename Like '%A%'

--6. Find out the names of all employees that have ‘L’ as their third character in their name. 
select Ename from Employee
where Ename like '__L%'

--7. Compute daily salary of JONES.
Select Ename,Salary,(Salary+Isnull(Comm,0))/30 as 'Daily salary' 
from Employee
where Ename = 'JONES'

--8. Calculate the total monthly salary of all employees.
select Sum(Salary) as 'Total salary'
From Employee

--9. Print the average annual salary .
select Avg((Salary*12)+Comm) as 'Average Annual Salary'
from Employee

--10. Select the name, job, salary, department number of all employees except SALESMAN from department number 30. 
select Ename,Job,Salary,Deptno
from Employee
Where Job != 'SALESMAN' and Deptno =30

--11. List unique departments of the EMP table.
--select Deptno
Select Distinct d.Dname,e.Deptno from Department d join Employee e
on d.Deptno=e.Deptno

/*12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. 
Label the columns Employee and Monthly Salary respectively.*/

Select Ename as [Employee name],Salary as [Monthly Salary]
From Employee
where Salary >1500 and Deptno in (10,30)

/*13. Display the name, job, and salary of all the employees whose job is MANAGER or 
ANALYST and their salary is not equal to 1000, 3000, or 5000. */
select Ename,Job,Salary
From Employee
where Job IN ('MANAGER','ANALYST') and Salary not in(1000,3000,5000)

--14. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%.
Select Ename,Salary,Comm
from Employee
where Comm > Salary+((Salary*10)/100)

--15. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782.

select Ename ,Deptno,Mgrid
From Employee
where Ename Like '%L%L%' AND (Deptno =30 or Mgrid = 7782);

--16. Display the names of employees with experience of over 10 years and under 20 yrs.Count the total number of employees. 
select Ename
from Employee 
where (Hiredate-GETDATE()) between 10 and 20

SELECT
ename,hiredate ,count(*) total,
DATEDIFF(YEAR, HireDate, GETDATE()) AS EXPERIENCE
FROM Employee
WHERE DATEDIFF(YEAR, HireDate, GETDATE()) between 10 and 20
group by ename,hiredate

--17. Retrieve the names of departments in ascending order and their employees in descending order. 
select Dname,Ename
from Employee e, Department d
where d.Deptno=e.Deptno
Order by Dname,Ename Desc

--18. Find out experience of MILLER. 

select DATEDIFF(YEAR, Hiredate,GETDATE())
from Employee
Where Ename= 'MILLER'

Select * from Employee
