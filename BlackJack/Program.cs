using System;
using System.Threading;

namespace BlackJack
{
    public class Deals
    {
        public static string cardOneSuit, cardTwoSuit, HitSuit, cardOneSuitD, cardTwoSuitD, HitSuitD, playerScore, dealerScore, faceCard;
        public static int playerRunningScore, dealerRunningScore = 0;
        public static string firstCard()
        {
            var rand = new Random();
            int[] drawCardOne = { rand.Next(1, 14), rand.Next(1, 5) };
            if (drawCardOne[1] == 1)
            {
                cardOneSuit = "hearts"; //checks the second element in the card array to find the suit

            }
            if (drawCardOne[1] == 2)
            {
                cardOneSuit = "diamonds";
            }
            if (drawCardOne[1] == 3)
            {
                cardOneSuit = "spades";
            }
            if (drawCardOne[1] == 4)
            {
                cardOneSuit = "clubs";
            }
            if (drawCardOne[0] == 11 || drawCardOne[0] == 12 || drawCardOne[0] == 13)
            {
                playerRunningScore = playerRunningScore + 10; //checks to see if a card is above 10 so that when it prints off the card it says 'queen of hearts' instead of '12 of hearts'
                //adds 10 to score instead of the card's real value
                if (drawCardOne[0] == 11)
                {
                    faceCard = "Jack";
                }
                if (drawCardOne[0] == 12)
                {
                    faceCard = "Queen";
                }
                if (drawCardOne[0] == 13)
                {
                    faceCard = "King";
                }
            }
            if (drawCardOne[0] == 1)
            {
                playerRunningScore = playerRunningScore + 11;// adds 11 to score
                if (drawCardOne[0] == 1)
                {
                    faceCard = "Ace"; // makes the writeline say ace instead of 1
                }
            }
            if (drawCardOne[0] == 2 || drawCardOne[0] == 3 || drawCardOne[0] == 4 || drawCardOne[0] == 5|| drawCardOne[0] == 6 || drawCardOne[0] == 7|| drawCardOne[0] == 8 || drawCardOne[0] == 9 || drawCardOne[0] == 10)
            {
                playerRunningScore = playerRunningScore + drawCardOne[0];
            }



            if (drawCardOne[0] >= 11 || drawCardOne[0] == 1)
            {
                Console.Write("You drew a " + faceCard + " of " + cardOneSuit);
            }
            else
            {
                Console.Write("You drew a " + drawCardOne[0] + " of " + cardOneSuit);
            }
            playerScore = playerRunningScore.ToString();
            return playerScore;
        }



