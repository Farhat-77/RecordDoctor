create database DapperScript;

use DapperScript;

create table DoctorRecords
(
	Id int primary key identity,
	RecordingName nvarchar(max) not null
);