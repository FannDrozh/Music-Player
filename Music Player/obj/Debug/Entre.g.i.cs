﻿#pragma checksum "..\..\Entre.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "12F2A3CB0F17707524D15241D7385071C7DB277D2B980347670FB60F74D78CA8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Music_Player;
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


namespace Music_Player {
    
    
    /// <summary>
    /// Entre
    /// </summary>
    public partial class Entre : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 130 "..\..\Entre.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SmashUp;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\Entre.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Logo;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\Entre.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Login;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\Entre.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LogV;
        
        #line default
        #line hidden
        
        
        #line 176 "..\..\Entre.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Password;
        
        #line default
        #line hidden
        
        
        #line 188 "..\..\Entre.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PasswordV;
        
        #line default
        #line hidden
        
        
        #line 199 "..\..\Entre.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Entree;
        
        #line default
        #line hidden
        
        
        #line 213 "..\..\Entre.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Exit;
        
        #line default
        #line hidden
        
        
        #line 223 "..\..\Entre.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NotAc;
        
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
            System.Uri resourceLocater = new System.Uri("/Music Player;component/entre.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Entre.xaml"
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
            this.SmashUp = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Logo = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.Login = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.LogV = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Password = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.PasswordV = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Entree = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.Exit = ((System.Windows.Controls.Image)(target));
            
            #line 221 "..\..\Entre.xaml"
            this.Exit.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Exit_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 9:
            this.NotAc = ((System.Windows.Controls.TextBlock)(target));
            
            #line 233 "..\..\Entre.xaml"
            this.NotAc.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.NotAc_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

