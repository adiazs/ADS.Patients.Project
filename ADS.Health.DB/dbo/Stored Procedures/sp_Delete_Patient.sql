
-- =============================================
-- Author:		Anthony Díaz
-- Create date: 06/05/2018
-- Description:	Delete a patient by ID
-- =============================================
CREATE PROCEDURE [dbo].[sp_Delete_Patient]
	-- Add the parameters for the stored procedure here
		@ID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DELETE FROM 
		[dbo].[Patients]
	WHERE 
		[dbo].[Patients].ID = @ID
	END