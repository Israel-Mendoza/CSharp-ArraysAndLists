using System;

namespace MultidimentionalArrayChallenge
{
    class Program
    {

        static string playerOne;
        static string playerTwo;
        static int[,] fields =
            {
                { 1, 2, 3},
                { 4, 5, 6},
                { 7, 8, 9}
            };
        static int currentPlayerID = 100;


        static void Main(string[] args)
        {

            selectPlayerToken();
            mainGameLoop();

        }

        static void mainGameLoop()
        {
            int choice;
            bool gameOver;
            string playerName;
            while (true)
            {
                Console.Clear();
                drawBoard(fields, playerOne, playerTwo);
                choice = getAvailableInt(fields);
                updateArray(fields, choice, currentPlayerID);
                gameOver = checkWinner(fields, currentPlayerID);
                if (GameDraw(fields))
                    break;
                if (gameOver)
                    break;
                currentPlayerID = currentPlayerID == 100 ? 200 : 100;
            }
            Console.Clear();
            drawBoard(fields, playerOne, playerTwo);
            if (GameDraw(fields))
            {
                Console.WriteLine("DRAW!!!");
                Console.ReadKey();
            }
            else
            {
                playerName = currentPlayerID == 100 ? "Player 1" : "Player";
                Console.WriteLine($"{playerName} has won... CONGRATULATIONS!!!");
                Console.ReadKey();
            }
        }
        
        static void selectPlayerToken()
        {
            Console.WriteLine("Player 1 gets to choose their token...");
            while (true)
            {
                Console.Write("P1, please enter \"O\" or \"X\" to start: ");
                string playerTokenChosen = Console.ReadLine();
                if (playerTokenChosen.ToUpper() == "O" || playerTokenChosen.ToUpper() == "X")
                {
                    playerOne = playerTokenChosen.ToUpper();
                    playerTwo = playerOne == "X" ? "0" : "X";
                    break;
                }
                else
                {
                    Console.WriteLine("That was not a valid option...");
                }
            }
            Console.WriteLine($"Player 1 will play with {playerOne}");
            Console.WriteLine($"Player 2 will play with {playerTwo}");
            Console.WriteLine("\n\nPRESS ANY KEY TO START...\n\n");
            Console.ReadKey();
            Console.Clear();
        }

        static void drawBoard(int[,] twoDArray, string playerOneToken, string playerTwoToken)
        {
            string one = getDisplayChar(twoDArray[0, 0], playerOneToken, playerTwoToken);
            string two = getDisplayChar(twoDArray[0, 1], playerOneToken, playerTwoToken);
            string three = getDisplayChar(twoDArray[0, 2], playerOneToken, playerTwoToken);
            string four = getDisplayChar(twoDArray[1, 0], playerOneToken, playerTwoToken);
            string five = getDisplayChar(twoDArray[1, 1], playerOneToken, playerTwoToken);
            string six = getDisplayChar(twoDArray[1, 2], playerOneToken, playerTwoToken);
            string seven = getDisplayChar(twoDArray[2, 0], playerOneToken, playerTwoToken);
            string eight = getDisplayChar(twoDArray[2, 1], playerOneToken, playerTwoToken);
            string nine = getDisplayChar(twoDArray[2, 2], playerOneToken, playerTwoToken);
            
            Console.WriteLine($"   |   |   ");
            Console.WriteLine($" {one} | {two} | {three} ");
            Console.WriteLine($"___|___|___");
            Console.WriteLine($"   |   |   ");
            Console.WriteLine($" {four} | {five} | {six} ");
            Console.WriteLine($"___|___|___");
            Console.WriteLine($"   |   |   ");
            Console.WriteLine($" {seven} | {eight} | {nine} ");
            Console.WriteLine($"   |   |   ");
        }

