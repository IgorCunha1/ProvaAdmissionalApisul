
using ProvaAdmissionalApisul.Interface;
using ProvaAdmissionalApisul.Service;

class Program
{

    public static void Main(string[] args)
    {
        var elevadorService = new ElevadorService();

        var andarMenosUtilizado = elevadorService.andarMenosUtilizado();
        Console.WriteLine("Andar Menos Utilizado: ");
        Console.WriteLine(string.Join(",", andarMenosUtilizado));
        
        var elevadorMaisFrequentado = elevadorService.elevadorMaisFrequentado();
        Console.WriteLine("Elevador Mais Frequentado: ");
        Console.WriteLine(string.Join(",", elevadorMaisFrequentado));

        var elevadorMenosFrequentado = elevadorService.elevadorMenosFrequentado();
        Console.WriteLine("Elevador Menos Frequentado: ");
        Console.WriteLine(string.Join(",", elevadorMenosFrequentado));
        
        var percentualDeUsoElevadorA = elevadorService.percentualDeUsoElevadorA();
        Console.WriteLine("Percentual De UsoElevador A: ");
        Console.WriteLine(percentualDeUsoElevadorA);
        
        var percentualDeUsoElevadorB = elevadorService.percentualDeUsoElevadorB();
        Console.WriteLine("Percentual De UsoElevador B: ");
        Console.WriteLine(percentualDeUsoElevadorB);
        
        var percentualDeUsoElevadorC = elevadorService.percentualDeUsoElevadorC();
        Console.WriteLine("Percentual De Uso Elevador C: ");
        Console.WriteLine(percentualDeUsoElevadorC);
        
        var percentualDeUsoElevadorD = elevadorService.percentualDeUsoElevadorD();
        Console.WriteLine("Percentual De UsoElevador D: ");
        Console.WriteLine(percentualDeUsoElevadorD);
        
        var percentualDeUsoElevadorE = elevadorService.percentualDeUsoElevadorE();
        Console.WriteLine("Percentual De UsoElevador E: ");
        Console.WriteLine(percentualDeUsoElevadorE);



    }
}
