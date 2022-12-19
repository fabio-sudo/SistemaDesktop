using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Grade
    {
        public int codigoGrade { get; set; }
        public string nomeGrade { get; set; }
    }

    public class GradeLista : List<Grade> { } 
}
