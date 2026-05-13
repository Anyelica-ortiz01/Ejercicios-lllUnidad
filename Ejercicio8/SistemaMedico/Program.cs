using SistemaMedico.ConexionDB;
using SistemaMedico.Data;

namespace SistemaMedico;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        var repo = new PacienteRepositorio(CadenaConexion.Valor);
        Application.Run(new Form1(repo));
    }
}
