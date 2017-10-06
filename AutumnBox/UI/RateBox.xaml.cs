/* =============================================================================*\
*
* Filename: RateBox.xaml.cs
* Description: 
*
* Version: 1.0
* Created: 8/4/2017 12:12:58(UTC+8:00)
* Compiler: Visual Studio 2017
* 
* Author: zsh2401
* Company: I am free man
*
\* =============================================================================*/
using AutumnBox.Basic.Functions;
using AutumnBox.Basic.Functions.RunningManager;
using AutumnBox.Helper;
using System;
using System.Drawing;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace AutumnBox.UI
{
    /// <summary>
    /// RateBox.xaml 的交互逻辑
    /// </summary>
    public partial class RateBox : Window
    {
        private RunningManager rm;
        public RateBox(Window owner)
        {
            InitializeComponent();
            buttonCancel.Visibility = Visibility.Hidden;
            this.Owner = owner;
        }
        public RateBox(Window owner, RunningManager rm)
        {
            InitializeComponent();
            this.rm = rm;
            this.Owner = owner;
        }
        public new void ShowDialog()
        {
            base.ShowDialog();
        }
        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            UIHelper.DragMove(this,e);
        }
        public new void Close() {
            base.Close();
        }
        private void buttonStartBrventService_Click(object sender, RoutedEventArgs e)
        {
            this.rm.FuncStop();
            this.Close();
        }
    }
}
