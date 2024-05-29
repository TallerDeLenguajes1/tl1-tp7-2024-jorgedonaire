namespace EspacioCalculadora;

public class Calculadora
{
    private double dato;

    public Calculadora(int valorInicial) //constructor con parametro
    {
        dato = valorInicial;
    }

    public Calculadora() //constructor sin parametro
    {
        dato = 0;
    }

    public Double Resultado{
        get => dato; //solo puedo obtener el dato
    }
    public void Sumar(Double termino){
        dato += termino;
    }
    
    public void Restar(Double termino){
        dato -= termino;
    }

    public void Multiplicar(Double termino){
        dato *= termino;
    }
    public void Dividir(Double termino){
        dato /= termino;
    }

    public void Limpiar(){
        dato = 0;
    }
}