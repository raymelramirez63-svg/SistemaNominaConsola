namespace SistemaNominaConsola.Models;

public class EmpleadoAsalariadoPorComision : Empleado
{
    public decimal VentasBrutas { get; set; }
    public decimal TarifaComision { get; set; }
    public decimal SalarioBase { get; set; }

    public EmpleadoAsalariadoPorComision()
    {
        Tipo = TipoEmpleado.AsalariadoPorComision;
    }

    public override decimal CalcularPago()
    {
        decimal comision = VentasBrutas * TarifaComision;
        decimal bono = SalarioBase * 0.10m;
        return comision + SalarioBase + bono;
    }

    public override string ObtenerDetalle() =>
        $"{base.ObtenerDetalle()} | Base: {SalarioBase:C2} | Ventas: {VentasBrutas:C2} a {TarifaComision:P2}";
}