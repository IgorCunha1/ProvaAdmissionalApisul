
using ProvaAdmissionalApisul.Interface;
using ProvaAdmissionalApisul.Service;

class Program
{

    public static void Main(string[] args)
    {
        var elevadorService = new ElevadorService();

        //var andarMenosUtilizado = elevadorService.andarMenosUtilizado();
        //andarMenosUtilizado.ForEach(a => Console.Write(a+"-"));

        //var elevadorMaisFrequentado = elevadorService.elevadorMaisFrequentado();
        //elevadorMaisFrequentado.ForEach(a => Console.WriteLine(a));

        //var elevadorMenosFrequentado = elevadorService.elevadorMenosFrequentado();
        //elevadorMaisFrequentado.ForEach(a => Console.WriteLine(a));

        var percentualDeUsoElevadorA = elevadorService.percentualDeUsoElevadorA();
        Console.WriteLine(percentualDeUsoElevadorA);

    }
}
