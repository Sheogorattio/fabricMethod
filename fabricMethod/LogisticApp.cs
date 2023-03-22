using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabricMethod
{
    abstract public class LogisticApp
    {
        abstract public Transport CreateTransprot();
    }

    public class RoadLogistics : LogisticApp
    {
        public override Transport CreateTransprot()
        {
            return new Lorry();
        }
    }
    public class AirLogistics : LogisticApp
    {
        public override Transport CreateTransprot()
        {
            return new Airplane();
        }
    }
    public class SeaLogistics : LogisticApp
    {
        public override Transport CreateTransprot()
        {
            return new Ship();
        }
    }

    public interface ITransport
    {
        double FuelUsage();
        double DeliveryPrice();
        double Distance();
        void Deliver();
    }

    abstract public class Transport : ITransport
    {
        public double FUsage { get; set; }
        public double DelPrice { get; set; }
        public double Dist {get;set;}
        abstract public void Deliver();

        public double DeliveryPrice()
        {
            return DelPrice;
        }

        public double Distance()
        {
            return Dist;
        }

        public double FuelUsage()
        {
            return FUsage;
        }
        public Transport() { }
        public Transport(double usage, double price, double dist) 
        {
            FUsage = usage;
            Dist = dist;
            DelPrice = price;
        }
    }
    public class Lorry : Transport
    {
        public override void Deliver()
        {
            Console.WriteLine("Lorry delivery");
        }
    }
    public class Ship : Transport
    {
        public override void Deliver()
        {
            Console.WriteLine("Ship delivery");
        }
    }

    public class Airplane : Transport
    {
        public override void Deliver()
        {
            Console.WriteLine("Airplane delivery");
        }
    }
}
