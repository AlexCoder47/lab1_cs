using System;


namespace lab1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Min and max values for types in C#: \n");

            Console.WriteLine("1. Byte: Min = {0}, Max = {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("2. Sbyte: Min = {0}, Max = {1}", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("3. Short: Min = {0}, Max = {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("4. Ushort: Min = {0}, Max = {1}", ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("5. Int: Min = {0}, Max = {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("6. Uint: Min = {0}, Max = {1}", uint.MinValue, uint.MaxValue);
            Console.WriteLine("7. Long: Min = {0}, Max = {1}", long.MinValue, long.MaxValue);
            Console.WriteLine("8. Ulong: Min = {0}, Max = {1}", ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("9. Float: Min = {0}, Max = {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("10. Double: Min = {0}, Max = {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("11. Decimal: Min = {0}, Max = {1}", decimal.MinValue, decimal.MaxValue);
        }
    }
}
