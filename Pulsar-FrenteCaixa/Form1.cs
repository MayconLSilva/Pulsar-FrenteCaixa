namespace Pulsar_FrenteCaixa
{
    public partial class FrmCadastroDeClientes : Form
    {


        public FrmCadastroDeClientes()
        {
            InitializeComponent();
            eventosBotoes("");
        }




        public void eventosBotoes(string click)
        {
            switch (click.ToUpper())
            {
                case "NOVO":
                    //Eventos botões
                    toolStripMenuItemNovo.Enabled = false;
                    toolStripMenuItemGravar.Enabled = true;
                    toolStripMenuItemEditar.Enabled = false;
                    toolStripMenuItemCancelar.Enabled = true;
                    toolStripMenuItemExcluir.Enabled = false;
                    toolStripMenuItemSincronizar.Enabled = false;
                    //Eventos habilita e desabilita campos
                    txtNome.Enabled = true;
                    txtTelefone.Enabled = true;
                    //Evento limpa campos
                    txtID.Text = "";
                    txtNome.Text = "";
                    txtTelefone.Text = "";
                    break;
                case "EDITAR":
                    //Eventos botões
                    toolStripMenuItemNovo.Enabled = false;
                    toolStripMenuItemGravar.Enabled = true;
                    toolStripMenuItemEditar.Enabled = false;
                    toolStripMenuItemCancelar.Enabled = true;
                    toolStripMenuItemExcluir.Enabled = false;
                    toolStripMenuItemSincronizar.Enabled = false;
                    //Eventos habilita e desabilita campos
                    txtNome.Enabled = true;
                    txtTelefone.Enabled = true;
                    break;
                case "GRAVAR":
                    //Eventos botões
                    toolStripMenuItemNovo.Enabled = true;
                    toolStripMenuItemGravar.Enabled = false;
                    toolStripMenuItemEditar.Enabled = true;
                    toolStripMenuItemCancelar.Enabled = false;
                    toolStripMenuItemExcluir.Enabled = true;
                    toolStripMenuItemSincronizar.Enabled = true;
                    //Eventos habilita e desabilita campos
                    txtNome.Enabled = false;
                    txtTelefone.Enabled = false;
                    break;
                case "CANCELAR":
                    //Eventos botões
                    toolStripMenuItemNovo.Enabled = true;
                    toolStripMenuItemGravar.Enabled = false;
                    toolStripMenuItemEditar.Enabled = false;
                    toolStripMenuItemCancelar.Enabled = false;
                    toolStripMenuItemExcluir.Enabled = false;
                    toolStripMenuItemSincronizar.Enabled = true;
                    //Eventos habilita e desabilita campos
                    txtNome.Enabled = false;
                    txtTelefone.Enabled = false;
                    //Evento limpa campos
                    txtID.Text = "";
                    txtNome.Text = "";
                    txtTelefone.Text = "";
                    break;
                case "EXCLUIR":
                    //Eventos botões
                    toolStripMenuItemNovo.Enabled = true;
                    toolStripMenuItemGravar.Enabled = false;
                    toolStripMenuItemEditar.Enabled = false;
                    toolStripMenuItemCancelar.Enabled = false;
                    toolStripMenuItemExcluir.Enabled = false;
                    toolStripMenuItemSincronizar.Enabled = true;
                    //Eventos habilita e desabilita campos
                    txtNome.Enabled = false;
                    txtTelefone.Enabled = false;
                    //Evento limpa campos
                    txtID.Text = "";
                    txtNome.Text = "";
                    txtTelefone.Text = "";
                    break;
                default:
                    //Eventos botões
                    toolStripMenuItemNovo.Enabled = true;
                    toolStripMenuItemGravar.Enabled = false;
                    toolStripMenuItemEditar.Enabled = false;
                    toolStripMenuItemCancelar.Enabled = false;
                    toolStripMenuItemExcluir.Enabled = true;
                    toolStripMenuItemSincronizar.Enabled = true;
                    //Eventos habilita e desabilita campos
                    txtNome.Enabled = false;
                    txtTelefone.Enabled = false;
                    //Evento limpa campos
                    txtID.Text = "";
                    txtNome.Text = "";
                    txtTelefone.Text = "";

                    break;
            }
        }




        private void toolStripMenuItemNovo_Click(object sender, EventArgs e)
        {
            eventosBotoes("Novo");
        }
        private void toolStripMenuItemGravar_Click(object sender, EventArgs e)
        {
            eventosBotoes("Gravar");
        }

        private void toolStripMenuItemEditar_Click(object sender, EventArgs e)
        {
            eventosBotoes("Editar");
        }

        private void toolStripMenuItemCancelar_Click(object sender, EventArgs e)
        {
            eventosBotoes("Cancelar");
        }

        private void toolStripMenuItemExcluir_Click(object sender, EventArgs e)
        {
            eventosBotoes("Excluir");
        }

        private void txtTelefone_Validated(object sender, EventArgs e)
        {
            txtTelefone.Text = MLSHelp.Util.MascaraTelefoneCelular(txtTelefone.Text);
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            txtTelefone.Text = MLSHelp.Util.MascaraTelefoneCelular(txtTelefone.Text);
        }
    }
}