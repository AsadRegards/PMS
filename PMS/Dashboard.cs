using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    //panel size: 1517, 826
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void aDDNEWSALEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDDNEWITEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewFormInPanel(new AddNewItem());
        }

        private void vIEWALLSALESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vIEWALLITEMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewFormInPanel(new ViewAllItems());
        }

        public static void ShowNewFormInPanel(Form newForm)
        {

            mainPanel.Controls.Clear();  

            newForm.TopLevel = false;  
            newForm.FormBorderStyle = FormBorderStyle.None;  
            newForm.Dock = DockStyle.Fill;  
            mainPanel.Controls.Add(newForm);  

            newForm.Show();
        }

    }
}
