--use Hospital
--Question 1 — Create a Clustered Index
--Create PatientIndexDemo with PatientId, PatientName, DOB, and WardId. Copy data from
--Patients, then create a clustered index on PatientId.

select *
into PatientIndexDemo
from Patients

create index IX__patient_PatientId
on PatientIndexDemo(id)

/*Question 2 — Create Another Clustered Index
Create ConsultantIndexDemo containing ConsultantId, ConsultantName, and Salary. Copy
data from Consultants, then create a clustered index on ConsultantId.*/

select *
into ConsultantIndexDemo
from Consultants

create index IX__ConsultantId
on ConsultantIndexDemo(id)


/*Question 3 — Index Patients by Ward
Create a nonclustered index on Patients.WardId to improve searches that retrieve patients
based on their ward.*/

create nonclustered index IX__Patients_WardId
on Patients(WardId)

select p.Id,p.WardId
from Patients p
where WardId=2

/*Question 4 — Index Consultants by Salary
Create a nonclustered index on Consultants.Salary.*/

create nonclustered index IX__Consultants_Salary
on Consultants(salary)

select c.Salary ,c.Id
from Consultants c
where Salary = 20083

/*Question 5 — Create a Composite Nonclustered Index
Create a nonclustered index on DrugAdministrations using PatientId and DrugCode.*/

create nonclustered index IX__DrugAdministrations_PatientId_DrugCode
on DrugAdministrations(PatientId,DrugCode)

select DrugCode,patientid
from DrugAdministrations
where DrugCode=1001 and patientid=202

/*Question 6 — Create a Nonclustered Index with Included
Columns
Create a nonclustered index on Patients.WardId and include Name and DOB.*/
go

create nonclustered index IX__Patients_WardId
on Patients(WardId)
include (name,dob)

select p.Id,p.WardId,name ,DOB
from Patients p
where WardId=2

/*Question 7 — Unique Consultant Names
Create a unique index on Consultants.Name to prevent duplicate consultant names.*/

create nonclustered index IX__Consultants_name
on Consultants(name)

select c.name ,Salary
from Consultants c
where Salary = 20083 and name='Dr. Peter Kowalczyk'


/*Question 8 — Composite Unique Index
Create PatientDrugAssignmentDemo with PatientId, DrugCode, and StartDate. Create a
unique composite index on PatientId and DrugCode.*/


select d.PatientId,d.DrugCode ,d.DATE
into PatientDrugAssignmentDemo
from DrugAdministrations d


WITH CTE AS (
    SELECT PatientId, DrugCode,
           ROW_NUMBER() OVER (PARTITION BY PatientId, DrugCode ORDER BY (SELECT NULL)) as RowNum
    FROM PatientDrugAssignmentDemo
)
DELETE FROM CTE WHERE RowNum > 1;



create unique  index IX__PatientDrugAssignmentDemo
on PatientDrugAssignmentDemo(PatientId,DrugCode)


/*Question 9 — Test the Unique Index
Insert one valid row into PatientDrugAssignmentDemo, then attempt to insert the same
PatientId and DrugCode again with a different date.*/
insert into PatientDrugAssignmentDemo 
values(201,1028,GETDATE())

insert into PatientDrugAssignmentDemo 
values(201,1028,'10-10-2001')/*xxxx*/


/*
Question 10 — Display Indexes
Display the indexes defined on the Patients table.*/

EXEC sp_helpindex 'Patients';

/*
Question 11 — Find Indexes from System Catalogs
Display table name, index name, and index type for all indexes in the Hospital database.*/
USE Hospital;
GO

SELECT 
    t.name AS TableName,
    i.name AS IndexName,
    i.type_desc AS IndexType
FROM 
    sys.indexes i
INNER JOIN 
    sys.tables t ON i.object_id = t.object_id
WHERE 
    i.name IS NOT NULL
ORDER BY 
    t.name, i.name;


/*
Question 12 — Drop a Nonclustered Index
Remove the index created in Question 4.*/

DROP INDEX IX__Consultants_Salary ON Consultants; 
/*
Question 13 — Create an Index for Patient Searches
Create a nonclustered index that can help queries searching patients by WardId and DOB.*/
create nonclustered index IX__Patients_WardId__dob
on Patients(WardId,dob)

select p.Id,p.WardId
from Patients p
where WardId=2


/*
Question 14 — Create a Reporting Index
Create a nonclustered index on DrugAdministrations using PatientId and DATE, including
DrugCode, Dosage, and Quantity.*/

create nonclustered index IX__DrugAdministrations_using_PatientId_DATE
on DrugAdministrations(PatientId,DATE)
include(DrugCode, Dosage, Quantity)