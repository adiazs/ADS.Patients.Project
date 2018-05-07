USE bd_Health
GO
-- =============================================
-- Author:		Anthony D�az S.
-- Create date: 06/05/2018
-- Description:	Update a Country by ID
-- =============================================
CREATE PROCEDURE sp_Update_Country
				@ID AS INT,
				@Name AS NVARCHAR(150)
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE 
		[dbo].[Countries]
    SET 
		[Name] = @Name
	WHERE 
		[ID] = @ID
END
GO
