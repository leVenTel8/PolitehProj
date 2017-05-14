using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolitehWinForm
{
    public partial class LoadUpdate : Form
    {
        public LoadUpdate()
        {
            InitializeComponent();
        }

        private void lOADBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.lOADBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (Exception err)
            {
                MessageBox.Show("ky ky", "error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.lOADTableAdapter.Fill(this.dataSet1.LOAD);
            }

        }

        private void LoadUpdate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.LOAD' table. You can move, or remove it, as needed.
            this.lOADTableAdapter.Fill(this.dataSet1.LOAD);

        }
    }
}
