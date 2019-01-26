using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI
{
    public class StringUniquenessChecker
    {
        /**
         * Is Unique: Implement an algorithm to determine if a string has all unique characters.
         */
        public static bool IsStringAllUniqueChars(string str)
        {
            var characterSet = new HashSet<char>();

            foreach (char c in str)
            {
                if (characterSet.Contains(c))
                {
                    return false;
                }
                characterSet.Add(c);
            }

            return true;
        }
    }
}
