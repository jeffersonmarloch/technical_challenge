create database technical_challenge_db;

use technical_challenge_db;

create table client (
	id int auto_increment,
	name varchar(150),
	email varchar(150),
	telephone varchar(15),
	register_date varchar(10),
	personal_type varchar(10),
	document varchar(14),
	state_registry varchar(16),
	free_state_registry boolean,
	gender varchar(9),
	date_of_birth varchar(10),
	is_blocked boolean,
	client_password varchar(15),
	primary key(id)
);