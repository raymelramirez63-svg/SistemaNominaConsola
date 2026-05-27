using SistemaNominaConsola.Models;

namespace SistemaNominaConsola.Services;

public class NominaService
{
    private readonly List<Empleado> _empleados = new();

    public void AgregarEmpleado(Empleado empleado)
    {
        _empleados.Add(empleado);
    }

    public Empleado? BuscarPorNss(string nss)
    {
        return _empleados.FirstOrDefault(e => e.NumeroSeguroSocial == nss);
    }

    public void GenerarReporte()
    {
        Console.Clear();
        Console.WriteLine("=== REPORTE SEMANAL DE NÓMINA ====");

        if (_empleados.Count == 0)
        {
            Console.WriteLine("===No hay empleados registrados en el sistema.===");
            return;
        }

        decimal totalNomina = 0;
        foreach (var emp in _empleados)
        {
            decimal pago = emp.CalcularPago();
            totalNomina += pago;

            Console.WriteLine(new string('-', 70));
            Console.WriteLine(emp.ObtenerDetalle());
            Console.WriteLine($"Pago Semanal Calculado: {pago:C2}");
        }

        Console.WriteLine(new string('=', 70));
        Console.WriteLine("TOTAL A PAGAR EN NÓMINA: {totalNomina:C2}");
    }
}