using ejercicio33;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar los valores de m, n y p
        Console.Write("Ingrese el valor de m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el valor de n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el valor de p: ");
        int p = int.Parse(Console.ReadLine());

        // Crear objetos Matriz
        Matriz A = new Matriz(m, n);
        Matriz B = new Matriz(n, p);

        // Llenar las matrices con sus respectivas fórmulas
        A.Llenar((i, j) => (i + 1) * j);
        B.Llenar((i, j) => i * (j + 1));

        // Multiplicar matrices
        Matriz C = Matriz.Multiplicar(A, B);

        // Imprimir matrices
        Console.WriteLine("\n*** A ***");
        A.Imprimir();

        Console.WriteLine("\n*** B ***");
        B.Imprimir();

        Console.WriteLine("\n*** C ***");
        C.Imprimir();
    }
}