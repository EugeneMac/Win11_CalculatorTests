﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Win11_CalculatorTests
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the Win11_CalculatorTestsRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("186e4a3c-02a2-4ecb-be52-4c6b99dbebff")]
    public partial class Win11_CalculatorTestsRepository : RepoGenBaseFolder
    {
        static Win11_CalculatorTestsRepository instance = new Win11_CalculatorTestsRepository();
        Win11_CalculatorTestsRepositoryFolders.CalculatorAppFolder _calculator;

        /// <summary>
        /// Gets the singleton class instance representing the Win11_CalculatorTestsRepository element repository.
        /// </summary>
        [RepositoryFolder("186e4a3c-02a2-4ecb-be52-4c6b99dbebff")]
        public static Win11_CalculatorTestsRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Win11_CalculatorTestsRepository() 
            : base("Win11_CalculatorTestsRepository", "/", null, 0, false, "186e4a3c-02a2-4ecb-be52-4c6b99dbebff", ".\\RepositoryImages\\Win11_CalculatorTestsRepository186e4a3c.rximgres")
        {
            _calculator = new Win11_CalculatorTestsRepositoryFolders.CalculatorAppFolder(this);
        }

#region Variables

        string _numberN = "1";

        /// <summary>
        /// Gets or sets the value of variable numberN.
        /// </summary>
        [TestVariable("3f29d758-3676-425f-9b35-8f3fb38cf74d")]
        public string numberN
        {
            get { return _numberN; }
            set { _numberN = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("186e4a3c-02a2-4ecb-be52-4c6b99dbebff")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The Calculator folder.
        /// </summary>
        [RepositoryFolder("958cfc07-32fe-430b-84b4-edb72437c1b1")]
        public virtual Win11_CalculatorTestsRepositoryFolders.CalculatorAppFolder Calculator
        {
            get { return _calculator; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class Win11_CalculatorTestsRepositoryFolders
    {
        /// <summary>
        /// The CalculatorAppFolder folder.
        /// </summary>
        [RepositoryFolder("958cfc07-32fe-430b-84b4-edb72437c1b1")]
        public partial class CalculatorAppFolder : RepoGenBaseFolder
        {
            Win11_CalculatorTestsRepositoryFolders.NumberPadFolder _numberpad;
            RepoItemInfo _plusbuttonInfo;
            RepoItemInfo _minusbuttonInfo;
            RepoItemInfo _clearbuttonInfo;
            RepoItemInfo _equalbuttonInfo;
            RepoItemInfo _resultInfo;
            RepoItemInfo _negatebuttonInfo;

            /// <summary>
            /// Creates a new Calculator  folder.
            /// </summary>
            public CalculatorAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Calculator", "/winapp[@packagename='Microsoft.WindowsCalculator']", parentFolder, 30000, null, true, "958cfc07-32fe-430b-84b4-edb72437c1b1", "")
            {
                _numberpad = new Win11_CalculatorTestsRepositoryFolders.NumberPadFolder(this);
                _plusbuttonInfo = new RepoItemInfo(this, "PlusButton", ".//container[@automationid='StandardOperators']/button[@automationid='plusButton']", ".//button[@automationid='plusButton']", 30000, null, "11cac90f-6e48-4a7a-813a-9bc91d6ba4c5");
                _minusbuttonInfo = new RepoItemInfo(this, "MinusButton", ".//container[@automationid='StandardOperators']/button[@automationid='minusButton']", ".//button[@automationid='minusButton']", 30000, null, "267cacbd-ee3f-4e5d-b74e-290f9cf87473");
                _clearbuttonInfo = new RepoItemInfo(this, "ClearButton", ".//container[@automationid='DisplayControls']/button[@automationid='clearButton']", ".//button[@automationid='clearButton']", 30000, null, "b482454a-4521-4f33-9c4f-30b2d1d39a79");
                _equalbuttonInfo = new RepoItemInfo(this, "EqualButton", ".//container[@automationid='StandardOperators']/button[@automationid='equalButton']", ".//button[@automationid='equalButton']", 30000, null, "99620f76-e4b7-4f7c-99bb-ac5ca922e541");
                _resultInfo = new RepoItemInfo(this, "Result", ".//text[@automationid='CalculatorResults']/container[@automationid='TextContainer']", ".//container[@automationid='TextContainer']", 30000, null, "b4100e42-b3b8-43df-9484-e78890533e27");
                _negatebuttonInfo = new RepoItemInfo(this, "NegateButton", "element[@automationid='NavView']/?/?/button[@automationid='negateButton']", ".//button[@automationid='negateButton']", 30000, null, "7d6f6b67-3eaa-4c52-8f93-be345ad764ff");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("958cfc07-32fe-430b-84b4-edb72437c1b1")]
            public virtual Ranorex.WindowsApp Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WindowsApp>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("958cfc07-32fe-430b-84b4-edb72437c1b1")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The PlusButton item.
            /// </summary>
            [RepositoryItem("11cac90f-6e48-4a7a-813a-9bc91d6ba4c5")]
            public virtual Ranorex.Button PlusButton
            {
                get
                {
                    return _plusbuttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PlusButton item info.
            /// </summary>
            [RepositoryItemInfo("11cac90f-6e48-4a7a-813a-9bc91d6ba4c5")]
            public virtual RepoItemInfo PlusButtonInfo
            {
                get
                {
                    return _plusbuttonInfo;
                }
            }

            /// <summary>
            /// The MinusButton item.
            /// </summary>
            [RepositoryItem("267cacbd-ee3f-4e5d-b74e-290f9cf87473")]
            public virtual Ranorex.Button MinusButton
            {
                get
                {
                    return _minusbuttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The MinusButton item info.
            /// </summary>
            [RepositoryItemInfo("267cacbd-ee3f-4e5d-b74e-290f9cf87473")]
            public virtual RepoItemInfo MinusButtonInfo
            {
                get
                {
                    return _minusbuttonInfo;
                }
            }

            /// <summary>
            /// The ClearButton item.
            /// </summary>
            [RepositoryItem("b482454a-4521-4f33-9c4f-30b2d1d39a79")]
            public virtual Ranorex.Button ClearButton
            {
                get
                {
                    return _clearbuttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ClearButton item info.
            /// </summary>
            [RepositoryItemInfo("b482454a-4521-4f33-9c4f-30b2d1d39a79")]
            public virtual RepoItemInfo ClearButtonInfo
            {
                get
                {
                    return _clearbuttonInfo;
                }
            }

            /// <summary>
            /// The EqualButton item.
            /// </summary>
            [RepositoryItem("99620f76-e4b7-4f7c-99bb-ac5ca922e541")]
            public virtual Ranorex.Button EqualButton
            {
                get
                {
                    return _equalbuttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The EqualButton item info.
            /// </summary>
            [RepositoryItemInfo("99620f76-e4b7-4f7c-99bb-ac5ca922e541")]
            public virtual RepoItemInfo EqualButtonInfo
            {
                get
                {
                    return _equalbuttonInfo;
                }
            }

            /// <summary>
            /// The Result item.
            /// </summary>
            [RepositoryItem("b4100e42-b3b8-43df-9484-e78890533e27")]
            public virtual Ranorex.Container Result
            {
                get
                {
                    return _resultInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Result item info.
            /// </summary>
            [RepositoryItemInfo("b4100e42-b3b8-43df-9484-e78890533e27")]
            public virtual RepoItemInfo ResultInfo
            {
                get
                {
                    return _resultInfo;
                }
            }

            /// <summary>
            /// The NegateButton item.
            /// </summary>
            [RepositoryItem("7d6f6b67-3eaa-4c52-8f93-be345ad764ff")]
            public virtual Ranorex.Button NegateButton
            {
                get
                {
                    return _negatebuttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The NegateButton item info.
            /// </summary>
            [RepositoryItemInfo("7d6f6b67-3eaa-4c52-8f93-be345ad764ff")]
            public virtual RepoItemInfo NegateButtonInfo
            {
                get
                {
                    return _negatebuttonInfo;
                }
            }

            /// <summary>
            /// The NumberPad folder.
            /// </summary>
            [RepositoryFolder("b15c4bcb-f085-4775-9bfc-8de45afba405")]
            public virtual Win11_CalculatorTestsRepositoryFolders.NumberPadFolder NumberPad
            {
                get { return _numberpad; }
            }
        }

        /// <summary>
        /// The NumberPadFolder folder.
        /// </summary>
        [RepositoryFolder("b15c4bcb-f085-4775-9bfc-8de45afba405")]
        public partial class NumberPadFolder : RepoGenBaseFolder
        {
            RepoItemInfo _numnbuttonInfo;
            RepoItemInfo _num2buttonInfo;
            RepoItemInfo _num3buttonInfo;

            /// <summary>
            /// Creates a new NumberPad  folder.
            /// </summary>
            public NumberPadFolder(RepoGenBaseFolder parentFolder) :
                    base("NumberPad", ".//container[@automationid='NumberPad']", parentFolder, 30000, null, false, "b15c4bcb-f085-4775-9bfc-8de45afba405", "")
            {
                _numnbuttonInfo = new RepoItemInfo(this, "NumNButton", "button[@automationid='num'+$numberN+'Button']", "", 30000, null, "4079cd5a-e111-4e2e-899b-1cff8f7e2674");
                _num2buttonInfo = new RepoItemInfo(this, "Num2Button", "button[@automationid='num2Button']", "", 30000, null, "cc1f45f0-b968-43fc-8b5b-c4623aa8f3a6");
                _num3buttonInfo = new RepoItemInfo(this, "Num3Button", "button[@automationid='num3Button']", "", 30000, null, "b8655b00-6458-4072-8b66-e9e77f663676");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("b15c4bcb-f085-4775-9bfc-8de45afba405")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("b15c4bcb-f085-4775-9bfc-8de45afba405")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The NumNButton item.
            /// </summary>
            [RepositoryItem("4079cd5a-e111-4e2e-899b-1cff8f7e2674")]
            public virtual Ranorex.Button NumNButton
            {
                get
                {
                    return _numnbuttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The NumNButton item info.
            /// </summary>
            [RepositoryItemInfo("4079cd5a-e111-4e2e-899b-1cff8f7e2674")]
            public virtual RepoItemInfo NumNButtonInfo
            {
                get
                {
                    return _numnbuttonInfo;
                }
            }

            /// <summary>
            /// The Num2Button item.
            /// </summary>
            [RepositoryItem("cc1f45f0-b968-43fc-8b5b-c4623aa8f3a6")]
            public virtual Ranorex.Button Num2Button
            {
                get
                {
                    return _num2buttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Num2Button item info.
            /// </summary>
            [RepositoryItemInfo("cc1f45f0-b968-43fc-8b5b-c4623aa8f3a6")]
            public virtual RepoItemInfo Num2ButtonInfo
            {
                get
                {
                    return _num2buttonInfo;
                }
            }

            /// <summary>
            /// The Num3Button item.
            /// </summary>
            [RepositoryItem("b8655b00-6458-4072-8b66-e9e77f663676")]
            public virtual Ranorex.Button Num3Button
            {
                get
                {
                    return _num3buttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Num3Button item info.
            /// </summary>
            [RepositoryItemInfo("b8655b00-6458-4072-8b66-e9e77f663676")]
            public virtual RepoItemInfo Num3ButtonInfo
            {
                get
                {
                    return _num3buttonInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
