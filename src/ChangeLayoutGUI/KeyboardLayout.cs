using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeLayoutGUI
{
    public class KeyboardLayout
    {
        private readonly static Dictionary<char, char> ukr_eng = new Dictionary<char, char>
        {
            {'й', 'q'}, {'ц', 'w'}, {'у', 'e'}, {'к', 'r'}, {'е', 't'}, {'н', 'y'}, {'г', 'u'},
            {'ш', 'i'}, {'щ', 'o'}, {'з', 'p'}, {'х', '['}, {'ї', ']'}, {'ф', 'a'}, {'і', 's'},
            {'в', 'd'}, {'а', 'f'}, {'п', 'g'}, {'р', 'h'}, {'о', 'j'}, {'л', 'k'}, {'д', 'l'},
            {'ж', ';'}, {'є', '\''}, {'я', 'z'}, {'ч', 'x'}, {'с', 'c'}, {'м', 'v'}, {'и', 'b'},
            {'т', 'n'}, {'ь', 'm'}, {'б', ','}, {'ю', '.'}
        };

        private readonly static Dictionary<char, char> eng_ukr = new Dictionary<char, char>
        {
            {'q', 'й'}, {'w', 'ц'}, {'e', 'у'}, {'r', 'к'}, {'t', 'е'}, {'y', 'н'}, {'u', 'г'},
            {'i', 'ш'}, {'o', 'щ'}, {'p', 'з'}, {'[', 'х'}, {']', 'ї'}, {'a', 'ф'}, {'s', 'і'},
            {'d', 'в'}, {'f', 'а'}, {'g', 'п'}, {'h', 'р'}, {'j', 'о'}, {'k', 'л'}, {'l', 'д'},
            {';', 'ж'}, {'\'', 'є'}, {'z', 'я'}, {'x', 'ч'}, {'c', 'с'}, {'v', 'м'}, {'b', 'и'},
            {'n', 'т'}, {'m', 'ь'}, {',', 'б'}, {'.', 'ю'}
        };

        public static string ConvertUkrToEng(string s)
        {
            string result="";
            foreach(char c in s)
            {
                if (ukr_eng.TryGetValue(char.ToLower(c), out char converted))
                {
                    if(char.IsUpper(c))
                    {
                        result += char.ToUpper(converted);
                    }
                    else
                    {
                        result += converted;
                    }
                }
                else
                {
                    result+= c;
                }
            }
            return result;
        }

        public static string ConvertEngToUkr(string s)
        {
            string result = "";
            bool all_caps = IsAllCaps(s);
            foreach (char c in s)
            {
                if (eng_ukr.TryGetValue(char.ToLower(c), out char converted))
                {
                    if(all_caps)
                    {
                        result += char.ToUpper(converted);
                    }
                    else
                    {
                        if (char.IsUpper(c))
                        {
                            result += char.ToUpper(converted);
                        }
                        else
                        {
                            result += converted;
                        }
                    }
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }

        private static bool IsAllCaps(string s)
        {
            foreach (char c in s)
            {
                if(char.IsLetter(c) && char.IsLower(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
