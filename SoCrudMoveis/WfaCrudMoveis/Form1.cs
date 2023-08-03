using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaCrudMoveis
{
    public partial class FrmMoveis : Form
    {
        private bool incluir = false;
        private string caminhoImagem;

        public FrmMoveis()
        {
            InitializeComponent();
        }

        private void FrmMoveis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lP2DataSet11.tbl_Moveis' table. You can move, or remove it, as needed.
            this.tbl_MoveisTableAdapter1.Fill(this.lP2DataSet11.tbl_Moveis);
            // TODO: This line of code loads data into the 'lp2DataSet.funcionario' table. You can move, or remove it, as needed.
            tbl_MoveisTableAdapter.Fill(lP2DataSet1.tbl_Moveis);
        }

        private void HabilitaCampos(Control container, bool hab)
        {
            foreach (Control campo in container.Controls)
            {
                if (!(campo is Label))
                {
                    campo.Enabled = hab;
                }
            }
        }

        private void HabilitaBotoes(Control container, bool hab)
        {
            foreach (Control componente in container.Controls)
            {
                if (componente is Button)
                {
                    componente.Enabled = hab;
                    if (componente.Name == "btnGravar" || componente.Name == "btnCancelar")
                    {
                        componente.Enabled = !hab;
                    }
                }
            }
        }

        private void LimpaCampos(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is MaskedTextBox)
                {
                    ((MaskedTextBox)control).Clear();
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif|Todos os arquivos|*.*";
            pcbFoto.SizeMode = PictureBoxSizeMode.Zoom;


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Atualize o PictureBox com a imagem selecionada
                pcbFoto.Image = Image.FromFile(openFileDialog.FileName);
            }
            caminhoImagem = openFileDialog.FileName;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            HabilitaCampos(grpCampos, true);
            HabilitaBotoes(this, false);
            incluir = true;
            txtId.Enabled = false;
            txtNome.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitaCampos(grpCampos, false);
            HabilitaBotoes(this, true);
            LimpaCampos(grpCampos);
            //btnEditar.Text = "&Editar";
            //btnApagar.Text = "&Apagar";
            incluir = false;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (incluir)
                {
                    tbl_MoveisTableAdapter.Insert(txtNome.Text, txtModelo.Text, Int32.Parse(txtPeso.Text), 
                        dtpDataCadastro.Value, caminhoImagem);
                    MessageBox.Show("Incluido com sucesso!", Application.ProductName,
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tbl_MoveisTableAdapter.Update(txtNome.Text, txtModelo.Text, Int32.Parse(txtPeso.Text),
                        dtpDataCadastro.Value, caminhoImagem, Int32.Parse(txtId.Text));
                    MessageBox.Show("Alterado com sucesso!", Application.ProductName,
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                FrmMoveis_Load(null, null);
                btnCancelar_Click(null, null);
                pcbFoto.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMovel.SelectedRows.Count > 0)
                {
                    HabilitaBotoes(this, false);
                    HabilitaCampos(grpCampos, true);
                    txtId.Enabled = false;
                    txtNome.Focus();

                    // Lendo os dados do dgvFuncionario
                    int linha = dgvMovel.CurrentRow.Index;
                    txtId.Text = dgvMovel[0, linha].Value.ToString();
                    txtNome.Text = dgvMovel[1, linha].Value.ToString();
                    txtModelo.Text = dgvMovel[2, linha].Value.ToString();
                    txtPeso.Text = dgvMovel[3, linha].Value.ToString();
                    dtpDataCadastro.Value = (DateTime)dgvMovel[4, linha].Value;
                }
                else
                {
                    MessageBox.Show("Selecione um móvel primeiro!", "Erro:",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pcbFoto.Image = null;
        }

        private void FrmMoveis_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMovel.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Deseja mesmo excluir o móvel selecionado?",
                        "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        tbl_MoveisTableAdapter.Delete(Int32.Parse(dgvMovel[0, dgvMovel.CurrentRow.Index].Value.ToString()));
                        FrmMoveis_Load(null, null);
                        MessageBox.Show("Móvel excluido com sucesso!", "Excluir:",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um móvel primeiro!", "Erro ao excluir:",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNome.Enabled == false)
            {
                txtNome.Enabled = true;
                txtNome.Focus();
                HabilitaBotoes(this, false);
                btnPesquisar.Enabled = true;
                btnGravar.Enabled = false;
                MessageBox.Show("Digite o nome ou parte do nome do " +
                    "móvel a ser pesquisado.", "Pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tbl_MoveisTableAdapter.FillByNome(lP2DataSet1.tbl_Moveis,
                    "%" + txtNome.Text + "%");
                btnCancelar_Click(null, null);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            FrmMoveis_Load(null, null);
            btnCancelar_Click(null, null);
        }
    }
}
