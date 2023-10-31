using System;
using System.Formats.Asn1;

namespace Program
{
    class rectangle
    {
        int rectangle_width;
        int rectangle_height;
        float area;
        public void getdata(int rectangle_width,int rectangle_height)
        {
            this.rectangle_width = rectangle_width;
            this.rectangle_height = rectangle_height;
             area = rectangle_width * rectangle_height;
        }
        public void displaydata()
        {
            Console.WriteLine("area of rectangle" +area);
            

        }
    }
    class program
    {
        public static void Main(string[]args)
        {
            rectangle rect = new rectangle();
            
            rect.getdata(5,10);
            rect.displaydata();

            
            Console.ReadKey();
        }
    }
}