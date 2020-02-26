using System;

/*
 * Efektivita
 * Prehlednost
 * Navrh
 * Samodokumentovaci
 */
namespace GamePhysics {

    public struct MetersPerSecond
    {
        public double value;

        public override string ToString()
        {
            return $"{value.ToString()} m/s";
        }
    }

    public struct Meters
    {
        public double value;

        public static MetersPerSecond operator /(Meters m, Seconds s)
        {
            double v = m.value / s.value;
            return new MetersPerSecond() { value = v };
        }
    }

    public struct Seconds
    {
        public double value;
    }

    public static class IntExtensions
    {
        public static Seconds Seconds(this int value)
        {
            return new Seconds() { value = value };
        }
        public static Meters Meters(this int value)
        {
            return new Meters() { value = value };
        }
    }

    class Program {
		static void Main(string[] args) {
			var distance = 2.Meters();
			var time = 3.Seconds();
			var speed = distance / time;
			Console.WriteLine($"Speed: {speed}");
		}
	}
}
