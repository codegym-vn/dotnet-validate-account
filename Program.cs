using System;

namespace ValidateAccount
{
    public class AccountExampleTest
    {
        private static AccountExample accountExample;
        static string[] validAccount = new String[] { "123abc_", "_abc123", "______", "123456", "abcdefgh" };
        static string[] invalidAccount = new String[] { ".@", "12345", "1234_", "abcde" };
        public static void Main(string[] args)
        {
            accountExample = new AccountExample();
            foreach (string account in validAccount)
            {
                bool isvalid = accountExample.Validate(account);
                Console.WriteLine("Account is " + account + " is valid: " + isvalid);
            }
            foreach (string account in invalidAccount)
            {
                bool isvalid = accountExample.Validate(account);
                Console.WriteLine("Account is " + account + " is valid: " + isvalid);
            }
        }
    }

}
 