namespace SistemaNominaConsola.Models;

public class EmpleadoAsalariado : Empleado
{
    public decimal SalarioSemanal { get; set; }

    public EmpleadoAsalariado()
    {
        Tipo = TipoEmpleado.Asalariado;
    }

    public override decimal CalcularPago() => SalarioSemanal;

    public override string ObtenerDetalle() =>
        $"{base.ObtenerDetalle()} | Salario Fijo: {SalarioSemanal:C2}";
}