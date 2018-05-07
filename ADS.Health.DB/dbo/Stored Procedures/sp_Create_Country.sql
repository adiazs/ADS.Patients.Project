-- =============================================
-- Author:		Anthony Díaz S.
-- Create date: 06/05/2018
-- Description:	Create a Country
-- =============================================
CREATE PROCEDURE sp_Create_Country
				@Name AS NVARCHAR(150)
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[Countries]
           ([Name])
     VALUES
           (@Name)
END