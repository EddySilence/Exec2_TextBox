namespace Q4
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
			this.label2 = new System.Windows.Forms.Label();
			this.peopelTextBox = new System.Windows.Forms.TextBox();
			this.carTextBox = new System.Windows.Forms.TextBox();
			this.resultButtonQ4 = new System.Windows.Forms.Button();
			this.resultLabelQ4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(62, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "人數：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(278, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "車數：";
			// 
			// peopelTextBox
			// 
			this.peopelTextBox.Location = new System.Drawing.Point(131, 54);
			this.peopelTextBox.Name = "peopelTextBox";
			this.peopelTextBox.Size = new System.Drawing.Size(100, 22);
			this.peopelTextBox.TabIndex = 2;
			// 
			// carTextBox
			// 
			this.carTextBox.Location = new System.Drawing.Point(342, 54);
			this.carTextBox.Name = "carTextBox";
			this.carTextBox.Size = new System.Drawing.Size(100, 22);
			this.carTextBox.TabIndex = 3;
			// 
			// resultButtonQ4
			// 
			this.resultButtonQ4.Location = new System.Drawing.Point(472, 54);
			this.resultButtonQ4.Name = "resultButtonQ4";
			this.resultButtonQ4.Size = new System.Drawing.Size(75, 23);
			this.resultButtonQ4.TabIndex = 4;
			this.resultButtonQ4.Text = "計算";
			this.resultButtonQ4.UseVisualStyleBackColor = true;
			this.resultButtonQ4.Click += new System.EventHandler(this.resultButtonQ4_Click);
			// 
			// resultLabelQ4
			// 
			this.resultLabelQ4.AutoSize = true;
			this.resultLabelQ4.Location = new System.Drawing.Point(182, 134);
			this.resultLabelQ4.Name = "resultLabelQ4";
			this.resultLabelQ4.Size = new System.Drawing.Size(137, 12);
			this.resultLabelQ4.TabIndex = 5;
			this.resultLabelQ4.Text = "人：? 車：?  共多少錢：?";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(578, 235);
			this.Controls.Add(this.resultLabelQ4);
			this.Controls.Add(this.resultButtonQ4);
			this.Controls.Add(this.carTextBox);
			this.Controls.Add(this.peopelTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox peopelTextBox;
		private System.Windows.Forms.TextBox carTextBox;
		private System.Windows.Forms.Button resultButtonQ4;
		private System.Windows.Forms.Label resultLabelQ4;
	}
}

