namespace FeedbackFormExample
{
    partial class Form1
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
            this.lblFeedbackForm = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtbxComments = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxEmailAddress = new System.Windows.Forms.TextBox();
            this.lblThingsYouLiked = new System.Windows.Forms.Label();
            this.chkbxSiteDesign = new System.Windows.Forms.CheckBox();
            this.chkbxLinks = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblFeedbackForm
            // 
            this.lblFeedbackForm.AutoSize = true;
            this.lblFeedbackForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblFeedbackForm.Location = new System.Drawing.Point(13, 13);
            this.lblFeedbackForm.Name = "lblFeedbackForm";
            this.lblFeedbackForm.Size = new System.Drawing.Size(203, 29);
            this.lblFeedbackForm.TabIndex = 0;
            this.lblFeedbackForm.Text = "Feedback Form";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Location = new System.Drawing.Point(18, 64);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(240, 13);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Please fill out this form to help us improve our site.";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(18, 86);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(59, 13);
            this.lblComments.TabIndex = 2;
            this.lblComments.Text = "Comments:";
            // 
            // txtbxComments
            // 
            this.txtbxComments.AcceptsTab = true;
            this.txtbxComments.Location = new System.Drawing.Point(21, 103);
            this.txtbxComments.Multiline = true;
            this.txtbxComments.Name = "txtbxComments";
            this.txtbxComments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbxComments.Size = new System.Drawing.Size(237, 82);
            this.txtbxComments.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "E-mail Address:";
            // 
            // txtbxEmailAddress
            // 
            this.txtbxEmailAddress.Location = new System.Drawing.Point(97, 192);
            this.txtbxEmailAddress.Name = "txtbxEmailAddress";
            this.txtbxEmailAddress.Size = new System.Drawing.Size(161, 20);
            this.txtbxEmailAddress.TabIndex = 5;
            // 
            // lblThingsYouLiked
            // 
            this.lblThingsYouLiked.AutoSize = true;
            this.lblThingsYouLiked.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThingsYouLiked.Location = new System.Drawing.Point(24, 227);
            this.lblThingsYouLiked.Name = "lblThingsYouLiked";
            this.lblThingsYouLiked.Size = new System.Drawing.Size(104, 13);
            this.lblThingsYouLiked.TabIndex = 6;
            this.lblThingsYouLiked.Text = "Things you liked:";
            // 
            // chkbxSiteDesign
            // 
            this.chkbxSiteDesign.AutoSize = true;
            this.chkbxSiteDesign.Location = new System.Drawing.Point(27, 244);
            this.chkbxSiteDesign.Name = "chkbxSiteDesign";
            this.chkbxSiteDesign.Size = new System.Drawing.Size(78, 17);
            this.chkbxSiteDesign.TabIndex = 7;
            this.chkbxSiteDesign.Text = "Site design";
            this.chkbxSiteDesign.UseVisualStyleBackColor = true;
            // 
            // chkbxLinks
            // 
            this.chkbxLinks.AutoSize = true;
            this.chkbxLinks.Location = new System.Drawing.Point(112, 244);
            this.chkbxLinks.Name = "chkbxLinks";
            this.chkbxLinks.Size = new System.Drawing.Size(51, 17);
            this.chkbxLinks.TabIndex = 8;
            this.chkbxLinks.Text = "Links";
            this.chkbxLinks.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(170, 244);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 371);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.chkbxLinks);
            this.Controls.Add(this.chkbxSiteDesign);
            this.Controls.Add(this.lblThingsYouLiked);
            this.Controls.Add(this.txtbxEmailAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxComments);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblFeedbackForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFeedbackForm;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtbxComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxEmailAddress;
        private System.Windows.Forms.Label lblThingsYouLiked;
        private System.Windows.Forms.CheckBox chkbxSiteDesign;
        private System.Windows.Forms.CheckBox chkbxLinks;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

