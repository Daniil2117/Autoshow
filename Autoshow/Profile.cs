using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoshow
{
    class Profile
    {
        public bool CheckPsw(string txb)
        {
            bool len = false, digit = false, upper = false, lower = false, speche = false;
            if (txb.Length >= 6)
            {
                len = true;
                foreach (char c in txb)
                {
                    if (char.IsDigit(c))
                    {
                        digit = true;
                    }
                    if (char.IsDigit(c))
                    {
                        upper = true;
                    }
                    if (char.IsDigit(c))
                    {
                        lower = true;
                    }
                }
                string spc = "!@#$%^";
                foreach (char c in spc)
                {
                    if (txb.Contains(c))
                    {
                        speche = true;
                    }
                }
            }
            if (len && digit && upper && lower && speche)
            {
                return true;
            }
            else { return false; }
        }
        public bool Psw_pod(string txb, string txb2)
        {
            if (txb == txb2)
                return true;
            else
                return false;
        }
    }
}
