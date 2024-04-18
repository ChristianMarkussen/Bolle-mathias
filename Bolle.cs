using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ultimate_from_scratch
{
    internal class Bolle
    {
        //Variables
        string x = "x";
        string o = "o";
        string skub = "                    ";
        static string blank = " ";
        string push = "█";
        bool ChoosenFelt = false;
        bool PlacedPiece = false;
        int round = 0;
        bool errorChooseFelt = false;

        bool xwin1 = false;
        bool xwin2 = false;
        bool xwin3 = false;
        bool xwin4 = false;
        bool xwin5 = false;
        bool xwin6 = false;
        bool xwin7 = false;
        bool xwin8 = false;
        bool xwin9 = false;

        bool owin1 = false;
        bool owin2 = false;
        bool owin3 = false;
        bool owin4 = false;
        bool owin5 = false;
        bool owin6 = false;
        bool owin7 = false;
        bool owin8 = false;
        bool owin9 = false;

        bool win = false;



        List<string> felt1 = new List<string>() { blank, blank, blank, blank, blank, blank, blank, blank, blank };
        List<string> felt2 = new List<string>() { blank, blank, blank, blank, blank, blank, blank, blank, blank };
        List<string> felt3 = new List<string>() { blank, blank, blank, blank, blank, blank, blank, blank, blank };
        List<string> felt4 = new List<string>() { blank, blank, blank, blank, blank, blank, blank, blank, blank };
        List<string> felt5 = new List<string>() { blank, blank, blank, blank, blank, blank, blank, blank, blank };
        List<string> felt6 = new List<string>() { blank, blank, blank, blank, blank, blank, blank, blank, blank };
        List<string> felt7 = new List<string>() { blank, blank, blank, blank, blank, blank, blank, blank, blank };
        List<string> felt8 = new List<string>() { blank, blank, blank, blank, blank, blank, blank, blank, blank };
        List<string> felt9 = new List<string>() { blank, blank, blank, blank, blank, blank, blank, blank, blank };
        List<int> latestNumber = new List<int>() { 0 };

        //To add something to this list use: latestNumber.Add(input);   Here input is the latest number that is being added to the list
        //To retrieve the latest number in this list use: int lastNumber = latestNumber.Last();



        //Play Method
        public void play()
        {
            //DisplayBoard();
            while (ChoosenFelt == false) { ChooseFelt(); } //This will continue until a correct felt has been choosen
            Console.Clear();
            while (win == false)
            {
                Console.Clear();
                rewrite(); //rewrites felter to X/O
                Board();


                //Add: ChooseListToPlace 
                PlacePiece(); //Add 
                CheckWinnerLittle();
                CheckWinnerFull();

            }
            if (win == true)
            {
                Console.Clear();
                rewrite();
                Board();
                WhoWOn();
            }
        }

        //Below are methods used in play


        //DisplayBoard: This displays what number the felter is
        public void DisplayBoard()
        {
            //ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 |
            //ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 |
            Console.WriteLine($"     |     |      {push}     |     |      {push}     |     |      ");

            string row1 = $"     |     |      {push}     |     |      {push}     |     |      ";
            Console.WriteLine(row1);
            Console.WriteLine($"_____|_____|_____ {push}_____|_____|_____ {push}_____|_____|_____ ");
            Console.WriteLine($"     |     |      {push}     |     |      {push}     |     |      ");
            string row2 = $"     |  1  |      {push}     |  2  |      {push}     |  3  |      ";
            Console.WriteLine(row2);
            Console.WriteLine($"_____|_____|_____ {push}_____|_____|_____ {push}_____|_____|_____ ");
            Console.WriteLine($"     |     |      {push}     |     |      {push}     |     |      ");
            string row3 = $"     |     |      {push}     |     |      {push}     |     |      ";
            Console.WriteLine(row3);
            Console.WriteLine($"     |     |      {push}     |     |      {push}     |     |      ");
            Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");





            //ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 |
            //ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 |
            Console.WriteLine($"     |     |      {push}     |     |      {push}     |     |      ");

            string row4 = $"     |     |      {push}     |     |      {push}     |     |      ";
            Console.WriteLine(row4);
            Console.WriteLine($"_____|_____|_____ {push}_____|_____|_____ {push}_____|_____|_____ ");
            Console.WriteLine($"     |     |      {push}     |     |      {push}     |     |      ");
            string row5 = $"     |  4  |      {push}     |  5  |      {push}     |  6  |      ";
            Console.WriteLine(row5);
            Console.WriteLine($"_____|_____|_____ {push}_____|_____|_____ {push}_____|_____|_____ ");
            Console.WriteLine($"     |     |      {push}     |     |      {push}     |     |      ");
            string row6 = $"     |     |      {push}     |     |      {push}     |     |      ";
            Console.WriteLine(row6);
            Console.WriteLine($"     |     |      {push}     |     |      {push}     |     |      ");
            Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");





            //ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 |
            //ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 |
            Console.WriteLine($"     |     |      {push}     |     |      {push}     |     |      ");

            string row7 = $"     |     |      {push}     |     |      {push}     |     |      ";
            Console.WriteLine(row7);
            Console.WriteLine($"_____|_____|_____ {push}_____|_____|_____ {push}_____|_____|_____ ");
            Console.WriteLine($"     |     |      {push}     |     |      {push}     |     |      ");
            string row8 = $"     |  7  |      {push}     |  8  |      {push}     |  9  |      ";
            Console.WriteLine(row8);
            Console.WriteLine($"_____|_____|_____ {push}_____|_____|_____ {push}_____|_____|_____ ");
            Console.WriteLine($"     |     |      {push}     |     |      {push}     |     |      ");
            string row9 = $"     |     |      {push}     |     |      {push}     |     |      ";
            Console.WriteLine(row9);
            Console.WriteLine($"     |     |      {push}     |     |      {push}     |     |      ");
        }

        //Board: Displays Board
        public void Board()
        {

            //ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 |
            //ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 | ROW 1 |
            Console.WriteLine($"     |     |      {push}     |     |      {push}     |     |      ");

            string row1 = $"  {felt1[0]}  |  {felt1[1]}  |  {felt1[2]}   {push}  {felt2[0]}  |  {felt2[1]}  |  {felt2[2]}   {push}  {felt3[0]}  |  {felt3[1]}  |  {felt3[2]}   ";
            Console.WriteLine(row1);
            Console.WriteLine($"_____|_____|_____ {push}_____|_____|_____ {push}_____|_____|_____ ");
            Console.WriteLine($"     |     |      {push}     |     |      {push}     |     |      ");
            string row2 = $"  {felt1[3]}  |  {felt1[4]}  |  {felt1[5]}   {push}  {felt2[3]}  |  {felt2[4]}  |  {felt2[5]}   {push}  {felt3[3]}  |  {felt3[4]}  |  {felt3[5]}   ";
            Console.WriteLine(row2);
            Console.WriteLine($"_____|_____|_____ {push}_____|_____|_____ {push}_____|_____|_____ ");
            Console.WriteLine($"     |     |      {push}     |     |      {push}     |     |      ");
            string row3 = $"  {felt1[6]}  |  {felt1[7]}  |  {felt1[8]}   {push}  {felt2[6]}  |  {felt2[7]}  |  {felt2[8]}   {push}  {felt3[6]}  |  {felt3[7]}  |  {felt3[8]}   ";
            Console.WriteLine(row3);
            Console.WriteLine($"     |     |      {push}     |     |      {push}     |     |      ");
            Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");





            //ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 |
            //ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 | ROW 2 |
            Console.WriteLine($"     |     |      {push}     |     |      {push}     |     |      {skub}     |     |      ");
            string row4 = $"  {felt4[0]}  |  {felt4[1]}  |  {felt4[2]}   {push}  {felt5[0]}  |  {felt5[1]}  |  {felt5[2]}   {push}  {felt6[0]}  |  {felt6[1]}  |  {felt6[2]}   {skub}  1  |  2  |  3   ";
            Console.WriteLine(row4);
            Console.WriteLine($"_____|_____|_____ {push}_____|_____|_____ {push}_____|_____|_____ {skub}_____|_____|_____ ");
            Console.WriteLine($"     |     |      {push}     |     |      {push}     |     |      {skub}     |     |      ");
            string row5 = $"  {felt4[3]}  |  {felt4[4]}  |  {felt4[5]}   {push}  {felt5[3]}  |  {felt5[4]}  |  {felt5[5]}   {push}  {felt6[3]}  |  {felt6[4]}  |  {felt6[5]}   {skub}  4  |  5  |  6   ";
            Console.WriteLine(row5);
            Console.WriteLine($"_____|_____|_____ {push}_____|_____|_____ {push}_____|_____|_____ {skub}_____|_____|_____ ");
            Console.WriteLine($"     |     |      {push}     |     |      {push}     |     |      {skub}     |     |      ");
            string row6 = $"  {felt4[6]}  |  {felt4[7]}  |  {felt4[8]}   {push}  {felt5[6]}  |  {felt5[7]}  |  {felt5[8]}   {push}  {felt6[6]}  |  {felt6[7]}  |  {felt6[8]}   {skub}  7  |  8  |  9   ";
            Console.WriteLine(row6);
            Console.WriteLine($"     |     |      {push}     |     |      {push}     |     |      {skub}     |     |      ");
            Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");





            //ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 |
            //ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 | ROW 3 |
            Console.WriteLine($"     |     |      {push}     |     |      {push}     |     |      ");
            string row7 = $"  {felt7[0]}  |  {felt7[1]}  |  {felt7[2]}   {push}  {felt8[0]}  |  {felt8[1]}  |  {felt8[2]}   {push}  {felt9[0]}  |  {felt9[1]}  |  {felt9[2]}   ";
            Console.WriteLine(row7);
            Console.WriteLine($"_____|_____|_____ {push}_____|_____|_____ {push}_____|_____|_____ ");
            Console.WriteLine($"     |     |      {push}     |     |      {push}     |     |      ");
            string row8 = $"  {felt7[3]}  |  {felt7[4]}  |  {felt7[5]}   {push}  {felt8[3]}  |  {felt8[4]}  |  {felt8[5]}   {push}  {felt9[3]}  |  {felt9[4]}  |  {felt9[5]}   ";
            Console.WriteLine(row8);
            Console.WriteLine($"_____|_____|_____ {push}_____|_____|_____ {push}_____|_____|_____ ");
            Console.WriteLine($"     |     |      {push}     |     |      {push}     |     |      ");
            string row9 = $"  {felt7[6]}  |  {felt7[7]}  |  {felt7[8]}   {push}  {felt8[6]}  |  {felt8[7]}  |  {felt8[8]}   {push}  {felt9[6]}  |  {felt9[7]}  |  {felt9[8]}   ";
            Console.WriteLine(row9);
            Console.WriteLine($"     |     |      {push}     |     |      {push}     |     |      ");



        }



        //CheckWinnerLittle: Checks for a Winner in every felt
        public bool CheckWinnerLittle()
        {
            //THIS CHECKS FOR X-WINNER
            if (felt1[0] == "x" && felt1[1] == "x" && felt1[2] == "x") { xwin1 = true; }
            if (felt1[3] == "x" && felt1[4] == "x" && felt1[5] == "x") { xwin1 = true; }
            if (felt1[6] == "x" && felt1[7] == "x" && felt1[8] == "x") { xwin1 = true; }
            if (felt1[0] == "x" && felt1[3] == "x" && felt1[6] == "x") { xwin1 = true; }
            if (felt1[1] == "x" && felt1[4] == "x" && felt1[7] == "x") { xwin1 = true; }
            if (felt1[2] == "x" && felt1[5] == "x" && felt1[8] == "x") { xwin1 = true; }
            if (felt1[0] == "x" && felt1[4] == "x" && felt1[8] == "x") { xwin1 = true; }
            if (felt1[2] == "x" && felt1[4] == "x" && felt1[6] == "x") { xwin1 = true; }

            if (felt2[0] == "x" && felt2[1] == "x" && felt2[2] == "x") { xwin2 = true; }
            if (felt2[3] == "x" && felt2[4] == "x" && felt2[5] == "x") { xwin2 = true; }
            if (felt2[6] == "x" && felt2[7] == "x" && felt2[8] == "x") { xwin2 = true; }
            if (felt2[0] == "x" && felt2[3] == "x" && felt2[6] == "x") { xwin2 = true; }
            if (felt2[1] == "x" && felt2[4] == "x" && felt2[7] == "x") { xwin2 = true; }
            if (felt2[2] == "x" && felt2[5] == "x" && felt2[8] == "x") { xwin2 = true; }
            if (felt2[0] == "x" && felt2[4] == "x" && felt2[8] == "x") { xwin2 = true; }
            if (felt2[2] == "x" && felt2[4] == "x" && felt2[6] == "x") { xwin2 = true; }

            if (felt3[0] == "x" && felt3[1] == "x" && felt3[2] == "x") { xwin3 = true; }
            if (felt3[3] == "x" && felt3[4] == "x" && felt3[5] == "x") { xwin3 = true; }
            if (felt3[6] == "x" && felt3[7] == "x" && felt3[8] == "x") { xwin3 = true; }
            if (felt3[0] == "x" && felt3[3] == "x" && felt3[6] == "x") { xwin3 = true; }
            if (felt3[1] == "x" && felt3[4] == "x" && felt3[7] == "x") { xwin3 = true; }
            if (felt3[2] == "x" && felt3[5] == "x" && felt3[8] == "x") { xwin3 = true; }
            if (felt3[0] == "x" && felt3[4] == "x" && felt3[8] == "x") { xwin3 = true; }
            if (felt3[2] == "x" && felt3[4] == "x" && felt3[6] == "x") { xwin3 = true; }

            if (felt4[0] == "x" && felt4[1] == "x" && felt4[2] == "x") { xwin4 = true; }
            if (felt4[3] == "x" && felt4[4] == "x" && felt4[5] == "x") { xwin4 = true; }
            if (felt4[6] == "x" && felt4[7] == "x" && felt4[8] == "x") { xwin4 = true; }
            if (felt4[0] == "x" && felt4[3] == "x" && felt4[6] == "x") { xwin4 = true; }
            if (felt4[1] == "x" && felt4[4] == "x" && felt4[7] == "x") { xwin4 = true; }
            if (felt4[2] == "x" && felt4[5] == "x" && felt4[8] == "x") { xwin4 = true; }
            if (felt4[0] == "x" && felt4[4] == "x" && felt4[8] == "x") { xwin4 = true; }
            if (felt4[2] == "x" && felt4[4] == "x" && felt4[6] == "x") { xwin4 = true; }

            if (felt5[0] == "x" && felt5[1] == "x" && felt5[2] == "x") { xwin5 = true; }
            if (felt5[3] == "x" && felt5[4] == "x" && felt5[5] == "x") { xwin5 = true; }
            if (felt5[6] == "x" && felt5[7] == "x" && felt5[8] == "x") { xwin5 = true; }
            if (felt5[0] == "x" && felt5[3] == "x" && felt5[6] == "x") { xwin5 = true; }
            if (felt5[1] == "x" && felt5[4] == "x" && felt5[7] == "x") { xwin5 = true; }
            if (felt5[2] == "x" && felt5[5] == "x" && felt5[8] == "x") { xwin5 = true; }
            if (felt5[0] == "x" && felt5[4] == "x" && felt5[8] == "x") { xwin5 = true; }
            if (felt5[2] == "x" && felt5[4] == "x" && felt5[6] == "x") { xwin5 = true; }

            if (felt6[0] == "x" && felt6[1] == "x" && felt6[2] == "x") { xwin6 = true; }
            if (felt6[3] == "x" && felt6[4] == "x" && felt6[5] == "x") { xwin6 = true; }
            if (felt6[6] == "x" && felt6[7] == "x" && felt6[8] == "x") { xwin6 = true; }
            if (felt6[0] == "x" && felt6[3] == "x" && felt6[6] == "x") { xwin6 = true; }
            if (felt6[1] == "x" && felt6[4] == "x" && felt6[7] == "x") { xwin6 = true; }
            if (felt6[2] == "x" && felt6[5] == "x" && felt6[8] == "x") { xwin6 = true; }
            if (felt6[0] == "x" && felt6[4] == "x" && felt6[8] == "x") { xwin6 = true; }
            if (felt6[2] == "x" && felt6[4] == "x" && felt6[6] == "x") { xwin6 = true; }

            if (felt7[0] == "x" && felt7[1] == "x" && felt7[2] == "x") { xwin7 = true; }
            if (felt7[3] == "x" && felt7[4] == "x" && felt7[5] == "x") { xwin7 = true; }
            if (felt7[6] == "x" && felt7[7] == "x" && felt7[8] == "x") { xwin7 = true; }
            if (felt7[0] == "x" && felt7[3] == "x" && felt7[6] == "x") { xwin7 = true; }
            if (felt7[1] == "x" && felt7[4] == "x" && felt7[7] == "x") { xwin7 = true; }
            if (felt7[2] == "x" && felt7[5] == "x" && felt7[8] == "x") { xwin7 = true; }
            if (felt7[0] == "x" && felt7[4] == "x" && felt7[8] == "x") { xwin7 = true; }
            if (felt7[2] == "x" && felt7[4] == "x" && felt7[6] == "x") { xwin7 = true; }

            if (felt8[0] == "x" && felt8[1] == "x" && felt8[2] == "x") { xwin8 = true; }
            if (felt8[3] == "x" && felt8[4] == "x" && felt8[5] == "x") { xwin8 = true; }
            if (felt8[6] == "x" && felt8[7] == "x" && felt8[8] == "x") { xwin8 = true; }
            if (felt8[0] == "x" && felt8[3] == "x" && felt8[6] == "x") { xwin8 = true; }
            if (felt8[1] == "x" && felt8[4] == "x" && felt8[7] == "x") { xwin8 = true; }
            if (felt8[2] == "x" && felt8[5] == "x" && felt8[8] == "x") { xwin8 = true; }
            if (felt8[0] == "x" && felt8[4] == "x" && felt8[8] == "x") { xwin8 = true; }
            if (felt8[2] == "x" && felt8[4] == "x" && felt8[6] == "x") { xwin8 = true; }

            if (felt9[0] == "x" && felt9[1] == "x" && felt9[2] == "x") { xwin9 = true; }
            if (felt9[3] == "x" && felt9[4] == "x" && felt9[5] == "x") { xwin9 = true; }
            if (felt9[6] == "x" && felt9[7] == "x" && felt9[8] == "x") { xwin9 = true; }
            if (felt9[0] == "x" && felt9[3] == "x" && felt9[6] == "x") { xwin9 = true; }
            if (felt9[1] == "x" && felt9[4] == "x" && felt9[7] == "x") { xwin9 = true; }
            if (felt9[2] == "x" && felt9[5] == "x" && felt9[8] == "x") { xwin9 = true; }
            if (felt9[0] == "x" && felt9[4] == "x" && felt9[8] == "x") { xwin9 = true; }
            if (felt9[2] == "x" && felt9[4] == "x" && felt9[6] == "x") { xwin9 = true; }


            //THIS CHECKS FOR O-WINNER
            if (felt1[0] == "o" && felt1[1] == "o" && felt1[2] == "o") { owin1 = true; }
            if (felt1[3] == "o" && felt1[4] == "o" && felt1[5] == "o") { owin1 = true; }
            if (felt1[6] == "o" && felt1[7] == "o" && felt1[8] == "o") { owin1 = true; }
            if (felt1[0] == "o" && felt1[3] == "o" && felt1[6] == "o") { owin1 = true; }
            if (felt1[1] == "o" && felt1[4] == "o" && felt1[7] == "o") { owin1 = true; }
            if (felt1[2] == "o" && felt1[5] == "o" && felt1[8] == "o") { owin1 = true; }
            if (felt1[0] == "o" && felt1[4] == "o" && felt1[8] == "o") { owin1 = true; }
            if (felt1[2] == "o" && felt1[4] == "o" && felt1[6] == "o") { owin1 = true; }

            if (felt2[0] == "o" && felt2[1] == "o" && felt2[2] == "o") { owin2 = true; }
            if (felt2[3] == "o" && felt2[4] == "o" && felt2[5] == "o") { owin2 = true; }
            if (felt2[6] == "o" && felt2[7] == "o" && felt2[8] == "o") { owin2 = true; }
            if (felt2[0] == "o" && felt2[3] == "o" && felt2[6] == "o") { owin2 = true; }
            if (felt2[1] == "o" && felt2[4] == "o" && felt2[7] == "o") { owin2 = true; }
            if (felt2[2] == "o" && felt2[5] == "o" && felt2[8] == "o") { owin2 = true; }
            if (felt2[0] == "o" && felt2[4] == "o" && felt2[8] == "o") { owin2 = true; }
            if (felt2[2] == "o" && felt2[4] == "o" && felt2[6] == "o") { owin2 = true; }

            if (felt3[0] == "o" && felt3[1] == "o" && felt3[2] == "o") { owin3 = true; }
            if (felt3[3] == "o" && felt3[4] == "o" && felt3[5] == "o") { owin3 = true; }
            if (felt3[6] == "o" && felt3[7] == "o" && felt3[8] == "o") { owin3 = true; }
            if (felt3[0] == "o" && felt3[3] == "o" && felt3[6] == "o") { owin3 = true; }
            if (felt3[1] == "o" && felt3[4] == "o" && felt3[7] == "o") { owin3 = true; }
            if (felt3[2] == "o" && felt3[5] == "o" && felt3[8] == "o") { owin3 = true; }
            if (felt3[0] == "o" && felt3[4] == "o" && felt3[8] == "o") { owin3 = true; }
            if (felt3[2] == "o" && felt3[4] == "o" && felt3[6] == "o") { owin3 = true; }

            if (felt4[0] == "o" && felt4[1] == "o" && felt4[2] == "o") { owin4 = true; }
            if (felt4[3] == "o" && felt4[4] == "o" && felt4[5] == "o") { owin4 = true; }
            if (felt4[6] == "o" && felt4[7] == "o" && felt4[8] == "o") { owin4 = true; }
            if (felt4[0] == "o" && felt4[3] == "o" && felt4[6] == "o") { owin4 = true; }
            if (felt4[1] == "o" && felt4[4] == "o" && felt4[7] == "o") { owin4 = true; }
            if (felt4[2] == "o" && felt4[5] == "o" && felt4[8] == "o") { owin4 = true; }
            if (felt4[0] == "o" && felt4[4] == "o" && felt4[8] == "o") { owin4 = true; }
            if (felt4[2] == "o" && felt4[4] == "o" && felt4[6] == "o") { owin4 = true; }

            if (felt5[0] == "o" && felt5[1] == "o" && felt5[2] == "o") { owin5 = true; }
            if (felt5[3] == "o" && felt5[4] == "o" && felt5[5] == "o") { owin5 = true; }
            if (felt5[6] == "o" && felt5[7] == "o" && felt5[8] == "o") { owin5 = true; }
            if (felt5[0] == "o" && felt5[3] == "o" && felt5[6] == "o") { owin5 = true; }
            if (felt5[1] == "o" && felt5[4] == "o" && felt5[7] == "o") { owin5 = true; }
            if (felt5[2] == "o" && felt5[5] == "o" && felt5[8] == "o") { owin5 = true; }
            if (felt5[0] == "o" && felt5[4] == "o" && felt5[8] == "o") { owin5 = true; }
            if (felt5[2] == "o" && felt5[4] == "o" && felt5[6] == "o") { owin5 = true; }

            if (felt6[0] == "o" && felt6[1] == "o" && felt6[2] == "o") { owin6 = true; }
            if (felt6[3] == "o" && felt6[4] == "o" && felt6[5] == "o") { owin6 = true; }
            if (felt6[6] == "o" && felt6[7] == "o" && felt6[8] == "o") { owin6 = true; }
            if (felt6[0] == "o" && felt6[3] == "o" && felt6[6] == "o") { owin6 = true; }
            if (felt6[1] == "o" && felt6[4] == "o" && felt6[7] == "o") { owin6 = true; }
            if (felt6[2] == "o" && felt6[5] == "o" && felt6[8] == "o") { owin6 = true; }
            if (felt6[0] == "o" && felt6[4] == "o" && felt6[8] == "o") { owin6 = true; }
            if (felt6[2] == "o" && felt6[4] == "o" && felt6[6] == "o") { owin6 = true; }

            if (felt7[0] == "o" && felt7[1] == "o" && felt7[2] == "o") { owin7 = true; }
            if (felt7[3] == "o" && felt7[4] == "o" && felt7[5] == "o") { owin7 = true; }
            if (felt7[6] == "o" && felt7[7] == "o" && felt7[8] == "o") { owin7 = true; }
            if (felt7[0] == "o" && felt7[3] == "o" && felt7[6] == "o") { owin7 = true; }
            if (felt7[1] == "o" && felt7[4] == "o" && felt7[7] == "o") { owin7 = true; }
            if (felt7[2] == "o" && felt7[5] == "o" && felt7[8] == "o") { owin7 = true; }
            if (felt7[0] == "o" && felt7[4] == "o" && felt7[8] == "o") { owin7 = true; }
            if (felt7[2] == "o" && felt7[4] == "o" && felt7[6] == "o") { owin7 = true; }

            if (felt8[0] == "o" && felt8[1] == "o" && felt8[2] == "o") { owin8 = true; }
            if (felt8[3] == "o" && felt8[4] == "o" && felt8[5] == "o") { owin8 = true; }
            if (felt8[6] == "o" && felt8[7] == "o" && felt8[8] == "o") { owin8 = true; }
            if (felt8[0] == "o" && felt8[3] == "o" && felt8[6] == "o") { owin8 = true; }
            if (felt8[1] == "o" && felt8[4] == "o" && felt8[7] == "o") { owin8 = true; }
            if (felt8[2] == "o" && felt8[5] == "o" && felt8[8] == "o") { owin8 = true; }
            if (felt8[0] == "o" && felt8[4] == "o" && felt8[8] == "o") { owin8 = true; }
            if (felt8[2] == "o" && felt8[4] == "o" && felt8[6] == "o") { owin8 = true; }

            if (felt9[0] == "o" && felt9[1] == "o" && felt9[2] == "o") { owin9 = true; }
            if (felt9[3] == "o" && felt9[4] == "o" && felt9[5] == "o") { owin9 = true; }
            if (felt9[6] == "o" && felt9[7] == "o" && felt9[8] == "o") { owin9 = true; }
            if (felt9[0] == "o" && felt9[3] == "o" && felt9[6] == "o") { owin9 = true; }
            if (felt9[1] == "o" && felt9[4] == "o" && felt9[7] == "o") { owin9 = true; }
            if (felt9[2] == "o" && felt9[5] == "o" && felt9[8] == "o") { owin9 = true; }
            if (felt9[0] == "o" && felt9[4] == "o" && felt9[8] == "o") { owin9 = true; }
            if (felt9[2] == "o" && felt9[4] == "o" && felt9[6] == "o") { owin9 = true; }


            return false;
        }

        //Rewrite a victory-felt to X or O
        //TIP: To make sure nobody can place something inside a felt that has been taken, check with the Last(); method if X or O appears more than 3 times, then the felt can only have been taken.
        //TIP: Change every felt inside to blank and winning side (X or O)
        public void rewrite()
        {
            //ALL THESE REWRITE THE WINNING FELTER TO X
            if (xwin1 == true)
            {
                felt1[0] = "x";
                felt1[1] = blank;
                felt1[2] = "x";
                felt1[3] = blank;
                felt1[4] = "x";
                felt1[5] = blank;
                felt1[6] = "x";
                felt1[7] = blank;
                felt1[8] = "x";
            }
            if (xwin2 == true)
            {
                felt2[0] = "x";
                felt2[1] = blank;
                felt2[2] = "x";
                felt2[3] = blank;
                felt2[4] = "x";
                felt2[5] = blank;
                felt2[6] = "x";
                felt2[7] = blank;
                felt2[8] = "x";
            }
            if (xwin3 == true)
            {
                felt3[0] = "x";
                felt3[1] = blank;
                felt3[2] = "x";
                felt3[3] = blank;
                felt3[4] = "x";
                felt3[5] = blank;
                felt3[6] = "x";
                felt3[7] = blank;
                felt3[8] = "x";
            }
            if (xwin4 == true)
            {
                felt4[0] = "x";
                felt4[1] = blank;
                felt4[2] = "x";
                felt4[3] = blank;
                felt4[4] = "x";
                felt4[5] = blank;
                felt4[6] = "x";
                felt4[7] = blank;
                felt4[8] = "x";
            }
            if (xwin5 == true)
            {
                felt5[0] = "x";
                felt5[1] = blank;
                felt5[2] = "x";
                felt5[3] = blank;
                felt5[4] = "x";
                felt5[5] = blank;
                felt5[6] = "x";
                felt5[7] = blank;
                felt5[8] = "x";
            }
            if (xwin6 == true)
            {
                felt6[0] = "x";
                felt6[1] = blank;
                felt6[2] = "x";
                felt6[3] = blank;
                felt6[4] = "x";
                felt6[5] = blank;
                felt6[6] = "x";
                felt6[7] = blank;
                felt6[8] = "x";
            }
            if (xwin7 == true)
            {
                felt7[0] = "x";
                felt7[1] = blank;
                felt7[2] = "x";
                felt7[3] = blank;
                felt7[4] = "x";
                felt7[5] = blank;
                felt7[6] = "x";
                felt7[7] = blank;
                felt7[8] = "x";
            }
            if (xwin8 == true)
            {
                felt8[0] = "x";
                felt8[1] = blank;
                felt8[2] = "x";
                felt8[3] = blank;
                felt8[4] = "x";
                felt8[5] = blank;
                felt8[6] = "x";
                felt8[7] = blank;
                felt8[8] = "x";
            }
            if (xwin9 == true)
            {
                felt9[0] = "x";
                felt9[1] = blank;
                felt9[2] = "x";
                felt9[3] = blank;
                felt9[4] = "x";
                felt9[5] = blank;
                felt9[6] = "x";
                felt9[7] = blank;
                felt9[8] = "x";
            }

            //ALL THESE REWRITE THE WINNING FELTER TO O
            if (owin1 == true)
            {
                felt1[0] = "o";
                felt1[1] = "o";
                felt1[2] = "o";
                felt1[3] = "o";
                felt1[4] = blank;
                felt1[5] = "o";
                felt1[6] = "o";
                felt1[7] = "o";
                felt1[8] = "o";
            }
            if (owin2 == true)
            {
                felt2[0] = "o";
                felt2[1] = "o";
                felt2[2] = "o";
                felt2[3] = "o";
                felt2[4] = blank;
                felt2[5] = "o";
                felt2[6] = "o";
                felt2[7] = "o";
                felt2[8] = "o";
            }
            if (owin3 == true)
            {
                felt3[0] = "o";
                felt3[1] = "o";
                felt3[2] = "o";
                felt3[3] = "o";
                felt3[4] = blank;
                felt3[5] = "o";
                felt3[6] = "o";
                felt3[7] = "o";
                felt3[8] = "o";
            }
            if (owin4 == true)
            {
                felt4[0] = "o";
                felt4[1] = "o";
                felt4[2] = "o";
                felt4[3] = "o";
                felt4[4] = blank;
                felt4[5] = "o";
                felt4[6] = "o";
                felt4[7] = "o";
                felt4[8] = "o";
            }
            if (owin5 == true)
            {
                felt5[0] = "o";
                felt5[1] = "o";
                felt5[2] = "o";
                felt5[3] = "o";
                felt5[4] = blank;
                felt5[5] = "o";
                felt5[6] = "o";
                felt5[7] = "o";
                felt5[8] = "o";
            }
            if (owin6 == true)
            {
                felt6[0] = "o";
                felt6[1] = "o";
                felt6[2] = "o";
                felt6[3] = "o";
                felt6[4] = blank;
                felt6[5] = "o";
                felt6[6] = "o";
                felt6[7] = "o";
                felt6[8] = "o";
            }
            if (owin7 == true)
            {
                felt7[0] = "o";
                felt7[1] = "o";
                felt7[2] = "o";
                felt7[3] = "o";
                felt7[4] = blank;
                felt7[5] = "o";
                felt7[6] = "o";
                felt7[7] = "o";
                felt7[8] = "o";
            }
            if (owin8 == true)
            {
                felt8[0] = "o";
                felt8[1] = "o";
                felt8[2] = "o";
                felt8[3] = "o";
                felt8[4] = blank;
                felt8[5] = "o";
                felt8[6] = "o";
                felt8[7] = "o";
                felt8[8] = "o";
            }
            if (owin9 == true)
            {
                felt9[0] = "o";
                felt9[1] = "o";
                felt9[2] = "o";
                felt9[3] = "o";
                felt9[4] = blank;
                felt9[5] = "o";
                felt9[6] = "o";
                felt9[7] = "o";
                felt9[8] = "o";
            }


        }


        //CheckWinnerFull: Checks for a Winner on full board
        public void CheckWinnerFull()
        {
            if (xwin1 == true && xwin2 == true && xwin3 == true) { win = true; }
            if (xwin4 == true && xwin5 == true && xwin6 == true) { win = true; }
            if (xwin7 == true && xwin8 == true && xwin9 == true) { win = true; }
            if (xwin1 == true && xwin4 == true && xwin7 == true) { win = true; }
            if (xwin2 == true && xwin5 == true && xwin8 == true) { win = true; }
            if (xwin3 == true && xwin6 == true && xwin9 == true) { win = true; }
            if (xwin1 == true && xwin5 == true && xwin9 == true) { win = true; }
            if (xwin3 == true && xwin5 == true && xwin7 == true) { win = true; }

            if (owin1 == true && owin2 == true && owin3 == true) { win = true; }
            if (owin4 == true && owin5 == true && owin6 == true) { win = true; }
            if (owin7 == true && owin8 == true && owin9 == true) { win = true; }
            if (owin1 == true && owin4 == true && owin7 == true) { win = true; }
            if (owin2 == true && owin5 == true && owin8 == true) { win = true; }
            if (owin3 == true && owin6 == true && owin9 == true) { win = true; }
            if (owin1 == true && owin5 == true && owin9 == true) { win = true; }
            if (owin3 == true && owin5 == true && owin7 == true) { win = true; }

        }

        //Checks number of "x" & "o" in a box
        //This is Used to choose between PlacePiece or Replace

        //PlacePiece: Places piece a piece on board
        //TIP: Here when getting input from the user the number that is choosen, will be the box number the next player has to place in.
        //TIP: So save the number so the player only has to choose which "felt" they want to place in, and tell the next player what box they now will be placing in.
        public void PlacePiece()
        {
            int lastNumber = latestNumber.Last(); //Latest Number in latestNumber list

            int count1x = felt1.Count(item => item == x);
            int count1o = felt1.Count(item => item == o);

            int count2x = felt2.Count(item => item == x);
            int count2o = felt2.Count(item => item == o);

            int count3x = felt3.Count(item => item == x);
            int count3o = felt3.Count(item => item == o);

            int count4x = felt4.Count(item => item == x);
            int count4o = felt4.Count(item => item == o);

            int count5x = felt5.Count(item => item == x);
            int count5o = felt5.Count(item => item == o);

            int count6x = felt6.Count(item => item == x);
            int count6o = felt6.Count(item => item == o);

            int count7x = felt7.Count(item => item == x);
            int count7o = felt7.Count(item => item == o);

            int count8x = felt8.Count(item => item == x);
            int count8o = felt8.Count(item => item == o);

            int count9x = felt9.Count(item => item == x);
            int count9o = felt9.Count(item => item == o);


            if (round % 2 == 0) { Console.WriteLine("Felt " + lastNumber + " | Player X: "); }
            else if (round % 2 == 1) { Console.WriteLine("Felt " + lastNumber + " | Player O: "); }
            //int input = Convert.ToInt32(Console.ReadLine());
            //input--;





            //This if-statement will choose which felt to place "X" inside
            if (lastNumber == 1)
            {
                if (xwin1 == true || owin1 == true)
                {
                    Console.WriteLine("This felt is full. Which felt would you like to place in?");
                    int nextFelt = Convert.ToInt32(Console.ReadLine());
                    if (nextFelt <= 9 && 1 <= nextFelt)
                    {
                        latestNumber.Add(nextFelt); //Adds the number to latestNumber
                    }
                }
                else if (round % 2 == 0) //X-turn
                {
                    if (count1x == 3) //X relocation
                    {
                        Console.WriteLine("Which piece do you want to move?");
                        int takePiece = Convert.ToInt32(Console.ReadLine());
                        takePiece--;
                        Console.WriteLine("Where do you want to move it?");
                        int placePiece = Convert.ToInt32(Console.ReadLine());
                        placePiece--;

                        if (takePiece <= 8 && 0<= takePiece && placePiece <= 8 && 0<= placePiece)
                        {
                            if (felt1[takePiece]==x && felt1[placePiece] == blank)
                            {
                                felt1[takePiece] = blank;
                                felt1[placePiece] = x;
                                placePiece++;
                                latestNumber.Add(placePiece);
                                round++;
                            }
                        }
                    }
                    else if (count1x < 3) //X place piece
                    {
                        int input = Convert.ToInt32(Console.ReadLine());
                        input--;
                        if (felt1[input] == blank)
                        {
                            felt1[input] = x;
                            input++;
                            latestNumber.Add(input);
                            round++;
                        }

                    }
                }
                else if (round % 2 == 1) //O-turn
                {
                    if (count1o == 3) //O relocation
                    {
                        Console.WriteLine("Which piece do you want to move?");
                        int takePiece = Convert.ToInt32(Console.ReadLine());
                        takePiece--;
                        Console.WriteLine("Where do you want to move it?");
                        int placePiece = Convert.ToInt32(Console.ReadLine());
                        placePiece--;

                        if (takePiece <= 8 && 0 <= takePiece && placePiece <= 8 && 0 <= placePiece)
                        {
                            if (felt1[takePiece] == o && felt1[placePiece] == blank)
                            {
                                felt1[takePiece] = blank;
                                felt1[placePiece] = o;
                                placePiece++;
                                latestNumber.Add(placePiece);
                                round++;
                            }
                        }
                    }
                    else if (count1o < 3)
                    {
                        int input = Convert.ToInt32(Console.ReadLine());
                        input--;
                        if (felt1[input] == blank)
                        {
                            felt1[input] = o;
                            input++;
                            latestNumber.Add(input);
                            round++;
                        }
                    }
                }
            }
            else if (lastNumber == 2)
            {
                if (xwin2 == true || owin2 == true)
                {
                    Console.WriteLine("This felt is full. Which felt would you like to place in?");
                    int nextFelt = Convert.ToInt32(Console.ReadLine());
                    if (nextFelt <= 9 && 1 <= nextFelt)
                    {
                        latestNumber.Add(nextFelt); //Adds the number to latestNumber
                    }
                }
                else if (round % 2 == 0) //X-turn
                {
                    if (count2x == 3) //X relocation
                    {
                        Console.WriteLine("Which piece do you want to move?");
                        int takePiece = Convert.ToInt32(Console.ReadLine());
                        takePiece--;
                        Console.WriteLine("Where do you want to move it?");
                        int placePiece = Convert.ToInt32(Console.ReadLine());
                        placePiece--;

                        if (takePiece <= 8 && 0 <= takePiece && placePiece <= 8 && 0 <= placePiece)
                        {
                            if (felt2[takePiece] == x && felt2[placePiece] == blank)
                            {
                                felt2[takePiece] = blank;
                                felt2[placePiece] = x;
                                placePiece++;
                                latestNumber.Add(placePiece);
                                round++;
                            }
                        }
                    }
                    else if (count2x < 3) //X place piece
                    {
                        int input = Convert.ToInt32(Console.ReadLine());
                        input--;
                        if (felt2[input] == blank)
                        {
                            felt2[input] = x;
                            input++;
                            latestNumber.Add(input);
                            round++;
                        }

                    }
                }
                else if (round % 2 == 1) //O-turn
                {
                    if (count2o == 3) // O-relocation
                    {
                        Console.WriteLine("Which piece do you want to move?");
                        int takePiece = Convert.ToInt32(Console.ReadLine());
                        takePiece--;
                        Console.WriteLine("Where do you want to move it?");
                        int placePiece = Convert.ToInt32(Console.ReadLine());
                        placePiece--;

                        if (takePiece <= 8 && 0 <= takePiece && placePiece <= 8 && 0 <= placePiece)
                        {
                            if (felt2[takePiece] == o && felt2[placePiece] == blank)
                            {
                                felt2[takePiece] = blank;
                                felt2[placePiece] = o;
                                placePiece++;
                                latestNumber.Add(placePiece);
                                round++;
                            }
                        }
                    }
                    else if (count2o < 3) //O place piece
                    {
                        int input = Convert.ToInt32(Console.ReadLine());
                        input--;
                        if (felt2[input] == blank)
                        {
                            felt2[input] = o;
                            input++;
                            latestNumber.Add(input);
                            round++;
                        }
                    }
                }
            }
            else if (lastNumber == 3)
            {
                if (xwin3 == true || owin3 == true)
                {
                    Console.WriteLine("This felt is full. Which felt would you like to place in?");
                    int nextFelt = Convert.ToInt32(Console.ReadLine());
                    if (nextFelt <= 9 && 1 <= nextFelt)
                    {
                        latestNumber.Add(nextFelt); //Adds the number to latestNumber
                    }
                }
                else if (round % 2 == 0) //X-turn
                {
                    if (count3x == 3) //X relocation
                    {
                        Console.WriteLine("Which piece do you want to move?");
                        int takePiece = Convert.ToInt32(Console.ReadLine());
                        takePiece--;
                        Console.WriteLine("Where do you want to move it?");
                        int placePiece = Convert.ToInt32(Console.ReadLine());
                        placePiece--;

                        if (takePiece <= 8 && 0 <= takePiece && placePiece <= 8 && 0 <= placePiece)
                        {
                            if (felt3[takePiece] == x && felt3[placePiece] == blank)
                            {
                                felt3[takePiece] = blank;
                                felt3[placePiece] = x;
                                placePiece++;
                                latestNumber.Add(placePiece);
                                round++;
                            }
                        }
                    }
                    else if (count3x < 3) //X place piece
                    {
                        //Write normal place piece code
                        int input = Convert.ToInt32(Console.ReadLine());
                        input--;
                        if (felt3[input] == blank)
                        {
                            felt3[input] = x;
                            input++;
                            latestNumber.Add(input);
                            round++;
                        }

                    }
                }
                else if (round % 2 == 1) //O-turn
                {
                    if (count3o == 3) //O relocation
                    {
                        Console.WriteLine("Which piece do you want to move?");
                        int takePiece = Convert.ToInt32(Console.ReadLine());
                        takePiece--;
                        Console.WriteLine("Where do you want to move it?");
                        int placePiece = Convert.ToInt32(Console.ReadLine());
                        placePiece--;

                        if (takePiece <= 8 && 0 <= takePiece && placePiece <= 8 && 0 <= placePiece)
                        {
                            if (felt3[takePiece] == o && felt3[placePiece] == blank)
                            {
                                felt3[takePiece] = blank;
                                felt3[placePiece] = o;
                                placePiece++;
                                latestNumber.Add(placePiece);
                                round++;
                            }
                        }
                    }
                    else if (count3o < 3) //O place piece
                    {
                        int input = Convert.ToInt32(Console.ReadLine());
                        input--;
                        if (felt3[input] == blank)
                        {
                            felt3[input] = o;
                            input++;
                            latestNumber.Add(input);
                            round++;
                        }
                    }
                }
            }
            else if (lastNumber == 4)
            {
                if (xwin4 == true || owin4 == true)
                {
                    Console.WriteLine("This felt is full. Which felt would you like to place in?");
                    int nextFelt = Convert.ToInt32(Console.ReadLine());
                    if (nextFelt <= 9 && 1 <= nextFelt)
                    {
                        latestNumber.Add(nextFelt); //Adds the number to latestNumber
                    }
                }
                else if (round % 2 == 0) //X-turn
                {
                    if (count4x == 3) //X relocation
                    {
                        Console.WriteLine("Which piece do you want to move?");
                        int takePiece = Convert.ToInt32(Console.ReadLine());
                        takePiece--;
                        Console.WriteLine("Where do you want to move it?");
                        int placePiece = Convert.ToInt32(Console.ReadLine());
                        placePiece--;

                        if (takePiece <= 8 && 0 <= takePiece && placePiece <= 8 && 0 <= placePiece)
                        {
                            if (felt4[takePiece] == x && felt4[placePiece] == blank)
                            {
                                felt4[takePiece] = blank;
                                felt4[placePiece] = x;
                                placePiece++;
                                latestNumber.Add(placePiece);
                                round++;
                            }
                        }
                    }
                    else if (count4x < 3) //X place piece
                    {
                        //Write normal place piece code
                        int input = Convert.ToInt32(Console.ReadLine());
                        input--;
                        if (felt4[input] == blank)
                        {
                            felt4[input] = x;
                            input++;
                            latestNumber.Add(input);
                            round++;
                        }

                    }
                }
                else if (round % 2 == 1) //O-turn
                {
                    if (count4o == 3) //O relocation
                    {
                        Console.WriteLine("Which piece do you want to move?");
                        int takePiece = Convert.ToInt32(Console.ReadLine());
                        takePiece--;
                        Console.WriteLine("Where do you want to move it?");
                        int placePiece = Convert.ToInt32(Console.ReadLine());
                        placePiece--;

                        if (takePiece <= 8 && 0 <= takePiece && placePiece <= 8 && 0 <= placePiece)
                        {
                            if (felt4[takePiece] == o && felt4[placePiece] == blank)
                            {
                                felt4[takePiece] = blank;
                                felt4[placePiece] = o;
                                placePiece++;
                                latestNumber.Add(placePiece);
                                round++;
                            }
                        }
                    }
                    else if (count4o < 3)//O place piece
                    {
                        int input = Convert.ToInt32(Console.ReadLine());
                        input--;
                        if (felt4[input] == blank)
                        {
                            felt4[input] = o;
                            input++;
                            latestNumber.Add(input);
                            round++;
                        }
                    }
                }
            }
            else if (lastNumber == 5)
            {
                if (xwin5 == true || owin5 == true)
                {
                    Console.WriteLine("This felt is full. Which felt would you like to place in?");
                    int nextFelt = Convert.ToInt32(Console.ReadLine());
                    if (nextFelt <= 9 && 1 <= nextFelt)
                    {
                        latestNumber.Add(nextFelt); //Adds the number to latestNumber
                    }
                }
                else if (round % 2 == 0) //X-turn
                {
                    if (count5x == 3)//X relocation
                    {
                        Console.WriteLine("Which piece do you want to move?");
                        int takePiece = Convert.ToInt32(Console.ReadLine());
                        takePiece--;
                        Console.WriteLine("Where do you want to move it?");
                        int placePiece = Convert.ToInt32(Console.ReadLine());
                        placePiece--;

                        if (takePiece <= 8 && 0 <= takePiece && placePiece <= 8 && 0 <= placePiece)
                        {
                            if (felt5[takePiece] == x && felt5[placePiece] == blank)
                            {
                                felt5[takePiece] = blank;
                                felt5[placePiece] = x;
                                placePiece++;
                                latestNumber.Add(placePiece);
                                round++;
                            }
                        }
                    }
                    else if (count5x < 3) //X place piece
                    {
                        //Write normal place piece code
                        int input = Convert.ToInt32(Console.ReadLine());
                        input--;
                        if (felt5[input] == blank)
                        {
                            felt5[input] = x;
                            input++;
                            latestNumber.Add(input);
                            round++;
                        }

                    }
                }
                else if (round % 2 == 1) //O-turn
                {
                    if (count5o == 3) //O relocation
                    {
                        Console.WriteLine("Which piece do you want to move?");
                        int takePiece = Convert.ToInt32(Console.ReadLine());
                        takePiece--;
                        Console.WriteLine("Where do you want to move it?");
                        int placePiece = Convert.ToInt32(Console.ReadLine());
                        placePiece--;

                        if (takePiece <= 8 && 0 <= takePiece && placePiece <= 8 && 0 <= placePiece)
                        {
                            if (felt5[takePiece] == o && felt5[placePiece] == blank)
                            {
                                felt5[takePiece] = blank;
                                felt5[placePiece] = o;
                                placePiece++;
                                latestNumber.Add(placePiece);
                                round++;
                            }
                        }
                    }
                    else if (count5o < 3)//O place piece
                    {
                        int input = Convert.ToInt32(Console.ReadLine());
                        input--;
                        if (felt5[input] == blank)
                        {
                            felt5[input] = o;
                            input++;
                            latestNumber.Add(input);
                            round++;
                        }
                    }
                }
            }
            else if (lastNumber == 6)
            {
                if (xwin6 == true || owin6 == true)
                {
                    Console.WriteLine("This felt is full. Which felt would you like to place in?");
                    int nextFelt = Convert.ToInt32(Console.ReadLine());
                    if (nextFelt <= 9 && 1 <= nextFelt)
                    {
                        latestNumber.Add(nextFelt); //Adds the number to latestNumber
                    }
                }
                else if (round % 2 == 0) //X-turn
                {
                    if (count6x == 3)//x relocation
                    {
                        Console.WriteLine("Which piece do you want to move?");
                        int takePiece = Convert.ToInt32(Console.ReadLine());
                        takePiece--;
                        Console.WriteLine("Where do you want to move it?");
                        int placePiece = Convert.ToInt32(Console.ReadLine());
                        placePiece--;

                        if (takePiece <= 8 && 0 <= takePiece && placePiece <= 8 && 0 <= placePiece)
                        {
                            if (felt6[takePiece] == x && felt6[placePiece] == blank)
                            {
                                felt6[takePiece] = blank;
                                felt6[placePiece] = x;
                                placePiece++;
                                latestNumber.Add(placePiece);
                                round++;
                            }
                        }
                    }
                    else if (count6x < 3)//X place piece
                    {
                        //Write normal place piece code
                        int input = Convert.ToInt32(Console.ReadLine());
                        input--;
                        if (felt6[input] == blank)
                        {
                            felt6[input] = x;
                            input++;
                            latestNumber.Add(input);
                            round++;
                        }

                    }
                }
                else if (round % 2 == 1) //O-turn
                {
                    if (count6o == 3)//O relocation
                    {
                        Console.WriteLine("Which piece do you want to move?");
                        int takePiece = Convert.ToInt32(Console.ReadLine());
                        takePiece--;
                        Console.WriteLine("Where do you want to move it?");
                        int placePiece = Convert.ToInt32(Console.ReadLine());
                        placePiece--;

                        if (takePiece <= 8 && 0 <= takePiece && placePiece <= 8 && 0 <= placePiece)
                        {
                            if (felt6[takePiece] == o && felt6[placePiece] == blank)
                            {
                                felt6[takePiece] = blank;
                                felt6[placePiece] = o;
                                placePiece++;
                                latestNumber.Add(placePiece);
                                round++;
                            }
                        }
                    }
                    else if (count6o < 3)//O place piece
                    {
                        int input = Convert.ToInt32(Console.ReadLine());
                        input--;
                        if (felt6[input] == blank)
                        {
                            felt6[input] = o;
                            input++;
                            latestNumber.Add(input);
                            round++;
                        }
                    }
                }
            }
            else if (lastNumber == 7)
            {
                if (xwin7 == true || owin7 == true)
                {
                    Console.WriteLine("This felt is full. Which felt would you like to place in?");
                    int nextFelt = Convert.ToInt32(Console.ReadLine());
                    if (nextFelt <= 9 && 1 <= nextFelt)
                    {
                        latestNumber.Add(nextFelt); //Adds the number to latestNumber
                    }
                }
                else if (round % 2 == 0) //X-turn
                {
                    if (count7x == 3) //X relocation
                    {
                        Console.WriteLine("Which piece do you want to move?");
                        int takePiece = Convert.ToInt32(Console.ReadLine());
                        takePiece--;
                        Console.WriteLine("Where do you want to move it?");
                        int placePiece = Convert.ToInt32(Console.ReadLine());
                        placePiece--;

                        if (takePiece <= 8 && 0 <= takePiece && placePiece <= 8 && 0 <= placePiece)
                        {
                            if (felt7[takePiece] == x && felt7[placePiece] == blank)
                            {
                                felt7[takePiece] = blank;
                                felt7[placePiece] = x;
                                placePiece++;
                                latestNumber.Add(placePiece);
                                round++;
                            }
                        }
                    }
                    else if (count7x < 3) //X place piece
                    {
                        //Write normal place piece code
                        int input = Convert.ToInt32(Console.ReadLine());
                        input--;
                        if (felt7[input] == blank)
                        {
                            felt7[input] = x;
                            input++;
                            latestNumber.Add(input);
                            round++;
                        }

                    }
                }
                else if (round % 2 == 1) //O-turn
                {
                    if (count7o == 3)//O relocation
                    {
                        Console.WriteLine("Which piece do you want to move?");
                        int takePiece = Convert.ToInt32(Console.ReadLine());
                        takePiece--;
                        Console.WriteLine("Where do you want to move it?");
                        int placePiece = Convert.ToInt32(Console.ReadLine());
                        placePiece--;

                        if (takePiece <= 8 && 0 <= takePiece && placePiece <= 8 && 0 <= placePiece)
                        {
                            if (felt7[takePiece] == o && felt7[placePiece] == blank)
                            {
                                felt7[takePiece] = blank;
                                felt7[placePiece] = o;
                                placePiece++;
                                latestNumber.Add(placePiece);
                                round++;
                            }
                        }
                    }
                    else if (count7o < 3)//O place piece
                    {
                        int input = Convert.ToInt32(Console.ReadLine());
                        input--;
                        if (felt7[input] == blank)
                        {
                            felt7[input] = o;
                            input++;
                            latestNumber.Add(input);
                            round++;
                        }
                    }
                }
            }
            else if (lastNumber == 8)
            {
                if (xwin8 == true || owin8 == true)
                {
                    Console.WriteLine("This felt is full. Which felt would you like to place in?");
                    int nextFelt = Convert.ToInt32(Console.ReadLine());
                    if (nextFelt <= 9 && 1 <= nextFelt)
                    {
                        latestNumber.Add(nextFelt); //Adds the number to latestNumber
                    }
                }
                else if (round % 2 == 0) //X-turn
                {
                    if (count8x == 3) //X relocation
                    {
                        Console.WriteLine("Which piece do you want to move?");
                        int takePiece = Convert.ToInt32(Console.ReadLine());
                        takePiece--;
                        Console.WriteLine("Where do you want to move it?");
                        int placePiece = Convert.ToInt32(Console.ReadLine());
                        placePiece--;

                        if (takePiece <= 8 && 0 <= takePiece && placePiece <= 8 && 0 <= placePiece)
                        {
                            if (felt8[takePiece] == x && felt8[placePiece] == blank)
                            {
                                felt8[takePiece] = blank;
                                felt8[placePiece] = x;
                                placePiece++;
                                latestNumber.Add(placePiece);
                                round++;
                            }
                        }
                    }
                    else if (count8x < 3)//X place piece
                    {
                        //Write normal place piece code
                        int input = Convert.ToInt32(Console.ReadLine());
                        input--;
                        if (felt8[input] == blank)
                        {
                            felt8[input] = x;
                            input++;
                            latestNumber.Add(input);
                            round++;
                        }

                    }
                }
                else if (round % 2 == 1) //O-turn
                {
                    if (count8o == 3)//O relocation
                    {
                        Console.WriteLine("Which piece do you want to move?");
                        int takePiece = Convert.ToInt32(Console.ReadLine());
                        takePiece--;
                        Console.WriteLine("Where do you want to move it?");
                        int placePiece = Convert.ToInt32(Console.ReadLine());
                        placePiece--;

                        if (takePiece <= 8 && 0 <= takePiece && placePiece <= 8 && 0 <= placePiece)
                        {
                            if (felt8[takePiece] == o && felt8[placePiece] == blank)
                            {
                                felt8[takePiece] = blank;
                                felt8[placePiece] = o;
                                placePiece++;
                                latestNumber.Add(placePiece);
                                round++;
                            }
                        }
                    }
                    else if (count8o < 3)//O place piece
                    {
                        int input = Convert.ToInt32(Console.ReadLine());
                        input--;
                        if (felt8[input] == blank)
                        {
                            felt8[input] = o;
                            input++;
                            latestNumber.Add(input);
                            round++;
                        }
                    }
                }
            }
            else if (lastNumber == 9)
            {
                if (xwin9 == true || owin9 == true)
                {
                    Console.WriteLine("This felt is full. Which felt would you like to place in?");
                    int nextFelt = Convert.ToInt32(Console.ReadLine());
                    if (nextFelt <= 9 && 1 <= nextFelt)
                    {
                        latestNumber.Add(nextFelt); //Adds the number to latestNumber
                    }
                }
                else if (round % 2 == 0) //X-turn
                {
                    if (count9x == 3) //X relocation
                    {
                        Console.WriteLine("Which piece do you want to move?");
                        int takePiece = Convert.ToInt32(Console.ReadLine());
                        takePiece--;
                        Console.WriteLine("Where do you want to move it?");
                        int placePiece = Convert.ToInt32(Console.ReadLine());
                        placePiece--;

                        if (takePiece <= 8 && 0 <= takePiece && placePiece <= 8 && 0 <= placePiece)
                        {
                            if (felt9[takePiece] == x && felt9[placePiece] == blank)
                            {
                                felt9[takePiece] = blank;
                                felt9[placePiece] = x;
                                placePiece++;
                                latestNumber.Add(placePiece);
                                round++;
                            }
                        }
                    }
                    else if (count9x < 3) //X place piece
                    {
                        //Write normal place piece code
                        int input = Convert.ToInt32(Console.ReadLine());
                        input--;
                        if (felt9[input] == blank)
                        {
                            felt9[input] = x;
                            input++;
                            latestNumber.Add(input);
                            round++;
                        }

                    }
                }
                else if (round % 2 == 1) //O-turn
                {
                    if (count9o == 3)//O relocation
                    {
                        Console.WriteLine("Which piece do you want to move?");
                        int takePiece = Convert.ToInt32(Console.ReadLine());
                        takePiece--;
                        Console.WriteLine("Where do you want to move it?");
                        int placePiece = Convert.ToInt32(Console.ReadLine());
                        placePiece--;

                        if (takePiece <= 8 && 0 <= takePiece && placePiece <= 8 && 0 <= placePiece)
                        {
                            if (felt9[takePiece] == o && felt9[placePiece] == blank)
                            {
                                felt9[takePiece] = blank;
                                felt9[placePiece] = o;
                                placePiece++;
                                latestNumber.Add(placePiece);
                                round++;
                            }
                        }
                    }
                    else if (count9o < 3)//O place piece
                    {
                        int input = Convert.ToInt32(Console.ReadLine());
                        input--;
                        if (felt9[input] == blank)
                        {
                            felt9[input] = o;
                            input++;
                            latestNumber.Add(input);
                            round++;
                        }
                    }
                }
            }













        }

        //Replace: Relocates a Piece on board
        //TIP: Remember to have checked if the current felt has 3 or more pieces of the currents players pieces.


        //ChooseFelt: Chooses which felt to start in
        public void ChooseFelt()
        {
            DisplayBoard();
            if (errorChooseFelt == true) { Console.WriteLine("Error, you can only enter a number ranging (1-9)"); errorChooseFelt = false; }
            Console.WriteLine("Which felt do you want to start in?");
            string firstinput = Console.ReadLine();
            int number;
            if (int.TryParse(firstinput, out number))
            {
                int input = Convert.ToInt32(firstinput); //Gets input from user
                if (input <= 9 && 1 <= input)
                {
                latestNumber.Add(input); //Adds the number to latestNumber
                ChoosenFelt = true;
                }
                else
                {
                    Console.Clear();
                    errorChooseFelt = true;
                }
                

            }
            else 
            { 
                Console.Clear();
                errorChooseFelt = true;
            }
            
            
        }


        //ChooseListToPlace: This chooses the correct list to place X or O into


        //WhoWon: Writes in console who won the game
        public void WhoWOn()
        {
            if (round % 2 == 0)
            {
                Console.WriteLine("Congratulation, The Winner is Player O!!");
            }
            else
            {
                Console.WriteLine("Congratulation, The Winner is Player X!!");
            }
        }


        //
    }
}
