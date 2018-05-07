
-- =============================================
-- Author:		Anthony Díaz S.
-- Create date: 06/05/2018
-- Description:	Add new patient
-- =============================================
CREATE PROCEDURE [dbo].[sp_Insert_Patients] 
	-- parameters for the stored procedure
			   @FirstName 	NVARCHAR(50),
			   @LastName	NVARCHAR(50),
			   @DateBirth	DATE,
			   @Nationality INT,
			   @BloodType	INT,
			   @Diseases	NVARCHAR(150),
			   @PhoneNumber INT
AS
BEGIN

	SET NOCOUNT ON;

    INSERT INTO 
		[dbo].[Patients]
           ([FirstName]
           ,[LastName]
           ,[DateBirth]
           ,[Nationality]
           ,[BloodType]
           ,[Diseases]
           ,[PhoneNumber])
     VALUES
           (@FirstName
           ,@LastName
           ,@DateBirth
           ,@Nationality
           ,@BloodType
           ,@Diseases
           ,@PhoneNumber)
END