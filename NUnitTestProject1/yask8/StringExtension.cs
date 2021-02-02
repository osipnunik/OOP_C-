using System.Text;

namespace NUnitTestProject1.task8
{
    public static class StringExtension
    {
        public static string CrossString(this string s1, string s2)
        {
            StringBuilder sb = new StringBuilder();
            char[] charArr1 = s1.ToCharArray();
            char[] charArr2 = s2.ToCharArray();
            for (int i = 0; i < charArr1.Length; i++)
            {
                for (int j = 0; j < charArr2.Length; j++)
                {
                    if (charArr1[i] == charArr2[j])
                    {
                        sb.Append(charArr1[i]);
                        break;
                    }
                }
            }
            return sb.ToString();
        }

    }
}
