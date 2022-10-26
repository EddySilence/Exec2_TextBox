namespace Q2
{
	partial class resultButton
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.resultButtonQ2 = new System.Windows.Forms.Button();
			this.resultLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(159, 100);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "輸入日期是否不大於今天";
			// 
			// inputTextBox
			// 
			this.inputTextBox.Location = new System.Drawing.Point(313, 97);
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Size = new System.Drawing.Size(100, 22);
			this.inputTextBox.TabIndex = 1;
			// 
			// resultButtonQ2
			// 
			this.resultButtonQ2.Location = new System.Drawing.Point(446, 96);
			this.resultButtonQ2.Name = "resultButtonQ2";
			this.resultButtonQ2.Size = new System.Drawing.Size(75, 23);
			this.resultButtonQ2.TabIndex = 2;
			this.resultButtonQ2.Text = "送出";
			this.resultButtonQ2.UseVisualStyleBackColor = true;
			this.resultButtonQ2.Click += new System.EventHandler(this.resultButtonQ2_Click);
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Location = new System.Drawing.Point(313, 166);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(29, 12);
			this.resultLabel.TabIndex = 3;
			this.resultLabel.Text = "結果";
			// 
			// resultButton
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.resultButtonQ2);
			this.Controls.Add(this.inputTextBox);
			this.Controls.Add(this.label1);
			this.Name = "resultButton";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox inputTextBox;
		private System.Windows.Forms.Button resultButtonQ2;
		private System.Windows.Forms.Label resultLabel;
	}
}

