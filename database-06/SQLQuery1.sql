use Hospital
go
--Question 1 — Count Patients per Ward
--Display the number of patients assigned to each ward.
select count(p.Id),
w.Name
from Patients p inner join Wards w on p.WardId=w.Id
group by w.Name

--Question 2 — Calculate the Average Consultant Salary
--Display the average salary of all consultants.
select avg(c.Salary)
from Consultants c

--Question 3 — Display Salary Statistics for Consultants
--Display the minimum, maximum, average, and total consultant salaries.
select min(c.Salary),
MAX(c.Salary),
AVG(c.Salary),
SUM(c.Salary)
from Consultants c

--Question 4 — Count Patients by Ward
--Display the ward ID and number of patients in each ward, sorted from highest to lowest.
select count(p.Id),
w.id
from Patients p inner join Wards w on p.WardId=w.Id
group by w.id
order by w.Id desc
--Question 5 — Medication Quantity per Patient
--Display the total medication quantity administered to each patient.
select count(d.DrugCode),
d.PatientId,
p.Name
from Patients p inner join DrugAdministrations d on p.Id=d.PatientId
group by d.PatientId,
p.Name
order by d.PatientId
--Question 6 — Medication Administrations per Patient
--Display each patient ID together with the number of medication administrations they received.
select count(d.DrugCode),
d.PatientId,
p.Name
from Patients p inner join DrugAdministrations d on p.Id=d.PatientId
group by d.PatientId,
p.Name
order by d.PatientId



--Question 7 — Patients per Ward with Ward Names
--Display every ward together with the number of patients assigned to it,
--including wards with no patients.
select count(p.Id),
w.Id,
w.Name
from Patients p right join Wards w on p.WardId=w.Id
group by w.Id,w.Name


--Question 8 — Average Nurse Salary per Ward
--Display each ward together with the average salary of nurses serving in that ward.
select AVG(n.Salary),
n.ServesInWardId
from Nurses n
group by n.ServesInWardId

--Question 9 — Wards with More Than 3 Patients
--Display wards that have more than 3 patients.
select count(p.Id),
w.Id,
w.Name
from Patients p right join Wards w on p.WardId=w.Id
group by w.Id,w.Name
having count(p.Id)>3

--Question 10 — Patients with More Than 5 Medication Administrations
--Display patients who received medication more than 5 times.

select count(d.DrugCode),
d.PatientId,
p.Name
from Patients p inner join DrugAdministrations d on p.Id=d.PatientId
group by d.PatientId,
p.Name
having count(d.DrugCode)>3
order by d.PatientId



--Question 11 — Consultants Above Average Salary
--Display consultants whose salary is greater than the average consultant salary.
select c.Name,c.Salary
from Consultants c
group by c.Name,c.Salary
having c.Salary>(select AVG(s.Salary)
from Consultants s )

--Question 12 — Nurses Above Average Salary
--Display nurses whose salary is greater than the average nurse salary.

select c.Name,c.Salary
from Nurses c
group by c.Name,c.Salary
having c.Salary>(select AVG(s.Salary)
from Nurses s )

--Question 13 — Patients in the Largest Ward
--Display patients who belong to the ward containing the largest number of patients.

SELECT p.Id, p.Name
FROM Patients p
WHERE p.WardId = (
    SELECT TOP (1) p2.WardId
    FROM Patients p2
    WHERE p2.WardId IS NOT NULL
    GROUP BY p2.WardId
    ORDER BY COUNT(p2.Id) DESC
);


--uestion 14 — Consultants with the Maximum Salary
--Display the consultant or consultants who have the highest salary.
SELECT *
FROM (
    SELECT *, DENSE_RANK() OVER (ORDER BY Salary DESC) AS dn
    FROM Consultants
) c
WHERE dn = 3;

--Question 15 — Patients Who Received Medication
--Display patients who have at least one medication administration.
select
d.PatientId,
p.Name
from Patients p inner join DrugAdministrations d on p.Id=d.PatientId
group by d.PatientId,
p.Name
having count(d.DrugCode) >0
order by d.PatientId

--Question 16 — Patients Who Never Received Medication
--Display patients who have never received any medication.
select
d.PatientId,
p.Name
from Patients p inner join DrugAdministrations d on p.Id=d.PatientId
group by d.PatientId,
p.Name
having count(d.DrugCode) =0
order by d.PatientId
--Question 17 — Count Medication Administrations per Patient
--Display every patient together with the number of medication administrations they received.
select count(d.DrugCode),
d.PatientId,
p.Name
from Patients p inner join DrugAdministrations d on p.Id=d.PatientId
group by d.PatientId,
p.Name
order by d.PatientId



--Question 18 — Total Medication Quantity per Patient
--Display every patient together with the total medication quantity administered to them.
select count(d.DrugCode) as 'countdrug',
d.PatientId,
p.Name
into test
from Patients p inner join DrugAdministrations d on p.Id=d.PatientId
group by d.PatientId,
p.Name
order by d.PatientId




--Question 19 — Derived Table for Consultant Salaries
--Create a derived table containing the average consultant salary, 
--then display consultants whose salary is above that average.
select c.*
into test
from Consultants c
where c.Salary>(
select AVG(c.Salary)
from Consultants c
)

drop table test

