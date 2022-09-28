using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Byte Bank 2");

            ContaCorrente conta = new ContaCorrente();

            Console.WriteLine(conta.saldo);

            conta.saldo += 175;

            Console.WriteLine(conta.saldo);

            Console.ReadLine();
        }
    }
}