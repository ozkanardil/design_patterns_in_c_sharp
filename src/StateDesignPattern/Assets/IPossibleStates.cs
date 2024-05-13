using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern.Assets
{
    public interface IPossibleStates
    {
        void PressOnButton(Tv context);
        void PressOffButton(Tv context);
        void PressMuteButton(Tv context);
    }
}
