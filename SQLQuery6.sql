USE [C:\USERS\FRANCISCO.HOLIVEIRA3\SOURCE\REPOS\MERCADOZE\MERCADOZE\BANCODEDADOS\MERCADOBD.MDF]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[P_InserirUsuarios]
		@Tipo = N'Gerente',
		@DataAcesso = '25/10/2005',
		@IdFunci_fk = 27,
		@senha = N'123'

SELECT	@return_value as 'Return Value'

GO
