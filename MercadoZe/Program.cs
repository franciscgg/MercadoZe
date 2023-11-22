
using MercadoZe.View.TelasCliente;
using MercadoZe.View.TelasFuncionario;
using MercadoZe.View.TelasProduto;

namespace MercadoZe
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MercadoZe.View.Menu());
        }
    }
}