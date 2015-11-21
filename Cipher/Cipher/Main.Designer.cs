namespace Cipher
{
    partial class form_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_readfromfile = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.dialog_openfile = new System.Windows.Forms.OpenFileDialog();
            this.btn_savetofile = new System.Windows.Forms.Button();
            this.dialog_savefile = new System.Windows.Forms.SaveFileDialog();
            this.caesar_layout_groupbox = new System.Windows.Forms.GroupBox();
            this.inp_shiftvalue = new System.Windows.Forms.NumericUpDown();
            this.caesar_radiobutton_generatesinglevalue = new System.Windows.Forms.RadioButton();
            this.caesar_radiobutton_generateall = new System.Windows.Forms.RadioButton();
            this.tabSystem = new System.Windows.Forms.TabControl();
            this.tab_caesar = new System.Windows.Forms.TabPage();
            this.tab_affine = new System.Windows.Forms.TabPage();
            this.caesar_radiobutton_predict = new System.Windows.Forms.RadioButton();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.affine_lbl_formula = new System.Windows.Forms.Label();
            this.affine_lbl_shiftby = new System.Windows.Forms.Label();
            this.affine_inp_m = new System.Windows.Forms.NumericUpDown();
            this.affine_label_x = new System.Windows.Forms.Label();
            this.affine_inp_c = new System.Windows.Forms.NumericUpDown();
            this.txtbox_input = new System.Windows.Forms.RichTextBox();
            this.txtbox_output = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.caesar_layout_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inp_shiftvalue)).BeginInit();
            this.tabSystem.SuspendLayout();
            this.tab_caesar.SuspendLayout();
            this.tab_affine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.affine_inp_m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.affine_inp_c)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(263, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_readfromfile});
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.inputToolStripMenuItem.Text = "Input";
            // 
            // btn_readfromfile
            // 
            this.btn_readfromfile.Name = "btn_readfromfile";
            this.btn_readfromfile.Size = new System.Drawing.Size(152, 22);
            this.btn_readfromfile.Text = "Read From File";
            this.btn_readfromfile.Click += new System.EventHandler(this.readFromFileToolStripMenuItem_Click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_decrypt.Location = new System.Drawing.Point(12, 331);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(239, 23);
            this.btn_decrypt.TabIndex = 2;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // dialog_openfile
            // 
            this.dialog_openfile.Filter = "Text Files|*.txt";
            this.dialog_openfile.InitialDirectory = "C:";
            // 
            // btn_savetofile
            // 
            this.btn_savetofile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_savetofile.Location = new System.Drawing.Point(12, 494);
            this.btn_savetofile.Name = "btn_savetofile";
            this.btn_savetofile.Size = new System.Drawing.Size(239, 29);
            this.btn_savetofile.TabIndex = 4;
            this.btn_savetofile.Text = "Save To File";
            this.btn_savetofile.UseVisualStyleBackColor = true;
            this.btn_savetofile.Click += new System.EventHandler(this.btn_savetofile_Click);
            // 
            // dialog_savefile
            // 
            this.dialog_savefile.FileName = "caesarShiftPlainText.txt";
            this.dialog_savefile.Filter = "Text File|*.txt";
            // 
            // caesar_layout_groupbox
            // 
            this.caesar_layout_groupbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.caesar_layout_groupbox.Controls.Add(this.caesar_radiobutton_predict);
            this.caesar_layout_groupbox.Controls.Add(this.inp_shiftvalue);
            this.caesar_layout_groupbox.Controls.Add(this.caesar_radiobutton_generatesinglevalue);
            this.caesar_layout_groupbox.Controls.Add(this.caesar_radiobutton_generateall);
            this.caesar_layout_groupbox.Location = new System.Drawing.Point(6, 6);
            this.caesar_layout_groupbox.Name = "caesar_layout_groupbox";
            this.caesar_layout_groupbox.Size = new System.Drawing.Size(219, 88);
            this.caesar_layout_groupbox.TabIndex = 5;
            this.caesar_layout_groupbox.TabStop = false;
            this.caesar_layout_groupbox.Text = "Options";
            // 
            // inp_shiftvalue
            // 
            this.inp_shiftvalue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inp_shiftvalue.Enabled = false;
            this.inp_shiftvalue.Location = new System.Drawing.Point(127, 44);
            this.inp_shiftvalue.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.inp_shiftvalue.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            -2147483648});
            this.inp_shiftvalue.MinimumSize = new System.Drawing.Size(35, 0);
            this.inp_shiftvalue.Name = "inp_shiftvalue";
            this.inp_shiftvalue.Size = new System.Drawing.Size(86, 20);
            this.inp_shiftvalue.TabIndex = 2;
            // 
            // caesar_radiobutton_generatesinglevalue
            // 
            this.caesar_radiobutton_generatesinglevalue.AutoSize = true;
            this.caesar_radiobutton_generatesinglevalue.Location = new System.Drawing.Point(7, 44);
            this.caesar_radiobutton_generatesinglevalue.Name = "caesar_radiobutton_generatesinglevalue";
            this.caesar_radiobutton_generatesinglevalue.Size = new System.Drawing.Size(114, 17);
            this.caesar_radiobutton_generatesinglevalue.TabIndex = 1;
            this.caesar_radiobutton_generatesinglevalue.Text = "Shift with set value";
            this.caesar_radiobutton_generatesinglevalue.UseVisualStyleBackColor = true;
            this.caesar_radiobutton_generatesinglevalue.CheckedChanged += new System.EventHandler(this.radiobutton_generatesinglevalue_CheckedChanged);
            // 
            // caesar_radiobutton_generateall
            // 
            this.caesar_radiobutton_generateall.AutoSize = true;
            this.caesar_radiobutton_generateall.Checked = true;
            this.caesar_radiobutton_generateall.Location = new System.Drawing.Point(7, 20);
            this.caesar_radiobutton_generateall.Name = "caesar_radiobutton_generateall";
            this.caesar_radiobutton_generateall.Size = new System.Drawing.Size(165, 17);
            this.caesar_radiobutton_generateall.TabIndex = 0;
            this.caesar_radiobutton_generateall.TabStop = true;
            this.caesar_radiobutton_generateall.Text = "Generate All Possible Outputs";
            this.caesar_radiobutton_generateall.UseVisualStyleBackColor = true;
            // 
            // tabSystem
            // 
            this.tabSystem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSystem.Controls.Add(this.tab_caesar);
            this.tabSystem.Controls.Add(this.tab_affine);
            this.tabSystem.Location = new System.Drawing.Point(12, 169);
            this.tabSystem.Name = "tabSystem";
            this.tabSystem.SelectedIndex = 0;
            this.tabSystem.Size = new System.Drawing.Size(239, 126);
            this.tabSystem.TabIndex = 6;
            this.tabSystem.SelectedIndexChanged += new System.EventHandler(this.tabSystem_SelectedIndexChanged);
            // 
            // tab_caesar
            // 
            this.tab_caesar.Controls.Add(this.caesar_layout_groupbox);
            this.tab_caesar.Location = new System.Drawing.Point(4, 22);
            this.tab_caesar.Name = "tab_caesar";
            this.tab_caesar.Padding = new System.Windows.Forms.Padding(3);
            this.tab_caesar.Size = new System.Drawing.Size(231, 100);
            this.tab_caesar.TabIndex = 0;
            this.tab_caesar.Text = "Caesar";
            this.tab_caesar.UseVisualStyleBackColor = true;
            // 
            // tab_affine
            // 
            this.tab_affine.Controls.Add(this.affine_inp_c);
            this.tab_affine.Controls.Add(this.affine_label_x);
            this.tab_affine.Controls.Add(this.affine_inp_m);
            this.tab_affine.Controls.Add(this.affine_lbl_shiftby);
            this.tab_affine.Controls.Add(this.affine_lbl_formula);
            this.tab_affine.Location = new System.Drawing.Point(4, 22);
            this.tab_affine.Name = "tab_affine";
            this.tab_affine.Padding = new System.Windows.Forms.Padding(3);
            this.tab_affine.Size = new System.Drawing.Size(231, 100);
            this.tab_affine.TabIndex = 1;
            this.tab_affine.Text = "Affine";
            this.tab_affine.UseVisualStyleBackColor = true;
            // 
            // caesar_radiobutton_predict
            // 
            this.caesar_radiobutton_predict.AutoSize = true;
            this.caesar_radiobutton_predict.Location = new System.Drawing.Point(7, 68);
            this.caesar_radiobutton_predict.Name = "caesar_radiobutton_predict";
            this.caesar_radiobutton_predict.Size = new System.Drawing.Size(58, 17);
            this.caesar_radiobutton_predict.TabIndex = 3;
            this.caesar_radiobutton_predict.TabStop = true;
            this.caesar_radiobutton_predict.Text = "Predict";
            this.caesar_radiobutton_predict.UseVisualStyleBackColor = true;
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_encrypt.Enabled = false;
            this.btn_encrypt.Location = new System.Drawing.Point(16, 301);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(239, 24);
            this.btn_encrypt.TabIndex = 7;
            this.btn_encrypt.Text = "Encrypt";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // affine_lbl_formula
            // 
            this.affine_lbl_formula.AutoSize = true;
            this.affine_lbl_formula.Location = new System.Drawing.Point(6, 3);
            this.affine_lbl_formula.Name = "affine_lbl_formula";
            this.affine_lbl_formula.Size = new System.Drawing.Size(47, 13);
            this.affine_lbl_formula.TabIndex = 0;
            this.affine_lbl_formula.Text = "Formula:";
            // 
            // affine_lbl_shiftby
            // 
            this.affine_lbl_shiftby.AutoSize = true;
            this.affine_lbl_shiftby.Location = new System.Drawing.Point(6, 16);
            this.affine_lbl_shiftby.Name = "affine_lbl_shiftby";
            this.affine_lbl_shiftby.Size = new System.Drawing.Size(49, 13);
            this.affine_lbl_shiftby.TabIndex = 1;
            this.affine_lbl_shiftby.Text = "Shift By: ";
            // 
            // affine_inp_m
            // 
            this.affine_inp_m.Location = new System.Drawing.Point(59, 14);
            this.affine_inp_m.Name = "affine_inp_m";
            this.affine_inp_m.Size = new System.Drawing.Size(45, 20);
            this.affine_inp_m.TabIndex = 2;
            // 
            // affine_label_x
            // 
            this.affine_label_x.AutoSize = true;
            this.affine_label_x.Location = new System.Drawing.Point(110, 16);
            this.affine_label_x.Name = "affine_label_x";
            this.affine_label_x.Size = new System.Drawing.Size(24, 13);
            this.affine_label_x.TabIndex = 3;
            this.affine_label_x.Text = "x + ";
            // 
            // affine_inp_c
            // 
            this.affine_inp_c.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.affine_inp_c.Location = new System.Drawing.Point(130, 14);
            this.affine_inp_c.Name = "affine_inp_c";
            this.affine_inp_c.Size = new System.Drawing.Size(95, 20);
            this.affine_inp_c.TabIndex = 4;
            // 
            // txtbox_input
            // 
            this.txtbox_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_input.Location = new System.Drawing.Point(13, 28);
            this.txtbox_input.Name = "txtbox_input";
            this.txtbox_input.Size = new System.Drawing.Size(238, 135);
            this.txtbox_input.TabIndex = 8;
            this.txtbox_input.Text = "";
            // 
            // txtbox_output
            // 
            this.txtbox_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_output.Location = new System.Drawing.Point(12, 360);
            this.txtbox_output.Name = "txtbox_output";
            this.txtbox_output.Size = new System.Drawing.Size(239, 128);
            this.txtbox_output.TabIndex = 9;
            this.txtbox_output.Text = "";
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 535);
            this.Controls.Add(this.txtbox_output);
            this.Controls.Add(this.txtbox_input);
            this.Controls.Add(this.btn_encrypt);
            this.Controls.Add(this.tabSystem);
            this.Controls.Add(this.btn_savetofile);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(240, 450);
            this.Name = "form_main";
            this.Text = "Cipher";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.caesar_layout_groupbox.ResumeLayout(false);
            this.caesar_layout_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inp_shiftvalue)).EndInit();
            this.tabSystem.ResumeLayout(false);
            this.tab_caesar.ResumeLayout(false);
            this.tab_affine.ResumeLayout(false);
            this.tab_affine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.affine_inp_m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.affine_inp_c)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.OpenFileDialog dialog_openfile;
        private System.Windows.Forms.Button btn_savetofile;
        private System.Windows.Forms.SaveFileDialog dialog_savefile;
        private System.Windows.Forms.GroupBox caesar_layout_groupbox;
        private System.Windows.Forms.NumericUpDown inp_shiftvalue;
        private System.Windows.Forms.RadioButton caesar_radiobutton_generatesinglevalue;
        private System.Windows.Forms.RadioButton caesar_radiobutton_generateall;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_readfromfile;
        private System.Windows.Forms.TabControl tabSystem;
        private System.Windows.Forms.TabPage tab_caesar;
        private System.Windows.Forms.TabPage tab_affine;
        private System.Windows.Forms.RadioButton caesar_radiobutton_predict;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.NumericUpDown affine_inp_c;
        private System.Windows.Forms.Label affine_label_x;
        private System.Windows.Forms.NumericUpDown affine_inp_m;
        private System.Windows.Forms.Label affine_lbl_shiftby;
        private System.Windows.Forms.Label affine_lbl_formula;
        private System.Windows.Forms.RichTextBox txtbox_input;
        private System.Windows.Forms.RichTextBox txtbox_output;
    }
}

