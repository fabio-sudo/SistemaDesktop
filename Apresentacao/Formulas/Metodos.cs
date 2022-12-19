using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao.Formulas
{
    public class Metodos
    {

        //metodo para formatar campos de Moeda
        public void metodoMoedaTB(ref TextBox txt)
        {

            string n = string.Empty;
            double v = 0;

            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))

                    n = "";
                n = n.PadLeft(3, '0');

                if (n.Length > 3 & n.Substring(0, 1) == "0")

                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt.Clear();

            }

        }

        //metodo para formatar campos de Moeda
        public void metodoMoedaMTB(ref MaskedTextBox txt)
        {

            string n = string.Empty;
            double v = 0;

            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))

                    n = "";
                n = n.PadLeft(3, '0');

                if (n.Length > 3 & n.Substring(0, 1) == "0")

                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt.Clear();

            }

        }

        //metodo para validar CPF
        public bool metodoValidarCPF(string CPF)
        {
            int[] mt1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mt2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string TempCPF;
            string Digito;
            int soma;
            int resto;

            CPF = CPF.Trim();
            CPF = CPF.Replace(".", "").Replace("-", "");
            if (CPF == "00000000000")
            {
                return false;
            }
            if (CPF == "11111111111")
            {
                return false;
            }
            if (CPF == "22222222222")
            {
                return false;
            }
            if (CPF == "33333333333")
            {
                return false;
            }
            if (CPF == "44444444444")
            {
                return false;
            }
            if (CPF == "55555555555")
            {
                return false;
            }
            if (CPF == "66666666666")
            {
                return false;
            }
            if (CPF == "77777777777")
            {
                return false;
            }
            if (CPF == "88888888888")
            {
                return false;
            }
            if (CPF == "99999999999")
            {
                return false;
            }
            else if (CPF.Length != 11)
                return false;

            TempCPF = CPF.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(TempCPF[i].ToString()) * mt1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            Digito = resto.ToString();
            TempCPF = TempCPF + Digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(TempCPF[i].ToString()) * mt2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            Digito = Digito + resto.ToString();

            return CPF.EndsWith(Digito);
        }

        //Método que bloqueia a entrada de literals
        public void metodoAllowNumber(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || //Letras
                char.IsSymbol(e.KeyChar) || //Símbolos
                char.IsWhiteSpace(e.KeyChar) || //Espaço
                char.IsPunctuation(e.KeyChar)) //Pontuação
                e.Handled = true; //Não permitir
        }

        //metodo para validar o cnpj da empresa cadastrada
        public bool metodoValidaCNPJ(string vrCNPJ)
        {

            string CNPJ = vrCNPJ.Replace(".", "");
            CNPJ = CNPJ.Replace("/", "");
            CNPJ = CNPJ.Replace("-", "");

            int[] digitos, soma, resultado;
            int nrDig;
            string ftmt;
            bool[] CNPJOk;

            ftmt = "6543298765432";
            digitos = new int[14];
            soma = new int[2];
            soma[0] = 0;
            soma[1] = 0;
            resultado = new int[2];
            resultado[0] = 0;
            resultado[1] = 0;
            CNPJOk = new bool[2];
            CNPJOk[0] = false;
            CNPJOk[1] = false;

            try
            {
                for (nrDig = 0; nrDig < 14; nrDig++)
                {
                    digitos[nrDig] = int.Parse(
                     CNPJ.Substring(nrDig, 1));
                    if (nrDig <= 11)
                        soma[0] += (digitos[nrDig] *
                        int.Parse(ftmt.Substring(
                          nrDig + 1, 1)));
                    if (nrDig <= 12)
                        soma[1] += (digitos[nrDig] *
                        int.Parse(ftmt.Substring(
                          nrDig, 1)));
                }

                for (nrDig = 0; nrDig < 2; nrDig++)
                {
                    resultado[nrDig] = (soma[nrDig] % 11);
                    if ((resultado[nrDig] == 0) || (resultado[nrDig] == 1))
                        CNPJOk[nrDig] = (
                        digitos[12 + nrDig] == 0);

                    else
                        CNPJOk[nrDig] = (
                        digitos[12 + nrDig] == (
                        11 - resultado[nrDig]));

                }

                return (CNPJOk[0] && CNPJOk[1]);

            }
            catch
            {
                return false;
            }

        }

        //Metodo para Agrupamento de itens do crediario Parcial
        public List<int> metodoRetornaListaParcial(ItemCrediarioParcialLista parciais)
        {
            //Linq para agrupar Lista
            List<object[]> novaLista = parciais.OrderBy(g => g.ItemCrediario.codigoItemCrediario).GroupBy(o => o.ItemCrediario.codigoItemCrediario)
          .Select(i => new object[]
            {
            i.Key,
            i.Select(h => (int) h.ItemCrediario.codigoItemCrediario).ToList()[0]
            }).ToList();
            List<int> items;
            int item;
            items = new List<int>();

            foreach (object[] lista in novaLista)
            {
                item = new int();
                item = Convert.ToInt32(lista[0]);

                items.Add(item);
            }


            return items;

        }

    }
}
