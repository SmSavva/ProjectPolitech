namespace ConsoleApp1
{
    public class Matrix
    {
        public int[][] Sort(Func<int[][], int[]> sortMas, bool inc, int[][] Mas)
        {
            int[] arr = sortMas.Invoke(Mas);
            int rows = Mas.Length;
            for (int i = 0; i < rows; i++)
            {
                for (int j = i + 1; j < rows; j++)
                {
                    if (inc)
                    {
                        if (arr[i] > arr[j])
                        {
                            (Mas[i], Mas[j]) = (Mas[j], Mas[i]);
                            (arr[i], arr[j]) = (arr[j], arr[i]);

                        }
                    }
                    else
                    {
                        if (arr[i] < arr[j])
                        {
                            (Mas[i], Mas[j]) = (Mas[j], Mas[i]);
                            (arr[i], arr[j]) = (arr[j], arr[i]);

                        }
                    }

                }
            }
            return Mas;
        }
    }
    public class SumElements
    {
        public static int[] Sort(int[][] m)
        {
            int[] sum_array = new int[m.Length];
            for (int i = 0; i < m.Length; i++)
            {
                sum_array[i] = m[i].Sum();
            }
            return sum_array;
        }
    }
    public class MaxElement
    {
        public static int[] Sort(int[][] m)
        {
            int[] max_array = new int[m.Length];
            for (int i = 0; i < m.Length; i++)
            {
                max_array[i] = m[i].Max();
            }
            return max_array;
        }
    }
    public class MinElement
    {
        public static int[] Sort(int[][] m)
        {
            int[] min_array = new int[m.Length];
            for (int i = 0; i < m.Length; i++)
            {
                min_array[i] = m[i].Min();
            }
            return min_array;
        }

    }
}


