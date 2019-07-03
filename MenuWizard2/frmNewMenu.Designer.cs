namespace MenuWizard2
{
	partial class frmNewMenu
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
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.lbTitle = new System.Windows.Forms.Label();
			this.lbWeight = new System.Windows.Forms.Label();
			this.nudWeight = new System.Windows.Forms.NumericUpDown();
			this.btnOK = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
			this.SuspendLayout();
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(75, 16);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(323, 27);
			this.txtTitle.TabIndex = 0;
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.Location = new System.Drawing.Point(12, 19);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(42, 20);
			this.lbTitle.TabIndex = 1;
			this.lbTitle.Text = "종목:";
			// 
			// lbWeight
			// 
			this.lbWeight.AutoSize = true;
			this.lbWeight.Location = new System.Drawing.Point(12, 50);
			this.lbWeight.Name = "lbWeight";
			this.lbWeight.Size = new System.Drawing.Size(57, 20);
			this.lbWeight.TabIndex = 2;
			this.lbWeight.Text = "가중치:";
			// 
			// nudWeight
			// 
			this.nudWeight.Location = new System.Drawing.Point(75, 50);
			this.nudWeight.Name = "nudWeight";
			this.nudWeight.Size = new System.Drawing.Size(323, 27);
			this.nudWeight.TabIndex = 3;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(253, 83);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(145, 30);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "추가";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
			// 
			// frmNewMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(406, 120);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.nudWeight);
			this.Controls.Add(this.lbWeight);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.txtTitle);
			this.Font = new System.Drawing.Font("맑은 고딕", 11F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmNewMenu";
			this.Text = "메뉴 추가";
			((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.Label lbWeight;
		private System.Windows.Forms.NumericUpDown nudWeight;
		private System.Windows.Forms.Button btnOK;
	}
}