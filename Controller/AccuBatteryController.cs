using System;
using System.Collections.Generic;
using System.Text;
using TheNextCar.Model;

namespace TheNextCar.Controller
{
    class AccuBatteryController
    {
        private AccuBattery accubattery;
        private OnPowerChanged callBackOnPowerChanged;

        public AccuBatteryController(OnPowerChanged callBackOnPowerChanged)
        {
            this.accubattery = new AccuBattery(12);
            this.callBackOnPowerChanged = callBackOnPowerChanged;
        }

        public bool accubatteryIsOn()
        {
            return this.accubattery.isOn();
        }

        public void turnOn()
        {
            this.accubattery.turnOn();
            this.callBackOnPowerChanged.onPowerChangedStatus("ON", "Power is on");
        }

        public void turnOff()
        {
            this.accubattery.turnOff();
            this.callBackOnPowerChanged.onPowerChangedStatus("OFF", "Power is off");
        }
    }

    interface OnPowerChanged
    {
        void onPowerChangedStatus(string value, string message);
    }
}
