CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateSales`(in SaleId int, NewSaleName varchar(50))
BEGIN
	update sellerdb.sales set sellerdb.sales.SaleName = NewSaleName
	where sellerdb.sales.SaleId = SaleId;
END
