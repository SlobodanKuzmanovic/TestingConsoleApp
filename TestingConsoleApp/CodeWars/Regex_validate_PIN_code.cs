using System;
using System.Collections.Generic;
using System.Linq;

namespace TestingConsoleApp.CodeWars
{
    public static class Regex_validate_PIN_code
    {
        public static bool ValidatePin(string pin)
        {
            var tempArr = pin.Where(x => !char.IsDigit(x)).ToList();

            if (tempArr.Count == 0 && (pin.Length == 4 || pin.Length == 6))
            {
                return true;
            }

            return false;
        }
    }
}
