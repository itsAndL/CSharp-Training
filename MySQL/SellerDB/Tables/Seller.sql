create table Seller
(
  SellerId int auto_increment primary key,
  FirstName varchar(15) not null,
  LastName varchar(15) not null,
  EmailAddress varchar(100),
  PhoneNumber varchar(20)
);
