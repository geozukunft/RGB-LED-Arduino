using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;  //neccessary to use the serial communication
using System.IO;
using System.Threading;


namespace Timer
{
    public partial class Form1 : Form
    {
        int[,] presetRGB = new int[3, 3] { {250, 250, 250}, { 10, 10, 10}, { 127, 127, 127} };
        public Form1()
        {
            InitializeComponent();
            initLBO();
        }
        
        private void initLBO()
        {
            lboModes.Items.Add("Tageslicht");
            lboModes.Items.Add("Nachmodus");
            lboModes.Items.Add("Manual Preset 1");
            lboModes.Items.Add("Trackbar");

        }

        private void MixColor()
        {
            panel1.BackColor = Color.FromArgb(trkRed.Value, trkGreen.Value, trkBlue.Value);
            lblRed.Text = Convert.ToString(trkRed.Value);
            lblGreen.Text = Convert.ToString(trkGreen.Value);
            lblBlue.Text = Convert.ToString(trkBlue.Value);


        }

        private void lboModes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lboModes.SelectedIndex != 3)
            {
                trkRed.Value = presetRGB[lboModes.SelectedIndex, 0];
                trkGreen.Value = presetRGB[lboModes.SelectedIndex, 1];
                trkBlue.Value = presetRGB[lboModes.SelectedIndex, 2];
            }
        }

        //finding an listing all usable ports
        private void ListCom()
        {
            string[] ports = SerialPort.GetPortNames();
            // Display each port name in the dropdown
            foreach (string port in ports)
            {
                cboPorts.Items.Add(port);
            }
        }//ListCom()



        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            ListCom();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (cboPorts.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose COM-Port!");
            }
            else
            {
                serialPort1.PortName = cboPorts.SelectedItem.ToString();
                if (!serialPort1.IsOpen)
                {
                    try
                    {
                        serialPort1.Open();
                        lblInfo.Text = "Port open";
                    }
                    catch (Exception ex)
                    {
                        lblInfo.Text = "Port open failed";
                    }
                }

            }
        }//public partial class Form1 : Form

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                lblInfo.Text = "Port closed";
            }
            else
            {
                lblInfo.Text = "Port not open";
            }
        }

        private void programmBeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MixRed(object sender, EventArgs e)
        {
            MixColor();
        }

        private void MixGreen(object sender, EventArgs e)
        {
            MixColor();
        }

        private void MixBlue(object sender, EventArgs e)
        {
            
            MixColor();
        }

        private void cmdSendData_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write(trkRed.Value + ";" + trkGreen.Value + ";" + trkBlue.Value + ";");       
            }
            catch
            {
                MessageBox.Show("No Port opened please open a Port");
            }

        }

        private void trkBlue_mouse(object sender, MouseEventArgs e)
        {
            if (lboModes.SelectedIndex != 3)
            {
                lboModes.SelectedIndex = 3;
            }
        }

        private void trkGreen_mouse(object sender, MouseEventArgs e)
        {
            if (lboModes.SelectedIndex != 3)
            {
                lboModes.SelectedIndex = 3;
            }
        }

        private void trkRed_mouse(object sender, MouseEventArgs e)
        {
            if (lboModes.SelectedIndex != 3)
            {
                lboModes.SelectedIndex = 3;
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            presetRGB[2, 0] = trkRed.Value;
            presetRGB[2, 1] = trkGreen.Value;
            presetRGB[2, 2] = trkBlue.Value;
            lboModes.SelectedIndex = 2;

        }
    }

}//namespace Timer
