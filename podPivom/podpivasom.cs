using System;

namespace podPivom
{
    class Program
    {
        static void vibor()
        {
            
            ConsoleKeyInfo okteyva = Console.ReadKey();
            while (okteyva.Key != ConsoleKey.Escape)
            {
                if (okteyva.Key == ConsoleKey.F3)
                    zamena1();
                if (okteyva.Key == ConsoleKey.F4)
                    zamena2();
                if (okteyva.Key == ConsoleKey.F5)
                    zamena3();
            }
        }
            

       
        static void okteyva1()
        {

                ConsoleKeyInfo okteyva = Console.ReadKey();
                int[] okteyva1 = new int[] { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
            while (okteyva.Key != ConsoleKey.Escape)
            {
                if (okteyva.Key == ConsoleKey.F4)
                    zamena1();
                if (okteyva.Key == ConsoleKey.F5)
                    zamena2();

                if (okteyva.Key == ConsoleKey.Z)
                    Console.Beep(okteyva1[0], 313);
                if (okteyva.Key == ConsoleKey.S)
                    Console.Beep(okteyva1[1], 313);
                if (okteyva.Key == ConsoleKey.X)
                    Console.Beep(okteyva1[2], 313);
                if (okteyva.Key == ConsoleKey.D)
                    Console.Beep(okteyva1[3], 313);
                if (okteyva.Key == ConsoleKey.C)
                    Console.Beep(okteyva1[4], 313);
                if (okteyva.Key == ConsoleKey.F)
                    Console.Beep(okteyva1[5], 313);
                if (okteyva.Key == ConsoleKey.V)
                    Console.Beep(okteyva1[6], 313);
                if (okteyva.Key == ConsoleKey.G)
                    Console.Beep(okteyva1[7], 313);
                if (okteyva.Key == ConsoleKey.B)
                    Console.Beep(okteyva1[8], 313);
                if (okteyva.Key == ConsoleKey.H)
                    Console.Beep(okteyva1[9], 313);
                if (okteyva.Key == ConsoleKey.N)
                    Console.Beep(okteyva1[10], 313);
                if (okteyva.Key == ConsoleKey.J)
                    Console.Beep(okteyva1[11], 313);
                okteyva = Console.ReadKey();
            }


            Console.Clear();
            
        }
        static void okteyva2()
        {
                ConsoleKeyInfo okteyva = Console.ReadKey();
                int[] okteyva2 = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
            while (okteyva.Key != ConsoleKey.Escape)
            {
                if (okteyva.Key == ConsoleKey.F5)
                    zamena2();
                if (okteyva.Key == ConsoleKey.F3)
                    zamena3();

                if (okteyva.Key == ConsoleKey.Z)
                    Console.Beep(okteyva2[0], 313);
                if (okteyva.Key == ConsoleKey.S)
                    Console.Beep(okteyva2[1], 313);
                if (okteyva.Key == ConsoleKey.X)
                    Console.Beep(okteyva2[2], 313);
                if (okteyva.Key == ConsoleKey.D)
                    Console.Beep(okteyva2[3], 313);
                if (okteyva.Key == ConsoleKey.C)
                    Console.Beep(okteyva2[4], 313);
                if (okteyva.Key == ConsoleKey.F)
                    Console.Beep(okteyva2[5], 313);
                if (okteyva.Key == ConsoleKey.V)
                    Console.Beep(okteyva2[6], 313);
                if (okteyva.Key == ConsoleKey.G)
                    Console.Beep(okteyva2[7], 313);
                if (okteyva.Key == ConsoleKey.B)
                    Console.Beep(okteyva2[8], 313);
                if (okteyva.Key == ConsoleKey.H)
                    Console.Beep(okteyva2[9], 313);
                if (okteyva.Key == ConsoleKey.N)
                    Console.Beep(okteyva2[10], 313);
                if (okteyva.Key == ConsoleKey.J)
                    Console.Beep(okteyva2[11], 313);
                okteyva = Console.ReadKey();
            }

            Console.Clear();
              
        }
        static void okteyva3()
        {

                ConsoleKeyInfo okteyva = Console.ReadKey();
                int[] okteyva3 = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987};
            while (okteyva.Key != ConsoleKey.Escape)
            {
                if (okteyva.Key == ConsoleKey.F3)
                    zamena3();
                if (okteyva.Key == ConsoleKey.F4)
                    zamena1();


                if (okteyva.Key == ConsoleKey.Z)
                    Console.Beep(okteyva3[0], 313);
                if (okteyva.Key == ConsoleKey.S)
                    Console.Beep(okteyva3[1], 313);
                if (okteyva.Key == ConsoleKey.X)
                    Console.Beep(okteyva3[2], 313);
                if (okteyva.Key == ConsoleKey.D)
                    Console.Beep(okteyva3[3], 313);
                if (okteyva.Key == ConsoleKey.C)
                    Console.Beep(okteyva3[4], 313);
                if (okteyva.Key == ConsoleKey.F)
                    Console.Beep(okteyva3[5], 313);
                if (okteyva.Key == ConsoleKey.V)
                    Console.Beep(okteyva3[6], 313);
                if (okteyva.Key == ConsoleKey.G)
                    Console.Beep(okteyva3[7], 313);
                if (okteyva.Key == ConsoleKey.B)
                    Console.Beep(okteyva3[8], 313);
                if (okteyva.Key == ConsoleKey.H)
                    Console.Beep(okteyva3[9], 313);
                if (okteyva.Key == ConsoleKey.N)
                    Console.Beep(okteyva3[10], 313);
                if (okteyva.Key == ConsoleKey.J)
                    Console.Beep(okteyva3[11], 313);
                okteyva = Console.ReadKey();
            }

            Console.Clear();
              
        }




        static void Main()
        {
            Console.WriteLine("Выберите октейву");
            Console.WriteLine("1-я октейва F3");
            Console.WriteLine("2-я октейва F4");
            Console.WriteLine("3-я октейва F5");
            vibor();
           
        }
        static void zamena1()
        {
            
            okteyva2();
        }
        static void zamena2()
        {
            okteyva3();
        }
        static void zamena3()
        {
            okteyva1();
        }
    }
}
