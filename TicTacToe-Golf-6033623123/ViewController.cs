using System;

using AppKit;
using Foundation;

namespace TicTacToeGolf6033623123
{
    public partial class ViewController : NSViewController
    {

        //game logic variables

        static Boolean isRunning = true;

        static string winner = null;

        static Boolean turn = true; //true binds to O false binds to X

        static int moveCount = 0;

        static string[] Board = { " ", " ", " ", " ", " ", " ", " ", " ", " " };

        //viewController parts

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
            updateState();
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.

            }
        }

        //gui binding part

        partial void onClickButton1(AppKit.NSButton sender)
        {
            Boolean success = mark(0);

            Console.WriteLine(success);

            if (success)
            {
                button1Prop.Enabled = false;
            }
            else
            {
                button1Prop.Enabled = true;
            }

            turn = !turn;
            updateState();

        }

        partial void onClickButton2(AppKit.NSButton sender)
        {
            Boolean success = mark(1);

            Console.WriteLine(success);

            if (success)
            {
                button2Prop.Enabled = false;
            }
            else
            {
                button2Prop.Enabled = true;
            }

            turn = !turn;
            updateState();

        }

        partial void onClickButton3(AppKit.NSButton sender)
        {
            Boolean success = mark(2);

            Console.WriteLine(success);

            if (success)
            {
                button3Prop.Enabled = false;
            }
            else
            {
                button3Prop.Enabled = true;
            }

            turn = !turn;
            updateState();

        }

        partial void onClickButton4(AppKit.NSButton sender)
        {
            Boolean success = mark(3);

            Console.WriteLine(success);

            if (success)
            {
                button4Prop.Enabled = false;
            }
            else
            {
                button4Prop.Enabled = true;
            }

            turn = !turn;
            updateState();

        }

        partial void onClickButton5(AppKit.NSButton sender)
        {
            Boolean success = mark(4);

            Console.WriteLine(success);

            if (success)
            {
                button5Prop.Enabled = false;
            }
            else
            {
                button5Prop.Enabled = true;
            }

            turn = !turn;
            updateState();

        }

        partial void onClickButton6(AppKit.NSButton sender)
        {
            Boolean success = mark(5);

            Console.WriteLine(success);

            if (success)
            {
                button6Prop.Enabled = false;
            }
            else
            {
                button6Prop.Enabled = true;
            }

            turn = !turn;
            updateState();

        }

        partial void onClickButton7(AppKit.NSButton sender)
        {
            Boolean success = mark(6);

            Console.WriteLine(success);

            if (success)
            {
                button7Prop.Enabled = false;
            }
            else
            {
                button7Prop.Enabled = true;
            }

            turn = !turn;
            updateState();

        }

        partial void onClickButton8(AppKit.NSButton sender)
        {
            Boolean success = mark(7);

            Console.WriteLine(success);

            if (success)
            {
                button8Prop.Enabled = false;
            }
            else
            {
                button8Prop.Enabled = true;
            }

            turn = !turn;
            updateState();

        }

        partial void onClickButton9(AppKit.NSButton sender)
        {
            Boolean success = mark(8);

            Console.WriteLine(success);

            if (success)
            {
                button9Prop.Enabled = false;
            }
            else
            {
                button9Prop.Enabled = true;
            }

            turn = !turn;
            updateState();

        }

        partial void onClickReset(Foundation.NSObject sender)
        {
            //reset everything
            string[] emptyBoard = { " ", " ", " ", " ", " ", " ", " ", " ", " " };
            Board = emptyBoard;
            isRunning = true;
            winner = null;
            turn = true;
            moveCount = 0;

            button1Prop.Enabled = true;
            button2Prop.Enabled = true;
            button3Prop.Enabled = true;
            button4Prop.Enabled = true;
            button5Prop.Enabled = true;
            button6Prop.Enabled = true;
            button7Prop.Enabled = true;
            button8Prop.Enabled = true;
            button9Prop.Enabled = true;

            updateState();

        }


        //logic part start here

        private string getCurrentTurn()
        {
            if (turn) { return "O"; }
            else
            {
                return "X";
            }
        }

        private Boolean mark(int i)
        {
            if (Board[i] == " ") //only marks when square board is empty
            {
                Board[i] = getCurrentTurn();
                moveCount++;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void displayboard() //bind button status (X,O) to boards variable
        {
            button1Prop.Title = Board[0];
            button2Prop.Title = Board[1];
            button3Prop.Title = Board[2];
            button4Prop.Title = Board[3];
            button5Prop.Title = Board[4];
            button6Prop.Title = Board[5];
            button7Prop.Title = Board[6];
            button8Prop.Title = Board[7];
            button9Prop.Title = Board[8];
        }

        private void displayMessage() //display game status message
        {
            if (isRunning)
            {
                if (turn)
                {
                    mainLabel.StringValue = "It is O turn";
                }
                else
                {
                    mainLabel.StringValue = "It is X turn";
                }
            }
            else
            {
                if (winner == null)
                {
                    mainLabel.StringValue = "Tie.";
                }
                else
                {
                    mainLabel.StringValue = (winner + " wins.");
                }
            }

        }

        private void evaluateGame() //evaluate game stats (check for winner)
        {
            //all winning combinations
            int[][] winningCombinations = { new int[] { 0, 1, 2 }, new int[] { 3, 4, 5 }, new int[] { 6, 7, 8 }, new int[] { 0, 3, 6 }, new int[] { 1, 4, 7 }, new int[] { 2, 5, 8 }, new int[] { 0, 4, 8 }, new int[] { 2, 4, 6 } };
            for (int i = 0; i < 8; i++)
            {
                int[] wc = winningCombinations[i];
                int firstElement = wc[0];
                int secondElement = wc[1];
                int thirdElement = wc[2];

                if (Board[firstElement] != " " && Board[firstElement] == Board[secondElement] && Board[firstElement] == Board[thirdElement])
                {
                    isRunning = false;
                    winner = Board[firstElement];
                }


            }
            //check tie condition
            Console.WriteLine(moveCount);
            if(moveCount==9)
            {
                isRunning = false;
            }


        }

        private void updateState() //update game states
        {
            evaluateGame();
            displayboard();
            displayMessage();
        }
    }
}