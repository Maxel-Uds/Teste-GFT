namespace exercicio1.Entities
{
    public class Atleta
    {
        public string Name { get;  set; }
        public string Country { get;  set; }
        public int Distance { get;  set; }

        public Atleta(string name, string country, int distance) {
            Name = name;
            Country = country;
            Distance = distance;
        }

        public int getDistance() {
            return Distance;
        }

        public override string ToString()
        {
            return Name + " - " + Country + " Resultado " + Distance;
        }
    }
}