using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursa4
{
    public partial class servis : Form
    {
        public servis()
        {
            InitializeComponent();
        }

        private devicesList devices = new devicesList();
        private devicesList Devices { get { return devices; } set { devices = value; }}
        private void addDevice(object sender, EventArgs e)
        {
            addDevicePanel.Visible = true;
        }

        private void addDeviceButton_Click(object sender, EventArgs e)
        {
            deviceAdded.Visible = true;
            producerBox.Clear();
            modelBox.Clear();
            serialIDBox.Clear();
            problemBox.Clear();
        }

        private void producerBox_MouseClick(object sender, MouseEventArgs e)
        {
            deviceAdded.Visible = false;
        }

        private void modelBox_MouseClick(object sender, MouseEventArgs e)
        {
            deviceAdded.Visible = false;
        }

        private void serialIDBox_MouseClick(object sender, MouseEventArgs e)
        {
            deviceAdded.Visible = false;
        }

        private void problemBox_MouseClick(object sender, MouseEventArgs e)
        {
            deviceAdded.Visible = false;
        }
    }
}
