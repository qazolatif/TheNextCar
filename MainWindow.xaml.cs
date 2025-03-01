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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TheNextCar.Model;
using TheNextCar.Controller;

namespace TheNextCar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, OnDoorChanged, OnPowerChanged, OnCarEngineStatusChanged
    {
        private readonly Car nextCar;
        public MainWindow()
        {
            InitializeComponent();
            AccuBatteryController accuBatteryController = new AccuBatteryController(this);
            DoorController doorController = new DoorController(this);

            nextCar = new Car(accuBatteryController, doorController, this);
        }

        public void carEngineStatusChanged(string value, string message)
        {
            status.Content = message;
            StartButton.Content = value;
        }

        public void doorSecurityChanged(string value, string message)
        {
            LockDoorState.Content = message;
            LockDoorButton.Content = value;
        }

        public void doorStatusChanged(string value, string message)
        {
            DoorOpenState.Content = message;
            DoorOpenButton.Content = value;
        }

        public void onPowerChangedStatus(string value, string message)
        {
            AccuState.Content = message;
            AccuButton.Content = value;
        }

        private void OnAccuButtonClicked(object sender, RoutedEventArgs e)
        {
            nextCar.toggleThePowerButton();
        }

        private void OnDoorOpenButtonClicked(object sender, RoutedEventArgs e)
        {
            nextCar.toggleTheDoorButton();
        }

        private void OnLockDoorButtonClicked(object sender, RoutedEventArgs e)
        {
            nextCar.toggleTheLockedDoorButton();
        }

        private void OnStartButtonClicked(object sender, RoutedEventArgs e)
        {
            nextCar.toggleStartEngineButton();
        }

    }
}
