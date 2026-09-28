namespace YADLAB.Models
{
    public class Office : WorkMachine
    {
        public Office(string name, Processor processor, int ramGb, string officeSuite) 
            : base(name, processor, ramGb, "Windows 11 Pro")
        {
            OfficeSuite = officeSuite;
        }
        public string OfficeSuite { get; set; }
        public override string MachineType => "Офисный ПК";
        public override string Purpose => "Работа с документами и почтой";
    }
}
