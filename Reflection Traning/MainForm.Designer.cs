namespace ReflectionTraning
{
    partial class MainForm
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
            this.btnFirstSimpleForm = new System.Windows.Forms.Button();
            this.btnFirstComplexForm = new System.Windows.Forms.Button();
            this.btnSecondComplexForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFirstSimpleForm
            // 
            this.btnFirstSimpleForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirstSimpleForm.Location = new System.Drawing.Point(12, 12);
            this.btnFirstSimpleForm.Name = "btnFirstSimpleForm";
            this.btnFirstSimpleForm.Size = new System.Drawing.Size(260, 23);
            this.btnFirstSimpleForm.TabIndex = 0;
            this.btnFirstSimpleForm.Text = "First Simple Form";
            this.btnFirstSimpleForm.UseVisualStyleBackColor = true;
            this.btnFirstSimpleForm.Click += new System.EventHandler(this.btnFirstSimpleForm_Click);
            // 
            // btnFirstComplexForm
            // 
            this.btnFirstComplexForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirstComplexForm.Location = new System.Drawing.Point(12, 41);
            this.btnFirstComplexForm.Name = "btnFirstComplexForm";
            this.btnFirstComplexForm.Size = new System.Drawing.Size(260, 23);
            this.btnFirstComplexForm.TabIndex = 1;
            this.btnFirstComplexForm.Text = "First Complex Form";
            this.btnFirstComplexForm.UseVisualStyleBackColor = true;
            this.btnFirstComplexForm.Click += new System.EventHandler(this.btnFirstComplexForm_Click);
            // 
            // btnSecondComplexForm
            // 
            this.btnSecondComplexForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSecondComplexForm.Location = new System.Drawing.Point(12, 70);
            this.btnSecondComplexForm.Name = "btnSecondComplexForm";
            this.btnSecondComplexForm.Size = new System.Drawing.Size(260, 23);
            this.btnSecondComplexForm.TabIndex = 2;
            this.btnSecondComplexForm.Text = "Second Complex Form";
            this.btnSecondComplexForm.UseVisualStyleBackColor = true;
            this.btnSecondComplexForm.Click += new System.EventHandler(this.btnSecondComplexForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 99);
            this.Controls.Add(this.btnSecondComplexForm);
            this.Controls.Add(this.btnFirstComplexForm);
            this.Controls.Add(this.btnFirstSimpleForm);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFirstSimpleForm;
        private System.Windows.Forms.Button btnFirstComplexForm;
        private System.Windows.Forms.Button btnSecondComplexForm;
    }
}