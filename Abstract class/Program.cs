using System;
namespace Abstract_class
{
    class Person
    {
        public string Work { get; set; }
    }
    class Madina
    {
        public virtual void N()
        {
            Console.WriteLine("Hello");
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; }
    }
    class TomHanks
    {
       
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; }
    }
    abstract class Planets
    {
        abstract public string Name { get; set; }
        abstract public int Id { get; set; }
        abstract public int Radius { get; set; }
        abstract public int Satellite { get; set; }
        public abstract void Planet();
        public abstract int PlanetFeature();
        public virtual void Equador()
        {
            Console.WriteLine("I'm not");
        }
    }
    class PlanetSatellite : Planets
    {
        public override int Id { get ; set; }
        public override string Name { get ; set ; }
        public override int Radius { get; set ; }
        public override int Satellite { get; set; }

        public override void Planet()
        {

            /*int satellite = int.Parse(Console.ReadLine());
            switch (satellite)
            {
                case 0:
                    Console.WriteLine("Mercury" + "Venus" + "Uranus");
                case 1:
                    Console.WriteLine("Earth");
                case 2:
                    Console.WriteLine("Mars");
                case 5:
                    Console.WriteLine("Pluto");
                case 79:
                    Console.WriteLine("Jupiter");
                case 82:
                    Console.WriteLine("Saturn");
            }*/

              int radius = int.Parse(Console.ReadLine());
             if (radius == 696000) Console.WriteLine("Sun");
             else if (radius == 4879) Console.WriteLine("Mercury");
             else if (radius == 6051) Console.WriteLine("Venus");
             else if (radius == 6378) Console.WriteLine("Earth");
             else if (radius == 3396) Console.WriteLine("Mars");
             else if (radius == 7149) Console.WriteLine("Jupiter");
             else if (radius == 6026) Console.WriteLine("Saturn");
             else if (radius == 2555) Console.WriteLine("Uranus");
             else if (radius == 1356) Console.WriteLine("Neptun");
             else if (radius == 1153) Console.WriteLine("Pluto");
            
        }
        public override int PlanetFeature()
        {
            int count = 0;
            string[] planets = { "Sun", "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptun", "Pluto" };
            for (int i = 0; i < planets.Length; i++)
            {
                count++;
            }
            return count;
        }
       public  PlanetSatellite (string name,int id,int radius,int satellite)
        {
            Name = name;
            Id = id;
            Radius = radius;
            Satellite = satellite;

        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Planets m = new PlanetSatellite("Mars",1,3396,2);
            m.Planet();
            m.PlanetFeature();
            m.Id = 15;
            m.Name = "Medine";
            m.Equador();
            Console.WriteLine(m.Id);
            Console.WriteLine(m.Name);
            Console.WriteLine(m.Radius);
            Console.WriteLine(m.Satellite);
            
            
            Madina  t = new Madina();
            t.Name = "Madina";
            t.Surname = "Alizade";
            t.Id = 1;
            Console.WriteLine(t.Name);
            Console.WriteLine(t.Surname);
            Console.WriteLine(t.Id);
            TomHanks k = new TomHanks();
            k.Name = "Tom";
            k.Surname = "Hanks";
            k.Id = 10;
            Console.WriteLine(k.Name);
            Console.WriteLine(k.Surname);
            Console.WriteLine(k.Id);

            /*Person sum = new Person(t);
                Console.WriteLine(sum.Work);*/
        }
    }
}