--Question 20 — Patients with Above-Average Medication Quantity
--Display patients whose total medication quantity is greater than
--the average total medication quantity across patients who received medication.
select COUNT(d.DrugCode) ,d.PatientId,d.DrugCode
from DrugAdministrations d
group by d.PatientId,d.DrugCode
having COUNT(d.DrugCode)>(
select AVG(t.countdrug)
from test t
)
--Question 21 — Create a Patient Backup
--Create a new table containing all patients.
select *
into  Patient_Backup
from Patients
--Question 22 — Create a Basic Patient Information Table
--Create a new table containing only patient ID, name, and date of birth.
select p.Id,p.Name,p.DOB
into  Patient_Information_Table
from Patients p
--Question 23 — Create a Consultant Salary Report
--Create a new table containing consultant ID, name, and salary.
select c.Id,c.Name,c.Salary
into  Consultant_Salary_Report
from Consultants c
--Question 24 — Create a Patient-Ward Report
--Create a new table containing each patient
--together with the ward they belong to.
select p.*,w.Name  as'WardName'
into  Patient_Ward_Report
from Patients p inner join Wards w on p.WardId=w.Id

--Question 25 — Create a Patient-Consultant Report
--Create a new table containing patients and their assigned consultants.

--Question 26 — Create a High-Salary Consultant Table
--Create a new table containing consultants whose salary is greater than 20000.
select c.Name ,c.Salary
into High_Salary_Consultant_Table
from Consultants c
where c.Salary>5000

--Question 27 — Create a Young Patients Table
--Create a new table containing patients born after January 1, 2000.
select *
into Young_Patients_Table
from Patients p
where p.DOB > 'January 1, 2000'
--Question 28 — Create a High-Salary Nurse Report
--Create a new table containing nurses earning more
--than 6000 together with the ward they serve in.
select n.*
into  High_Salary_Nurse_Report
from Nurses n
where n.Salary>6000

--Question 29 — Create a Ward Patient Summary
--Create a new table containing each ward and its patient count.

select COUNT(p.Id) as 'count patient',w.Id,w.Name
into Ward_Patient_Summary
from Patients p inner join Wards w on p.WardId=w.Id 
group by w.Id,w.Name
--Question 30 — Create a Patient Medication Summary
--Create a new table containing each patient and their total medication quantity.
select *
from test



--Question 31 — Calculate Patient Age
--Create a scalar function that receives a date of birth and returns the patient's age.
create Function Patient_Age(@id int)
returns int
as
begin
declare @age int;
SELECT @age = DATEDIFF(YEAR, p.DOB, GETDATE()) - 
        CASE 
            WHEN DATEADD(YEAR, DATEDIFF(YEAR, p.DOB, GETDATE()), p.DOB) > GETDATE() 
            THEN 1 
            ELSE 0 
        END
from Patients p
where p.Id=@id;
return @age;
end;

select dbo.Patient_Age(217)





--Question 32 — Calculate Annual Salary
--Create a scalar function that receives a monthly salary and returns the annual salary.
create function dbo.Annual_Salary(@salary int)
returns int as
begin
declare @annual int
select  @annual = @salary*12;
return @annual;
end

select dbo.Annual_Salary(10000)
--Question 33 — Calculate Medication Cost
--Create a scalar function that receives quantity and unit price and 
--returns the total medication cost.
go
create function dbo.Medication_Cost(@quantity int,@unite int)
returns int as
begin
declare @total int
select  @total =@quantity*@unite;
return @total;
end
go
select dbo.Medication_Cost(5,10)

--Question 34 — Get Patients by Ward
--Create an inline table-valued function that
--receives a ward ID and returns all patients in that ward.
create function dbo.Patients_by_Ward(@wid int)
returns table as 
return (select p.*
from Patients p inner join Wards w on p.WardId=@wid)

select *
from dbo.Patients_by_Ward(1)

--Question 35 — Get Consultants by Minimum Salary
--Create an inline table-valued function that receives
--a minimum salary and returns consultants whose salary is greater than or equal to it.
create function dbo.Consultants_Minimum_Salary(@mininum int)
returns table as 
return (select c.*
from Consultants c
where c.Salary>@mininum)

select *
from dbo.Consultants_Minimum_Salary(20000)

--Question 36 — Get Patients with Their Ward
--Create an inline table-valued function that
--receives a ward ID and returns patients together with their ward name.

create function dbo.Patients_by_their_Ward(@wid int)
returns table as 
return (select p.*,w.Name as 'wardname'
from Patients p inner join Wards w on p.WardId=w.Id
where p.WardId=@wid
)

select *
from dbo.Patients_by_their_Ward(1)



--Question 37 — Get Patients Above a Specific Age
--Create a multi-statement table-valued function that receives
--a minimum age and returns patients who are at least that age.

create function dbo.Specific_Age(@minage int)
returns @t table (id int , name varchar(50) , age int) as 
begin
declare @age int
insert into @t
select p.Id,p.Name , 
DATEDIFF(YEAR, p.DOB, GETDATE()) - 
        CASE 
            WHEN DATEADD(YEAR, DATEDIFF(YEAR, p.DOB, GETDATE()), p.DOB) > GETDATE() 
            THEN 1 
            ELSE 0 
        END as age

from Patients p
where (DATEDIFF(YEAR, p.DOB, GETDATE()) - 
        CASE 
            WHEN DATEADD(YEAR, DATEDIFF(YEAR, p.DOB, GETDATE()), p.DOB) > GETDATE() 
            THEN 1 
            ELSE 0 
        END )>=@minage;
        RETURN;
END;
GO
select * from dbo.Specific_Age(80)
