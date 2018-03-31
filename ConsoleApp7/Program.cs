using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //array1();
            //array2();
            //array3();
            //array4();
            //array5();
            //array6();
            array7();
        }

        //Գրել ցիկլ, որը կարտածի միաչափ զանգվածի էլեմենտները։
        static void array1()

        {

            int a = 3;
            int[] x = new int[] { 7, 8, 9};
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(x[i]);
            }
            Console.ReadLine();
        }

        //Ստեղծել n երկարությամբ միաչափ զանգված և ցիկլով ներմուծել զնագվածի էլեմենտների արժեքները։

        static void array2()

        {

            Console.Write("Input array length = ");
            int a = int.Parse(Console.ReadLine());
            int i;
            int b;
            
            int[] x = new int[a];
            for (i = 0; i < a; i++)
            {
                Console.Write("Input array element = ");
                 b = int.Parse(Console.ReadLine());
                x[i] = b;
                
            }

            for (i = 0; i < a; i++)
            {
                Console.Write(" {0}", x[i]);
            }

            Console.ReadLine();
        }

        //Ստեղծել զանգված, որի էլեմենտները կպարունակեն 1 - ից մինչև n ամբողջ թվերի քառակուսիները։
        static void array3()

        {

            Console.Write("Input array length = ");
            int a = int.Parse(Console.ReadLine());
            int i;
            int b;
            

            int[] x = new int[a];
            for (i = 0; i < a; i++)
            {
                Console.Write("Input array element = ");
                b = int.Parse(Console.ReadLine());
                int c = b * b;
                x[i] = c;

            }

            for (i = 0; i < a; i++)
            {
                Console.Write(" {0}", x[i]);
            }

            Console.ReadLine();
        }

        //Հաշվել թվային զանգվածի էլեմենտների գումարը։
        static void array4()

        {

            Console.Write("Input array length = ");
            int a = int.Parse(Console.ReadLine());
            int i;
            int b;
            int sum = 0;


            int[] x = new int[a];
            for (i = 0; i < a; i++)
            {
                Console.Write("Input array element = ");
                b = int.Parse(Console.ReadLine());
                x[i] = b;

            }
            
            for (i = 0; i < a; i++)
            {
                sum = x[i] + sum;
               
                Console.Write(" {0}", x[i]);
               
            }
            Console.WriteLine();
            Console.WriteLine(" {0}", sum);
            Console.ReadLine();
        }


        //Հաշվել թվային զանգվածի էլեմենտների արտադրյալը։

        //Հաշվել թվային զանգվածի էլեմենտների գումարը։
        static void array5()

        {

            Console.Write("Input array length = ");
            int a = int.Parse(Console.ReadLine());
            int i;
            int b;
            int pow = 1;


            int[] x = new int[a];
            for (i = 0; i < a; i++)
            {
                Console.Write("Input array element = ");
                b = int.Parse(Console.ReadLine());
                x[i] = b;

            }

            for (i = 0; i < a; i++)
            {
                pow = x[i] * pow;

                Console.Write(" {0}", x[i]);

            }
            Console.WriteLine();
            Console.WriteLine(" {0}", pow);
            Console.ReadLine();
        }
        //Գտնել թվային զանգվածի էլեմենտներից փոքրագույնը։
        static void array6()

        {

            Console.Write("Input array length = ");
            int a = int.Parse(Console.ReadLine());
            int i;
            int b;

            int[] x = new int[a];
            for (i = 0; i < a; i++)
            {
                Console.Write("Input array element = ");
                b = int.Parse(Console.ReadLine());
                x[i] = b;

            }

            int min = x[0], minIndex = 0;
            for (i = 0; i < a; i++)
            {
                if (min > x[i])
                {
                    min = x[i];
                    minIndex = i;
                }

                Console.Write(" {0}", x[i]);
             
                
            }
            Console.WriteLine(" Minimal element = {0}", min);

            Console.ReadLine();
        }

        //Գտնել թվային զանգվածի էլեմենտներից մեծագույնը։
        static void array7()

        {

            Console.Write("Input array length = ");
            int a = int.Parse(Console.ReadLine());
            int i;
            int b;

            int[] x = new int[a];
            for (i = 0; i < a; i++)
            {
                Console.Write("Input array element = ");
                b = int.Parse(Console.ReadLine());
                x[i] = b;

            }

            int max = x[0], maxIndex = 0;
            for (i = 0; i < a; i++)
            {
                if (max < x[i])
                {
                    max = x[i];
                    maxIndex = i;
                }

                Console.Write(" {0}", x[i]);


            }
            Console.WriteLine(" Maximal element = {0}", max);

            Console.ReadLine();
        }
        //Գրել ծրագիր, որը կպատճենի a զանգվածը b զանգվածի մեջ։

        static void array8()

        {

            Console.Write("Input array length = ");
            int a = int.Parse(Console.ReadLine());
            int i;
            int b;
            int c;

            int[] x = new int[a];
            int[] y = new int[c];
            for (i = 0; i < a; i++)
            {
                Console.Write("Input array element = ");
                b = int.Parse(Console.ReadLine());
                x[i] = b;

            }

            for (i = 0; i < a; i++)
            {
                Console.Write(" {0}", y[i]);
            }

            Console.ReadLine();
        }

        //Գրել ծրագիր, որը կհակադարձի զանգվածը։
        //Գրել ծրագիր, որը կգումարի էլեմենտ առ էլեմենտ a և b զանգվածները և արդյունքը կպահի c զանգվածի մեջ։
        //Գրել ծրագիր, որը կբազմապատկի էլեմենտ առ էլեմենտ a և b զանգվածները և արդյունքը կպահի c զանգվածի մեջ։
    }
}
