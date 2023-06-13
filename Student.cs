

namespace OOPBasics
{
     class Student
    {
       public long id;// properties
       public string name;
       public string grade;
       public string regestrationNumber;
       public Student(long id, string name, string regestrationNumber) // constructore same name as class and it intialise proberties
        {
            this.id = id;//this return to class properties
            this.name = name;
            this.regestrationNumber = regestrationNumber;
            printStuentDetails();

        }
        public void stusy()// method
        {
            Console.WriteLine("studyint "+name+" is studying : ");
        }

        void printStuentDetails()
        {
            Console.WriteLine("Name : "+this.name+" Registration number : "+this.regestrationNumber);
        }
    }
}
