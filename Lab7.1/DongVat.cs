using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongVat.AnCo
{
    public class Bo
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; }

        public Bo(string id, string name, float weight)
        {
            ID = id;
            Name = name;
            Weight = weight;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Bo - ID: {ID}, Name: {Name}, Weight: {Weight}kg");
        }
    }

    public class Trau
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; }

        public Trau(string id, string name, float weight)
        {
            ID = id;
            Name = name;
            Weight = weight;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Trau - ID: {ID}, Name: {Name}, Weight: {Weight}kg");
        }
    }

    public class De
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; }

        public De(string id, string name, float weight)
        {
            ID = id;
            Name = name;
            Weight = weight;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"De - ID: {ID}, Name: {Name}, Weight: {Weight}kg");
        }
    }
}

namespace DongVat.AnThit
{
    public class CaSau
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; }

        public CaSau(string id, string name, float weight)
        {
            ID = id;
            Name = name;
            Weight = weight;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"CaSau - ID: {ID}, Name: {Name}, Weight: {Weight}kg");
        }
    }

    public class Ho
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; }

        public Ho(string id, string name, float weight)
        {
            ID = id;
            Name = name;
            Weight = weight;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Ho - ID: {ID}, Name: {Name}, Weight: {Weight}kg");
        }
    }

    public class SuTu
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; }

        public SuTu(string id, string name, float weight)
        {
            ID = id;
            Name = name;
            Weight = weight;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"SuTu - ID: {ID}, Name: {Name}, Weight: {Weight}kg");
        }
    }
}


