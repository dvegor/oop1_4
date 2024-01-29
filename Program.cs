namespace ConsoleApp1
{
    internal class Program


        {
            public static int[] searchBySumm(int[] arr, int target)
            {
                HashSet<int> result = new(arr);
                int[] storage = new int[3];
                int temp = 0;

                foreach (int item in arr)
                {
                    foreach (int el in arr)
                    {
                        if (el != item)
                        {
                            temp = (target - item) - el;
                            if (result.Contains(temp))
                            {
                                storage[0] = item;
                                storage[1] = el;
                                storage[2] = temp;
                                return storage;
                            }
                        }
                    }
                }
                return storage;
            }
            static void Main(string[] args)
            {
                int[] array = { 3, 4, 7, 8, 1, 2, 9, 10, 5, 6, 11 };
                int targ = 15;

                int[] res = searchBySumm(array, targ);

                Console.WriteLine($"{targ} = {res[0]} + {res[1]} + {res[2]}");
            }
        }
    }