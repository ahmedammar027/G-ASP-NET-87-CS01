/*Question 1 — Commit a Patient Update
Start a transaction and update the ward of patient Id = 1 to ward 2.
Commit the transaction so that the change is permanently saved.
*/
begin transaction
update Patients
set WardId=2
where Id=275
commit

select * 
from Patients
where id=275
/*

Question 2 — Rollback a Consultant Salary Update
Start a transaction and increase the salary of consultant Id = 1 by 5000.
Then rollback the transaction so that the salary returns to its original value.*/

begin transaction
update consultants
set Salary+=5000
where Id=301
rollback

select * 
from Patients
where id=275


/*
Question 3 — Commit Multiple Related Updates
Start one transaction that:
Moves patient Id = 1 to ward 3.
Updates nurse Number = 1 so that the nurse serves ward 3.
Commit the transaction after both operations are completed successfully.*/

begin transaction

update Patients
set WardId=3
where Id=275

update Nurses
set ServesInWardId=3
where Number=1
commit



/*
Question 4 — Use a Savepoint
Start a transaction that:
Updates patient Id = 1 and assigns the patient to ward 2.
Creates a savepoint named PatientUpdate.
Changes the patient's name to 'Temporary Patient Name'.
Rolls back only to the PatientUpdate savepoint.
Commits the transaction.
The ward change should remain, while the temporary name change should be cancelled.*/

begin transaction
update Patients
set WardId=2
where Id=275
SAVE TRANSACTION PatientUpdate;
update Patients
set Name='Temporary Patient Name'
where Id=275
rollback  TRANSACTION PatientUpdate;
COMMIT TRANSACTION;



/*
Question 5 — Transaction with TRY/CATCH
Create a transaction that increases the salary of consultant Id = 1 by 3000.
Use TRY...CATCH.
If the operation succeeds, commit the transaction.
If an error occurs, rollback the transaction and display:
Error number
Error message
*/


BEGIN TRANSACTION;

BEGIN TRY
    UPDATE Consultants
    SET Salary = Salary + 3000
    WHERE Id = 301;

    COMMIT TRANSACTION;
END TRY

BEGIN CATCH
    IF @@TRANCOUNT > 0
    BEGIN
        ROLLBACK TRANSACTION;
    END

    SELECT 
        ERROR_NUMBER() AS ErrorNumber,
        ERROR_MESSAGE() AS ErrorMessage;
END CATCH;

/*Question 6 — Consultant Patient Statistics
Create vw_ConsultantPatientStatistics displaying Consultant ID,
Consultant Name, Salary, and number of assigned patients.
Use Consultants, PatientConsultantAssignments, COUNT(), and GROUP BY.
*/
go
create view vw_ConsultantPatientStatistics as
select c.Id ,c.Name ,c.Salary ,count(p.PatientId) aS PatientCount
from Consultants c inner join PatientConsultantAssignments p
on c.Id=p.ConsultantId
group by  c.Id ,c.Name ,c.Salary

select *
from vw_ConsultantPatientStatistics

/*Question 7 — Find Consultants with More Than 5 Patients
Using vw_ConsultantPatientStatistics, display consultants
who have more than 5 assigned patients.*/

select *
from vw_ConsultantPatientStatistics
where PatientCount >5





/*
Question 8 — Create an Indexed Aggregate View
Create dbo.vw_IndexedConsultantPatientCount displaying Consultant 
ID and number of assigned patients. Use COUNT_BIG(), GROUP BY,
WITH SCHEMABINDING, and then create the required unique clustered index.
*/
go
create view dbo.vw_IndexedConsultantPatientCount 
WITH SCHEMABINDING as
select c.Id ,COUNT_BIG(p.PatientId) aS PatientCount
from dbo.Consultants c inner join dbo.PatientConsultantAssignments p
on c.Id=p.ConsultantId
group by  c.Id 

