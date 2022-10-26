using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void resultButton_Click(object sender, EventArgs e)
		{
			//取得數字
			int number = 0;
			try
			{
				number = GetNumber();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			//是否在1~99之間
			bool result;
			result = GetResultBool(number);

			//呈現
			resultLabel.Text = GetReslutString(result, number);

		}

		private string GetReslutString(bool result, int number)
		=> result ? $" {number} 介於1~99之間" : $" {number} \"不\"介於1~99之間";

		private bool GetResultBool(int number)
		=> (number <= 99 && number >= 1);


		private int GetNumber()
		{
			string input = string.Empty;
			input = inputTextBox.Text;

			bool isInt = int.TryParse(input, out int number);

			return isInt ? number : throw new Exception("請輸入數字");
		}
	}
}
