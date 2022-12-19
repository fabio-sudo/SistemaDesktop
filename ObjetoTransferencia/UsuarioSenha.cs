using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTransferencia
{
   public class UsuarioSenha
    {
        public int codigoUsuarioSenha { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public Funcionario Funcionario { get; set; }

        //data do cadastro e efetuada no momento do cadastro


    }

   public class UsuarioSenhaLista : List<UsuarioSenha> { }
}