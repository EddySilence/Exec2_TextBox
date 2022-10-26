namespace Q1
{
	partial class Form1
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
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.resultButton = new System.Windows.Forms.Button();
			this.resultLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// inputTextBox
			// 
			this.inputTextBox.Location = new System.Drawing.Point(206, 65);
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Size = new System.Drawing.Size(100, 22);
			this.inputTextBox.TabIndex = 0;
			// 
			// resultButton
			// 
			this.resultButton.Location = new System.Drawing.Point(367, 65);
			this.resultButton.Name = "resultButton";
			this.resultButton.Size = new System.Drawing.Size(75, 23);
			this.resultButton.TabIndex = 1;
			this.resultButton.Text = "送出";
			this.resultButton.UseVisualStyleBackColor = true;
			this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Location = new System.Drawing.Point(215, 120);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(41, 12);
			this.resultLabel.TabIndex = 2;
			this.resultLabel.Text = "結果：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(64, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "輸入數值是否在[1,99]";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 269);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.resultButton);
			this.Controls.Add(this.inputTextBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox inputTextBox;
		private System.Windows.Forms.Button resultButton;
		private System.Windows.Forms.Label resultLabel;
		private System.Windows.Forms.Label label1;
	}
}

