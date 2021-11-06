using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02_102190381_TranVanThai
{
    class CSDL
    {
        private static CSDL _Instance;
        public static CSDL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new CSDL();
                return _Instance;
            }
        }
        public DataTable DTSV { get; set; }
        public DataTable DTLSH { get; set; }

        private CSDL()
        {
            DTLSH = new DataTable();
            DTLSH.Columns.AddRange(new DataColumn[]{
                new DataColumn("ID_Lop", typeof(int)),
                new DataColumn("NameLop", typeof(string))
            });
            DataRow row = DTLSH.NewRow();
            row["ID_Lop"] = 1;
            row["NameLop"] = "CNTT_Nhật1";
            DTLSH.Rows.Add(row);
            DataRow row1 = DTLSH.NewRow();
            row1["ID_Lop"] = 2;
            row1["NameLop"] = "CNTT_Nhật2";
            DTLSH.Rows.Add(row1);
            DataRow row2 = DTLSH.NewRow();
            row2["ID_Lop"] = 3;
            row2["NameLop"] = "CNTT_DT1";
            DTLSH.Rows.Add(row2);


            /////////////////////
            DTSV = new DataTable();
            DTSV.Columns.AddRange(new DataColumn[]{
                new DataColumn("MSSV", typeof(string)),
                new DataColumn("NameSv", typeof(string)),
                new DataColumn("Gender", typeof(bool)),
                new DataColumn("NS", typeof(DateTime)),
                new DataColumn("ID_Lop", typeof(double))
            });

            DataRow r1 = DTSV.NewRow();
            r1["MSSV"] = "102381";
            r1["NameSv"] = "Trần Văn Thái";
            r1["Gender"] = true;
            r1["NS"] = DateTime.Now;
            r1["ID_Lop"] = 2;
            DTSV.Rows.Add(r1);
            DataRow r2 = DTSV.NewRow();
            r2["MSSV"] = "102482";
            r2["NameSv"] = "Đoàn Công Tín";
            r2["Gender"] = false;
            r2["NS"] = DateTime.Now;
            r2["ID_Lop"] = 1;
            DTSV.Rows.Add(r2);
            DataRow r3 = DTSV.NewRow();
            r3["MSSV"] = "102581";
            r3["NameSv"] = "Thu Huyền";
            r3["Gender"] = false;
            r3["NS"] = DateTime.Now;
            r3["ID_Lop"] = 3;
            DTSV.Rows.Add(r3);
            DataRow r4 = DTSV.NewRow();
            r4["MSSV"] = "102681";
            r4["NameSv"] = "Thị Phước";
            r4["Gender"] = false;
            r4["NS"] = DateTime.Now;
            r4["ID_Lop"] = 1;
            DTSV.Rows.Add(r4);
        }
        public bool AddDataRow(SV sv)
        {
            try
            {
                if (!CSDL.Instance.ContainSV(sv.MSSV))
                {
                    DataRow row = DTSV.NewRow();
                    row["MSSV"] = sv.MSSV;
                    row["NameSv"] = sv.NameSV;
                    row["Gender"] = sv.Gender;
                    row["NS"] = sv.NS;
                    row["ID_Lop"] = sv.ID_Lop;
                    DTSV.Rows.Add(row);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EditDataRow(SV sv)
        {
            try
            {
                foreach (DataRow i in DTSV.Rows)
                {
                    if (i["MSSV"].ToString() == sv.MSSV)
                    {
                        i["NameSv"] = sv.NameSV;
                        i["Gender"] = sv.Gender;
                        i["NS"] = sv.NS;
                        i["ID_Lop"] = sv.ID_Lop;
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteDataRow(string mssv)
        {
            try
            {
                foreach (DataRow i in DTSV.Rows)
                {
                    if (i["MSSV"].ToString() == mssv)
                    {
                        //DBSV.Rows.Remove(i);
                        i.Delete();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool ContainSV(string mssv)
        {

            foreach (DataRow r in DTSV.Rows)
            {
                if (r["MSSV"].ToString() == mssv)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
