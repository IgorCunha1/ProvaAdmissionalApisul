using Newtonsoft.Json;
using ProvaAdmissionalApisul.Interface;
using ProvaAdmissionalApisul.Model;
using System.Linq;

namespace ProvaAdmissionalApisul.Service
{
    public class ElevadorService : IElevadorService
    {

        public ElevadorService() { }

        public List<ElevadorData> LeitorJson()
        {
            using (StreamReader r = new StreamReader("../../../input.json"))
            {
                var json = r.ReadToEnd();
                List<ElevadorData> elevadorData = JsonConvert.DeserializeObject<List<ElevadorData>>(json);
                return elevadorData;
            }
        }

        public float CalcularPercentualElevadores(char elevador)
        {
            List<ElevadorData> ElevadorData = LeitorJson();

            var elevadores = from e in ElevadorData
                             where e.Elevador == elevador
                             select e.Elevador;
            
            float QuantidadeElevador = elevadores.Count();

            var resultado = (QuantidadeElevador * 100) / ElevadorData.Count();

            return resultado;
        }

        public List<int> andarMenosUtilizado()
        {

            List<ElevadorData> elevadorData = LeitorJson();

            var elevadores = from e in elevadorData
                             where e.Andar == e.Andar
                             group e by e.Andar into andar
                             orderby andar.Count() ascending
                             select andar;

            List<int> menosFrequentado = new();

            var elevadoresList = elevadores.ToList();
            elevadoresList.ForEach(e => menosFrequentado.Add(e.Key));

            return menosFrequentado;
                                
        }

        public List<char> elevadorMaisFrequentado()
        {
            List<ElevadorData> elevadorData = LeitorJson();

            var elevadores = from e in elevadorData
                            where e.Elevador == e.Elevador
                            group e by e.Elevador into elevador
                            orderby elevador.Count() descending
                            select elevador;
                                                
            List<char> maisFrequentado = new();

            var elevadoresList = elevadores.ToList();
            elevadoresList.ForEach(e => maisFrequentado.Add(e.Key));

            return maisFrequentado;
        }

        public List<char> elevadorMenosFrequentado()
        {
            List<ElevadorData> elevadorData = LeitorJson();

            var elevadores = from e in elevadorData
                             where e.Elevador == e.Elevador
                             group e by e.Elevador into elevador
                             orderby elevador.Count() ascending
                             select elevador;

            List<char> menosFrequentado = new();

            var elevadoresList = elevadores.ToList();
            elevadoresList.ForEach(e => menosFrequentado.Add(e.Key));

            return menosFrequentado;
        }

        public List<char> periodoMaiorFluxoElevadorMaisFrequentado()
        {
            List<ElevadorData> elevadorData = LeitorJson();

            var elevadores = from e in elevadorData
                             where e.Turno == e.Turno
                             group e by e.Turno into turno
                             orderby turno.Count() descending
                             select turno;

            List<char> turnoMaisFrequentado = new();

            var elevadoresList = elevadores.ToList();
            elevadoresList.ForEach(e => turnoMaisFrequentado.Add(e.Key));

            return turnoMaisFrequentado;
        }


        public float percentualDeUsoElevadorA()
        {
            return CalcularPercentualElevadores('A');
        }

        public float percentualDeUsoElevadorB()
        {
            return CalcularPercentualElevadores('B');
        }

        public float percentualDeUsoElevadorC()
        {
            return CalcularPercentualElevadores('C');
        }

        public float percentualDeUsoElevadorD()
        {
            return CalcularPercentualElevadores('D');
        }

        public float percentualDeUsoElevadorE()
        {
            return CalcularPercentualElevadores('E');
        }

        public List<char> periodoMaiorUtilizacaoConjuntoElevadores()
        {
            throw new NotImplementedException();
        }

        public List<char> periodoMenorFluxoElevadorMenosFrequentado()
        {
            throw new NotImplementedException();
        }
    }
}
