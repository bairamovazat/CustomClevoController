﻿#pragma checksum "..\..\..\..\Views\Page_OtherSettings.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E66402A89C997DC4AFCED3A0A3A00CE9B5212BD30679829E1AA4FDCC7FBD77C1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

using BSCustomClevoController.Views;
using MahApps.Metro;
using MahApps.Metro.Accessibility;
using MahApps.Metro.Actions;
using MahApps.Metro.Automation.Peers;
using MahApps.Metro.Behaviors;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Converters;
using MahApps.Metro.Markup;
using MahApps.Metro.Theming;
using MahApps.Metro.ValueBoxes;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace BSCustomClevoController.Views {
    
    
    /// <summary>
    /// Page_OtherSettings
    /// </summary>
    public partial class Page_OtherSettings : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\..\..\Views\Page_OtherSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox monitorModesComboBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Views\Page_OtherSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TouchPadToggle;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Views\Page_OtherSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox FeaturesListBox;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Views\Page_OtherSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BSCustomClevoController;component/views/page_othersettings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Page_OtherSettings.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.monitorModesComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 43 "..\..\..\..\Views\Page_OtherSettings.xaml"
            this.monitorModesComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.monitorModesComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TouchPadToggle = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\Views\Page_OtherSettings.xaml"
            this.TouchPadToggle.Click += new System.Windows.RoutedEventHandler(this.TouchPadToggle_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FeaturesListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.Exit = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\..\Views\Page_OtherSettings.xaml"
            this.Exit.Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

