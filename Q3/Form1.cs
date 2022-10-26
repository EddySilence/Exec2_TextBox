using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void resultButtonQ3_Click(object sender, EventArgs e)
		{
			//取得使用者輸入
			DateTime inputDate;
			DateTime today = DateTime.Today;
			try
			{
				inputDate = GetInput();
				if(inputDate> today)
				{
					MessageBox.Show("生日不能比今天大");
					return;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			//判斷是否大於13歲
			bool result;
			result = GetAgeBool(inputDate);

			//呈現資訊
			resultLabel.Text = GetResultString(result);

		}

		private string GetResultString(bool result)
		{
			return result ? "大於" : "小於";
		}

		private bool GetAgeBool(DateTime inputDate)
		{
			DateTime today = DateTime.Today;
			inputDate = inputDate.AddYears(13);

			return (inputDate <= today);//加了13歲還是小於今天的話，就大於13歲
		}

		private DateTime GetInput()
		{
			string input = string.Empty;
			input = inputTextBox.Text;

			bool isDate = DateTime.TryParse(input, out DateTime inputDate);

			return isDate ? inputDate : throw new Exception("請輸入日期");
		}
	}
}
