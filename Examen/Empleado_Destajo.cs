class Empleado_Destajo : Empleado
{
    public int NumClientes { get; set; }

    public double CalcularPago()
    {
        return NumClientes * 130;
    }
}