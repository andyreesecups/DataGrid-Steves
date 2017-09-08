using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalletDetailViewer.Models;

namespace PalletDetailViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(VerifyInput())
            {
                MaterialCode myMaterialCode;
                string sMessage;
                if(DataAccess.GetData(txtInput.Text.Trim(), out myMaterialCode, out sMessage) == false)
                {
                    MessageBox.Show(sMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataGridViewRow row = (DataGridViewRow)grdResults.Rows[0].Clone();
                    row.Cells[0].Value = myMaterialCode.sPlant;
                    row.Cells[1].Value = myMaterialCode.sMaterialCode;
                    row.Cells[2].Value = myMaterialCode.dTotalCost.ToString("C");

                    grdResults.Rows.Add(row);
                }
            }
        }

        private bool VerifyInput()
        {
            if (string.IsNullOrEmpty(txtInput.Text) == false)
            {
                MessageBox.Show("Good", "Good Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                //if (MessageBox.Show("Bad", "Bad Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                //{
                //    MessageBox.Show("YES");
                //}
                //else
                //{
                //    MessageBox.Show("NO");
                //}

                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
