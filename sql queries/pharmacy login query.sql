SELECT TOP (1000) [Id]
      ,[User_Email]
      ,[Password]
  FROM [Pharmacy_DB].[dbo].[User_Login]

  create procedure sp_login
  (
  @email varchar(50),
  @pwd varchar(50)
  )as begin
  select count(1) from User_Login where User_Email = @email and Password = @pwd
  end

  insert into User_Login (User_Email,Password) values ('selvam@gmail.com','selvam420')
  alter table User_Login alter COLUMN Id int identity(1,1) not null
  alter table User_Login drop COLUMN Id
  insert into User_Login  values ('2','selvam@gmail.com','selvam420')