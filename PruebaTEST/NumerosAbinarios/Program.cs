using System;

namespace NumerosAbinarios
{
    class Program
    {

    
        static void Main(string[] args)
        {

            bool estatus = true;
            while (estatus)
            {
                Console.Clear();
                Console.WriteLine(" SELECCIONE UNA OPCION.");
                Console.WriteLine(" 1.- CONVERTIR NUMEROS ENTEROS A BINARIOS.");
                Console.WriteLine(" 2.- NUMEROS PRIMOS DEL 1-100");
                Console.WriteLine(" 3.- MENSAJES");
                Console.Write("\r\n OPCION :");


                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("¿INGRESE VALOR NUMERICO A CONVERTIR ?");
                        int val = Convert.ToInt32(Console.ReadLine());
                        string binary2 = Convert.ToString(val, 2);
                        Console.WriteLine("Num binario: " + binary2);

                        Console.WriteLine("Precione  ENTER para regresar al menu");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("LOS SIGUIENTES NUMEROS SON PRIMOS DEL 1 AL 100.");
                        var numero = 100;
                        for (int i = 1; i <= numero; i++)
                        {
                            if (ValidaNumeroPrimo(i))
                            {
                                Console.WriteLine( i.ToString() +" Es primo");
                            }
                        }

                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine(" 1.- Mensaje EMAIL.");
                        Console.WriteLine(" 2.- Mensaje SMS.");
                        Console.Write("\r\n OPCION :");
                        int Opcionmensaje = Convert.ToInt32(Console.ReadLine());
                        Mensaje men = new Mensaje();
                        switch (Opcionmensaje)
                        {
                            case 1:
                              
                                var op1 = new PrincipalService(men);
                                Console.WriteLine(op1.EmailMensaje());
                                Console.ReadKey();
                                break;
                            case 2:
                               // Mensaje men = new Mensaje();
                                var principal = new PrincipalService(men);
                                Console.WriteLine(principal.SmsMensaje());
                                Console.ReadKey();

                                break;
                            default:
                                break;
                        }
                       

                      
                        break;
                }

            }



        }


        static bool ValidaNumeroPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                   
                    return false;
                }
                else
                {

                }
            }
           
            return true;
        }

    }
}
