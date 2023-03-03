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
            List<ElevadorData> elevadorData = LeitorJson();

            var elevadores = from e in elevadorData
                             where e.Elevador == 'A'
                             select e.Elevador;
                        
            float QuantidadeElevadorA = elevadores.Count();

            float percentualDeUsoElevadorA = (QuantidadeElevadorA * 100) / elevadorData.Count();
            
            return percentualDeUsoElevadorA;
        }


        public float percentualDeUsoElevadorB()
        {
            List<ElevadorData> elevadorData = LeitorJson();

            var elevadores = from e in elevadorData
                             where e.Elevador == 'B'
                             select e.Elevador;

            float QuantidadeElevadorB = elevadores.Count();

            float percentualDeUsoElevadorB = (QuantidadeElevadorB * 100) / elevadorData.Count();

            return percentualDeUsoElevadorB;
        }

        public float percentualDeUsoElevadorC()
        {
            List<ElevadorData> elevadorData = LeitorJson();

            var elevadores = from e in elevadorData
                             where e.Elevador == 'C'
                             select e.Elevador;

            float QuantidadeElevadorC = elevadores.Count();

            float percentualDeUsoElevadorC = (QuantidadeElevadorC * 100) / elevadorData.Count();

            return percentualDeUsoElevadorC;
        }

        public float percentualDeUsoElevadorD()
        {
            List<ElevadorData> elevadorData = LeitorJson();

            var elevadores = from e in elevadorData
                             where e.Elevador == 'D'
                             select e.Elevador;

            float QuantidadeElevadorD = elevadores.Count();

            float percentualDeUsoElevadorD = (QuantidadeElevadorD * 100) / elevadorData.Count();

            return percentualDeUsoElevadorD;
        }

        public float percentualDeUsoElevadorE()
        {
            List<ElevadorData> elevadorData = LeitorJson();

            var elevadores = from e in elevadorData
                             where e.Elevador == 'E'
                             select e.Elevador;

            float QuantidadeElevadorE = elevadores.Count();

            float percentualDeUsoElevadorE = (QuantidadeElevadorE * 100) / elevadorData.Count();

            return percentualDeUsoElevadorE;
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
