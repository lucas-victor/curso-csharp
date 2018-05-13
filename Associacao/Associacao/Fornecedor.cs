using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associacao
{
    class Fornecedor
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }

        public Fornecedor(string nome, string email, string telefone) {
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;

        }

        public Fornecedor(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
            this.telefone = "0000-0000";

        }

        public override string ToString()
        {
            return nome
                + ", Email: "
                + email
                + ", Telefone: "
                + telefone
                ;//*/
        }

    }
}
