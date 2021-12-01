using System.Collections.Generic; // Required to implement List <>
using BankSystemCsharp.Classes;
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
        List <Extrato> GetExtrato(); 
        // Declarando o contrato GetExtrato para as classes herdeiras
        // Declaring the GetExtrato Contract for Inherit Classes
    }

    // Criando os contratos
    // Creating the contracts
}