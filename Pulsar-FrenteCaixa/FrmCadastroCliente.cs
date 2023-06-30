using Pulsar_FrenteCaixa.Dominio;
using ServiceStack;
using ServiceStack.Redis;
using ServiceStack.Redis.Generic;
using static ServiceStack.Diagnostics.Events;

namespace Pulsar_FrenteCaixa
{
    public partial class FrmCadastroDeClientes : Form
    {

        int numeroSequencial = 0;
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
                case "EXCLUIR":
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
                default:
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
            txtNome.Focus();
            empleadoBindingSource.Add(new Empleado());
            empleadoBindingSource.MoveLast();
            gerarID();
        }
        private void toolStripMenuItemGravar_Click(object sender, EventArgs e)
        {
            try
            {
                using (RedisClient cliente = new RedisClient("localhost", 6379))
                {
                    empleadoBindingSource.EndEdit();

                    IRedisTypedClient<Empleado> empleado = cliente.As<Empleado>();
                    empleado.StoreAll(empleadoBindingSource.DataSource as List<Empleado>);
                    MessageBox.Show(this, "Datos gravados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    eventosBotoes("Gravar");
                    numeroSequencial = 0;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void toolStripMenuItemEditar_Click(object sender, EventArgs e)
        {
            eventosBotoes("Editar");
        }

        private void toolStripMenuItemCancelar_Click(object sender, EventArgs e)
        {
            if (numeroSequencial != 0)
            {
                Empleado em = empleadoBindingSource.Current as Empleado;
                if (em != null)
                {
                    using (RedisClient cliente = new RedisClient("localhost", 6379))
                    {
                        IRedisTypedClient<Empleado> empleado = cliente.As<Empleado>();
                        empleado.DeleteById(em.ID);
                        empleadoBindingSource.RemoveCurrent();

                    }
                }
            }
            eventosBotoes("Cancelar");
        }

        private void toolStripMenuItemExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, "Tem certeza que deseja excluir o registro", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                        DialogResult.Yes)
                {
                    Empleado em = empleadoBindingSource.Current as Empleado;
                    if (em != null)
                    {
                        using (RedisClient cliente = new RedisClient("localhost", 6379))
                        {
                            IRedisTypedClient<Empleado> empleado = cliente.As<Empleado>();
                            empleado.DeleteById(em.ID);
                            empleadoBindingSource.RemoveCurrent();

                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
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

        private void FrmCadastroDeClientes_Load(object sender, EventArgs e)
        {

            try
            {
                using (RedisClient cliente = new RedisClient("localhost", 6379))
                {
                    IRedisTypedClient<Empleado> empleado = cliente.As<Empleado>();
                    empleadoBindingSource.DataSource = empleado.GetAll();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void gerarID()
        {
            int numeroLinhas = dataGridViewClientes.RowCount;
            txtID.Text = numeroLinhas.ToString();
            numeroSequencial = numeroLinhas;
            empleadoBindingSource.EndEdit();
        }

        private void toolStripMenuItemSincronizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade ainda não implementada nesta versão!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            txtTelefone.Text = MLSHelp.Util.MascaraTelefoneCelular(txtTelefone.Text);
        }
    }
}