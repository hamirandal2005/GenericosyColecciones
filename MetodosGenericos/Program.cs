int[] IntArray = { 0, 1, 2, 3, 4, 5, 6 };
double[] DoubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
char[] CharArray = { 'L', 'i', 'L', 'i' };

Console.WriteLine("El arreglo IntArray contiene: ");
ImprimirArreglo(IntArray);
Console.WriteLine("El arreglo DoubleArray contiene: ");
ImprimirArreglo(DoubleArray);
Console.WriteLine("El arreglo CharArray contiene: ");
ImprimirArreglo(CharArray);

//Los métodos genericos permiten el ahorrar código
//Para hacerlo generico, se agregan los parentesis angulares <E>(Por lógica... Es tomado como un tipo de dato X, osea permite cualquier tipo de dato)
static void ImprimirArreglo<E>(E[] charArray)
{
    foreach (E elemento in charArray)
        Console.WriteLine(elemento + " ");
    Console.WriteLine("\n");
}