create table arrangementen (
	
	soort nvarchar(20) not null primary key,
	aantalUren int not null,
	prijs money not null,
	isVasteDuur nvarchar(5) not null,
	subtotaalExBtw money not null,
	subtotaalInBtw money not null,
	totaalExBtw money not null,
	totaalInBtw money not null

);