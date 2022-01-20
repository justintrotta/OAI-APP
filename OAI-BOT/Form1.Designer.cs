namespace OAI_APP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtb_output = new System.Windows.Forms.RichTextBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_output
            // 
            this.rtb_output.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rtb_output.Location = new System.Drawing.Point(461, 12);
            this.rtb_output.Name = "rtb_output";
            this.rtb_output.Size = new System.Drawing.Size(1029, 575);
            this.rtb_output.TabIndex = 0;
            this.rtb_output.Text = "";
            this.rtb_output.WordWrap = false;
            // 
            // btn_generate
            // 
            this.btn_generate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_generate.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_generate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_generate.Location = new System.Drawing.Point(12, 117);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(443, 111);
            this.btn_generate.TabIndex = 1;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = false;
            this.btn_generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OAI_APP.Properties.Resources.unnamed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1502, 599);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.rtb_output);
            this.KeyPreview = true;
            this.Name = "OpenAI";
            this.Text = "OpenAI App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtb_output;
        private Button btn_generate;
    }
}