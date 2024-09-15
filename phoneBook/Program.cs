using System.Diagnostics.Eventing.Reader;

string[][] contacts = new string[3][];

contacts[0] = new string[] { "1", "Roya", "Abbasova", "+994xxxxxxxxx" };
contacts[1] = new string[] { "2", "Mirvari", "Muradova", "+994xxxxxxxxx" };
contacts[2] = new string[] { "3", "Zehra", "Melikzade", "+994xxxxxxxxx" };

int contID = 3;


repeat:

Console.Clear();
Console.Write("Show all Contacts: 1 \n" +
                  "Add Contact: 2 \n" +
                  "Delete Contact: 3 \n" +
                  "Search Contact: 4 \n" +
                  "Edit Contact: 5 \n" +
                  "Exit: 6 \n" +
                  "Select the operation number: ");

int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
{
    Console.Clear();

    for (int i = 0; i < contacts.Length; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (contacts[i][j] != null)
            {
                if (j == 0)
                {
                    Console.WriteLine("\nId: " + contacts[i][0]);
                }
                if (j == 1)
                {
                    Console.WriteLine("Name: " + contacts[i][1]);
                }
                if (j == 2)
                {
                    Console.WriteLine("Surname: " + contacts[i][2]);
                }
                if (j == 3)
                {
                    Console.WriteLine("Number: " + contacts[i][3]);
                }
            }
        }
    }

    Console.WriteLine("Do you want to continue? Yes or Not");

    string select = Console.ReadLine();

    if (select == "yes")
    {
        goto repeat;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Goodbye");

        Environment.Exit(0);
    }
}


else if (num == 2)
{
    Console.Clear();

    Console.WriteLine("Please enter  Name, Surname and Number of a new contact");
    Array.Resize(ref contacts, contacts.Length + 1);

    contID++;
    string newId = contID.ToString();

    Console.Write("Name: ");
    string newName = Console.ReadLine();

    Console.Write("Surname: ");
    string newSurname = Console.ReadLine();

    Console.Write("Number: ");
    string newNumber = Console.ReadLine();

    string[] newAdd = new string[] { newId, newName, newSurname, newNumber };

    contacts[contacts.Length - 1] = newAdd;

    Console.WriteLine("Do you want to continue? Yes or Not");

    string select = Console.ReadLine();

    if (select == "yes")
    {
        goto repeat;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Goodbye");

        Environment.Exit(0);
    }
}


else if (num == 3)
{
    Console.Clear();

    for (int i = 0; i < contacts.Length; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (j == 0)
            {
                Console.WriteLine("Id: " + contacts[i][j]);
            }
            if (j == 1)
            {
                Console.WriteLine("Name: " + contacts[i][j]);
            }
            if (j == 2)
            {
                Console.WriteLine("Surname: " + contacts[i][j]);
            }
            if (j == 3)
            {
                Console.WriteLine("Number: " + contacts[i][j]);
            }
        }
    }

    Console.Write("Enter the name of the contact you want to delete: ");

    string delName = Console.ReadLine();

    for (int i = 0; i < contacts.Length; i++)
    {
        if (contacts[i][1].Equals(delName))
        {
            for (int j = 0; j < contacts[i].Length; j++)
            {
                contacts[i][j] = null;
            }
        }
    }

    Console.WriteLine("Do you want to continue? Yes or Not");

    string select = Console.ReadLine();

    if (select == "yes")
    {
        goto repeat;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Goodbye");

        Environment.Exit(0);
    }
}


else if (num == 4)
{
repeat2:
    Console.Clear();
    Console.WriteLine("Which properties do you want to search?\n" +
                      "Name\n" +
                      "Number");

    string searchbyProperties = Console.ReadLine();

    if (searchbyProperties == "name")
    {
        repeatName:
        Console.WriteLine("Please include " + searchbyProperties);
        string propContact = Console.ReadLine();

        for (int i = 0; i < contacts.Length; i++)
        {
            if (contacts[i][1] == propContact)
            {
                for (int j = 0; j < contacts[i].Length; j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine("\nId: " + contacts[i][0]);
                    }
                    if (j == 1)
                    {
                        Console.WriteLine("Name: " + contacts[i][1]);
                    }
                    if (j == 2)
                    {
                        Console.WriteLine("Surname: " + contacts[i][2]);
                    }
                    if (j == 3)
                    {
                        Console.WriteLine("Number: " + contacts[i][3]);
                    }
                }
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Contact can not find");

                goto repeatName;
            }
        }
    }

    else if (searchbyProperties == "number")
    {
        repeatPhone:
        Console.WriteLine("Please include " + searchbyProperties);
        string propContact = Console.ReadLine();

        for (int i = 0; i < contacts.Length; i++)
        {
            if (contacts[i][2] == propContact)
            {
                for (int j = 0; j < contacts[i].Length; j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine("\nId: " + contacts[i][0]);
                    }
                    if (j == 1)
                    {
                        Console.WriteLine("Name: " + contacts[i][1]);
                    }
                    if (j == 2)
                    {
                        Console.WriteLine("Surname: " + contacts[i][2]);
                    }
                    if (j == 3)
                    {
                        Console.WriteLine("Number: " + contacts[i][3]);
                    }
                }
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Contact can not find");

                goto repeatPhone;
            }
        }
    }

    else
    {
        Console.Clear();
        Console.WriteLine("The property you entered is incorrect! \n" +
                          "Want to try again? Yes or Not");

        string select2 = Console.ReadLine();

        if (select2 == "yes")
        {
            goto repeat2;
        }
        else
        {
            goto repeat;
        }
    }

    Console.WriteLine("Do you want to continue? Yes or Not");

    string select = Console.ReadLine();

    if (select == "yes")
    {
        goto repeat;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Goodbye");

        Environment.Exit(0);   
    }

}


