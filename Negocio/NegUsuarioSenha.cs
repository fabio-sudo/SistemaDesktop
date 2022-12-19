using AcessoDados;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace Negocio
{
    public class NegUsuarioSenha
    {

        ConexaoSqlServer sqlserver = new ConexaoSqlServer();

        //Cadastro de usuario e senha 
        public Boolean CadastrarUsuarioSenha(UsuarioSenha usuariosenha)
        {
            try
            {
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigousuariosenha", usuariosenha.codigoUsuarioSenha));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@usuario", usuariosenha.usuario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@senha", usuariosenha.senha));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoFuncionario", usuariosenha.Funcionario.codigoFuncionario));

                string comando = " exec uspCadastrarUsuarioSenha " +
                   "@usuario, @senha, @codigoFuncionario";

                object Resposta = sqlserver.ExecutarScalar(comando, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) != 1)
                {
                    return true;
                }
                else
                    return false;

            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Erro na camada de negócios - Cadastro. " + ex.Message);

            }
        }

        //Exclusao de login e senha      
        public Boolean ExcluirUsuarioSenha(UsuarioSenha usuariosenha)
        {
            try
            {

                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigousuariosenha", usuariosenha.codigoUsuarioSenha));

                string comando = "exec uspExcluirUsuarioSenha @codigoUsuarioSenha";

                sqlserver.ExecutarScalar(comando, System.Data.CommandType.Text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível excluir os dados do Usuário. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Alteração de Usuario e Senha
        public Boolean AtualizarUsuarioSenha(UsuarioSenha usuariosenha)
        {
            try
            {
                sqlserver.LimparParametros();

                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigousuariosenha", usuariosenha.codigoUsuarioSenha));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@usuario", usuariosenha.usuario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@senha", usuariosenha.senha));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoFuncionario", usuariosenha.Funcionario.codigoFuncionario));

                string comando = "exec uspAlterarUsuarioSenha @codigoUsuarioSenha, @usuario, @senha, @codigoFuncionario";

                sqlserver.ExecutarScalar(comando, CommandType.Text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível atualizar os dados do Usuário. Motivo: " + ex.Message);
            }
        }

        //-----------------------Consultas
        //Buscar por nome
        public UsuarioSenhaLista BuscarUsuarioSenhaPorNome(string nome)
        {
            try
            {
                sqlserver.LimparParametros();

                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@InvarnomeUsuario", nome));


                DataTable resultado = sqlserver.ExecutarConsulta("uspBuscarUsuarioSenhaPorNome", CommandType.StoredProcedure);

                UsuarioSenhaLista usuariosenhas = new UsuarioSenhaLista();
                UsuarioSenha usuariosenha;

                foreach (DataRow registro in resultado.Rows)
                {
                    usuariosenha = new UsuarioSenha();
                    usuariosenha.Funcionario = new Funcionario();

                    usuariosenha.codigoUsuarioSenha = Convert.ToInt32(registro[0]);
                    usuariosenha.usuario = registro[1].ToString();
                    usuariosenha.senha = registro[2].ToString();
                    usuariosenha.Funcionario.codigoFuncionario = Convert.ToInt32(registro[3]);
                    usuariosenha.Funcionario.nomeFuncionario = (registro[4].ToString());
                    usuariosenha.Funcionario.sobrenomeFuncionario = (registro[5].ToString());
                    usuariosenha.Funcionario.cpfFuncionario = (registro[6].ToString());


                    usuariosenhas.Add(usuariosenha);
                }

                return usuariosenhas;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível realizar a pesquisa de Usuario e Senha. " + ex.Message);
            }
        }

        //metodo para validar usuario e senha
        public UsuarioSenha ValidarSenha(UsuarioSenha usuariosenha)
        {
            try
            {
                string comando = String.Format("exec uspValidaUsuarioSenha '{0}', '{1}'", usuariosenha.usuario.Replace("'", ""), usuariosenha.senha.Replace("'", ""));

                DataTable tabelaRetorno = sqlserver.ExecutarConsulta(comando, System.Data.CommandType.Text);
                UsuarioSenha usuarioValidado = new UsuarioSenha();

                if (tabelaRetorno.Rows.Count > 0 )
                {
                    DataRow registro = tabelaRetorno.Rows[0];

                    //define o objeto para não mantelo nullo
                    usuarioValidado.Funcionario = new Funcionario();

                    usuarioValidado.codigoUsuarioSenha = Convert.ToInt32(registro[0]);
                    usuarioValidado.usuario = registro[1].ToString();
                    usuarioValidado.senha = registro[2].ToString();
                    usuarioValidado.Funcionario.codigoFuncionario = Convert.ToInt32(registro[3].ToString());
                    usuarioValidado.Funcionario.nomeFuncionario = registro[4].ToString();

                    return usuarioValidado;
                }
                else {

                return usuarioValidado = null;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível efetuar login. [Negócios]. Motivo: " + ex.Message);

            }
        }

        //Validar nome de Usuario para login são iguais
        public Boolean ValidarNomeUsuario(UsuarioSenha usuariosenha)
        {
            try
            {

                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@usuario", usuariosenha.usuario));

                string comando = "exec uspValidarNomeUsuarioSenha @usuario";

                object Resposta = sqlserver.ExecutarScalar(comando, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) != 1)
                {
                    return true;
                }
                else
                    return false;

            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Erro na camada de negócios - Cadastro. " + ex.Message);

            }
        }

        //Verifica se o nome do Usuário já existe no sistema
        public UsuarioSenha ValidaCadastroUsuarioSenha(String Usuario)
        {
            try
            {
                DataTable tabelaRetorno;
                UsuarioSenha usuario;

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@Usuario", Usuario));

                string comando = "exec uspValidaCadastroUsuarioSenha @Usuario";

                tabelaRetorno = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);
                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];//Consulta só retorna uma objeto

                    usuario = new UsuarioSenha();
                    usuario.Funcionario = new Funcionario();

                    usuario.usuario = registro[0].ToString();
                    usuario.Funcionario.nomeFuncionario = (registro[1].ToString());
                    usuario.Funcionario.sobrenomeFuncionario = (registro[2].ToString());
                    usuario.Funcionario.cpfFuncionario = (registro[3].ToString());

                    return usuario;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível validar o Usuário. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Verifica se Funcionário ja tem Usuário no sistema
        public UsuarioSenha uspValidaCadastroUsuarioFuncionario(Funcionario Funcionario)
        {
            try
            {
                DataTable tabelaRetorno;
                UsuarioSenha usuario;

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@Funcionario", Funcionario.codigoFuncionario));

                string comando = "exec uspValidaCadastroUsuarioFuncionario @Funcionario";

                tabelaRetorno = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);
                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];//Consulta só retorna uma objeto

                    usuario = new UsuarioSenha();
                    usuario.Funcionario = new Funcionario();

                    usuario.usuario = registro[0].ToString();
                    usuario.Funcionario.nomeFuncionario = (registro[1].ToString());
                    usuario.Funcionario.sobrenomeFuncionario = (registro[2].ToString());
                    usuario.Funcionario.cpfFuncionario = (registro[3].ToString());

                    return usuario;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível validar o Usuário. [Negócios]. Motivo: " + ex.Message);
            }
        }
    }
}
