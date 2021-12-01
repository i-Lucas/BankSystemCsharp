using System.Collections.Generic; // Required to implement List <>
using System.Linq; // Required to implement FirstOrDefault <>
using System.Threading; // Required to implement Thread.Sleep
using System;

namespace BankSystemCsharp.Classes
{
    public class Layout
    {
        private static List<Pessoa> pessoas = new List<Pessoa>();
        // Armazenar as contas criadas localmente em lista ( tipo um array )
        // Store accounts created locally in list ( type an array )
        private static int opcao = 0;
        public static void TelaPrincipal()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("==============================================================================");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                         DIGITE A OPÇÃO DESEJADA:                             ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("==============================================================================");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                         1 - CRIAR CONTA                                      ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                         2 - ENTRAR COM CPF E SENHA                           ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                         3 - SAIR                                             ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("==============================================================================");

            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    TelaCriarConta();
                    break;
                case 2:
                    TelaLogin();
                    break;
                case 3:
                    Console.WriteLine("Invalid option, you cannot exit my program!");
                    // TelaPrincipal();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("==============================================================================");
                    Console.WriteLine("                                                                              ");
                    Console.WriteLine("                            OPÇÃO INVÁLIDA !                                  ");
                    Console.WriteLine("                                                                              ");
                    Console.WriteLine("==============================================================================");
                    break;
            }
        }
        private static void TelaCriarConta()
        {
            Console.Clear();
            Console.WriteLine("==============================================================================");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                             DIGITE SEU NOME:                                 ");
            string obterNome = Console.ReadLine();
            Console.WriteLine("==============================================================================");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                             DIGITE O CPF:                                    ");
            string obterCpf = Console.ReadLine();
            Console.WriteLine("==============================================================================");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                             DIGITE SUA SENHA:                                ");
            string obterSenha = Console.ReadLine();
            Console.WriteLine("==============================================================================");

            // Criando contas - Creating accounts

            ContaCorrente cc = new ContaCorrente();
            // Instanciando o objeto da classe ContaCorrente
            // Instantiating the object of the ContaCorrente class

            Pessoa cliente = new Pessoa();
            // Instanciando o objeto da classe Pessoas
            // Instantiating the People class object

            cliente.SetNome(obterNome);
            cliente.SetCpf(obterCpf);
            cliente.SetSenha(obterSenha);
            // Passando as informações obtidas para o objeto 
            // Passing the obtained information to the object

            cliente.ContaUsuario = cc;
            // Agregando a classe Pessoa com a classe Conta ( herança de interface )
            // Criando uma conta corrente vinculando a pessoa através da agregação

            // Aggregating the Person class with the Account class (interface inheritance)
            // Creating a checking account linking the person through aggregation

            pessoas.Add(cliente);
            // Adcionando o objeto na lista pessoas
            // Adding the object to the people list

            Console.Clear();
            Console.WriteLine("==============================================================================");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                     CONTA CADASTRADA COM SUCESSO !                           ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("==============================================================================");

            Thread.Sleep(1500);
            // Esperar 1.5 segundo até chamar a função abaixo
            // Wait 1.5 seconds to call the function below
            TelaContaLogada(cliente);
        }
        private static void TelaLogin()
        {
            Console.Clear();
            Console.WriteLine("==============================================================================");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                             DIGITE SEU CPF:                                  ");
            string obterCpf = Console.ReadLine();
            Console.WriteLine("==============================================================================");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                             DIGITE SUA SENHA:                                ");
            string obterSenha = Console.ReadLine();
            Console.WriteLine("==============================================================================");

            Pessoa pessoa = pessoas.FirstOrDefault(x => x.cpfUsuario == obterCpf && x.senhaUsuario == obterSenha);
            // Verificando os dados da pessoa da lista para retornar se existe ou não
            // Checking the person's data on the list to return whether or not it exists

            if (pessoa != null)
            {
                TelaContaLogada(pessoa);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("==============================================================================");
                Console.WriteLine("                                                                              ");
                Console.WriteLine("                     CONTA NÃO CADASTRADA NO SISTEMA!                         ");
                Console.WriteLine("                                                                              ");
                Console.WriteLine("==============================================================================");
            }
        }
        private static void TelaContaLogada(Pessoa pessoa)
        {
            Console.Clear();
            TelaBoasVindas(pessoa);

            Console.WriteLine("==============================================================================");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                         DIGITE A OPÇÃO DESEJADA:                             ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("==============================================================================");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                         1 - REALIZAR DEPÓSITO                                ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                         2 - REALIZAR SAQUE                                   ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                         3 - CONSULTAR SALDO                                  ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                         4 - CONSULTAR EXTRATO                                ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                         5 - SAIR                                             ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("==============================================================================");

            opcao = int.Parse(Console.ReadLine());
            // Armazenar a opção digitada e jogar na variável opcao convertida em Int
            // Store the typed option and put it in the option variable converted to Int

            switch (opcao)
            {
                case 1:
                    TelaDeposito(pessoa);
                    break;
                case 2:
                    TelaSaque(pessoa);
                    break;
                case 3:
                    TelaSaldo(pessoa);
                    break;
                case 4:
                    TelaExtrato(pessoa);
                    break;
                case 5:
                    OpcaoVoltarDeslogado();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("==============================================================================");
                    Console.WriteLine("                                                                              ");
                    Console.WriteLine("                            OPÇÃO INVÁLIDA !                                  ");
                    Console.WriteLine("                                                                              ");
                    Console.WriteLine("==============================================================================");
                    break;
            }
        }
        private static void TelaDeposito(Pessoa pessoa)
        {
            Console.Clear();
            TelaBoasVindas(pessoa);
            Console.WriteLine("==============================================================================");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                         DIGITE O VALOR DO DEPÓSITO:                          ");
            double obterValor = double.Parse(Console.ReadLine());
            Console.WriteLine("                                                                              ");
            Console.WriteLine("==============================================================================");

            pessoa.ContaUsuario.Depositar(obterValor);
            Console.Clear();
            TelaBoasVindas(pessoa);

            Console.WriteLine("==============================================================================");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                     DEPÓSITO REALIZADO COM SUCESSO !                         ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("==============================================================================");

            Thread.Sleep(1500);
            // Esperar 1.5 segundo até chamar a função abaixo
            // Wait 1.5 seconds to call the function below
            OpcaoVoltarLogado(pessoa);
        }
        private static void TelaSaque(Pessoa pessoa)
        {
            Console.Clear();
            TelaBoasVindas(pessoa);
            Console.WriteLine("==============================================================================");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                         DIGITE O VALOR DO SAQUE:                             ");
            double obterValor = double.Parse(Console.ReadLine());
            Console.WriteLine("                                                                              ");
            Console.WriteLine("==============================================================================");

            bool saqueLiberado = pessoa.ContaUsuario.Sacar(obterValor);
            // Retorna true ou false - Returns true or false
            // Caso o valor seja menor que o saldo retorna true e efetua a operação
            // If the value is less than the balance, it returns true and performs the operation

            Console.Clear();
            TelaBoasVindas(pessoa);

            if (saqueLiberado)
            {
                Console.WriteLine("==============================================================================");
                Console.WriteLine("                                                                              ");
                Console.WriteLine("                         SAQUE REALIZADO COM SUCESSO !                        ");
                Console.WriteLine("                                                                              ");
                Console.WriteLine("==============================================================================");
            }
            else
            {
                Console.WriteLine("==============================================================================");
                Console.WriteLine("                                                                              ");
                Console.WriteLine("                             SALDO INSUFICIENTE !                             ");
                Console.WriteLine("                                                                              ");
                Console.WriteLine("==============================================================================");
            }
            Thread.Sleep(1500);
            OpcaoVoltarLogado(pessoa);
        }
        private static void TelaSaldo(Pessoa pessoa)
        {
            Console.Clear();
            TelaBoasVindas(pessoa);
            Console.WriteLine("==============================================================================");
            Console.WriteLine("                                                                              ");
            Console.WriteLine($"                            SEU SALDO É R$: {pessoa.ContaUsuario.ConsultarSaldo()}");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("==============================================================================");

            Thread.Sleep(2000);
            OpcaoVoltarLogado(pessoa);
        }
        private static void TelaExtrato(Pessoa pessoa)
        {
            Console.Clear();
            TelaBoasVindas(pessoa);
            // Verifica se há algo dentro de Extrato - Check if there is something inside the Extract
            if (pessoa.ContaUsuario.GetExtrato().Any())
            {
                // Obter total do extrato - Get statement total
                double total = pessoa.ContaUsuario.GetExtrato().Sum(x => x._ExtratoValor);
                // Função Sum() somará todo valor do extrato - Sum() function will sum all extract value

                Console.WriteLine("==============================================================================");
                Console.WriteLine("                                                                              ");
                Console.WriteLine("                             SEU EXTRATO:                                     ");
                Console.WriteLine("                                                                              ");

                // Fazendo uma varredura na lista movimentacoes (GetExtrato ) e armazenando na lista Extrato
                // Scanning the movement list (GetExtrato ) and storing it in the Extract list
                foreach (Extrato extrato in pessoa.ContaUsuario.GetExtrato())
                {
                    Console.WriteLine("                                                                                     ");
                    Console.WriteLine($"               DATA DA MOVIMENTAÇÃO: {extrato._Data.ToString("dd/MM/yyyy HH:mm:ss")}");
                    Console.WriteLine($"               TIPO DE MOVIMENTAÇÃO: {extrato._Descricao}                           ");
                    Console.WriteLine($"               VALOR R$: {extrato._ExtratoValor}                                    ");
                    Console.WriteLine("                                                                                     ");
                }
                Console.WriteLine("                                                                              ");
                Console.WriteLine($"               SUBTOTAL R$: {total}                                          ");
                Console.WriteLine("                                                                              ");
                Console.WriteLine("==============================================================================");
            }
            else
            {
                Console.WriteLine("==============================================================================");
                Console.WriteLine("                                                                              ");
                Console.WriteLine("                      NENHUMA MOVIMENTAÇÃO ENCONTRADA !                       ");
                Console.WriteLine("                                                                              ");
                Console.WriteLine("==============================================================================");

                Thread.Sleep(2000); // Caso não houver movimentações - If there are no movements
                OpcaoVoltarLogado(pessoa);
            }
            Thread.Sleep(10000); // Caso tenha movimentações - If have movements
            OpcaoVoltarLogado(pessoa);
        }
        private static void OpcaoVoltarLogado(Pessoa pessoa)
        {
            Console.Clear();
            Console.WriteLine("==============================================================================");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                         DIGITE A OPÇÃO DESEJADA:                             ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("==============================================================================");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                         1 - VOLTAR PARA MINHA CONTA                          ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                         2 - SAIR                                             ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("==============================================================================");

            opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
                TelaContaLogada(pessoa);
            else
                TelaPrincipal();
        }
        private static void OpcaoVoltarDeslogado()
        {
            Console.Clear();
            Console.WriteLine("==============================================================================");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                         DIGITE A OPÇÃO DESEJADA:                             ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("==============================================================================");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                         1 - VOLTAR PARA MENU PRINCIPAL                       ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                         2 - SAIR                                             ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("==============================================================================");

            opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
                TelaPrincipal();
            else
                Console.WriteLine("Invalid option, you cannot exit my program!");
            TelaPrincipal();
        }
        // Parâmetro recebido ( uma pessoa ) - Parameter received ( one person )
        private static void TelaBoasVindas(Pessoa pessoa)
        {
            string mensagem =
            $"  SEJA BEM VINDO {pessoa.nomeUsuario} | BANCO: {pessoa.ContaUsuario.GetCodigoBanco()} " +
            $"| AGÊNCIA: {pessoa.ContaUsuario.GetNumeroAgencia()} | CONTA: {pessoa.ContaUsuario.GetNumeroConta()} |";

            Console.WriteLine("\n" + mensagem + "\n");
        }
    }
}