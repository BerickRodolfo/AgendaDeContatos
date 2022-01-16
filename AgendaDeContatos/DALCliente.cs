using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AgendaDeContatos
{
    internal class DALCliente
    {
        private Conexao objConexao;

        public DALCliente(Conexao conexao)
        {
            objConexao = conexao;
        }

        //Ao executar o método incluir que recebe um objeto do tipo Cliente
        //o CommandText irá ser executado para capturar as informações e inserir no banco de dados
        //Inicia-se uma conexão para executar os comandos no banco de dados.
        public void Incluir(Cliente cliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "insert into cliente(cliente_nome, " +
                "cliente_categoria, cliente_email, cliente_tel, cliente_ativo)" + 
                "values (@nome, @categoria, @email, @telefone, @ativo); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@categoria", cliente.Categoria);
            cmd.Parameters.AddWithValue("@email", cliente.Email);
            cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
            cmd.Parameters.AddWithValue("@ativo", cliente.Ativo);
            objConexao.Conectar();
            cliente.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void Alterar(Cliente cliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "update cliente set cliente_nome = @nome, " +
                "cliente_email = @email, cliente_tel = @telefone, cliente_categoria = @categoria," +
                "cliente_ativo = @ativo where cliente_cod = @codigo";
            cmd.Parameters.AddWithValue("@nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@categoria", cliente.Categoria);
            cmd.Parameters.AddWithValue("@email", cliente.Email);
            cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
            cmd.Parameters.AddWithValue("@ativo", cliente.Ativo);
            cmd.Parameters.AddWithValue("@codigo", cliente.Codigo);
            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();
        }

        public void Excluir(Cliente cliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "delete from cliente where cliente_cod = @cod";
            cmd.Parameters.AddWithValue("@cod", cliente.Codigo);
            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();
        }

        



    }
}
