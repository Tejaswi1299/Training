alter procedure Payslip (@name varchar(30) )
  as
  declare @DA float,@sal float,@HRA float,@PF float,@IT float,@Deductions float,@Gross_Salary float, @Net_salary float
  
  begin
   select @sal=Salary from Employee where Empname= @name
  
   set @DA= (@sal*20)/100
   set @HRA = (@sal*10)/100
   set @PF = (@sal*8)/100
   set @IT = (@sal*5)/100
   set @Deductions = @PF + @IT
   set @Gross_Salary = @sal+@HRA+@DA
   set @Net_salary = @Gross_Salary-@Deductions
   select @DA as DA ,@HRA as HRA,@PF as PF,@IT as IT,@Deductions as Deductions,@Gross_Salary as Gross_salary , @Net_salary as net_salary

 end
 
execute Payslip 'Tejaswi'