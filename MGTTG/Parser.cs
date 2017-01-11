using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGTTG
{
    
    public class Parser
    {
        private string _input;
        Dictionary<string,string> _symbolsMap = new Dictionary<string, string>();
        Dictionary<string,double> _metalMap = new Dictionary<string, double>(); 
        public Parser()
        {
            
        }

        public string AddInput(string input)
        {
            try
            {
                var lowercaseInput = input.ToLower();
                if (lowercaseInput.StartsWith("how much is"))
                {
                    var words = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    var roman = string.Empty;
                    var answer = string.Empty;
                    for (int i = 3; i < words.Length - 1; i++)
                    {
                        roman += _symbolsMap[words[i]];
                        answer += words[i] + " ";
                    }
                    answer += "is " + new Roman(roman.ToUpper()).ToInt();
                    return answer;
                }
                if (lowercaseInput.StartsWith("how many credits is"))
                {
                    var words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var roman = string.Empty;
                    var metal = words[words.Length - 2];
                    var answer = string.Empty;

                    for (int i = 4; i < words.Length - 2; i++)
                    {
                        roman += _symbolsMap[words[i]];
                        answer += words[i] + " ";
                    }
                    answer += metal + " is " + new Roman(roman).ToInt() * _metalMap[metal] + " Credits";
                    return answer;
                }
                if (lowercaseInput.EndsWith("credits"))
                {
                    var words = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    var metal = words[words.Length - 4];
                    var credits = Double.Parse(words[words.Length - 2]);
                    var roman = string.Empty;
                    for (int i = 0; i < words.Length - 4;i++)
                    {
                        roman += _symbolsMap[words[i]];
                    }
                    var romanValue = new Roman(roman).ToInt();
                    _metalMap[metal] = credits/romanValue;
                    return string.Empty;
                }
                if (lowercaseInput.Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries).Length == 3)
                {
                    var words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    _symbolsMap[words[0]] = words[2].ToUpper(); 
                    return string.Empty;
                }
                return "I have no idea what you are talking about";
            }
            catch
            {
                return "I have no idea what you are talking about";
            }
        }
        
    }
}
