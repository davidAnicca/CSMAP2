namespace CSMAP.Entities
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string School { get; set; }

        public Student(int id, string name, string school)
        {
            this.Id = id;
            this.Name = name;
            this.School = school;
        }
    }

}