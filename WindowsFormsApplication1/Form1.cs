using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var request = (HttpWebRequest)WebRequest.Create("http://www.otorita.net/otoritadb/pages/hozim_new/103_1479.pdf");

            var response = (HttpWebResponse)request.GetResponse();


            byte[] responseBytes = new BinaryReader(response.GetResponseStream()).ReadBytes((int)response.ContentLength);
                        System.IO.File.WriteAllBytes("c:\\users\\shay\\currentPDF.pdf", responseBytes);
  //                      MessageBox.Show(responseString);
//            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {
            pdf1.LoadFile("c:\\users\\shay\\currentPDF.pdf");
//            System.IO.File.Delete("c:\\users\\shay\\currentPDF.pdf");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}
