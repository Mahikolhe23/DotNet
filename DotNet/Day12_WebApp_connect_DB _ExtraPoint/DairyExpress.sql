Create database DairyExpress;
use DairyExpress;

Create table Products(Id int not null primary key AUTO_INCREMENT,  title varchar(20),category varchar(20),unitprice decimal(9,2),expDate date);

insert into Products (title,category,unitPrice,expDate) values("Paneer","Milk",100,"2023-01-20");
insert into Products (title,category,unitPrice,expDate) values("Flavored Milk", "Milk",1210,"2023-01-20");
insert into Products (title,category,unitPrice,expDate) values("Amul Cheese", " Cheese Slices",100,"2023-01-20");

