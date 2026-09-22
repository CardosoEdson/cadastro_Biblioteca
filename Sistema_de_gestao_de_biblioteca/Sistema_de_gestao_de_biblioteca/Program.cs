using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sistema_de_gestao_de_biblioteca
{
    internal class Program
    { /* 1 - Cadastrar Livro

        2 - Cadastrar Jogo

        3 - Cadastrar Cliente

        4 - Cadastrar Fornecedor

        5 - Registrar Empréstimo

        6 - Sair */
        static void Main(string[] args)
        {
            int opcao = 0;

            while (opcao != 6)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(@"
░█████╗░░█████╗░███╗░░██╗████████╗██████╗░░█████╗░██╗░░░░░███████╗  ██████╗░███████╗
██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗██╔══██╗██║░░░░░██╔════╝  ██╔══██╗██╔════╝
██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██████╔╝██║░░██║██║░░░░░█████╗░░  ██║░░██║█████╗░░
██║░░██╗██║░░██║██║╚████║░░░██║░░░██╔══██╗██║░░██║██║░░░░░██╔══╝░░  ██║░░██║██╔══╝░░
╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░██║░░██║╚█████╔╝███████╗███████╗  ██████╔╝███████╗
░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚══════╝╚══════╝  ╚═════╝░╚══════╝

░██████╗░███████╗░██████╗████████╗░█████╗░░█████╗░
██╔════╝░██╔════╝██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░██╗░█████╗░░╚█████╗░░░░██║░░░███████║██║░░██║
██║░░╚██╗██╔══╝░░░╚═══██╗░░░██║░░░██╔══██║██║░░██║
╚██████╔╝███████╗██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚═════╝░╚══════╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░
");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" 1 - Cadastrar Livros ");
                Console.WriteLine(" 2 - cadastar Jogo ");
                Console.WriteLine(" 3 - Cadastrar Cliente ");
                Console.WriteLine(" 4 - Cadastrar Fornecedor ");
                Console.WriteLine(" 5 - Registrar Empréstimo ");
                Console.WriteLine(" 6 - Sair ");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {

                    case 1:
                        Cadastrar_Livros();

                        break;

                    case 2:
                        Cadastrar_Jogo();

                        break;

                    case 3:
                        Cadastrar_Cliente();

                        break;

                    case 4:
                        Cadastrar_Fornecedor();

                        break;

                    case 5:
                        Registrar_Empréstimo();

                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine(" Saindo Do Sistema !!! Até Logo ");
                        break;

                }
            }
        }

        static void Cadastrar_Livros()
        {
            int id, AnoPublicacao, QtdExemplares;
            string titulo, autor, genero, isbn;
            Console.Clear();
            Console.WriteLine(@" 
██████╗░██╗██████╗░██╗░░░░░██╗░█████╗░████████╗███████╗░█████╗░░█████╗░
██╔══██╗██║██╔══██╗██║░░░░░██║██╔══██╗╚══██╔══╝██╔════╝██╔══██╗██╔══██╗
██████╦╝██║██████╦╝██║░░░░░██║██║░░██║░░░██║░░░█████╗░░██║░░╚═╝███████║
██╔══██╗██║██╔══██╗██║░░░░░██║██║░░██║░░░██║░░░██╔══╝░░██║░░██╗██╔══██║
██████╦╝██║██████╦╝███████╗██║╚█████╔╝░░░██║░░░███████╗╚█████╔╝██║░░██║
╚═════╝░╚═╝╚═════╝░╚══════╝╚═╝░╚════╝░░░░╚═╝░░░╚══════╝░╚════╝░╚═╝░░╚═╝");

            Console.WriteLine(" Digite o Id Do Livro ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o ano da publicação");
            AnoPublicacao = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite a Quantidade De Exemplares ");
            QtdExemplares = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o Titulo Do Livro");
            titulo = Console.ReadLine();

            Console.WriteLine(" Digite o Nome Do Autor");
            autor = Console.ReadLine();

            Console.WriteLine(" Digite o Genero do Livro");
            genero = Console.ReadLine();

            Console.WriteLine(" Digite o ISBN Do Livro ");
            isbn = Console.ReadLine();


            Console.WriteLine("\n Cadastro Realizado Com Sucesso !!! ");
            Console.WriteLine(" \n" + id);
            Console.WriteLine("\n" + AnoPublicacao);
            Console.WriteLine("\n" + QtdExemplares);
            Console.WriteLine("\n" + titulo);
            Console.WriteLine("\n" + autor);
            Console.WriteLine("\n" + genero);
            Console.WriteLine("\n" + isbn);

            Thread.Sleep(2000);
        }

        static void Cadastrar_Jogo()

        {
            int IdentiUnico, IdadeMrecomenda, qntdMipartic, NumMxJogadores, qtdExemplares;
            string NomeJogo, TipoJogo;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

░░░░░██╗░█████╗░░██████╗░░█████╗░░██████╗
░░░░░██║██╔══██╗██╔════╝░██╔══██╗██╔════╝
░░░░░██║██║░░██║██║░░██╗░██║░░██║╚█████╗░
██╗░░██║██║░░██║██║░░╚██╗██║░░██║░╚═══██╗
╚█████╔╝╚█████╔╝╚██████╔╝╚█████╔╝██████╔╝
░╚════╝░░╚════╝░░╚═════╝░░╚════╝░╚═════╝░");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("Digite o identificador do jogo");
            IdentiUnico = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite a Idade recomendada");
            IdadeMrecomenda = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite a quantidade Minima De Participantes");
            qntdMipartic = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Quantidade maxima de jogadores");
            NumMxJogadores = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Quantidade de Exemplares");
            qtdExemplares = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o nome do Jogo");
            NomeJogo = Console.ReadLine();

            Console.WriteLine(" Qual o Tipo Do Jogo");
            TipoJogo = Console.ReadLine();

            Console.WriteLine("\n Cadastro Realizado Com Sucesso !!!");
            Console.WriteLine("\n" + IdentiUnico);
            Console.WriteLine("\n" + IdadeMrecomenda);
            Console.WriteLine("\n" + qntdMipartic);
            Console.WriteLine("\n" + NumMxJogadores);
            Console.WriteLine("\n" + qtdExemplares);
            Console.WriteLine("\n" + NomeJogo);
            Console.WriteLine("\n" + TipoJogo);

            Thread.Sleep(4000);
        }
        static void Cadastrar_Cliente()
        {
            int id;
            string nomeCompleto, cpf, Telefone, Email;
            DateTime dataNascimento;
            bool Situaçao;

            Console.Clear();
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

░█████╗░██╗░░░░░██╗███████╗███╗░░██╗████████╗███████╗░██████╗
██╔══██╗██║░░░░░██║██╔════╝████╗░██║╚══██╔══╝██╔════╝██╔════╝
██║░░╚═╝██║░░░░░██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░╚█████╗░
██║░░██╗██║░░░░░██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░░╚═══██╗
╚█████╔╝███████╗██║███████╗██║░╚███║░░░██║░░░███████╗██████╔╝
░╚════╝░╚══════╝╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═════╝░");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Digite o id do cliente");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o nome completo do cliente: ");
            nomeCompleto = Console.ReadLine();

            Console.WriteLine(" Digite o cpf do Cliente: ");
            cpf = Console.ReadLine();

            Console.WriteLine(" Digite o telefone do Cliente");
            Telefone = Console.ReadLine();

            Console.WriteLine(" Digite o E-mail do Cliente ");
            Email = Console.ReadLine();

            Console.WriteLine(" Digite a Data De nascimento Do Cliente");
            dataNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(" Digite a Situaçao do cadastro Ativo ou Desativado ");
            Situaçao = bool.Parse(Console.ReadLine());



            if (Situaçao == true)
            {

                Console.WriteLine("\n Cadastro Realizado Com Sucesso !!! ");
                Console.WriteLine("\n" + id);
                Console.WriteLine("\n" + nomeCompleto);
                Console.WriteLine("\n" + cpf);
                Console.WriteLine("\n" + Telefone);
                Console.WriteLine("\n" + Email);
                Console.WriteLine("\n" + dataNascimento);
                Console.WriteLine("\n" + Situaçao);



            }
            else
            {
                Console.WriteLine(" Cadastro nao finalizado ");
            }



            Thread.Sleep(3000);
        }

        static void Cadastrar_Fornecedor()
        {
            int id;
            string RazaoSocial, cnpj, telefone, Email, endereco;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@" 
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

███████╗░█████╗░██████╗░███╗░░██╗███████╗░█████╗░███████╗██████╗░░█████╗░██████╗░
██╔════╝██╔══██╗██╔══██╗████╗░██║██╔════╝██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔══██╗
█████╗░░██║░░██║██████╔╝██╔██╗██║█████╗░░██║░░╚═╝█████╗░░██║░░██║██║░░██║██████╔╝
██╔══╝░░██║░░██║██╔══██╗██║╚████║██╔══╝░░██║░░██╗██╔══╝░░██║░░██║██║░░██║██╔══██╗
██║░░░░░╚█████╔╝██║░░██║██║░╚███║███████╗╚█████╔╝███████╗██████╔╝╚█████╔╝██║░░██║
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚══════╝░╚════╝░╚══════╝╚═════╝░░╚════╝░╚═╝░░╚═╝");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine(" Digite o Id do Fornecedor");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite a razão Social do Fornecedor");
            RazaoSocial = Console.ReadLine();

            Console.WriteLine(" Digite o Cnpj do Fornecedor");
            cnpj = Console.ReadLine();

            Console.WriteLine(" Digite o Telefone do Fornecedor");
            telefone = Console.ReadLine();

            Console.WriteLine(" Digite o E-mail do Fornecedor");
            Email = Console.ReadLine();

            Console.WriteLine(" Digite o Endereço do Fornecedor");
            endereco = Console.ReadLine();

            Console.WriteLine("\n Cadastro Finalizado com Sucesso!!! ");
            Console.WriteLine("\n" + id);
            Console.WriteLine("\n" + RazaoSocial);
            Console.WriteLine("\n" + cnpj);
            Console.WriteLine("\n" + telefone);
            Console.WriteLine("\n" + Email);
            Console.WriteLine("\n" + endereco);

            Thread.Sleep(3000);
        }
        static void Registrar_Empréstimo()
        {
            int id, ClienteId,ItemId;
            string TipoItem;
            DateTime DataEmprestimo, DataDevolucao;
            bool StatusDevoluçao;

            Console.Clear();
            Console.WriteLine(@" 
███████╗███╗░░░███╗██████╗░██████╗░███████╗░██████╗████████╗██╗███╗░░░███╗░█████╗░
██╔════╝████╗░████║██╔══██╗██╔══██╗██╔════╝██╔════╝╚══██╔══╝██║████╗░████║██╔══██╗
█████╗░░██╔████╔██║██████╔╝██████╔╝█████╗░░╚█████╗░░░░██║░░░██║██╔████╔██║██║░░██║
██╔══╝░░██║╚██╔╝██║██╔═══╝░██╔══██╗██╔══╝░░░╚═══██╗░░░██║░░░██║██║╚██╔╝██║██║░░██║
███████╗██║░╚═╝░██║██║░░░░░██║░░██║███████╗██████╔╝░░░██║░░░██║██║░╚═╝░██║╚█████╔╝
╚══════╝╚═╝░░░░░╚═╝╚═╝░░░░░╚═╝░░╚═╝╚══════╝╚═════╝░░░░╚═╝░░░╚═╝╚═╝░░░░░╚═╝░╚════╝░");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine(" Digite o Identificador Unico");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o Id do Cliente ");
            ClienteId = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o ID do Item emprestado ");
            ItemId = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o tipo do item emprestado");
            TipoItem = Console.ReadLine();

            Console.WriteLine(" Digite a Data do Emprestimo");
            DataEmprestimo = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(" Digite a Data da Devoluçao");
            DataDevolucao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o Status da Devolução ");
            StatusDevoluçao = bool.Parse(Console.ReadLine());

            if (StatusDevoluçao == true)
            {
                Console.WriteLine("\n Cadastro realizaod com sucesso!!!");
                Console.WriteLine("\n" + id);
                Console.WriteLine("\n" + ClienteId);
                Console.WriteLine("\n" + ItemId);
                Console.WriteLine("\n" + TipoItem);
                Console.WriteLine("\n" + DataEmprestimo);
                Console.WriteLine("\n" + DataDevolucao);
                Console.WriteLine("\n" + StatusDevoluçao);
                

            }
            else
            {
                Console.WriteLine(" Item não Devolvido ");
            }

            Thread.Sleep(4000);



            


           












        }
    } 
}
