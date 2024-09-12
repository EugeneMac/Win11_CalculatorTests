using System;
using System.Threading;
using System.Diagnostics;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Win11_CalculatorTests
{
	/// <summary>
	/// Description of Calculator.
	/// </summary>
	public class Calculator
	{
		public static Win11_CalculatorTestsRepository repo = Win11_CalculatorTestsRepository.Instance;
		
		public Calculator()
		{
			if (!isSutRunning()) Host.Local.RunApplication("\"C:\\Windows\\SysWOW64\\calc.exe\"", "", "", false);
			clickClear();
	    }
		
		private bool isSutRunning()
		{
			Process[] pname = Process.GetProcessesByName("CalculatorApp");
			if (pname.Length == 0) return false;
  			else return true;
		}
		
		public Calculator enterNumber(string number)
		{
			foreach (var chr in number)
			{
				repo.numberN = chr.ToString();
				repo.Calculator.NumberPad.NumNButton.Click();
			}
		return this;	
		}
		
		public Calculator clickClear()
		{
			repo.Calculator.ClearButton.Click();
			return this;
		}
		
		public Calculator clickPlus()
		{
			repo.Calculator.PlusButton.Click();
			return this;
		}
		
		public Calculator clickMinus()
		{
			repo.Calculator.MinusButton.Click();
			return this;
		}
		
		public Calculator clickEqual()
		{
			repo.Calculator.EqualButton.Click();
			return this;
		}
		
		public Calculator clickNegate()
		{
			repo.Calculator.NegateButton.Click();
			return this;
		}
	}
}
