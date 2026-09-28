namespace YADLAB.Models
{
public interface IPowerControl
    {
        PowerState State { get; }

        string PowerOn();
        string PowerOff();
        string Restart();
    }
}
