using System;

namespace Индексатор_8
{
    class Program
    {
        static void Main(string[] args)
        {
            SymbolArray symbolArray = new SymbolArray();

            Console.Write("Введите размер ЧИСЛОВОГО массива: ");
            int numericArraySize = Convert.ToInt32(Console.ReadLine());
            symbolArray.ArraySize(numericArraySize);

            Console.Write("Введите первый элемент ЧИСЛОВОГО массива: ");
            int firstNumericElement = Convert.ToInt32(Console.ReadLine());
            symbolArray.ArrayFill(firstNumericElement);

            Console.Write("Введите размер СИМВОЛЬНОГО массива: ");
            int symbolArraySize = Convert.ToInt32(Console.ReadLine());
            symbolArray.SymbolArraySize(symbolArraySize);

            Console.Write("Введите первый элемент СИМВОЛЬНОГО массива: ");
            char firstSymbolElement = Convert.ToChar(Console.ReadLine());
            symbolArray.SymbolArrayFill(firstSymbolElement);

            Console.WriteLine("ЧИСЛОВОЙ массив: ");
            symbolArray.ShowNumericArray();
            Console.WriteLine("СИМВОЛЬНЫЙ массив: ");
            symbolArray.ShowSymbolArray();

            Console.ReadKey();
        }
    }

    class NumArray
    {
        public int numSize = 0;
        public int[] numericArray;

        public void ArraySize(int size)
        {
            numericArray = new int[size];
            numSize = size;
        }

        public void ArrayFill(int _number)
        {
            int k = 1;
            numericArray[0] = _number;
            for(int i = 1; i < numSize; i++)
            {
                numericArray[i] = _number + k;
                k++;
            }
        } 

        public void ShowNumericArray()
        {
            for (int i = 0; i < numSize; i++)
            {
                Console.WriteLine($"{numericArray[i]} ");
            }
        }
    }

    class SymbolArray : NumArray
    {
        public int symbolSize;
        public char[] textArray;

        public void SymbolArraySize(int symbolSize)
        {
            textArray = new char[symbolSize];
            this.symbolSize = symbolSize;
        }

        public void SymbolArrayFill(char _symbol)
        {
            int k = 1;
            textArray[0] = _symbol;
            for(int i = 1; i < symbolSize; i++)
            {
                textArray[i] = (char)(_symbol + k);
                k++;
            }
        }

        public void ShowSymbolArray()
        {
            for(int i = 0; i < symbolSize; i++)
            {
                Console.WriteLine($"{textArray[i]} ");
            }
        }
    }
}

