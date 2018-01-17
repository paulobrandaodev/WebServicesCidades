using System.Collections.Generic;

namespace WebServicesCidades.Models
{
    public class Cidades
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Estados { get; set; }
        public int Habitantes { get; set; }

        public List<Cidades> Listar(){
            return new List<Cidades>(){
                new Cidades{Id=10, Nome="Leme",          Estados="SP", Habitantes=1541},
                new Cidades{Id=11, Nome="São Paulo",     Estados="SP", Habitantes=1542},
                new Cidades{Id=12, Nome="Ribeirão Preto",Estados="SP", Habitantes=1543},
                new Cidades{Id=13, Nome="Itú",           Estados="SP", Habitantes=1544}
            };
        }
    }
}