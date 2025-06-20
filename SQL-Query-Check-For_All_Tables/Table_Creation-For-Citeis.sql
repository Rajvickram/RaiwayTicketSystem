use RailwayDb;

create table Cities
(
Id int primary key identity,
Name nvarchar(100) not null
);


insert into Cities (Name)
values ('Chennai'), ('Cuddalore'), ('Chidambaram'), ('Pondicherry'), ('Coimbatore'), ('Madurai'), ('Chengalpattu'), ('Salem'), ('Karaikal'), ('Kumbakonam'), ('Mayiladutharai'), ('Rameswaram');


select * from Cities;

select * from Users;

select * from Bookings;