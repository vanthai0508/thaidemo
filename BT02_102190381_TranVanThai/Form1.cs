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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setCbo();
        }

        private void setCbo()
        {
            CBBLSH.Items.Add(new CBBItem { _Text = "All", _Value = 0 });
            foreach (LSH i in CSDL_OOP.Instance.GetAllLSH())
            {
                CBBItem cb = new CBBItem
                {
                    _Text = i.NameLop,
                    _Value = i.ID_Lop
                };
                CBBLSH.Items.Add(cb);
            }
            CBBLSH.SelectedIndex = 0;

            CBBSET.Items.AddRange(new CBBItem[]
            {
                new CBBItem{ _Text = "MSSV", _Value = 1},
                new CBBItem{ _Text = "NameSV", _Value = 2},
                new CBBItem{ _Text = "Gender", _Value = 3},
                new CBBItem{ _Text = "NS", _Value = 4},
                new CBBItem{ _Text = "ID_Lop", _Value = 5 }
            });
            //cboSortType.DisplayMember = "_Text";
        }


        private void BT8_Click(object sender, EventArgs e)
        {
            if (CBBSET.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn sort type");
                return;
            }
            CBBItem cbId = CBBLSH.SelectedItem as CBBItem;
            int id = cbId._Value;
            CBBItem cb = CBBSET.SelectedItem as CBBItem;
            switch (cb._Value)
            {
                case 1:
                   DGV.DataSource = CSDL_OOP.Instance.SortListSv(id, tsearch.Text, SV.DescendingMSSV);
                    break;
                case 2:
                    DGV.DataSource = CSDL_OOP.Instance.SortListSv(id, tsearch.Text, SV.AscendingName);
                    break;
                case 3:
                    DGV.DataSource = CSDL_OOP.Instance.SortListSv(id, tsearch.Text, SV.AscendingGender);
                    break;
                case 4:
                    DGV.DataSource = CSDL_OOP.Instance.SortListSv(id, tsearch.Text, SV.AscendingNS);
                    break;
                case 5:
                    DGV.DataSource = CSDL_OOP.Instance.SortListSv(id, tsearch.Text, SV.AscendingIDLop);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tsearch_TextChanged(object sender, EventArgs e)
        {
            ShowData();                   
        }

        private void CBBLSH_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowData();
        }

        public void ShowData()
        {
            int idlop = ((CBBItem)CBBLSH.SelectedItem)._Value;
            string name = tsearch.Text;
            if (tsearch.Text == "")
            {
                DGV.DataSource = CSDL_OOP.Instance.GetListSVByIDLop(((CBBItem)CBBLSH.SelectedItem)._Value);
            }
            else
            {
                DGV.DataSource = CSDL_OOP.Instance.GetListSVByIDAndNameSv(idlop, name);
            }
            DGV.Refresh();
        }

        private void badd_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2._ShowData = ShowData;
            f2.d("");
            f2.Show();
        }

        private void bedit_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2._ShowData = ShowData;
            string mssv = DGV.CurrentRow.Cells["MSSV"].Value.ToString();
            f2.d(mssv);
            f2.Show();
        }

        private void bdel_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = DGV.SelectedRows;
            foreach(DataGridViewRow dr in r)
            {
                CSDL_OOP.Instance.DeleteDB(dr.Cells["MSSV"].Value.ToString());      
            }
            ShowData();
        }

        private void CBBSET_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
