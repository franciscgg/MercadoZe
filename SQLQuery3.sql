USE [C:\USERS\FRANCISCO.HOLIVEIRA3\SOURCE\REPOS\MERCADOZE\MERCADOZE\BANCODEDADOS\MERCADOBD.MDF]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[P_InserirFunci]
		@nomeFunci = N'fghfghfg',
		@emailFunci = N'hfghfgh@gmail.com',
		@foneFunci = N'1314423'

SELECT	@return_value as 'Return Value'

GO
