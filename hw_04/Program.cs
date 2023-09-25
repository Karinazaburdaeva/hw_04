namespace Model
{
    internal class Program
    {
        static void Main()
        {
            Model.ErrorCode myVariable = Model.ErrorCode.ConnectionLost;
            Console.WriteLine("MyVariable = {0}", myVariable);

            var today = Model.Days.Sunday;
            int todayInt = (int)today;
            Console.WriteLine("Today variable = {0}", today);
            Console.WriteLine("TodayInt variable = {0}", todayInt);

            int tommorowInt = 2;
            Model.Days tommorowEnum = (Model.Days)tommorowInt;
            Console.WriteLine("tommorowEnum variable = {0}", tommorowEnum);

            int intNine = 9;
            Model.Days nineEnum = (Model.Days)intNine;
            Console.WriteLine("nineEnum variable = {0}", nineEnum);


            Console.WriteLine("Weekend = {0}", (Model.Days)96);

            Console.ForegroundColor = (ConsoleColor.DarkBlue);

            var courceDays = Model.Days.Monday | Model.Days.Thursday;

            Model.Days currentDay = Model.Days.Friday;

            if (courceDays.HasFlag(currentDay))
            {
                Console.WriteLine("Flag presented = {0}", currentDay);
            }
            else
            {
                Console.WriteLine("Flag not presented = {0}", currentDay);
            }

            /*
            * ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            */

        }
    }
}