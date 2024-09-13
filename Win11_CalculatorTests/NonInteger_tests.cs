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
    /// Description of NonInteger_tests.
    /// </summary>
    [TestModule("CA025505-ECE1-413A-980A-939CD7089487", ModuleType.UserCode, 1)]
    public class NonInteger_tests : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NonInteger_tests()
        { }

        void ITestModule.Run()
        {
			calc.enterNumber("123.456").clickPlus().enterNumber("456.789").clickEqual();
			Validate.AttributeContains(repo.Calculator.ResultInfo, "Caption", "580,245");
            
            calc.clickClear();
        }
    }
}
