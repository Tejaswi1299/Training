
--1.Write a T-SQL Program to find the factorial of a given number.
declare @number int=7;
declare @fact int=1;

while(@number > 1)
begin
    set @fact = @fact * @number;
    set @number = @number - 1;
end

select @fact as 'Factorial is '

--2.Create a stored procedure to generate multiplication tables up to a given number.
 
CREATE TABLE Multiplctable(c1 int ,c2 int ,c3 int,c4 int,c5 int,c6 int,c7 int,c8 int,c9 int ,c10 int)

create or alter Procedure Multiplication_table
@Mul  int
as 
begin
 truncate table Multiplctable   
 INSERT INTO Multiplctable 
  VALUES(@Mul*1,@Mul*2,@Mul*3,@Mul*4,@Mul*5,@Mul*6,
             @Mul*7,@Mul*8,@Mul*9,@Mul*10);

  SELECT M.c1 [1],M.c2 [2],M.c3 [3],M.c4 [4],M.c5 [5],M.c6 [6],M.c7 [7],M.c8 [8],M.c9 [9],M.c10 [10]
  FROM Multiplctable M
  end

  execute Multiplication_table '10'

--method2
Create or alter procedure Mul_Table
 @i int 
 as
 begin
 Declare @j int

SET @j= 1; 
PRINT 'Multipliction table for '    + CONVERT(VARCHAR, @i) ;

While (@j <=10)
begin
 PRINT CONVERT(VARCHAR, @i) + ' x ' +CONVERT(VARCHAR, @j)+' = '+ CONVERT(VARCHAR, @i*@j)
 set @j=@j+1;
End
end
exec Mul_Table '7' 

 /*3.  Create a trigger to restrict data manipulation on EMP table during General holidays. 
 Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manupulate" etc
Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details*/


create table Holiday
(
holiday_date Varchar(15),
holiday_name Varchar(15),
)

select * from Holiday
insert into Holiday values('15-JAN','Sankranthi'),('15-AUG','Independanceday'),('14-NOV','ChildrensDay')

create trigger T_holiday
on Holiday
instead of update
as
begin
 select 'Dates cannot be change in this table'
 end

 update Holiday set holiday_date='25-JAN' where holiday_name = 'Republicday'


