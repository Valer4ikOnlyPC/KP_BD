﻿#pragma checksum "..\..\..\..\Pages\PageOrderProduct.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C0BCF0A77B1AF8BABB17B105A34810D2F313DF78"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Keeper.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Keeper.Pages {
    
    
    /// <summary>
    /// PageOrderProduct
    /// </summary>
    public partial class PageOrderProduct : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\Pages\PageOrderProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewOrderProduct;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Pages\PageOrderProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewCategory;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Pages\PageOrderProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewProduct;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Pages\PageOrderProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackToCategory;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\Pages\PageOrderProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackToOrder;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Pages\PageOrderProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteProduct;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Keeper;V1.0.0.0;component/pages/pageorderproduct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\PageOrderProduct.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ListViewOrderProduct = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.ListViewCategory = ((System.Windows.Controls.ListView)(target));
            
            #line 34 "..\..\..\..\Pages\PageOrderProduct.xaml"
            this.ListViewCategory.PreviewMouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ListViewCategory_PreviewMouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ListViewProduct = ((System.Windows.Controls.ListView)(target));
            
            #line 41 "..\..\..\..\Pages\PageOrderProduct.xaml"
            this.ListViewProduct.PreviewMouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ListViewProduct_PreviewMouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BackToCategory = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\..\Pages\PageOrderProduct.xaml"
            this.BackToCategory.Click += new System.Windows.RoutedEventHandler(this.BackToCategory_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BackToOrder = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\..\Pages\PageOrderProduct.xaml"
            this.BackToOrder.Click += new System.Windows.RoutedEventHandler(this.BackToOrder_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DeleteProduct = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\..\Pages\PageOrderProduct.xaml"
            this.DeleteProduct.Click += new System.Windows.RoutedEventHandler(this.DeleteProduct_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

