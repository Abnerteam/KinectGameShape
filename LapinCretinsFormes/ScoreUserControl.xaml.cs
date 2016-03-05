﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LapinCretinsFormes
{
    /// <summary>
    /// Logique d'interaction pour ScoreUserControl.xaml
    /// </summary>
    public partial class ScoreUserControl : UserControl
    {
        private MainWindow windowContainer;
        private BitmapSource backgroundPicture;

        public ScoreUserControl(MainWindow container, BitmapSource picture, string score, string pourcentage)
        {
            InitializeComponent();
            windowContainer = container;
            PictureTakenBackgroundImage.ImageSource = picture;
            backgroundPicture = picture;
            ScoreText.Text = score;
        }

        public void NextButtonClick(object sender, RoutedEventArgs e)
        {
            windowContainer.LoadContent(new EmailInputUserControl(windowContainer, backgroundPicture));
        }
    }
}
