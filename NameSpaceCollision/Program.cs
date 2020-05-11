extern alias Service1;
extern alias Service2;

using System;
//using Service1PatientDBContext = Service1.DataServiceFactory.DataContext.PatientDataContext;
//using Service2PatientDBContext = Service2.DataServiceFactory.DataContext.PatientDataContext;

namespace NameSpaceCollision
{
    class Program
    {
        static void Main(string[] args)
        {
            var object1 = new Service1.DataServiceFactory.DataContext.PatientDataContext();
            var object2 = new Service2.DataServiceFactory.DataContext.PatientDataContext();

            // OR if you don't like the above fully qualified namespace 
            // then you can create an alias of namespace as shown in below commented code.
            // Uncomment it to see it working.

            //var object1 = new Service1PatientDBContext();
            //var object2 = new Service2PatientDBContext();

            Console.WriteLine(object1);
            Console.WriteLine(object2);
            Console.ReadLine();
        }
    }
}
