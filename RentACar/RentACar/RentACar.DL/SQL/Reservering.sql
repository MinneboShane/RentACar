create table Reserveringen (

	reserveringsNr int not null primary key identity,
	datum date not null,
	klantnummer nvarchar(15) not null,
	wagen1 nvarchar(150) not null,
	wagen2 nvarchar(150) null,
	wagen3 nvarchar(150) null,
	arrangement nvarchar(150) not null,
	startdatum date not null,
	startuur time not null,
	aantalUren decimal not null,
	startplaats nvarchar(25) not null,
	aankomstplaats nvarchar(25) not null,
	subtotaalExBtw money not null,
	subtotaalInBtw money not null,
	totaalExBtw money not null,
	totaalInBtw money not null,

	constraint FK_Reservering_Klanten foreign key (klant) references Klanten(klantnummer),
	constraint FK_Reservering_Wagens foreign key (wagen1) references Wagens(merk, model),
	constraint FK_Reservering_Wagens foreign key (wagen2) references Wagens(merk, model),
	constraint FK_Reservering_Wagens foreign key (wagen3) references Wagens(merk, model),
	constraint FK_Reservering_Arrangement foreign key (arrangement) references Arrangement(soort),
	constraint FK_Reservering_Plaats foreign key (startplaats) references Plaats(plaatsnaam),
	constraint FK_Reservering_Plaats foreign key (aankomstplaats) references Plaats(plaatsnaam)
	
	
);