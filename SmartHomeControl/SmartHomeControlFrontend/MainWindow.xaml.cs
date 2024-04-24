﻿using SmartHomeControl;
using SmartHomeControl.Models;
using SmartHomeControlFrontend.Dialogs;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SmartHomeControlFrontend
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(Properties.Settings.Default.ClientName))
            {
                Properties.Settings.Default.ClientName = Guid.NewGuid().ToString();
                Properties.Settings.Default.Save();
            }
        }

        private async void ell_closeWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            await Task.Delay(200);
            Environment.Exit(0);
        }

        private void txt_windowTitle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(Mouse.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btn_settings_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void btn_triggerAlarm_Click(object sender, RoutedEventArgs e)
        {
            ToggleAlarmDialog toggleAlarmDialog = new ToggleAlarmDialog();
            toggleAlarmDialog.ShowDialog();
            if (toggleAlarmDialog.Result)
            {
                MqttConnection.Instance.PublishMessage(new MqttMessage("ESP8266_ALARMSYSTEM alarm", "SmartHome/AlarmSystem"));
            }
        }

        private void btn_alarmLightToggle_Click(object sender, RoutedEventArgs e)
        {
            MqttConnection.Instance.PublishMessage(new MqttMessage("ESP8266_ALARMSYSTEM lamp", "SmartHome/AlarmSystem"));
        }

        private void btn_toggleLightLamp_Click(object sender, RoutedEventArgs e)
        {
            MqttConnection.Instance.PublishMessage(new MqttMessage("ESP8266_LEDREMOTE lamp", "SmartHome/SingleLed"));
        }

        private async void btn_connectToBroker_Click(object sender, RoutedEventArgs e)
        {
                ConnectingIndicator indicator = new ConnectingIndicator();
                indicator.Show();
            try
            {
                MqttConnection.Instance.SetBrokerAddress(Properties.Settings.Default.BrokerAddress);
                MqttConnection.Instance.SetBrokerPort(Properties.Settings.Default.BrokerPort);
                MqttConnection.Instance.SetClientId("PC_L33L");

                await MqttConnection.Instance.InitializeMqttClient();

                string subscribeTopic = Properties.Settings.Default.SubscribeTopic;

                if (!string.IsNullOrEmpty(subscribeTopic))
                {
                    MqttConnection.Instance.SetSubscrbeTopic(Properties.Settings.Default.SubscribeTopic);
                    MqttConnection.Instance.Subscribe(subscribeTopic);
                }
                bool isConnected = MqttConnection.Instance.mqttClientIsConnected();

                if (isConnected) indicator.CloseWindow();
                btn_disconnectToBroker.Visibility = Visibility.Visible;
                btn_connectToBroker.Visibility = Visibility.Collapsed;

                if(isConnected)
                {
                    PopUpDialog popUpDialog = new PopUpDialog("Verbindung zum Broker hergestellt", "Erfolg", PopUpDialog.PopUpDialogKind.Information);
                    popUpDialog.ShowDialog();
                }
                else
                {
                    PopUpDialog popUpDialog = new PopUpDialog("Verbindung zum Broker konnte nicht hergestellt werden", "Fehler", PopUpDialog.PopUpDialogKind.Error);
                    popUpDialog.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                indicator.CloseWindow();
                await Task.Delay(150);
                PopUpDialog popUpDialog = new PopUpDialog(ex.Message, "Fehler", PopUpDialog.PopUpDialogKind.Error);
                popUpDialog.ShowDialog(); 
            }
        }

        private void btn_disconnectToBroker_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PopUpDialog popUpDialog = new PopUpDialog("Soll die Verbindung zum MQTT-Broker wirklich getrennt werden?", "Verbindung trennen", PopUpDialog.PopUpDialogKind.Question);
                popUpDialog.ShowDialog();
                if(popUpDialog.Result)
                {
                    MqttConnection.Instance.Disconnect();
                    btn_disconnectToBroker.Visibility = Visibility.Collapsed;
                    btn_connectToBroker.Visibility = Visibility.Visible;
                }
            }
            catch (Exception ex)
            {
                PopUpDialog popUpDialog = new PopUpDialog(ex.Message, "Fehler", PopUpDialog.PopUpDialogKind.Error);
                popUpDialog.ShowDialog();
            }
        }
    }
}
