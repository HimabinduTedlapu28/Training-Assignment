using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RemotingServer;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;



namespace remoting_client
{
    public partial class Form1 : Form
    {
        Service remoteobj = new Service();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            remoteobj = (Service)Activator.GetObject(typeof(Service), "Tcp://localhost:8089/OurFirstRemoteService");
            int n1 = Int32.Parse(txtnum1.Text);
            int n2 = Int32.Parse(txtnum2.Text);
            txtresult.Text = remoteobj.HighestNumber(n1, n2).ToString();

        }

        private void btnlowest_Click(object sender, EventArgs e)
        {
            remoteobj = (Service)Activator.GetObject(typeof(Service), "Tcp://localhost:8089/OurFirstRemoteService");
            int n1 = Int32.Parse(txtnum1.Text);
            int n2 = Int32.Parse(txtnum2.Text);
            txtresult.Text = remoteobj.LowestNumber(n1, n2).ToString();
        }

        private void txtdisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
