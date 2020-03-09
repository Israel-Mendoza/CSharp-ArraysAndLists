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
        static int playedTurns = 0;


        static void Main(string[] args)
        {

            SelectPlayerToken();

            Console.WriteLine($"Player 1: {playerOne}");
            Console.WriteLine($"Player 2: {playerTwo}");
            MainGameLoop();

        }

        /// <summary>Method <c>MainGameLoop</c> runs the main game loop</summary>
        static void MainGameLoop()
        {
            int choice;
            while (true)
            {
                Console.Clear();
                string playerName = currentPlayerID == 100 ? "Player 1" : "Player 2";
                DrawBoard(fields, playerOne, playerTwo);
                Console.WriteLine($"It's {playerName}'s turn (\"{(currentPlayerID == 100 ? playerOne : playerTwo)}\")!");
                choice = GetAvailableInt(fields);
                UpdateArray(fields, choice, currentPlayerID);
                playedTurns++;
                
                if (CheckWinner(fields, currentPlayerID))
                {
                    EndGameWithWinner(currentPlayerID);
                    break;
                }
                    
                if (playedTurns == 9)
                {
                    EndGameWithDraw();
                    break;
                }  
                currentPlayerID = currentPlayerID == 100 ? 200 : 100;
            }
        }
        
        
        static void EndGameWithWinner(int playerID)
        {
            Console.Clear();
            DrawBoard(fields, playerOne, playerTwo);
            string playerName = playerID == 100 ? "Player 1" : "Player 2";
            Console.WriteLine($"\n\n{playerName} has won... CONGRATULATIONS!!!");
            Console.ReadKey();
        }

        static void EndGameWithDraw()
        {
            Console.Clear();
            DrawBoard(fields, playerOne, playerTwo);
            Console.WriteLine("\n\nDRAW!!!");
            Console.ReadKey();
        }
        
        /// <summary>Method <c>SelectPlayerToken</c> allows Player 1 choose their token, either "O" or "X"</summary>
        static void SelectPlayerToken()
        {
            Console.WriteLine("Player 1 gets to choose their token...");
            while (true)
            {
                Console.Write("P1, please enter \"O\" or \"X\" to start: ");
                string playerTokenChosen = Console.ReadLine();
                if (playerTokenChosen.ToUpper() == "O" || playerTokenChosen.ToUpper() == "X")
                {
                    playerOne = playerTokenChosen.ToUpper();
                    playerTwo = playerOne == "X" ? "O" : "X";
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

        /// <summary>Method <c>DrawBoard</c> draws the game board on the cosole with the current values</summary>
        static void DrawBoard(int[,] twoDArray, string playerOneToken, string playerTwoToken)
        {
            string one = GetDisplayChar(twoDArray[0, 0], playerOneToken, playerTwoToken);
            string two = GetDisplayChar(twoDArray[0, 1], playerOneToken, playerTwoToken);
            string three = GetDisplayChar(twoDArray[0, 2], playerOneToken, playerTwoToken);
            string four = GetDisplayChar(twoDArray[1, 0], playerOneToken, playerTwoToken);
            string five = GetDisplayChar(twoDArray[1, 1], playerOneToken, playerTwoToken);
            string six = GetDisplayChar(twoDArray[1, 2], playerOneToken, playerTwoToken);
            string seven = GetDisplayChar(twoDArray[2, 0], playerOneToken, playerTwoToken);
            string eight = GetDisplayChar(twoDArray[2, 1], playerOneToken, playerTwoToken);
            string nine = GetDisplayChar(twoDArray[2, 2], playerOneToken, playerTwoToken);
            
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

        /// <summary>Method <c>GetDisplayChar</c> returns the item to be written in the board on the console based on the value in the array</summary>
        static string GetDisplayChar(int valueToDisplay, string playerOneToken, string playerTwoToken)
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

        /// <summary>Method <c>UpdateArray</c> updates the array based on the player's choice</summary>
        static void UpdateArray(int[,] anArray, int selectedSpot, int playerID)
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

        /// <summary>Method <c>CheckWinner</c> returns True if the passed player has won the game</summary>
        static bool CheckWinner(int[,] twoDArray, int playerID)
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

        /// <summary>Method <c>GetAvailableInt</c> prompts the player to select a number until they choose an available one. 
        /// Returns the available spot in the array (int)</summary>
        static int GetAvailableInt(int[,] twoDArray)
        {
            while (true)
            {
                int userChoice = GetValidInt();
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

        /// <summary>Method <c>GetValidInt</c> prompts player to select a valid number between 1 and 9. Returns that number</summary>
        static int GetValidInt()
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
