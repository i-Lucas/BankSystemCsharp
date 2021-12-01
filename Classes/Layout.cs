using System;

namespace BankSystemCsharp.Classes
{
    public class Layout
    {
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
                    break;
                default:
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
        }

    }
}