 create table bussines (
	bussinessid int primary key identity(1,1),
	namebussiness varchar (255) not null,
	phone varchar (50),
	email  varchar(255),
	document varchar(50)
 );

 insert into bussines (namebussiness, phone, email, document) 
values ('Gabriel Corporation', '992990307', 'contato@gcorporation.com', '41149160837')

select * from bussines
