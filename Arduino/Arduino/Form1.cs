using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Arduino
{
    public partial class ArduinoPnl : Form
    {
        SerialPort sp = new SerialPort();
       private int err = 1;
        public ArduinoPnl()
        {
            InitializeComponent();
            sp.PortName = "COM3";
            sp.BaudRate = 9600;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            if (sp.IsOpen == false) { 
            sp.Open();
                timer1.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(sp.IsOpen) 
            {
                timer1.Stop();
                sp.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            InfoWindow.Text = sp.ReadLine();
        }
    }
}
