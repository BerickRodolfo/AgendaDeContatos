using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaDeContatos
{
    public class Cliente
    {

        public Cliente()
        {
            this.Codigo = 0;
            this.Nome = "";
            this.Categoria = 0;
            this.Email = "";
            this.Telefone = "";
            this.Ativo = false;
        }

        public Cliente(int codigo, string nome, int categoria, string email, string telefone, bool ativo)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Categoria = categoria;
            this.Email = email;
            this.Telefone = telefone;
            this.Ativo = ativo;
        }


        private int cliente_cod;

        public int Codigo
        {
            get { return cliente_cod; }
            set { cliente_cod = value; }
        }

        private string cliente_nome;

        public String Nome
        {
            get { return cliente_nome; }
            set { cliente_nome = value; }
        }

        private int cliente_categoria;

        public int Categoria
        {
            get { return cliente_categoria; }
            set { cliente_categoria = value; }
        }

        private string cliente_email;

        public String Email
        {
            get { return cliente_email; }
            set { cliente_email = value; }
        }

        private string cliente_telefone;

        public String Telefone
        {
            get { return cliente_telefone; }
            set { cliente_telefone = value; }
        }

        public bool cliente_ativo;

        public bool Ativo
        {
            get { return cliente_ativo; }
            set { cliente_ativo = value; }
        }
    }
}
