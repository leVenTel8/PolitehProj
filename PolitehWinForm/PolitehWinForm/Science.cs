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
    public partial class Science : Form
    {
        public Science()
        {
            InitializeComponent();
        }

        private void sCIENCEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sCIENCEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Science_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.SCIENCE' table. You can move, or remove it, as needed.
            this.sCIENCETableAdapter.Fill(this.dataSet1.SCIENCE);

        }
    }
}
