
namespace WfaCrudMoveis
{
    partial class FrmMoveis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMoveis));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.grpCampos = new System.Windows.Forms.GroupBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.dtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.lblDataCad = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvMovel = new System.Windows.Forms.DataGridView();
            this.tbl_MoveisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lP2DataSet11 = new WfaCrudMoveis.LP2DataSet1();
            this.tblMoveisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lP2DataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lP2DataSet1 = new WfaCrudMoveis.LP2DataSet();
            this.tblMoveisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lP2DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_MoveisTableAdapter1 = new WfaCrudMoveis.LP2DataSet1TableAdapters.tbl_MoveisTableAdapter();
            this.tableAdapterManager = new WfaCrudMoveis.LP2DataSet1TableAdapters.TableAdapterManager();
            this.tbl_MoveisTableAdapter = new WfaCrudMoveis.LP2DataSetTableAdapters.tbl_MoveisTableAdapter();
            this.tblMoveisBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblMoveisBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tblMoveisBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_MoveisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMoveisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMoveisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMoveisBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMoveisBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMoveisBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Honeydew;
            this.btnSair.Location = new System.Drawing.Point(770, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(77, 43);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnListar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListar.Location = new System.Drawing.Point(670, 12);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(82, 43);
            this.btnListar.TabIndex = 14;
            this.btnListar.Text = "&Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(545, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 43);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.Honeydew;
            this.btnGravar.Location = new System.Drawing.Point(448, 12);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(82, 43);
            this.btnGravar.TabIndex = 12;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPesquisar.Location = new System.Drawing.Point(331, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(104, 43);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnApagar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnApagar.Location = new System.Drawing.Point(225, 12);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(82, 43);
            this.btnApagar.TabIndex = 10;
            this.btnApagar.Text = "&Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Location = new System.Drawing.Point(122, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(82, 43);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.Honeydew;
            this.btnIncluir.Location = new System.Drawing.Point(12, 12);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(82, 43);
            this.btnIncluir.TabIndex = 8;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // grpCampos
            // 
            this.grpCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(137)))), ((int)(((byte)(132)))));
            this.grpCampos.Controls.Add(this.btnFoto);
            this.grpCampos.Controls.Add(this.pcbFoto);
            this.grpCampos.Controls.Add(this.dtpDataCadastro);
            this.grpCampos.Controls.Add(this.lblDataCad);
            this.grpCampos.Controls.Add(this.txtPeso);
            this.grpCampos.Controls.Add(this.lblPeso);
            this.grpCampos.Controls.Add(this.txtModelo);
            this.grpCampos.Controls.Add(this.lblModelo);
            this.grpCampos.Controls.Add(this.txtNome);
            this.grpCampos.Controls.Add(this.lblNome);
            this.grpCampos.Controls.Add(this.txtId);
            this.grpCampos.Controls.Add(this.lblId);
            this.grpCampos.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCampos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpCampos.Location = new System.Drawing.Point(59, 61);
            this.grpCampos.Name = "grpCampos";
            this.grpCampos.Size = new System.Drawing.Size(741, 412);
            this.grpCampos.TabIndex = 16;
            this.grpCampos.TabStop = false;
            this.grpCampos.Text = "Móvel";
            // 
            // btnFoto
            // 
            this.btnFoto.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnFoto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFoto.Location = new System.Drawing.Point(511, 349);
            this.btnFoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(104, 53);
            this.btnFoto.TabIndex = 10;
            this.btnFoto.Text = "&Foto";
            this.btnFoto.UseVisualStyleBackColor = false;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // pcbFoto
            // 
            this.pcbFoto.Location = new System.Drawing.Point(417, 33);
            this.pcbFoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(301, 308);
            this.pcbFoto.TabIndex = 9;
            this.pcbFoto.TabStop = false;
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataCadastro.Location = new System.Drawing.Point(227, 257);
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Size = new System.Drawing.Size(155, 28);
            this.dtpDataCadastro.TabIndex = 8;
            // 
            // lblDataCad
            // 
            this.lblDataCad.AutoSize = true;
            this.lblDataCad.Location = new System.Drawing.Point(84, 257);
            this.lblDataCad.Name = "lblDataCad";
            this.lblDataCad.Size = new System.Drawing.Size(153, 24);
            this.lblDataCad.TabIndex = 7;
            this.lblDataCad.Text = "Data de cadastro:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(166, 209);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(88, 28);
            this.txtPeso.TabIndex = 6;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(105, 213);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(55, 24);
            this.lblPeso.TabIndex = 5;
            this.lblPeso.Text = "Peso:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(166, 158);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(216, 28);
            this.txtModelo.TabIndex = 4;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(84, 162);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(75, 24);
            this.lblModelo.TabIndex = 3;
            this.lblModelo.Text = "Modelo:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(166, 107);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(216, 28);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(95, 111);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(64, 24);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(166, 57);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(37, 28);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(129, 61);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(30, 24);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // dgvMovel
            // 
            this.dgvMovel.AllowUserToAddRows = false;
            this.dgvMovel.AllowUserToDeleteRows = false;
            this.dgvMovel.AutoGenerateColumns = false;
            this.dgvMovel.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvMovel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.pesoDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn,
            this.fotoDataGridViewTextBoxColumn});
            this.dgvMovel.DataSource = this.tblMoveisBindingSource4;
            this.dgvMovel.Location = new System.Drawing.Point(59, 480);
            this.dgvMovel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMovel.Name = "dgvMovel";
            this.dgvMovel.ReadOnly = true;
            this.dgvMovel.RowHeadersWidth = 51;
            this.dgvMovel.RowTemplate.Height = 24;
            this.dgvMovel.Size = new System.Drawing.Size(741, 139);
            this.dgvMovel.TabIndex = 17;
            // 
            // tbl_MoveisBindingSource
            // 
            this.tbl_MoveisBindingSource.DataMember = "tbl_Moveis";
            this.tbl_MoveisBindingSource.DataSource = this.lP2DataSet11;
            // 
            // lP2DataSet11
            // 
            this.lP2DataSet11.DataSetName = "LP2DataSet1";
            this.lP2DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMoveisBindingSource1
            // 
            this.tblMoveisBindingSource1.DataMember = "tbl_Moveis";
            this.tblMoveisBindingSource1.DataSource = this.lP2DataSet1BindingSource1;
            // 
            // lP2DataSet1BindingSource1
            // 
            this.lP2DataSet1BindingSource1.DataSource = this.lP2DataSet1;
            this.lP2DataSet1BindingSource1.Position = 0;
            // 
            // lP2DataSet1
            // 
            this.lP2DataSet1.DataSetName = "LP2DataSet";
            this.lP2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMoveisBindingSource
            // 
            this.tblMoveisBindingSource.DataMember = "tbl_Moveis";
            this.tblMoveisBindingSource.DataSource = this.lP2DataSet1BindingSource;
            // 
            // lP2DataSet1BindingSource
            // 
            this.lP2DataSet1BindingSource.DataSource = this.lP2DataSet1;
            this.lP2DataSet1BindingSource.Position = 0;
            // 
            // tbl_MoveisTableAdapter1
            // 
            this.tbl_MoveisTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_MoveisTableAdapter = this.tbl_MoveisTableAdapter1;
            this.tableAdapterManager.UpdateOrder = WfaCrudMoveis.LP2DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_MoveisTableAdapter
            // 
            this.tbl_MoveisTableAdapter.ClearBeforeFill = true;
            // 
            // tblMoveisBindingSource2
            // 
            this.tblMoveisBindingSource2.DataMember = "tbl_Moveis";
            this.tblMoveisBindingSource2.DataSource = this.lP2DataSet1BindingSource;
            // 
            // tblMoveisBindingSource3
            // 
            this.tblMoveisBindingSource3.DataMember = "tbl_Moveis";
            this.tblMoveisBindingSource3.DataSource = this.lP2DataSet1BindingSource1;
            // 
            // tblMoveisBindingSource4
            // 
            this.tblMoveisBindingSource4.DataMember = "tbl_Moveis";
            this.tblMoveisBindingSource4.DataSource = this.lP2DataSet1BindingSource;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.FillWeight = 80F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 150;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            this.modeloDataGridViewTextBoxColumn.Width = 150;
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            this.pesoDataGridViewTextBoxColumn.DataPropertyName = "peso";
            this.pesoDataGridViewTextBoxColumn.HeaderText = "Peso";
            this.pesoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            this.pesoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pesoDataGridViewTextBoxColumn.Width = 70;
            // 
            // dataCadastroDataGridViewTextBoxColumn
            // 
            this.dataCadastroDataGridViewTextBoxColumn.DataPropertyName = "dataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.HeaderText = "Data de Cadastro";
            this.dataCadastroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataCadastroDataGridViewTextBoxColumn.Name = "dataCadastroDataGridViewTextBoxColumn";
            this.dataCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataCadastroDataGridViewTextBoxColumn.Width = 140;
            // 
            // fotoDataGridViewTextBoxColumn
            // 
            this.fotoDataGridViewTextBoxColumn.DataPropertyName = "foto";
            this.fotoDataGridViewTextBoxColumn.HeaderText = "Foto";
            this.fotoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fotoDataGridViewTextBoxColumn.Name = "fotoDataGridViewTextBoxColumn";
            this.fotoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fotoDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmMoveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(862, 630);
            this.Controls.Add(this.dgvMovel);
            this.Controls.Add(this.grpCampos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnIncluir);
            this.Font = new System.Drawing.Font("Geologica", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMoveis";
            this.Text = "CRUD - Móveis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMoveis_FormClosing);
            this.Load += new System.EventHandler(this.FrmMoveis_Load);
            this.grpCampos.ResumeLayout(false);
            this.grpCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_MoveisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMoveisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMoveisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMoveisBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMoveisBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMoveisBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.GroupBox grpCampos;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
        private System.Windows.Forms.Label lblDataCad;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private LP2DataSet lP2DataSet1;
        private System.Windows.Forms.DataGridView dgvMovel;
        private System.Windows.Forms.BindingSource lP2DataSet1BindingSource;
        private System.Windows.Forms.BindingSource lP2DataSet1BindingSource1;
        private System.Windows.Forms.BindingSource tblMoveisBindingSource;
        private LP2DataSetTableAdapters.tbl_MoveisTableAdapter tbl_MoveisTableAdapter;
        private System.Windows.Forms.BindingSource tblMoveisBindingSource1;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox pcbFoto;
        private LP2DataSet1 lP2DataSet11;
        private System.Windows.Forms.BindingSource tbl_MoveisBindingSource;
        private LP2DataSet1TableAdapters.tbl_MoveisTableAdapter tbl_MoveisTableAdapter1;
        private LP2DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tblMoveisBindingSource4;
        private System.Windows.Forms.BindingSource tblMoveisBindingSource2;
        private System.Windows.Forms.BindingSource tblMoveisBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fotoDataGridViewTextBoxColumn;
    }
}

