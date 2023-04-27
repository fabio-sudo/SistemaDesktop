using Negocio;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmSelecionarParcialCrediario : Form
    {
        NegItemCrediario nParcial = new NegItemCrediario();
        
        ItemCrediarioParcial objParcial = new ItemCrediarioParcial();
        ItemCrediarioParcialLista listaParcial = new ItemCrediarioParcialLista();
        ItemCrediarioParcialLista ListaCancelamento = new ItemCrediarioParcialLista();
        ItemCrediarioParcialLista ListaParcialSangria = new ItemCrediarioParcialLista();//Utilizada para cancelamentos no caso de sangria
        ItemCrediario objitemCrediario = new ItemCrediario();

        Cliente objCliente = new Cliente();
        NegCliente nCliente = new NegCliente();


        //Variaveis
        String LocalSolution;
        Boolean clkSelecao = false;
        Boolean iniciaFrm = false;

        public FrmSelecionarParcialCrediario(ItemCrediario itemCrediario, ItemCrediarioParcialLista listaParcial)
        {
            InitializeComponent();

            if (itemCrediario != null) {

                objitemCrediario = itemCrediario;
            
            }
            if (listaParcial != null) {
                ListaParcialSangria = listaParcial;
            
            }
        }

        //-----------Métodos
        private void AtualizarDataGrid()
        {
            try
            {
                this.dgvParcial.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

                if (this.listaParcial.Count > 0)
                {
                    this.dgvParcial.Rows.Add(this.listaParcial.Count);
                }
                else
                {
                    return;
                }

                int indice = 0;
                foreach (ItemCrediarioParcial item in this.listaParcial)
                {
                    //------FK e UK
                    this.dgvParcial[1, indice].Value = item.Cliente.codigoCliente;
                    this.dgvParcial[2, indice].Value = item.ItemCrediario.codigoItemCrediario;
                    this.dgvParcial[3, indice].Value = item.CodigoParcial;
                    this.dgvParcial[4, indice].Value = item.ProdutoCor.codigoProdutoCor;
                    this.dgvParcial[5, indice].Value = item.ProdutoCor.Produto.codigoProduto;
                    //-----Produto
                    this.dgvParcial[6, indice].Value = item.ProdutoCor.Produto.descricaoProduto;
                    this.dgvParcial[7, indice].Value = item.ProdutoCor.Produto.referenciaProduto;
                    this.dgvParcial[8, indice].Value = item.Tamanho.codigoTamanho;
                    this.dgvParcial[9, indice].Value = item.Tamanho.nometamanho;
                    //-----FormaPagamento
                    this.dgvParcial[10, indice].Value = item.FormaPagamento.codigoFormaPagamento;
                    this.dgvParcial[11, indice].Value = item.FormaPagamento.formaPagamento;
                    //-----Valores
                    this.dgvParcial[12, indice].Value = item.parcelaParcial;
                    this.dgvParcial[13, indice].Value = item.valorParcialBruto;//Recebimento
                    this.dgvParcial[14, indice].Value = item.valorPagoParcial;//Valor Liquido sem Desconto e Sem Taxa
                    this.dgvParcial[15, indice].Value = item.jurosParcial;  
                    this.dgvParcial[16, indice].Value = item.descontoParcial;               
                    //-----------Parcial Estatus
                    this.dgvParcial[17, indice].Value = item.ProdutoCor.ImagemProduto;
                    this.dgvParcial[18, indice].Value = item.dataParcial;
                    this.dgvParcial[19, indice].Value = item.estatusParcial;

                    indice++;
                }

                dgvParcial.Update();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void metodoIniciaFormulario()
        {
            //Busca Parciais que devem ser excluidas ou atualizadas para atualizar os valores da sangria
            if (ListaParcialSangria.Count > 0) {

                btBuscarParcial.Enabled = false;
                tbBuscarCliente.Enabled = false;
                pbBuscarCrediario.Enabled = false;
                pbCliente.Enabled = false;
                pbFiltrar.Enabled = false;
                pbLimpar.Enabled = false;
                this.Text = "Cancelamento Parciais Sangria";

                int contador = 0;
                listaParcial = new ItemCrediarioParcialLista();

                foreach (ItemCrediarioParcial item in ListaParcialSangria) {
                    if (listaParcial.Count == 0)
                    {
                        listaParcial = nParcial.BuscarItemCrediarioParcialPorItemCrediario(item.ItemCrediario.codigoItemCrediario);
                    }
                    else if(item.ItemCrediario.codigoItemCrediario != listaParcial[contador].ItemCrediario.codigoItemCrediario) {
                       
                        ItemCrediarioParcialLista novaLista = new  ItemCrediarioParcialLista();

                        novaLista = nParcial.BuscarItemCrediarioParcialPorItemCrediario(item.ItemCrediario.codigoItemCrediario);

                        //Junta as duas listas
                        listaParcial.AddRange(novaLista);                    
                    }
                }

                ListaCancelamento = listaParcial;                                       
                AtualizarDataGrid();
                metodoExibeImagemProduto();
                metodoSelecionaTodosItens();
            
            }else{
            
            iniciaFrm = true;

            //Inicia o Formulário Com Item Selecionado ou com Crediario ou com Formulário Vazio
            if (objitemCrediario.codigoItemCrediario != 0 && objitemCrediario.parcialItemCrediario != (objitemCrediario.quantidadeItemCrediario * objitemCrediario.valorItemCrediario)) {
                listaParcial = nParcial.BuscarItemCrediarioParcialPorItemCrediario(objitemCrediario.codigoItemCrediario);
                AtualizarDataGrid();

                objCliente = nCliente.BuscarClientePorCodigo(objitemCrediario.Crediario.codigoCrediario);
                this.tbBuscarCliente.Text = objCliente.nomeCliente + " " + objCliente.sobrenomeCliente;

                metodoExibeImagemProduto();

            }
            else if (objitemCrediario.Crediario != null && listaParcial.Count == 0)
            {

                objCliente = nCliente.BuscarClientePorCodigo(objitemCrediario.Crediario.codigoCrediario);
                this.tbBuscarCliente.Text = objCliente.nomeCliente + " " + objCliente.sobrenomeCliente;

                btBuscarParcial.PerformClick();
                metodoExibeImagemProduto();
            }
            else if (dgvParcial.Rows.Count > 0)
            {
                this.tbBuscarCliente.Text = objCliente.nomeCliente + " " + objCliente.sobrenomeCliente;
                btBuscarParcial.PerformClick();
                metodoExibeImagemProduto();
            }
            else
            {
                iniciaFrm = false;
                return;
              }
            }
        }

        private void metodoExibeImagemProduto()
        {
            if (dgvParcial.Rows.Count > 0)
            {
                //Buscal Local que a Solution Está sendo Executada no Computador
                LocalSolution = Environment.CurrentDirectory;
                // This will get the current PROJECT directory
                LocalSolution = Directory.GetParent(LocalSolution).Parent.Parent.FullName;

                String imgProduto = (dgvParcial.CurrentRow.Cells[17].Value).ToString();
                //Verifica se a imagem existe
                if (System.IO.File.Exists(LocalSolution + "\\Imagens\\" + imgProduto + ".jpeg") == true)
                {
                    //----------------Cria imagem para exibir 
                    Image img;
                    Bitmap img2;
                    img = (System.Drawing.Image.FromFile(LocalSolution + "\\Imagens\\" + imgProduto + ".jpeg"));
                    img2 = new Bitmap(img);
                    img.Dispose();
                    pbImagemProduto.Image = img2;
                }
                else
                {
                    pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
                }
            }

        }

        private void metodoCalcula() {
            if (dgvParcial.Rows.Count > 0)
            {
                double juros = 0;
                double desconto = 0;
                double parcialLiquido = 0;
                double parcialRecebida = 0;
                //percorre todas as linhas do gride
                foreach (DataGridViewRow check in dgvParcial.Rows)
                {
                    //pega valores cheked no gride
                    if ((bool)check.Cells[0].FormattedValue == true)
                    {
                        parcialRecebida = Convert.ToDouble(check.Cells[13].Value) + parcialRecebida; //Recebimento
                        parcialLiquido = Convert.ToDouble(check.Cells[14].Value) + parcialLiquido;//Valor Liquido sem Desconto e Sem Taxa
                        juros = Convert.ToDouble(check.Cells[15].Value) + juros; //juros
                        desconto = Convert.ToDouble(check.Cells[16].Value) + desconto;//desconto
                    }

                    lbValorTotalParcial.Text = "+ " + String.Format("{0:C2}", parcialLiquido);
                    lbJurosParcial.Text = "% " + String.Format("{0:C2}", juros);
                    lbDescontoParcial.Text = "-  " + String.Format("{0:C2}", desconto);
                    lbTotalLiquidoParcial.Text = String.Format("{0:C2}", parcialRecebida); //Esse e o valor que realmente foi recebido

                    //preencher as quantidade totais
                    lbEstorno.Text = String.Format("{0:C2}", parcialRecebida);
                    lbTaxa.Text = String.Format("{0:C2}", juros);
                    lbDesconto.Text = String.Format("{0:C2}", desconto);

                    if (cbJuros.Checked == true)
                    {

                        lbTotalBrutoParcial.Text = String.Format("{0:C2}", parcialRecebida);
                        lbEstorno.Text = String.Format("{0:C2}", parcialRecebida);

                    }
                    else
                    {

                        lbTotalBrutoParcial.Text = String.Format("{0:C2}", parcialLiquido - desconto);
                        lbEstorno.Text = String.Format("{0:C2}", parcialLiquido - desconto);
                    }
                }
            }
            else {
                lbValorTotalParcial.Text = "+ " + String.Format("{0:C2}", 0);
                lbJurosParcial.Text = "% " + String.Format("{0:C2}", 0);
                lbDescontoParcial.Text = "-  " + String.Format("{0:C2}", 0);
                lbTotalLiquidoParcial.Text = String.Format("{0:C2}", 0); //Esse e o valor que realmente foi recebido
                lbTotalBrutoParcial.Text = String.Format("{0:C2}", 0);
                lbEstorno.Text = String.Format("{0:C2}", 0);
                lbTaxa.Text = String.Format("{0:C2}", 0);
                lbDesconto.Text = String.Format("{0:C2}", 0);
            }

        
        }

        private Boolean metodoValidaSelecao()
        {

            Boolean validaSelecao = false;

            if (dgvParcial.RowCount > 0)
            {
                //percorre todas as linhas do gride
                foreach (DataGridViewRow check in dgvParcial.Rows)
                {
                    //pega valores cheked no gride
                    if ((bool)check.Cells[0].FormattedValue)
                    {
                        validaSelecao = true;
                        return validaSelecao;
                    }

                }

            }

            return validaSelecao;

        }

        //---------------------------------------Métodos para cancelamento da Sangria
        #region Cancelamento Sangria

        //Adiciona itens a lista de cancelamento
        private void metodoAddListaCancelamento() {

            //Limpando a lista
            ListaCancelamento = new ItemCrediarioParcialLista();

            //percorre todas as linhas do gride
            foreach (DataGridViewRow check in dgvParcial.Rows)
            {
                //pega valores cheked no gride
                if ((bool)check.Cells[0].FormattedValue)
                {
                    //Código item Entrada 
                    int codigoItem = int.Parse(check.Cells[3].Value.ToString());

                    foreach (ItemCrediarioParcial parcial in listaParcial)
                    {

                        if (codigoItem == parcial.CodigoParcial)
                        {
                            ListaCancelamento.Add(parcial);
                        }
                    }

                }
            }
        
        
        }

        //Seleciona todos os itens do data grid
        private void metodoSelecionaTodosItens() {

            foreach (DataGridViewRow col in dgvParcial.Rows) {

                ((DataGridViewCheckBoxCell)col.Cells[0]).Value = true;
                ((DataGridViewCheckBoxCell)col.Cells[0]).ReadOnly = true;
            }
        
        }

        //Realiza comparações para ver a necessidade da atalização da sangria
        private Boolean metodoValidaCancelamentoSangria()
        {
            try
            {
                Sangria sangria = new Sangria();
                NegSangria nSangria = new NegSangria();

                if (ListaCancelamento.Count > 0)
                {
                    //Nova  Lista Separando intens por forma de Pagamento
                    ItemCrediarioParcialLista lista = new ItemCrediarioParcialLista();

                    //Adiciona itens por data e forma de pagamento na lista
                    int contador = 0;
                    foreach (ItemCrediarioParcial itemLista in ListaCancelamento)
                    {
                        //Adiciona Item
                        if (contador == 0)
                        {
                            lista.Add(itemLista);
                        }
                     
                        //DATA e PAGAMENTO forem iguais realizado a atualização do item
                        else if (lista[contador].FormaPagamento.codigoFormaPagamento == itemLista.FormaPagamento.codigoFormaPagamento &&
                            lista[contador].dataParcial == itemLista.dataParcial)
                        {
                            //Soma os valores das parciais com a mesma data e mesma forma de pagamento
                            lista[contador].valorParcialBruto = lista[contador].valorParcialBruto + itemLista.valorPagoParcial;
                        }
                        else
                        {
                            lista.Add(itemLista);
                            contador++;
                        }
                    }

                    //Validar itens de acordo com sua forma de pagamento e data
                    contador = 0;
                    while (lista.Count > contador)
                    {
                        //Resto Caixa
                        sangria = nSangria.BuscarCancelamentoSangria(lista[contador].dataParcial, lista[contador].FormaPagamento.codigoFormaPagamento);
                        
                        if (sangria != null)
                        {
                            sangria.dataSangria = lista[contador].dataParcial;
                            double valorTotalItem = (from x in lista where (x.FormaPagamento.codigoFormaPagamento == sangria.pagamentoSangria.codigoFormaPagamento && x.dataParcial == sangria.dataSangria) select (x.valorParcialBruto)).Sum();//Valor parcial e o valor com desconto e juros valor liquido

                            //Lista de valores da sangria referente a data de cancelamento do item
                            SangriaLista sangriaLista = new SangriaLista();
                            sangriaLista = metodoBuscaSangriaCancelamento(lista);
                            double valorSangria = (from s in sangriaLista where (s.pagamentoSangria.codigoFormaPagamento == lista[contador].FormaPagamento.codigoFormaPagamento) select (s.valorSangria)).Sum();

                            //Busca Valores do caixa de acordo com as datas que tem no item
                            CaixaLista caixaLista = new CaixaLista();
                            caixaLista = metodoBuscaCaixaCancelamento(lista);
                            double valorCaixa = (from c in caixaLista where (c.formaPagamento.codigoFormaPagamento == lista[contador].FormaPagamento.codigoFormaPagamento && c.dataCaixa == lista[contador].dataParcial) select (c.valorCaixa)).Sum();


                            //Resto do caixa >= Valor do Caixa - Valor Item Cancelado
                            if ((sangria.valorSangria) >= valorCaixa - valorTotalItem)
                            {
                                DialogResult resultadoAtualizacaoSangria;
                                FrmCancelamentoSangria frmSangria = new FrmCancelamentoSangria(null,null,null);
                                resultadoAtualizacaoSangria = frmSangria.ShowDialog();

                                if (resultadoAtualizacaoSangria == DialogResult.Yes)
                                {

                                    return true;

                                }
                                else { 
                                    return false;
                                }
                            }

                        }
                        else { contador++; }
                        //Validação sangria vazia 
                    }//While End
                }//ListaItemCrediario > 0

                return true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
        }

        //Busca Valores dos Caixas referente as datas dos itens que serão cancelados
        private CaixaLista metodoBuscaCaixaCancelamento(ItemCrediarioParcialLista lista)
        {
            NegCaixa nCaixa = new NegCaixa();
            CaixaLista caixaLista = new CaixaLista();
            int contador = 0;
            foreach (ItemCrediarioParcial item in lista)
            {
                if (caixaLista.Count == 0)
                {

                    caixaLista = nCaixa.BuscarCaixaValores(item.dataParcial);
                }
                else if (item.dataParcial != caixaLista[contador].dataCaixa)
                {
                    //Toda vez que a data for diferente busca os itens do caixa 
                    //E os adiciona na lista antiga
                    CaixaLista caixaListaNova = new CaixaLista();
                    caixaListaNova = nCaixa.BuscarCaixaValores(item.dataParcial);
                    foreach (Caixa caixaAdd in caixaListaNova)
                    {

                        caixaLista.Add(caixaAdd);

                    }

                }

            }

            return caixaLista;
        }

        //Buscar valores da Sangria referente ao cancelamento
        private SangriaLista metodoBuscaSangriaCancelamento(ItemCrediarioParcialLista lista)
        {

            SangriaLista sangriaLista = new SangriaLista();
            NegSangria nSangria = new NegSangria();
            int contador = 0;
            foreach (ItemCrediarioParcial item in lista)
            {
                if (sangriaLista.Count == 0)
                {

                    sangriaLista = nSangria.BuscarSangriaParaCancelamento(item.dataParcial);
                }
                else if (item.dataParcial != sangriaLista[contador].dataSangria)
                {
                    //Toda vez que a data for diferente busca os itens do caixa 
                    //E os adiciona na lista antiga
                    SangriaLista sangriaListaNova = new SangriaLista();
                    sangriaListaNova = nSangria.BuscarSangriaParaCancelamento(item.dataParcial);
                    foreach (Sangria sangriaAdd in sangriaListaNova)
                    {

                        sangriaLista.Add(sangriaAdd);

                    }

                }

            }

            return sangriaLista;

        }

        #endregion
        //-----------------------Caixa De Texto
        private void tbBuscarCliente_Leave(object sender, EventArgs e)
        {
            if (tbBuscarCliente.Text == "")
            {
                tbBuscarCliente.Text = "Digite o nome do cliente ...";
                pbCliente.Image = Properties.Resources.ClienteAzul;
                panelBuscarCliente.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbBuscarCliente.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void tbBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbCliente_Click(null, null);
                e.Handled = true;
            }
        }

        private void tbBuscarCliente_Enter(object sender, EventArgs e)
        {
            if (iniciaFrm == true)
            {

                iniciaFrm = false;
            }
            else
            {
                tbBuscarCliente.Clear();
                pbCliente.Image = Properties.Resources.ClienteRosa;
                panelBuscarCliente.BackColor = Color.DeepPink;
            }
        }

        //----------------------Botões
        private void pbCliente_Click(object sender, EventArgs e)
        {
            int n;
            bool ehUmNumero = int.TryParse(tbBuscarCliente.Text, out n);
            if (ehUmNumero == true)
            {
                objCliente = nCliente.BuscarClientePorCodigo(n);
                if (objCliente != null)
                {
                    this.tbBuscarCliente.Text = objCliente.nomeCliente + " " + objCliente.sobrenomeCliente;

                    btBuscarParcial.PerformClick();
                    metodoExibeImagemProduto();

                }
            }
            else
            {
                FrmSelecionarCliente frmSelecionarCliente = new FrmSelecionarCliente(tbBuscarCliente.Text);
                DialogResult resultado = frmSelecionarCliente.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    this.objCliente = frmSelecionarCliente.clienteSelecionado;
                    this.tbBuscarCliente.Text = objCliente.nomeCliente + " " + objCliente.sobrenomeCliente;

                    btBuscarParcial.PerformClick();
                    metodoExibeImagemProduto();
                }

            }
        }

        private void pbBuscarCrediario_Click(object sender, EventArgs e)
        {
            if (dgvParcial.Rows.Count > 0)
            {
                objCliente = nCliente.BuscarClientePorCodigo(Convert.ToInt32(dgvParcial.CurrentRow.Cells[1].Value));
               
                if (objCliente != null)
                {
                    this.tbBuscarCliente.Text = objCliente.nomeCliente + " " + objCliente.sobrenomeCliente;

                    btBuscarParcial.PerformClick();
                    metodoExibeImagemProduto();

                    lbValorTotalParcial.Text = "+ " + String.Format("{0:C2}", 0);
                    lbJurosParcial.Text = "% " + String.Format("{0:C2}", 0);
                    lbDescontoParcial.Text = "-  " + String.Format("{0:C2}", 0);
                    lbTotalLiquidoParcial.Text = String.Format("{0:C2}", 0); //Esse e o valor que realmente foi recebido
                    lbTotalBrutoParcial.Text = String.Format("{0:C2}", 0);  

                }
            }
        }

        private void btBuscarParcial_Click(object sender, EventArgs e)
        {
           string cliente = tbBuscarCliente.Text;

           if (tbBuscarCliente.Text.Equals("Digite o nome do cliente ...") || tbBuscarCliente.Text == string.Empty)
           {
               cliente = "";
           }
           else if(objCliente != null){

               cliente = objCliente.nomeCliente;
           }


            listaParcial = nParcial.BuscarItemCrediarioParcialPorCliente(cliente);
            AtualizarDataGrid();
            metodoExibeImagemProduto();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dgvParcial.Rows.Count > 0 && metodoValidaSelecao() == true)
            {
                //Criando Caixa de dialogo
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Opção Cancelar!",
                "Deseja Realizar o cancelamento?",
                Properties.Resources.DialogExcluir,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Sim", "Não",
                false);

                DialogResult resposta = frmCaixa.ShowDialog();
                //----------------------------------ImprimiComprovanteVenda
                if (resposta == DialogResult.Yes)
                {

                    //Metodo Add Itens a lista de cancelamento
                    metodoAddListaCancelamento();

                    //Validação se há Sangria vinculada a cancelamento
                    if (metodoValidaCancelamentoSangria() == true)
                    {
                        //Continua Exclusão
                        if (nParcial.ExcluirItemCrediarioParcialLista(ListaCancelamento) == true)
                        {
                            //Criando Caixa de dialogo
                            frmCaixa = new FrmCaixaDialogo("Calcelamento Realizada!",
                            "Parcial cancelada com sucesso !\r\n" +
                            "Deseja Realizar Impressão do Comprovante?",
                            Properties.Resources.DialogOK,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Sim", "Não",
                            false);

                            DialogResult respostaImpressao = frmCaixa.ShowDialog();
                            //----------------------------------ImprimiComprovanteVenda
                            if (respostaImpressao == DialogResult.Yes)
                            {
                                //ImprimiComprovante()
                                metodoIniciaFormulario();
                                metodoCalcula();
                                if (dgvParcial.Rows.Count == 0) { this.DialogResult = DialogResult.Yes; }
                            }
                            else
                            {
                                //metodoLimpaCampos()
                                metodoIniciaFormulario();
                                metodoCalcula();
                                if (dgvParcial.Rows.Count == 0) { this.DialogResult = DialogResult.Yes; }
                            }
                        }
                        else
                        {
                            FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Erro Cancelar Parcial",
                            "Erro ao cancelar Parcial!",
                            Properties.Resources.DialogErro,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Ok", "",
                            false);
                            frmCaixaCad.ShowDialog();
                        }
                    }
                    else
                    {
                        FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Atualização Sangria",
                        "Realize a atualização da Sangria para cancelar as parciais!",
                         Properties.Resources.DialogErro,
                         System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "Ok", "",
                        false);
                        frmCaixaCad.ShowDialog();
                    }
                }//Opção for igual a não
            }
            else
            {
                FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Erro Seleção",
                "Não existem parciais selecionadas!",
                 Properties.Resources.DialogErro,
                 System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Ok", "",
                false);
                frmCaixaCad.ShowDialog();
            }
         
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação Parcial",
            " Deseja realmente sair da Parcial?",
            Properties.Resources.DialogQuestion,
            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
            Color.White,
            "Sim", "Não",
            false);

            resposta = frmCaixa.ShowDialog();
            if (resposta == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void pbCalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\system32\\calc.exe");
        }

        private void cbJuros_CheckedChanged(object sender, EventArgs e)
        {
            metodoCalcula();
        }

        //------------------------DataGrid
        //Exibe Imagem
        private void dgvParcial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            metodoExibeImagemProduto();
        }

        private void dgvParcial_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvParcial.Columns[e.ColumnIndex].Name == "marcarItem")
            {

                if (clkSelecao == false)
                {
                    clkSelecao = true;
                    foreach (DataGridViewRow dtr in dgvParcial.Rows)
                    {
                        ((DataGridViewCheckBoxCell)dtr.Cells[0]).Value = true;
                    }
                }
                else
                {
                    clkSelecao = false;
                    foreach (DataGridViewRow dtr in dgvParcial.Rows)
                    {
                        ((DataGridViewCheckBoxCell)dtr.Cells[0]).Value = false;
                    }

                }
                metodoCalcula();
                btExcluir.Focus();
            }
        }

        private void dgvParcial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Verificamos se e somente se a celula checkbox (Estado) foi clicada
            if (e.ColumnIndex == dgvParcial.Columns["marcarItem"].Index)
            {
                dgvParcial.EndEdit();
                metodoCalcula();
            }
        }

        //-----------------------Filtros
        private void pbFiltrar_Click(object sender, EventArgs e)
        {
            string cliente = tbBuscarCliente.Text;

            if (tbBuscarCliente.Text.Equals("Digite o nome do cliente ...") || tbBuscarCliente.Text == string.Empty)
            {
                cliente = "";
                objCliente = new Cliente();
            }
            if (objCliente.nomeCliente != null)
            {

                cliente = objCliente.nomeCliente;
                listaParcial = nParcial.BuscarItemCrediarioParcialPorClienteEData(cliente, dtpDataInicial.Value, dtpDataFinal.Value);
            }
            else {

                listaParcial = nParcial.BuscarItemCrediarioParcialPorData(dtpDataInicial.Value, dtpDataFinal.Value);
            }
            
            AtualizarDataGrid();
            metodoExibeImagemProduto();


        }

        private void pbLimpar_Click(object sender, EventArgs e)
        {
            dtpDataInicial.Value = DateTime.Now;
            dtpDataFinal.Value = DateTime.Now;
            dgvParcial.Rows.Clear();
            tbBuscarCliente.Focus();
            pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;

            lbValorTotalParcial.Text = "+ " + String.Format("{0:C2}", 0);
            lbJurosParcial.Text = "% " + String.Format("{0:C2}", 0);
            lbDescontoParcial.Text = "-  " + String.Format("{0:C2}", 0);
            lbTotalLiquidoParcial.Text = String.Format("{0:C2}", 0); //Esse e o valor que realmente foi recebido
            lbTotalBrutoParcial.Text = String.Format("{0:C2}",0);  
            
        }

        private void FrmSelecionarParcialCrediario_Load(object sender, EventArgs e)
        {
            metodoIniciaFormulario();
        }

        //---------------Teclas de Atalho
        private void FrmSelecionarParcialCrediario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F5) == true)
            {
                pbBuscarCrediario_Click(null, null);
            }
            if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btExcluir.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
        }



    }
}
