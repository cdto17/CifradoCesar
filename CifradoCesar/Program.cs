namespace Cifrado_Cesar 
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alfabeto = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
            'Q','R','S','T','U','V','W','X','Y','Z'};
            char[] mensaje;
            int valor;
            int opcion;
            string cifrado = "", descrifrado = "";
            Console.WriteLine("");
            int bandera = 1;

            do
            {
                Console.WriteLine("Escoga una opcion a realizar: ");
                Console.Write("1. Cifrar  2. Descifrar: ");
                try
                {
                    opcion = int.Parse(Console.ReadLine());
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("No se ha introducido el valor correcto, se tomará como número 1");
                    opcion = 1;
                }
                switch (opcion)
                {
                    case 1:
                      
                            Console.Write("\nIngrese el mensaje para cifrar: ");
                            mensaje = Console.ReadLine().ToUpper().ToCharArray();
                        

                        for (int i = 0; i < mensaje.Length; i++)
                        {
                            for (int j = 0; j < alfabeto.Length; j++)
                            {
                                if (mensaje[i] == alfabeto[j])
                                {
                                    valor = alfabeto[j];
                                    int formula = ((valor - 65) + 2)% alfabeto.Length;
                                    int conversionASCII = formula + 65;
                                    cifrado = cifrado + (char)conversionASCII + " ";
                                }
                            }
                        }
                        if (cifrado != "")
                        {
                            Console.WriteLine("Mensaje cifrado: " +cifrado);
                            cifrado = "";

                        }  
                        else
                        {
                            Console.WriteLine("Cadena Vacia!");
                        }
                        break;

                    case 2:
                        Console.Write("\nIngrese el mensaje para descifrar: ");
                        mensaje = Console.ReadLine().ToUpper().ToCharArray();

                        for (int i = 0; i < mensaje.Length; i++)
                        {
                            for (int j = 0; j < alfabeto.Length; j++)
                            {
                                if (mensaje[i] == alfabeto[j])
                                {
                                    valor = alfabeto[j];    
                                    int operacion = ((valor - 65) - 2) % alfabeto.Length;
                                    int operacionASCII = operacion + 65;

                                    if (operacionASCII == 63 ||  operacionASCII == 64)
                                    {
                                        descrifrado = descrifrado + ((char)(operacionASCII + 26) + " ");
                                    }
                                    if (operacionASCII >= 65  && operacionASCII <= 90)
                                    {
                                        descrifrado = descrifrado + (char)operacionASCII + "";
                                    }
                                }
                            }
                        }
                        if (descrifrado != "")
                        {
                            Console.WriteLine("Mensaje descifrado: " +descrifrado);
                            descrifrado = "";
                        }
                        else
                        {
                            Console.WriteLine("Cadena Vacia!");   
                        }
                        break;

                    default:
                        Console.WriteLine("Ingrese una opcion válida");
                        break;
                }
                Console.WriteLine(" ");
                Console.WriteLine("\t\r¿Desea cifrar/descifrar otro mensaje?: ");
                try
                {
                    Console.Write("1. Cifrar/Descifrar  0. Salir : ");
                    bandera = int.Parse(Console.ReadLine());
                }
                catch (FormatException a)
                {
                    Console.WriteLine("No se ha introducido un valor correcto, se tomará como opción 1");
                }
                Console.WriteLine("\n------------------------------\n");
            }
            while (bandera==1);
            Environment.Exit(0);

        }
    }
}
