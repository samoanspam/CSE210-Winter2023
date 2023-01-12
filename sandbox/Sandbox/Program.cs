using System;


class Person
{
    public string name;
    string birth;
    string gender;
    List<string> names;

    public string GetGender()
    {
        return this.gender;
    }
}

class Program
{
    static void Main(string[] args)
    {

        Person fred = new Person();
        fred.name = "Fred";
        System.Console.WriteLine(fred.GetGender());

        List<string> items = new List<string>();
        List<float> prices = new List<float>();

        bool done = false;
        while (!done)
        {
            DisplayMenu();
            int choice = GetChoice();

            // switch (choice)
            // {
            //     case 1:
            //         AddItem(items, prices);
            //         break;
            //     case 2:
            //         Display(items, prices);
            //         break;
            //     case 5:
            //         done = false;
            //         break;
            // }
            // if (choice == 1)

            {
                AddItem(items, prices);
            }

            if (choice == 2)
            {
                Display(items, prices);
            }

            if (choice == 5)
            {
                done = true;
            }
        }
    }

    static void DisplayMenu()
    {
        System.Console.WriteLine("1) Add Item");
        System.Console.WriteLine("2) ADisplay");
        System.Console.WriteLine("3) Total");
        System.Console.WriteLine("4) Remove");
        System.Console.WriteLine("5) Quit");
    }

    static int GetChoice()
    {
        System.Console.Write("Enter Choice: ");
        string choice = Console.ReadLine();
        int answer = int.Parse(choice);
        return answer;
    }
    static void AddItem(List<string> items, List<float> prices)
    {
        System.Console.Write("Enter Item: ");
        string item = Console.ReadLine();

        System.Console.Write("Enter Item: ");
        string price = Console.ReadLine();
        float priceAmount = float.Parse(price);

        items.Add(item);
        prices.Add(priceAmount);
    }

    static void Display(List<string> items, List<float> prices)
    {
        System.Console.WriteLine("DISPLAY ITEMS");
        for (int i = 0; i < items.Count; i++)
            {
                System.Console.WriteLine($"{items[i]}: price{prices[i]}");
            }
        System.Console.WriteLine("");
    }

}