use Hospital
go

--Question 1 — Display All Patients
--Create a stored procedure that returns all patients.
go
create or alter procedure sp_GetAllpatients
as begin
select p.Id,p.Name,p.DOB,p.WardId
from Patients p
end

exec sp_GetAllpatients
--Question 2 — Display All Consultants
--Create a stored procedure that returns all consultants with their salaries.
go
create or alter procedure sp_GetAllconsultantsalaries
as begin
select c.Id,c.Name,c.Salary
from Consultants c
end

exec sp_GetAllconsultantsalaries



--Question 3 — Display Patients with Their Wards
--Create a stored procedure that displays every patient together with the ward they belong to.

go
create or alter procedure sp_GetPatientswithWards
as begin
select p.Id,p.Name,w.Name
from Patients p inner join Wards w on p.WardId=w.Id
end

exec sp_GetPatientswithWards


--Question 4 — Get Patient by ID
--Create a stored procedure that receives a patient ID and returns that patient.
go
create or alter procedure sp_GetPatientsbyid
@id int
as begin
select p.Id,p.Name,p.DOB
from Patients p where p.Id=@id
end

exec sp_GetPatientsbyid 201

--Question 5 — Get Consultants by Minimum Salary
--Create a stored procedure that receives a minimum salary and returns consultants whose
--salary is greater than or equal to it.

go
create or alter procedure sp_Getconsultantsalary
@minimum int
as begin
select c.Id,c.Name,c.Salary
from Consultants c where c.Salary>=@minimum
end

exec sp_Getconsultantsalary 20000


--Question 6 — Get Patients by Ward
--Create a stored procedure that receives a ward ID and returns all patients assigned to that
--ward.
go
create or alter procedure sp_getpatientbywardid
@wid int as begin 
select *
from Patients p
where p.WardId=@wid
end


exec sp_getpatientbywardid 1

--Question 7 — Return Patient Count
--Create a stored procedure that returns the total number of patients through an OUTPUT
--parameter.
go
create or alter procedure sp_getpatientcount
@countt int output as begin 
select @countt=count(*)
from Patients p
end

go
declare @counttt int
exec sp_getpatientcount @counttt output
select  @counttt as count



--Question 8 — Return Average Consultant Salary
--Create a stored procedure that returns the average consultant salary through an OUTPUT
--parameter.
go
create or alter procedure sp_AvgConsultantSalary
@average decimal(18,2) output
as begin
select @average=AVG(c.Salary)
from Consultants c
end

declare @result decimal(18,2) 
exec sp_AvgConsultantSalary @result output
select @result


--Question 9 — Return Patient Medication Quantity
--Create a stored procedure that receives a patient ID and returns the total medication
--quantity through an OUTPUT parameter.
go
CReate or alter procedure sp_patiente_quantity
@Quantity int output,@more int as begin
select @Quantity=@Quantity+@more end

declare @Quantiity int=15 
exec sp_patiente_quantity @Quantiity output ,5
select @Quantiity as total




--Question 10 — Increase a Salary
--Create a stored procedure that receives a salary as an input-output parameter and
--increases it by a supplied percentage.
go
CReate or alter procedure sp_Increase_Salary
@salary int output,@more int as begin
select @salary=@salary+@more end
go
declare @salary int=2000
exec sp_patiente_quantity @salary output ,500
select @salary as total




--Question 11 — Increase Medication Quantity
--Create a stored procedure that receives a quantity as input-output and adds an additional
--quantity to it.
go
CReate or alter procedure sp_patiente_quantity
@Quantity int output,@more int as begin
select @Quantity=@Quantity+@more end

declare @Quantiity int=15 
exec sp_patiente_quantity @Quantiity output ,5
select @Quantiity as total




--Question 12 — Convert Monthly Salary to Annual Salary
--Create a stored procedure that receives a monthly salary as input-output and replaces it
--with the annual salary.
go
create or alter procedure sp_Annual_Salary
@Monthly int output as begin
select @Monthly=@Monthly*12 end
go
declare @Monthly int =1000
exec sp_Annual_Salary @Monthly  output
select @Monthly as Annual_Salary


--Question 13 — Insert Patient with Error Handling
--Create a stored procedure that inserts a patient and handles errors using TRY-CATCH.
go
create or alter procedure sp_insertpatient
@id int ,@name nvarchar(20), @dob date ,@wid int as begin
begin try
insert into Patients
values(@id,@name,@dob,@wid);
print'successful insert'
end try
begin catch
print ('error ocurred')
select ERROR_NUMBER() as error_number,
	   ERROR_MESSAGE() as error_message,
	   ERROR_LINE()as error_line
