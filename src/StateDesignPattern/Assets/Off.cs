using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StateDesignPattern.Assets
{
    public class Off: IPossibleStates
    {
        Tv _tvContext;
        //Initially we'll start from Off state
        public Off(Tv context)
        {
            Console.WriteLine("Tv is Off now.");
            _tvContext = context;
        }
        //Users can press any of these buttons at this state-On, Off or Mute
        //Tv is Off now, user is pressing On button
        public void PressOnButton(Tv context)
        {
            Console.WriteLine("On button is pressed. Going from Off to On state");

            _tvContext.CurrentState = new On(context);
        }
        //Tv is Off already, user is pressing Off button again
        public void PressOffButton(Tv context)
        {
            Console.WriteLine("Off button is pressed. Tv is already in Off state");
        }

        public void PressMuteButton(Tv context)
        {
            Console.WriteLine("Mute button is pressed. Tv is already in Off state, so Mute operation will not work.");
        }
    }
}
