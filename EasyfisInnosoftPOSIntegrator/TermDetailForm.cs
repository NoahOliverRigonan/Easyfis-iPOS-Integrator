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
    public partial class TermDetailForm : Form
    {
        public Data.pos13dbDataContext db = new Data.pos13dbDataContext();
        public SettingsForm settingsForm;

        public TermDetailForm(SettingsForm form)
        {
            InitializeComponent();

            settingsForm = form;
            CreateTermComboBox();
        }


        public void CreateTermComboBox()
        {
            var terms = from d in db.MstTerms
                        select d;

            if (terms.Any())
            {
                cboTerm.DataSource = terms.ToList();
                cboTerm.DisplayMember = "Term";
                cboTerm.DropDownStyle = ComboBoxStyle.DropDownList;

                CreateMapTermComboBox();
            }
        }

        public void CreateMapTermComboBox()
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:2651/api/innosoftPOSIntegration/term/list");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();

                JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                List<Entities.MstTerm> termes = (List<Entities.MstTerm>)javaScriptSerializer.Deserialize(result, typeof(List<Entities.MstTerm>));

                cboMapTerm.DataSource = termes.ToList();
                cboMapTerm.DisplayMember = "Term";
                cboMapTerm.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void btnSaveDiscount_Click(object sender, EventArgs e)
        {
            settingsForm.RefreshTermDataGrid(cboTerm.Text, cboMapTerm.Text);
            Hide();
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
