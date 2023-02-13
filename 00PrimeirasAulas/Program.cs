using System;
using System.Globalization;

namespace Projeto1
{
    class Program
    {

        // ---------------------------------------------------------------------

        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);
        }

        static int Maior(int a, int b, int c)
        {
            /* Explicando a função:
            *  Deve ser static pois será usada dentro de uma função static
            *  Deve ser do tipo int pois retornará um valor int */

            int m;
            if (a > b && a > c) {
                m = a;
            }
            else if (b > c) {
                m = b;
            }
            else {
                m = c;
            }

            return m;
        }

        // ---------------------------------------------------------------------


        /* *** PRIMEIRA AULA - SAÍDA DE DADOS EM C# ***
         
        static void Main(string[] args)
        {
            SByte x = 127;
            SByte y = 128;      //ERRO: Overflow (quando o limite da variável é estourado)
            Console.WriteLine("Hello World");
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        

        static void Main (string[] args)
        {
            Console.Write("Well, Hello!");          // Escreve o conteúdo, mas não tem quebra de linha. Precisa da biblioteca System.Globalization.
            Console.WriteLine("Hello, World!");   // Escreve o conteúdo "Hello World" e quebra o fim da linha
            Console.WriteLine("I'm here");

            double saldo = 10.55661;

            //Os números quebrados imprimem vírgula porque o é pego o idioma do sistema. No caso, como é português, os números quebrados terão vírgula no lugar do ponto.
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2"));    // Imprime apenas duas casas após a vírgula
            Console.WriteLine(saldo.ToString("F4"));    // Imprime 4 casas após a vírgula
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));      // Troca a linha por "."
        }

        */


        /* *** SEGUNDA AULA - PLACEHOLDERS, INTERPOLAÇÃO E CONCATENAÇÃO ***

        static void Main(string[] args)
        {
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            // PLACEHOLDER
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a R${2} reais.", nome, idade, saldo);
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a R${2:F2} reais.", nome, idade, saldo);  // :F2 vai limitar a quantidade de casas dps da vírgula para 2
            Console.WriteLine();

            //INTERPOLAÇÃO
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a R${saldo:F2} reais");
            Console.WriteLine();

            //CONCATENAÇÃO
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a R$" + saldo.ToString("F2") + " reais");
            Console.WriteLine();

            // Para colocar o ponto no lugar da vírgula, é necessário usar o ToString
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a R$" + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }
        */


        /* *** EXERCICIO DA SEGUNDA AULA ***
        
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é R${preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é R${preco2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
        */


        /* *** TERCEIRA AULA - OPERADORES DE ATRIBUIÇÃO ***

        static void Main(string[] args)
        {
            // Os operadores de atribuição em tese funcionam tanto com números quanto com strings
            // No entanto, o exemplo do professor não está funcionando

            int intA = 10;
            intA += 2;
            Console.WriteLine(intA);

            string s = "ABC";
            Console.WriteLine(s);
            s += "DEF";
            Console.WriteLine(s);
        }
        */


        /* *** QUARTA AULA - CONVERSÃO IMPLÍCITA E CASTING ***

        static void Main(string[] args)
        {
            float x = 4.5f;     // Float possui um tamanho de 4 bytes
            double y = x;       // Double possui um tamanho de 8 bytes
                                // Portanto, o float cabe dentro do double
            Console.WriteLine("Valor de y: " + y);


            // ************************************************************************ //
            // Se tentarmos inverter os tipos, o double não caberá dentro do float, então usamos casting para resolver a situação
            double ax;
            float bx;

            ax = 5.1;
            //bx = ax;        // => Apresenta erro (aviso) de que informação será perdida caso haja a conversão da informação da variável
            bx = (float)ax;   // => Casting, permite a conversão
            Console.Write("Valor de bx: ");
            Console.WriteLine(bx);


            // ************************************************************************ //
            // Convertendo double para int
            double au;   // => Tamanho de 8 bytes
            int bu;      // => Tamanho de 4 byes

            au = 5.1;    // => Número quebrado
            bu = (int)au; // => Número inteiro

            Console.WriteLine("Valor de bu: " + bu);  // => O valor após a vírgula é perdido/trunkado


            // ************************************************************************ //
            int a = 5;
            int b = 2;

            double resultado1 = a / b;          // => Resultado = 2, pois é entendido que dois números int estão sendo divididos
            double resultado2 = (double)a / b;  // => Resultado = 2,5 pois o a foi entendido como um double

            Console.WriteLine("Resultado sem casting: " + resultado1);
            Console.WriteLine("Resultado com casting: " + resultado2);
        } */


        /* *** QUINTA AULA - OPERAÇÕES ARITMÉTICAS ***
         
        static void Main(string[] args)
        {
            double a = 1.0, b = -3.0, c = -4.0;

            // Math.Pow => Função para calcular EXPONENCIAÇÃO. <= Math.Pow(base, exponencial)
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            // Math. Sqrt => Função para calcular RAIZ QUADRADA
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("Valor de delta: " + delta);
            Console.WriteLine("Valor do x1: " + x1);
            Console.WriteLine("Valor do x2: " + x2);
        } */


        /* *** SEXTA AULA - ENTRADA DE DADOS EM C# - READLINE E SPLIT ***

        static void Main(string[] args)
        {
            // Console.ReadLine(); => LÊ A ENTRADA DE DADOS PADRÃO ATÉ A QUEBRA DE LINHA (ENTER)
            // Console.ReadLine(); => RETORNA OS DADOS LIDOS NA FORMA DE STRING

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            

            // .Split => Usado para quebrar uma cadeia de caracteres delimitada em subcadeias de caracteres

            string s = Console.ReadLine();
            string[] v = s.Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }*/


        /* *** SÉTIMA AULA - ENTRADA DE DADOS EM C# / PT 2 ***

        static void Main(string[] args)
        {
            // O Console.ReadLine() retorna os valores lidos como string
            int n1 = int.Parse(Console.ReadLine());      // int.Parse() está convertendo o valor lido para int
            char ch = char.Parse(Console.ReadLine());    // char.Parse() está convertendo o valor lido para char
            //double n2 = double.Parse(Console.ReadLine()); // double.Parse() está convertendo o valor lido para double
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Troca a vírgula para ponto

            Console.WriteLine("Você Digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            //Console.WriteLine(n2);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture)); // Necessário adicionar o CultureInfo aqui tb para ter ponto


            // ********************************************************************************

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        } */


        /* *** EXERCÍCIO DA SÉTIMA AULA (AULA 23 UDEMY) ***

        static void Main(string[] args)
        {
            // ENTRADA DE DADOS
            
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double valorProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");

            string[] v = Console.ReadLine().Split(' ');
            string nomeV = v[0];
            int idadeV = int.Parse(v[1]);
            double alturaV = double.Parse(v[2], CultureInfo.InvariantCulture);

            // SAÍDA DE DADOS

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(valorProd.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nomeV);
            Console.WriteLine(idadeV);
            Console.WriteLine(alturaV.ToString("F2", CultureInfo.InvariantCulture));
            
        } */


        /* *** OITAVA AULA - OPERADORES COMPARATIVOS E LÓGICOS ***

        static void Main(string[] args)
        {
            bool c1 = 2 > 3 || 4 != 5;      // true
            bool c2 = !(2 > 3) && 4 != 5;   // true

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Console.WriteLine("-----------------------");

            bool c3 = 10 < 5;           // false
            bool c4 = c1 || c2 && c3;   // true

            Console.WriteLine(c3);
            Console.WriteLine(c4);
        } */


        /* *** NONA AULA - ESCOPO ***

        static void Main(string[] args)
        {
            // Escpopo
            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;

            if (preco > 100.0)
            {
                // Escopo menor
                // double desconto = preco * 0.1;   // Dá erro no cw, porque o programa principal não enxerga variáveis declaradas dentro de escopos menores dentro dele.
                desconto = preco * 0.1;
            }

             Console.WriteLine(desconto);
        } */

    }
}