internal class Program
{
    private static void Main(string[] args)
    {
        bool flag = true;
        do
        {
            Console.Clear();
            Console.WriteLine("----------- MENÚ --------------");
            Console.WriteLine("1. Mostrar número Fibonacci");
            Console.WriteLine("2. Verificar si es número Fibonacci");
            Console.WriteLine("3. Mostrar cierta cantidad de números Fibonacci");
            Console.WriteLine("4. Salir del Programa");
            Console.WriteLine("-------------------------------------------");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Clear();
                    System.Console.Write("Ingrese número que desee convetir: ");
                    int num = int.Parse(Console.ReadLine());
                    if (num < 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Error en número digitado");
                    }
                    else
                    {
                        int num1 = 0;
                        int num2 = 1;
                        for (int i = 0; i < num; i++)
                        {
                            int temp = num1;
                            num1 = num2;
                            num2 = temp + num1;
                        }
                        System.Console.WriteLine("F{0} = {1}", num, num1);
                    }
                    break;

                case "2":
                    Console.Clear();
                    List<int> list = new List<int>();
                    System.Console.Write("Ingrese número que desee verificar: ");
                    int opt = Convert.ToInt32(Console.ReadLine());
                    if (opt < 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Error en número digitado");
                    }
                    else
                    {
                        int num1 = 0;
                        int num2 = 1;
                        for (int i = 0; i < opt; i++)
                        {
                            int temp = num1;
                            num1 = num2;
                            num2 = temp + num1;
                            list.Add(num1);
                        }
                        if (list.Contains(opt))
                        {
                            System.Console.WriteLine("{0} Si es un número Fibonacci", opt);
                        }
                        else
                        {
                            System.Console.WriteLine("{0} No es un número Fibonacci", opt);
                        }

                    }
                    break;
                case "3":
                    Console.Clear();
                    System.Console.Write("Ingrese cantidad de números Fibonacci a mostrar: ");
                    int a = int.Parse(Console.ReadLine());
                    if (a <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Error en número digitado");
                    }
                    else
                    {
                        int f = 0;
                        int s = 1;
                        for (int i = 0; i < a; i++)
                        {
                            int temp = f;
                            f = s;
                            s = temp + f;
                            System.Console.WriteLine("F{0} = {1}", i + 1, f);
                        };
                    }
                    break;

                case "4":
                    Console.Clear();
                    System.Console.WriteLine("Adioos!!");
                    flag = false;
                    break;
            }
            System.Console.WriteLine("Pulse cualquier tecla");
            Console.ReadLine();
        } while (flag);


    }
}