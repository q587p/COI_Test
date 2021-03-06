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
    ///The SetSimpleData_1x1 recording.
    /// </summary>
    [TestModule("60ce45f4-3105-4670-9be1-ec83de0947f1", ModuleType.Recording, 1)]
    public partial class SetSimpleData_1x1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the COI_TestRepository repository.
        /// </summary>
        public static COI_TestRepository repo = COI_TestRepository.Instance;

        static SetSimpleData_1x1 instance = new SetSimpleData_1x1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SetSimpleData_1x1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SetSimpleData_1x1 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.SomeElement' at 115;79.", repo.NewProtocolWizard.SomeElementInfo, new RecordItemIndex(0));
            repo.NewProtocolWizard.SomeElement.Click("115;79");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1'.", new RecordItemIndex(1));
            Keyboard.Press("1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.Grid.Next' at 22;10.", repo.NewProtocolWizard.Grid.NextInfo, new RecordItemIndex(2));
            repo.NewProtocolWizard.Grid.Next.Click("22;10");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
