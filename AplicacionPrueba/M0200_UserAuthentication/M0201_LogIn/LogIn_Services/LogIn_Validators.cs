using System;
using System.Text.RegularExpressions;

namespace AplicacionPrueba.M0200_UserAuthentication.M0201_LogIn.LogIn_Services
{
    public class LogIn_Validators
    {
        public LogIn_Validators()
        {
        }

        public bool EmailField_Validator(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length > 100)
                return false;

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return regex.IsMatch(value);
        }
    }
}
