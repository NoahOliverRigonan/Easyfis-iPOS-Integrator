using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class TaxDetailForm : Form
    {
        public Data.pos13dbDataContext db = new Data.pos13dbDataContext();
        public SettingsForm settingsForm;

        public TaxDetailForm(SettingsForm form)
        {
            InitializeComponent();

            settingsForm = form;
            CreateTaxComboBox();
        }

        public void CreateTaxComboBox()
        {
            var taxes = from d in db.MstTaxes
                        select d;

            if (taxes.Any())
            {
                cboTax.DataSource = taxes.ToList();
                cboTax.DisplayMember = "Tax";
                cboTax.DropDownStyle = ComboBoxStyle.DropDownList;

                CreateMapTaxComboBox();
            }
        }

        public void CreateMapTaxComboBox()
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:2651/api/innosoftPOSIntegration/tax/list");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();

                JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                List<Entities.MstTax> taxes = (List<Entities.MstTax>)javaScriptSerializer.Deserialize(result, typeof(List<Entities.MstTax>));

                cboMapTax.DataSource = taxes.ToList();
                cboMapTax.DisplayMember = "Tax";
                cboMapTax.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void btnSaveDiscount_Click(object sender, EventArgs e)
        {
            settingsForm.RefreshTaxDataGrid(cboTax.Text, cboMapTax.Text);
            Hide();
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
