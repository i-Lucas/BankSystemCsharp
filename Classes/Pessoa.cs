using BankSystemCsharp.Contratos; // Implementing the library for interface IConta

namespace BankSystemCsharp.Classes
{
    public class Pessoa
    {
        // Atributos - Attributes
        public string nomeUsuario { get; private set; }
        public string cpfUsuario { get; private set; }
        public string senhaUsuario { get; private set; }
        public IConta ContaUsuario { get; set; }
        // ( Agregação ) propiedade da interface ( acesso a todos os contratos e métodos )
        // ( Aggregation ) interface property ( access to all contracts and methods )

        // Métodos - Methods
        public void SetNome(string nome)
        {
            this.nomeUsuario = nome;
        }
        public void SetCpf(string cpf) // Parâmetro - Parameter
        {
            this.cpfUsuario = cpf;
            // Atribuindo valor no atributo
            // Assigning attribute value
        }
        public void SetSenha(string senha)
        {
            this.senhaUsuario = senha;
        }
    }
}
