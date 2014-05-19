namespace _09AndAbove
{
    public class Group
    {
        public Group()
        {
        }
        public Group(string departmentName)
        {
            this.DepartmentName = departmentName;
        }
        public int GroupNumber { get; set; }
        public string DepartmentName { get; set; }
    }
}