        static string getDisplayChar(int valueToDisplay, string playerOneToken, string playerTwoToken)
        {
            
            switch (valueToDisplay)
            {
                case 1:
                    return "1";
                case 2:
                    return "2";
                case 3:
                    return "3";
                case 4:
                    return "4";
                case 5:
                    return "5";
                case 6:
                    return "6";
                case 7:
                    return "7";
                case 8:
                    return "8";
                case 9:
                    return "9";
                case 100:
                    return playerOneToken == "O" ? "O" : "X";
                case 200:
                    return playerTwoToken == "O" ? "O" : "X";
                default:
                    return "Error";
            }
        }

        static void updateArray(int[,] anArray, int selectedSpot, int playerID)
        {
            switch (selectedSpot)
            {
                case 1:
                    anArray[0, 0] = playerID;
                    break;
                case 2:
                    anArray[0, 1] = playerID;
                    break;
                case 3:
                    anArray[0, 2] = playerID;
                    break;
                case 4:
                    anArray[1, 0] = playerID;
                    break;
                case 5:
                    anArray[1, 1] = playerID;
                    break;
                case 6:
                    anArray[1, 2] = playerID;
                    break;
                case 7:
                    anArray[2, 0] = playerID;
                    break;
                case 8:
                    anArray[2, 1] = playerID;
                    break;
                case 9:
                    anArray[2, 2] = playerID;
                    break;
            }
        }
        
        static bool checkWinner(int[,] twoDArray, int playerID)
        {
            if (playerID == twoDArray[0, 0] && playerID == twoDArray[0, 1] && playerID == twoDArray[0, 2])
                return true;
            else if (playerID == twoDArray[1, 0] && playerID == twoDArray[1, 1] && playerID == twoDArray[1, 2])
                return true;
            else if (playerID == twoDArray[2, 0] && playerID == twoDArray[2, 1] && playerID == twoDArray[2, 2])
                return true;
            else if (playerID == twoDArray[0, 0] && playerID == twoDArray[1, 0] && playerID == twoDArray[2, 0])
                return true;
            else if (playerID == twoDArray[0, 1] && playerID == twoDArray[1, 1] && playerID == twoDArray[2, 1])
                return true;
            else if (playerID == twoDArray[0, 2] && playerID == twoDArray[1, 2] && playerID == twoDArray[2, 2])
                return true;
            else if (playerID == twoDArray[0, 0] && playerID == twoDArray[1, 1] && playerID == twoDArray[2, 2])
                return true;
            else if (playerID == twoDArray[0, 2] && playerID == twoDArray[1, 1] && playerID == twoDArray[2, 0])
                return true;
            else
            {
                return false;
            }
        }

        static bool GameDraw(int[,] twoDArray)
        {
            for (int i = 0; i < twoDArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDArray.GetLength(1); j++)
                {
                    if (twoDArray[i, j] != 100 && twoDArray[i, j] != 200)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static int getAvailableInt(int[,] twoDArray)
        {
            while (true)
            {
                int userChoice = getValidInt();
                int choiceInBoard = 0;
                switch (userChoice)
                {
                    case 1:
                        choiceInBoard = twoDArray[0, 0];
                        break;
                    case 2:
                        choiceInBoard = twoDArray[0, 1];
                        break;
                    case 3:
                        choiceInBoard = twoDArray[0, 2];
                        break;
                    case 4:
                        choiceInBoard = twoDArray[1, 0];
                        break;
                    case 5:
                        choiceInBoard = twoDArray[1, 1];
                        break;
                    case 6:
                        choiceInBoard = twoDArray[1, 2];
                        break;
                    case 7:
                        choiceInBoard = twoDArray[2, 0];
                        break;
                    case 8:
                        choiceInBoard = twoDArray[2, 1];
                        break;
                    case 9:
                        choiceInBoard = twoDArray[2, 2];
                        break;
                }
                if (userChoice == choiceInBoard)
                    return userChoice;
                else
                {
                    Console.WriteLine("That field is already taken!!! Choose another number...");
                }
            }
            
        }

        static int getValidInt()
        {
            while (true)
            {
                Console.Write("Enter a valid number between 1 and 9: ");
                bool isIntConverted = Int32.TryParse(Console.ReadLine(), out int result);
                if (isIntConverted && result > 0 && result < 10)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("I'm sorry... That was not a valid number... \n");
                }
            }
        }
    }
}
