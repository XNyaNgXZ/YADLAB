namespace YADLAB.Models
{
    public class Server : WorkMachine
    {
        public Server(string name, Processor processor, int ramGb, int rackUnits)
            : base(name, processor, ramGb, "Ubuntu Server")
        {
            RackUnits = rackUnits;
        }
        public int RackUnits { get; set; }
        public override string MachineType => "Сервер";
        public override string Purpose => "Круглосуточная работа сайтов и баз данных";
        public override string PowerOn() => base.PowerOn() + ", службы запущены";
    }
}
