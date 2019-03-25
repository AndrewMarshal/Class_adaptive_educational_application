namespace ClassSort
{
    public class Sort
    {
        static void QuickSort(int[] massive, int start, int end)
        {
            if (end == start) return;
            var mainIndex = start;
            for (int i = start; i < end; i++)
                if (massive[i] <= massive[end])
                {
                    var c = massive[i];
                    massive[i] = massive[mainIndex];
                    massive[mainIndex] = c;
                    mainIndex++;
                }
            var newAnd = massive[mainIndex];
            massive[mainIndex] = massive[end];
            massive[end] = newAnd;
            if (mainIndex > start) QuickSort(massive, start, mainIndex - 1);
            if (mainIndex < end) QuickSort(massive, mainIndex + 1, end);

        }

        public static void QuickSort(int[] array)
        {
            if (array.Length == 0)
                return;
            QuickSort(array, 0, array.Length - 1);
        }
    }
}
