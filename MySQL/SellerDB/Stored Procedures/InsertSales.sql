CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertSales`(in SellerId int, SaleName varchar(50), DateShipping date, Price double)
BEGIN
	insert into sellerdb.sales(
    sellerdb.sales.SellerId, 
    sellerdb.sales.SaleName, 
    sellerdb.sales.DateShipping, 
    sellerdb.sales.Price) 
    values(SellerId, SaleName, DateShipping, Price);
END
