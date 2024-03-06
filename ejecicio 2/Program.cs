using System;

class Program
{
    static void Main(string[] args)
    {
//----------------EJERCICIO 2---------------------------------------------------------------------------------------------------------------------------     
      
    // Solicita al usuario 
    Console.Write("Ingrese un número: ");
    int numero = Convert.ToInt32(Console.ReadLine());
        // Llama a la función VerificarOrden para determinar si los dígitos están en orden
    bool ordenado = VerificarOrden(numero);
        // Muestra el resultado de la verificación
    if (ordenado)
        Console.WriteLine("TRUE"); // Si los dígitos están en orden 
    else
        Console.WriteLine("FALSE"); // Si los dígitos no están en orden
    //Console.ReadKey();
    
    // Función para verificar si los dígitos del número están en orden 
    static bool VerificarOrden(int numero)
    {
    string numeroString = numero.ToString(); // Convierte el número a una cadena de texto
        // Itera a través de los dígitos del número
    for (int i = 0; i < numeroString.Length - 1; i++)
    {
        // Comprueba si el dígito actual es mayor que el siguiente
    if (numeroString[i] > numeroString[i + 1])
    return false; // Si el dígito actual es mayor que el siguiente, los dígitos no están en orden ascendente
    }
    return true; // Si no se encontraron dígitos fuera de orden, retorna true
    }
}
}
