﻿using System.ComponentModel;
using System.Windows;
using Microsoft.HandsFree.GazePointer;

namespace Sleep37
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            GazePointer.Attach(this);
        }

        private void MainWindow_OnClosing(object sender, CancelEventArgs e)
        {
            GazePointer.DetachAll();
        }

        #region Button ClickHandlers
        private void LockButton1_OnClick(object sender, RoutedEventArgs e)
        {
            LockButton1.IsEnabled = false;
            LockButton2.IsEnabled = true;
        }

        private void LockButton2_OnClick(object sender, RoutedEventArgs e)
        {
            LockButton2.IsEnabled = false;
            LockButton3.IsEnabled = true;
        }

        private void LockButton3_OnClick(object sender, RoutedEventArgs e)
        {
            LockButton3.IsEnabled = false;
            LockButton4.IsEnabled = true;
        }

        private void LockButton4_OnClick(object sender, RoutedEventArgs e)
        {
            LockButton4.IsEnabled = false;
            LockButton1.IsEnabled = true;

            var wakeWindow = new WakeWindow();
            wakeWindow.ShowDialog();
        }
        #endregion Button ClickHandlers
    }
}