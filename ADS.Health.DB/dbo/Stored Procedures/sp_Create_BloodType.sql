-- =============================================
-- Author:		Anthony Díaz S.
-- Create date: 06/05/2018
-- Description:	Create a Blood Type
-- =============================================
CREATE PROCEDURE sp_Create_BloodType
				@Description AS NVARCHAR(50),
				@Abbreviation AS CHAR(3)
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[BloodTypes]
           ([Description]
           ,[Abbreviation])
     VALUES
           (@Description
           ,@Abbreviation)
END