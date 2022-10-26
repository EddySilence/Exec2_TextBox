namespace Q3
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
			this.label1 = new System.Windows.Forms.Label();
			this.resultButtonQ3 = new System.Windows.Forms.Button();
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.resultLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(119, 103);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(179, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "經由輸入生日判斷是否已滿 13 歲";
			// 
			// resultButtonQ3
			// 
			this.resultButtonQ3.Location = new System.Drawing.Point(449, 100);
			this.resultButtonQ3.Name = "resultButtonQ3";
			this.resultButtonQ3.Size = new System.Drawing.Size(75, 23);
			this.resultButtonQ3.TabIndex = 1;
			this.resultButtonQ3.Text = "送出";
			this.resultButtonQ3.UseVisualStyleBackColor = true;
			this.resultButtonQ3.Click += new System.EventHandler(this.resultButtonQ3_Click);
			// 
			// inputTextBox
			// 
			this.inputTextBox.Location = new System.Drawing.Point(321, 100);
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Size = new System.Drawing.Size(100, 22);
			this.inputTextBox.TabIndex = 2;
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Location = new System.Drawing.Point(331, 147);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(29, 12);
			this.resultLabel.TabIndex = 3;
			this.resultLabel.Text = "結果";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.inputTextBox);
			this.Controls.Add(this.resultButtonQ3);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button resultButtonQ3;
		private System.Windows.Forms.TextBox inputTextBox;
		private System.Windows.Forms.Label resultLabel;
	}
}

