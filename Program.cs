namespace OOPBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std1=new Student(1,"Mohammed","A","1020"); // creating a bjects
            //std1.id = 1;
            //std1.name = "Mohammed";
            //std1.grade = "A";

            //Console.WriteLine("Std1 Details "); 
            //Console.WriteLine("Name : "+ std1.name);//printing  objects
            //Console.WriteLine("Grade :"+ std1.grade);
            //std1.stusy(); // calling the method which show what object can do 

            Student std2 = new Student(2, "Umran","A+","1090"); // creating a bjects
            //std2.id = 123;
            //std2.name = "Omran";
            //std2.grade = "A+";
            //std2.name = "test";

            Console.WriteLine("Std2 Details ");
            Console.WriteLine("Name : " + std2.name);//printing  objects
            Console.WriteLine("Grade :" + std2.grade);
            std2.stusy(); // calling the method which show what object can do 
        }
    }
}