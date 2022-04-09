using System;
using System.Text.RegularExpressions;

namespace RegExEmailValidator
{
    public class Patterns
    {
        public static string name_validator = "^[A-Z][a-z]{2,}$";   // pattern of string to validate first name
        public bool firstNameValidator(string firstName)    // method for validating name
        {
            return Regex.IsMatch(firstName,name_validator);     // true or false value will be returned 
        }       
    }
}