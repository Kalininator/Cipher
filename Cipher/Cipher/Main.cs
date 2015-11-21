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
            switch(tabSystem.SelectedIndex)
            {
                case 0:
                    //caesar cipher
                    decrypt_caesar();
                    break;
                case 1:
                    //affine cipher
                    decrypt_affine();
                    break;
            }
        }
        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            switch (tabSystem.SelectedIndex)
            {
                case 0:
                    //caesar cipher
                    encrypt_caesar();
                    break;
                case 1:
                    //affine cipher
                    encrypt_affine();
                    break;
            }
        }


        //AFFINE CIPHER
        private void encrypt_affine()
        {
            txtbox_output.Text = Encrypter.AffineEncrypt(txtbox_input.Text,(int)affine_inp_m.Value,(int)affine_inp_c.Value);
        }
        private void decrypt_affine()
        {

        }


        //CAESAR CIPHER
        private void encrypt_caesar()
        {
            txtbox_output.Text = Encrypter.ShiftString(txtbox_input.Text.ToUpper(), -(int)inp_shiftvalue.Value);
        }
        private void decrypt_caesar()
        {
            if (caesar_radiobutton_generateall.Checked)
            {
                txtbox_output.Text = "";
                for(int i = 1; i < 26; i ++)
                {
                    txtbox_output.Text += ("Shift by " + i + ":" + System.Environment.NewLine);
                    txtbox_output.Text += Encrypter.ShiftString(txtbox_input.Text.ToUpper(), i) + System.Environment.NewLine + System.Environment.NewLine;
                }
            }
            else if (caesar_radiobutton_generatesinglevalue.Checked)
            {
                txtbox_output.Text = Encrypter.ShiftString(txtbox_input.Text.ToUpper(), (int)inp_shiftvalue.Value);
            }else if(caesar_radiobutton_predict.Checked)
            {
                txtbox_output.Text = Encrypter.ShiftString(txtbox_input.Text, FrequencyAnalysis.PredictShiftValue(txtbox_input.Text));
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
            if (caesar_radiobutton_generatesinglevalue.Checked)
            {
                inp_shiftvalue.Enabled = true;
                btn_encrypt.Enabled = true;
            }
            else
            {
                inp_shiftvalue.Enabled = false;
                btn_encrypt.Enabled = false;
            }
        }

        private void tabSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //settings to set when changing tabs
            switch(tabSystem.SelectedIndex)
            {
                case 0:
                    //caesar
                    btn_encrypt.Enabled = false;
                    caesar_radiobutton_generateall.Checked = true;
                    btn_decrypt.Enabled = true;
                    break;
                case 1:
                    //affine
                    btn_encrypt.Enabled = true;
                    btn_decrypt.Enabled = false;
                    break;
            }
        }
    }
}
