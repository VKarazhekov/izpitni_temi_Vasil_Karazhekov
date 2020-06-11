namespace Izpitna_tema_4_OOP
{
    internal class Citizen
    {
        private string name;
        private int age;
        public string ID { get; internal set; }

        public Citizen(string name, string id, int age)
        {
            this.name = name;
            this.ID = id;
            this.age = age;
        }

    }
}