﻿using System;
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
    public partial class DiscountDetailForm : Form
    {
        public Data.pos13dbDataContext db = new Data.pos13dbDataContext();
        public SettingsForm settingsForm;

        public DiscountDetailForm(SettingsForm form)
        {
            InitializeComponent();

            settingsForm = form;
            CreateDiscountComboBox();
        }

        public void CreateDiscountComboBox()
        {
            var discounts = from d in db.MstDiscounts
                            select d;

            if (discounts.Any())
            {
                cboDiscount.DataSource = discounts.ToList();
                cboDiscount.DisplayMember = "Discount";
                cboDiscount.DropDownStyle = ComboBoxStyle.DropDownList;

                CreateMapDiscountComboBox();
            }
        }

        public void CreateMapDiscountComboBox()
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:2651/api/innosoftPOSIntegration/discount/list");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();

                JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                List<Entities.MstDiscount> discounts = (List<Entities.MstDiscount>)javaScriptSerializer.Deserialize(result, typeof(List<Entities.MstDiscount>));

                cboMapDiscount.DataSource = discounts.ToList();
                cboMapDiscount.DisplayMember = "Discount";
                cboMapDiscount.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void btnSaveDiscount_Click(object sender, EventArgs e)
        {
            settingsForm.RefreshDiscountDataGrid(cboDiscount.Text, cboMapDiscount.Text);
            Hide();
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
