

namespace HdrSet
{

    partial class frmMain
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>


        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIsHdrSet = new System.Windows.Forms.Label();
            this.lblIsHdrSetValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIsHdrSet
            // 
            this.lblIsHdrSet.AutoSize = true;
            this.lblIsHdrSet.Location = new System.Drawing.Point(107, 116);
            this.lblIsHdrSet.Name = "lblIsHdrSet";
            this.lblIsHdrSet.Size = new System.Drawing.Size(138, 29);
            this.lblIsHdrSet.TabIndex = 0;
            this.lblIsHdrSet.Text = "HDR is set?";
            // 
            // lblIsHdrSetValue
            // 
            this.lblIsHdrSetValue.AutoSize = true;
            this.lblIsHdrSetValue.Location = new System.Drawing.Point(281, 116);
            this.lblIsHdrSetValue.Name = "lblIsHdrSetValue";
            this.lblIsHdrSetValue.Size = new System.Drawing.Size(40, 29);
            this.lblIsHdrSetValue.TabIndex = 1;
            this.lblIsHdrSetValue.Text = "no";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIsHdrSetValue);
            this.Controls.Add(this.lblIsHdrSet);
            this.Name = "frmMain";
            this.Text = "WinHDRSet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIsHdrSet;
        private System.Windows.Forms.Label lblIsHdrSetValue;
    }
}

