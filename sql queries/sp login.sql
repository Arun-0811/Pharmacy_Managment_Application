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




alter PROCEDURE GetProductsByCategory
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


BACKUP DATABASE [Pharmacy_DB]
TO DISK = 'C:\BackupDatabase\Pharmacy_DB.bak'
WITH FORMAT,
     MEDIANAME = 'PharmacyBackup',
     NAME = 'Full Backup of Pharmacy_DB';

	 BACKUP DATABASE [AREvent_Project]
TO DISK = 'C:\BackupDatabase\AREvent_Project.bak'
WITH FORMAT,
     MEDIANAME = 'AREventBackup',
     NAME = 'Full Backup of AREvent_Project';


	 CREATE PROCEDURE GetCatIdByCategory
    @CategoryName varchar(100) -- Input parameter
AS
BEGIN
    insert into tbl_tablets (cat_id as categoryId) values (@cat_id = (SELECT cat_id FROM Category_Name WHERE categoryName = @CategoryName)

    UNION

    insert into tbl_syrup (cat_id as categoryId) values (@cat_id = (SELECT cat_id FROM Category_Name WHERE categoryName = @CategoryName)

    UNION

    insert into tbl_surgical_items (cat_id as categoryId) values (@cat_id = (SELECT cat_id FROM Category_Name WHERE categoryName = @CategoryName);
END;

CREATE PROCEDURE GetCatIdByCategory
    @CategoryName VARCHAR(100) -- Input parameter
AS
BEGIN
    -- Declare a variable to hold the category ID
    DECLARE @cat_id INT;

    -- Get the cat_id from the Category_Name table based on the CategoryName
    SELECT @cat_id = cat_id 
    FROM Category_Name 
    WHERE cat_name = @CategoryName;

    -- Insert into tbl_tablets
    INSERT INTO tbl_tablets (cat_id)
    VALUES (@cat_id);

    -- Insert into tbl_syrup
    INSERT INTO tbl_syrup (cat_id)
    VALUES (@cat_id);

    -- Insert into tbl_surgical_items
    INSERT INTO tbl_surgical_items (cat_id)
    VALUES (@cat_id);
END;


Alter PROCEDURE GetCatIdByCategory
    @CategoryName VARCHAR(100) -- Input parameter
AS
BEGIN
    -- Declare a variable to hold the category ID
    DECLARE @cat_id INT;

    -- Get the cat_id from the Category_Name table based on the CategoryName
    SELECT @cat_id = cat_id 
    FROM Category_Name 
    WHERE cat_name = @CategoryName;

    -- Return the cat_id to the calling procedure
    SELECT @cat_id AS cat_id;
END;


ALTER TABLE tbl_tablets
DROP COLUMN category_name;

ALTER TABLE tbl_syrup
DROP COLUMN category_name;

ALTER TABLE tbl_surgical_items
DROP COLUMN category_name;

  -- Add the foreign key constraint (FK_tbl_tablets_Category)
ALTER TABLE tbl_tablets
ADD CONSTRAINT FK_tbl_tablets_Category FOREIGN KEY (cat_id) REFERENCES Category_Name (cat_id);

ALTER TABLE tbl_syrup 
ADD CONSTRAINT FK_tbl_syrup_Category FOREIGN KEY (cat_id) REFERENCES Category_Name (cat_id);

ALTER TABLE tbl_surgical_items 
ADD CONSTRAINT FK_tbl_surgical_items_Category FOREIGN KEY (cat_id) REFERENCES Category_Name (cat_id);


CREATE TABLE tbl_syrup (
    syrup_id INT IDENTITY(1,1) PRIMARY KEY,         -- Primary key for tbl_syrup
    syrup_name VARCHAR(100) NOT NULL,               -- Syrup name column
    cat_id INT,                                     -- Foreign key reference to Category_Name table
    syrup_quantity INT,                             -- Syrup quantity
    syrup_price DECIMAL(18, 2),                     -- Syrup price
    default_date DATE,                              -- Manufacturing date
    syrup_expiry DATE,                              -- Expiry date of syrup
    total_price AS (syrup_quantity * syrup_price),  -- Computed total price (quantity * price)
    picture_upload VARBINARY(MAX),                  -- Image upload for the syrup (if needed)
    CONSTRAINT FK_tbl_syrup_Category FOREIGN KEY (cat_id) REFERENCES Category_Name (cat_id) -- Foreign key constraint
);


CREATE TABLE tbl_surgical_items (
    sur_id INT IDENTITY(1,1) PRIMARY KEY,           -- Primary key for tbl_surgical_items
    sur_name VARCHAR(100) NOT NULL,                 -- Surgical item name column
    cat_id INT,                                     -- Foreign key reference to Category_Name table
    sur_quantity INT,                               -- Surgical item quantity
    sur_price DECIMAL(18, 2),                       -- Surgical item price
    default_date DATE,                              -- Manufacturing date
    surgical_expiry DATE,                           -- Expiry date of surgical item
    total_price AS (sur_quantity * sur_price),      -- Computed total price (quantity * price)
    picture_upload VARBINARY(MAX),                  -- Image upload for the surgical item (if needed)
    CONSTRAINT FK_tbl_surgical_items_Category FOREIGN KEY (cat_id) REFERENCES Category_Name (cat_id) -- Foreign key constraint
);



ALTER PROCEDURE InsertTablet
    @tab_name VARCHAR(100),          -- Tablet name
    @cat_name VARCHAR(100),      -- Category name
    @quantity INT,               -- Tablet quantity
    @price DECIMAL(18, 2),       -- Tablet price
    @mfgdate DATE,               -- Manufacturing date
    @expiry DATE,                -- Expiry date
    @pic_upload VARBINARY(MAX)   -- Image or picture upload
AS
BEGIN
    DECLARE @cat_id INT;

    -- Get the cat_id from Category_Name using the GetCatIdByCategory procedure
    EXEC GetCatIdByCategory @CategoryName = @cat_name;

    -- Insert into tbl_tablets
    INSERT INTO tbl_tablets
    (
        tab_name, 
        cat_id, 
        tab_quantity, 
        tab_price, 
        default_date, 
        tab_expiry, 
        picture_upload
    )
    VALUES 
    (
        @tab_name, 
        @cat_id, 
        @quantity, 
        @price, 
        @mfgdate, 
        @expiry, 
        @pic_upload
    );
END;


CREATE PROCEDURE InsertSyrup
    @name VARCHAR(100),          -- Syrup name
    @cat_name VARCHAR(100),      -- Category name
    @quantity INT,               -- Syrup quantity
    @price DECIMAL(18, 2),       -- Syrup price
    @mfgdate DATE,               -- Manufacturing date
    @expiry DATE,                -- Expiry date
    @pic_upload VARBINARY(MAX)   -- Image or picture upload
AS
BEGIN
    DECLARE @cat_id INT;

    -- Get the cat_id from Category_Name using the GetCatIdByCategory procedure
    EXEC GetCatIdByCategory @CategoryName = @cat_name;

    -- Insert into tbl_syrup
    INSERT INTO tbl_syrup
    (
        syrup_name, 
        cat_id, 
        syrup_quantity, 
        syrup_price, 
        default_date, 
        syrup_expiry, 
        picture_upload
    )
    VALUES 
    (
        @name, 
        @cat_id, 
        @quantity, 
        @price, 
        @mfgdate, 
        @expiry, 
        @pic_upload
    );
END;


CREATE PROCEDURE InsertSurgicalItem
    @name VARCHAR(100),           -- Surgical item name
    @cat_name VARCHAR(100),       -- Category name
    @quantity INT,                -- Surgical item quantity
    @price DECIMAL(18, 2),        -- Surgical item price
    @mfgdate DATE,                -- Manufacturing date
    @expiry DATE,                 -- Expiry date
    @pic_upload VARBINARY(MAX)    -- Image or picture upload
AS
BEGIN
    DECLARE @cat_id INT;

    -- Get the cat_id from Category_Name using the GetCatIdByCategory procedure
    EXEC GetCatIdByCategory @CategoryName = @cat_name;

    -- Insert into tbl_surgical_items
    INSERT INTO tbl_surgical_items
    (
        sur_name, 
        cat_id, 
        sur_quantity, 
        sur_price, 
        default_date, 
        surgical_expiry, 
        picture_upload
    )
    VALUES 
    (
        @name, 
        @cat_id, 
        @quantity, 
        @price, 
        @mfgdate, 
        @expiry, 
        @pic_upload
    );
END;


alter this procedure for same error  

CREATE PROCEDURE sp_UpdateTablet
    @id INT,                      -- Tablet ID to be updated
    @name VARCHAR(100),            -- Updated tablet name
    @cat_name VARCHAR(100),        -- Updated category name
    @quantity INT,                 -- Updated tablet quantity
    @price DECIMAL(18, 2),         -- Updated tablet price
    @mfgdate DATE,                 -- Updated manufacturing date
    @expiry DATE,                  -- Updated expiry date
    @pic_upload VARBINARY(MAX)     -- Updated image or picture upload
AS
BEGIN
    DECLARE @cat_id INT;

    -- Get the cat_id from Category_Name using the GetCatIdByCategory procedure
    EXEC GetCatIdByCategory @CategoryName = @cat_name;

    -- Update the tbl_tablets table with the new values
    UPDATE tbl_tablets
    SET
        tab_name = @name,
        cat_id = @cat_id, 
        tab_quantity = @quantity,
        tab_price = @price,
        default_date = @mfgdate,
        tab_expiry = @expiry,
        picture_upload = @pic_upload
    WHERE tab_id = @id;  -- Update only the record that matches the given tab_id
END;





CREATE PROCEDURE sp_UpdateSyrup
    @id INT,                      -- Syrup ID to be updated
    @name VARCHAR(100),            -- Updated syrup name
    @cat_name VARCHAR(100),        -- Updated category name
    @quantity INT,                 -- Updated syrup quantity
    @price DECIMAL(18, 2),         -- Updated syrup price
    @mfgdate DATE,                 -- Updated manufacturing date
    @expiry DATE,                  -- Updated expiry date
    @pic_upload VARBINARY(MAX)     -- Updated image or picture upload
AS
BEGIN
    DECLARE @cat_id INT;

    -- Get the cat_id from Category_Name using the GetCatIdByCategory procedure
    EXEC GetCatIdByCategory @CategoryName = @cat_name;

    -- Update the tbl_syrup table with the new values
    UPDATE tbl_syrup
    SET
        syrup_name = @name,
        cat_id = @cat_id, 
        syrup_quantity = @quantity,
        syrup_price = @price,
        default_date = @mfgdate,
        syrup_expiry = @expiry,
        picture_upload = @pic_upload
    WHERE syrup_id = @id;  -- Update only the record that matches the given syrup_id
END;



CREATE PROCEDURE sp_UpdateSurgicalItem
    @id INT,                      -- Surgical item ID to be updated
    @name VARCHAR(100),            -- Updated surgical item name
    @cat_name VARCHAR(100),        -- Updated category name
    @quantity INT,                 -- Updated surgical item quantity
    @price DECIMAL(18, 2),         -- Updated surgical item price
    @mfgdate DATE,                 -- Updated manufacturing date
    @expiry DATE,                  -- Updated expiry date
    @pic_upload VARBINARY(MAX)     -- Updated image or picture upload
AS
BEGIN
    DECLARE @cat_id INT;

    -- Get the cat_id from Category_Name using the GetCatIdByCategory procedure
    EXEC GetCatIdByCategory @CategoryName = @cat_name;

    -- Update the tbl_surgical_items table with the new values
    UPDATE tbl_surgical_items
    SET
        sur_name = @name,
        cat_id = @cat_id, 
        sur_quantity = @quantity,
        sur_price = @price,
        default_date = @mfgdate,
        surgical_expiry = @expiry,
        picture_upload = @pic_upload
    WHERE sur_id = @id;  -- Update only the record that matches the given sur_id
END;


CREATE PROCEDURE DeleteSurgicalItem
    @sur_id INT   -- Surgical item ID to identify which record to delete
AS
BEGIN
    -- Delete from tbl_surgical_items where sur_id matches the given ID
    DELETE FROM tbl_surgical_items WHERE sur_id = @sur_id;
END;


CREATE PROCEDURE DeleteSyrupItem
    @id INT   -- Syrup item ID to identify which record to delete
AS
BEGIN
    -- Delete from tbl_syrup where syrup_id matches the given ID
    DELETE FROM tbl_syrup WHERE syrup_id = @id;
END;

CREATE PROCEDURE DeleteTabletItem
    @id INT   -- Tablet item ID to identify which record to delete
AS
BEGIN
    -- Delete from tbl_tablets where tab_id matches the given ID
    DELETE FROM tbl_tablets WHERE tab_id = @id;
END;

