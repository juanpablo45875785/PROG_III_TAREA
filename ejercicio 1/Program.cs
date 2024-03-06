class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número:");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Obtiene el último dígito del número ingresado
        int ultimoDigito = numero % 10;
        numero = numero /10;
        Console.WriteLine("Último dígito: " + ultimoDigito + numero);
    }
}