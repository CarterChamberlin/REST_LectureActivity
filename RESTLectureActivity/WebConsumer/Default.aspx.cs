using System;
using System.Web.UI;
using System.Net;
using System.IO;

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

            string urlPW = @"http://localhost:54497/Service1.svc/password?firstName=" + firstName + "&lastName=" + lastName + "&age=" + age;
            password = readerResponse(urlPW);
            password = password.Remove(password.Length - 1, 1);
            password = password.Remove(0, 1);
            PASSWORD.Text = password;

            string urlID = @"http://localhost:54497/Service1.svc/loginID?age=" + age;
            loginID = Int32.Parse(readerResponse(urlID));
            LOGINID.Text = loginID.ToString();
            
            
        }

        string readerResponse(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            return reader.ReadToEnd();
        }
    }
}