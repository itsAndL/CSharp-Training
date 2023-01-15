CREATE DEFINER=`root`@`localhost` PROCEDURE `ReadData`()
BEGIN
	select a.SaleId, a.SaleName, a.DateShipping, a.Price, e.*
	from sellerdb.seller e join sellerdb.sales a on e.SellerId = a.SellerId
    order by SaleId;
END
