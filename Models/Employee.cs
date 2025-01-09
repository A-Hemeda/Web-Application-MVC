namespace WebApplication1
{
    public class Employee
    {
        public int Id { get; set; }
        public string name { get; set; }

        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Emp_Id :{Id} , Emp_Name : {name} ,Salary : {Salary:c}";
        }

    }
}
