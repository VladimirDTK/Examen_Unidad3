class Empleado_Contratado : Empleado
{
    public int AniosExperiencia { get; set; }

    public double CalcularSalario()
    {
        double salarioFijo = 1000;
        double porcentaje = 0;
        if (AniosExperiencia <= 3)
        {
            porcentaje = 0.05;
        }
        else if (AniosExperiencia <= 7)
        {
            porcentaje = 0.1;
        }
        else if (AniosExperiencia <= 15)
        {
            porcentaje = 0.15;
        }
        else
        {
            porcentaje = 0.2;
        }
        return salarioFijo * (1 + porcentaje);
    }
}