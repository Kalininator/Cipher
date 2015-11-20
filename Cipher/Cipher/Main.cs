using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cipher
{
    public partial class form_main : Form
    {



        public form_main()
        {
            InitializeComponent();
        }

        private void readFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialog_openfile.ShowDialog();
            String filecontents;
            filecontents = System.IO.File.ReadAllText(dialog_openfile.FileName);
            txtbox_input.Text = filecontents;
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            txtbox_output.Text = ShiftString(txtbox_input.Text, 3);
        }

        private void btn_savetofile_Click(object sender, EventArgs e)
        {
            dialog_savefile.ShowDialog();
            System.IO.File.WriteAllText(dialog_savefile.FileName, txtbox_output.Text);
        }

        private String ShiftString(String str, int shift)
        {
            String temp = "";
            for (int i = 0; i < str.Length; i++)
            {
                temp += ShiftChar(str[i], shift);
            }
            return temp;
        }
        private char ShiftChar(char x, int shift)
        {
            if ((int)x < 91 && (int)x > 64)
            {
                int initChar = (int)x;
                return (char)((((initChar - 65) + shift) % 26) + 65);
            }
            else if ((int)x < 122 && (int)x > 96)
            {
                int initChar = (int)x;
                return (char)((((initChar - 97) + shift) % 26) + 97);
            }
            else
            {
                return x;
            }
        }
        
    }
}
