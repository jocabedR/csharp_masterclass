using System;

class RemoteControlCar
{
    private int _battery = 100;
    private int _meters = 0;

    public static RemoteControlCar Buy()
    {
        var car = new RemoteControlCar();
        return car;
    }

    public string DistanceDisplay()
    {
        return String.Format("Driven {0} meters", this._meters);
    }

    public string BatteryDisplay()
    {
        if (_battery == 0) return "Battery empty";
        return String.Format("Battery at {0}%", this._battery);
    }

    public void Drive()
    {
        if (!BatteryDisplay().Equals("Battery empty")) {
            this._battery --;
            this._meters += 20;
        }
    }
}
