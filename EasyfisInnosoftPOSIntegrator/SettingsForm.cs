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
        }

        public void CreateDiscountDataGrid()
        {
            try
            {
                dgvDiscount.AutoGenerateColumns = false;
                dgvDiscount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                DataGridViewTextBoxColumn dataGridViewTextBoxColumnDiscount = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Discount",
                    DataPropertyName = "Discount"
                };

                DataGridViewComboBoxColumn dataGridViewComboBoxColumnDiscount = new DataGridViewComboBoxColumn
                {
                    HeaderText = "Map Discount",
                    DataPropertyName = "MapDiscount",
                    DataSource = CreateComboBoxDiscount()
                };

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Discount", typeof(String));
                dataTable.Columns.Add("Map Discount", typeof(String));

                var discounts = from d in db.MstDiscounts select d;
                if (discounts.Any())
                {
                    var rowIndex = 0;
                    foreach (var discount in discounts)
                    {
                        if (rowIndex > 0)
                        {
                            dataTable.Rows.Add(new object[] { discount.Discount, "Zero Discount" });
                        }

                        rowIndex += 1;
                    }
                }

                dgvDiscount.DataSource = dataTable;
                dgvDiscount.Columns.AddRange(dataGridViewTextBoxColumnDiscount, dataGridViewComboBoxColumnDiscount);
                dgvDiscount.Columns[0].ReadOnly = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public List<String> CreateComboBoxDiscount()
        {
            List<String> listDiscounts = new List<String>();

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:2651/api/innosoftPOSIntegration/discount/list");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();

                JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                List<String> discounts = (List<String>)javaScriptSerializer.Deserialize(result, typeof(List<String>));

                foreach (var discount in discounts)
                {
                    listDiscounts.Add(discount);
                }
            }

            return listDiscounts.ToList();
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            DiscountDetailForm discountDetailForm = new DiscountDetailForm();
            discountDetailForm.ShowDialog();
        }
    }
}
