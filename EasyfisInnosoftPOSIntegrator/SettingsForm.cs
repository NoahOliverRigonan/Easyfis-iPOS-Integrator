using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace EasyfisInnosoftPOSIntegrator
{
    public partial class SettingsForm : Form
    {
        public Data.pos13dbDataContext db = new Data.pos13dbDataContext();

        public SettingsForm()
        {
            InitializeComponent();
            CreateDiscountDataGrid();
            CreateTaxDataGrid();
            CreateUnitDataGrid();
            CreateTermDataGrid();
        }

        public void CreateDiscountDataGrid()
        {
            try
            {
                btnDeleteDiscount.CellTemplate.Style.BackColor = Color.IndianRed;
                btnDeleteDiscount.CellTemplate.Style.ForeColor = Color.White;

                dgvDiscount.AutoGenerateColumns = false;
                dgvDiscount.Columns[0].DefaultCellStyle.SelectionBackColor = Color.IndianRed;
                dgvDiscount.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvDiscount.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshDiscountDataGrid(String discount, String MapDiscount)
        {
            dgvDiscount.Rows.Add("Delete", discount, MapDiscount);
            dgvDiscount.Refresh();
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            DiscountDetailForm discountDetailForm = new DiscountDetailForm(this);
            discountDetailForm.ShowDialog();
        }

        private void dgvDiscount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult deleteDialogResult = MessageBox.Show("Delete Discount?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (deleteDialogResult == DialogResult.Yes)
                {
                    dgvDiscount.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        public void CreateTaxDataGrid()
        {
            try
            {
                btnDeleteTax.CellTemplate.Style.BackColor = Color.IndianRed;
                btnDeleteTax.CellTemplate.Style.ForeColor = Color.White;

                dgvTax.AutoGenerateColumns = false;
                dgvTax.Columns[0].DefaultCellStyle.SelectionBackColor = Color.IndianRed;
                dgvTax.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTax.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshTaxDataGrid(String tax, String MapTax)
        {
            dgvTax.Rows.Add("Delete", tax, MapTax);
            dgvTax.Refresh();
        }

        private void btnAddTax_Click(object sender, EventArgs e)
        {
            TaxDetailForm taxDetailForm = new TaxDetailForm(this);
            taxDetailForm.ShowDialog();
        }

        private void dgvTax_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult deleteDialogResult = MessageBox.Show("Delete Tax?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (deleteDialogResult == DialogResult.Yes)
                {
                    dgvTax.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        public void CreateUnitDataGrid()
        {
            try
            {
                btnDeleteUnit.CellTemplate.Style.BackColor = Color.IndianRed;
                btnDeleteUnit.CellTemplate.Style.ForeColor = Color.White;

                dgvUnit.AutoGenerateColumns = false;
                dgvUnit.Columns[0].DefaultCellStyle.SelectionBackColor = Color.IndianRed;
                dgvUnit.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvUnit.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshUnitDataGrid(String unit, String MapUnit)
        {
            dgvUnit.Rows.Add("Delete", unit, MapUnit);
            dgvUnit.Refresh();
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            UnitDetailForm unitDetailForm = new UnitDetailForm(this);
            unitDetailForm.ShowDialog();
        }

        private void dgvUnit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult deleteDialogResult = MessageBox.Show("Delete Unit?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (deleteDialogResult == DialogResult.Yes)
                {
                    dgvUnit.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        public void CreateTermDataGrid()
        {
            try
            {
                btnDeleteTerm.CellTemplate.Style.BackColor = Color.IndianRed;
                btnDeleteTerm.CellTemplate.Style.ForeColor = Color.White;

                dgvTerm.AutoGenerateColumns = false;
                dgvTerm.Columns[0].DefaultCellStyle.SelectionBackColor = Color.IndianRed;
                dgvTerm.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTerm.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshTermDataGrid(String term, String MapTerm)
        {
            dgvTerm.Rows.Add("Delete", term, MapTerm);
            dgvTerm.Refresh();
        }

        private void btnAddTerm_Click(object sender, EventArgs e)
        {
            TermDetailForm termDetailForm = new TermDetailForm(this);
            termDetailForm.ShowDialog();
        }

        private void dgvTerm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult deleteDialogResult = MessageBox.Show("Delete Term?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (deleteDialogResult == DialogResult.Yes)
                {
                    dgvTerm.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
