using System;
using System.Collections;
using System.Collections.Generic;

namespace MckinneyStoreRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mySection = new Dictionary<string, int>();

            Rack inventory = new Rack();

            Rack myRacks1 = new Rack();
            myRacks1.RackNumber = "1";
            mySection["A001"] = 1;
            inventory.AddToRack(myRacks1);

            Rack myRacks2 = new Rack();
            myRacks2.RackNumber = "2";
            mySection["B002"] = 2;
            inventory.AddToRack(myRacks2);

            Rack myRacks3 = new Rack();
            myRacks3.RackNumber = "3";
            mySection["C003"] = 3;
            inventory.AddToRack(myRacks3);

            Rack myRacks4 = new Rack();
            myRacks4.RackNumber = "4";
            mySection["D004"] = 4;
            inventory.AddToRack(myRacks4);

            Rack myRacks5 = new Rack();
            myRacks5.RackNumber = "5";
            mySection["E005"] = 5;
            inventory.AddToRack(myRacks5);

            Rack myRacks6 = new Rack();
            myRacks6.RackNumber = "6";
            mySection["F006"] = 6;
            inventory.AddToRack(myRacks6);

            Rack myRacks7 = new Rack();
            myRacks7.RackNumber = "7";
            mySection["G007"] = 7;
            inventory.AddToRack(myRacks7);
            
            Rack myRacks8 = new Rack();
            myRacks8.RackNumber = "8";
            mySection["H008"] = 8;
            inventory.AddToRack(myRacks8);

            Rack myRacks9 = new Rack();
            myRacks9.RackNumber = "9";
            mySection["I009"] = 9;
            inventory.AddToRack(myRacks9);

            Rack myRacks10 = new Rack();
            myRacks9.RackNumber = "10";
            mySection["J010"] = 10;
            inventory.AddToRack(myRacks10);

            Rack myRacks11 = new Rack();
            myRacks9.RackNumber = "11";
            mySection["K011"] = 11;
            inventory.AddToRack(myRacks11);

            Rack myRacks12 = new Rack();
            myRacks12.RackNumber = "12";
            mySection["L012"] = 12;
            inventory.AddToRack(myRacks12);

            Rack myRacks13 = new Rack();
            myRacks13.RackNumber = "13";
            mySection["M013"] = 13;
            inventory.AddToRack(myRacks13);

            Rack myRacks14 = new Rack();
            myRacks14.RackNumber = "14";
            mySection["N014"] = 14;
            inventory.AddToRack(myRacks14);

            Rack myRacks15 = new Rack();
            myRacks15.RackNumber = "15";
            mySection["O015"] = 15;
            inventory.AddToRack(myRacks15);

            Rack myRacks16 = new Rack();
            myRacks16.RackNumber = "16";
            mySection["P016"] = 16;
            inventory.AddToRack(myRacks16);

            Rack myRacks17 = new Rack();
            myRacks17.RackNumber = "17";
            mySection["Q017"] = 17;
            inventory.AddToRack(myRacks17);

            Rack myRacks18 = new Rack();
            myRacks18.RackNumber = "18";
            mySection["R018"] = 18;
            inventory.AddToRack(myRacks18);

            Rack myRacks19 = new Rack();
            myRacks9.RackNumber = "19";
            mySection["S019"] = 19;
            inventory.AddToRack(myRacks19);

            Rack myRacks20 = new Rack();
            myRacks20.RackNumber = "20";
            mySection["T020"] = 20;
            inventory.AddToRack(myRacks20);


            foreach(var item in mySection)
            {
                Console.WriteLine("The item I have on {0} key, has" +
                                         " the value of: RackNumer[{1}]" +
                                                  " and type[{2}]",
                                                     item.Key, item.Value);
                                                    
                                        

            }

            myRacks20.ShowRack();

                

        }
    }
}
public class Rack
{
    Dictionary<int, Rack> Section = new Dictionary<int, Rack>();

    public string RackNumber { get; set; }
    


    public void AddToRack(Rack newRack)
    {
        int count = Section.Count;

        bool doesItExist = Section.ContainsKey(count);

        if (doesItExist)
        {
            Section.Add(count, newRack);
        }

    }
    public void ShowRack()
    {
        Console.WriteLine("The racks are has: ");
        foreach(var Section in RackNumber)
        {
            Console.WriteLine(Section);

        }
        
    }

}

