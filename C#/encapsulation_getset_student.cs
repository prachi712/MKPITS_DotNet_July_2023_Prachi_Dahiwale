using System;

    class student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    class program
    {
        static void Main(string[]args)
        {
            student Student=new student();
            Student.ID = "101";
            Student.Name = "prachi";
            Student.Email = "prachidahiwale0";
        Console.WriteLine("ID=" + Student.ID);
        Console.WriteLine("Name=" + Student.Name);
        Console.WriteLine("email=" + Student.Email);

    }
    }
    



