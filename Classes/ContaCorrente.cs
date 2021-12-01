namespace BankSystemCsharp.Classes
{
    // Herdando a classe abstrata Conta
    // Inheriting the Account abstract class
    public class ContaCorrente : Conta
    {
        public ContaCorrente()
        {
            this._NumeroConta = "00" + Conta.NumeroContaSequencial;
            // Ao instanciar o objeto da classe ContaCorrente
            // O número da conta corrente criada vai ser 00 + o total de contas criadas

            // When instantiating the object of the ContaCorrente class
            // The number of the created checking account will be 00 + the total of created accounts
        }
    }
}