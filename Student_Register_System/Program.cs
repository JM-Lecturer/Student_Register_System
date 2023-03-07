namespace Student_Register_System
{
    internal class Program
    {
        
        static int RunMenu(string[] menuItems)
        {

            Console.WriteLine(menuItems[0] + "\n");

            for (int i = 1; i < menuItems.Length; i++)
            {

                Console.WriteLine(i + ": " + menuItems[i]);

            }

            Console.WriteLine("Please enter your selection from the list provided: \n");
            int menuChoice = Convert.ToInt16(Console.ReadLine());

            return menuChoice;

        }
        
        static void Main(string[] args)
        {
            
            string[] menuItems = { "-----------Menu-----------", "Register Student", "Assign Student to Class", "Take Register", "Close"};
            int menuChoice = RunMenu(menuItems);

        }
    }
}