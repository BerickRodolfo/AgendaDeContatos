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
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int flag = 0;
            FormCadastro f = new FormCadastro(flag);
            f.ShowDialog();
            f.Dispose();
        }

        


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TISG95H\SQLEXPRESS;Initial Catalog=Agenda;Integrated Security=True");
        SqlDataAdapter adpt;
        DataTable dt;


        public void Listar()
        {


            con.Open();
            adpt = new SqlDataAdapter(" Select dbo.Cliente.cliente_cod, dbo.Categoria.nome_categoria, dbo.Cliente.cliente_nome, dbo.Cliente.cliente_email, dbo.Cliente.cliente_tel," +
                "case WHEN dbo.Cliente.cliente_ativo = 0 then 'Não é Ativo' ELSE 'É Ativo' END As Status from dbo.Cliente " +
                "INNER JOIN dbo.Categoria ON dbo.Cliente.cliente_categoria = dbo.Categoria.id_categoria", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGrid1.DataSource = dt;
            con.Close();


        }

            
        public void Editar()
        {

            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();

            editButton.FlatStyle = FlatStyle.Standard;

            editButton.HeaderText = "Editar";
            editButton.Name = "Editar";
            editButton.UseColumnTextForButtonValue = true;
            editButton.Text = "Editar";

            editButton.Width = 80;


            if (dataGrid1.Columns.Contains(editButton.HeaderText = "Editar"))
            {
                dataGrid1.Columns["Email"].DisplayIndex = 3;
                dataGrid1.Columns["Categoria"].DisplayIndex = 4;
                dataGrid1.Columns["Status"].DisplayIndex = 5;
                dataGrid1.Columns["Editar"].DisplayIndex = 6;
            }
            else
            {
                dataGrid1.Columns.Add(editButton);

            }

            

        }

            private void btnSearch_Click(object sender, EventArgs e)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TISG95H\SQLEXPRESS;Initial Catalog=Agenda;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("Select dbo.Cliente.cliente_cod, dbo.Categoria.nome_categoria, dbo.Cliente.cliente_nome, dbo.Cliente.cliente_email, dbo.Cliente.cliente_tel," +
                "case WHEN dbo.Cliente.cliente_ativo = 0 then 'Não é Ativo' ELSE 'É Ativo' END As Status from dbo.Cliente " +
                "INNER JOIN dbo.Categoria ON dbo.Cliente.cliente_categoria = dbo.Categoria.id_categoria WHERE cliente_nome = @nome " +
                    "OR cliente_categoria = @categoria", con);
                cmd.Parameters.AddWithValue("@nome", nomeText.Text);
                cmd.Parameters.AddWithValue("@categoria", comboBox1.SelectedIndex);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGrid1.DataSource = dt;


            Editar();


            }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Editar();
        }

      


        private void dataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                var row = dataGrid1.CurrentRow;
                int id_cliente = Int32.Parse(row.Cells[1].Value.ToString());
                FormCadastro f = new FormCadastro(id_cliente) ;

                f.ShowDialog();
                f.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listar();
            Editar();
        }
    }

    }




