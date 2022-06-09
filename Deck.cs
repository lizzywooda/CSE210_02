using System;
using System.Collections.Generic;
using System.Linq;

namespace CSE210_02
{
    public class Deck
    {
       public int cardValue;

       ///
       public int getNewCard(){
           Random randomGenerator = new Random();
           cardValue = randomGenerator.Next(1,14);
           return cardValue;
       } 
    }
}
