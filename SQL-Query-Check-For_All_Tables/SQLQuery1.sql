use RailwayDb;

--SQL Scripts to Crate Db and Tables

--1. Creating Table of Users For Signup and Login Page :-

create table Users
(
Id int primary key identity,
Name nvarchar(100),
Email nvarchar(150) unique,
Password nvarchar(100)
);

--Query to Check whether the Table is created or Not :-

select * from Users;


--2. Creating Table for Booking RailwayTicketSystem :-

create table Bookings 
(
Id int primary key identity,
UserId int foreign key references Users(Id),
FromLocation nvarchar(100),
ToLocation nvarchar(100),
JourneyDate date,
seats int
);


--Query to check whether the Table is created or Not :-

select * from Bookings;