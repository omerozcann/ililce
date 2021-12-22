namespace ililce
{
    partial class ililceFrm
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
            this.illercmb = new System.Windows.Forms.ComboBox();
            this.ilcelercmb = new System.Windows.Forms.ComboBox();
            this.ilyuklebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // illercmb
            // 
            this.illercmb.FormattingEnabled = true;
            this.illercmb.Location = new System.Drawing.Point(70, 81);
            this.illercmb.Name = "illercmb";
            this.illercmb.Size = new System.Drawing.Size(121, 21);
            this.illercmb.TabIndex = 0;
            this.illercmb.SelectedIndexChanged += new System.EventHandler(this.illercmb_SelectedIndexChanged);
            // 
            // ilcelercmb
            // 
            this.ilcelercmb.FormattingEnabled = true;
            this.ilcelercmb.Location = new System.Drawing.Point(70, 128);
            this.ilcelercmb.Name = "ilcelercmb";
            this.ilcelercmb.Size = new System.Drawing.Size(121, 21);
            this.ilcelercmb.TabIndex = 1;
            // 
            // ilyuklebtn
            // 
            this.ilyuklebtn.Location = new System.Drawing.Point(89, 31);
            this.ilyuklebtn.Name = "ilyuklebtn";
            this.ilyuklebtn.Size = new System.Drawing.Size(75, 23);
            this.ilyuklebtn.TabIndex = 2;
            this.ilyuklebtn.Text = "İlleri Yükle";
            this.ilyuklebtn.UseVisualStyleBackColor = true;
            this.ilyuklebtn.Click += new System.EventHandler(this.ilyuklebtn_Click);
            // 
            // ililceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ilyuklebtn);
            this.Controls.Add(this.ilcelercmb);
            this.Controls.Add(this.illercmb);
            this.Name = "ililceFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İl İlçe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox illercmb;
        private System.Windows.Forms.ComboBox ilcelercmb;
        private System.Windows.Forms.Button ilyuklebtn;
    }
}

