using AcessoDados;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
  public class NegBackupBancoDeDados
    {
        private ConexaoSqlServer sqlserver = new ConexaoSqlServer();

        //Buscar e retornar ultimo registro do banco
        public Boolean Backup(String EnderecoSalvar)
        {
            try
            {

                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new SqlParameter("@local", EnderecoSalvar));

                string comando = " exec uspBackupBancoDeDados @local";
                //D:\BancoDeDadosSqlServer.BAK' modelo do tipo do parametro para salvar

                object Resposta = sqlserver.ExecutarScalar(comando, System.Data.CommandType.Text);
                if (Convert.ToInt16(Resposta) == 1)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                //caso não houver nenhum registro retorna 1 para o primeiro cadastro
                return false;
                throw new Exception("Erro na camada de negócios - Retorno. " + ex.Message);

            }
        }

    }
}
