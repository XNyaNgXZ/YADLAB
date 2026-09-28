using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YADLAB.Models;

namespace YADLAB.Pages
{
    public class IndexModel : PageModel
    {
        public PersonalComputer Computer { get; set; } = null;
        public List<string> Messages { get; set; } = new();
        public List<WorkMachine> Machines { get; set; } = new();

        public void OnGet()
        {
            Computer = new PersonalComputer("HOME-PC", new Processor("AMD Ryzen 7600", 6, 3.8), 32, "Windows 11 Pro");
            Computer.VideoCard = "NVIDIA GeForce RTX 4060";
            Computer.Storages.Add(new StorageDevice("SSD", 1000));
            Computer.Storages.Add(new StorageDevice("HDD", 2000));

            Messages.Add(Computer.PowerOn());
            Messages.Add(Computer.Restart());

            Machines.Add(new Office("OFFICE-01", new Processor("Intel Core i3-12100", 4, 3.3), 8, "Microsoft Office"));
            Machines.Add(new Server("SRV-01", new Processor("Intel Xeon Silver 4314", 16, 2.4), 128, 2));
            Machines.Add(new Laptop("LAPTOP-01", new Processor("Intel Core i5-1335U", 10, 1.3), 16, 0));
            Machines.Add(new GamingPC("GAME-01", new Processor("Intel Core i7-14700K", 20, 3.4), 32, "RTX 4070", 165));

            foreach (var machine in Machines)
            {
                Messages.Add(machine.PowerOn());
            }
        }
    }
}
