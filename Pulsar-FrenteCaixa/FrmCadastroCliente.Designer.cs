namespace Pulsar_FrenteCaixa
{
    partial class FrmCadastroDeClientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblID = new Label();
            lblNome = new Label();
            lblTelefone = new Label();
            txtID = new TextBox();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            menuStrip = new MenuStrip();
            toolStripMenuItemNovo = new ToolStripMenuItem();
            toolStripMenuItemGravar = new ToolStripMenuItem();
            toolStripMenuItemEditar = new ToolStripMenuItem();
            toolStripMenuItemCancelar = new ToolStripMenuItem();
            toolStripMenuItemExcluir = new ToolStripMenuItem();
            toolStripMenuItemSincronizar = new ToolStripMenuItem();
            dataGridViewClientes = new DataGridView();
            bindingSourceCliente = new BindingSource(components);
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCliente).BeginInit();
            SuspendLayout();

            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(38, 30);
            lblID.Name = "lblID";
            lblID.Size = new Size(21, 15);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(16, 60);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(5, 89);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(54, 15);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "Telefone:";
            // 
            // txtID
            // 
            txtID.Location = new Point(65, 27);
            txtID.MaxLength = 25;
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(45, 23);
            txtID.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(65, 57);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(238, 23);
            txtNome.TabIndex = 4;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(65, 86);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(99, 23);
            txtTelefone.TabIndex = 5;
            txtTelefone.Leave += txtTelefone_Leave;
            txtTelefone.Validated += txtTelefone_Validated;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItemNovo, toolStripMenuItemGravar, toolStripMenuItemEditar, toolStripMenuItemCancelar, toolStripMenuItemExcluir, toolStripMenuItemSincronizar });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(526, 24);
            menuStrip.TabIndex = 6;
            menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItemNovo
            // 
            toolStripMenuItemNovo.Image = Properties.Resources.novo;
            toolStripMenuItemNovo.Name = "toolStripMenuItemNovo";
            toolStripMenuItemNovo.Size = new Size(69, 20);
            toolStripMenuItemNovo.Text = "NOVO";
            toolStripMenuItemNovo.Click += toolStripMenuItemNovo_Click;
            // 
            // toolStripMenuItemGravar
            // 
            toolStripMenuItemGravar.Image = Properties.Resources.save;
            toolStripMenuItemGravar.Name = "toolStripMenuItemGravar";
            toolStripMenuItemGravar.Size = new Size(78, 20);
            toolStripMenuItemGravar.Text = "GRAVAR";
            toolStripMenuItemGravar.Click += toolStripMenuItemGravar_Click;
            // 
            // toolStripMenuItemEditar
            // 
            toolStripMenuItemEditar.Image = Properties.Resources.edit;
            toolStripMenuItemEditar.Name = "toolStripMenuItemEditar";
            toolStripMenuItemEditar.Size = new Size(72, 20);
            toolStripMenuItemEditar.Text = "EDITAR";
            toolStripMenuItemEditar.Click += toolStripMenuItemEditar_Click;
            // 
            // toolStripMenuItemCancelar
            // 
            toolStripMenuItemCancelar.Image = Properties.Resources.cancel1;
            toolStripMenuItemCancelar.Name = "toolStripMenuItemCancelar";
            toolStripMenuItemCancelar.Size = new Size(95, 20);
            toolStripMenuItemCancelar.Text = "CANCELAR";
            toolStripMenuItemCancelar.Click += toolStripMenuItemCancelar_Click;
            // 
            // toolStripMenuItemExcluir
            // 
            toolStripMenuItemExcluir.Image = Properties.Resources.delete;
            toolStripMenuItemExcluir.Name = "toolStripMenuItemExcluir";
            toolStripMenuItemExcluir.Size = new Size(80, 20);
            toolStripMenuItemExcluir.Text = "EXCLUIR";
            toolStripMenuItemExcluir.Click += toolStripMenuItemExcluir_Click;
            // 
            // toolStripMenuItemSincronizar
            // 
            toolStripMenuItemSincronizar.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItemSincronizar.Image = Properties.Resources.sincronizar;
            toolStripMenuItemSincronizar.Name = "toolStripMenuItemSincronizar";
            toolStripMenuItemSincronizar.Size = new Size(111, 20);
            toolStripMenuItemSincronizar.Text = "SINCRONIZAR";
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AutoGenerateColumns = false;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.DataSource = bindingSourceCliente;
            dataGridViewClientes.Location = new Point(5, 115);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowTemplate.Height = 25;
            dataGridViewClientes.Size = new Size(509, 101);
            dataGridViewClientes.TabIndex = 7;
            // 
            // FrmCadastroDeClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 228);
            Controls.Add(dataGridViewClientes);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Controls.Add(lblTelefone);
            Controls.Add(lblNome);
            Controls.Add(lblID);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "FrmCadastroDeClientes";
            Text = "Cadastro de Clientes";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label lblNome;
        private Label lblTelefone;
        private TextBox txtID;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private MenuStrip menuStrip;
        private ToolStripMenuItem toolStripMenuItemNovo;
        private ToolStripMenuItem toolStripMenuItemGravar;
        private ToolStripMenuItem toolStripMenuItemEditar;
        private ToolStripMenuItem toolStripMenuItemCancelar;
        private ToolStripMenuItem toolStripMenuItemExcluir;
        private ToolStripMenuItem toolStripMenuItemSincronizar;
        private DataGridView dataGridViewClientes;
        private BindingSource bindingSourceCliente;
    }
}