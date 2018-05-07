USE bd_Health
GO
-- =============================================
-- Author:		Anthony Díaz S.
-- Create date: 06/05/2018
-- Description:	Delete a Country by ID
-- =============================================
CREATE PROCEDURE sp_Delete_Country
				@ID AS INT
AS
BEGIN
	SET NOCOUNT ON;

	  DELETE 
	  FROM 
		[dbo].[Countries]
      WHERE 
		[ID] = @ID
END
GO
