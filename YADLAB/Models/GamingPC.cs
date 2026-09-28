namespace YADLAB.Models
{
    public class GamingPC : WorkMachine
    {
        public GamingPC(string name, Processor processor, int ramGb, string videoCard, int monitorHz)
            : base(name, processor, ramGb, "Windows 11 Pro")
        {
            VideoCard = videoCard;
            MonitorHz = monitorHz;
        }
        public int MonitorHz { get; set; }
        public override string MachineType => "Игровой ПК";
        public override string Purpose => "Игры и работа с графикой";
    }
}
