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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tEACHERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tEACHERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.SUBJECTS' table. You can move, or remove it, as needed.
            this.sUBJECTSTableAdapter.Fill(this.dataSet1.SUBJECTS);
            // TODO: This line of code loads data into the 'dataSet1.ACADEMIC_YEARS' table. You can move, or remove it, as needed.
            this.aCADEMIC_YEARSTableAdapter.Fill(this.dataSet1.ACADEMIC_YEARS);
            // TODO: This line of code loads data into the 'dataSet1.GROUPS' table. You can move, or remove it, as needed.
            this.gROUPSTableAdapter.Fill(this.dataSet1.GROUPS);
            // TODO: This line of code loads data into the 'dataSet1.LOAD' table. You can move, or remove it, as needed.
            this.lOADTableAdapter.Fill(this.dataSet1.LOAD);
            // TODO: This line of code loads data into the 'dataSet1.SCIENCE' table. You can move, or remove it, as needed.
            this.sCIENCETableAdapter.Fill(this.dataSet1.SCIENCE);
            // TODO: This line of code loads data into the 'dataSet1.POST' table. You can move, or remove it, as needed.
            this.pOSTTableAdapter.Fill(this.dataSet1.POST);
            // TODO: This line of code loads data into the 'dataSet1.POST' table. You can move, or remove it, as needed.
            this.pOSTTableAdapter.Fill(this.dataSet1.POST);
            // TODO: This line of code loads data into the 'dataSet1.TEACHERS' table. You can move, or remove it, as needed.
            this.tEACHERSTableAdapter.Fill(this.dataSet1.TEACHERS);

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?",
            "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
            DialogResult.Yes;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Post frmPost = new Post();

            frmPost.ShowDialog();

            this.pOSTTableAdapter.Fill(this.dataSet1.POST);

            pOSTBindingSource.ResetBindings(false);
            tEACHERSBindingSource.ResetBindings(false);
        }

        private void ученыеСтепениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Science frmScience = new Science();

            frmScience.ShowDialog();

            this.sCIENCETableAdapter.Fill(this.dataSet1.SCIENCE);

            sCIENCEBindingSource.ResetBindings(false);
            tEACHERSBindingSource.ResetBindings(false);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();

            this.lOADBindingSource.EndEdit();

            this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (Exception err1)
            {
                MessageBox.Show("ky ky", "error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.lOADTableAdapter.Fill(this.dataSet1.LOAD);
            }
        }

        private void нагрузкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUpdate frm_loadUpdate = new LoadUpdate();

            frm_loadUpdate.ShowDialog();

            this.lOADTableAdapter.Fill(this.dataSet1.LOAD);

            lOADBindingSource.ResetBindings(false);
            tEACHERSBindingSource.ResetBindings(false);
        }


    }
}
