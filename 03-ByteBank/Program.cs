using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Byte Bank 3");

            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 863;
            contaGabriela.numero = 863154;

            ContaCorrente contaGabrielaCosta = new ContaCorrente();
            contaGabrielaCosta.titular = "Gabriela";
            contaGabrielaCosta.agencia = 863;
            contaGabrielaCosta.numero = 863154;

            Console.WriteLine(contaGabriela == contaGabrielaCosta);         //igualdade de tipo de referência (Aponta para objetos diferentes
                                                                            //da memória, por isso é falso)


            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine(idade == idadeMaisUmaVez);                    //igualdade de tipo de valor


            contaGabriela = contaGabrielaCosta;
            Console.WriteLine(contaGabriela == contaGabrielaCosta);         //igualdade de tipo de referência (Aponta para o mesmo objeto na memória,
                                                                            //por isso é verdadeiro)


            contaGabriela.saldo = 300;
            Console.WriteLine(contaGabriela.saldo);
            Console.WriteLine(contaGabrielaCosta.saldo);                    // O Valor é o mesmo pois a cima a contaGabriela recebeu o valor de 
                                                                            // contaGabrielaCosta, fazendo as duas referencias apontar pro mesmo objeto,
                                                                            //Se o Objeto for alterado, é alterado para as duas referencias, 
                                                                            //pois elas falam da mesma coisa

            Console.ReadLine();
        }
    }
}