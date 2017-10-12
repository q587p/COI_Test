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
    ///The SetDataDoubleMore recording.
    /// </summary>
    [TestModule("f35e7cab-5ed3-42c0-9a8d-49200644a505", ModuleType.Recording, 1)]
    public partial class SetDataDoubleMore : ITestModule
    {
        /// <summary>
        /// Holds an instance of the COI_TestRepository repository.
        /// </summary>
        public static COI_TestRepository repo = COI_TestRepository.Instance;

        static SetDataDoubleMore instance = new SetDataDoubleMore();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SetDataDoubleMore()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SetDataDoubleMore Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.ClearButton' at 42;14.", repo.NewProtocolWizard.ClearButtonInfo, new RecordItemIndex(0));
            repo.NewProtocolWizard.ClearButton.Click("42;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.SomeElement' at 46;55.", repo.NewProtocolWizard.SomeElementInfo, new RecordItemIndex(1));
            repo.NewProtocolWizard.SomeElement.Click("46;55");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '9999999999999999999999999999'.", new RecordItemIndex(2));
            Keyboard.Press("9999999999999999999999999999");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '9'.", new RecordItemIndex(3));
            Keyboard.Press("9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu down}{Tab down}{LMenu up}{Tab up}'.", new RecordItemIndex(4));
            Keyboard.Press("{LMenu down}{Tab down}{LMenu up}{Tab up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking Focus() on item 'NewProtocolWizard'.", repo.NewProtocolWizard.SelfInfo, new RecordItemIndex(5));
            repo.NewProtocolWizard.Self.Focus();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '9'.", new RecordItemIndex(6));
            Keyboard.Press("9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.Grid.Next' at 37;14.", repo.NewProtocolWizard.Grid.NextInfo, new RecordItemIndex(7));
            repo.NewProtocolWizard.Grid.Next.Click("37;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.Grid.Back' at 32;19.", repo.NewProtocolWizard.Grid.BackInfo, new RecordItemIndex(8));
            repo.NewProtocolWizard.Grid.Back.Click("32;19");
            Delay.Milliseconds(152930);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
