using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETO01.Modelos
{
    public class CadastroFesta
    {
    public int FestaID { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public string UF { get; set; }
        public DateTime DataFesta { get; set; }
        public string Bairro { get; set; }
        public string PrecoIngresso { get; set; }
        public int OrganizadorID { get; set; }
        public int ConviteID { get; set; }




    }
}
