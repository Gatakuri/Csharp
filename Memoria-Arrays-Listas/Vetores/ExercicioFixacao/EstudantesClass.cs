using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Vetores {
    internal class Estudantes {

        public string email {  get; set; }
        public string nome { get; set; }

        public Estudantes(string email, string nome) {
            this.email = email;
            this.nome = nome;
        }

        public override string ToString() {
            return email + ", " + nome;
        }
    }
}
