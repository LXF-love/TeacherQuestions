﻿#pragma checksum "..\..\Alter.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "22BEF1116407E5C8DA1F88F54647A3DD11614D4B24E6D309D26D9F1852CC91B9"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

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
using TeacherDatabase;


namespace TeacherDatabase {
    
    
    /// <summary>
    /// Alter
    /// </summary>
    public partial class Alter : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 83 "..\..\Alter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Xtype;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\Alter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox selectXtype;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\Alter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxChapter;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\Alter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxQuestion;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\Alter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxAnswer;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\Alter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxIssueAnthor;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\Alter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox isShare;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\Alter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button del;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\Alter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button save;
        
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
            System.Uri resourceLocater = new System.Uri("/TeacherDatabase;component/alter.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Alter.xaml"
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
            this.Xtype = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.selectXtype = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbxChapter = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbxQuestion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbxAnswer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbxIssueAnthor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.isShare = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.del = ((System.Windows.Controls.Button)(target));
            
            #line 121 "..\..\Alter.xaml"
            this.del.Click += new System.Windows.RoutedEventHandler(this.Btn_Delete);
            
            #line default
            #line hidden
            return;
            case 9:
            this.save = ((System.Windows.Controls.Button)(target));
            
            #line 122 "..\..\Alter.xaml"
            this.save.Click += new System.Windows.RoutedEventHandler(this.Btn_Save);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

