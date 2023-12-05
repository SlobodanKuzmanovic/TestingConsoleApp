using System;
using System.Collections.Generic;

namespace TestingConsoleApp
{
    public static class Regex_validate_PIN_code
    {
        public static bool ValidatePin(string pin)
        {
            pin = pin.Replace("\n", "").Replace("\t", "");

            pin.Contains("\n");

            if (pin.Length == 4 || pin.Length == 6)
            {
                try
                {
                    var pinInt = Convert.ToInt32(pin);
                    if (pinInt > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