end catch
end
go

exec sp_insertpatient  301,'ammar','2005-1-16',3

--Question 14 — Update Consultant with Error Handling
--Create a stored procedure that updates a consultant's salary and handles errors.

go
create or alter procedure sp_updatepatient
@id int ,@name nvarchar(20), @dob date ,@wid int as begin
begin try
update Patients 
set name= @name, DOB=@dob,WardId=@wid
where id=@id
print'successful update'
end try
begin catch
print ('error ocurred while updateing')
select ERROR_NUMBER() as error_number,
	   ERROR_MESSAGE() as error_message,
	   ERROR_LINE()as error_line
end catch
end
go
exec sp_updatepatient  301,'ali','2005-1-16',3

--Question 15 — Delete Patient with Error Handling
--Create a stored procedure that deletes a patient and handles errors using TRY-CATCH.

go
create or alter procedure sp_deletepatient
@id int as begin
begin try
delete Patients 

where id=@id
print'successful delete'
end try
begin catch
print ('error ocurred while deleting')
select ERROR_NUMBER() as error_number,
	   ERROR_MESSAGE() as error_message,
	   ERROR_LINE()as error_line
end catch
end
go
exec sp_deletepatient 301

--Question 16 — Add a New Patient
--Create a stored procedure that inserts a new patient.
go
create or alter procedure sp_insertapatient
@id int ,@name nvarchar(20), @dob date ,@wid int as begin

insert into Patients
values(@id,@name,@dob,@wid);
print'successful insert'

end
go

exec sp_insertapatient  305,'ammar','2005-1-16',3

--Question 17 — Add a New Consultant
--Create a stored procedure that inserts a new consultant.
go
create or alter procedure sp_insertaConsultant
@id int ,@name nvarchar(20), @salary int as begin
insert into Consultants
values(@id,@name,@salary);
print'successful insert'
end
go

exec sp_insertaConsultant  316,'youssef',30000
--Question 18 — Record a Medication Administration
--Create a stored procedure that inserts a new medication administration.

go
create or alter procedure sp_drug_admin
@nid int,@did int,@pid int,@dosage nvarchar(50) as begin
insert into DrugAdministrations
values(@nid,@did,@pid,@dosage,CAST(GETDATE() AS DATE), CAST(GETDATE() AS TIME))
print'successful insert'
end
go

exec sp_drug_admin  101,1001,202,'2tablets'


--Question 19 — Update Patient Information
--Create a stored procedure that updates a patient's name, date of birth, and ward.

go
create or alter procedure sp_updateapatient
@id int ,@name nvarchar(20), @dob date ,@wid int as begin
update Patients 
set name= @name, DOB=@dob,WardId=@wid
where id=@id
print'successful update'

end
go
exec sp_updateapatient  305,'hesi','2005-1-16',3



--Question 20 — Update Consultant Salary
--Create a stored procedure that changes a consultant's salary.
go
create or alter procedure sp_updateaconsultantsalary
@id int ,@newsalary int as begin
update Consultants 
set Salary+=@newsalary
where id=@id
print'successful update'

end
go
exec sp_updateaconsultantsalary  301,1000


--Question 21 — Increase Nurse Salary
--Create a stored procedure that increases a nurse's salary by a percentage.

go
create or alter procedure sp_updateNursesalary
@id int ,@persentage decimal (18,2) as begin
update Nurses 
set Salary=Salary+(Salary*(@persentage/100))
where Number=@id
print'successful update'

end
go
exec sp_updateNursesalary  101,10.0


--Question 22 — Delete a Patient
--Create a stored procedure that deletes a patient by ID.

go
create or alter procedure sp_deleteapatient
@id int as begin
delete Patients 
where id=@id
print'successful delete'
end

exec sp_deleteapatient 500
exec sp_insertpatient 500,'medo','2005-1-1',1

--Question 23 — Delete a Consultant
--Create a stored procedure that deletes a consultant by ID.
go
create or alter procedure sp_deleteConsultant
@id int as begin
delete Consultants 
where id=@id
print'successful delete'
end
go
exec sp_insertaConsultant 13330,'test',1000
exec sp_deleteConsultant 13330

--Question 24 — Delete a Medication Administration
--Create a stored procedure that deletes a medication administration using its identifying
--columns.

go
create or alter procedure sp_deleteConsultant
@id int as begin
delete Consultants 
where id=@id
print'successful delete'
end
go
exec sp_insertaConsultant 13330,'test',1000
exec sp_deleteConsultant 13330


