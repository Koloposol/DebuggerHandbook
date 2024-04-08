create table users_db (
	id int identity(1,1) not null primary key,
	surname varchar(20) not null,
	name varchar(15) not null,
	email varchar(30) not null unique,
	password varchar(10) not null unique,
	theory_count int default 0 not null,
	practice_count int default 0 not null,
	theory_progress int default 0 not null,
	practice_progress int default 0 not null
);