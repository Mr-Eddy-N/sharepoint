using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint.Client;
using System.Xml.Linq;
using System.Security;
using System.Windows.Forms;
using System.Configuration;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices;

namespace SPtoolv2
{
    class Helper
    {   
        public static bool CreateList(string siteUrl,string NameList,ListTemplateType templateList)
        {
            try
            {
                ClientContext clientContext = new ClientContext(siteUrl);
                Web oWebsite = clientContext.Web;
                Site site = clientContext.Site;
                ListCreationInformation listCreationInfo = new ListCreationInformation();
                listCreationInfo.Title = NameList;
                listCreationInfo.TemplateType = (int)templateList;
                List oList = oWebsite.Lists.Add(listCreationInfo);
                //clientContext.ExecuteQuery();
                return true;
            }
            catch (Exception e) {
                return false;
            };
            
        }
        public static bool CreateList(string siteUrl, string NameList, ListTemplateType templateList, string fieldsAdd, bool isOnline)
        {
            string path = @"C:\Users\ereyes\Documents\Visual Studio 2012\Projects\SPtoolv2\SPtoolv2\Resources\CustomTemplatesList\"; 
            try
            {

                string pass = ConfigurationManager.AppSettings["pass"];
                string user = ConfigurationManager.AppSettings["userAdmin"];
                ClientContext clientContext = new ClientContext(siteUrl);
                SecureString passWord = new SecureString();
                foreach (char c in pass.ToCharArray()) passWord.AppendChar(c);
                clientContext.Credentials = new SharePointOnlineCredentials(user, passWord);
                Web oWebsite = clientContext.Web;
                Site site = clientContext.Site;
                ListCreationInformation listCreationInfo = new ListCreationInformation();
                listCreationInfo.Title = NameList;
                listCreationInfo.TemplateType = (int)templateList;
                List oList = oWebsite.Lists.Add(listCreationInfo);
                oList.Update();
                clientContext.ExecuteQuery();
                List nList =clientContext.Web.Lists.GetByTitle(NameList);
                
                XDocument doc = XDocument.Load(path + fieldsAdd+".xml");

                var fields = doc.Descendants("Field");
                Field oField ;

                foreach (var field in fields)
                {
                     nList.Fields.AddFieldAsXml(field.ToString(), true, AddFieldOptions.DefaultValue);
                }
                clientContext.ExecuteQuery();  ; 
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Algo salio mal :(\n\r"+e.Message);
                return false;
            };

        }
        public static SharePointOnlineCredentials getredentialOnline(string user,string pass) {
            SecureString passWord = new SecureString();
            foreach (char c in pass.ToCharArray()) passWord.AppendChar(c);
            SharePointOnlineCredentials Credentials = new SharePointOnlineCredentials(user, passWord);
            return Credentials; 
        }
        public static List<UserAD> GetUserAccounts()
        {
            string domain = "Perifel.com.mx"; //getInfo("dominio");
            //string machine = getInfo("machine");
            //string OU = getInfo("connection");
            List<UserAD> listAccounts = new List<UserAD>();
            try
            {

                //bodymail += "\n" + DateTime.Now + ": Contexto:" + ContextType.Domain.ToString() + " | " + domain + " | " + OU;
                PrincipalContext ctx = new PrincipalContext(ContextType.Domain, domain);
                UserPrincipal qbeUser = new UserPrincipal(ctx);
                PrincipalSearcher srch = new PrincipalSearcher(qbeUser);
                List<UserAD> items = new List<UserAD>();
                foreach (System.DirectoryServices.AccountManagement.Principal result in srch.FindAll())
                {
                    if (!String.IsNullOrEmpty(result.DisplayName))
                    {
                        
                        UserAD item = new UserAD();
                        item.Name = result.DisplayName;
                        listAccounts.Add(item);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               

            }
            return listAccounts;
        }
    }
    public  class UserAD {
        public string Name { get; set; }
    
    }
 
}