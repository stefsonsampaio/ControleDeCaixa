create table caixa (
	id int primary key,
	valor_inicial float not null,
	valor_final float default null,
	data_abertura datetime default getdate(),
	data_fechamento datetime default null,
	status char(1),
	justificativa varchar(200) default null
)

create table movimentacao (
	transacao_id int primary key,
	caixa_id int,
	constraint FK_caixa_id foreign key (caixa_id)
		references caixa (id),
	data_transacao datetime default getdate(),
	tipo_transacao char(1) not null,
	valor_transacao float not null
)