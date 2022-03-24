using System;
using System.Linq;

namespace CAI_EjerciciosRepaso
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            #region Ejercicio 1

            /*
            int Registro;
            int i;
            string RegistroString;
            bool Continuar = true;

            //Se solicita el ingreso del registro

            do
            {
                Console.WriteLine("A continuación ingrese su nro de Registro.");
                Console.WriteLine("Recuerde que debe ser un entero > 0 y < 999999.");

                if ((int.TryParse(Console.ReadLine(), out Registro)) == true && Herramientas.ValidarLimites(Registro, 0, 999999) == true)
                {
                    //Obtengo los últimos tres dígitos del Registro

                    //1º convierto en string el nro de registro
                    RegistroString = Registro.ToString();

                    //2º Obtengo los último tres nros del string

                    RegistroString = RegistroString.Substring(RegistroString.Length - 3);

                    //3º Tomo el valor del string y lo convierto en entero

                    Registro = Int32.Parse(RegistroString);

                    //Si el registro es menor a 100 le sumo 100 como indica la consigna
                    if (Registro < 100) Registro = Registro + 100;

                    //Comienza la consigna
                    for (i = 1; i < Registro + 1; i++)
                    {
                        if (i % 3 == 0 && i % 5 == 0)
                        {
                            //El nro es múltiplo de 3 y 5
                            Console.WriteLine(i + " - FooBar");
                        }
                        else if (i %3 == 0)
                        {
                            //El nro es múltiplo únicamente de 3
                            Console.WriteLine(i + " - Foo");
                        }
                        else if (i % 5 == 0)
                        {
                            //El nro es múltiplo únicamente de 5
                            Console.WriteLine(i + " - Bar");
                        }
                        else
                        {
                            //El número no es múltiplo de 3 ni de 5
                            Console.WriteLine(i);
                        }
                    }

                    Console.WriteLine("Se ejecutó el programa con éxito, presione cualquier tecla para salir.");
                    Console.ReadKey();
                    Continuar = false;
                } else
                {
                    Console.WriteLine("Ha ingresado un valor incorrecto, presione cualquier tecla para continuar.");
                    Console.ReadKey();
                    Continuar = true;
                }

            } while (Continuar);

            Herramientas.Salir();
            
            */

            #endregion



            #region Ejercicio 2
            /*
            
            int Registro;
            int i;
            string RegistroString;
            bool Continuar = true;

            //Se solicita el ingreso del registro

            do
            {
                Console.WriteLine("A continuación ingrese su nro de Registro.");
                Console.WriteLine("Recuerde que debe ser un entero > 0 y < 999999.");

                if ((int.TryParse(Console.ReadLine(), out Registro)) == true && Herramientas.ValidarLimites(Registro, 0, 999999) == true)
                {
                    //Obtengo los últimos tres dígitos del Registro

                    //1º convierto en string el nro de registro
                    RegistroString = Registro.ToString();

                    //2º Obtengo los último tres nros del string

                    RegistroString = RegistroString.Substring(RegistroString.Length - 3);

                    //3º Tomo el valor del string y lo convierto en entero

                    Registro = Int32.Parse(RegistroString);

                    //Si el registro es menor a 100 le sumo 100 como indica la consigna
                    if (Registro < 100) Registro = Registro + 100;

                    //Comienza la consigna
                    for (i = 1; i < Registro + 1; i++)
                    {
                        if (i % 3 == 0 && Herramientas.VerificarSiEsPrimo(i))
                        {
                            //El nro es múltiplo de 3 y es Primo
                            Console.WriteLine(i + " - Es primo y divisible por 3");
                        }
                        else if (i %3 == 0)
                        {
                            //El nro es múltiplo únicamente de 3
                            Console.WriteLine(i + " - Es divisible por 3");
                        }
                        else if (Herramientas.VerificarSiEsPrimo(i))
                        {
                            //El nro es Primo
                            Console.WriteLine(i + " - Es primo");
                        }
                        else
                        {
                            //El número no es múltiplo de 3 ni es primo
                            Console.WriteLine(i);
                        }
                    }

                    Console.WriteLine("Se ejecutó el programa con éxito, presione cualquier tecla para salir.");
                    Console.ReadKey();
                    Continuar = false;
                } else
                {
                    Console.WriteLine("Ha ingresado un valor incorrecto, presione cualquier tecla para continuar.");
                    Console.ReadKey();
                    Continuar = true;
                }

            } while (Continuar);

            Herramientas.Salir();
            */

            #endregion


            #region Ejercicio 3
            /*

            bool Continuar = true;
            string Palabra = null;
            bool Palindromo = false;
            int i;
            //bool Simetria = true;

            do
            {
                Console.WriteLine("** A continuación ingrese una palabra para verificar si es un Palíndromo");
                Palabra = Console.ReadLine();
                if (Palabra == null || Palabra.Contains(" ") || Palabra.Length == 0)
                {
                    Console.WriteLine("No ha ingresado una palabra, pulse cualquier tecla para intentar de nuevo");
                    Console.ReadKey();
                    Continuar = true;
                }
                else
                {
                    //Se verificó que se ha ingresado una palabra, ahora se verificará si es un palíndromo

                    //Si la palabra es de dos letras, no puede ser palíndromo.
                    if (Palabra.Length == 2)
                    {
                        Palindromo = false;
                    }
                    //Si la palabra tiene 3 letras, es más fácil verificar
                    else if (Palabra.Length == 3)
                    {
                        if (Palabra[0] == Palabra[2])
                        {
                            Palindromo = true;
                        }
                    }
                    else
                    {
                        //Parto definiendo que es un palíndromo pero lo cambio ante la primer diferencia
                        Palindromo = true;

                        for (i = 0; i < Palabra.Length / 2; i++)
                        {
                            if (Palabra[i] != Palabra[Palabra.Length - (i + 1)])
                            {
                                Palindromo = false;
                                break;
                            }
                        }
                    }

                    if (Palindromo)
                    {
                        Console.WriteLine("La palabra ingresada es un palíndromo.");
                    }
                    else
                    {
                        Console.WriteLine("La palabra ingresada NO es un palíndromo.");
                    }
                    Continuar = false;
                    Console.WriteLine("Presione cualquier tecla para terminar el programa.");
                    Console.ReadKey();
                }

            } while (Continuar);

            Herramientas.Salir();
            */

            #endregion


            #region Ejercicio 4









            #endregion

        }
    }
}
