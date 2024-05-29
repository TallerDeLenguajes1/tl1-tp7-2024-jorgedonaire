using Microsoft.VisualBasic;

namespace SistemaDeAdministracion;
enum Cargos
{
    Auxiliar,
    Admistrativo,
    Ingeniero,
    Especialista,
    Investigador
}
public class Empleado
{
    private String nombre;
    private String apellido;
    private DateTime fechaDeNacimiento;
    private Char estadoCivil;
    private DateTime fechaDeIngreso;
    private Double sueldoBasico;
    private int resultadoAntiguedad;
    private int resultadoEdad;
    private TimeSpan resultadosAniosParaJubilarse;
    private Cargos cargo;
////////////////////////////////77
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaDeIngreso { get => fechaDeIngreso; set => fechaDeIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    internal Cargos Cargo { get => cargo; set => cargo = value; }
    public int antiguedad(){ //CONSULTAR. Porque no devuelve void y paso parametro del empleado
        DateTime fechaActual = DateTime.Now;
        int resultadoAntiguedad = fechaActual.Year - FechaDeIngreso.Year;
        return resultadoAntiguedad;
    }
    // public int obtenerAntiguedad{ //CONSULTAR. Porque no utilizo este metodo para obtener los resultados como el punto anterior
    //     get => resultadoAntiguedad;
    // }
    public int edad(){
        DateTime fechaActual = DateTime.Now;
        int resultadoEdad = fechaActual.Year - FechaDeNacimiento.Year;        
        return resultadoEdad;
    }
    // public int obtenerEdad{
    //     get => resultadoEdad;
    // }
    public TimeSpan aniosParaJubilarse(){
        DateTime fechaActual = DateTime.Now;
        TimeSpan resultadosAniosParaJubilarse = fechaActual - FechaDeIngreso;
        return resultadosAniosParaJubilarse;
    }
    // public TimeSpan obtenerAniosParaJubilarse{
    //     get => resultadosAniosParaJubilarse;
    // }
    public Double CalcularSalario(){ //CONSULTAR. Porque no paso por parametro el empleado
        double adicional = 0;

        if (antiguedad() <= 20)
        {
            adicional += 1 + (0.01 * antiguedad());
        }else
        {
            adicional = 1.25;
        }

        if (Cargo.ToString() == Cargos.Ingeniero.ToString() || Cargo.ToString() == Cargos.Especialista.ToString())
        {
            adicional *= 1.5;
        }

        if (EstadoCivil == 'c')
        {
            adicional += 150000;
        }

        return adicional;
    }


}