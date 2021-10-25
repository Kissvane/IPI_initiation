using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_initiation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercice1();

            //Exercice2_1();

            //Exercice2_2();

            //Exercice3_1();

            //Exercice3_2();

            //Exercice4();

            //Exercice5();

            //Exercice6(RedFlag.RED);

            //Exercice7();

            //Exercice8();

            //Exercice9();

            //Exercice10();

            //Exercice11();

            //Exercice12();

            //Exercice13();

            //Exercice14();

            //Exercice15();

            //Exercice16();

            //Exercice17();

            //Exercice18();

            //Exercice19();

            Exercice20();
        }

        static void Exercice1()
        {
            Console.WriteLine("Tapez votre prénom.");
            string firstName = Console.ReadLine();

            Console.WriteLine("Tapez votre nom.");
            string lastName = Console.ReadLine();

            Console.WriteLine("Bonjour {0} {1}", firstName, lastName);
        }

        static void Exercice2_1()
        {
            Console.WriteLine("Tapez votre année de naissance");
            int birthYear = int.Parse(Console.ReadLine());
            int currentYear = DateTime.Now.Year;
            Console.WriteLine("Vous avez {0} ans.", currentYear - birthYear);
        }

        static void Exercice2_2()
        {
            Console.WriteLine("Tapez votre année de naissance");
            int birthYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Tapez votre mois de naissance");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Tapez votre jour de naissance");
            int birthDay = int.Parse(Console.ReadLine());
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;
            int currentDay = DateTime.Now.Day;

            int age = currentYear - birthYear;

            if (birthMonth > currentMonth || (birthMonth == currentMonth && birthDay > currentDay))
            {
                Console.WriteLine("Vous n'avez pas fêté votre anniversaire.");
                age--;
            }

            Console.WriteLine("Vous avez {0} ans.", age);
        }

        static void Exercice3_1()
        {
            Console.WriteLine("Tapez le prix de votre produit.");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Le prix TTC est de {0} euros.", price * 1.2f);
        }

        static void Exercice3_2()
        {
            Console.WriteLine("Tapez le prix de votre produit.");
            float price = float.Parse(Console.ReadLine());
            Console.WriteLine("Tapez la TVA de votre produit.");
            float tva = (100f + float.Parse(Console.ReadLine())) / 100f;
            Console.WriteLine("Le prix TTC est de {0} euros.", price * tva);
        }

        static void Addition(int arg1, int arg2)
        {
            Console.WriteLine("{0} + {1} = {2}", arg1, arg2, arg1 + arg2);
        }

        static void Division(int arg1, int arg2)
        {
            Console.WriteLine("{0} / {1} = {2} reste {3}", arg1, arg2, arg1 / arg2, arg1 % arg2);
        }

        static void Exercice4()
        {
            Console.WriteLine("Tapez le premier nombre.");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tapez le second nombre.");
            int number2 = int.Parse(Console.ReadLine());

            Addition(number1, number2);
            Division(number1, number2);
        }

        static void Exercice5()
        {
            bool validParameters = true;
            Console.WriteLine("Tapez le premier nombre.");
            int number1 = 0;
            int number2 = 0;
            validParameters = validParameters && int.TryParse(Console.ReadLine(), out number1);

            if (!validParameters)
            {
                Console.WriteLine("Parameters invalid");
                return;
            }

            Console.WriteLine("Tapez le second nombre.");
            validParameters = validParameters && int.TryParse(Console.ReadLine(), out number2);
            if (validParameters)
            {
                Addition(number1, number2);
                if (number2 != 0)
                    Division(number1, number2);
                else
                    Console.WriteLine("Division by 0 is not allowed");
            }
            else
                Console.WriteLine("Parameters invalid");
        }

        public enum RedFlag { GREEN, ORANGE, RED };

        static void Exercice6(RedFlag flag)
        {
            /*switch (flag)
            {
                case RedFlag.GREEN:
                    Console.WriteLine(RedFlag.ORANGE);
                    break;
                case RedFlag.ORANGE:
                    Console.WriteLine(RedFlag.RED);
                    break;
                default:
                    Console.WriteLine(RedFlag.GREEN);
                    break;
            }*/

            int temp = ((int)flag + 1) % Enum.GetNames(typeof(RedFlag)).Length;

        }

        static void Exercice7()
        {
            Console.WriteLine("Entrez la tempréature de l'eau.");
            int temperature = int.Parse(Console.ReadLine());
            if (temperature <= 0)
            {
                Console.WriteLine("GLACE.");
            }
            else if (temperature >= 100)
            {
                Console.WriteLine("VAPEUR.");
            }
            else
            {
                Console.WriteLine("LIQUIDE.");
            }
        }

        static void DivisionException(int arg1, int arg2)
        {
            try
            {
                Console.WriteLine("{0} / {1} = {2} reste {3}", arg1, arg2, arg1 / arg2, arg1 % arg2);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Division by 0 is not allowed. {0}", ex.Message);
            }
        }

        static void Exercice8()
        {
            try
            {
                Console.WriteLine("Tapez le premier nombre.");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Tapez le second nombre.");
                int number2 = int.Parse(Console.ReadLine());
                Addition(number1, number2);
                DivisionException(number1, number2);
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("All arguments must be numerals. {0}", ex.Message);
            }
        }

        static void Exercice9()
        {
            Random rnd = new Random();

            try
            {
                Console.WriteLine("Tapez un nombre");
                int arg0 = int.Parse(Console.ReadLine());
                Console.WriteLine("Tapez un nombre");
                int arg1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Tapez un nombre");
                int arg2 = int.Parse(Console.ReadLine());
                int arg3 = rnd.Next(0, 100);
                Console.WriteLine("{0} est choisi au hasard", arg3);
                int arg4 = rnd.Next(0, 100);
                Console.WriteLine("{0} est choisi au hasard", arg4);
                int arg5 = rnd.Next(0, 100);
                Console.WriteLine("{0} est choisi au hasard\n\n", arg5);

                List<int> temp = new List<int> { arg0, arg1, arg2, arg3, arg4, arg5 };
                temp = temp.OrderByDescending(x => x).ToList();

                foreach (int i in temp)
                {
                    Console.WriteLine(i);
                }
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("All arguments must be numerals. {0}", ex.Message);
            }
        }

        static void Exercice10()
        {
            try
            {
                Console.WriteLine("Tapez un nombre");
                float arg0 = float.Parse(Console.ReadLine());
                Console.WriteLine("Tapez un nombre");
                float arg1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Tapez un nombre");
                float arg2 = float.Parse(Console.ReadLine());

                float temp0 = 0;
                float temp1 = 0;
                float temp2 = 0;

                if (arg0 <= arg1 && arg0 <= arg2)
                {
                    temp0 = arg0;
                    if (arg1 <= arg2)
                    {
                        temp1 = arg1;
                        temp2 = arg2;
                    }
                    else
                    {
                        temp1 = arg2;
                        temp2 = arg1;
                    }
                }
                else if (arg1 <= arg0 && arg1 <= arg2)
                {
                    temp0 = arg1;
                    if (arg0 <= arg2)
                    {
                        temp1 = arg0;
                        temp2 = arg2;
                    }
                    else
                    {
                        temp1 = arg2;
                        temp2 = arg0;
                    }
                }
                else if (arg2 <= arg0 && arg2 <= arg1)
                {
                    temp0 = arg2;
                    if (arg1 <= arg0)
                    {
                        temp1 = arg1;
                        temp2 = arg0;
                    }
                    else
                    {
                        temp1 = arg0;
                        temp2 = arg1;
                    }
                }

                Console.WriteLine("{0} - {1} - {2}", temp0, temp1, temp2);
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("All arguments must be numerals. {0}", ex.Message);
            }
        }

        static void Exercice11()
        {
            for (int i = 0; i <= 20; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
        
        static void Exercice12()
        {
            Console.WriteLine(SumAll(4));
        }

        static int SumAll(int number)
        {
            int result = 0;
            for (int i = 1; i <= number; i++)
            {
                result += i;
            }
            return result;
        }

        static void Exercice13()
        {
            string result = "";
            for (int i = 30; i >= 0; i = i - 3)
            {
                result += string.Concat(i, "_");
            }
            result = result.Substring(0, result.Length - 1);
            Console.WriteLine(result);
        }

        static void Exercice14()
        {
            int count = 2;
            while (count <= 21)
            {
                Console.WriteLine(count);
                count += 3;
            }
        }

        static void Exercice15()
        {
            bool isNumber = true;
            int result = 0;
            while (true)
            {
                Console.WriteLine("Tapez un nombre.");
                isNumber = int.TryParse(Console.ReadLine(),out int number);
                if (isNumber)
                {
                    result += number;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(result);
        }

        static void Exercice16()
        {
            Console.WriteLine("Tapez un nombre.");
            bool isNumber = int.TryParse(Console.ReadLine(), out int number);
            int result = 0;
            if (isNumber)
            {
                while (number > 1)
                {
                    number /= 2;
                    result++;
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Vous devez taper un nombre");
            }
        }

        static void Exercice17()
        {
            int[] myArray = new int[9];
            int index = 0;
            for (int i = 5; i <= 13; i++)
            {
                myArray[index] = i;
                if (index == 2)
                {
                    myArray[index] = 111;
                }
                index++;
            }
            
            foreach (int i in myArray) 
            {
                Console.WriteLine(i);
            }
        }

        static void Exercice18()
        {
            int[] original = new int[] { 13, 12, 4, 5, 7, 8, 2 };
            int[] copy = new int[original.Length]; 
            for (int i = 0; i < original.Length; i++)
            {
                if (original[i]%2 == 0) 
                    copy[i] = i;
                else
                    copy[i] = original[i];
            }

            PrintArray(original);

            PrintArray(copy);
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                {
                    Console.Write(string.Concat(array[i], "_"));
                }
                else
                {
                    Console.Write(array[i]);
                }
            }
            Console.WriteLine();
        }

        static void Exercice19()
        {
            int[] array1 = new int[] { 0, 2, 4, 6, 8 };
            int[] array2 = new int[] { 1, 3, 5 };
            int[] result = new int[array1.Length + array2.Length];
            int resultIndex = 0;
            for (int i = 0; i < Math.Max(array1.Length, array2.Length); i++)
            {
                if (array1.Length > i) 
                {
                    result[resultIndex] = array1[i];
                    resultIndex++;
                }
                if (array2.Length > i) 
                {
                    result[resultIndex] = array2[i];
                    resultIndex++;
                }
            }

            PrintArray(result);
        }

        static void Exercice20()
        {
            int[] array1 = new int[] { 0, 1, 5, 6, 7};
            int[] array2 = new int[] { 2, 3, 4 };

            PrintArray(insertArray(array1, array2, 2));
        }

        static int[] insertArray(int[] array, int[] insertedArray, int insertionIndex)
        {
            int[] result = new int[array.Length + insertedArray.Length];
            int insertedNumbers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == insertionIndex)
                {
                    //insert inserted array
                    for (int j = 0; j < insertedArray.Length; j++)
                    {
                        result[i + j] = insertedArray[j];
                    }
                    insertedNumbers = insertedArray.Length;
                }
                Console.WriteLine("i = "+i+" insertedNumbers = "+insertedNumbers);
                result[i + insertedNumbers] = array[i];
            }
            return result;
        }
    }
}
