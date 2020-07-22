using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cap09.Data.DAL.Docente
{
    public class ProfessorDAL
    {
        private IESContext _context;
        public ProfessorDAL(IESContext context)
        {
            _context = context;
        }
    }
}
