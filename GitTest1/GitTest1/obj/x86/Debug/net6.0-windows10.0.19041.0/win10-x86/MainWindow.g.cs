#pragma checksum "C:\Users\jeanmi\OneDrive - Cégep de Trois-Rivières\A22\GUI\Git\GitTest1\GitTest1\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "19F125FEBE5A052332A52887FD54CA3BA55F8E3035D04FA51BC272E8EE376030"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GitTest1
{
    partial class MainWindow : 
        global::Microsoft.UI.Xaml.Window, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainWindow.xaml line 11
                {
                    global::Microsoft.UI.Xaml.Controls.NavigationView element2 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NavigationView>(target);
                    ((global::Microsoft.UI.Xaml.Controls.NavigationView)element2).SelectionChanged += this.NavigationView_SelectionChanged;
                }
                break;
            case 3: // MainWindow.xaml line 13
                {
                    this.header = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 4: // MainWindow.xaml line 18
                {
                    this.Maison = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NavigationViewItem>(target);
                }
                break;
            case 5: // MainWindow.xaml line 19
                {
                    this.Favoris = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NavigationViewItem>(target);
                }
                break;
            case 6: // MainWindow.xaml line 20
                {
                    this.Calendrier = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NavigationViewItem>(target);
                }
                break;
            case 7: // MainWindow.xaml line 30
                {
                    this.mainFrame = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Frame>(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

