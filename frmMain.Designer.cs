namespace ScreensTest
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.edtMain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblX = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblY = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrMouse = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblScreenNum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tmrScreenGet = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // edtMain
            // 
            this.edtMain.Location = new System.Drawing.Point(2, 2);
            this.edtMain.Multiline = true;
            this.edtMain.Name = "edtMain";
            this.edtMain.Size = new System.Drawing.Size(350, 163);
            this.edtMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "X:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.lblX);
            this.panel1.Location = new System.Drawing.Point(9, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 100);
            this.panel1.TabIndex = 2;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblX.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblX.Location = new System.Drawing.Point(34, 34);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(32, 32);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "0:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.lblY);
            this.panel2.Location = new System.Drawing.Point(245, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 100);
            this.panel2.TabIndex = 4;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblY.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblY.Location = new System.Drawing.Point(34, 34);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(32, 32);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "0:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(279, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y:";
            // 
            // tmrMouse
            // 
            this.tmrMouse.Enabled = true;
            this.tmrMouse.Interval = 50;
            this.tmrMouse.Tick += new System.EventHandler(this.tmrMouse_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.lblScreenNum);
            this.panel3.Location = new System.Drawing.Point(127, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 100);
            this.panel3.TabIndex = 6;
            // 
            // lblScreenNum
            // 
            this.lblScreenNum.AutoSize = true;
            this.lblScreenNum.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScreenNum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblScreenNum.Location = new System.Drawing.Point(34, 34);
            this.lblScreenNum.Name = "lblScreenNum";
            this.lblScreenNum.Size = new System.Drawing.Size(32, 32);
            this.lblScreenNum.TabIndex = 0;
            this.lblScreenNum.Text = "0:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(140, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Screen";
            // 
            // tmrScreenGet
            // 
            this.tmrScreenGet.Enabled = true;
            this.tmrScreenGet.Tick += new System.EventHandler(this.tmrScreenGet_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(354, 315);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Screen Info";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox edtMain;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label lblX;
        private Label lblY;
        private System.Windows.Forms.Timer tmrMouse;
        private Panel panel3;
        private Label lblScreenNum;
        private Label label4;
        private System.Windows.Forms.Timer tmrScreenGet;
    }
}