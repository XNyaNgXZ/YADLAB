namespace YADLAB.Models;

public class Processor
{
    public string Model { get; set; }
    public int Cores { get; set; }
    public double FrequencyGHz { get; set; }
    public Processor(string model, int cores, double frequencyGHz)
    {
        Model = model;
        Cores = cores;
        FrequencyGHz = frequencyGHz;
    }
    public override string ToString() => $"{Model}, {Cores} ядер, {FrequencyGHz} ГГц";
}