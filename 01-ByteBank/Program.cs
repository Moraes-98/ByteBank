using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Byte Bank");

            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 863;
            contaGabriela.numero = 863146;
            contaGabriela.saldo = 100;
            Console.WriteLine("Titular: " + contaGabriela.titular);
            Console.WriteLine("Agência: " + contaGabriela.agencia);
            Console.WriteLine("Número: " + contaGabriela.numero);
            Console.WriteLine("Saldo: " + contaGabriela.saldo);

            contaGabriela.saldo += 200;
            Console.WriteLine("Saldo: " + contaGabriela.saldo);

            /*      Forma Errado de se fazer
            string titular = "Gabriela";
            int numeroAgencia = 863;
            int numero = 863146;
            double saldo = 100;

            string titular2 = "Bruno";
            int numeroAgencia2 = 863;
            int numero2 = 864;
            double saldo2 = 50;
            */


            Console.ReadLine();
        }
    }
}