        //**********************************************************************************************************************************************************//
        //same exact code as before but applies the score to the dealers score and doesn't print out the cards that the dealer drew.
        public static void dealerFirstDraw()
        {
            var rand = new Random();
            int[] drawCardOneD = { rand.Next(1, 14), rand.Next(1, 5) };
            if (drawCardOneD[0] == 11 || drawCardOneD[0] == 12 || drawCardOneD[0] == 13)
            {
                dealerRunningScore = dealerRunningScore + 10;
            }
            if (drawCardOneD[0] == 1)
            {
                dealerRunningScore = dealerRunningScore + 11;
            }
            if (drawCardOneD[0] == 2 || drawCardOneD[0] == 3 || drawCardOneD[0] == 4 || drawCardOneD[0] == 5 || drawCardOneD[0] == 6 || drawCardOneD[0] == 7 || drawCardOneD[0] == 8 || drawCardOneD[0] == 9 || drawCardOneD[0] == 10)
            {
                dealerRunningScore = dealerRunningScore + drawCardOneD[0]; //lol i forgot that I could do <=10 
            }
        }
        public static string secondCard()
        {
            var rand = new Random();
            int[] drawCardTwo = { rand.Next(1, 14), rand.Next(1, 5) };
            if (drawCardTwo[1] == 1)
            {
                cardOneSuit = "hearts";

            }
            if (drawCardTwo[1] == 2)
            {
                cardOneSuit = "diamonds";
            }
            if (drawCardTwo[1] == 3)
            {
                cardOneSuit = "spades";
            }
            if (drawCardTwo[1] == 4)
            {
                cardOneSuit = "clubs";
            }
            if (drawCardTwo[0] == 11 || drawCardTwo[0] == 12 || drawCardTwo[0] == 13)
            {
                playerRunningScore = playerRunningScore + 10;
                if (drawCardTwo[0] == 11)
                {
                    faceCard = "Jack";
                }
                if (drawCardTwo[0] == 12)
                {
                    faceCard = "Queen";
                }
                if (drawCardTwo[0] == 13)
                {
                    faceCard = "King";
                }
            }
            if (drawCardTwo[0] == 1)
            {
                playerRunningScore = playerRunningScore + 11;
                if (drawCardTwo[0] == 1)
                {
                    faceCard = "Ace";
                }
            }
            if (drawCardTwo[0] == 2 || drawCardTwo[0] == 3 || drawCardTwo[0] == 4 || drawCardTwo[0] == 5 || drawCardTwo[0] == 6 || drawCardTwo[0] == 7 || drawCardTwo[0] == 8 || drawCardTwo[0] == 9 || drawCardTwo[0] == 10)
            {
                playerRunningScore = playerRunningScore + drawCardTwo[0];
            }



            if (drawCardTwo[0] >= 11 || drawCardTwo[0] == 1)
            {
                Console.WriteLine(" and a " + faceCard + " of " + cardOneSuit);
            }
            else
            {
                Console.WriteLine(" and a " + drawCardTwo[0] + " of " + cardOneSuit);
            }
            playerScore = playerRunningScore.ToString();
            return playerScore;
        }
        public static string Hit()
        {
            var rand = new Random();
            int[] drawCardHit = { rand.Next(1, 14), rand.Next(1, 5) };
            if (drawCardHit[1] == 1)
            {
                cardOneSuit = "hearts";

            }
            if (drawCardHit[1] == 2)
            {
                cardOneSuit = "diamonds";
            }
            if (drawCardHit[1] == 3)
            {
                cardOneSuit = "spades";
            }
            if (drawCardHit[1] == 4)
            {
                cardOneSuit = "clubs";
            }
            if (drawCardHit[0] == 11 || drawCardHit[0] == 12 || drawCardHit[0] == 13)
            {
                playerRunningScore = playerRunningScore + 10;
                if (drawCardHit[0] == 11)
                {
                    faceCard = "Jack";
                }
                if (drawCardHit[0] == 12)
                {
                    faceCard = "Queen";
                }
                if (drawCardHit[0] == 13)
                {
                    faceCard = "King";
                }
            }
            if (drawCardHit[0] == 1)
            {
                playerRunningScore = playerRunningScore + 10;
                if (drawCardHit[0] == 1)
                {
                    faceCard = "Ace";
                }
            }
            if (drawCardHit[0] == 2 || drawCardHit[0] == 3 || drawCardHit[0] == 4 || drawCardHit[0] == 5 || drawCardHit[0] == 6 || drawCardHit[0] == 7 || drawCardHit[0] == 8 || drawCardHit[0] == 9 || drawCardHit[0] == 10)
            {
                playerRunningScore = playerRunningScore + drawCardHit[0];
            }



            if (drawCardHit[0] >= 11 || drawCardHit[0] == 1)
            {
                Console.WriteLine("You drew a " + faceCard + " of " + cardOneSuit);
            }
            else
            {
                Console.WriteLine("You drew a " + drawCardHit[0] + " of " + cardOneSuit);
            }
            playerScore = playerRunningScore.ToString();
            return playerScore;
        }
    }







    public class Program
    {
        public static string username;

