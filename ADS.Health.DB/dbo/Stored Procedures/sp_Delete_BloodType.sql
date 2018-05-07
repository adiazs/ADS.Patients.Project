-- =============================================
-- Author:		Anthony Díaz S.
-- Create date: 06/05/2018
-- Description:	Delete a BloodType by ID
-- =============================================
CREATE PROCEDURE sp_Delete_BloodType
				@ID AS INT
AS
BEGIN
	SET NOCOUNT ON;

	  DELETE 
	  FROM 
		[dbo].[BloodTypes]
      WHERE 
		[ID] = @ID
END