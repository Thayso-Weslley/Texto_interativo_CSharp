using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Collections;


namespace estudos.Models
{
    public class Interativo
    {
// Atributos

        private string[] A = {"   As coisas lindas que eu tenho pra te dizer dessa vez são...", "  \n   Eu tenho orgulho de você", "   Eu tenho orgulho de ter te conhecido", "   Eu tenho orgulho de te mandar emails tão lindos quanto cartas todo ano nessa mesma data", "   Eu tenho orgulho de você por ter mudado tanto desde quando eu te conheci", "   Eu tenho orgulho de você por ter aguentado tanto sacode do mundo e ainda continuar sendo você", "   Eu tenho orgulho de você por ser incompreendida pelas pessoas, por você não é igual a elas", "   Eu tenho orgulho de dizer que você fez uma diferença muito grande na minha vida e de como eu a enxergo", "   Assim como também me orgulho de dizer que sou seu amigo, e que sou uma pessoa importante pra você", " \n   Eu me orgulho muito por conseguir te entender, de ser a pessoa na qual você procura quando precisa desabafar. Desde concordar, até discordar.", "  Desde os sonhos estranhos, da conexão inexplicável, até às madrugadas que a gente passa conversando sobre qualquer coisa. \n \n"};
        private string[] B = {"   Eu não acho você uma alienígena ( a gente já teve essa conversa rsrsrs )", "  Mas também não acho que você pertença a este mundo, e o mesmo digo pra mim, pois se assim fosse, o mundo nos amaria, correto? Sabemos que não é assim que acontece. Afinal o mundo ama o que é seu, já o que não é, é rejeitado, escanteado e incompreendido.", "   Não se sinta mal por ser assim.", "   Eu não me sinto. Pelo contrário, eu tenho orgulho disso. Sabe por quê?", "   Porque foi isso que eu aprendi com você.", " \n   Depois de te conhecer, foi que eu aprendi a amar ser quem eu sou. Sem dar importância pro que os outros pensam de mim, pois eu não vivo de opiniões, aceitação, popularidade nem nada do tipo.", "   Se eu tiver só uma pessoa que me enxergue, que me admire, e que me faça sentir que eu não sou o único estranho no mundo, pra mim já basta.", "   E se eu tivesse que imaginar quem é essa pessoa, seria você.\n \n"};
        private string[] C = {"   Não podemos dizer que uma estrela brilha se não há ninguém que a enxergue.", "   Eu enxergo", "   Brilhe, minha amiga! Mas não como uma estrela, como um quasar, como um vagalume, uma lâmpada ou uma vela. Brilhe como Giselle.", "   Brilhe sendo quem você é.", "   Eu sei que há pessoas que te enxergarão como Giselle.", "   Assim como eu enxergo.", " \n   Te amo, Gih", "   Feliz aniversário \n \n"};
        private string[] D = {"P.S.:", "   Hoje é um dia muito especial!", "   De presente de aniversário eu já te dei meu primeiro desenho realista, música ao vivo de violão, Flores de origami, um livro e um quadro 100% artesanal, como minha maior e melhor obra como artista.", "   O curioso é que toda vez que eu faço algo pra você é uma novidade tanto pra você que recebe, quanto pra mim que sempre aprendo e busco ir além do que eu já sei só pra te presentear.", "   Bom...  dessa vez eu não tenho nada físico pra você, na verdade nem fisicamente eu poderei estar presente, pois eu trabalho, faço faculdade e sei que você também tem o seu tempo.  ", "   Por outro lado, eu jamais poderia deixar passar essa data em branco, pois apesar das limitações, esse ano tem novidade sim!", "   Espero que você goste tanto quanto eu.", " \n   Ass - Thayso"};

// Métodos


    // Inicio do texto

        public void inicio()
        {
            Console.WriteLine("    Thayso: eu tive uma ideia! \n No lugar de escrever muito e pensar em cada detalhe, vou reaproveitar mensagens que eu já escrevi. \n \n    E já que só tu vai testar mesmo, então vai ser um exclusivo só pra tu...");
        }

    // Primeira interação com o usuário

        public void intro()
        {
            Console.Write("   Podemos começar? (sim) ");
            string? start = Console.ReadLine().ToUpper().Trim();

            if(start !="SIM")
            {
                Console.Clear();
                 int seg = 0;
                while (seg < 5)
                {
                    Console.WriteLine(". ");
                    Thread.Sleep(1000);
                    seg++;
                }
                Console.WriteLine("   Desculpe! Meu código, minhas regras kkkkkkkkkkkkkkk \n");
                start = null;
                while (start != "SIM")
                {
                    Console.Write(" Podemos prosseguir? diga que sim: ");
                    start = Console.ReadLine().ToUpper().Trim();
                }
            }
            Console.Clear();

            string[] comeco = {"               INTRO \n", "    Assim como sempre fiz há 4 anos e continuarei fazendo por muitos e muitos anos... \n.  Feliz aniversário, Giselle!", " \n.  Nem preciso dizer que você já esperava por um email de aniversário, né? Rsrsrs", "  A cada ano que se passa, a gente se conhece cada vez mais ao ponto de saber o que o outro vai fazer sem nem ter feito ainda."};
            int contador = comeco.Length;

            // Usando Foreach
            foreach (string n in comeco)
            {
                Console.WriteLine(n);
                Thread.Sleep(2000);
            }
        }

    // Interação de menu com o usuário

        public void menu()
        {

            Console.Write("\n \n Este código está dividido em tópicos. \n Pra qual deles você quer ir? \n   A. Meu orgulho... \n   B. Aprendi com você \n   C. Brilhe! \n   D. P.S. \n");
            string x = Console.ReadLine().ToUpper().Trim();

            while(x != "JA LI TUDO")
            {
                switch(x)
                {
                    case "A":
                        Console.Clear();
                        foreach (string n in A)
                        {
                            Console.WriteLine(n);
                            Thread.Sleep(2000);
                        }
                        break;
                    
                    case "B":
                         Console.Clear();
                        foreach (string n in B)
                        {
                            Console.WriteLine(n);
                            Thread.Sleep(2000);
                        }
                        break;

                    case "C":
                         Console.Clear();
                        foreach (string n in C)
                        {
                            Console.WriteLine(n);
                            Thread.Sleep(2000);
                        }
                        break;

                    case "D":
                         Console.Clear();
                        foreach (string n in D)
                        {
                            Console.WriteLine(n);
                            Thread.Sleep(2000);
                        }
                        break;

                    case "JA LI TUDO":
                        x = "JA LI TUDO";
                        break;
                    
                    default:
                        Console.Clear();
                        Console.WriteLine("\n   Essa resposta não é válida ao sistema");
                        break;
                }

                Console.Write(" \n \n Este código está dividido em tópicos. \n Pra qual deles você quer ir? \n   A. Meu orgulho... \n   B. Aprendi com você \n   C. Brilhe! \n   D. P.S. \n \n   Se já leu todos, escreva 'ja li tudo' para encerrar o código. \n   Ler tópico: ");
                x = Console.ReadLine().ToUpper().Trim();
            }
            Console.Clear();
        }
     // Parte final do código

        public void final()
        {
            // int contador = 0;
            Console.WriteLine("   Encerrando código");

            for(int contador = 0; contador < 5; contador++)
            {
                Console.WriteLine(".");
                Thread.Sleep(1000);
            }

            Console.WriteLine("   Thayso: Obrigado por testar meu código em C# \n \n");
            Thread.Sleep(2000);
        }
 
    }
}