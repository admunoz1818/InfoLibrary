﻿#pragma checksum "C:\Users\Adrián\Documents\Visual Studio 2013\Projects\InfoLibrary\InfoLibrary\DetailedBook.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0885802FC11F724E3FB81900E25429EF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace InfoLibrary {
    
    
    public partial class DetailedBook : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox code;
        
        internal System.Windows.Controls.TextBox name;
        
        internal System.Windows.Controls.TextBox author;
        
        internal System.Windows.Controls.TextBox genre;
        
        internal System.Windows.Controls.TextBox pages;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/InfoLibrary;component/DetailedBook.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.code = ((System.Windows.Controls.TextBox)(this.FindName("code")));
            this.name = ((System.Windows.Controls.TextBox)(this.FindName("name")));
            this.author = ((System.Windows.Controls.TextBox)(this.FindName("author")));
            this.genre = ((System.Windows.Controls.TextBox)(this.FindName("genre")));
            this.pages = ((System.Windows.Controls.TextBox)(this.FindName("pages")));
        }
    }
}

