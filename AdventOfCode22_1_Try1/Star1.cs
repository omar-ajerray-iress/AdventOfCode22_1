using static System.Int32;

namespace AdventOfCode22_1_Try1
{
    internal static class Star1
    {
        public static int Run()
        {
            var caloryItems = File.ReadAllText("Input/input.txt");

            var dividedCaloryElves = caloryItems.Split($"{Environment.NewLine}{Environment.NewLine}", StringSplitOptions.RemoveEmptyEntries);

            var maxCalories = 0;

            foreach (var dividedCaloryElf in dividedCaloryElves)
            {
                var elfCalories = 0;

                var dividedCaloryElfItems = dividedCaloryElf.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

                foreach (var dividedCaloryElfItem in dividedCaloryElfItems)
                {
                    TryParse(dividedCaloryElfItem, out var currentCalories);

                    elfCalories += currentCalories;
                }
                maxCalories = maxCalories > elfCalories ? maxCalories : elfCalories;
            }

            return maxCalories;
        }
    }
}
