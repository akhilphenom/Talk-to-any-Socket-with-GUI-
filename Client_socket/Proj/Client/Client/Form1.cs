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

namespace Client
{
    public partial class Form1 : Form
    {

        public Boolean mode;
        TcpClient client;
        int port;
        string msg,cmd;
        int bytecount;
        NetworkStream stream,stream2;
        byte[] tosend;
        string feedback;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void onbut_Click(object sender, EventArgs e)
        {
            mode = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(porttext.Text, out port))
            {
                MessageBox.Show("\n Incorrect Port! \n");
                outputtext.Items.Add("\n Invalid Port number\n");

            }
            try
            {
                client = new TcpClient(iptext.Text, port);
                MessageBox.Show("\n Connection made!");
                outputtext.Items.Add("\n Made connection with " + iptext.Text);
            }
            catch(System.Net.Sockets.SocketException)
            {
                MessageBox.Show("\n Connection got failed!");
                outputtext.Items.Add("Connection failed");
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                msg = msgtext.Text;
                bytecount = Encoding.ASCII.GetByteCount(msg);
                tosend = new byte[bytecount];
                tosend = Encoding.ASCII.GetBytes(msg);
                stream = client.GetStream();
                stream.Write(tosend, 0, tosend.Length);
                outputtext.Items.Add("Sent the message - "+msg);   
            }
            catch(System.NullReferenceException)
            {
                MessageBox.Show("Unabl to send Message!");
                outputtext.Items.Add("Failed to send message");
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            stream.Close();     
            client.Close();
            outputtext.Items.Add("Connection ended");
        }

        private void a_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void offbut_Click(object sender, EventArgs e)
        {
            mode = false;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if(mode==false)
            {
                outputtext.Items.Add("Command mode is inactive!");
            }
            else
            {
                try
                {
                    cmd = comtext.Text;
                    bytecount = Encoding.ASCII.GetByteCount(cmd);
                    tosend = new byte[bytecount];
                    tosend = Encoding.ASCII.GetBytes(cmd);
                    stream = client.GetStream();
                    stream.Write(tosend, 0, tosend.Length);
                    outputtext.Items.Add("COMMAND - " + cmd);
                    if (stream.CanRead)
                    {
                        byte[] readbuffer = new byte[1024];
                       // feedback = "";
                        int bytesread = 0;
                        while (stream.DataAvailable)
                        {
                            bytesread = stream.Read(readbuffer, 0, readbuffer.Length);
                            //feedback = String.Concat(feedback, Encoding.ASCII.GetString(readbuffer, 0, bytesread));
                            feedback = Encoding.ASCII.GetString(readbuffer, 0, bytesread);
                            feedtext.Items.Add(feedback);
                        }
                    }
                }
                catch (System.NullReferenceException)
                {
                    outputtext.Items.Add("Done!");
                }
            }
        }
    }
}
