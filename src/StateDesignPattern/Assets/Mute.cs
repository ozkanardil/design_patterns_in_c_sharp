using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern.Assets
{
    internal class Mute: IPossibleStates
    {
        Tv _tvContext;
        public Mute(Tv context)
        {
            Console.WriteLine("Tv is in Mute mode now.");
            _tvContext = context;
        }
        //Users can press any of these buttons at this state-On, Off or Mute
        //Tv is in mute, user is pressing On button
        public void PressOnButton(Tv context)
        {
            Console.WriteLine("On button is pressed. Going from Mute mode to On state.");

            _tvContext.CurrentState = new On(context);
        }
        //Tv is in mute, user is pressing Off button
        public void PressOffButton(Tv context)
        {
            Console.WriteLine("Off button is pressed. Going to Mute mode to Off state.");

            _tvContext.CurrentState = new Off(context);
        }
        //Tv is in mute already, user is pressing mute button again
        public void PressMuteButton(Tv context)
        {
            Console.WriteLine(" Mute button is pressed. Tv is already in Mute mode.");
        }
    }
}
