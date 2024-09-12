using System;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace Win11_CalculatorTests
{
	/// <summary>
	/// Description of Base.
	/// </summary>
	public class Base
	{
		public static Win11_CalculatorTestsRepository repo = Win11_CalculatorTestsRepository.Instance;
    	public Calculator calc;
		public Base()
		{
			this.calc = new Calculator();
			Mouse.DefaultMoveTime = 80;
            Keyboard.DefaultKeyPressTime = 60;
            Delay.SpeedFactor = 0;
		}
	}
}
