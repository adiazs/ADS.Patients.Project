USE [bd_Health]
GO
-- =============================================
-- Author:		Anthony Díaz S.
-- Create date: 06/05/2018
-- Description:	Get all blood types.
-- =============================================
CREATE PROCEDURE [dbo].[sp_Get_BloodTypes]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT [ID]
      ,[Description]
      ,[Abbreviation]
  FROM [bd_Health].[dbo].[BloodTypes]
	 

END

GO


