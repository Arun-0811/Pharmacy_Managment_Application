USE [Pharmacy_DB]
GO
/****** Object:  StoredProcedure [dbo].[sp_login]    Script Date: 20-03-2025 14:15:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[sp_login]
  (@username varchar(50),
  @email varchar(50),
  @pwd varchar(50)
  )as begin
  select count(1) from User_Login where user_name = @username and User_Email = @email and Password = @pwd
  end

  create procedure [dbo].[sp_login]
  (@username varchar(50),
  @email varchar(50),
  @pwd varchar(50)
  )as begin
  select count(1) from User_Login where user_name = @username and User_Email = @email and Password = @pwd
  end



    ALTER TABLE [tbl_syrup]
ADD [total_price] AS ([syrup_quantity] * [syrup_price]) PERSISTED;


ALTER TABLE [tbl_tablets]
ADD [total_price] AS ([tab_quantity] * [tab_price]) PERSISTED;

ALTER TABLE Orders
ADD CONSTRAINT DF_OrderDate DEFAULT GETDATE() FOR OrderDate;




CREATE PROCEDURE GetProductsByCategory
    @CategoryId INT -- Input parameter
AS
BEGIN
    SELECT tab_name AS ItemName
FROM tbl_tablets
WHERE category_name = (SELECT cat_name FROM Category_Name WHERE cat_id = @CategoryId)

    UNION

    SELECT syrup_name AS ItemName 
    FROM tbl_syrup 
    WHERE category_name  = (SELECT cat_name FROM Category_Name WHERE cat_id = @CategoryId)

    UNION

    SELECT sur_name AS ItemName 
    FROM tbl_surgical_items 
    WHERE category_name  = (SELECT cat_name FROM Category_Name WHERE cat_id = @CategoryId);
END;



CREATE PROCEDURE GetProductImageByCategory
    @Itemname varchar(50) -- Input parameter
AS
BEGIN 
    SELECT picture_upload AS ItemPic FROM tbl_tablets WHERE tab_name = @Itemname

    UNION

    SELECT picture_upload AS ItemPic FROM tbl_syrup WHERE syrup_name = @Itemname

    UNION

    SELECT picture_upload AS ItemPic FROM tbl_surgical_items WHERE sur_name = @Itemname;
END;


ALTER PROCEDURE [dbo].[GetProductImageByCategory]
    @Itemname varchar(50) -- Input parameter
AS
BEGIN 
    SELECT picture_upload AS ItemPic , tab_expiry as ExpiryDate , tab_price as PricePerQty FROM tbl_tablets WHERE tab_name = @Itemname

    UNION

    SELECT picture_upload AS ItemPic , syrup_expiry as ExpiryDate , syrup_price as PricePerQty FROM tbl_syrup WHERE syrup_name = @Itemname

    UNION

    SELECT picture_upload AS ItemPic , surgical_expiry as ExpiryDate , sur_price as PricePerQty FROM tbl_surgical_items WHERE sur_name = @Itemname;
END;


CREATE PROCEDURE UpdateInventory
AS
BEGIN
    -- Update tablets quantity
    UPDATE p
    SET p.tab_quantity = p.tab_quantity - pd.quantity
    FROM tbl_tablets p
    INNER JOIN cus_purchase_tbl pd ON p.tab_name = pd.item_name 

    -- Update syrup quantity
    UPDATE p
    SET p.syrup_quantity = p.syrup_quantity - pd.quantity
    FROM tbl_syrup p
    INNER JOIN cus_purchase_tbl pd ON p.syrup_name = pd.item_name;

    -- Update surgical items quantity
    UPDATE p
    SET p.sur_quantity = p.sur_quantity - pd.quantity
    FROM tbl_surgical_items p
    INNER JOIN cus_purchase_tbl pd ON p.sur_name = pd.item_name;
END;