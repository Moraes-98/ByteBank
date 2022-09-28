
namespace ProjetoByteBank
{
    public class ContaCorrente
    {
        public static int QuantidadeContas { get; private set; }
        

        //Conta:                                   
        public Cliente Titular { get; set; } 
        public ClassEndereco Endereco { get; set; } 


        private int _agencia;
        public int Agencia 
        {
            get
            {
                return _agencia;
            } 
            set
            {
                if(value <= 0)
                {
                    return;
                }
                _agencia = value;
            }
        }
        public int Numero { get; set; }


        private double _saldo;
        public double Saldo
        {
            get //Obter
            {
                return _saldo;
            }
            set //Definir
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        private double poupanca;
        public double Poupanca
        {
            get
            {
                return poupanca;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                poupanca = value;
            }
        }



        //Fator de Rendimento da Poupança:
        double fatorRendimento = 1.0036;
        double acrescimoRendimentoAno = 0.0010;


        


        //Saque:
        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            return true;

        }
        

        //Depósito:
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }


        //Transferência
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this.Sacar(valor);
            contaDestino.Depositar(valor);
            return true;

        }


        //Poupança
        public void VerificarPoupanca(double verificacaoPorAno)
        {
            for (int contadorAno = 1; contadorAno <= verificacaoPorAno; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    this.poupanca *= fatorRendimento;
                }
                
                fatorRendimento += acrescimoRendimentoAno;
            }
        }




        public ContaCorrente(Cliente titular, ClassEndereco endereco, int agencia, int numero, double saldo, double poupanca)
        {
            Titular = titular;
            Endereco = endereco;
            Agencia = agencia;
            Numero = numero;
            Saldo = saldo;
            Poupanca = poupanca;

            QuantidadeContas++;
        }
    }
}