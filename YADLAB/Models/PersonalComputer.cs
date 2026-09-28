namespace YADLAB.Models;

public class PersonalComputer : IPowerControl
{
    private int _ramGb;

    public PersonalComputer(string name, Processor processor, int ramGb, string operatingSystem)
    {
        Name = name;
        Processor = processor;
        RamGb = ramGb;
        OperatingSystem = operatingSystem;
    }

    public string Name { get; set; }
    public Processor Processor { get; set; }
    public string VideoCard { get; set; } = "встроенная";
    public string OperatingSystem { get; set; }
    public List<StorageDevice> Storages { get; } = new();

    public int RamGb
    {
        get => _ramGb;
        set => _ramGb = value > 0 ? value : throw new ArgumentException("ОЗУ должно быть больше 0");
    }

    public int TotalStorageGb => Storages.Sum(s => s.CapacityGb);

    public PowerState State { get; private set; } = PowerState.Off;

    public virtual string PowerOn()
    {
        if (State == PowerState.On) return $"{Name} уже включён";
        State = PowerState.On;
        return $"{Name} включён, загружается {OperatingSystem}";
    }

    public virtual string PowerOff()
    {
        if (State == PowerState.Off) return $"{Name} уже выключен";
        State = PowerState.Off;
        return $"{Name} выключен";
    }

    public virtual string Restart()
    {
        if (State == PowerState.Off) return "Нельзя перезагрузить выключенный компьютер";
        PowerOff();
        PowerOn();
        return $"{Name} перезагружен";
    }

    public override string ToString() =>
        $"{Name}: {Processor}, ОЗУ {RamGb} ГБ, накопители {TotalStorageGb} ГБ, " +
        $"видеокарта {VideoCard}, ОС {OperatingSystem}";
}