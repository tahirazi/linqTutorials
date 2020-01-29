using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqFormsApp.Tuts.Classes
{
    //In case of extension method the class must be a static class
    public static class StringHelper
    {
        //Method must be static
        //The first parameter is a type of extension with keyword 'this'
        public static string ChangeFirstLetterCase(this string inputString)
        {
            if(inputString.Length > 0)
            {
                char[] charArray = inputString.ToCharArray();
                charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
                return new string(charArray);
            }
            return inputString;
        }
    }
}
