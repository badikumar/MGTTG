using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MGTTG
{
    public class Roman
    {
        private readonly Dictionary<string, int> _symbolReference = new Dictionary<string, int>()
        {
            {"I",1},
            {"V",5 },
            {"X",10 },
            {"L",50 },
            {"C",100 },
            {"D",500 },
            {"M",1000 }
        };
        private readonly string _roman;
        public Roman(string roman)
        {
            _roman = roman;
        }

        public int ToInt()
        {
            
            var arr = _roman.ToCharArray();
            int[] values = new int[arr.Length];
            if (_roman.Length == 1)
            {
                return _symbolReference[_roman];
            }

            for (int i = 0; i < arr.Length-1; i++)
            {
                values[i] = _symbolReference[arr[i].ToString()];
                var lookahead = _symbolReference[arr[i + 1].ToString()];
                if (lookahead > values[i])
                {
                    values[i] = lookahead - values[i];
                    values[i + 1] = 0;
                    i++;
                }
                else
                {
                    values[i + 1] = lookahead;
                }
            }
            
            return values.Sum();
        }
    }
}
