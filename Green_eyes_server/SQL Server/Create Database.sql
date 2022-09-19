Create database Green_eyes_bd;

Use Green_eyes_bd;

Create table tbPlantacao (
	id nvarchar(20) not null,
	plantacao nvarchar(5) not null unique,
	Ativado bit default 1, 
	primary key(id));

Create table tbUsuarios (
	id nvarchar(20) not null,
	Nome nvarchar(20) not null,
	Login nvarchar(50) not null unique,
	Senha nvarchar(200) not null unique,
	Tipo int default 1,
	id_plantacao nvarchar(20) not null foreign key references tbPlantacao(id),
	Ativado bit default 1,
	primary key(id));


Create table tbFotos(
	id nvarchar(20) not null,
	data datetime not null,
	id_usuario nvarchar(20) not null foreign key references tbUsuarios(id),
	link nvarchar(200) not null unique,
	Ativado bit default 1,
	primary key(id));

Create table tbFotosSegmentadas(
	id nvarchar(20) not null,
	data datetime not null,
	id_Foto nvarchar(20) not null foreign key references tbFotos(id),
	link nvarchar(200) not null unique,
	Ativado bit default 1,
	versao_segmentador nvarchar(20) not null
	primary key(id));

Create table tbDiagnosticos(
	id nvarchar(20) not null,
	id_foto_segmentada nvarchar(20) not null foreign key references tbFotosSegmentadas(id),
	data datetime not null,
	classificacao_Azure nvarchar(50) not null,
	grau_certeza decimal(5,2) not null,
	classificacao_final nvarchar(50) not null,
	primary key (id));



