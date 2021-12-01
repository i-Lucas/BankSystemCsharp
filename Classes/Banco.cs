namespace BankSystemCsharp.Classes
{
    public abstract class Banco
    {
        public Banco() // Construtor - Constructor
        {
            this.NomeDoBanco = "GitHub Bank";  // Setando valores padrão
            this.CodigoDoBanco = "0227";        // Setting default values
        }
        // Contratos
        public string NomeDoBanco{get; private set;}
        public string CodigoDoBanco{get; private set;}
    }
}