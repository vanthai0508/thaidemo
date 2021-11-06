using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT02_102190381_TranVanThai
{
    public partial class Form2 : Form
    {
        public delegate void Mydel(string mssv);
        public Mydel d;

        string MSSV;

        public delegate void ShowData();

        public ShowData _ShowData;

        public void GetMSSV(string _MSSV)
        {
            MSSV = _MSSV;
        }
        public Form2()
        {
            InitializeComponent();
            setCBobox();
            d += new Mydel(GetMSSV);
        }
        public void setCBobox()
        {
            foreach (LSH i in CSDL_OOP.Instance.GetAllLSH())
            {
                CBBItem cb = new CBBItem
                {
                    _Text = i.NameLop,
                    _Value = i.ID_Lop
                };
                cbbLSH.Items.Add(cb);
            }
        }

        public SV GetSV()
        {
            SV sv = new SV();
            sv.MSSV = tmssv.Text;
            sv.NameSV = tname.Text;
            if(male.Checked == true)
            {
                sv.Gender = true;
            } else
            {
                sv.Gender = false;
            }
            sv.NS = dateTimePicker1.Value;
            sv.ID_Lop = ((CBBItem)cbbLSH.SelectedItem)._Value;
            return sv;
        }

        private void BT1_Click(object sender, EventArgs e)
        {
            if(MSSV == "")
            {
                CSDL_OOP.Instance.AddDB(GetSV());
            }
            else
            {
                CSDL_OOP.Instance.EditDB(GetSV());
            }
            _ShowData();
            this.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(MSSV != "")
            {
                SV sv = new SV();
                sv = CSDL_OOP.Instance.GetSVByMSSV(MSSV);
                tmssv.Text = sv.MSSV;
                tname.Text = sv.NameSV;
                cbbLSH.SelectedIndex = sv.ID_Lop - 1;
                dateTimePicker1.Value = sv.NS;
                if(sv.Gender == true)
                {
                    male.Checked = true;
                }
                else
                {
                    female.Checked = true;
                }
                tmssv.Enabled = false;
            }
        }
    }
}
