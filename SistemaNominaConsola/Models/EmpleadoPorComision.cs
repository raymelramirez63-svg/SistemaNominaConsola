namespace SistemaNominaConsola.Models;

public class EmpleadoPorComision : Empleado
{
    public decimal VentasBrutas { get; set; }
    public decimal TarifaComision { get; set; }

    public EmpleadoPorComision()
    {
        Tipo = TipoEmpleado.PorComision;
    }

    public override decimal CalcularPago() => VentasBrutas * TarifaComision;

    public override string ObtenerDetalle() =>
        $"{base.ObtenerDetalle()} | Ventas: {VentasBrutas:C2} | Tarifa: {TarifaComision:P2}";
}