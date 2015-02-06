/******************************************************************************/
/*                                                                            */
/*   Program: MyWindowsPositionSettingsReload                                 */
/*   Automatic save and reload Windows-Setting after close and start          */
/*                                                                            */
/*   21.01.2015 0.0.0.0 uhwgmxorg Start                                       */
/*                                                                            */
/******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
﻿using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyWindowsPositionSettingsReload
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /******************************/
        /*       Button Events        */
        /******************************/
        #region Button Events

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        #endregion

        /******************************/
        /*      Menu Events          */
        /******************************/
        #region Menu Events

        #endregion

        /******************************/
        /*      Other Events          */
        /******************************/
        #region Other Events

        #endregion

        /******************************/
        /*      Other Functions       */
        /******************************/
        #region Other Functions

        #endregion
    }
}
