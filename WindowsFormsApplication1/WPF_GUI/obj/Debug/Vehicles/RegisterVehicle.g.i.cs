﻿#pragma checksum "..\..\..\Vehicles\RegisterVehicle.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D6A3FBDAAFB8C1D86DCF0AA0E7F8234F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace WPF_GUI {
    
    
    /// <summary>
    /// RegisterVehicle
    /// </summary>
    public partial class RegisterVehicle : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\Vehicles\RegisterVehicle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnCar;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\Vehicles\RegisterVehicle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnTruck;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\Vehicles\RegisterVehicle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox btnVehicleModel;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Vehicles\RegisterVehicle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblModel;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Vehicles\RegisterVehicle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox btnVehicleColor;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Vehicles\RegisterVehicle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblColor;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Vehicles\RegisterVehicle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPrice;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Vehicles\RegisterVehicle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputVehiclePrice;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Vehicles\RegisterVehicle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Vehicles\RegisterVehicle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDone;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Vehicles\RegisterVehicle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblStatus;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF_GUI;component/vehicles/registervehicle.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Vehicles\RegisterVehicle.xaml"
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
            this.btnCar = ((System.Windows.Controls.RadioButton)(target));
            
            #line 7 "..\..\..\Vehicles\RegisterVehicle.xaml"
            this.btnCar.Checked += new System.Windows.RoutedEventHandler(this.btnCar_Checked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnTruck = ((System.Windows.Controls.RadioButton)(target));
            
            #line 8 "..\..\..\Vehicles\RegisterVehicle.xaml"
            this.btnTruck.Checked += new System.Windows.RoutedEventHandler(this.btnTruck_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnVehicleModel = ((System.Windows.Controls.ComboBox)(target));
            
            #line 9 "..\..\..\Vehicles\RegisterVehicle.xaml"
            this.btnVehicleModel.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.btnCarModel_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lblModel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.btnVehicleColor = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\..\Vehicles\RegisterVehicle.xaml"
            this.btnVehicleColor.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.btnCarColor_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lblColor = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lblPrice = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.inputVehiclePrice = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\..\Vehicles\RegisterVehicle.xaml"
            this.inputVehiclePrice.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Vehicles\RegisterVehicle.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnDone = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Vehicles\RegisterVehicle.xaml"
            this.btnDone.Click += new System.Windows.RoutedEventHandler(this.btnRegister_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.lblStatus = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

