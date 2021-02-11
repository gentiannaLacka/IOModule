using System;

namespace IOModule
{
    static class MyExtensionMethods
    {
        public static int NumberOfVowels(this String str)
        {

            int i, len, vowel_count;
            vowel_count = 0;
            len = str.Length;
            
            if (String.IsNullOrEmpty(str))
            {
                return 0;
            }
            else
            {
                str = str.ToLower();

                for (i = 0; i < len; i++)
                {
                    if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                    {
                        vowel_count++;
                    }
                }
            }


            return vowel_count;
        }

        public static bool IsPalindrome(this String str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return false;
            }
            else
            {
                char[] stringArray = str.ToCharArray();
                Array.Reverse(stringArray);

                string reverse = new string(stringArray);

                return str.Equals(reverse, StringComparison.OrdinalIgnoreCase);
            }

        }
    }
}
