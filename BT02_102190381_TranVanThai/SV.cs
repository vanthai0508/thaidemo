using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02_102190381_TranVanThai
{
    public class SV
    {
        public string MSSV { get; set; }
        public string NameSV { get; set; }
        public bool Gender { get; set; }
        public DateTime NS { get; set; }
        public int ID_Lop { get; set; }

        public override string ToString()
        {
            return NameSV;
        }
        public static bool DescendingMSSV(SV s1, SV s2)
        {
            return Convert.ToInt32(s1.MSSV) < Convert.ToInt32(s2.MSSV);
        }
        public static bool AscendingName(SV s1, SV s2)
        {
            if(string.Compare(s1.NameSV, s2.NameSV) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool AscendingGender(SV s1, SV s2)
        {
            return string.Compare(s1.Gender.ToString(), s2.Gender.ToString()) > 0;
        }
        public static bool AscendingNS(SV s1, SV s2)
        {
            return string.Compare(s1.NS.ToString(), s2.NS.ToString()) > 0;
        }

        public static bool AscendingIDLop(SV s1, SV s2)
        {
            if(s1.ID_Lop > s2.ID_Lop)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
