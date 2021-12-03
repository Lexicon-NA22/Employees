using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    //Statisk klass kan ej instansieras (med andra ord EJ : Util util = new Util())
    //Statiska klasser kan endast ha statiska medlemmar
    //Anropas med klassNamn.MetodNamn tex Util.AskForString("Hej!", new ConsoleUI())
    public static class Util
    {
        //Prompt = det vi vill skriva ut på skärmen
        //IUI hanterar input/output
        //Här har vi ingen aning vilken typ av ui som vi faktiskt jobbar med det enda vi vet är att vi kan anropa GetStringInput samt PrintString
        public static string AskForString(string prompt, IUI ui)
        {
            bool success = false;
            string answer;

            do
            {
                ui.PrintString($"{prompt}: ");
                answer = ui.GetStringInput();

                //loopa tills användaren har skrivit in något
                //Än så länge ingen annan validering.
                if (string.IsNullOrWhiteSpace(answer))
                {
                    ui.PrintString($"You must enter a {prompt}");
                }
                else
                {
                    success = true;
                }

            } while (!success);

            return answer;
        }

        public static uint AskForUInt(string prompt, IUI ui)
        {
            do
            {
                //Anropa AskForString så vi vet att vi faktiskt får en string tillbaks
                //Fortsätter tills vi har fått en string som vi kan Parsa till en uint
                string input = AskForString(prompt, ui);
                if(uint.TryParse(input, out uint answer)) return answer;

            } while (true);
        }
    }
}
