using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simpleTestApplication.BLL
{
    public static class ArrayUtils
    {
        public static int[] ReplaceValue(int[] numbers, int value, int substituteValue)
        {
            IEnumerable<int> EnumerabledValues = numbers;

            foreach (var number in EnumerabledValues.Select((numbers, index) => new { index, numbers }))
            {
                if (numbers[number.index].Equals(value))
                {
                    numbers[number.index] = substituteValue;
                    break;
                }

            }

            return numbers;
        }
        public static int[] RemoveValue(int[] numbers, int removableValue)
        {
            return numbers.Where(value => value != removableValue).ToArray();
        }
        public static int AddArrayValues(int[] numbers)
        {
            int addedValue = 0;
            foreach (int number in numbers)
            {
                addedValue += number;
            }

            return addedValue;
        }

        public static Dictionary<int, int[]> AddRandomArrayValues(int[] values)
        {
            Random random = new Random();

            int firstRandomPosition = 0;
            int secondRandomPosition = 0;

            for (int i = 0; firstRandomPosition == secondRandomPosition; i++)
            {
                firstRandomPosition = random.Next(0, values.Length);
                secondRandomPosition = random.Next(0, values.Length);
            }

            int firstNumber = values[firstRandomPosition];
            int secondNumber = values[secondRandomPosition];

            int addedNumbers = firstNumber + secondNumber;

            Dictionary<int, int[]> resultMap = new Dictionary<int, int[]>();

            resultMap.Add(addedNumbers, new int[] { firstNumber, secondNumber });

            return resultMap;
        }

    }
}
