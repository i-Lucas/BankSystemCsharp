using BankSystemCsharp.Contratos;

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
        }
        //Attributes
        public double _Saldo { get; protected set; }
        public string _NumeroAgencia { get; private set; }
        public string _NumeroConta { get; protected set; }
        public static int NumeroContaSequencial { get; private set; }
        // Atributo estático da classe ( não acessível aos objetos )
        // Static attribute of the class (not accessible to objects)

        // Methods - Implementing contracts
        public double ConsultarSaldo()
        {
            return this._Saldo;
        }
        public void Depositar(double valor)
        {
            this._Saldo += valor;
        }
        public bool Sacar(double valor)
        {
            if (valor > this.ConsultarSaldo())
                return false;
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
    }
}