using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectToServer_Click(object sender, EventArgs e)
        {
            if (EditIP.Text != "") {
                if ( File.Exists ( "Multi Theft Auto.exe" ) )
                {
                    Process.Start("Multi Theft Auto.exe", "mtasa://" + EditIP.Text);
                    HelperText.Text = "МТА запущена!";
                } 
                else if ( File.Exists ( "MTA\\Multi Theft Auto.exe" ) )
                {
                    Process.Start("MTA\\Multi Theft Auto.exe", "mtasa://" + EditIP.Text);
                    HelperText.Text = "МТА запущена!";
                }
                else
                {
                    HelperText.Text = "МТА нет в папке!";
                }
            }
            else
            {
                HelperText.Text = "Вы не ввели IP!";
            }
        }
    }
}
