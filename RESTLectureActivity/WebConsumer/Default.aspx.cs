using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Xml;
//using System.Net.Http;
//using System.Runtime.Serialization.Json;

namespace WebConsumer
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LOGINID.ReadOnly = true;
            PASSWORD.ReadOnly = true;
        }






        protected void SUBMIT_Click(object sender, EventArgs e)
        {
            string firstName = String.Empty;
            string lastName = String.Empty;
            int age = 0;

            string password = String.Empty;
            int loginID = 0;

            firstName = FIRST.Text;
            lastName = LAST.Text;
            age = Int32.Parse(AGE.Text);
        }
    }
}