﻿#pragma checksum "..\..\..\XAMLViews\Configuration.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4D21D01034D466BB86609879209CC09F3A05593270E4DF82EBA45B6127B9AED6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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
using UIGameClientTourist.Properties;
using UIGameClientTourist.XAMLViews;


namespace UIGameClientTourist.XAMLViews {
    
    
    /// <summary>
    /// Configuration
    /// </summary>
    public partial class Configuration : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\XAMLViews\Configuration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboxLanguages;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\XAMLViews\Configuration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butAccept;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\XAMLViews\Configuration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider volumeSlider;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\XAMLViews\Configuration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbutPlayMusic;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\XAMLViews\Configuration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbutPauseMusic;
        
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
            System.Uri resourceLocater = new System.Uri("/UIGameClientTourist;component/xamlviews/configuration.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\XAMLViews\Configuration.xaml"
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
            this.cboxLanguages = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\..\XAMLViews\Configuration.xaml"
            this.cboxLanguages.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ChangeLanguage);
            
            #line default
            #line hidden
            return;
            case 2:
            this.butAccept = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\XAMLViews\Configuration.xaml"
            this.butAccept.Click += new System.Windows.RoutedEventHandler(this.NavigateToMainMenuGame);
            
            #line default
            #line hidden
            return;
            case 3:
            this.volumeSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 29 "..\..\..\XAMLViews\Configuration.xaml"
            this.volumeSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.volumeSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.rbutPlayMusic = ((System.Windows.Controls.RadioButton)(target));
            
            #line 45 "..\..\..\XAMLViews\Configuration.xaml"
            this.rbutPlayMusic.Checked += new System.Windows.RoutedEventHandler(this.rbutPlayMusic_Checked_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rbutPauseMusic = ((System.Windows.Controls.RadioButton)(target));
            
            #line 55 "..\..\..\XAMLViews\Configuration.xaml"
            this.rbutPauseMusic.Checked += new System.Windows.RoutedEventHandler(this.rbutPauseMusic_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

