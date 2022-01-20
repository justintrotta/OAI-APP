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
            this.btn_undo = new System.Windows.Forms.Button();
            this.btn_regenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_output
            // 
            this.rtb_output.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rtb_output.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtb_output.Location = new System.Drawing.Point(459, 0);
            this.rtb_output.Name = "rtb_output";
            this.rtb_output.Size = new System.Drawing.Size(1043, 599);
            this.rtb_output.TabIndex = 0;
            this.rtb_output.Text = "";
            this.rtb_output.WordWrap = false;
            // 
            // btn_generate
            // 
            this.btn_generate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_generate.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_generate.Location = new System.Drawing.Point(0, 0);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(459, 111);
            this.btn_generate.TabIndex = 1;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_undo
            // 
            this.btn_undo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_undo.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_undo.Location = new System.Drawing.Point(0, 111);
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.Size = new System.Drawing.Size(459, 121);
            this.btn_undo.TabIndex = 2;
            this.btn_undo.Text = "Undo";
            this.btn_undo.UseVisualStyleBackColor = true;
            this.btn_undo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_regenerate
            // 
            this.btn_regenerate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_regenerate.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_regenerate.Location = new System.Drawing.Point(0, 232);
            this.btn_regenerate.Name = "btn_regenerate";
            this.btn_regenerate.Size = new System.Drawing.Size(459, 114);
            this.btn_regenerate.TabIndex = 3;
            this.btn_regenerate.Text = "Regenerate";
            this.btn_regenerate.UseVisualStyleBackColor = true;
            this.btn_regenerate.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OAI_APP.Properties.Resources.unnamed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1502, 599);
            this.Controls.Add(this.btn_regenerate);
            this.Controls.Add(this.btn_undo);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.rtb_output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtb_output;
        private Button btn_generate;
        private Button btn_undo;
        private Button btn_regenerate;
    }
}