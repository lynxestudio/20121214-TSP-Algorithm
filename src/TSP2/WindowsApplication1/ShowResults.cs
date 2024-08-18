using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TSP
{
    public partial class ShowResults : Form
    {
        public string FileName { set; get; }
        public ShowResults()
        {
            InitializeComponent();
        }

        private void ShowResults_Load(object sender, EventArgs e)
        {
            try {
                DataSet dt = new DataSet();
                dt.ReadXml(FileName);
                grilla.DataSource = dt.Tables[0].DefaultView;

            }catch(ApplicationException ex){
                MessageBox.Show(ex.Message);
            }
        }
    }
}