--Question 25 — Store All Patients Returned by a
--Procedure
--Create a table and use INSERT INTO ... EXEC to store the result of GetAllPatients.

create table patients_procedure_result(
id int,name nvarchar(50),dob date , wardid int
)
go
insert into patients_procedure_result
exec sp_GetAllpatients
--Question 26 — Store High-Salary Consultants
--Create a table and use INSERT INTO ... EXEC to store consultants earning at least 50000.
go
create table High_Salary_Consultants(
id int,name nvarchar(50),salary int
)
go

insert into High_Salary_Consultants
exec sp_Getconsultantsalary 5000

--Question 27 — Store Patients from a Specific Ward
--Create a table and use INSERT INTO ... EXEC to store patients returned from
--GetPatientsByWard.
go
create table PatientsfromSpecificWard(
id int,name nvarchar(50),dob date , wardid int
)

go
insert into PatientsfromSpecificWard
exec sp_getpatientbywardid 2

--Question 28 — Create a Patient Audit Table
--Create a table that can store patient insert, update, and delete operations.
--drop table Patientsaudit
create table Patientsaudit(
auditid int identity(1,1),id int,action_type nvarchar(50),action_date date
,description nvarchar(50),name nvarchar(50),dob date , wardid int
)
go

--Question 29 — Create an AFTER INSERT Trigger
--Create an AFTER INSERT trigger that records every newly inserted patient in PatientAudit.
go
create or alter trigger TRG_patient_AFTER_INSERT
on patients 
after insert
as begin
insert into Patientsaudit(id,name,action_type,action_date,description)
select i.Id,i.Name,'insert',GETDATE(),'patient inserted successfully'
from inserted i
end
go

insert into Patients
values (305,'medo','2000-1-1',1)









--Question 30 — Audit Consultant Salary Changes
--Create an audit table and an AFTER UPDATE trigger that stores the old and new
--consultant salary.
--go
--alter table Consultant_Salary_Changes add  difference int
--alter table Consultant_Salary_Changes add  datechange date
--go
--create table Consultant_Salary_Changes(auditid int identity(1,1),id int,
--old_salary int , new_salary int)
go
create or alter trigger TRG_Consultant_Salary_Changes
on Consultants after update as begin
insert into Consultant_Salary_Changes (id,old_salary,new_salary,difference,datechange)
select i.Id,d.Salary ,i.Salary,i.Salary-d.Salary,GETDATE()

from inserted i inner join deleted d on i.Id=i.Id
end


go
update Consultants 
set Salary+=1000
where id=316



--Question 31 — Audit Patient Ward Changes
--Create a trigger that records the old and new ward whenever a patient's ward changes.

go
create or alter trigger TRG_Patient_Ward_Changes
on patients after update as begin
select i.Id as 'patient id',i.Name,i.WardId as 'new w id',d.WardId as 'old w id',GETDATE()

from inserted i inner join deleted d on i.Id=i.Id
end

update Patients
set WardId=2
where id=201




--Question 32 — Archive Deleted Patients
--Create a table for deleted patients and an AFTER DELETE trigger that stores deleted
--patient information.
go
create table Archive_Deleted_Patients(
auditid int identity(1,1),id int,
name nvarchar(20) ,dob date ,wid int
)
select * from Archive_Deleted_Patients
alter table Archive_Deleted_Patients
add date date
go
create or alter trigger TRG_Deleted_Patients on patients
after delete as begin
insert into Archive_Deleted_Patients
select d.Id,d.Name,d.DOB,d.WardId,GETDATE()
from deleted d
end
go
delete from Patients where id =302

--Question 33 — Audit Deleted Consultants
--Create an AFTER DELETE trigger that stores deleted consultant information.
go
create table Archive_Deleted_Consultants(
auditid int identity(1,1),id int,
name nvarchar(20) ,salary decimal (18,2),date date 
)
go
select * from Archive_Deleted_Consultants

go
create or alter trigger TRG_Deleted_Consultants on Consultants
after delete as begin
insert into Archive_Deleted_Consultants
select d.Id,d.Name,d.Salary,GETDATE()
from deleted d
end
go
delete from Consultants where id =316
--Question 34 — Compare Old and New Consultant Salary
--Create an AFTER UPDATE trigger that displays the old and new salary of the consultant.
update Consultants 
set Salary+=5000
where id =315

--Question 35 — Compare Old and New Patient Ward
--Create an AFTER UPDATE trigger that displays the patient's old ward and new ward.

update Patients
set WardId=1
where id=201


--Question 36 — Handle Multiple Inserted Rows
--Create an AFTER INSERT trigger that records every patient inserted by a single statement.
--Then insert three patients in one statement.

