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
    public partial class UnitDetailForm : Form
    {
        public Data.pos13dbDataContext db = new Data.pos13dbDataContext();
        public SettingsForm settingsForm;

        public UnitDetailForm(SettingsForm form)
        {
            InitializeComponent();

            settingsForm = form;
            CreateUnitComboBox();
        }

        public void CreateUnitComboBox()
        {
            var units = from d in db.MstUnits
                        select d;

            if (units.Any())
            {
                cboUnit.DataSource = units.ToList();
                cboUnit.DisplayMember = "Unit";
                cboUnit.DropDownStyle = ComboBoxStyle.DropDownList;

                CreateMapUnitComboBox();
            }
        }

        public void CreateMapUnitComboBox()
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:2651/api/innosoftPOSIntegration/unit/list");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();

                JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                List<Entities.MstUnit> units = (List<Entities.MstUnit>)javaScriptSerializer.Deserialize(result, typeof(List<Entities.MstUnit>));

                cboMapUnit.DataSource = units.ToList();
                cboMapUnit.DisplayMember = "Unit";
                cboMapUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void btnSaveDiscount_Click(object sender, EventArgs e)
        {
            settingsForm.RefreshUnitDataGrid(cboUnit.Text, cboMapUnit.Text);
            Hide();
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
