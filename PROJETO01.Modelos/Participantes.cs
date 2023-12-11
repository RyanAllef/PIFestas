using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETO01.Modelos
{
    public class Participantes
    {
        public int ConviteID { get; set; }
        public int UsuarioID { get; set; }
        public int FestaID { get; set; }

        public Login Usuario { get; set;}
        public CadastroFesta NomeFesta { get; set; }

    }
}
