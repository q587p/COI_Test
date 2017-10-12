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
    ///The CheckEmtpyData recording.
    /// </summary>
    [TestModule("e0743c0d-84ee-45b6-81d9-ebf17874a277", ModuleType.Recording, 1)]
    public partial class CheckEmtpyData : ITestModule
    {
        /// <summary>
        /// Holds an instance of the COI_TestRepository repository.
        /// </summary>
        public static COI_TestRepository repo = COI_TestRepository.Instance;

        static CheckEmtpyData instance = new CheckEmtpyData();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CheckEmtpyData()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CheckEmtpyData Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.ClearButton' at 55;14.", repo.NewProtocolWizard.ClearButtonInfo, new RecordItemIndex(0));
            repo.NewProtocolWizard.ClearButton.Click("55;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'NewProtocolWizard.SomeContainer3.MeasurementsDataCouldNotBeResolved'.", repo.NewProtocolWizard.SomeContainer3.MeasurementsDataCouldNotBeResolvedInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.NewProtocolWizard.SomeContainer3.MeasurementsDataCouldNotBeResolvedInfo, "Enabled", "True");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
