using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class Validator
    {
        static public bool PinValidator(string _pin)
        {

            if (_pin.Length < 4 || _pin.Length > 8 || _pin.All(char.IsDigit) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static public bool PhoneValidator(string _phoneNum)
        {
            string strippedNum = Regex.Replace(_phoneNum, "[^0-9]", "");
            string areaCode = strippedNum.Substring(0, 3);

            if (areaCode == "555" || strippedNum.Length != 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static public bool EmailValidator(string _email)
        {
            if (_email.Contains('@') && _email.Contains('.'))
            {
                if (_email.Count(f => f == '@') == 1)
                {
                    int atIndex = _email.IndexOf('@');
                    int dotIndex = _email.IndexOf('.');
                    if (dotIndex > atIndex)
                    {
                        string username = _email[..atIndex];
                        string domain = _email.Substring(atIndex, dotIndex - atIndex);
                        string topLevelDomain = _email[dotIndex..];
                        if(username.Length > 0 && domain.Length > 1 && topLevelDomain.Length > 1)
                        {
                        return true;

                        } else
                        {
                            return false;
                        }

                    }
                    else
                    {
                        return false;
                    }


                }
                else
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
