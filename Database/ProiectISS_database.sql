use master
if exists( select * from sys.databases where name='ProiectISS' )
	drop database ProiectISS
create database ProiectISS

go
use ProiectISS

create table CommitteeMembers(
	username nvarchar(10) primary key,
	pass nvarchar(10),
	firstName nvarchar(10),
	surName nvarchar(10),
	email nvarchar(30),
	webPage nvarchar(20),
	affiliation nvarchar(15),
	rang nvarchar(10)
);

create table Listeners(
	username nvarchar(10) primary key,
	pass nvarchar(10),
	firstName nvarchar(10),
	surName nvarchar(10)
);

create table Sections(
	idS int primary key,
	numeS nvarchar(12)
);

create table Papers(
	idP int primary key,
	title nvarchar(20),
	keywords nvarchar(20),
	topics nvarchar(20),
	authors nvarchar(50),
	publisher nvarchar(20),
	datePaper date,
	pathPaper nvarchar(30),
	idSection int references Sections(idS)
);

create table Speakers(
	username nvarchar(10) primary key,
	pass nvarchar(10),
	firstName nvarchar(10),
	surName nvarchar(10),
	idLucrare int foreign key references Papers(idP)
);

create table Reviews(
	idR int primary key,
	username nvarchar(10) references CommitteeMembers(username),
	idP int references Papers(idP),
	qualifier nvarchar(20) ,
	comment nvarchar(100)
);

create table Bidding(
	usernameCommitteeMember int references CommitteeMembers(username),
	idP int references Papers(idP),
	accepted bit
);