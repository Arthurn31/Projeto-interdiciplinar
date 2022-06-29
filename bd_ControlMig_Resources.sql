create database trabalho_interdiciplinar;
use trabalho_interdiciplinar;

create table produto(
cod int auto_increment not null,
nome varchar(150) not null,
quantidade int not null,
valor double(9,2) not null,
unidade varchar(80),
primary key(cod)
)engine = innoDB;
 
 create table usuarios(
 cpf varchar(14) not null,
 nome varchar(80) not null,
 cargo varchar(80) not null, -- Vendedor, ADM
 data_nasct date not null,
 senha varchar(10) not null,
 primary key(cpf)
 )engine =innoDB;
 
 create table venda(
 numero_venda int auto_increment not null,
 dt_venda date not null,
 valor double(9,2) not null,
 dt_entrega date not null,
 tipo_venda varchar(20) not null,
 usuarios_cpf varchar(14) not null,
 primary key(numero_venda),
 foreign key(usuarios_cpf) references usuarios(cpf)
 )engine= innoDB;
 
 create table itens_venda(
cod int unsigned auto_increment not null,
quantidade int not null,
valor double(9,2) not null,
venda_numero_venda int not null,
produto_cod int not null,
primary key(cod),
foreign key(venda_numero_venda) references venda(numero_venda),
foreign key(produto_cod) references produto(cod)
)engine = innoDB;
