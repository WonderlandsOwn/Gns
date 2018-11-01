/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
DELETE FROM [dbo].[Player]
DELETE FROM [dbo].[Rank]
INSERT INTO [dbo].[Player]([PlayerName])
VALUES('PlayerOne')
INSERT INTO [dbo].[Player]([PlayerName])
VALUES('PlayerTwo')
INSERT INTO [dbo].[Player]([PlayerName])
VALUES('PlayerThree')
INSERT INTO [dbo].[Rank]([RankName])
VALUES ('Race')
INSERT INTO [dbo].[Rank]([RankName])
VALUES ('PrimaryClass')
INSERT INTO [dbo].[Rank]([RankName])
VALUES ('SecondaryClass')