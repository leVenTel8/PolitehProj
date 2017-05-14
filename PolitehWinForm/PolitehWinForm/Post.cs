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
    public partial class Post : Form
    {
        public Post()
        {
            InitializeComponent();
        }

        private void pOSTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pOSTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Post_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.POST' table. You can move, or remove it, as needed.
            this.pOSTTableAdapter.Fill(this.dataSet1.POST);

        }
    }
}
