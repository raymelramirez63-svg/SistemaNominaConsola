namespace SistemaNominaConsola.Models;

public abstract class Empleado
{
    public string PrimerNombre { get; set; } = string.Empty;
    public string ApellidoPaterno { get; set; } = string.Empty;
    public string NumeroSeguroSocial { get; set; } = string.Empty;
    public TipoEmpleado Tipo { get; protected set; }

    public abstract decimal CalcularPago();

    public virtual string ObtenerDetalle()
    {
        return $"{PrimerNombre} {ApellidoPaterno} | NSS: {NumeroSeguroSocial} | Tipo: {Tipo}";
    }
}