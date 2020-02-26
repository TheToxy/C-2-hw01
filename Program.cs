using System;

/*
 * Efektivita
 * Prehlednost
 * Navrh
 * Samodokumentovaci
 */
namespace GamePhysics
{

    public struct MetersPerSecond
    {
        public double Value { get; set; }
        public override string ToString() => $"{Value.ToString()} m/s";
    }

    public struct Meters
    {
        public double Value { get; set; }
        public static MetersPerSecond operator /(Meters m, Seconds s) => new MetersPerSecond { Value = m.Value / s.Value };
    }

    public struct Seconds
    {
        public double Value { get; set; }
    }

    public static class IntExtensions
    {
        public static Seconds Seconds(this int value) => new Seconds { Value = value };
        public static Meters Meters(this int value) => new Meters { Value = value };
    }

    class Program
    {
        static void Main(string[] args)
        {
            var distance = 2.Meters();
            var time = 3.Seconds();
            var speed = distance / time;
            Console.WriteLine($"Speed: {speed}");
        }
    }
}
