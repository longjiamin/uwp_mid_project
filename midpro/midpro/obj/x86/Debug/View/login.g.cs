﻿#pragma checksum "C:\Users\zhulifeng\Desktop\期中代码\midpro\midpro\View\login.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "230B731D86F651E0227C546E7A973B45"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace midpro
{
    partial class login : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.title = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.userLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.username = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4:
                {
                    this.passwordLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.password = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 6:
                {
                    this.userLogin = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 32 "..\..\..\View\login.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.userLogin).Click += this.userLogin_Click;
                    #line 32 "..\..\..\View\login.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.userLogin).KeyDown += this.userLogin_KeyDown;
                    #line default
                }
                break;
            case 7:
                {
                    this.userSignup = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 33 "..\..\..\View\login.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.userSignup).Click += this.userSignup_Click;
                    #line 33 "..\..\..\View\login.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.userSignup).KeyDown += this.userSignup_KeyDown;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

