using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			resultLabelQ4.Text = String.Empty;
		}

		private void resultButtonQ4_Click(object sender, EventArgs e)
		{
			resultLabelQ4.Text = String.Empty;
			int people, car;
			//取得人數
			try
			{
				people = GetPeople();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			//取得車數
			try
			{
				car = GetCar();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			int carCost, peopleCost;
			//按車輛計費
			carCost = GetCarCost(car);

			//按人數計費
			peopleCost = GetpeopleCost(people);

			//判斷哪個便宜並呈現資訊
			resultLabelQ4.Text = GetResult(people, car, carCost, peopleCost);

		}

		private string GetResult(int people, int car, int carCost, int peopleCost)
		=> (carCost >= peopleCost || car == 0) ? $"總共：　{people} 人 總共： {car} 輛車 共計： {peopleCost}元" :
												$"總共：　{people} 人 總共： {car} 輛車 共計： {carCost}元";


		private int GetpeopleCost(int peopleAmount)
		=> peopleAmount * 60;

		private int GetCarCost(int carAmount)
		=> carAmount * 200;

		private int GetCar()
		{
			string input = string.Empty;
			input = carTextBox.Text;
			string title = "車輛";

			return GetNumber(input, title);
		}

		private int GetPeople()
		{
			string input = string.Empty;
			input = peopelTextBox.Text;
			string title = "人數";

			return GetNumber(input, title);
		}

		private int GetNumber(string input, string title)
		{
			if(input == string.Empty) throw new Exception($"請輸入{title}");
			bool isInt = int.TryParse(input, out int number);

			if (number < 0) throw new Exception($"{title}不能負數");
			return isInt ? number : throw new Exception($"{title}要輸入數字");
		}
	}
}
