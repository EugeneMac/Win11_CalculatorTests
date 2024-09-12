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
    /// Description of CalculatorTests.
    /// </summary>
    [TestModule("F2A25841-EEEF-4F68-AB02-6D620FD44514", ModuleType.UserCode, 1)]
    public class Plus_tests : Base, ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Plus_tests()
        { }

        void ITestModule.Run()
        {
            calc.enterNumber("123").clickPlus().enterNumber("456").clickEqual();
            Validate.AttributeContains(repo.Calculator.ResultInfo, "Caption", "579");
            
            calc.clickClear();
            
            calc.enterNumber("789").clickNegate().clickPlus().enterNumber("654").clickEqual();
            Validate.AttributeContains(repo.Calculator.ResultInfo, "Caption", "-135");
        }
    }
}
