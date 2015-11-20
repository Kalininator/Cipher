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
            this.txtbox_input = new System.Windows.Forms.TextBox();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.txtbox_output = new System.Windows.Forms.TextBox();
            this.dialog_openfile = new System.Windows.Forms.OpenFileDialog();
            this.btn_savetofile = new System.Windows.Forms.Button();
            this.dialog_savefile = new System.Windows.Forms.SaveFileDialog();
            this.layout_groupbox = new System.Windows.Forms.GroupBox();
            this.radiobutton_generateall = new System.Windows.Forms.RadioButton();
            this.radiobutton_generatesinglevalue = new System.Windows.Forms.RadioButton();
            this.inp_shiftvalue = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.layout_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inp_shiftvalue)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(313, 24);
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
            // txtbox_input
            // 
            this.txtbox_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_input.Location = new System.Drawing.Point(13, 28);
            this.txtbox_input.MinimumSize = new System.Drawing.Size(4, 40);
            this.txtbox_input.Multiline = true;
            this.txtbox_input.Name = "txtbox_input";
            this.txtbox_input.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbox_input.Size = new System.Drawing.Size(288, 59);
            this.txtbox_input.TabIndex = 1;
            this.txtbox_input.WordWrap = false;
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_decrypt.Location = new System.Drawing.Point(13, 174);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(288, 23);
            this.btn_decrypt.TabIndex = 2;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // txtbox_output
            // 
            this.txtbox_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_output.Location = new System.Drawing.Point(12, 203);
            this.txtbox_output.Multiline = true;
            this.txtbox_output.Name = "txtbox_output";
            this.txtbox_output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbox_output.Size = new System.Drawing.Size(289, 152);
            this.txtbox_output.TabIndex = 3;
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
            this.btn_savetofile.Location = new System.Drawing.Point(12, 361);
            this.btn_savetofile.Name = "btn_savetofile";
            this.btn_savetofile.Size = new System.Drawing.Size(289, 23);
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
            // layout_groupbox
            // 
            this.layout_groupbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layout_groupbox.Controls.Add(this.inp_shiftvalue);
            this.layout_groupbox.Controls.Add(this.radiobutton_generatesinglevalue);
            this.layout_groupbox.Controls.Add(this.radiobutton_generateall);
            this.layout_groupbox.Location = new System.Drawing.Point(13, 93);
            this.layout_groupbox.Name = "layout_groupbox";
            this.layout_groupbox.Size = new System.Drawing.Size(287, 75);
            this.layout_groupbox.TabIndex = 5;
            this.layout_groupbox.TabStop = false;
            this.layout_groupbox.Text = "Options";
            // 
            // radiobutton_generateall
            // 
            this.radiobutton_generateall.AutoSize = true;
            this.radiobutton_generateall.Checked = true;
            this.radiobutton_generateall.Location = new System.Drawing.Point(7, 20);
            this.radiobutton_generateall.Name = "radiobutton_generateall";
            this.radiobutton_generateall.Size = new System.Drawing.Size(165, 17);
            this.radiobutton_generateall.TabIndex = 0;
            this.radiobutton_generateall.TabStop = true;
            this.radiobutton_generateall.Text = "Generate All Possible Outputs";
            this.radiobutton_generateall.UseVisualStyleBackColor = true;
            // 
            // radiobutton_generatesinglevalue
            // 
            this.radiobutton_generatesinglevalue.AutoSize = true;
            this.radiobutton_generatesinglevalue.Location = new System.Drawing.Point(7, 44);
            this.radiobutton_generatesinglevalue.Name = "radiobutton_generatesinglevalue";
            this.radiobutton_generatesinglevalue.Size = new System.Drawing.Size(139, 17);
            this.radiobutton_generatesinglevalue.TabIndex = 1;
            this.radiobutton_generatesinglevalue.Text = "Decypher with set value";
            this.radiobutton_generatesinglevalue.UseVisualStyleBackColor = true;
            this.radiobutton_generatesinglevalue.CheckedChanged += new System.EventHandler(this.radiobutton_generatesinglevalue_CheckedChanged);
            // 
            // inp_shiftvalue
            // 
            this.inp_shiftvalue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inp_shiftvalue.Enabled = false;
            this.inp_shiftvalue.Location = new System.Drawing.Point(153, 44);
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
            this.inp_shiftvalue.Size = new System.Drawing.Size(128, 20);
            this.inp_shiftvalue.TabIndex = 2;
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 396);
            this.Controls.Add(this.layout_groupbox);
            this.Controls.Add(this.btn_savetofile);
            this.Controls.Add(this.txtbox_output);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.txtbox_input);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(240, 380);
            this.Name = "form_main";
            this.Text = "Cipher";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.layout_groupbox.ResumeLayout(false);
            this.layout_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inp_shiftvalue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.TextBox txtbox_input;
        private System.Windows.Forms.ToolStripMenuItem btn_readfromfile;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.TextBox txtbox_output;
        private System.Windows.Forms.OpenFileDialog dialog_openfile;
        private System.Windows.Forms.Button btn_savetofile;
        private System.Windows.Forms.SaveFileDialog dialog_savefile;
        private System.Windows.Forms.GroupBox layout_groupbox;
        private System.Windows.Forms.NumericUpDown inp_shiftvalue;
        private System.Windows.Forms.RadioButton radiobutton_generatesinglevalue;
        private System.Windows.Forms.RadioButton radiobutton_generateall;
    }
}

