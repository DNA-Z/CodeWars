namespace Katas
{
    public class Kata_4_StripCommentsSolution
    {
        public static string StripComments(string text, string[] commentSymbols)
        {
            string[] rowArray = GetRowArray(text);
            string[] cleanArray = GetCleaningArray(rowArray, commentSymbols);
            string result = JoinArrayToString(cleanArray);

            return result;
        }

        private static string[] GetRowArray(string text)
        {
            return text.Split('\n').ToArray();
        }

        private static string[] GetCleaningArray(string[] arrayText, string[] commentSymbols)
        {
            char[] symbols = StringToCharArrays(commentSymbols);

            for (int i = 0; i < arrayText.Length; i++)
            {
                arrayText[i] = arrayText[i].Split(symbols).ToArray().First().TrimEnd(' ');
            }

            return arrayText;
        }

        private static char[] StringToCharArrays(string[] strings)
        {
            string str = string.Join("", strings); 
            char[] chars = str.ToCharArray();

            return chars;
        }

        private static string JoinArrayToString(string[] array)
        {
            return string.Join('\n', array);
        }

        
    }
}