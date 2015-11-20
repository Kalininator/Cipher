using System;
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
            try
            {
                txtbox_input.Text = System.IO.File.ReadAllText(dialog_openfile.FileName);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            txtbox_output.Text = Encrypter.ShiftString(txtbox_input.Text, -27);
        }

        private void btn_savetofile_Click(object sender, EventArgs e)
        {
            dialog_savefile.ShowDialog();
            try {
                System.IO.File.WriteAllText(dialog_savefile.FileName, txtbox_output.Text);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        
        
    }
}
