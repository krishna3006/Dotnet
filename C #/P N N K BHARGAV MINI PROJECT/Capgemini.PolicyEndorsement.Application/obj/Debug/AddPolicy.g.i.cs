﻿#pragma checksum "..\..\AddPolicy.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BC2CF957DC8F4BF396F235FBC4C100F6C3F6A5E2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Capgemini.PolicyEndorsement.Application;
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


namespace Capgemini.PolicyEndorsement.Application {
    
    
    /// <summary>
    /// AddPolicy
    /// </summary>
    public partial class AddPolicy : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\AddPolicy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbCustomerNumber;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AddPolicy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbProductID;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AddPolicy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtInsuredName;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AddPolicy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtInsuredAge;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddPolicy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNominee;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AddPolicy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRelation;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\AddPolicy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdMon;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AddPolicy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdHalfY;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AddPolicy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdQuat;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\AddPolicy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdAnnu;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\AddPolicy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSubmit;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\AddPolicy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClear;
        
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
            System.Uri resourceLocater = new System.Uri("/Capgemini.PolicyEndorsement.Application;component/addpolicy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddPolicy.xaml"
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
            
            #line 9 "..\..\AddPolicy.xaml"
            ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Grid_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmbCustomerNumber = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\AddPolicy.xaml"
            this.cmbCustomerNumber.DropDownClosed += new System.EventHandler(this.CmbCustomerNumber_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmbProductID = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.txtInsuredName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtInsuredAge = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtNominee = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtRelation = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.rdMon = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 9:
            this.rdHalfY = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 10:
            this.rdQuat = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 11:
            this.rdAnnu = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 12:
            this.btnSubmit = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\AddPolicy.xaml"
            this.btnSubmit.Click += new System.Windows.RoutedEventHandler(this.BtnSubmit_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btnClear = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\AddPolicy.xaml"
            this.btnClear.Click += new System.Windows.RoutedEventHandler(this.BtnClear_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

