namespace ArraysAndStrings
{
    public class C1_03_URLify
    {
        public static string UrlifyTheString(string str)
        {
            string newStr = ""; // Your Name ->9 characcters
                           // Your%20Name -> 11 char.
            var strSplit = str.Split(' ');
            int countSpaces = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == ' ')
                {
                    countSpaces++;
                }
            }

            int newStrLength = str.Length + (countSpaces*3);

            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == ' ')
                {
                    newStr = newStr + "%20";
                }
                else
                {
                    newStr = newStr + str[i];
                }
                //"Your%20%20Name%20i%20%20%20o"
            }

            return newStr;
        }
    }
}
