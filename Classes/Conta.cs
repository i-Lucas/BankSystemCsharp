using System.Collections.Generic; // Required to implement List <>
using BankSystemCsharp.Contratos; // Implementing the library for interface IConta
using System; // Required to implement DateTime
namespace BankSystemCsharp.Classes
{
    // Herdando classe banco - Inheriting bank class
    // Implementing IConta Interface
    public abstract class Conta : Banco, IConta
    {
        public Conta() // Constructor
        {
            this._NumeroAgencia = "0001"; // Setting default values
            Conta.NumeroContaSequencial++;
            // A cada objeto instanciado o atributo estático da classe somará 1
            // For each object instantiated, the static attribute of the class will add 1

            this.Movimentacoes = new List<Extrato>();
            // A cada objeto instanciado vai criar uma lista de movimentações vazia
            // Each instantiated object will create an empty movement list
        }
        //Attributes
        public double _Saldo { get; protected set; }
        public string _NumeroAgencia { get; private set; }
        public string _NumeroConta { get; protected set; }
        public static int NumeroContaSequencial { get; private set; }
        // Atributo estático da classe ( não acessível aos objetos )
        // Static attribute of the class (not accessible to objects)

        private List<Extrato> Movimentacoes;
        // Declarando a lista movimentações
        // Declaring the list of moves

        // Methods - Implementing contracts
        public double ConsultarSaldo()
        {
            return this._Saldo;
        }
        public void Depositar(double valor)
        {
            DateTime dataAtual = DateTime.Now; // Get the current date
            this.Movimentacoes.Add(new Extrato(dataAtual, "DEPÓSITO", valor)); 
            // Adciona um novo item na lista passando os parâmetros
            // Add a new item to the list by passing the parameters
            this._Saldo += valor;
        }
        public bool Sacar(double valor)
        {
            if(valor > this.ConsultarSaldo())
            return false;

            DateTime dataAtual = DateTime.Now; // Get the current date
            this.Movimentacoes.Add(new Extrato(dataAtual, "SAQUE", - valor)); 
            // Adciona um novo item na lista passando os parâmetros
            // Add a new item to the list by passing the parameters 
            this._Saldo -= valor;
            return true;
        }
        public string GetCodigoBanco()
        {
            return this.CodigoDoBanco;
            // CodigoDoBanco definido da classe Banco ( usando o get )
            // CodigoDoBanco set of class Banco ( using get )
        }
        public string GetNumeroAgencia()
        {
            return this._NumeroAgencia;
            // Atributo ( contrato ) da classe Conta
            // Attribute ( contract ) of the Conta class
        }
        public string GetNumeroConta()
        {
            return this._NumeroConta;
            // Atributo ( contrato ) da classe Conta
            // Attribute ( contract ) of the Conta class
        }

        // Implementando o contrato List Extrato
        // Implementing the List Extract contract
        public List<Extrato> GetExtrato()
        {
            return this.Movimentacoes;
            // Retorna a lista movimentações
            // Return to list of moves
        }
    }
}