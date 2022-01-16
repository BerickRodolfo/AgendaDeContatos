using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaDeContatos
{


    public partial class FormCadastro : Form
    {

        public int idCliente 
        { get; set; }
        

        public FormCadastro(int linha)
        {
            InitializeComponent();
            idCliente = linha;
            
        }


        public void MostrarExcluir(bool isEditing)
        {
            btnExcluir.Visible = isEditing;
        }

        public void LimpaCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTel.Clear();
            txtCombo.Text = "Categoria";
            txtCheck.Checked = false;
            idCliente = 0;
           
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TISG95H\SQLEXPRESS;Initial Catalog=Agenda;Integrated Security=True");

        SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand cmd;

        private void FormCadastro_Load(object sender, EventArgs e)
        {

            if(idCliente > 0)
            {
                this.MostrarExcluir(true);
                Mostrar();
            }
            else
            {
                this.MostrarExcluir(false);
            }


        }

        private void Mostrar()
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = ("Select dbo.Cliente.cliente_ativo, dbo.Categoria.nome_categoria, dbo.Cliente.cliente_nome, dbo.Cliente.cliente_email, dbo.Cliente.cliente_tel " +
                "from dbo.Cliente INNER JOIN dbo.Categoria ON dbo.Cliente.cliente_categoria = dbo.Categoria.id_categoria WHERE cliente_cod = @codigo;");
            cmd.Parameters.AddWithValue("@codigo", idCliente);

            adpt = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adpt.Fill(dt);
            con.Close();

            txtNome.Text = dt.Rows[0]["cliente_nome"].ToString();
            txtEmail.Text = dt.Rows[0]["cliente_email"].ToString();
            txtTel.Text = dt.Rows[0]["cliente_tel"].ToString();
            txtCombo.Text = dt.Rows[0]["nome_categoria"].ToString();
            
            string ativo = dt.Rows[0]["cliente_ativo"].ToString();


            if(ativo == "1")
            {
                txtCheck.CheckState = CheckState.Checked;
            }


           
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            this.LimpaCampos();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if(idCliente > 0)
            {
                Alterar();
            }
            else
            {
                Criar();
            }
        }

        private void Criar()
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Email = txtEmail.Text;
            cliente.Telefone = txtTel.Text;
            cliente.Categoria = txtCombo.SelectedIndex;
            cliente.Ativo = txtCheck.Checked;

            if (cliente.Nome == "")
            {
                MessageBox.Show("É necessário que o Cliente informe seu nome para prosseguir com o cadastro");
                this.Close();
            }

            else
            {

                //Conexão com o Banco de Dados
                String strconexao = @"Data Source=DESKTOP-TISG95H\SQLEXPRESS;Initial Catalog=Agenda;Integrated Security=True";
                Conexao conexao = new Conexao(strconexao);
                DALCliente dal = new DALCliente(conexao);

                dal.Incluir(cliente);
                MessageBox.Show("Cliente Cadastrado com sucesso");
                MessageBox.Show("O código deste cliente é " + cliente.Codigo.ToString());
            }
        }

        private void Alterar()
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Email = txtEmail.Text;
            cliente.Telefone = txtTel.Text;
            cliente.Categoria = txtCombo.SelectedIndex;
            cliente.Ativo = txtCheck.Checked;
            cliente.Codigo = idCliente;

            if (cliente.Nome == "")
            {
                MessageBox.Show("É necessário que o Cliente informe seu nome para prosseguir com a edição");
                this.Close();
            }

            else
            {

                //Conexão com o Banco de Dados
                String strconexao = @"Data Source=DESKTOP-TISG95H\SQLEXPRESS;Initial Catalog=Agenda;Integrated Security=True";
                Conexao conexao = new Conexao(strconexao);
                DALCliente dal = new DALCliente(conexao);

                dal.Alterar(cliente);
                MessageBox.Show("Cliente Atualizado com Sucesso");
                MessageBox.Show("O código deste cliente permanece o mesmo que é : " + cliente.Codigo.ToString());

            }
        }

        public void Excluir()
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Email = txtEmail.Text;
            cliente.Telefone = txtTel.Text;
            cliente.Categoria = txtCombo.SelectedIndex;
            cliente.Ativo = txtCheck.Checked;
            cliente.Codigo = idCliente;

            //Conexão com o Banco de Dados
            String strconexao = @"Data Source=DESKTOP-TISG95H\SQLEXPRESS;Initial Catalog=Agenda;Integrated Security=True";
            Conexao conexao = new Conexao(strconexao);
            DALCliente dal = new DALCliente(conexao);

            dal.Excluir(cliente);
            MessageBox.Show("Cliente Excluído com Sucesso");
   
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
            this.Close();
        }
    }
}   
