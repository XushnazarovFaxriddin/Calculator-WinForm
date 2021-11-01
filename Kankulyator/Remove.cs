namespace Kankulyator
{
    public class Remove
    {
        public static string ochir(string txt)
        {
            string TXT = "";
            for(int i=0; i<txt.Length-1; i++)
            {
                TXT += txt[i];
            }
            return TXT;
        }
        public static string oldOchir(string txt)
        {
            string TXT = "";
            for(int i=1; i<txt.Length; i++)
            {
                TXT += txt[i];
            }
            return TXT;
        }
    }
}
