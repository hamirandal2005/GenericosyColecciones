internal class Program
{
    private static void Main(string[] args)
    {
        int[] IntArray = { 0, 1, 2, 3, 4, 5, 6 };
        double[] DoubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
        char[] CharArray = { 'L', 'i', 'L', 'i' };

        Console.Write("El arreglo IntArray contiene: ");
        ImprimirArreglo(IntArray);
        Console.Write("El arreglo DoubleArray contiene: ");
        ImprimirArreglo(DoubleArray);
        Console.Write("El arreglo CharArray contiene: ");
        ImprimirArreglo(CharArray);

        
    }
    static void ImprimirArreglo(char[] charArray)
    {
        foreach (char elemento in charArray)
            Console.WriteLine(elemento + " ");
        Console.WriteLine("\n");
    }

    static void ImprimirArreglo(double[] doubleArray)
    {
        foreach (double elemento in doubleArray)
            Console.WriteLine(elemento + " ");
        Console.WriteLine("\n");
    }
    static void ImprimirArreglo(int[] intArray)
    {
        foreach (int elemento in intArray)
            Console.WriteLine(elemento + " ");
        Console.WriteLine("\n");
    }
}