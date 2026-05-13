using Ejercicio3.ConexionDB;
using Ejercicio3.Data;

namespace Ejercicio3;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        var repo = new EstudianteRepositorio(CadenaConexion.Valor);
        Application.Run(new Form1(repo));
    }
}
