using System;
namespace program
{
    
    class Book
    {
        string title;
        string author;
        int publicationyear;
        public void getdata(string title,string author,int publicationyear)
        {
            this.title = title;
            this.author = author;
            this.publicationyear=publicationyear;
        }
        public void displaydata()
        {
            Console.WriteLine("title" + title);
            Console.WriteLine("author" + author);
            Console.WriteLine("title" + publicationyear);

        }
    }
    class program
    {
        public static void Main(string[]args)
        {
            Book[] b1 = new Book[3];
            b1[0] = new Book();
            b1[1] = new Book();
            b1[2] = new Book();
            string author = null;
            string title = null;
            int publicationyear = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter author=");
                string aut = Console.ReadLine();
                Console.WriteLine("enter title=");
                string tit = Console.ReadLine();
                Console.WriteLine("enter year=");
                int py = Convert.ToInt32(Console.ReadLine());

                b1[i].getdata(aut, tit, py);
                

            }
            for(int i=0;i<3;i++)
            {
                b1[i].displaydata();
            }
            Console.ReadKey();

        }
    }
}