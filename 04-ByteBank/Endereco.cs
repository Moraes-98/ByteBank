using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoByteBank
{
    public class ClassEndereco
    {
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }

        public ClassEndereco(string endereco, string bairro, string cidade)
        {
            Endereco = endereco;
            Bairro = bairro;
            Cidade = cidade;
        }
    }
}
