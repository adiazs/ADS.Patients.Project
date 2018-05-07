
-- =============================================
-- Author:		Anthony Díaz S.
-- Create date: 06/05/2018
-- Description:	Update a patient by id.
-- =============================================
CREATE PROCEDURE [dbo].[sp_Update_Patient]
	-- Add the parameters for the stored procedure here
		@FirstName		NVARCHAR(50),
		@LastName		NVARCHAR(50), 
		@DateBirth		DATE,
		@Nationality	INT,
		@BloodType		INT,
		@Diseases		NVARCHAR(150),
		@PhoneNumber	INT,
		@ID				INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
UPDATE 
	[dbo].[Patients]
   SET 
		[FirstName] =		@FirstName, 
		[LastName] =		@LastName, 
		[DateBirth] =		@DateBirth, 
		[Nationality] =		@Nationality,
		[BloodType] =		@BloodType, 
		[Diseases] =		@Diseases, 
		[PhoneNumber] =		@PhoneNumber
 WHERE 
		[ID] = @Id

END