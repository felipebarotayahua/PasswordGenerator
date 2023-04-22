using System;
using System.IO;
using System.IO;

namespace PasswordGenerator.Models
{
    public static class PasswordChecker
    {
        public static bool IsPasswordCompromised(string password)
        {
            using (var reader = new StreamReader("compromised-passwords.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null!)
                {
                    if (line.Trim() == password.Trim())
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}







