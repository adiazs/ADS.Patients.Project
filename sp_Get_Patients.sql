USE [bd_Health]
GO

-- =============================================
-- Author:		Anthony Díaz S.
-- Create date: 06/05/2018
-- Description:	Get all patients.
-- =============================================
CREATE PROCEDURE [dbo].[sp_Get_Patients]
AS
BEGIN

	SET NOCOUNT ON;

SELECT TOP 1000
	   PTS.[ID]
      ,PTS.[FirstName]
      ,PTS.[LastName]
      ,PTS.[DateBirth]
      ,PTS.[Diseases]
      ,PTS.[PhoneNumber]
	  ,BTS.[Abbreviation] AS BloodType
	  ,BTS.[ID] AS idBloodType
	  ,CTS.[Name] AS Nationality
	  ,CTS.[ID] AS idCountry 
FROM
	[dbo].[Patients] PTS
INNER JOIN
	[dbo].Countries CTS
ON
	PTS.Nationality = CTS.ID
INNER JOIN
	[dbo].BloodTypes BTS
ON
	PTS.BloodType = BTS.ID
	 

END

GO


