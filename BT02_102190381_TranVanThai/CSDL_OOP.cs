using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02_102190381_TranVanThai
{
    public class CSDL_OOP
    {
        private static CSDL_OOP _Instance;
        public static CSDL_OOP Instance
        {
            get
            {
                if (_Instance == null) _Instance = new CSDL_OOP();
                return _Instance;
            }
        }
        private CSDL_OOP()
        { }
        public SV GetSV(DataRow i)
        {
            return new SV
            {
                MSSV = i["MSSV"].ToString(),
                NameSV = i["NameSV"].ToString(),
                Gender = Convert.ToBoolean(i["Gender"]),
                NS = Convert.ToDateTime(i["NS"].ToString()),
                ID_Lop = int.Parse(i["ID_Lop"].ToString())
            };
        }
        public List<SV> GetAllSV()
        {
            List<SV> data = new List<SV>();
            foreach (DataRow i in CSDL.Instance.DTSV.Rows)
            {
                data.Add(GetSV(i));
            }
            return data;
        }
        public SV GetSVByMSSV(string ms)
        {
            SV sv = new SV();
            foreach (SV i in GetAllSV())
            {
                if (ms == i.MSSV)
                {
                    sv = i;
                }
            }
            return sv;
        }
        public LSH GetLSH(DataRow i)
        {
            return new LSH
            {
                NameLop = i["NameLop"].ToString(),
                ID_Lop = int.Parse(i["ID_Lop"].ToString())
            };
        }
        public List<LSH> GetAllLSH()
        {
            List<LSH> list = new List<LSH>();
            foreach (DataRow i in CSDL.Instance.DTLSH.Rows)
            {
                list.Add(CSDL_OOP.Instance.GetLSH(i));
            }
            return list;
        }
        public List<SV> GetListSVByIDLop(int ID)
        {
            List<SV> list = new List<SV>();
            if (ID == 0)
            {
                list = GetAllSV();
            }
            foreach (SV i in GetAllSV())
            {
                if (i.ID_Lop == ID)
                {
                    list.Add(i);
                }
            }
            return list;
        }

        public List<SV> GetSVByName(string name)
        {
            List<SV> list = new List<SV>();
            foreach(DataRow dr in CSDL.Instance.DTSV.Rows)
            {
                if ( dr["NameSV"].ToString().Contains(name))
                {
                    list.Add(GetSV(dr));
                }
            }
            return list;
        }
        public List<SV> GetListSVByIDAndNameSv(int id, string name)
        {
            List<SV> list = new List<SV>();
            if (name == "")
            {
                list = GetListSVByIDLop(id);
            }
            else if(id == 0)
            {
                list = GetSVByName(name);
            }
            else
            {
                foreach(DataRow dr in CSDL.Instance.DTSV.Rows)
                {
                    if(Convert.ToInt32(dr["ID_Lop"].ToString()) == id && dr["NameSV"].ToString().Contains(name))
                    {
                        list.Add(GetSV(dr));
                    }
                }    

            }
            return list;
        }
        public bool AddDB(SV sv)
        {
            return CSDL.Instance.AddDataRow(sv);
        }
        public bool EditDB(SV sv)
        {
            return CSDL.Instance.EditDataRow(sv);
        }
        public bool DeleteDB(string mssv)
        {
            return CSDL.Instance.DeleteDataRow(mssv);
        }

        public delegate bool MyCompare(SV s1, SV s2);
        public List<SV> SortListSv(int id, string name, MyCompare cmp)
        {
            List<SV> list = new List<SV>();
            list = CSDL_OOP.Instance.GetListSVByIDAndNameSv(id, name);
            for (int i = 0; i < list.Count - 1; ++i)
            {
                for (int j = i + 1; j < list.Count; ++j)
                {
                    if (cmp(list[i], list[j]))
                    {
                        SV temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;
        }
    }
}
