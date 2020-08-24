namespace Face_Detection_App
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
			this.label1 = new System.Windows.Forms.Label();
			this.cbxDevice = new System.Windows.Forms.ComboBox();
			this.btnDetect = new System.Windows.Forms.Button();
			this.picBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(45, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Thiết bị";
			// 
			// cbxDevice
			// 
			this.cbxDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxDevice.FormattingEnabled = true;
			this.cbxDevice.Location = new System.Drawing.Point(139, 22);
			this.cbxDevice.Name = "cbxDevice";
			this.cbxDevice.Size = new System.Drawing.Size(299, 24);
			this.cbxDevice.TabIndex = 1;
			// 
			// btnDetect
			// 
			this.btnDetect.Location = new System.Drawing.Point(664, 66);
			this.btnDetect.Name = "btnDetect";
			this.btnDetect.Size = new System.Drawing.Size(124, 55);
			this.btnDetect.TabIndex = 2;
			this.btnDetect.Text = "Detect";
			this.btnDetect.UseVisualStyleBackColor = true;
			this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
			// 
			// picBox
			// 
			this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picBox.Location = new System.Drawing.Point(44, 66);
			this.picBox.Name = "picBox";
			this.picBox.Size = new System.Drawing.Size(614, 419);
			this.picBox.TabIndex = 3;
			this.picBox.TabStop = false;
			this.picBox.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 540);
			this.Controls.Add(this.picBox);
			this.Controls.Add(this.btnDetect);
			this.Controls.Add(this.cbxDevice);
			this.Controls.Add(this.label1);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Face Detection";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbxDevice;
		private System.Windows.Forms.Button btnDetect;
		private System.Windows.Forms.PictureBox picBox;
	}
}

