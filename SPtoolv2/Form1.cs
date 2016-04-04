using System;
using Microsoft.SharePoint.Client.Application;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;


namespace SPtoolv2
{
    public partial class sptool : Form
    {
        public static Dictionary<string, string> claves = new Dictionary<string, string>();
        public sptool()
        {
            InitializeComponent();
            string path=@"C:\Users\ereyes\Documents\Visual Studio 2012\Projects\SPtoolv2\SPtoolv2\Resources\CustomTemplatesList";
            string[] filePaths = Directory.GetFiles(path,"*.xml");
            foreach (var x in filePaths) {
                var f = new FileInfo(x).Name.Split('.')[0];
                Template.Items.Add(f);
          
            }
           
        }

        private void btn_cn_Click(object sender, EventArgs e)
        {
          
            if (isOnline.Checked)
            {
                if (Helper.CreateList(siteUrl.Text, NameList.Text, Microsoft.SharePoint.Client.ListTemplateType.GenericList, "Nomina",true))
                {
                    MessageBox.Show("Se ha creado con Exito la lsita");
                }
                else
                {
                    // MessageBox.Show("Algo salio mal :(");
                }
            }
            else {
                if (Helper.CreateList(siteUrl.Text, NameList.Text, Microsoft.SharePoint.Client.ListTemplateType.GenericList, "Nomina",false))
                {
                    MessageBox.Show("Se ha creado con Exito la lsita");
                }
                else
                {
                    // MessageBox.Show("Algo salio mal :(");
                }
            
            
            }
        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void btn_conect_Click(object sender, EventArgs e)
        {
            login log= new login();
            log.Show();
           // MessageBox.Show(
        }

        private void button1_Click(object sender, EventArgs e)
        {
           List<UserAD> user=Helper.GetUserAccounts();
        }
      
    }
}
