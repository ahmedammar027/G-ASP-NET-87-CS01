--create database Hotel
--go
--use Hotel
--go



--create table Guest(
--id int identity primary key,
--name varchar(20),
--nationality varchar(20),
--birth_date date,
--passportnumber int unique
--)

--create table Guest_contact_details(
--Guest_id int,
--details varchar(50)
--primary key (Guest_id,details)
--CONSTRAINT FK_Guest_id FOREIGN KEY (Guest_id) REFERENCES Guest(Id)
--)

--create table Payment(
--id int identity primary key,
--method varchar(50),
--date date ,
--Amount int,
--conformation_number int,
--)

--create table Reservations(
--id int identity primary key,
--booking_date date ,
--checkin_date date ,
--checkout_date date ,
--state varchar(50),
--total_price int,
--number_of_adults int,
--number_of_children int,
--)

--create table Reservations_Payment(
--Payment_id int,
--Reservations_id int,
--primary key(Payment_id ,Reservations_id),
--CONSTRAINT FK_Payment_id FOREIGN KEY (Payment_id) REFERENCES Payment(Id),
--CONSTRAINT FK_Reservations_id FOREIGN KEY (Reservations_id) REFERENCES Reservations(Id),
--)

--create table Reservations_Guest(
--Guest_id int,
--Reservations_id int,
--primary key(Guest_id ,Reservations_id),
--CONSTRAINT FK_Guestid FOREIGN KEY (Guest_id) REFERENCES Guest(Id),
--CONSTRAINT FK_Reservation_id FOREIGN KEY (Reservations_id) REFERENCES Reservations(Id),
--)

--create table services(
--id int identity primary key,
--service_name varchar(50),
--charge int,
--request_date date ,
--)

--create table Reservations_services(
--services_id int,
--Reservations_id int,
--primary key(services_id ,Reservations_id),
--CONSTRAINT FK_services_id FOREIGN KEY (services_id) REFERENCES services(Id),
--CONSTRAINT FK_Reservationid FOREIGN KEY (Reservations_id) REFERENCES Reservations(Id),
--)

--create table Staff(
--id int identity primary key,
--full_name varchar(50),
--position varchar(50),
--salary int,
--request_date date ,
--)

--alter table services
--add Staff_id int references Staff(id)

--create table Hotels(
--id int identity primary key,
--name varchar(50),
--Address varchar(50),
--city varchar(50),
--starrating int,
--contact_num int,
--managed_id int unique,
--CONSTRAINT fk_managed_id FOREIGN KEY (managed_id ) REFERENCES Staff(id)
--)

--alter table Staff
--add Hotelid int references Hotels(id)

--create table Rooms(
--R_number int identity primary key,
--R_type varchar(50),
--capacity int,
--daily_rate int,
--availability varchar(50) ,
--Hotelid int references Hotels(id)
--)

--create table Amenities(
--R_number int references Rooms(R_number),
--Amenity int ,
--primary key(R_number,Amenity),
--)

--create table Reservations_Rooms(
--R_number int references Rooms(R_number),
--Reservations_id int REFERENCES Reservations(Id),
--primary key(R_number ,Reservations_id),
--)

insert into guest(name,nationality,birth_date,passportnumber)
values('ahmed','egyption','1-1-2000',1001)

insert into guest(name,nationality,birth_date,passportnumber)
values('omar','soudi','1-1-2001',1002),
('saied','french','1-1-2003',1003),
('mostafa','germen','1-1-2005',1004),
('reda','sodani','1-1-2010',1005)

update Rooms 
set daily_rate*=.15

update Reservations
SET state = CASE
    WHEN checkout_date <GETDATE() THEN 'Completed'
    WHEN checkout_date >GETDATE() THEN 'Upcoming'
    ELSE 'Active'
END
