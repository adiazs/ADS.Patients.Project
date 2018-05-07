USE bd_Health
GO
-- =============================================
-- Author:		Anthony Díaz S.
-- Create date: 06/05/2018
-- Description:	Update a BloodType by ID
-- =============================================
CREATE PROCEDURE sp_Update_BloodType
				@ID AS INT,
				@Abbreviation AS CHAR(3),
				@Description  AS NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE 
		[dbo].[BloodTypes]
    SET 
		[Abbreviation] = @Abbreviation,
		[Description] = @Description
	WHERE 
		[ID] = @ID
END
GO
