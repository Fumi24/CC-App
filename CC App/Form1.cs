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

namespace CC_App
{
    public partial class Form1 : Form
    {
        public string file1 = "";
        public string file2 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfileload1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {

            }
            txtboxfile1.Text = openFileDialog1.FileName;
            file1 = openFileDialog1.FileName;


        }

        private void btnloadfile2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {

            }
            txtboxfile2.Text = openFileDialog1.FileName;
            file2 = openFileDialog1.FileName;
        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.WorkingDirectory = @"C:\Program Files\CloudCompare";
            process.StartInfo.Arguments = "/C CloudCompare -o " + file1 + " -o " + file2 + " -C2C_DIST -C_EXPORT_FMT PLY -SAVE_CLOUDS";
            process.Start();

            process.WaitForExit();
            process.Close();
        }

        private void btnbinopen_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.WorkingDirectory = @"C:\Program Files\CloudCompare";
            process.StartInfo.Arguments = "/C CloudCompare";
            process.Start();



        }
    }
}
