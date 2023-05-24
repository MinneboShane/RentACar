create table wagens (

	merk nvarchar(50) not null primary key,
	model nvarchar(50) not null primary key,
	bouwjaar nvarchar (4) null,
	isBeschikbaar nvarchar(5) not null
);