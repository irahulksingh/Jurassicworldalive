namespace iFaceRecognition
{
    partial class frmiFace
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmiFace));
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpSave = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveFaces = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpFound = new System.Windows.Forms.GroupBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lblFaceNames = new System.Windows.Forms.Label();
            this.lblFacesFound = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VideoGrabber = new Emgu.CV.UI.ImageBox();
            this.lblFR = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.grpFound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoGrabber)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(13, 131);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(112, 21);
            this.txtName.TabIndex = 7;
            // 
            // grpSave
            // 
            this.grpSave.Controls.Add(this.label1);
            this.grpSave.Controls.Add(this.btnSaveFaces);
            this.grpSave.Controls.Add(this.txtName);
            this.grpSave.Controls.Add(this.imageBox1);
            this.grpSave.Controls.Add(this.panel2);
            this.grpSave.Font = new System.Drawing.Font("Segoe UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpSave.Location = new System.Drawing.Point(340, 109);
            this.grpSave.Name = "grpSave";
            this.grpSave.Size = new System.Drawing.Size(137, 202);
            this.grpSave.TabIndex = 11;
            this.grpSave.TabStop = false;
            this.grpSave.Text = "Detect - Save Face";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(10, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name: ";
            // 
            // btnSaveFaces
            // 
            this.btnSaveFaces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(134)))), ((int)(((byte)(133)))));
            this.btnSaveFaces.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFaces.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveFaces.Location = new System.Drawing.Point(13, 157);
            this.btnSaveFaces.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveFaces.Name = "btnSaveFaces";
            this.btnSaveFaces.Size = new System.Drawing.Size(111, 39);
            this.btnSaveFaces.TabIndex = 9;
            this.btnSaveFaces.Text = "Save Face";
            this.btnSaveFaces.UseVisualStyleBackColor = false;
            this.btnSaveFaces.Click += new System.EventHandler(this.btnSaveFaces_Click_1);
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageBox1.InitialImage")));
            this.imageBox1.Location = new System.Drawing.Point(31, 21);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(76, 82);
            this.imageBox1.TabIndex = 5;
            this.imageBox1.TabStop = false;
            this.imageBox1.WaitOnLoad = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(28, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 86);
            this.panel2.TabIndex = 10;
            // 
            // grpFound
            // 
            this.grpFound.Controls.Add(this.lbl);
            this.grpFound.Controls.Add(this.lblFaceNames);
            this.grpFound.Controls.Add(this.lblFacesFound);
            this.grpFound.Controls.Add(this.label2);
            this.grpFound.Font = new System.Drawing.Font("Segoe UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFound.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpFound.Location = new System.Drawing.Point(51, 316);
            this.grpFound.Name = "grpFound";
            this.grpFound.Size = new System.Drawing.Size(430, 68);
            this.grpFound.TabIndex = 12;
            this.grpFound.TabStop = false;
            this.grpFound.Text = "Faces Detected:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl.Location = new System.Drawing.Point(6, 25);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(96, 21);
            this.lbl.TabIndex = 17;
            this.lbl.Text = "Faces Found:";
            // 
            // lblFaceNames
            // 
            this.lblFaceNames.AutoSize = true;
            this.lblFaceNames.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaceNames.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFaceNames.Location = new System.Drawing.Point(100, 25);
            this.lblFaceNames.Name = "lblFaceNames";
            this.lblFaceNames.Size = new System.Drawing.Size(45, 21);
            this.lblFaceNames.TabIndex = 16;
            this.lblFaceNames.Text = "none";
            // 
            // lblFacesFound
            // 
            this.lblFacesFound.AutoSize = true;
            this.lblFacesFound.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacesFound.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblFacesFound.Location = new System.Drawing.Point(398, 28);
            this.lblFacesFound.Name = "lblFacesFound";
            this.lblFacesFound.Size = new System.Drawing.Size(17, 20);
            this.lblFacesFound.TabIndex = 15;
            this.lblFacesFound.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(262, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "No. Of Faces Found:";
            // 
            // VideoGrabber
            // 
            this.VideoGrabber.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.RightClickMenu;
            this.VideoGrabber.Location = new System.Drawing.Point(22, 3);
            this.VideoGrabber.Name = "VideoGrabber";
            this.VideoGrabber.Size = new System.Drawing.Size(239, 192);
            this.VideoGrabber.TabIndex = 10;
            this.VideoGrabber.TabStop = false;
            this.VideoGrabber.Click += new System.EventHandler(this.VideoGrabber_Click);
            // 
            // lblFR
            // 
            this.lblFR.AutoSize = true;
            this.lblFR.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFR.Location = new System.Drawing.Point(9, 79);
            this.lblFR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFR.Name = "lblFR";
            this.lblFR.Size = new System.Drawing.Size(178, 32);
            this.lblFR.TabIndex = 13;
            this.lblFR.Text = "Face Recognizer";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(134)))), ((int)(((byte)(133)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(432, 390);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 25);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(495, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openImageToolStripMenuItem.Text = "Open Image";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.VideoGrabber);
            this.panel1.Location = new System.Drawing.Point(51, 115);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 198);
            this.panel1.TabIndex = 17;
            // 
            // frmiFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(495, 432);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblFR);
            this.Controls.Add(this.grpSave);
            this.Controls.Add(this.grpFound);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmiFace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Face Recognizer v 1.1";
            this.Load += new System.EventHandler(this.iFace_Load);
            this.grpSave.ResumeLayout(false);
            this.grpSave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.grpFound.ResumeLayout(false);
            this.grpFound.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoGrabber)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpSave;
        private System.Windows.Forms.Label label1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.GroupBox grpFound;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblFaceNames;
        private System.Windows.Forms.Label lblFacesFound;
        private System.Windows.Forms.Label label2;
        private Emgu.CV.UI.ImageBox VideoGrabber;
        private System.Windows.Forms.Button btnSaveFaces;
        private System.Windows.Forms.Label lblFR;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

