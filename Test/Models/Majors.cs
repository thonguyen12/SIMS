﻿namespace Test.Models
{
    public class Majors
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public Departments Department { get; set; }
    }
}
