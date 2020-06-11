namespace Izpitna_tema_4_OOP
{
    internal class Robot
    {
        private string model;
        public string ID { get; internal set; }

        public Robot(string model, string id)
        {
            this.model = model;
            this.ID = id;
        }
    }
}