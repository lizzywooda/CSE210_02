using System;
using System.Collections.Generic;
using CSE210_02;


namespace CSE210_02
{
    public class Player
    {
        bool isPlaying = true;
        int winningPoint = 100;
        int losingPoint = 75;
        int totalScore = 300;
        int currentCard = 1;
        int nextCard;
        Deck deck = new Deck();
        public Player()
        {    
        }

        public void StartGame()
        {
            currentCard = deck.getNewCard();
            while (isPlaying)
            {
                MainGame();
                GameCheck();
            }
        }

        public void MainGame(){
            Console.WriteLine($"The card is {currentCard}");
            
            nextCard = deck.getNewCard();

            Console.Write("Higher or Lower: [h/l] ");
            string cardGuess = Console.ReadLine();
            Console.WriteLine($"the next card was:{nextCard}");
            
            if (cardGuess.Equals("h") && currentCard < nextCard){
                totalScore += winningPoint;
            }
            else if (cardGuess.Equals("l") && currentCard > nextCard){
                totalScore += winningPoint;
            }
            else if(cardGuess.Equals("h") && currentCard > nextCard){
                totalScore -= losingPoint;
                if (totalScore < 0){
                    totalScore = 0;
                }
            }
            else if(cardGuess.Equals("l") && currentCard < nextCard){
                totalScore -= losingPoint;
                if (totalScore < 0){
                    totalScore = 0;
                }
            }
            Console.WriteLine($"Your score is: {totalScore}");
        }

        public void GameCheck()
            {
                if (totalScore == 0){
                    isPlaying = false;
                }

                currentCard = nextCard;
                Console.Write("Keep Playing? [y/n] ");
                string drawCard = Console.ReadLine();
                isPlaying = (drawCard == "y");
            }
    }
}
