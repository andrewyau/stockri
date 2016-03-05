﻿#pragma checksum "..\..\..\Orders\OrderDetailsView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D2A05A6884FB9A5BA3CDCC7384B5160E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using StockTraderRI.Infrastructure;
using StockTraderRI.Infrastructure.Converters;
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


namespace StockTraderRI.Modules.Position.Orders {
    
    
    /// <summary>
    /// OrderDetailsView
    /// </summary>
    public partial class OrderDetailsView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\Orders\OrderDetailsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal StockTraderRI.Modules.Position.Orders.OrderDetailsView UserControl;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Orders\OrderDetailsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Orders\OrderDetailsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton BuyRadio;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Orders\OrderDetailsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton SellRadio;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Orders\OrderDetailsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SharesTextBox;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Orders\OrderDetailsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StopLimitPriceTextBox;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Orders\OrderDetailsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox OrderTypeCombo;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Orders\OrderDetailsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TimeInForceCombo;
        
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
            System.Uri resourceLocater = new System.Uri("/StockTraderRI.Modules.Position;component/orders/orderdetailsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Orders\OrderDetailsView.xaml"
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
            this.UserControl = ((StockTraderRI.Modules.Position.Orders.OrderDetailsView)(target));
            return;
            case 2:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.BuyRadio = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.SellRadio = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.SharesTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.StopLimitPriceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.OrderTypeCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.TimeInForceCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

