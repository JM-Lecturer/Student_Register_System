using System.Runtime.Versioning;

namespace Student_Register_System
{
    internal class Program
    {

        class Students
        {

            private string m_fName;
            private string m_sName;
            private int m_age;

            //To autogenerate a property do the following: type "prop" then press TAB TAB

            public string fName { get { return m_fName; } set { m_fName = value; } }

            public string sName { get { return m_sName; } set { m_sName = value; } }

            public int ID { get { return m_age; } set { m_age = value; } }

            public Students(string fName, string sName, int age)
            {

                m_fName= fName;
                m_sName= sName;
                m_age = age;

            }

            public string GetFullName()
            {

                return m_fName + " " + m_sName;

            }

        }

            static int RunMenu(string[] menuItems)
            {

                Console.WriteLine(menuItems[0] + "\n");

                for (int i = 1; i < menuItems.Length; i++)
                {

                    Console.WriteLine(i + ": " + menuItems[i]);

                }

                int menuChoice = 0;

                try
                {

                    Console.WriteLine("\nPlease enter your selection from the list provided: \n");
                    menuChoice = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();

                    if (menuChoice < 1 || menuChoice >= menuItems.Length)
                    {

                        throw new Exception(); //Make sure to improve the error handling section for this area!!!!

                    }

                }
                catch
                {

                    Console.WriteLine("Sorry, an unexpected error has occured. Please try again...\n[Press Enter to Try Again]");
                    Console.ReadLine();
                    Console.Clear();

                }

                return menuChoice;

            }

            static void Main(string[] args)
            {

                int menuChoice = 0;

                do
                {

                    string[] menuItems = { "-----------Menu-----------", "Register Student", "Assign Student to Class", "Take Register", "Close" };
                    menuChoice = RunMenu(menuItems);

                    switch (menuChoice)
                    {

                        case 1:

                            Console.WriteLine("Register Students coming soon...");
                            break;

                        case 2:

                            Console.WriteLine("Assign Student to Class coming soon...");
                            break;

                        case 3:

                            Console.WriteLine("Take Register coming soon...");
                            break;

                        case 4:

                            Console.WriteLine("Good Bye\n[Press Enter to Close]");
                            Console.ReadLine();
                            break;

                    }


                } while (menuChoice != 4);


            }
        }
    }