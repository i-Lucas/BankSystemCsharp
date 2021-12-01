namespace BankSystemCsharp.Contratos
{
    public interface IConta
    {
        void Depositar(double valor);
        bool Sacar(double valor);
        double ConsultarSaldo();
        string GetCodigoBanco();
        string GetNumeroAgencia();
        string GetNumeroConta();
    }

    // Criando os contratos
    // Creating the contracts
}