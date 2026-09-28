namespace YADLAB.Models
{
    public class Laptop : WorkMachine
    {
        public Laptop(string name, Processor processor, int ramGb, int batteryLevel)
            : base(name, processor, ramGb, "Windows 11 Home")
        {
            BatteryLevel = batteryLevel;
        }
        public int BatteryLevel { get; set; }
        public override string MachineType => "Ноутбук";
        public override string Purpose => "Работа в дороге";
        public override string PowerOn()
        {
            if (BatteryLevel == 0) return $"{Name}: батарея разряжена";
            return base.PowerOn();
        }
    }
}
