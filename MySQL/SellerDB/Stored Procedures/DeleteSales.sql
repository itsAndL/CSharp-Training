CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteSales`(in SaleId int)
BEGIN
    delete from sellerdb.sales where sellerdb.sales.SaleId = SaleId;
END
