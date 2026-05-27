using SistemaNominaConsola.Models;
using SistemaNominaConsola.Services;

var servicioNomina = new NominaService();
bool salir = false;

while (!salir)
{
    Console.Clear();
    Console.WriteLine("=== SISTEMA DE GESTIÓN DE NÓMINA ===");
    Console.WriteLine("1. Agregar Empleado Asalariado");
    Console.WriteLine("2. Agregar Empleado por Horas");
    Console.WriteLine("3. Agregar Empleado por Comisión");
    Console.WriteLine("4. Agregar Empleado Asalariado por Comisión");
    Console.WriteLine("5. Actualizar Empleado (Recalcular Pago)");
    Console.WriteLine("6. Generar Reporte Semanal");
    Console.WriteLine("7. Salir");
    Console.Write("\nSeleccione una opción: ");

    string opcion = Console.ReadLine() ?? "";

    switch (opcion)
    {
        case "1":
            var empAsalariado = new EmpleadoAsalariado();
            CapturarDatosBase(empAsalariado);
            Console.Write("Salario Semanal: ");
            empAsalariado.SalarioSemanal = Convert.ToDecimal(Console.ReadLine());
            servicioNomina.AgregarEmpleado(empAsalariado);
            MensajeExito();
            break;

        case "2":
            var empHoras = new EmpleadoPorHoras();
            CapturarDatosBase(empHoras, true);
            Console.Write("Sueldo por Hora: ");
            empHoras.SueldoPorHora = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Horas Trabajadas: ");
            empHoras.HorasTrabajadas = Convert.ToDecimal(Console.ReadLine());
            servicioNomina.AgregarEmpleado(empHoras);
            MensajeExito();
            break;

        case "3":
            var empComision = new EmpleadoPorComision();
            CapturarDatosBase(empComision);
            Console.Write("Ventas Brutas: ");
            empComision.VentasBrutas = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Tarifa de Comisión (ej. 0.05 para 5%): ");
            empComision.TarifaComision = Convert.ToDecimal(Console.ReadLine());
            servicioNomina.AgregarEmpleado(empComision);
            MensajeExito();
            break;

        case "4":
            var empAsalComision = new EmpleadoAsalariadoPorComision();
            CapturarDatosBase(empAsalComision);
            Console.Write("Ventas Brutas: ");
            empAsalComision.VentasBrutas = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Tarifa de Comisión ");
            empAsalComision.TarifaComision = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Salario Base: ");
            empAsalComision.SalarioBase = Convert.ToDecimal(Console.ReadLine());
            servicioNomina.AgregarEmpleado(empAsalComision);
            MensajeExito();
            break;

        case "5":
            Console.Write("\nIngrese el NSS del empleado a actualizar: ");
            string nssActualizar = Console.ReadLine() ?? "";
            var empleadoActualizar = servicioNomina.BuscarPorNss(nssActualizar);

            if (empleadoActualizar == null)
            {
                Console.WriteLine("Empleado no encontrado con ese número de seguro social.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"\nEmpleado encontrado: {empleadoActualizar.ObtenerDetalle()}");

                if (empleadoActualizar is EmpleadoAsalariado ea)
                {
                    Console.Write("Nuevo Salario Semanal: ");
                    ea.SalarioSemanal = Convert.ToDecimal(Console.ReadLine());
                }
                else if (empleadoActualizar is EmpleadoPorHoras eh)
                {
                    Console.Write("Nuevas Horas Trabajadas: ");
                    eh.HorasTrabajadas = Convert.ToDecimal(Console.ReadLine());
                }
                else if (empleadoActualizar is EmpleadoPorComision ec)
                {
                    Console.Write("Nuevas Ventas Brutas: ");
                    ec.VentasBrutas = Convert.ToDecimal(Console.ReadLine());
                }
                else if (empleadoActualizar is EmpleadoAsalariadoPorComision eac)
                {
                    Console.Write("Nuevas Ventas Brutas: ");
                    eac.VentasBrutas = Convert.ToDecimal(Console.ReadLine());
                }
                MensajeExito();
            }
            break;

        case "6":
            servicioNomina.GenerarReporte();
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
            break;

        case "7":
            salir = true;
            break;

        default:
            Console.WriteLine("Opción no válida. Presione cualquier tecla para continuar...");
            Console.ReadKey();
            break;
    }
}

void CapturarDatosBase(Empleado emp, bool omitirPrimerNombre = false)
{
    Console.WriteLine("--- Nuevo {emp.Tipo} ---");
    if (!omitirPrimerNombre)
    {
        Console.Write("Primer Nombre: ");
        emp.PrimerNombre = Console.ReadLine() ?? "";
    }
    Console.Write("Apellido Paterno: ");
    emp.ApellidoPaterno = Console.ReadLine() ?? "";
    Console.Write("NSS (Número de Seguro Social): ");
    emp.NumeroSeguroSocial = Console.ReadLine() ?? "";
}

void MensajeExito()
{
    Console.WriteLine("Operación realizada con éxito, Presione cualquier tecla para continuar...");
    Console.ReadKey();
}