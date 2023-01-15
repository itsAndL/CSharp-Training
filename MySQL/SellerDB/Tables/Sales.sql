create table Sales
(
  SaleId int auto_increment primary key,
  SellerId int not null,
  SaleName varchar(50),
  DateShipping date,
  Price double,
  constraint FK_Sales_SellerId foreign key(SellerId) references Seller(SellerId)
);
