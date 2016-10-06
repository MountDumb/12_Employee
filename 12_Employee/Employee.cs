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

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is Employee)
            {
                Employee emp = obj as Employee;
                if (emp.Id != this.id || emp.Name != this.name || emp.Type != this.type)
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }




        public string Name
        {
            get { return name; }
            
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}