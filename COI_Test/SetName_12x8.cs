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
    ///The SetName_12x8 recording.
    /// </summary>
    [TestModule("98a5053a-ee28-4960-b9a4-3aa2fbdc617b", ModuleType.Recording, 1)]
    public partial class SetName_12x8 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the COI_TestRepository repository.
        /// </summary>
        public static COI_TestRepository repo = COI_TestRepository.Instance;

        static SetName_12x8 instance = new SetName_12x8();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SetName_12x8()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SetName_12x8 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.SomeContainer2.SomeElement5' at 212;5.", repo.NewProtocolWizard.SomeContainer2.SomeElement5Info, new RecordItemIndex(0));
            repo.NewProtocolWizard.SomeContainer2.SomeElement5.Click("212;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(1));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}T{LShiftKey up}est'.", new RecordItemIndex(2));
            Keyboard.Press("{LShiftKey down}T{LShiftKey up}est");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.Grid.Next' at 13;7.", repo.NewProtocolWizard.Grid.NextInfo, new RecordItemIndex(3));
            repo.NewProtocolWizard.Grid.Next.Click("13;7");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
