using System;
public class Program
{
    static void Main(string[]args)
    {
        ContarVocales();
    static void ContarVocales()
    {
    Console.WriteLine("Introduzca la palabra: ");
    string palabra = Console.ReadLine().ToLower(); // Convertir la palabra a minúsculas para hacer coincidir las vocales
    int conteoVocales = 0;
    //int conteoVocales = palabra.Count(caracter => "aeiou".Contains(caracter)); // Contar las vocales en la palabra
    for (int i = 0; i < palabra.Length; i++)
    {
        if ("aeiou".Contains(palabra[i]))
        {
            conteoVocales++; // Incrementar el contador si el caracter es una vocal
        }
    }
    Console.WriteLine("La cantidad de vocales en la palabra es: " + conteoVocales);
    Console.ReadKey();
    }
    }
}