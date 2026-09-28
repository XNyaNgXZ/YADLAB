namespace YADLAB.Models
{
public abstract class WorkMachine : PersonalComputer
    {
   protected WorkMachine(string name, Processor processor, int ramGb, string operatingSystem)
            : base(name, processor, ramGb, operatingSystem)
        {
        }
        public abstract string MachineType { get; }
        public abstract string Purpose { get; }
        public override string ToString() => $"{MachineType} - {base.ToString()}";
    }
}
