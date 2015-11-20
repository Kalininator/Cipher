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

            if (radiobutton_generateall.Checked)
            {
                txtbox_output.Text = "";
                for(int i = 1; i < 26; i ++)
                {
                    txtbox_output.Text += ("Shift by " + i + ":" + System.Environment.NewLine);
                    txtbox_output.Text += Encrypter.ShiftString(txtbox_input.Text.ToUpper(), i) + System.Environment.NewLine + System.Environment.NewLine;
                }
            }
            else if (radiobutton_generatesinglevalue.Checked)
            {
                txtbox_output.Text = Encrypter.ShiftString(txtbox_input.Text.ToUpper(), (int)inp_shiftvalue.Value);
            }
            
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

        private void radiobutton_generatesinglevalue_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobutton_generatesinglevalue.Checked)
            {
                inp_shiftvalue.Enabled = true;
            }
            else
            {
                inp_shiftvalue.Enabled = false;
            }
        }

        private void predictToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtbox_output.Text = Encrypter.ShiftString(txtbox_input.Text, FrequencyAnalysis.PredictShiftValue(txtbox_input.Text));
        }
    }
}