else if (num == 5)
{
    Console.Clear();

    for (int i = 0; i < contacts.Length; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (j == 0)
            {
                Console.WriteLine("Id: " + contacts[i][j]);
            }
            if (j == 1)
            {
                Console.WriteLine("Name: " + contacts[i][j]);
            }
            if (j == 2)
            {
                Console.WriteLine("Surname: " + contacts[i][j]);
            }
            if (j == 3)
            {
                Console.WriteLine("Number: " + contacts[i][j]);
            }
        }
    }

    Console.Write("Which user do you want to change? Please, enter the name: ");
    string name = Console.ReadLine();

    for (int i = 0; i < contacts.Length; i++)
    {
        if (contacts[i][1].Equals(name))
        {
            for (int j = 0; j < 4; j++)
            {
                if (j == 0)
                {
                    Console.WriteLine("\nId: " + contacts[i][0]);
                }
                if (j == 1)
                {
                    Console.WriteLine("Name: " + contacts[i][1]);
                }
                if (j == 2)
                {
                    Console.WriteLine("Surname: " + contacts[i][2]);
                }
                if (j == 3)
                {
                    Console.WriteLine("Number: " + contacts[i][3] + "\n");
                }
            }

        repeat3:
            Console.Clear();
            Console.WriteLine("Which properties do you want to change?\n" +
                              "Name: 1 \n" +
                              "Surname: 2 \n" +
                              "Number: 3");

            string editContact = Console.ReadLine();

            if (editContact == "1")
            {
                Console.Clear();
                Console.WriteLine("Current Name: " + contacts[i][1]);
                Console.Write("Enter new name: ");
                string newName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(newName))
                {
                    contacts[i][1] = newName;
                    Console.WriteLine("Updated Name: " + contacts[i][1]);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Name was not updated.");
                }

                Console.WriteLine("Want to change other properties too? Yes or Not");

                string select2 = Console.ReadLine();

                if (select2 == "yes")
                {
                    goto repeat3;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Do you want to continue? Yes or Not");

                    string select = Console.ReadLine();

                    if (select == "yes")
                    {
                        goto repeat;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Goodbye");

                        Environment.Exit(0);
                    }
                }
            }

            else if (editContact == "2")
            {
                Console.Clear();
                Console.WriteLine("Current Surname: " + contacts[i][2]);
                Console.Write("Enter new Surname: ");
                string newSurname = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(newSurname))
                {
                    contacts[i][2] = newSurname;
                    Console.WriteLine("Updated Surname: " + contacts[i][2]);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Surname was not updated.");
                }

                Console.WriteLine("Want to change other properties too? Yes or Not");

                string select2 = Console.ReadLine();

                if (select2 == "yes")
                {
                    goto repeat3;
                }
                else
                {
                    Console.WriteLine("Do you want to continue? Yes or Not");

                    string select = Console.ReadLine();

                    if (select == "yes")
                    {
                        goto repeat;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Goodbye");

                        Environment.Exit(0);
                    }
                }
            }

            else if (editContact == "3")
            {
                Console.Clear();
                Console.WriteLine("Current Number: " + contacts[i][3]);
                Console.Write("Enter new Number: ");
                string newNumber = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(newNumber))
                {
                    contacts[i][3] = newNumber;
                    Console.WriteLine("Updated Name: " + contacts[i][3]);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Number was not updated.");
                }

                Console.WriteLine("Want to change other properties too? Yes or Not");

                string select2 = Console.ReadLine();

                if (select2 == "yes")
                {
                    goto repeat3;
                }
                else
                {
                    Console.WriteLine("Do you want to continue? Yes or Not");

                    string select = Console.ReadLine();

                    if (select == "yes")
                    {
                        goto repeat;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Goodbye");

                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}


else if (num == 6)
{
    Console.Clear();
    Console.WriteLine("Goodbye");
    Console.ReadLine();

    Environment.Exit(0);    
}


else
{
    Console.Clear();
    Console.WriteLine("Operation number is incorrect \n" +
                       "Do you want to try again? Yes or Not");

    string select = Console.ReadLine();

    if (select == "yes")
    {
        goto repeat;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Goodbye");

        Environment.Exit(0);    
    }
}





Console.ReadLine();