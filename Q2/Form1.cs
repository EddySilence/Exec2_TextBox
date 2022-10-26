using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
	public partial class resultButton : Form
	{
		public resultButton()
		{
			InitializeComponent();
		}

		private void resultButtonQ2_Click(object sender, EventArgs e)
		{

			//取得使用者輸入的日期
			DateTime inputDate;
			try
			{
				inputDate = GetDate();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			//判斷有沒有大於今天
			bool result;
			result = GetResultBool(inputDate);

			//呈現資訊
			resultLabel.Text = GetResultString(result, inputDate);

		}

		private string GetResultString(bool result, DateTime inputDate)
		=> result ? $"{inputDate:yyyy/MM/dd} \"有\"大於今天" : $"{inputDate:yyyy/MM/dd} \"沒有\"大於今天";

		private bool GetResultBool(DateTime inputDate)
		{
			DateTime dateTime = DateTime.Today;

			return (inputDate > dateTime);//如果大於就回傳ture
		}

		private DateTime GetDate()
		{
			string input = inputTextBox.Text;
			bool isDate = DateTime.TryParse(input, out DateTime Date);

			return isDate ? Date : throw new Exception("請輸入正確的日期");
		}
	}
}
