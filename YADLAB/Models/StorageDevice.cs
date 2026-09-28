namespace YADLAB.Models
{
    public class StorageDevice
    {
        public string Type { get; set; }
        public int CapacityGb { get; set; }

        public StorageDevice(string type, int capacityGb)
        {
            Type = type;
            CapacityGb = capacityGb;
        }

        public override string ToString() => $"{Type} {CapacityGb} Гб";
    }
}
