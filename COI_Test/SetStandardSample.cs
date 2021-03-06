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
    ///The SetStandardSample recording.
    /// </summary>
    [TestModule("350e22d4-763e-48dd-b809-23b5b459a761", ModuleType.Recording, 1)]
    public partial class SetStandardSample : ITestModule
    {
        /// <summary>
        /// Holds an instance of the COI_TestRepository repository.
        /// </summary>
        public static COI_TestRepository repo = COI_TestRepository.Instance;

        static SetStandardSample instance = new SetStandardSample();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SetStandardSample()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SetStandardSample Instance
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

            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Checked to 'True' on item 'NewProtocolWizard.SomeContainer2.SomeCheckBox'.", repo.NewProtocolWizard.SomeContainer2.SomeCheckBoxInfo, new RecordItemIndex(0));
            repo.NewProtocolWizard.SomeContainer2.SomeCheckBox.Element.SetAttributeValue("Checked", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Checked to 'False' on item 'NewProtocolWizard.SomeContainer2.SomeCheckBox1'.", repo.NewProtocolWizard.SomeContainer2.SomeCheckBox1Info, new RecordItemIndex(1));
            repo.NewProtocolWizard.SomeContainer2.SomeCheckBox1.Element.SetAttributeValue("Checked", "False");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Checked to 'False' on item 'NewProtocolWizard.SomeContainer2.SomeCheckBox2'.", repo.NewProtocolWizard.SomeContainer2.SomeCheckBox2Info, new RecordItemIndex(2));
            repo.NewProtocolWizard.SomeContainer2.SomeCheckBox2.Element.SetAttributeValue("Checked", "False");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Checked to 'False' on item 'NewProtocolWizard.SomeContainer2.SomeCheckBox3'.", repo.NewProtocolWizard.SomeContainer2.SomeCheckBox3Info, new RecordItemIndex(3));
            repo.NewProtocolWizard.SomeContainer2.SomeCheckBox3.Element.SetAttributeValue("Checked", "False");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Checked to 'False' on item 'NewProtocolWizard.SomeContainer2.SomeCheckBox4'.", repo.NewProtocolWizard.SomeContainer2.SomeCheckBox4Info, new RecordItemIndex(4));
            repo.NewProtocolWizard.SomeContainer2.SomeCheckBox4.Element.SetAttributeValue("Checked", "False");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Checked to 'False' on item 'NewProtocolWizard.SomeContainer2.SomeCheckBox5'.", repo.NewProtocolWizard.SomeContainer2.SomeCheckBox5Info, new RecordItemIndex(5));
            repo.NewProtocolWizard.SomeContainer2.SomeCheckBox5.Element.SetAttributeValue("Checked", "False");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Checked to 'False' on item 'NewProtocolWizard.SomeContainer2.SomeCheckBox6'.", repo.NewProtocolWizard.SomeContainer2.SomeCheckBox6Info, new RecordItemIndex(6));
            repo.NewProtocolWizard.SomeContainer2.SomeCheckBox6.Element.SetAttributeValue("Checked", "False");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Checked to 'False' on item 'NewProtocolWizard.SomeContainer2.SomeCheckBox7'.", repo.NewProtocolWizard.SomeContainer2.SomeCheckBox7Info, new RecordItemIndex(7));
            repo.NewProtocolWizard.SomeContainer2.SomeCheckBox7.Element.SetAttributeValue("Checked", "False");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.Grid.Next' at 36;12.", repo.NewProtocolWizard.Grid.NextInfo, new RecordItemIndex(8));
            repo.NewProtocolWizard.Grid.Next.Click("36;12");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
