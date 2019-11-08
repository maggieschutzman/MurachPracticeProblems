using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCsharp.TicTacToe {
    class TicTacToe {

        public static int Player { get; set; } = 1;
        public static int Choice { get; set; }
        public static int Flag { get; set; } = 0; //winner count

        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public static void Board() {
            
            Console.WriteLine(" {0} | {1} | {2}", arr[1],arr[2],arr[3]);
            Console.WriteLine("___|___|___ ");
            Console.WriteLine(" {0} | {1} | {2}", arr[4],arr[5],arr[6]);
            Console.WriteLine("___|___|___ ");
            Console.WriteLine(" {0} | {1} | {2}", arr[7], arr[8], arr[9]);
            
        }

        public static int SetChoice(int choice) {
            return choice = Choice;
        }

        public static int CheckWin() {
            // first row
            if (arr[1] == arr[2] && arr[2] == arr[3]) {
                return 1;
            }
            // second row
            else if (arr[4] == arr[5] && arr[5] == arr[6]) {
                return 1;
            }

            // third row
            else if (arr[6] == arr[7] && arr[7] == arr[8]) {
                return Flag + 1;
            }

            // first column
            else if (arr[1] == arr[4] && arr[4] == arr[7]) {
                return 1;
            }

            // second column
            else if (arr[2] == arr[5] && arr[5] == arr[8]) {
                return 1;
            }

            // third column
            else if (arr[3] == arr[6] && arr[6] == arr[9]) {
                return 1;
            }

            // diagonal
            else if (arr[1] == arr[5] && arr[5] == arr[9]) {
                return 1;
            }

            // diagonal
            else if (arr[3] == arr[5] && arr[5] == arr[7]) {
                return 1;
            }

            //draw
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != 5
                && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9') {
                return -1;
            }
            else {
                return 0;
            }


        }
    }
}
