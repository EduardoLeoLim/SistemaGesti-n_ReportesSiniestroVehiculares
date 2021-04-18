﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DelegacionMunicipal.Conductores
{
    /// <summary>
    /// Lógica de interacción para FormConductor.xaml
    /// </summary>
    public partial class FormConductor : Window
    {
        public FormConductor()
        {
            InitializeComponent();
        }

        private void btn_RegistrarConductor_Click(object sender, RoutedEventArgs e)
        {
            //
            this.DialogResult = true;
            this.Close();
        }

        private void btn_CancelarRegistro_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
