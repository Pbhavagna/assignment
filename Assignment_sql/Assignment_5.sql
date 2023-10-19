use Assignment2
create proc  GeneratePayslip
    @EmployeeID int
AS
begin
    declare @BasicSalary int
    declare @HRA int
    declare @DA int
    declare @PF int
    declare @IT int
    declare @Deductions int
    declare @GrossSalary int
    declare @NetSalary int

    -- Get the employee's basic salary
   select @BasicSalary = sal FROM Emp WHERE empno = @EmployeeID;

    -- Calculate HRA, DA, PF, and IT
    set @HRA = 0.10 * @BasicSalary;
    set @DA = 0.20 * @BasicSalary;
    set @PF = 0.08 * @BasicSalary;
    set @IT = 0.05 * @BasicSalary;

    -- Calculate Deductions
    set @Deductions = @PF + @IT;

    -- Calculate Gross Salary
    set @GrossSalary = @BasicSalary + @HRA + @DA;

    -- Calculate Net Salary
    set @NetSalary = @GrossSalary - @Deductions;

    -- Display the payslip
    print 'Employee ID: ' + CAST(@EmployeeID as varchar);
    print 'Basic Salary: ' + CAST(@BasicSalary as varchar);
    print 'HRA: ' + CAST(@HRA as varchar);
    print 'DA: ' + CAST(@DA as varchar);
    print 'PF: ' + CAST(@PF as varchar);
    print 'IT: ' + CAST(@IT as varchar);
    print 'Deductions: ' + CAST(@Deductions as varchar);
    print 'Gross Salary: ' + CAST(@GrossSalary as varchar);
    print 'Net Salary: ' + CAST(@NetSalary as varchar);
End;
select * from emp
execute  GeneratePayslip 8909