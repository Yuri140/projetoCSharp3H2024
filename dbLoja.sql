drop database dbLoja;
 
create database dbLoja;
 
use dbLoja;
 
create table tbFuncionarios(
codFunc int not null auto_increment,
nome varchar(100),
email varchar(100),
cpf char(14) not null unique,
telCel char(10),
endereco varchar(100),
numero char(5),
cep char(9),
bairro varchar(100),
cidade varchar(100),
estado char(100),
primary key(codFunc)
);

insert into tbFuncionarios(nome,email,cpf,
    telCel,endereco,numero,cep,bairro,cidade,estado)
    values(@nome,@email,@cpf,
    @telCel,@endereco,@numero,@cep,@bairro,@cidade,@estado);