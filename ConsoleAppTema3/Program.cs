using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTema3
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercitiul1();
            Exercitiul2();
            Exercitiul3();
            Exercitiul4();
            Exercitiul5();
            Exercitiul6();
            ExercitiulSuplimentar1();
        }
        static void Exercitiul1()
        {
            double[] vector = new double[3];
            vector[0] = 1;
            vector[1] = 5;
            vector[2] = 10;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(vector[i]);
            }
            //Console.ReadLine();
        }
        static void Exercitiul2()
        {
            int[] vector = new int[10] { 5, 11, -3, 1, 25, -33, 70, 45, 9, 100 };
            int min = vector[0];
            int max = vector[0];

            for (int i = 0; i < 10; i++)
            {
                if (vector[i] < min)
                {
                    min = vector[i];
                }
                if (vector[i] > max)
                {
                    max = vector[i];
                }
            }

            Console.WriteLine("Min=" + min);
            Console.WriteLine("Max=" + max);

            //Console.ReadLine();
        }

        static void Exercitiul3()
        {
            int[] vector = new int[] {1, 5, 7, 11, -2, 15, 18, 20, 25, 30};
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i]<0)
                {
                    Console.WriteLine("Numarul negativ este pe pozitia:" + (i+1));
                    break;
                }
            }
            //Console.ReadLine();
        }

        static void Exercitiul4()
        {
            string text = "Something meaningful";
            char[] vectorName = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                vectorName[i] = text[i];
            }
            for (int i = 0; i < vectorName.Length; i++)
            {
                Console.WriteLine("vectorName[" + i + "]=" + vectorName[i]);
            }
            //Console.ReadLine();
        }

        static void Exercitiul5()
        {
            char[] vectorName = new char[] {'a', 'b', 'c', 'd', 'e', 'f'};
            for (int i = 0; i < vectorName.Length; i++)
            {
                if (i%2==0)
                {
                    vectorName[i] = char.ToUpper(vectorName[i]);
                }
            }
            for (int i = 0; i < vectorName.Length; i++)
            {
                Console.WriteLine("vectorName[" + i + "]=" + vectorName[i]);
            }
            //Console.ReadLine();
        }

        static void Exercitiul6()
        {
            int[] vectorName = new int[] { 1, 2, 3, 4, 5 };
            double[] vectorMiddleName = new double[vectorName.Length];
            double variable = 10.55;
            for (int i = 0; i < vectorName.Length; i++)
            {
                vectorMiddleName[i] = variable * vectorName[i];
            }
            for (int i = 0; i < vectorName.Length; i++)
            {
                Console.WriteLine(vectorName[i] + " + " + variable + "=" + vectorMiddleName[i]);
            }
            //Console.ReadLine();
        }

        static void ExercitiulSuplimentar1()
        {
            string text = "Acesta este un limbaj de programare interesant.";
            string[] vectorName;
            int vectorLenght = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]==' ')
                {
                    vectorLenght++;
                }
            }

            vectorName = new string[vectorLenght + 1];

            string word = "";
            int currentPosition = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    word = word + text[i];
                }
                else
                {
                    vectorName[currentPosition] = word;
                    word = "";
                    currentPosition++;
                }
            }
            if (word !="")
            {
                vectorName[currentPosition] = word;
            }

            Console.WriteLine(text);
            for (int i = 0; i < vectorName.Length; i++)
            {
                Console.WriteLine(vectorName[i]);
            }
            Console.ReadLine();
        }
    }
}
