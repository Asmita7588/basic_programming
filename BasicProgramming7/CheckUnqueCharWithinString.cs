using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming7
{
    internal class CheckUnqueCharWithinString
    {
        public bool CheckUnqueString(string input) {

            input = input.ToLower();
            for (int i = 0; i < input.Length; i++) {
                char ch = input[i];
                if (input.IndexOf(ch) != input.LastIndexOf(ch) )
                {
                   return false;
                }
                
            }
          return true;
        }
        
    } 
}

