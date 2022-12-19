using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ObjetoTransferencia
{
   public class Funcionario
    {
        public int codigoFuncionario { get; set; }
        public string nomeFuncionario { get; set; }
        public string sobrenomeFuncionario { get; set; }
        public DateTime dataNascimentoFuncionario { get; set; }
        public string sexoFuncionario { get; set; }
        public string rgFuncionario { get; set; }
        public string cpfFuncionario { get; set; }
        public string ctpsFuncionario { get; set; }
        public string enderecoFuncionario { get; set; }
        public string bairroFuncionario { get; set; }
        public int numeroFuncionario { get; set; }
        public string cidadeFuncionario { get; set; }
        public string estadoFuncionario { get; set; }
        public string cepFuncionario { get; set; }
        public string telefoneFuncionario { get; set; }
        public string celularFuncionario { get; set; }
        public decimal salarioFuncionario { get; set; }

    }

    public class FuncionarioLista:List<Funcionario>{}
}