insert into Patients 
values (307,'samar','2000-10-1',2),
 (304,'samar','2000-10-1',2),
 (305,'samar','2000-10-1',2),
 (306,'samar','2000-10-1',2)


--Question 37 — Prevent Patients Without a Ward
--Create an INSTEAD OF INSERT trigger that prevents inserting a patient when WardId is
--NULL.
go
create or alter trigger TRG_Patients_Without_Ward on Patients
instead of insert as begin
if exists ( 
select 1
from inserted i
where i.WardId is null
)
begin raiserror ('ward id is null',16,1)
ROLLBACK TRANSACTION;
return; end
insert into Patients
select i.Id,i.Name,i.DOB,i.WardId
from inserted i
end


insert into Patients 
values (317,'hager','2000-10-1',null)



/*Question 38 — Validate Patient Date of Birth
Create an INSTEAD OF INSERT trigger that prevents patients whose date of birth is in the
future.*/
go
create or alter trigger TRG_Patients_Without_Ward on Patients
instead of insert as begin
if exists ( 
select 1
from inserted i
where i.WardId is null 
)
begin raiserror ('ward id is null',16,1)
ROLLBACK TRANSACTION;
return; end

if exists ( 
select 1
from inserted i
where i.DOB>GETDATE()
)
begin raiserror ('incorrect dob',16,1)
ROLLBACK TRANSACTION;
return; end

insert into Patients
select i.Id,i.Name,i.DOB,i.WardId
from inserted i
end


insert into Patients 
values (318,'hager','2100-10-1',1)
/*


Question 39 — Prevent Consultant Salary Reduction
Create an INSTEAD OF UPDATE trigger that prevents reducing a consultant's salary.*/
go
create or alter trigger TRG_Consultant_Salary_Reduction
on consultants INSTEAD OF UPDATE  as begin 
if exists(
select 1
from inserted i inner join deleted d on i.Id=d.Id
where i.Salary<d.Salary
)
begin 
raiserror ('Reduction Salary denied',16,1)
rollback transaction
return;
end
update Consultants
set name=i.Name,salary=i.Salary
from Consultants c inner join inserted i on c.Id=i.id
end


update Consultants
set Salary+=1000
where id=301

/*
Question 40 — Control Patient Updates
Create an INSTEAD OF UPDATE trigger that allows patient information to be updated
without changing the patient ID.*/
go
create or alter trigger TRG_Patient_Updates on patients instead of update as begin 
if exists(
select 1
from inserted i inner join Patients p on i.Id=p.Id
)
begin
update Patients
set id=p.Id,Name=i.Name,DOB=i.DOB,WardId=i.WardId
from inserted i inner join Patients p on i.Id=p.Id
print('successful')
return
end 
raiserror ('access denide',16,1)
end
go
update Patients
set  WardId=1
where id =201



/*

Question 41 — Prevent Patient Deletion
Create an INSTEAD OF DELETE trigger that prevents patients from being deleted directly.*/

--go
--create or alter trigger TRG_Prevent_Patient_Deletion on patients instead of delete as begin 

--raiserror ('cannot delete direct',16,1)
--end
--go
delete Patients
where id =201
go
DISABLE TRIGGER TRG_Prevent_Patient_Deletion ON Patients;

/*
Question 42 — Archive Before Delete
Create an INSTEAD OF DELETE trigger that first stores the deleted patient in
DeletedPatients, then deletes the patient from Patients.*/
go
create or alter trigger TRG_Prevent_Patient_Deletion on patients INSTEAD OF DELETE 
as begin
insert into Archive_Deleted_Patients (id,name,dob,wid,date)
select d.Id,d.Name ,d.DOB,d.WardId,cast(GETDATE()as date)
from deleted d
delete Patients
from Patients p inner join deleted d on d.Id=p.Id
end


delete Patients
where id =317


/*

Question 43 — Add Patient with Audit Trigger
Create a stored procedure that adds a patient and an AFTER INSERT trigger that records
the new patient in PatientAudit. Then execute the procedure.*/
go
create or alter procedure sp_insertpatient
@id int ,@name nvarchar(20), @dob date ,@wid int as begin
begin try
insert into Patients
values(@id,@name,@dob,@wid);
print'successful insert'
end try
begin catch
print ('error ocurred')
select ERROR_NUMBER() as error_number,
	   ERROR_MESSAGE() as error_message,
	   ERROR_LINE()as error_line
end catch
end
go

exec sp_insertpatient  317,'ammar','2005-1-16',3



