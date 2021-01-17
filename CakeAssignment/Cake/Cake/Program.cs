using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using CS_133_Projects.GenericClasses;


namespace CS_133_Projects

{
    class Program
    {
        static void Main(string[] args)
        {

            ILoveCake GenericClasses = new ILoveCake();

            

            List<ILoveCake> myObject = new List<ILoveCake>();

            ILoveCake firstCake = new ILoveCake();
            firstCake.Type = "Wedding";
            firstCake.Flavor = "Vanilla";

            ILoveCake secondCake = new ILoveCake();
            secondCake.Type = "Sweet 16";
            secondCake.Flavor = "Chocolate";

            
            

            myObject.Add(firstCake);
            myObject.Add(secondCake);


            ILoveCake myCakeObject = myObject.First();
            

     

            Console.WriteLine(myCakeObject.Type);
            Console.WriteLine(myCakeObject.Flavor);

           
            
         

        }

        
    }
}
