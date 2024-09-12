using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace Win11_CalculatorTests
{
    /// <summary>
    /// Description of Minus_tests.
    /// </summary>
    [TestModule("096D695C-C9F6-441A-9C8B-263D0C510200", ModuleType.UserCode, 1)]
    public class Minus_tests : Base, ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Minus_tests()
        { }

        void ITestModule.Run()
        {
            calc.enterNumber("321").clickMinus().enterNumber("654").clickEqual();
            Validate.AttributeContains(repo.Calculator.ResultInfo, "Caption", "-333");
            
            calc.clickClear();
            
            calc.enterNumber("789").clickNegate().clickMinus().enterNumber("987").clickEqual();
            Validate.AttributeContains(repo.Calculator.ResultInfo, "Caption", "-1 776");
        }
    }
}
