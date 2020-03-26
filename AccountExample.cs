using System;
using System.Text.RegularExpressions;

namespace ValidateAccount
{
    public class AccountExample
    {
        /*Không chứa các ký tự đặc biệt
          Phải dài hơn 6 ký tự
          Không chứa các ký tự viết hoa
          Cho phép dấu gạch dưới (_)
        */
        static String ACCOUNT_REGEX = "^[_a-z0-9]{6,}$";
        public bool Validate(string regex)
        {
            bool isMatch = Regex.IsMatch(regex, ACCOUNT_REGEX);
            return isMatch;
        }
    }

}
