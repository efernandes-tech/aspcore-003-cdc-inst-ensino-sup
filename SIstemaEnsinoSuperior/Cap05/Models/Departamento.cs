using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cap05.Models
{
    public class Departamento
    {
        public long? DepartamentoID { get; set; }
        public string Nome { get; set; }

        public long? InstituicaoID { get; set; }
        public Instituicao Instituicao { get; set; }
    }
}
