namespace MES.UI.Dialogs
{
    partial class MessageDialog
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
            checkButton1 = new DevExpress.XtraEditors.CheckButton();
            SuspendLayout();
            // 
            // checkButton1
            // 
            checkButton1.Location = new System.Drawing.Point(120, 66);
            checkButton1.Name = "checkButton1";
            checkButton1.Size = new System.Drawing.Size(131, 21);
            checkButton1.TabIndex = 0;
            checkButton1.Text = "checkButton1";            
            // 
            // MessageDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(367, 92);
            Controls.Add(checkButton1);
            Name = "MessageDialog";
            Text = "MessageDialog";
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.CheckButton checkButton1;
    }
}