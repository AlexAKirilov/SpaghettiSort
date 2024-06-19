namespace Laba
{
    public class SortingAlgorithm
    {
        public List<int> SortNumbers(int[] numbers)
        {
            var spaghetti = new Dictionary<int, List<int>>();
            var maxNumber = 0;

            foreach (var number in numbers)
            {
                maxNumber = Math.Max(number, maxNumber);

                if (!spaghetti.ContainsKey(number))
                {
                    spaghetti[number] = new List<int>();
                }
                spaghetti[number].Add(number);
            }

            var result = new List<int>();
            for (var value = maxNumber; value >= 0; value--)
            {
                if (spaghetti.ContainsKey(value))
                {
                    result.AddRange(spaghetti[value]);
                }
            }

            return result;
        }
    }
}
