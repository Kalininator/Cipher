using System;
using System.Text.RegularExpressions;
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
            txtbox_output.Text = Encrypter.AffineEncrypt(txtbox_input.Text,int.Parse(affine_inp_m.SelectedItem.ToString()),(int)affine_inp_c.Value);
        }
        private void decrypt_affine()
        {
            txtbox_output.Text = Encrypter.AffineDecrypt(txtbox_input.Text,int.Parse(affine_inp_m.SelectedItem.ToString()),(int)affine_inp_c.Value);
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
            }
            else if(caesar_radiobutton_predict.Checked)
            {

                
                String[] options = new String[26];
                
                for(int i = 0; i < options.Length; i ++)
                {
                    options[i] = Encrypter.ShiftString(txtbox_input.Text,i);
                }

                txtbox_output.Text = options[FrequencyAnalysis.Predict(options)];

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
                    btn_decrypt.Enabled = true;
                    break;
            }
        }

        private void saveToTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialog_savefile.Filter = "Text File|*.txt";
            dialog_savefile.ShowDialog();
            try
            {
                System.IO.File.WriteAllText(dialog_savefile.FileName, txtbox_output.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void saveToWebPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String output = txtbox_output.Text;
            output = Regex.Replace(output, @"\r\n?|\n", "<br />");
            dialog_savefile.Filter = "Web Page|*.html";
            dialog_savefile.ShowDialog();
            try
            {
                System.IO.File.WriteAllText(dialog_savefile.FileName, output);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void affine_radiopredict_CheckedChanged(object sender, EventArgs e)
        {
            if(affine_radiopredict.Checked)
            {
                affine_formulabox.Enabled = false;
                btn_encrypt.Enabled = false;
            }
            else
            {
                affine_formulabox.Enabled = true;
                btn_encrypt.Enabled = true;
            }
        }
    }
}
