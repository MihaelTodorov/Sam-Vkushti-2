namespace ListNumsActions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command.ToLower() == "finish")
                {
                    break;
                }
                switch (command)
                {
                    case "ins": int index= int.Parse(cmd[1]);
                        int num = int.Parse(cmd[2]);
                        nums.Insert(index,num);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;
                    case "contains":
                        int element = int.Parse(cmd[1]);
                        Console.WriteLine(nums.Contains(element) ? "Yes" : "No");
                        break;
                    case "del":
                        int toDelete = int.Parse(cmd[1]);
                        nums.Remove(toDelete);
                        break;
                    case "remove":
                        int removeIndex = int.Parse(cmd[1]);
                        if (removeIndex >= 0 && removeIndex < nums.Count)
                            nums.RemoveAt(removeIndex);
                        break;
                    case "add":
                        int a = int.Parse(cmd[1]);
                        int b = int.Parse(cmd[2]);
                        nums.Add(a + b);
                        break;
                    case "countl":
                        int limit = int.Parse(cmd[1]);
                        int greaterCount = nums.Count(x => x > limit);
                        Console.WriteLine($"CountL={greaterCount}");
                        break;
                    case "countodds":
                        int odds = nums.Count(x => x % 2 != 0);
                        Console.WriteLine($"CountOdds={odds}");
                        break;
                }
            }
        }
    }
}
