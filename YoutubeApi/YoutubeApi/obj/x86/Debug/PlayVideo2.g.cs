﻿#pragma checksum "C:\Users\admin\source\repos\YoutubeApi\YoutubeApi\PlayVideo2.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "42200430044E5AB8330EE1E123BB6846"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YoutubeApi
{
    partial class PlayVideo2 : 
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
                    this.btnHomePage = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 11 "..\..\..\PlayVideo2.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnHomePage).Click += this.btnHomePage_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.Myplayer = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 3:
                {
                    this.volumeSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 20 "..\..\..\PlayVideo2.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.volumeSlider).ValueChanged += this.ChangeMediaVolume;
                    #line default
                }
                break;
            case 4:
                {
                    this.openFile = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 22 "..\..\..\PlayVideo2.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.openFile).Click += this.openFile_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.Play = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 23 "..\..\..\PlayVideo2.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Play).Click += this.Play_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.Pause = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 24 "..\..\..\PlayVideo2.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Pause).Click += this.Pause_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.Stop = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 25 "..\..\..\PlayVideo2.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Stop).Click += this.Stop_Click;
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

