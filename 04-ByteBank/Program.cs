using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoByteBank
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Byte Bank.\n");
            
            
            //Informações da Conta: (772/996)
            _568996 nConta = new _568996();

            Cliente cliente = new Cliente (nConta.Nome, nConta.CPF, nConta.Profissao );
            ClassEndereco endereco = new ClassEndereco(nConta.Endereco, nConta.Bairro, nConta.Cidade);
            ContaCorrente conta = new ContaCorrente(cliente , endereco, nConta.Agencia, nConta.Numero, nConta.Saldo, nConta.Poupanca);

            Console.WriteLine(
                "Nome: " + conta.Titular.Nome + "\n" +
                "CPF: " + conta.Titular.CPF + "\n" +
                "Profissão: " + conta.Titular.Profissao + "\n\n" +
                "Agência: " + conta.Agencia + "\n" +
                "Número da Conta: " + conta.Numero + "\n" +
                "Saldo: " + conta.Saldo + "\n" +
                "Poupança/Investimento: " + conta.Poupanca + "\n\n" +
                "Endereço: " + conta.Endereco.Endereco + "\n" +
                "Bairro: " + conta.Endereco.Bairro + "\n" +
                "Cidade: " + conta.Endereco.Cidade + "\n" +
                "\n\n\n\nTecle Enter para continuar");
            Console.ReadLine();



            //Ações:
                //Ação do Banco: Ver total de contas criadas
            bool quantContas = false;           //Feito mais por conta da aula, para aprender o "static" que mantém a informação em conjunto com a classe

                //Saque
            double valorSaque = 0;
                
                //Depósito
            double valorDeposito = 0;
                
                //Transferência
            double valorTransferencia = 0;
            _568772 numTransf = new _568772();
            Cliente clienteTransf = new Cliente(numTransf.Nome, numTransf.CPF, numTransf.Profissao);
            ClassEndereco enderTransf = new ClassEndereco(numTransf.Endereco, numTransf.Bairro, numTransf.Cidade);
            ContaCorrente contaTransf = new ContaCorrente(clienteTransf, enderTransf, 
                numTransf.Agencia, numTransf.Numero, numTransf.Saldo, numTransf.Poupanca);

                //Cálculo de crescimento da Poupança por ano
            int verificacaoPorAno = 0;


       

            ////////////////////////////////////////////////////////
            // Informações na tela.

                //Saque:                                                !!!!!!!!Deixar mais simplificado como o de transferência.!!!!!!!
            if (valorSaque > 0)
            {
                bool resultadoSaque = conta.Sacar(valorSaque);
                if (resultadoSaque == true)
                {      
                    Console.WriteLine("Seu saque foi permitido.\nVocê sacou o valor de: R$" + valorSaque + ".\n" +
                        "E ficou com o valor de: R$" + conta.Saldo + ".");
                }
                else
                {
                    Console.WriteLine("Desculpe!\nSeu saque foi negado, parece que seu saldo é insuficiente.\n" +
                        "O valor na sua conta é de: R$" + conta.Saldo + ".\nE você tentou sacar: R$" + valorSaque + ".");
                }
            }


                //Deposito:
            if (valorDeposito > 0)
            {
                conta.Depositar(valorDeposito);
                Console.WriteLine("Foi depositado o valor de: R$" + valorDeposito + ".\n" +
                    "Ficando com um saldo de: R$" + conta.Saldo + ".");
            }


                //Transferência:
            if(valorTransferencia > 0)
            {
                bool resultadoTransf = conta.Transferir(valorTransferencia,contaTransf);
                if (resultadoTransf == true)
                {
                    Console.WriteLine("Sua transferência foi realizada com sucesso.\n" +
                        "De " + conta.Titular.Nome + " para " + contaTransf.Titular.Nome + ".\n" +
                        "Valor de: R$" + valorTransferencia + ".\n" +
                        "Saldo atual: R$" + conta.Saldo + ".");
                }
                else
                {
                    Console.WriteLine("Houve um problema com sua transferência.\n" +
                        "Seu saldo é insuficiente.");
                }
            }


                //Poupança/Investimento:
            if(verificacaoPorAno > 0)
            {
                conta.VerificarPoupanca(verificacaoPorAno);
                Console.WriteLine("Seu investimeto renderá, num período de " + 
                    verificacaoPorAno + " anos, o valor de: " + conta.Poupanca);
            }

                //Quantidade de Contas:
            if(quantContas == false)
            {
                
            }
            else
            {
                Console.WriteLine(ContaCorrente.QuantidadeContas);
            }
            
            Console.ReadLine();
        }
    }
}