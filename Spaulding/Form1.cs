using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2.Classes;

namespace Spaulding
{
    public partial class Form1 : Form
    {
        private DataOperations operations = new DataOperations();
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            this.comboBox1.DataSource = operations.GetYear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex != 0)
            {
                operations.GetSales(this.comboBox1.SelectedValue.ToString());
                LoadInformation();
            }
        }

        private void LoadInformation()
        {
            if (tabControl1.SelectedIndex == 0)
            {
                this.lblTotalSales.Text = "Total Sales:" + operations._sales.TotalSales;
                this.dgrSalesPerState.DataSource = operations._sales.StateSales;
                this.dgrSalesPerState.Columns[2].Visible = false;
                this.dgrSales.DataSource = operations._sales.Sales;
                this.dgrSales.Columns[4].Visible = false;
                this.dgrSales.Columns[0].Visible = false;
                this.dgrSales.Columns[3].Visible = false;
            }

            if (tabControl1.SelectedIndex == 1)
            {
                this.dgrSalesPerStateIncr.DataSource = null;
                this.dgrSalesPerStateIncr.DataSource = operations._sales.StateSales;
                this.dgrSalesIncr.DataSource = null;
                this.dgrSalesIncr.DataSource = operations._sales.Sales;
                if (dgrSales.DataSource != null)
                {
                    this.dgrSales.Columns[0].Visible = false;
                    this.dgrSales.Columns[3].Visible = false;
                }

            }
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInformation();
        }

        private void txtPercentage_TextChanged(object sender, EventArgs e)
        {
            operations.GetIncrementData(double.Parse(txtPercentage.Text));
            LoadInformation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                var path = this.folderBrowserDialog1.SelectedPath;
                operations.DownloadToCSV(path);
            }
            
        }
    }
}
