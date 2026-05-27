namespace SistemaNominaConsola.Models;

public class EmpleadoPorHoras : Empleado
{
    public decimal SueldoPorHora { get; set; }
    public decimal HorasTrabajadas { get; set; }

    public EmpleadoPorHoras()
    {
        Tipo = TipoEmpleado.PorHoras;
    }

    public override decimal CalcularPago()
    {
        if (HorasTrabajadas <= 40)
            return SueldoPorHora * HorasTrabajadas;

        decimal pagoRegular = SueldoPorHora * 40;
        decimal pagoExtra = SueldoPorHora * 1.5m * (HorasTrabajadas - 40);
        return pagoRegular + pagoExtra;
    }

    public override string ObtenerDetalle() =>
        $"{base.ObtenerDetalle()} | {HorasTrabajadas}h a {SueldoPorHora:C2}/h";
}