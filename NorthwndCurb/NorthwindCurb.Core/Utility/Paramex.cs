using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NorthwindCurb.Core.Utility
{
    static class Paramex
    {

        // Chars to define parameters with spaces, so that we wont remove them.
        static char ignoreSpaceStart = '[';
        static char ignoreSpaceEnd = ']';

        public static int GetParamCount(string str) // TODO ecapsulate more.
        {           
            int count = 0;
            if (!String.IsNullOrEmpty(str))
            {
                str = str.FormatSpaces();
                str = str.FormatSpacesIgnore();
                return str.Split(' ').Count() - 1;

            }
            return count;
        }

        public static string[] GetParams(string str)
        {
            str = str.FormatSpaces();
            int count = GetParamCount(str);
            string[] s = new string[count];

            str = str.Substring(0, str.IndexOf(" ")+1);
            for(int i=0; i < count; i++)
            {
                if (str[0].Equals(ignoreSpaceStart))
                {

                }
            }

            return s;
        }

        public static string FormatSpaces(this string str)
        {
            str = str.Trim(' ');
            bool ignore = false;
            
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Equals(ignoreSpaceStart)) ignore = true;
                if (str[i].Equals(ignoreSpaceEnd)) ignore = false;
                if (str[i].Equals(' ') && ignore == false)
                {
                    while(str[i+1].Equals(' '))
                    {
                        str = str.Remove(i + 1, 1);
                    }
                }
            }
            return str;
        }

        public static string FormatSpacesIgnore(this string str) // Implement from FormatSpaces() instead.
        {
            if (str.Contains(ignoreSpaceStart) && str.Contains(ignoreSpaceEnd))
            {
                bool ignore = true;
                str = str.FormatSpaces();
                str = Regex.Replace(str, @"\s+", " ");
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i].Equals(ignoreSpaceStart)) ignore = false;
                    if (str[i].Equals(ignoreSpaceEnd)) ignore = true;
                    if (ignore == false)
                    {
                        if(str[i].Equals(' ')) str = str.Remove(i, 1);
                    }
                }
            }          
            return str;
        }

    }
}
