using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckIPv4Address
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtIpAddress_TextChanged(object sender, EventArgs e)
        {
            String ipAddress;

            ipAddress = txtIpAddress.ToString();

            if (Validation(ipAddress))
            {
                lblResult.BackColor = Color.ForestGreen;
                lblResult.Text = "IPv4 address is legit";

            }

            else
            {
                lblResult.BackColor = Color.Firebrick;
                lblResult.Text = "IPv4 address is wrong";
            }
        }
       
        private bool Validation(string ipAddress)
        {
            Regex validationIpAddress = new Regex(@"(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])");

            bool isIpAddress = false;

            isIpAddress = validationIpAddress.IsMatch(ipAddress);

            return isIpAddress;
        }

    }
}
