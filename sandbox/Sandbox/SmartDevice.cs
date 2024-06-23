using System.Net.Security;

class SmartDevice
{
    private string deviceName;
    private bool isOn;

    public SmartDevice(string deviceName)
    {
        this.deviceName = deviceName;
    }
    public virtual bool TurnOnOff(string powerState)
    {
          
        if (powerState.ToLower() == "on" )
        {
            return isOn = true;
        }
        else if (powerState.ToLower() == "off")
        {
            return isOn = false;
        }
        else
        {
            return isOn = isOn;
        }
    }
    
}