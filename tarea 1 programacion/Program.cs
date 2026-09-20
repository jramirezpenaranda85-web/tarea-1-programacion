
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasetiposdatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa para calcular salarios de N empleados

            int cantidadEmpleados;
            int tipoEmpleado;

            string cedula;
            string nombre;
            string tipoNombre;

            double horas;
            double precioHora;
            double salarioOrdinario;
            double aumento;
            double salarioBruto;
            double deduccionCCSS;
            double salarioNeto;

            Console.WriteLine("Digite la cantidad de empleados:");
            cantidadEmpleados = int.Parse(Console.ReadLine());

            // Ciclo para ingresar los empleados

            for (int i = 1; i <= cantidadEmpleados; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("EMPLEADO NUMERO: " + i);

                Console.WriteLine("Digite la cedula:");
                cedula = Console.ReadLine();

                Console.WriteLine("Digite el nombre del empleado:");
                nombre = Console.ReadLine();

                Console.WriteLine("Digite el tipo de empleado:");
                Console.WriteLine("1 - Operario");
                Console.WriteLine("2 - Tecnico");
                Console.WriteLine("3 - Profesional");

                tipoEmpleado = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite la cantidad de horas laboradas:");
                horas = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite el precio por hora:");
                precioHora = double.Parse(Console.ReadLine());

                // Calcular salario ordinario

                salarioOrdinario = horas * precioHora;

                // Calcular aumento segun tipo de empleado

                if (tipoEmpleado == 1)
                {
                    tipoNombre = "Operario";
                    aumento = salarioOrdinario * 0.15;
                }
                else if (tipoEmpleado == 2)
                {
                    tipoNombre = "Tecnico";
                    aumento = salarioOrdinario * 0.10;
                }
                else if (tipoEmpleado == 3)
                {
                    tipoNombre = "Profesional";
                    aumento = salarioOrdinario * 0.05;
                }
                else
                {
                    tipoNombre = "No valido";
                    aumento = 0;
                }

                // Calcular salario bruto

                salarioBruto = salarioOrdinario + aumento;

                // Calcular deduccion CCSS del 9.17%

                deduccionCCSS = salarioBruto * 0.0917;

                // Calcular salario neto

                salarioNeto = salarioBruto - deduccionCCSS;

                // Mostrar resultados

                Console.WriteLine("");
                Console.WriteLine("========== RESULTADOS ==========");

                Console.WriteLine("Cedula: " + cedula);
                Console.WriteLine("Nombre Empleado: " + nombre);
                Console.WriteLine("Tipo Empleado: " + tipoNombre);
                Console.WriteLine("Salario por Hora: " + precioHora);
                Console.WriteLine("Cantidad de Horas: " + horas);

                Console.WriteLine("Salario Ordinario: " + salarioOrdinario);
                Console.WriteLine("Aumento: " + aumento);
                Console.WriteLine("Salario Bruto: " + salarioBruto);
                Console.WriteLine("Deduccion CCSS: " + deduccionCCSS);
                Console.WriteLine("Salario Neto: " + salarioNeto);

                Console.WriteLine("================================");
            }

            Console.WriteLine("");
            Console.WriteLine("Proceso finalizado.");
            Console.ReadKey();
        }
    }
}