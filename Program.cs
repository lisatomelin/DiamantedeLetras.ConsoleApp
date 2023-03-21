using System;

namespace DiamantedeLetras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letraInformada = 'Z';

            char letra = 'A';

            int espacodaMargem = letraInformada - letra;

            int quantidadeDeLinhas = letraInformada - letra;

            int espacoEntreAsLetras = -1;

            
            // parte superior

            for (int linha = 0; linha < quantidadeDeLinhas; linha++)
            {
                for (int i = 0; i < espacodaMargem; i++)
                {
                    Console.Write(" ");
                }

                Console.Write(letra);


                for (int i = 0; i < espacoEntreAsLetras; i++)
                {
                    Console.Write(" ");
                }

                if (letra != 'A')
                    Console.Write(letra);

                letra++;
                espacodaMargem--;
                espacoEntreAsLetras += 2;
                Console.Write(" ");

                Console.WriteLine();

            }    
            Console.WriteLine(letraInformada);


            for (int i = 0; i < espacoEntreAsLetras; i++)
            {
                Console.Write(" ");
            }

            Console.Write(letraInformada);

            letra--;
            espacodaMargem++;
            espacoEntreAsLetras -= 2;
            Console.WriteLine();

            
            for (int linha = 0; linha < quantidadeDeLinhas; linha++)
            {
                for (int i = 0; i < espacodaMargem; i++)
                {
                    Console.Write(" ");
                }

                Console.Write(letra);


                for (int i = 0; i < espacoEntreAsLetras; i++)
                {
                    Console.Write(" ");
                }


                if (letra != 'A')
                    Console.Write(letra);

                letra--;
                espacodaMargem++;
                espacoEntreAsLetras -= 2;


                Console.WriteLine();


            }  
            Console.ReadLine();
                    
                
            
        }
    }
}


 
        
        


