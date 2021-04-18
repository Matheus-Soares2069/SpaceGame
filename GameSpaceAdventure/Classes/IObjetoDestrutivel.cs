using System;
using System.Collections.Generic;
using System.Text;

namespace GameSpaceAdventure.Classes
{
    interface IObjetoDestrutivel
    {
        void DanoGrave();
        void DanoMedio();
        void DanoLeve();
    }
}
