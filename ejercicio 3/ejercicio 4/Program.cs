using System;
public class oracion{
    static void Main(string[]args){
Console.WriteLine("Ingrese una oración:");
        string oracion = Console.ReadLine();

        int cantidadPalabras = ContarPalabras(oracion);

        Console.WriteLine("La cantidad de palabras en la oración es: " + cantidadPalabras);
    

    static int ContarPalabras(string oracion)
    {
        // Dividir la oración en palabras utilizando los espacios como separadores
        string[] palabras = oracion.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // Retornar la cantidad de palabras obtenidas
        return palabras.Length;
    }
}
}