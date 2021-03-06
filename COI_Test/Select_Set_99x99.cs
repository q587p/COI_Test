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
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace COI_Test
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Select_Set_99x99 recording.
    /// </summary>
    [TestModule("293fa08b-e9e5-4c54-bb33-356c55d52836", ModuleType.Recording, 1)]
    public partial class Select_Set_99x99 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the COI_TestRepository repository.
        /// </summary>
        public static COI_TestRepository repo = COI_TestRepository.Instance;

        static Select_Set_99x99 instance = new Select_Set_99x99();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Select_Set_99x99()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Select_Set_99x99 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.SomeContainer3.SomeList' at 59;12.", repo.NewProtocolWizard.SomeContainer3.SomeListInfo, new RecordItemIndex(0));
            repo.NewProtocolWizard.SomeContainer3.SomeList.Click("59;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.Grid.Next' at 48;9.", repo.NewProtocolWizard.Grid.NextInfo, new RecordItemIndex(1));
            repo.NewProtocolWizard.Grid.Next.Click("48;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.SomeContainer2.SomeList1' at 33;71.", repo.NewProtocolWizard.SomeContainer2.SomeList1Info, new RecordItemIndex(2));
            repo.NewProtocolWizard.SomeContainer2.SomeList1.Click("33;71");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{End}' with focus on 'NewProtocolWizard.SomeContainer2.SomeList1'.", repo.NewProtocolWizard.SomeContainer2.SomeList1Info, new RecordItemIndex(3));
            repo.NewProtocolWizard.SomeContainer2.SomeList1.PressKeys("{End}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.SomeContainer2.SomeElement' at 14;10.", repo.NewProtocolWizard.SomeContainer2.SomeElementInfo, new RecordItemIndex(4));
            repo.NewProtocolWizard.SomeContainer2.SomeElement.Click("14;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(5));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '99'.", new RecordItemIndex(6));
            Keyboard.Press("99");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.SomeContainer2.SomeElement2' at 19;10.", repo.NewProtocolWizard.SomeContainer2.SomeElement2Info, new RecordItemIndex(7));
            repo.NewProtocolWizard.SomeContainer2.SomeElement2.Click("19;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(8));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '99'.", new RecordItemIndex(9));
            Keyboard.Press("99");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.Grid.Next' at 39;12.", repo.NewProtocolWizard.Grid.NextInfo, new RecordItemIndex(10));
            repo.NewProtocolWizard.Grid.Next.Click("39;12");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
