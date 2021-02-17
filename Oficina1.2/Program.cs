using System;

public class atividade02
{

    static void Main()
    {
    inicio:
        char yn = ' ';
        int c = 0;
        int x = 0;
        Console.WriteLine("Olá, seja bem vindo ao conteúdo interativo da aula 1.2!");
        Console.WriteLine("O que você deseja revisar? \n[1] Conversões \n[2] Condições If/else \n[3] Condições Switch Case \n[4] Repetição For \n[5] Repetição While \n[0] Sair");
        c = int.Parse(Console.ReadLine());

        //SWITCH CASE
        switch (c)
        {
            // CONVERSÃO INT - DOUBLE
            case 1:
                Console.Clear();

                Console.WriteLine("Olá, este é um progama de conversões. (Linhas 30-33) \nDigite sua altura (em cm).");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine(("Seu valor em metros é: " + System.Convert.ToDouble(x) / 100));
                break;

            // IF/ELSE
            case 2:
                Console.Clear();

                Console.WriteLine("Olá, este é um programa de estrutura condicional if/else. (Linhas 41-52) \n Digite sua idade.");
                x = int.Parse(Console.ReadLine());
                if (x > 0 && x < 18)
                    Console.WriteLine("Você é menor de idade!");
                else
                if (x >= 18 && x < 65)
                    Console.WriteLine("Você é adulto!");
                else
                if (x >= 65 && x < 120)
                    Console.WriteLine("Você é idoso!");
                else
                    Console.WriteLine("Idade inválida!");
                break;

            case 3:
                Console.Clear();

                Console.WriteLine("Olá, este é um programa de switch case. \n Por favor, verifique o programa a partir da linha 25 ^^");
                break;

            // LAÇO FOR
            case 4:
                Console.Clear();

                Console.WriteLine("Olá, este é um programa de laço for. (Linhas 66-77) \nDigite um n-ésimo termo da Sequencia de Fibonacci.");
                x = int.Parse(Console.ReadLine());
                int n1 = 1, n2 = 0, n3;
                for (int j = 0; j < x; j++)
                {
                    n3 = n1 + n2;
                    n2 = n1;
                    n1 = n3;
                }
                Console.WriteLine("O {0}° termo na Sequência é: {1}", x, n1);
                break;

            // LAÇO WHILE
            case 5:
                Console.Clear();
                Console.WriteLine("Olá, este é um programa de laço while. (Linhas 81-88) \nDigite um número e o contaremos até chegar nele.");
                x = int.Parse(Console.ReadLine());
                int i = 1;
                while ((x + 1) != i)
                {
                    Console.WriteLine("Ainda não chegamos, estamos no n° " + i);
                    i++;
                }
                break;

            case 0:
                Console.Clear();
                break;

            default:
                Console.Clear();
                goto inicio;
        }

    simnao:
        Console.WriteLine("Deseja Fazer outra operação? \n[s] Sim \n[n] Não");
        yn = char.Parse(Console.ReadLine());

        if (yn == 'S' || yn == 's')
        {
            Console.Clear();
            goto inicio;
        }
        if (yn == 'N' || yn == 'n')
        {
            Console.WriteLine("Entendido, obrigado por usar meu programa ^^");
        }
        else
        {
            Console.Clear();
            goto simnao;
        }
    }
}