CREATE UNIQUE CLUSTERED INDEX IX_vw_IndexedConsultantPatientCount_Id 
ON dbo.vw_IndexedConsultantPatientCount(Id);








/*
Question 9 — Query the Indexed Aggregate View
Display consultants whose number of assigned patients is greater than 5.
*/
select *
from vw_IndexedConsultantPatientCount
where PatientCount>5










/*Question 10 — Display All Views
Display View Name, Creation Date, and Modification Date for all views in the Hospital database.
*/

USE Hospital;
GO

SELECT 
    name AS ViewName,
    create_date AS CreationDate,
    modify_date AS ModificationDate
FROM 
    sys.views
ORDER BY 
    name;







/*Question 11 — Display a View Definition
Display the SQL definition of vw_PatientInformation.
*/
ALTER DATABASE Hospital SET RECOVERY SIMPLE;

create view vw_PatientInformation as
select *
from Patients

exec sp_helptext'vw_PatientInformation'






/*Question 12 — Alter a View
Modify vw_PatientInformation so that it returns only Patient ID, 
Patient Name, and Date of Birth.
*/
alter view vw_PatientInformation as 
select id,name,DOB
from Patients


/*Question 13 — Drop a View
Remove vw_ConsultantSalary.*/

drop view[vw_PatientInformation]

/*
Question 14 — Patient Hospital Report
Create vw_PatientHospitalReport displaying Patient ID,
Patient Name, DOB, Ward Name, and Consultant Name. Use Patients,
Wards, PatientConsultantAssignments, and Consultants. Use LEFT JOIN
so patients remain visible even without a ward or consultant.
*/

create view vw_PatientHospitalReport as
select p.Id,p.Name as 'patient name',p.DOB,w.Name as 'ward name',c.Name as 'consultant name'
from Patients p left join Wards w on p.WardId=w.Id
inner join PatientConsultantAssignments pc on pc.PatientId=p.Id
left join Consultants c on c.Id=pc.ConsultantId



/*Question 15 — Search the Hospital Report
Using vw_PatientHospitalReport, display only patients whose consultant name is not NULL.
*/

select *
from vw_PatientHospitalReport
where [consultant name] <> null







/*Question 16 — Display Patients by Ward
Using vw_PatientHospitalReport, display Patient Name, Ward Name, and Consultant Name for patients belonging to a specific ward.
*/
select *
from vw_PatientHospitalReport
where [ward name]= 'specific'



/*Question 17 — Most Patients per Consultant
Using vw_ConsultantPatientStatistics, display the consultant with
the highest number of assigned patients.
*/
select top(1) *
from vw_ConsultantPatientStatistics
order by PatientCount desc

/*Question 18 — View + Filtering
Using vw_PatientAgeInformation, display patients whose age is greater than 60.
*/

select *
from vw_PatientInformation v
where DATEDIFF(YEAR, DOB, GETDATE()) > 60;

exec sp_helptext'vw_PatientInformation'





/*Question 19 — View + Sorting
Using vw_ConsultantPatientStatistics, display all consultants ordered
from the consultant with the highest number of patients to the lowest.
*/
select  *
from vw_ConsultantPatientStatistics
order by PatientCount desc







/*Question 20 — View + Aggregation
Using vw_PatientWardInformation, display the number of patients in each ward.
*/

select wardid , count(id)
from vw_PatientInformation f
group by wardid



/*
Question 21 — Find Indexed Views
Display all views that have indexes. Show Schema Name, View Name, Index Name, and Index Type.
*/

SELECT 
    s.name AS SchemaName,
    v.name AS ViewName,
    i.name AS IndexName,
    i.type_desc AS IndexType
FROM 
    sys.views v
INNER JOIN 
    sys.schemas s ON v.schema_id = s.schema_id
INNER JOIN 
    sys.indexes i ON v.object_id = i.object_id
WHERE 
    i.index_id > 0;