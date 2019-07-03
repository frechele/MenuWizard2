namespace MenuWizard2
{
	partial class frmMain
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.lstView = new System.Windows.Forms.ListView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnSum = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstView
			// 
			this.lstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.lstView.HideSelection = false;
			this.lstView.Location = new System.Drawing.Point(12, 12);
			this.lstView.Name = "lstView";
			this.lstView.Size = new System.Drawing.Size(910, 396);
			this.lstView.TabIndex = 0;
			this.lstView.UseCompatibleStateImageBehavior = false;
			this.lstView.View = System.Windows.Forms.View.Details;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(744, 414);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(178, 38);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "추가";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "종목";
			this.columnHeader1.Width = 670;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "가중치";
			this.columnHeader2.Width = 218;
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(744, 458);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(178, 38);
			this.btnRemove.TabIndex = 2;
			this.btnRemove.Text = "제거";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
			// 
			// btnSum
			// 
			this.btnSum.Location = new System.Drawing.Point(744, 502);
			this.btnSum.Name = "btnSum";
			this.btnSum.Size = new System.Drawing.Size(178, 38);
			this.btnSum.TabIndex = 3;
			this.btnSum.Text = "추첨";
			this.btnSum.UseVisualStyleBackColor = true;
			this.btnSum.Click += new System.EventHandler(this.BtnSum_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(934, 551);
			this.Controls.Add(this.btnSum);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lstView);
			this.Font = new System.Drawing.Font("맑은 고딕", 11F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMain";
			this.Text = "MenuWizard2";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lstView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnSum;
	}
}

