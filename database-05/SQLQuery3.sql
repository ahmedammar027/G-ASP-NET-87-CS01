use hospital
go
--Q1
select p.Name,w.Name
from Patients p inner join Wards w on
p.WardId=w.Id

--Q2 
select  p.Name,da.DrugCode 
from DrugAdministrations da inner join Patients p on da.PatientId=p.Id

--Q3
select p.Name,c.Name
from Patients p inner join PatientExaminations pe on
p.Id=pe.PatientId inner join Consultants c on c.Id=pe.ConsultantId

--Q4
select p.Name,w.Name
from Patients p left join Wards w on
p.WardId=w.Id

--Q5
select p.Name,w.Name
from Patients p right join Wards w on
p.WardId=w.Id

--Q6
select p.Name,c.Name
from Patients p inner join PatientExaminations pe on
p.Id=pe.PatientId right join Consultants c on c.Id=pe.ConsultantId

--Q7
select p.Name,w.Name
from Patients p right join Wards w on
p.WardId=w.Id

--Q8
select p.Name,c.Name
from Patients p inner join PatientConsultantAssignments pe on
p.Id=pe.PatientId right join Consultants c on c.Id=pe.ConsultantId


--Q9
select p.Name,w.Name
from Patients p full outer join Wards w on p.WardId=w.Id

--Q10
select p.Name,c.Name
from Patients p full outer join PatientConsultantAssignments pe on
p.Id=pe.PatientId full outer join Consultants c on c.Id=pe.ConsultantId

--Q11
select n.Name as 'nurse' , m.Name as 'manager'
from Nurses n inner join Nurses m
on n.ManagerId=m.Number

--Q12
select n.Name as 'nurse' , m.Name as 'manager'
from Nurses n inner join Nurses m
on n.ManagerId=m.Number

--Question 13
select m.Name as 'manager',n.Name as 'nurse'  
from Nurses n inner join Nurses m
on n.ManagerId=m.Number
order by m.Name 

--Q14
select p.Name,c.Name
from Patients p inner join PatientExaminations pe on
p.Id=pe.PatientId right join Consultants c on c.Id=pe.ConsultantId 

--Q15
select co.Name,c.Name
from Patients p inner join PatientConsultantAssignments pc on
p.Id=pc.PatientId inner join Wards c on c.Id=p.WardId inner join Consultants co on
co.Id=pc.ConsultantId

--Q16
select p.Name,co.Name,c.Name
from Patients p inner join PatientExaminations pc on
p.Id=pc.PatientId inner join Wards c on c.Id=p.WardId inner join Consultants co on
co.Id=pc.ConsultantId

--Q17
select p.Name, n.Name, dr.Dosage,dr.Code
from Nurses n inner join DrugAdministrations d on n.Number=d.NurseId
inner join Patients p on p.Id= d.PatientId
inner join Drugs dr on dr.Code=d.DrugCode

--Q18
select p.Name, n.Name, dr.Dosage,dr.Code,w.Name
from  Nurses n inner join DrugAdministrations d on n.Number=d.NurseId
inner join Patients p on p.Id= d.PatientId
inner join Drugs dr on dr.Code=d.DrugCode
inner join Wards w on w.Id=p.WardId

--Q19
select p.Name,co.Name,c.Name
from Patients p inner join PatientExaminations pc on
p.Id=pc.PatientId inner join Wards c on c.Id=p.WardId inner join Consultants co on
co.Id=pc.ConsultantId

--Q20
select p.Name, n.Name,dr.Code, dr.Dosage, d.DATE, d.Time
from Nurses n inner join DrugAdministrations d on n.Number=d.NurseId
inner join Patients p on p.Id= d.PatientId
inner join Drugs dr on dr.Code=d.DrugCode

--Q21
SELECT 
    ROW_NUMBER() OVER (ORDER BY Salary DESC) AS RowNum,
    Name,
    Salary
FROM Consultants;

--Q22
SELECT 
    ROW_NUMBER() OVER (ORDER BY Salary asc) AS RowNum,
    Name,
    Salary
FROM Consultants;

--Q23
SELECT 
    ROW_NUMBER() OVER (ORDER BY Salary DESC , name asc) AS RowNum,
    Name,
    Salary
FROM Consultants;

--Q24
SELECT 
    dense_rank() OVER (ORDER BY Salary desc) AS dnum,
    Name,
    Salary
FROM Consultants;

--Q25
SELECT 
    dense_rank() OVER (ORDER BY Salary asc) AS dnum,
    Name,
    Salary
FROM Consultants;

--Q26
SELECT 
    dense_rank() OVER (ORDER BY Salary desc) AS dnum,
    Name,
    Salary
FROM Consultants;

--Q27
SELECT 
    dense_rank() OVER (ORDER BY Salary desc) AS dnum,
    Name,
    Salary
FROM Consultants;

--Q28
SELECT 
    dense_rank() OVER (ORDER BY Salary desc) AS dnum,
    Name,
    Salary
FROM Consultants;

--Q29
SELECT 
    dense_rank() OVER (ORDER BY Salary desc) AS dnum,
    rank() OVER (ORDER BY Salary desc) AS rnum,
    Name,
    Salary
FROM Consultants;

--Q30
SELECT 
    ntile(2) OVER (ORDER BY Salary desc) AS dnum,
    Name,
    Salary
FROM Consultants;

--Q31
SELECT 
    ntile(3) OVER (ORDER BY Salary desc) AS dnum,
    Name,
    Salary
FROM Consultants;

--Q32
SELECT 
    ntile(4) OVER (ORDER BY Salary desc) AS dnum,
    Name,
    Salary
FROM Consultants;

--Q33
SELECT 
    rank() OVER (partition by n.ServesInWardId
    ORDER BY n.Salary desc
    ) AS dnum,
    n.Name,
    n.Salary,
    w.Name
FROM Nurses n inner join Wards w on n.ServesInWardId=w.Id;

--Q34
SELECT 
    row_number() OVER (partition by n.ServesInWardId
    ORDER BY n.Salary desc
    ) AS dnum,
    n.Name,
    n.Salary,
    w.Name
FROM Nurses n inner join Wards w on n.ServesInWardId=w.Id;

--Q35
SELECT 
    dense_rank() OVER (
    ORDER BY n.Salary desc
    ) AS dnum,
    n.Name,
    n.Salary,
    w.Name
FROM Nurses n inner join Wards w on n.ServesInWardId=w.Id;

--Q36

SELECT 
    ntile(2) OVER (
    ORDER BY n.Salary desc
    ) AS dnum,
    n.Name,
    n.Salary,
    w.Name
FROM Nurses n inner join Wards w on n.ServesInWardId=w.Id;

--Q37
SELECT 
    rank() OVER (
    ORDER BY w.name 
    ) AS dnum,
    n.Name,
    n.Salary,
    w.Name
FROM Nurses n inner join Wards w on n.ServesInWardId=w.Id;

--Q38
SELECT 
    rank() OVER (
    ORDER BY c.Salary 
    ) AS dnum,
    p.Name,
    w.Name,
    c.Salary,
    w.Name
FROM Patients p inner join Wards w on p.WardId=w.Id
inner join PatientConsultantAssignments pc on pc.PatientId=p.Id
inner join Consultants c on c.Id=pc.ConsultantId ;

--Q39
select p.Name,
n.Name,
d.Dosage,
n.Salary,
RANK() over(order by n.Salary)
from Patients p inner join DrugAdministrations d on p.Id=d.PatientId
inner join Nurses n on n.Number=d.NurseId 
order by n.SupervisedWardId 