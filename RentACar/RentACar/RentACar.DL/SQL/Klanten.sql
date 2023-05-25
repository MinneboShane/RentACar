create table klanten (
	klantnummer nvarchar(15) not null primary key identity,
	voornaam nvarchar(30) not null,
	naam nvarchar(30) not null,
	straat nvarchar(50) not null,
	huisnummer int not null,
	busnummer int null,
	gemeente nvarchar(30) not null,
	postcode nvarchar(4) not null,
	btwnummer nvarchar(30) null
);