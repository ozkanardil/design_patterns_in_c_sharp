using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern.Assets
{
    public class Tv
    {
        private IPossibleStates _currentState;
        public IPossibleStates CurrentState
        {

            get
            {
                return _currentState;
            }

            set
            {
                _currentState = value;
            }
        }
        public Tv()
        {
            _currentState = new Off(this);
        }
        public void PressOffButton()
        {
            _currentState.PressOffButton(this);//Delegating the state
        }
        public void PressOnButton()
        {
            _currentState.PressOnButton(this);//Delegating the state
        }
        public void PressMuteButton()
        {
            _currentState.PressMuteButton(this);//Delegating the state
        }
    }
}
