using System;
using System.Collections;
using System.IO;

namespace solution1
{
    class Program
    {
        /*
            * list for mens single's
            * list for womens single's
            * list for men's double's
            * list for women's double's
            * list for mixed double's
            */


        private ArrayList menSingle = new ArrayList();
        private ArrayList menDouble = new ArrayList();
        private ArrayList womenSingle = new ArrayList();
        private ArrayList womenDouble = new ArrayList();
        private ArrayList mixedDouble = new ArrayList();

        static void Main(string[] args)
        {
            Program p = new Program();

            p.addParticipent();

        }
        public void addParticipent()
        {
            ArrayList names = new ArrayList();
            string name;
            string gender;
            string eventtype ;
      
            Console.WriteLine("***********************Welcome to the tennis club******************");
            do
            {
                Console.WriteLine("Enter Name");
                name = Console.ReadLine();
                Console.WriteLine("Enter Gender");
                gender = Console.ReadLine();
                Options(gender);
                eventtype = Console.ReadLine();
                groupParticipants(eventtype, gender, name);
            } while (!eventtype.Equals("x", StringComparison.InvariantCultureIgnoreCase));

            PairParcitipants();
            Console.WriteLine("nothing");


        }
        public void Options(string gender)
        {
                switch (gender)
                {
                    case "m":
                        Console.WriteLine("A) mens singles");
                        Console.WriteLine("B). mens double's");
                        break;
                    case "f":
                        Console.WriteLine("A). womens singles");
                        Console.WriteLine("B). womens double's");
                        break;
                default:
                    Console.WriteLine("invalid gender");
                    break;


                }
                Console.WriteLine("C). mixed double's");
                Console.WriteLine("X). to quite");
         
        }
        public void groupParticipants(string eventType,string gender,string name)
        {


            switch(eventType.ToLower())
            {
                case "a":
                    if (gender.Equals("m", StringComparison.InvariantCultureIgnoreCase))
                        menSingle.Add(name);
                    else
                        womenSingle.Add(name);
                    break;
                case "b":
                    if (gender.Equals("m", StringComparison.InvariantCultureIgnoreCase))
                        menDouble.Add(name);
                    else
                        womenDouble.Add(name);
                    break;
                case "c":
                    mixedDouble.Add(name);
                    break;
                    
            }
           


        }
        public void PairParcitipants()
        {
           if(menSingle.Count > 1)
            {
                for(int i = 0; i < menSingle.Count; i ++)
                {
                    if (i + 1 < menSingle.Count)
                        Console.WriteLine("**** "+menSingle[i] + " vs " + menSingle[i + 1] +" ****+ "+ "in mens singles");

                }
            }
            if (womenSingle.Count > 1)
            {
                for (int i = 0; i < womenSingle.Count; i++)
                {
                    if (i + 1 < womenSingle.Count)
                        Console.WriteLine("**** " +menSingle[i] + " vs " + womenSingle[i + 1] +" ****+ " +"in womens singles");

                }
            }
            if (menDouble.Count > 1)
            {
                for (int i = 0; i < menDouble.Count; i++)
                {
                    if (i + 1 < menDouble.Count)
                        Console.WriteLine(" **** "+menDouble[i] + " vs " + menDouble[i + 1] +" ****+ " +"in mens double's");

                }
            }
            if (womenDouble.Count > 1)
            {
                for (int i = 0; i < womenDouble.Count; i++)
                {
                    if (i + 1 < womenDouble.Count)
                        Console.WriteLine(" **** " +womenDouble[i] + " vs " + womenDouble[i + 1] +" ****+ " +"in womens double's");

                }
            }
            if (mixedDouble.Count > 1)
            {
                for (int i = 0; i < mixedDouble.Count; i++)
                {
                    if (i + 1 < mixedDouble.Count)
                        Console.WriteLine(" **** "+mixedDouble[i] + " vs " + mixedDouble[i + 1]+" ***** " + "in mixed double's");

                }
            }


        }
     
    }
}
