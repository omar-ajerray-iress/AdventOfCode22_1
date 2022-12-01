using static System.Int32;

namespace AdventOfCode22_1_Try1
{
    internal static class Star2
    {
        public static int Run()
        {
            var caloryItems = File.ReadAllText("Input/input.txt");

            var dividedCaloryElves = caloryItems.Split($"{Environment.NewLine}{Environment.NewLine}", StringSplitOptions.RemoveEmptyEntries);

            var fullList = new List<int>();

            foreach (var dividedCaloryElf in dividedCaloryElves)
            {
                var elfCalories = 0;

                var dividedCaloryElfItems = dividedCaloryElf.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

                foreach (var dividedCaloryElfItem in dividedCaloryElfItems)
                {
                    TryParse(dividedCaloryElfItem, out var currentCalories);

                    elfCalories += currentCalories;
                }
                fullList.Add(elfCalories);
            }

            fullList.Sort();
            return fullList[fullList.Count() - 1] + fullList[fullList.Count() - 2] + fullList[fullList.Count() - 3];
        }
    }
}