        public static void Main(string[] args)
        {
            int wager = 500; //original starting amount





            //Rules for the game.
            Console.WriteLine("_________________________________________________________________________________________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("- Welcome user. You will be playing Blackjack against a dealer. Your goal is to get to or as close to 21 as possible.");
            Console.WriteLine("- You will be dealt two cards at the beginning; it is then your decision whether you want to hold your current cards or draw another card.");
            Console.WriteLine("- If you go over 21 you lose. Card values are according to face value. Jack, Queen, King are all worth 10 and Ace is worth 11.");
            Console.WriteLine("- If you reach 21 off of the first deal you receive 2x the amount that you wagered.");
            Console.WriteLine("- You will start with $500 and you play until you run out or you withdraw. You can only withdraw at the end of a round.");
            Console.WriteLine("");
            Console.WriteLine("_________________________________________________________________________________________________________________________________________________");



            Console.WriteLine("");
            Console.Write("To start, Enter your username:"); //asks the user for username
            username = Console.ReadLine();
            Console.WriteLine("Welcome " + username + ".");


        nextRound:
            wager:
            int wageredAmount;
            Console.WriteLine("You currently have $" + wager);
            Console.Write("Enter wager:");
            while(!int.TryParse(Console.ReadLine(), out wageredAmount))
            {
                Console.WriteLine("That is not an acceptable wager.");
                Console.Write("Enter wager:");
            }


            if(wageredAmount > wager)
            {
                Console.WriteLine("You wagered too much!");
                goto wager;
            }









            Console.Clear();
            Console.WriteLine("You have wagered $" + wageredAmount);
            Console.WriteLine("The dealer will now deal you 2 cards.");
            Thread.Sleep(2000);
            Deals.firstCard();



            Console.WriteLine("The current value of your cards is " + Deals.secondCard());
            Console.WriteLine("The dealer will now draw.");
            Deals.dealerFirstDraw();
            Deals.dealerFirstDraw();
            Thread.Sleep(2000);





            if (Deals.playerRunningScore == 21 && Deals.dealerRunningScore == 21)
            {
                Console.Clear();
                Console.WriteLine("You both drew naturals. Its a draw.");
                Deals.playerRunningScore = 0; //sets scores equal to zero for the next round
                Deals.dealerRunningScore = 0;
                goto nextRound;
                
            }
            else if (Deals.playerRunningScore == 21)
            {
                Console.WriteLine("You drew a natural. You win this round and receive 2x your wager.");  //these if statements check if either the dealer or player got a natural
                wager = wager + (wageredAmount * 2);
                Console.WriteLine("Would you like to play again? (yes or no)");
                string playAgain = Console.ReadLine();
                if (playAgain == "yes")
                {
                    Console.Clear();
                    Deals.playerRunningScore = 0;
                    Deals.dealerRunningScore = 0;
                    goto nextRound;
                    
                }
                if (playAgain == "no")
                {
                    Console.Clear();
                    goto endGame;
                }
            }
            else if (Deals.dealerRunningScore == 21)
            {
                Console.WriteLine("The dealer drew a natural. They win 1.5x their wager.");
                wager = wager - (wageredAmount * 2);
                if(wager > 0)
                {
                    Console.WriteLine("Would you like to play again? (yes or no)");
                    string playAgain = Console.ReadLine();
                    if (playAgain == "yes")
                    {
                        Console.Clear();
                        Deals.playerRunningScore = 0;
                        Deals.dealerRunningScore = 0;
                        goto nextRound;
                        
                    }
                    if (playAgain == "no")
                    {
                        Console.Clear();
                        goto endGame;
                    }
                }
                if(wager <= 0) //checks the player's prize pool to see if they are out of money.
                {
                    Console.Clear();
                    goto endGame;
                }
            }




            else
            {
                for (int i = Deals.playerRunningScore; i <= 21; i = Deals.playerRunningScore) //repeats until the players score goes over 21
                {

                    Console.WriteLine("What do you want to do now? (hit or stand)");
                    string nextMove = Console.ReadLine();
                        if (nextMove == "hit")
                        {
                            Console.Clear();
                            Console.WriteLine("The current value of your cards is " + Deals.Hit());
                            if (Deals.dealerRunningScore >= 18)
                            {
                                Console.WriteLine("The dealer stands");
                            }

                            else if (Deals.dealerRunningScore < 17)
                            {
                                Console.WriteLine("The dealer hits");
                                Deals.dealerFirstDraw();
                            }
                        }

                        else if (nextMove == "stand")
                        {
                            for (int D = Deals.dealerRunningScore; D <= 21; D = Deals.dealerRunningScore) //repeats until the dealer's score goes over 21
                            {
                                if (Deals.dealerRunningScore >= 18)
                                {
                                    Console.WriteLine("The dealer stands");  
                                    break;//breaks the dealer for loop if the dealer stands before reaching 21
                                }
                                else if (Deals.dealerRunningScore < 18)
                                {
                                    Console.WriteLine("The dealer hits");
                                    Deals.dealerFirstDraw();
                                }
                            }
                            break; // breaks the original for loop only if the player and the dealer stand before reaching 21
                        }
                }








                //checks to see if the player busted and removes their wagered amount from their prize pool.
                if (Deals.playerRunningScore > 21)
                {
                    wager = wager - wageredAmount;
                    Console.WriteLine("You busted.");


                    if (wager <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("You have no more money!");
                        goto endGame;
                    }



                    Console.WriteLine("");
                    Console.WriteLine("The final score of that round was: " + username + "-" + Deals.playerRunningScore + " Dealer-" + Deals.dealerRunningScore);
                    Console.WriteLine("");
                    Console.WriteLine("Would you like to play again? (yes or no)");
                    string playAgain = Console.ReadLine();
                    if (playAgain == "yes")
                    {
                        Console.Clear();
                        Deals.playerRunningScore = 0;
                        Deals.dealerRunningScore = 0;
                        goto nextRound;
                    }
                    if (playAgain == "no")
                    {
                        Console.Clear();
                        goto endGame;
                    }
                }



                //checks to see if the dealer busts. Always checks it second after the program checks to see if the player busted.
                if (Deals.dealerRunningScore > 21)
                {
                    wager = wager + wageredAmount;
                    Console.WriteLine("The dealer busted");
                    Console.WriteLine("");
                    Console.WriteLine("The final score of that round was: " + username + "-" + Deals.playerRunningScore + " Dealer-" + Deals.dealerRunningScore);
                    Console.WriteLine("");
                    Console.WriteLine("Would you like to play again? (yes or no)");
                    string playAgain = Console.ReadLine();
                    if (playAgain == "yes")
                    {
                        Deals.playerRunningScore = 0;
                        Deals.dealerRunningScore = 0;
                        Console.Clear();
                        goto nextRound;
                    }
                    if (playAgain == "no")
                    {
                        Console.Clear();
                        goto endGame;
                    }
                }




                //displays the final score of the round
                Console.WriteLine("");
                Console.WriteLine("The final score of that round was: " + username + "-" + Deals.playerRunningScore + " Dealer-" + Deals.dealerRunningScore);




                //if the player wins, adds their wageredamount to their prize pool and asks if they can play again.
                if(Deals.playerRunningScore > Deals.dealerRunningScore && Deals.playerRunningScore <= 21)
                {
                    wager = wager + wageredAmount;
                    Console.WriteLine("You won this round. Would you like to play again? (yes or no)");
                    string playAgain = Console.ReadLine();
                    if(playAgain == "yes")
                    {
                        Deals.playerRunningScore = 0;
                        Deals.dealerRunningScore = 0;
                        Console.Clear();
                        goto nextRound;
                        
                    }
                    if(playAgain == "no")
                    {
                        Console.Clear();
                        goto endGame;
                    }
                }


                //accounts for the dealer winning the round
                if(Deals.playerRunningScore < Deals.dealerRunningScore && Deals.dealerRunningScore <= 21)
                {
                    wager = wager - wageredAmount;
                    if(wager <= 0)
                    {
                        Console.WriteLine("You have no more money!");
                        goto endGame;
                    }
                    Console.WriteLine("You lost this round. Would you like to play again? (yes or no)");
                    string playAgain = Console.ReadLine();
                    if (playAgain == "yes")
                    {
                        Console.Clear();
                        Deals.playerRunningScore = 0;
                        Deals.dealerRunningScore = 0;
                        goto nextRound;
                    }
                    if (playAgain == "no")
                    {
                        Console.Clear();
                        goto endGame;
                    }
                }
            }

















        endGame:
            Console.WriteLine("You ended the game with $" + wager);
            Thread.Sleep(2500);
            if(wager > 0 && wager < 500)
            {
                Console.WriteLine("At least you still have some money.");
            }
            if(wager <= 0)
            {
                Console.WriteLine("Surely this will not lead to a crippling gambling addiction...");
            }
            if(wager >= 500)
            {
                Console.WriteLine("You made a profit!");
            }
        }
    }
}
