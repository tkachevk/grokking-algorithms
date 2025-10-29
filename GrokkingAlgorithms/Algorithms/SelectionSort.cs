namespace GrokkingAlgorithms.Algorithms;

public static class SelectionSort
{
    public static void Sort(int[] list)
    {
        for (int i = 0; i < list.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < list.Length; j++)
            {
                if (list[j] < list[minIndex])
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                int tmp = list[i];

                list[i] = list[minIndex];
                list[minIndex] = tmp;
            }
        }
    }
}