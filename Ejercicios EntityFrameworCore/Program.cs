using Ejercicios_EntityFrameworCore.Ejemplos;
using System;

namespace Ejercicios_EntityFrameworCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static void Menu()
        {
           
            int opcion = 0;
            string aux = string.Empty;
            do
            {
                Console.WriteLine("\n\n    Emminton Manuel Ureña Santana 2017-0286      MENU:           ");
                Console.WriteLine("1. Guardar un estudiante en la BD.");
                Console.WriteLine("2. Hacer un simple Query.");              
                Console.WriteLine("3. Hacer un query usando SQL.");
                Console.WriteLine("5. Actualizar data de una entidad.");
                Console.WriteLine("4. Borrar data de una entidad.");
                Console.WriteLine("6. Hacer Querry Parametrizado.");
                Console.WriteLine("7. Salir.");
                Console.WriteLine("OPCION:");
                aux = Console.ReadLine();
                opcion = Convert.ToInt32(aux);               
                switch (opcion)
                {
                    case 1:
                        EjemplosEntytiFramawork.GuardarStudentDB();
                        Console.ReadKey();
                        break;
                    case 2:
                        EjemplosEntytiFramawork.SimpleQueryDB(); 
                        Console.ReadKey();
                        break;                
                    case 3:
                        EjemplosEntytiFramawork.QuerryUsingSql(); 
                        Console.ReadKey();
                        break;                   
                    case 4:
                        EjemplosEntytiFramawork.DeletingData();
                        Console.ReadKey();
                        break;
                    case 5:
                        EjemplosEntytiFramawork.UpdatingOnDisconnectedScenario(); 
                        Console.ReadKey();
                        break;      
                    case 6:
                        EjemplosEntytiFramawork.QuerryParametrizado(); 
                        Console.ReadKey();
                        break;
                    case 7:
                        break;
                }
            }
            while (opcion != 7);
            {
                Console.WriteLine("Solo es hasta el numero 7");

            }
        }
    }
}


