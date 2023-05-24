create table Arrangementen (
	
	soort nvarchar(20) not null primary key,
	aantalUren int not null,
	prijs decimal not null,
	isVasteDuur nvarchar(5) not null,
	subtotaal decimal not null
);