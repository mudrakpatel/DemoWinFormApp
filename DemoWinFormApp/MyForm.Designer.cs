namespace DemoWinFormApp
{
    partial class MyForm
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
            this.cbxCities = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbxCities
            // 
            this.cbxCities.FormattingEnabled = true;
            this.cbxCities.Items.AddRange(new object[] {
            "Surat",
            "NewYork",
            "Toronto"});
            this.cbxCities.Location = new System.Drawing.Point(13, 13);
            this.cbxCities.Name = "cbxCities";
            this.cbxCities.Size = new System.Drawing.Size(121, 21);
            this.cbxCities.TabIndex = 0;
            this.cbxCities.SelectedIndexChanged += new System.EventHandler(this.cbxCities_SelectedIndexChanged);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 262);
            this.Controls.Add(this.cbxCities);
            this.Name = "MyForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCities;
    }
}

