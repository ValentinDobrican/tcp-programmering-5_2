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
using System.Net.Sockets;

namespace KlientForm
{
    public partial class KlientForm : Form
    {
        TcpClient klient;
        int port = 12345;
        public KlientForm()
        {
            InitializeComponent();
        }

        private void btnAnslut_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress adress = IPAddress.Parse(tbxIPAdress.Text);

                //Skapa Klient
                klient = new TcpClient();
                klient.NoDelay = true;
                klient.Connect(adress, port); //Connect funktionen anropas

                btnAnslut.Enabled = false;
                btnSänd.Enabled = true;
            }
            catch ( Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            
        }

        private void btnSänd_Click(object sender, EventArgs e)
        {
            if (klient.Connected)  //if-sats där om anslutning lyckas då ska det sända data
            {
                byte[] utData = Encoding.Unicode.GetBytes(tbxMeddelande.Text);
                klient.GetStream().Write(utData, 0, utData.Length);
                
            }
        }
        private void KlientForm_FormClosing(object sender, EventArgs e)
        {
            if (klient.Connected)
            {
                klient.Close();
            }
        }

    }
}
