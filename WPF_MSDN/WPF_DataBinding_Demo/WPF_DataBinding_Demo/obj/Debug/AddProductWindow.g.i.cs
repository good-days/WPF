﻿#pragma checksum "..\..\AddProductWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3D3F0B501F73105131B46CFCB7CED34871A3022763B4BAB5F7DBEC06F0DE1892"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
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
using WPF_DataBinding_Demo;


namespace WPF_DataBinding_Demo {
    
    
    /// <summary>
    /// AddProductWindow
    /// </summary>
    public partial class AddProductWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 54 "..\..\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescriptionEntryForm;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StartPriceEntryForm;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StartDateEntryForm;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CategoryEntryForm;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SpecialFeaturesEntryForm;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Submit;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ErrorTextBlock;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl ShortPreview;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl LongPreview;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF_DataBinding_Demo;component/addproductwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddProductWindow.xaml"
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
            
            #line 8 "..\..\AddProductWindow.xaml"
            ((WPF_DataBinding_Demo.AddProductWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.OnInit);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DescriptionEntryForm = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.StartPriceEntryForm = ((System.Windows.Controls.TextBox)(target));
            
            #line 63 "..\..\AddProductWindow.xaml"
            this.StartPriceEntryForm.AddHandler(System.Windows.Controls.Validation.ErrorEvent, new System.EventHandler<System.Windows.Controls.ValidationErrorEventArgs>(this.OnValidationError));
            
            #line default
            #line hidden
            return;
            case 4:
            this.StartDateEntryForm = ((System.Windows.Controls.TextBox)(target));
            
            #line 79 "..\..\AddProductWindow.xaml"
            this.StartDateEntryForm.AddHandler(System.Windows.Controls.Validation.ErrorEvent, new System.EventHandler<System.Windows.Controls.ValidationErrorEventArgs>(this.OnValidationError));
            
            #line default
            #line hidden
            return;
            case 5:
            this.CategoryEntryForm = ((System.Windows.Controls.ComboBox)(target));
            
            #line 97 "..\..\AddProductWindow.xaml"
            this.CategoryEntryForm.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SpecialFeaturesEntryForm = ((System.Windows.Controls.ComboBox)(target));
            
            #line 112 "..\..\AddProductWindow.xaml"
            this.SpecialFeaturesEntryForm.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Submit = ((System.Windows.Controls.Button)(target));
            
            #line 129 "..\..\AddProductWindow.xaml"
            this.Submit.Click += new System.Windows.RoutedEventHandler(this.SubmitProduct);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ErrorTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.ShortPreview = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 10:
            this.LongPreview = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
