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


namespace ServerForm
{
    public partial class ServerForm : Form
    {
        TcpListener lyssnare;
        TcpClient klient;
        int port = 12345;
        public ServerForm()
        {
            InitializeComponent();
        }

        private void btnStarta_Click(object sender, EventArgs e)
        {
            //Koden gör att lyssnaren startar
            lyssnare = new TcpListener(IPAddress.Any, port);
            lyssnare.Start();

            //Kod för att vänta på anslutning från Klienten
            klient = lyssnare.AcceptTcpClient();
        }

        private void btnTaEmot_Click(object sender, EventArgs e)
        {
            //Kod för att ta emot meddelanden
            byte[] inData = new byte[256];

            int antalByte = klient.GetStream().Read(inData, 0, inData.Length);

            tbxInkorg.Text = Encoding.Unicode.GetString(inData, 0, antalByte);
        }

        private void ServerForm_FormClosing(object sender, EventArgs e)
        {
            klient.Close();
            lyssnare.Stop();
        }
    }
}
