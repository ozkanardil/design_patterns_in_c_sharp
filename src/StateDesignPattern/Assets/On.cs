using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StateDesignPattern.Assets
{
    public class On: IPossibleStates
    {
        Tv _tvContext;
        public On(Tv context)
        {
            Console.WriteLine("Tv is On now.");
            _tvContext = context;
        }

        public void PressOnButton(Tv context)
        {
            Console.WriteLine("On button is pressed. Tv is already in On state.");
        }

        public void PressOffButton(Tv context)
        {
            Console.WriteLine("Off button is pressed. Going from On to Off state.");

            _tvContext.CurrentState = new Off(context);
        }

        public void PressMuteButton(Tv context)
        {
            Console.WriteLine("Mute button is pressed. Going from On to Mute mode.");
            _tvContext.CurrentState = new Mute(context);
        }
    }
}
