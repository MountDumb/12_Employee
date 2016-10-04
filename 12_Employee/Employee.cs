namespace _12_Employee
{
    public class Employee
    {
        private string name;
        private string type;
        private long id;

        public Employee(string name, string position)
        {
            this.name = name;
            this.type = position;
            
        }

        public Employee(string name, string position,long id)
        {
            this.name = name;
            this.type = position;
            this.id = id;

        }




        public string Name
        {
            get { return name; }
            
        }

        public string Type
        {
            get { return type; }
        }

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}