namespace Katas
{
    public class Kata_4_1_2  // Улитка
    {
        public static int[] Snail(int[][] array)
        {
            int index = array[0].Length * array[0].Length;
            int[] resultArray = new int[index];
            int indexResultArray = -1;

            if (array.Length == 0) return Array.Empty<int>();

            for (int resizeMinus = array[0].Length, resizePlus = 0; indexResultArray < index - 1; resizePlus++, resizeMinus--)
            {
                for (int j = resizePlus; j < resizeMinus && indexResultArray <= index - 1; j++)
                    resultArray[++indexResultArray] = array[resizePlus][j];

                for (int j = resizePlus + 1; j < resizeMinus && indexResultArray <= index - 1; j++)
                    resultArray[++indexResultArray] = array[j][resizeMinus - 1];

                for (int j = resizeMinus - 1; j > resizePlus && indexResultArray <= index - 1; j--)
                    resultArray[++indexResultArray] = array[resizeMinus - 1][j - 1];

                for (int j = resizeMinus - 1; j > resizePlus + 1 && indexResultArray <= index - 1; j--)
                    resultArray[++indexResultArray] = array[j - 1][resizePlus];
            }
            return resultArray;
        }
    }
}

//int[][] array =
//            {
//                new int[] { 244, 603, 402, 134 },
//                new int[] { 819, 977, 380, 141 },
//                new int[] { 965, 498, 515, 766 },
//                new int[] { 595, 569, 986, 996 }
//            };