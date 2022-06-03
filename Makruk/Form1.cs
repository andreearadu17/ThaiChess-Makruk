using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Makruk
{
    public partial class Form1 : Form
    {

        public static int selectedRow;
        public static String selectedColumn;

        public static int initialRow;
        public static String initialColumn;
        public static int initialColumnToNumber;

        public static int finalRow;
        public static String finalColumn;
        public static int finalColumnToNumber;

        public static int playerClick = 0;
        public static String humanColor = "";
        public static String computerColor = "";
        public static String turnToPlay = "";
        static string movespath = Directory.GetCurrentDirectory();
        StreamWriter sw = new StreamWriter(movespath + "\\Resources\\Moves.txt");
        public static String pieceToMove = "";
        piece[] pieseAlbe = new piece[32];
        public static String[,] tabla = new String[8, 8];
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void RedrawThetable(string[,] table)
        {

            string piecePath = "";
            string path = Directory.GetCurrentDirectory();

            for (int i = 0; i <= 7; i++)
            {
                for (int j = 0; j <= 7; j++)
                {
                    piecePath = "";
                    switch (table[(i), (j)])
                    {
                        case "White Pawn":
                            piecePath = "\\Resources\\pion_alb.png";
                            break;
                        case "White Rook":
                            piecePath = "\\Resources\\tura_alba.png";
                            break;

                        case "White Knight":
                            piecePath = "\\Resources\\cal_alb.png";
                            break;

                        case "White Bishop":
                            piecePath = "\\Resources\\nebun_alb.png";
                            break;

                        case "White Queen":
                            piecePath = "\\Resources\\regina_alba.png";
                            break;

                        case "White King":
                            piecePath = "\\Resources\\rege_alb.png";
                            break;

                        case "Black Pawn":
                            piecePath = "\\Resources\\pion_negru.png";
                            break;

                        case "Black Rook":
                            piecePath = "\\Resources\\tura_neagra.png";
                            break;

                        case "Black Knight":
                            piecePath = "\\Resources\\cal_negru.png";
                            break;

                        case "Black Bishop":
                            piecePath = "\\Resources\\nebun_negru.png";
                            break;

                        case "Black Queen":
                            piecePath = "\\Resources\\regina_neagra.png";
                            break;

                        case "Black King":
                            piecePath = "\\Resources\\rege_negru.png";
                            break;

                        case "Promoted Black Pawn":
                            piecePath = "\\Resources\\pion_promovat_negru.gif";
                            break;
                        case "Promoted White Pawn":
                            piecePath = "\\Resources\\pion_promovat_alb.gif";
                            break;

                        case "":
                            piecePath = "\\Resources\\nothing.gif";
                            break;

                    }


                    if ((i == 0) & (j == 0))
                        pictureBoxA1.Load(string.Concat(path, piecePath));
                    else if ((i == 0) & (j == 1))
                        pictureBoxA2.Load(string.Concat(path, piecePath));
                    else if ((i == 0) & (j == 2))
                        pictureBoxA3.Load(string.Concat(path, piecePath));
                    else if ((i == 0) & (j == 3))
                        pictureBoxA4.Load(string.Concat(path, piecePath));
                    else if ((i == 0) & (j == 4))
                        pictureBoxA5.Load(string.Concat(path, piecePath));
                    else if ((i == 0) & (j == 5))
                        pictureBoxA6.Load(string.Concat(path, piecePath));
                    else if ((i == 0) & (j == 6))
                        pictureBoxA7.Load(string.Concat(path, piecePath));
                    else if ((i == 0) & (j == 7))
                        pictureBoxA8.Load(string.Concat(path, piecePath));

                    else if ((i == 1) & (j == 0))
                        pictureBoxB1.Load(string.Concat(path, piecePath));
                    else if ((i == 1) & (j == 1))
                        pictureBoxB2.Load(string.Concat(path, piecePath));
                    else if ((i == 1) & (j == 2))
                        pictureBoxB3.Load(string.Concat(path, piecePath));
                    else if ((i == 1) & (j == 3))
                        pictureBoxB4.Load(string.Concat(path, piecePath));
                    else if ((i == 1) & (j == 4))
                        pictureBoxB5.Load(string.Concat(path, piecePath));
                    else if ((i == 1) & (j == 5))
                        pictureBoxB6.Load(string.Concat(path, piecePath));
                    else if ((i == 1) & (j == 6))
                        pictureBoxB7.Load(string.Concat(path, piecePath));
                    else if ((i == 1) & (j == 7))
                        pictureBoxB8.Load(string.Concat(path, piecePath));

                    else if ((i == 2) & (j == 0))
                        pictureBoxC1.Load(string.Concat(path, piecePath));
                    else if ((i == 2) & (j == 1))
                        pictureBoxC2.Load(string.Concat(path, piecePath));
                    else if ((i == 2) & (j == 2))
                        pictureBoxC3.Load(string.Concat(path, piecePath));
                    else if ((i == 2) & (j == 3))
                        pictureBoxC4.Load(string.Concat(path, piecePath));
                    else if ((i == 2) & (j == 4))
                        pictureBoxC5.Load(string.Concat(path, piecePath));
                    else if ((i == 2) & (j == 5))
                        pictureBoxC6.Load(string.Concat(path, piecePath));
                    else if ((i == 2) & (j == 6))
                        pictureBoxC7.Load(string.Concat(path, piecePath));
                    else if ((i == 2) & (j == 7))
                        pictureBoxC8.Load(string.Concat(path, piecePath));

                    else if ((i == 3) & (j == 0))
                        pictureBoxD1.Load(string.Concat(path, piecePath));
                    else if ((i == 3) & (j == 1))
                        pictureBoxD2.Load(string.Concat(path, piecePath));
                    else if ((i == 3) & (j == 2))
                        pictureBoxD3.Load(string.Concat(path, piecePath));
                    else if ((i == 3) & (j == 3))
                        pictureBoxD4.Load(string.Concat(path, piecePath));
                    else if ((i == 3) & (j == 4))
                        pictureBoxD5.Load(string.Concat(path, piecePath));
                    else if ((i == 3) & (j == 5))
                        pictureBoxD6.Load(string.Concat(path, piecePath));
                    else if ((i == 3) & (j == 6))
                        pictureBoxD7.Load(string.Concat(path, piecePath));
                    else if ((i == 3) & (j == 7))
                        pictureBoxD8.Load(string.Concat(path, piecePath));

                    else if ((i == 4) & (j == 0))
                        pictureBoxE1.Load(string.Concat(path, piecePath));
                    else if ((i == 4) & (j == 1))
                        pictureBoxE2.Load(string.Concat(path, piecePath));
                    else if ((i == 4) & (j == 2))
                        pictureBoxE3.Load(string.Concat(path, piecePath));
                    else if ((i == 4) & (j == 3))
                        pictureBoxE4.Load(string.Concat(path, piecePath));
                    else if ((i == 4) & (j == 4))
                        pictureBoxE5.Load(string.Concat(path, piecePath));
                    else if ((i == 4) & (j == 5))
                        pictureBoxE6.Load(string.Concat(path, piecePath));
                    else if ((i == 4) & (j == 6))
                        pictureBoxE7.Load(string.Concat(path, piecePath));
                    else if ((i == 4) & (j == 7))
                        pictureBoxE8.Load(string.Concat(path, piecePath));

                    else if ((i == 5) & (j == 0))
                        pictureBoxF1.Load(string.Concat(path, piecePath));
                    else if ((i == 5) & (j == 1))
                        pictureBoxF2.Load(string.Concat(path, piecePath));
                    else if ((i == 5) & (j == 2))
                        pictureBoxF3.Load(string.Concat(path, piecePath));
                    else if ((i == 5) & (j == 3))
                        pictureBoxF4.Load(string.Concat(path, piecePath));
                    else if ((i == 5) & (j == 4))
                        pictureBoxF5.Load(string.Concat(path, piecePath));
                    else if ((i == 5) & (j == 5))
                        pictureBoxF6.Load(string.Concat(path, piecePath));
                    else if ((i == 5) & (j == 6))
                        pictureBoxF7.Load(string.Concat(path, piecePath));
                    else if ((i == 5) & (j == 7))
                        pictureBoxF8.Load(string.Concat(path, piecePath));

                    else if ((i == 6) & (j == 0))
                        pictureBoxG1.Load(string.Concat(path, piecePath));
                    else if ((i == 6) & (j == 1))
                        pictureBoxG2.Load(string.Concat(path, piecePath));
                    else if ((i == 6) & (j == 2))
                        pictureBoxG3.Load(string.Concat(path, piecePath));
                    else if ((i == 6) & (j == 3))
                        pictureBoxG4.Load(string.Concat(path, piecePath));
                    else if ((i == 6) & (j == 4))
                        pictureBoxG5.Load(string.Concat(path, piecePath));
                    else if ((i == 6) & (j == 5))
                        pictureBoxG6.Load(string.Concat(path, piecePath));
                    else if ((i == 6) & (j == 6))
                        pictureBoxG7.Load(string.Concat(path, piecePath));
                    else if ((i == 6) & (j == 7))
                        pictureBoxG8.Load(string.Concat(path, piecePath));

                    else if ((i == 7) & (j == 0))
                        pictureBoxH1.Load(string.Concat(path, piecePath));
                    else if ((i == 7) & (j == 1))
                        pictureBoxH2.Load(string.Concat(path, piecePath));
                    else if ((i == 7) & (j == 2))
                        pictureBoxH3.Load(string.Concat(path, piecePath));
                    else if ((i == 7) & (j == 3))
                        pictureBoxH4.Load(string.Concat(path, piecePath));
                    else if ((i == 7) & (j == 4))
                        pictureBoxH5.Load(string.Concat(path, piecePath));
                    else if ((i == 7) & (j == 5))
                        pictureBoxH6.Load(string.Concat(path, piecePath));
                    else if ((i == 7) & (j == 6))
                        pictureBoxH7.Load(string.Concat(path, piecePath));
                    else if ((i == 7) & (j == 7))
                        pictureBoxH8.Load(string.Concat(path, piecePath));
                }
            }
        }
        public static void Starting_position()
        {


            for (int a = 0; a <= 7; a++)
            {
                for (int b = 0; b <= 7; b++)
                {
                    tabla[(a), (b)] = "";
                }
            }

            tabla[(0), (0)] = "White Rook";
            tabla[(0), (2)] = "White Pawn";
            tabla[(0), (5)] = "Black Pawn";
            tabla[(0), (7)] = "Black Rook";
            tabla[(1), (0)] = "White Knight";
            tabla[(1), (2)] = "White Pawn";
            tabla[(1), (5)] = "Black Pawn";
            tabla[(1), (7)] = "Black Knight";
            tabla[(2), (0)] = "White Bishop";
            tabla[(2), (2)] = "White Pawn";
            tabla[(2), (5)] = "Black Pawn";
            tabla[(2), (7)] = "Black Bishop";
            tabla[(3), (0)] = "White King";
            tabla[(3), (2)] = "White Pawn";
            tabla[(3), (5)] = "Black Pawn";
            tabla[(3), (7)] = "Black Queen";
            tabla[(4), (0)] = "White Queen";
            tabla[(4), (2)] = "White Pawn";
            tabla[(4), (5)] = "Black Pawn";
            tabla[(4), (7)] = "Black King";
            tabla[(5), (0)] = "White Bishop";
            tabla[(5), (2)] = "White Pawn";
            tabla[(5), (5)] = "Black Pawn";
            tabla[(5), (7)] = "Black Bishop";
            tabla[(6), (0)] = "White Knight";
            tabla[(6), (2)] = "White Pawn";
            tabla[(6), (5)] = "Black Pawn";
            tabla[(6), (7)] = "Black Knight";
            tabla[(7), (0)] = "White Rook";
            tabla[(7), (2)] = "White Pawn";
            tabla[(7), (5)] = "Black Pawn";

            tabla[(7), (7)] = "Black Rook";


        }
        private void button_Play_Click(object sender, EventArgs e)
        {

            MessageBox.Show("You do the first move. The white pieces are yours!");
            Starting_position();
            RedrawThetable(tabla);
            humanColor = "White";
            turnToPlay = "Human";
            if (turnToPlay == "Computer")
                Initial_Computer_Move();

            Application.DoEvents();

        }

        private List<Move> SavePossibleMoves(piece piesa_calculator, ref List<Move> move)
        {


            switch (piesa_calculator.getNume())
            {
                case "Black Pawn":
                    {
                        checkForPawnMove(tabla, piesa_calculator.getColoana(), piesa_calculator.getLinie(), piesa_calculator, ref move);
                        break;
                    }
                case "Black Rook":
                    {
                        checkForRookMove(tabla, piesa_calculator.getColoana(), piesa_calculator.getLinie(), piesa_calculator, ref move);
                        break;
                    }
                case "Black Queen":
                    {
                        checkForQueenMove(tabla, piesa_calculator.getColoana(), piesa_calculator.getLinie(), piesa_calculator, ref move);
                        break;
                    }
                case "Black Bishop":
                    {
                        checkForBishopMove(tabla, piesa_calculator.getColoana(), piesa_calculator.getLinie(), piesa_calculator, ref move);
                        break;
                    }
                case "Black King":
                    {
                        checkForKingMove(tabla, piesa_calculator.getColoana(), piesa_calculator.getLinie(), piesa_calculator, ref move);
                        break;
                    }
                case "Black Knight":
                    {
                        checkForKnightMove(tabla, piesa_calculator.getColoana(), piesa_calculator.getLinie(), piesa_calculator, ref move);
                        break;
                    }
                case "Promoted Black Pawn":
                    {

                        checkForPromotedPawnMove(tabla, piesa_calculator.getColoana(), piesa_calculator.getLinie(), piesa_calculator, ref move);
                        break;
                    }
            }
            return move;
        }

        public int prio(int coloana, int linie)
        {
            switch (tabla[coloana, linie])
            {
                case "White Queen":
                    return 20;
                case "White King":
                    return 100;
                case "White Rook":
                    return 10;
                case "White Pawn":
                    return 5;
                case "White Bishop":
                    return 30;
                case "White Knight":
                    return 40;
                case "":
                    return 1;
                default: return 0;
            }
        }

        public int ct = -1;
        List<Move> lista_mutari = new List<Move>();
        private void Initial_Computer_Move()
        {
            ct = -1;
            piece[] piese = new piece[16];
            for (int i = 0; i < 16; i++)
            {
                piese[i] = new piece("", 0, 0);
            }
            lista_mutari.Clear();// golim lista la fiecare mutare



            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (tabla[i, j].IndexOf("Black") != -1)
                    {
                        ct++;

                        piese[ct].setName(tabla[i, j]);//in piese[ct] se afla piesa calculatorului pentru care se face lista de mutari posibile
                        piese[ct].setColoana(i);
                        piese[ct].setLinie(j);

                        SavePossibleMoves(piese[ct], ref lista_mutari);//creaza lista cu 1  mutare posibila pentru piesa aflata pe pozitia tabla[i,j] (pentru piesa[ct])
                    }
                }
            }
            int maxim = 0;
            Move piesa_de_atacat = new Move(0, "", null, 0);
            foreach (var aux in lista_mutari)
            {
                if (aux.getPrio() >= maxim)
                {
                    piesa_de_atacat.setLinie(aux.getLinie());
                    piesa_de_atacat.setCol(aux.getCol());
                    piesa_de_atacat.setPrio(aux.getPrio());
                    piesa_de_atacat.setPiesa(aux.getPiesa());
                    maxim = aux.getPrio();

                }

            }
            if (piesa_de_atacat.getPrio() == 1)
            {
                var random = new Random();
                int index = random.Next(lista_mutari.Count);
                piesa_de_atacat.setLinie(lista_mutari[index].getLinie());
                piesa_de_atacat.setCol(lista_mutari[index].getCol());
                piesa_de_atacat.setPrio(lista_mutari[index].getPrio());
                piesa_de_atacat.setPiesa(lista_mutari[index].getPiesa());
            }
            if (tabla[conversion(piesa_de_atacat.getCol()), piesa_de_atacat.getLinie()] == "White King")
            {
                MessageBox.Show("Sah Mat!");
                restartGame();

            }
            else
            {
                Ataca(piesa_de_atacat);
                RedrawThetable(tabla);
                turnToPlay = "Human";
                playerClick = 0;
            }

        }
        private void Ataca(Move piesa)
        {
            Thread.Sleep(2000);
            tabla[conversion(piesa.getCol()), piesa.getLinie()] = piesa.getPiesa().getNume();
            label35.Text = conversion(piesa.getPiesa().getColoana()) + (piesa.getPiesa().getLinie() + 1) + " -> " + (piesa.getCol()) + (piesa.getLinie() + 1);
            tabla[piesa.getPiesa().getColoana(), piesa.getPiesa().getLinie()] = "";
            if (piesa.getPiesa().getNume() == "Black Pawn" && piesa.getLinie() == 2)//promovare
            {
                tabla[conversion(piesa.getCol()), piesa.getLinie()] = "Promoted Black Pawn";
            }
            sw.WriteLine("Computer: " + label35.Text);
        }
        private void restartGame()
        {
            Starting_position();
            RedrawThetable(tabla);
        }
        private void action()
        {
            if (turnToPlay.CompareTo("Human") == 0)
            { // If this is the first click, then it is the starting square
                if (playerClick == 0)
                {
                    initialColumn = selectedColumn;
                    initialRow = selectedRow;
                    playerClick++;
                }
                // If this is the second click, then it is the finishing square
                else if (playerClick == 1)
                {
                    finalColumn = selectedColumn;
                    finalRow = selectedRow;
                    if (conversion(finalColumn) >= 0 && conversion(finalColumn) < 8 && finalRow - 1 >= 0 && finalRow - 1 < 8)
                    {
                        if (tabla[conversion(finalColumn), finalRow - 1] == "Black King")
                        {
                            MessageBox.Show("Sah Mat!");
                            restartGame();


                        }
                        else
                        {
                            playerClick++;
                            Enter_move();
                            label36.Text = initialColumn + initialRow + " -> " + finalColumn + finalRow;
                            sw.WriteLine("Human: " + label36.Text);
                            call_AI();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Not your turn.");
            }

        }

        public void Enter_move()
        {
            if (initialColumn.CompareTo("A") == 0)
                initialColumnToNumber = 1;
            else if (initialColumn.CompareTo("B") == 0)
                initialColumnToNumber = 2;
            else if (initialColumn.CompareTo("C") == 0)
                initialColumnToNumber = 3;
            else if (initialColumn.CompareTo("D") == 0)
                initialColumnToNumber = 4;
            else if (initialColumn.CompareTo("E") == 0)
                initialColumnToNumber = 5;
            else if (initialColumn.CompareTo("F") == 0)
                initialColumnToNumber = 6;
            else if (initialColumn.CompareTo("G") == 0)
                initialColumnToNumber = 7;
            else if (initialColumn.CompareTo("H") == 0)
                initialColumnToNumber = 8;


            if (finalColumn.CompareTo("A") == 0)
                finalColumnToNumber = 1;
            else if (finalColumn.CompareTo("B") == 0)
                finalColumnToNumber = 2;
            else if (finalColumn.CompareTo("C") == 0)
                finalColumnToNumber = 3;
            else if (finalColumn.CompareTo("D") == 0)
                finalColumnToNumber = 4;
            else if (finalColumn.CompareTo("E") == 0)
                finalColumnToNumber = 5;
            else if (finalColumn.CompareTo("F") == 0)
                finalColumnToNumber = 6;
            else if (finalColumn.CompareTo("G") == 0)
                finalColumnToNumber = 7;
            else if (finalColumn.CompareTo("H") == 0)
                finalColumnToNumber = 8;


            pieceToMove = tabla[initialColumnToNumber - 1, initialRow - 1];

            if (pieceToMove == "White Pawn")
            {
                PawnMove();
            }
            else if (pieceToMove.IndexOf("Queen") != -1)
            {
                QueenMove();
            }
            else if (pieceToMove.IndexOf("Knight") != -1)
            {
                HorseMove();
            }
            else if (pieceToMove.IndexOf("Rook") != -1)
            {
                RookMove();
            }
            else if (pieceToMove.IndexOf("King") != -1)
            {
                KingMove();
            }
            else if (pieceToMove.IndexOf("Bishop") != -1)
            {
                BishopMove();
            }
            else if (pieceToMove == "Promoted White Pawn")
            {

                QueenMove();
            }

        }

        //pionul se misca un spatiu inainte sau cand ataca un spatiu inainte pe diagonala 

        public void PawnMove()
        {
            if (finalRow - 1 == 5 && finalColumnToNumber - 1 >= 0 && finalColumnToNumber - 1 < 8) //pion promovat
            {

                tabla[initialColumnToNumber - 1, initialRow - 1] = "";
                pieceToMove = "Promoted White Pawn";
                tabla[finalColumnToNumber - 1, finalRow - 1] = pieceToMove;
                RedrawThetable(tabla);
                playerClick = 0;
                turnToPlay = "Computer";

                return;

            }
            else if (finalRow - 1 < 5)
            //caz inainte
            {
                if (tabla[finalColumnToNumber - 1, finalRow - 1] == "" && finalColumnToNumber == initialColumnToNumber && ((finalRow - initialRow) == 1))
                {
                    {
                        tabla[initialColumnToNumber - 1, initialRow - 1] = "";
                        tabla[finalColumnToNumber - 1, finalRow - 1] = pieceToMove;
                        RedrawThetable(tabla);
                        playerClick = 0;
                        turnToPlay = "Computer";
                    }
                }
                //caz in care ataca
                else if (tabla[finalColumnToNumber - 1, finalRow - 1] != "")
                {
                    if (Math.Abs(finalColumnToNumber - initialColumnToNumber) == 1 && (finalRow - initialRow) == 1)
                    {
                        if (tabla[finalColumnToNumber - 1, finalRow - 1].IndexOf("Black") != -1)// daca pe locul in care vreau sa mut piesa e alta de aceeasi culoare, nu muta
                        {

                            tabla[initialColumnToNumber - 1, initialRow - 1] = "";
                            tabla[finalColumnToNumber - 1, finalRow - 1] = pieceToMove;
                            RedrawThetable(tabla);
                            playerClick = 0;
                            turnToPlay = "Computer";

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid move.");
                playerClick = 0;
            }

        }

        //regina se misca doar un spatiu pe diagonla
        public void QueenMove()
        {
            if (Math.Abs(finalColumnToNumber - initialColumnToNumber) == 1 && Math.Abs((finalRow - initialRow)) == 1) //verific diagonala
            {
                if (tabla[finalColumnToNumber - 1, finalRow - 1] != "" || tabla[finalColumnToNumber - 1, finalRow - 1] == "")
                {
                    if ((tabla[initialColumnToNumber - 1, initialRow - 1].IndexOf("Black") != -1 && tabla[finalColumnToNumber - 1, finalRow - 1].IndexOf("Black") != -1) || (tabla[initialColumnToNumber - 1, initialRow - 1].IndexOf("White") != -1 && tabla[finalColumnToNumber - 1, finalRow - 1].IndexOf("White") != -1))// daca pe locul in care vreau sa mut piesa e alta de aceeasi culoare, nu muta
                    {
                        MessageBox.Show("Move somewhere else");

                    }
                    else
                    {
                        tabla[initialColumnToNumber - 1, initialRow - 1] = "";
                        tabla[finalColumnToNumber - 1, finalRow - 1] = pieceToMove;
                        RedrawThetable(tabla);
                        playerClick = 0;
                        turnToPlay = "Computer";
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid move.");
                playerClick = 0;
            }
        }

        //calul se deplaseaza 2 spatii intr-o directie si un spatiu perpendicular
        public void HorseMove()
        {
            //2 spatii inainte si unul la dreapta/stanga:
            if ((Math.Abs((finalRow - initialRow)) == 2) && (Math.Abs(finalColumnToNumber - initialColumnToNumber) == 1))
            {
                if ((tabla[initialColumnToNumber - 1, initialRow - 1].IndexOf("Black") != -1 && tabla[finalColumnToNumber - 1, finalRow - 1].IndexOf("Black") != -1) || (tabla[initialColumnToNumber - 1, initialRow - 1].IndexOf("White") != -1 && tabla[finalColumnToNumber - 1, finalRow - 1].IndexOf("White") != -1))// daca pe locul in care vreau sa mut piesa e alta de aceeasi culoare, nu muta
                {
                    MessageBox.Show("Move somewhere else");

                }
                else
                {
                    tabla[initialColumnToNumber - 1, initialRow - 1] = "";
                    tabla[finalColumnToNumber - 1, finalRow - 1] = pieceToMove;
                    RedrawThetable(tabla);
                    playerClick = 0;
                    turnToPlay = "Computer";
                }
            }
            //2 spatii pe orizontala, unul inainte/inapoi
            else if ((Math.Abs(finalColumnToNumber - initialColumnToNumber) == 2) && (Math.Abs(finalRow - initialRow) == 1))
            {
                if ((tabla[initialColumnToNumber - 1, initialRow - 1].IndexOf("Black") != -1 && tabla[finalColumnToNumber - 1, finalRow - 1].IndexOf("Black") != -1) || (tabla[initialColumnToNumber - 1, initialRow - 1].IndexOf("White") != -1 && tabla[finalColumnToNumber - 1, finalRow - 1].IndexOf("White") != -1))// daca pe locul in care vreau sa mut piesa e alta de aceeasi culoare, nu muta
                {
                    MessageBox.Show("Move somewhere else");

                }
                else
                {
                    tabla[initialColumnToNumber - 1, initialRow - 1] = "";
                    tabla[finalColumnToNumber - 1, finalRow - 1] = pieceToMove;
                    RedrawThetable(tabla);
                    playerClick = 0;
                    turnToPlay = "Computer";
                }
            }
            else
            {
                MessageBox.Show("Invalid move.");
                playerClick = 0;
            }

        }

        //se deplaseaza o singura casuta, pe verticala, orizontala, sau diagonala, in orice directie

        public void KingMove()
        {
            if ((finalColumnToNumber - 1 == initialColumnToNumber - 1 || finalColumnToNumber - 1 == initialColumnToNumber - 2 || finalColumnToNumber - 1 == initialColumnToNumber) && (finalRow - 1 == initialRow - 2 || finalRow - 1 == initialRow - 1 || finalRow - 1 == initialRow))
            {
                if ((tabla[initialColumnToNumber - 1, initialRow - 1].IndexOf("Black") != -1 && tabla[finalColumnToNumber - 1, finalRow - 1].IndexOf("Black") != -1) || (tabla[initialColumnToNumber - 1, initialRow - 1].IndexOf("White") != -1 && tabla[finalColumnToNumber - 1, finalRow - 1].IndexOf("White") != -1))
                {
                    MessageBox.Show("Move somewhere else");

                }
                else
                {
                    tabla[initialColumnToNumber - 1, initialRow - 1] = "";
                    tabla[finalColumnToNumber - 1, finalRow - 1] = pieceToMove;
                    RedrawThetable(tabla);
                    playerClick = 0;
                    turnToPlay = "Computer";
                }
            }
            else
            {
                MessageBox.Show("Invalid move.");
                playerClick = 0;
            }
        }
        //se misca o casuta in orice directie pe diagonala sau o casuta in fata
        public void BishopMove()
        {
            if ((finalColumnToNumber == initialColumnToNumber) && /*Math.Abs*/(finalRow - initialRow) == 1)
            {
                if ((tabla[finalColumnToNumber - 1, finalRow - 1] == "") || (tabla[finalColumnToNumber - 1, finalRow - 1] != "" && tabla[finalColumnToNumber - 1, finalRow - 1].IndexOf("Black") != -1))
                {
                    tabla[initialColumnToNumber - 1, initialRow - 1] = "";
                    tabla[finalColumnToNumber - 1, finalRow - 1] = pieceToMove;
                    RedrawThetable(tabla);
                    playerClick = 0;
                    turnToPlay = "Computer";
                }
            }
            else if (Math.Abs(finalColumnToNumber - initialColumnToNumber) == 1 && Math.Abs(finalRow - initialRow) == 1)
            {

                if ((tabla[finalColumnToNumber - 1, finalRow - 1] == "") || (tabla[finalColumnToNumber - 1, finalRow - 1] != "" && tabla[finalColumnToNumber - 1, finalRow - 1].IndexOf("Black") != -1))
                {
                    tabla[initialColumnToNumber - 1, initialRow - 1] = "";
                    tabla[finalColumnToNumber - 1, finalRow - 1] = pieceToMove;
                    RedrawThetable(tabla);
                    playerClick = 0;
                    turnToPlay = "Computer";
                }
            }
            else
            {
                MessageBox.Show("Invalid move.");
                playerClick = 0;
            }
        }

        //se deplaseaza oricat, ortogonal
        public void RookMove()
        {
            if (((Math.Abs(finalRow - initialRow) == 0) && (Math.Abs(finalColumnToNumber - initialColumnToNumber) < 8)) ||
                  ((Math.Abs(finalRow - initialRow) < 8) && (Math.Abs(finalColumnToNumber - initialColumnToNumber) == 0)))
            {
                if (tabla[finalColumnToNumber - 1, finalRow - 1].IndexOf("Black") != -1 || tabla[finalColumnToNumber - 1, finalRow - 1] == "")
                {
                    tabla[initialColumnToNumber - 1, initialRow - 1] = "";
                    tabla[finalColumnToNumber - 1, finalRow - 1] = pieceToMove;
                    RedrawThetable(tabla);
                    playerClick = 0;
                    turnToPlay = "Computer";
                }
                else
                {
                    MessageBox.Show("Move somewhere else");
                }
            }
            else
            {
                MessageBox.Show("Invalid move.");
                playerClick = 0;
            }

        }


        private void call_AI()
        {
            playerClick = 0;
            RedrawThetable(tabla);
            label2.Text = "Thinking...";
            Application.DoEvents();
            Initial_Computer_Move();
            RedrawThetable(tabla);
            label2.Text = "";
        }

        public String conversion(int j)
        {
            String str = "";
            switch (j)
            {
                case 0:
                    {
                        str = "A";
                        break;
                    }
                case 1:
                    {
                        str = "B";
                        break;
                    }
                case 2:
                    {
                        str = "C";
                        break;
                    }
                case 3:
                    {
                        str = "D";
                        break;
                    }
                case 4:
                    {
                        str = "E";
                        break;
                    }
                case 5:
                    {
                        str = "F";
                        break;
                    }
                case 6:
                    {
                        str = "G";
                        break;
                    }
                case 7:
                    {
                        str = "H";
                        break;
                    }
            }
            return str;
        }

        public int conversion(string j)
        {
            int col = 0;
            switch (j)
            {
                case "A":
                    {
                        col = 0;
                        break;
                    }
                case "B":
                    {
                        col = 1;
                        break;
                    }
                case "C":
                    {
                        col = 2;
                        break;
                    }
                case "D":
                    {
                        col = 3;
                        break;
                    }
                case "E":
                    {
                        col = 4;
                        break;
                    }
                case "F":
                    {
                        col = 5;
                        break;
                    }
                case "G":
                    {
                        col = 6;
                        break;
                    }
                case "H":
                    {
                        col = 7;
                        break;
                    }
            }
            return col;
        }



        //***********************************************************************************
        //********************************FUNCTII DE CHECK NOI*******************************
        //***********************************************************************************
        private List<Move> checkForPawnMove(string[,] currentBoard, int i, int j, piece piesa, ref List<Move> pawn_moves)
        {
            int prioritate = 0;


            if ((i - 1 >= 0) && (j - 1 >= 2))
            {
                if (currentBoard[i - 1, j - 1] != "" && currentBoard[i - 1, j - 1].IndexOf(humanColor) != -1)
                {
                    prioritate = prio(i - 1, j - 1);
                    pawn_moves.Add(new Makruk.Move(j - 1, conversion(i - 1), piesa, prioritate));

                }
            }
            if ((i + 1 < 8) && (j - 1 >= 0))
            {
                if (currentBoard[i + 1, j - 1] != "" && currentBoard[i + 1, j - 1].IndexOf(humanColor) != -1)
                {
                    prioritate = prio(i + 1, j - 1);
                    pawn_moves.Add(new Makruk.Move(j - 1, conversion(i + 1), piesa, prioritate));

                }
            }
            if (j - 1 >= 2 && currentBoard[i, j - 1] == "")
            {
                prioritate = prio(i, j - 1);
                pawn_moves.Add(new Makruk.Move(j - 1, conversion(i), piesa, prioritate));

            }

            return pawn_moves;
        }

        private List<Move> checkForRookMove(string[,] currentBoard, int i, int j, piece piesa, ref List<Move> rook_moves)
        {
            int prioritate = 0;


            for (int casuta = 1; casuta <= j; casuta++)  //atac in fata
            {
                if (currentBoard[i, (j - casuta)] != "" && currentBoard[i, (j - casuta)].IndexOf(humanColor) != -1)
                {
                    prioritate = prio(i, j - casuta);
                    rook_moves.Add(new Makruk.Move((j - casuta), conversion(i), piesa, prioritate));

                    break;

                }
                else if (currentBoard[i, (j - casuta)] == "")
                {
                    prioritate = prio(i, j - casuta);
                    rook_moves.Add(new Makruk.Move(j - casuta, conversion(i), piesa, prioritate));
                }
                else if (currentBoard[i, (j - casuta)].IndexOf(computerColor) != -1)
                {
                    break;
                }
            }

            for (int casuta = 1; casuta < 8 - j; casuta++) //atac in spate
            {
                if (currentBoard[i, (j + casuta)] != "" && currentBoard[i, (j + casuta)].IndexOf(humanColor) != -1)
                {
                    prioritate = prio(i, j + casuta);
                    rook_moves.Add(new Makruk.Move((j + casuta), conversion(i), piesa, prioritate));

                    break;

                }
                else if (currentBoard[i, j + casuta] == "")
                {
                    prioritate = prio(i, j + casuta);
                    rook_moves.Add(new Makruk.Move(j + casuta, conversion(i), piesa, prioritate));
                }
                else if (currentBoard[i, (j + casuta)].IndexOf(computerColor) != -1)
                {
                    break;
                }
            }

            for (int casuta = 1; casuta <= i; casuta++) //atac in stanga
            {
                if (currentBoard[i - casuta, (j)] != "" && currentBoard[i - casuta, j].IndexOf(humanColor) != -1)
                {
                    prioritate = prio(i - casuta, j);
                    rook_moves.Add(new Makruk.Move(j, conversion(i - casuta), piesa, prioritate));

                    break;
                }
                else if (currentBoard[i - casuta, j] == "")
                {
                    prioritate = prio(i - casuta, j);
                    rook_moves.Add(new Makruk.Move(j, conversion(i - casuta), piesa, prioritate));

                }
                else if (currentBoard[i - casuta, (j)].IndexOf(computerColor) != -1)
                {
                    break;
                }
            }

            for (int casuta = 1; casuta < 8 - i; casuta++) //atac in dreapta
            {
                if (currentBoard[i + casuta, j] != "" && currentBoard[i + casuta, j].IndexOf(humanColor) != -1)
                {
                    prioritate = prio(i + casuta, j);
                    rook_moves.Add(new Makruk.Move(j, conversion(i + casuta), piesa, prioritate));

                    break;

                }
                else if (currentBoard[i + casuta, j] == "")
                {
                    prioritate = prio(i + casuta, j);
                    rook_moves.Add(new Makruk.Move(j, conversion(i + casuta), piesa, prioritate));
                }
                else if (currentBoard[i + casuta, (j)].IndexOf(computerColor) != -1)
                {
                    break;
                }
            }
            return rook_moves;
        }

        private List<Move> checkForQueenMove(string[,] currentBoard, int i, int j, piece piesa, ref List<Move> queen_moves)
        {
            bool queen_attack = false;
            int prioritate = 0;
            //atac diagonala in fata
            if (i - 1 >= 0 && j - 1 >= 0)
            {
                if (currentBoard[i - 1, j - 1] != "" && currentBoard[i - 1, j - 1].IndexOf(humanColor) != -1)
                {
                    prioritate = prio(i - 1, j - 1);
                    queen_moves.Add(new Makruk.Move(j - 1, conversion(i - 1), piesa, prioritate));
                    queen_attack = true;

                }
                if (currentBoard[i - 1, j - 1] == "" && queen_attack != true)
                {
                    prioritate = prio(i - 1, j - 1);
                    queen_moves.Add(new Makruk.Move(j - 1, conversion(i - 1), piesa, prioritate));

                }
            }
            if (i + 1 < 8 && j - 1 >= 0)
            {
                if (currentBoard[i + 1, j - 1] != "" && currentBoard[i + 1, j - 1].IndexOf(humanColor) != -1)
                {
                    prioritate = prio(i + 1, j - 1);
                    queen_moves.Add(new Makruk.Move(j - 1, conversion(i + 1), piesa, prioritate));
                    queen_attack = true;

                }
                else if (currentBoard[i + 1, j - 1] == "" && queen_attack != true)
                {
                    prioritate = prio(i + 1, j - 1);
                    queen_moves.Add(new Makruk.Move(j - 1, conversion(i + 1), piesa, prioritate));

                }
            }
            //atac diagonala inapoi
            if (i + 1 < 8 && j + 1 < 8)
            {
                if (currentBoard[i + 1, j + 1] != "" && currentBoard[i + 1, j + 1].IndexOf(humanColor) != -1)
                {
                    prioritate = prio(i + 1, j + 1);
                    queen_moves.Add(new Makruk.Move(j + 1, conversion(i + 1), piesa, prioritate));
                    queen_attack = true;
                }
                if (currentBoard[i + 1, j + 1] == "" && queen_attack != true)
                {
                    prioritate = prio(i + 1, j + 1);
                    queen_moves.Add(new Makruk.Move(j + 1, conversion(i + 1), piesa, prioritate));
                }
            }

            if (i - 1 >= 0 && j + 1 < 8)
            {
                if (currentBoard[i - 1, j + 1] != "" && currentBoard[i - 1, j + 1].IndexOf(humanColor) != -1)
                {
                    prioritate = prio(i - 1, j + 1);
                    queen_moves.Add(new Makruk.Move(j + 1, conversion(i - 1), piesa, prioritate));
                    queen_attack = true;
                }
                if (currentBoard[i - 1, j + 1] == "" && queen_attack != true)
                {
                    prioritate = prio(i - 1, j + 1);
                    queen_moves.Add(new Makruk.Move(j + 1, conversion(i - 1), piesa, prioritate));
                }
            }

            return queen_moves;
        }

        private List<Move> checkForKnightMove(string[,] currentBoard, int i, int j, piece piesa, ref List<Move> knight_moves)
        {
            bool knight_attack = false;
            int prioritate = 0;
            if ((i - 2 >= 0) && (j + 1 < 8) && currentBoard[i - 2, j + 1] != "" && currentBoard[i - 2, j + 1].IndexOf("Black") == -1)
            {
                prioritate = prio(i - 2, j + 1);
                knight_moves.Add(new Makruk.Move(j + 1, conversion(i - 2), piesa, prioritate));
                knight_attack = true;
            }
            if ((i - 2 >= 0) && (j - 1 >= 0) && currentBoard[i - 2, j - 1] != "" && currentBoard[i - 2, j - 1].IndexOf("Black") == -1)
            {
                prioritate = prio(i - 2, j - 1);
                knight_moves.Add(new Makruk.Move(j - 1, conversion(i - 2), piesa, prioritate));
                knight_attack = true;
            }
            if ((i + 2 < 8) && (j + 1 < 8) && currentBoard[i + 2, j + 1] != "" && currentBoard[i + 2, j + 1].IndexOf("Black") == -1)
            {
                prioritate = prio(i + 2, j + 1);
                knight_moves.Add(new Makruk.Move(j + 1, conversion(i + 2), piesa, prioritate));
                knight_attack = true;
            }
            if ((i + 2 < 8) && (j - 1 >= 0) && currentBoard[i + 2, j - 1] != "" && currentBoard[i + 2, j - 1].IndexOf("Black") == -1)
            {
                prioritate = prio(i + 2, j - 1);
                knight_moves.Add(new Makruk.Move(j - 1, conversion(i + 2), piesa, prioritate));
                knight_attack = true;
            }
            if ((i - 1 >= 0) && (j - 2 >= 0) && currentBoard[i - 1, j - 2] != "" && currentBoard[i - 1, j - 2].IndexOf("Black") == -1)
            {
                prioritate = prio(i - 1, j - 2);
                knight_moves.Add(new Makruk.Move(j - 2, conversion(i - 1), piesa, prioritate));
                knight_attack = true;
            }
            if ((i + 1 < 8) && (j - 2 >= 0) && currentBoard[i + 1, j - 2] != "" && currentBoard[i + 1, j - 2].IndexOf("Black") == -1)
            {
                prioritate = prio(i + 1, j - 2);
                knight_moves.Add(new Makruk.Move(j - 2, conversion(i + 1), piesa, prioritate));
                knight_attack = true;
            }
            if ((i - 1 >= 0) && (j + 2 < 8) && currentBoard[i - 1, j + 2] != "" && currentBoard[i - 1, j + 2].IndexOf("Black") == -1)
            {
                prioritate = prio(i - 1, j + 2);
                knight_moves.Add(new Makruk.Move(j + 2, conversion(i - 1), piesa, prioritate));
                knight_attack = true;
            }
            if ((i + 1 < 8) && (j + 2 < 8) && currentBoard[i + 1, j + 2] != "" && currentBoard[i + 1, j + 2].IndexOf("Black") == -1)
            {
                prioritate = prio(i + 1, j + 2);
                knight_moves.Add(new Makruk.Move(j + 2, conversion(i + 1), piesa, prioritate));
                knight_attack = true;
            }
            if (knight_attack != true)
            {
                if ((i - 1 >= 0) && (j - 2 >= 0) && currentBoard[i - 1, j - 2].IndexOf("Black") == -1)
                    knight_moves.Add(new Makruk.Move(j - 2, conversion(i - 1), piesa, prioritate));
                if ((i - 1 >= 0) && (j + 2 < 8) && currentBoard[i - 1, j + 2].IndexOf("Black") == -1)
                    knight_moves.Add(new Makruk.Move(j + 2, conversion(i - 1), piesa, prioritate));
                if ((i + 1 < 8) && (j + 2 < 8) && currentBoard[i + 1, j + 2].IndexOf("Black") == -1)
                    knight_moves.Add(new Makruk.Move(j + 2, conversion(i + 1), piesa, prioritate));
                if ((i + 1 < 8) && (j - 2 >= 0) && currentBoard[i + 1, j - 2].IndexOf("Black") == -1)
                    knight_moves.Add(new Makruk.Move(j - 2, conversion(i + 1), piesa, prioritate));
                if ((i + 2 < 8) && (j - 1 >= 0) && currentBoard[i + 2, j - 1].IndexOf("Black") == -1)
                    knight_moves.Add(new Makruk.Move(j - 1, conversion(i + 2), piesa, prioritate));
                if ((i + 2 < 8) && (j + 1 < 8) && currentBoard[i + 2, j + 1].IndexOf("Black") == -1)
                    knight_moves.Add(new Makruk.Move(j + 1, conversion(i + 2), piesa, prioritate));
                if ((i - 2 >= 0) && (j - 1 >= 0) && currentBoard[i - 2, j - 1].IndexOf("Black") == -1)
                    knight_moves.Add(new Makruk.Move(j - 1, conversion(i - 2), piesa, prioritate));
                if ((i - 2 >= 0) && (j + 1 < 8) && currentBoard[i - 2, j + 1].IndexOf("Black") == -1)
                    knight_moves.Add(new Makruk.Move(j + 1, conversion(i - 2), piesa, prioritate));

            }

            return knight_moves;
        }

        private List<Move> checkForBishopMove(string[,] currentBoard, int i, int j, piece piesa, ref List<Move> bishop_moves)
        {
            bool bishop_attack = false;
            int prioritate = 0;

            if ((i - 1 >= 0) && (j - 1 >= 0)) //  in fata pe diagonala
            {
                if (currentBoard[i - 1, j - 1] != "" && currentBoard[i - 1, j - 1].IndexOf(humanColor) != -1)
                {
                    prioritate = prio(i - 1, j - 1);
                    bishop_moves.Add(new Makruk.Move(j - 1, conversion(i - 1), piesa, prioritate));
                    bishop_attack = true;
                }
                if (currentBoard[i - 1, j - 1] == "" && bishop_attack != true)
                {
                    prioritate = prio(i - 1, j - 1);
                    bishop_moves.Add(new Makruk.Move(j - 1, conversion(i - 1), piesa, prioritate));
                }
            }
            if ((i + 1 < 8) && (j - 1 >= 0)) // in fata pe diagonala
            {
                if (currentBoard[i + 1, j - 1] != "" && currentBoard[i + 1, j - 1].IndexOf(humanColor) != -1) //atac diagonala jos
                {
                    prioritate = prio(i + 1, j - 1);
                    bishop_moves.Add(new Makruk.Move(j - 1, conversion(i + 1), piesa, prioritate));
                    bishop_attack = true;
                }
                if (currentBoard[i + 1, j - 1] == "" && bishop_attack != true)
                {
                    prioritate = prio(i + 1, j - 1);
                    bishop_moves.Add(new Makruk.Move(j - 1, conversion(i + 1), piesa, prioritate));
                }
            }
            if ((i + 1 < 8) && (j + 1 < 8)) // in spate pe diagonala
            {
                if (currentBoard[i + 1, j + 1] != "" && currentBoard[i + 1, j + 1].IndexOf(humanColor) != -1) //atac diagonala sus
                {
                    prioritate = prio(i + 1, j + 1);
                    bishop_moves.Add(new Makruk.Move(j + 1, conversion(i + 1), piesa, prioritate));
                    bishop_attack = true;
                }
                if (currentBoard[i + 1, j + 1] == "" && bishop_attack != true)
                {
                    prioritate = prio(i + 1, j + 1);
                    bishop_moves.Add(new Makruk.Move(j + 1, conversion(i + 1), piesa, prioritate));

                }
            }
            if ((i - 1 >= 0) && (j + 1 < 8)) //in spate pe diagonala
            {
                if (currentBoard[i - 1, j + 1] != "" && currentBoard[i - 1, j + 1].IndexOf(humanColor) != -1) //atac diagonala sus
                {
                    prioritate = prio(i - 1, j + 1);
                    bishop_moves.Add(new Makruk.Move(j + 1, conversion(i - 1), piesa, prioritate));
                    bishop_attack = true;
                }
                if (currentBoard[i - 1, j + 1] == "" && bishop_attack != true)
                {
                    prioritate = prio(i - 1, j + 1);
                    bishop_moves.Add(new Makruk.Move(j + 1, conversion(i - 1), piesa, prioritate));

                }
            }

            if ((j - 1 >= 0)) //in fata
            {
                if (currentBoard[i, j - 1] != "" && currentBoard[i, j - 1].IndexOf(humanColor) != -1)//atac inainte
                {
                    prioritate = prio(i, j - 1);
                    bishop_moves.Add(new Makruk.Move(j - 1, conversion(i), piesa, prioritate));
                    bishop_attack = true;
                }
                if (currentBoard[i, j - 1] == "" && bishop_attack != true)
                {
                    prioritate = prio(i, j - 1);
                    bishop_moves.Add(new Makruk.Move(j - 1, conversion(i), piesa, prioritate));

                }
            }
            return bishop_moves;
        }

        private List<Move> checkForKingMove(string[,] currentBoard, int i, int j, piece piesa, ref List<Move> king_moves)
        {
            bool king_attack = false;
            int prioritate = 0;
            if ((i - 1 >= 0) && (j - 1 >= 0)) //  in fata pe diagonala
            {
                if (currentBoard[i - 1, j - 1] != "" && currentBoard[i - 1, j - 1].IndexOf(humanColor) != -1)
                {
                    prioritate = prio(i - 1, j - 1);
                    king_moves.Add(new Makruk.Move(j - 1, conversion(i - 1), piesa, prioritate));
                    king_attack = true;
                }
                if (currentBoard[i - 1, j - 1] == "" && king_attack != true)
                {
                    prioritate = prio(i - 1, j - 1);
                    king_moves.Add(new Makruk.Move(j - 1, conversion(i - 1), piesa, prioritate));
                }
            }
            if ((i + 1 < 8) && (j - 1 >= 0)) // in fata pe diagonala
            {
                if (currentBoard[i + 1, j - 1] != "" && currentBoard[i + 1, j - 1].IndexOf(humanColor) != -1) //atac diagonala jos
                {
                    prioritate = prio(i + 1, j - 1);
                    king_moves.Add(new Makruk.Move(j - 1, conversion(i + 1), piesa, prioritate));
                    king_attack = true;
                }
                if (currentBoard[i + 1, j - 1] == "" && king_attack != true)
                {
                    prioritate = prio(i + 1, j - 1);
                    king_moves.Add(new Makruk.Move(j - 1, conversion(i + 1), piesa, prioritate));
                }
            }
            if ((i + 1 < 8) && (j + 1 < 8)) // in spate pe diagonala
            {
                if (currentBoard[i + 1, j + 1] != "" && currentBoard[i + 1, j + 1].IndexOf(humanColor) != -1) //atac diagonala sus
                {
                    prioritate = prio(i + 1, j + 1);
                    king_moves.Add(new Makruk.Move(j + 1, conversion(i + 1), piesa, prioritate));
                    king_attack = true;
                }
                if (currentBoard[i + 1, j + 1] == "" && king_attack != true)
                {
                    prioritate = prio(i + 1, j + 1);
                    king_moves.Add(new Makruk.Move(j + 1, conversion(i + 1), piesa, prioritate));

                }
            }
            if ((i - 1 >= 0) && (j + 1 < 8)) //in spate pe diagonala
            {
                if (currentBoard[i - 1, j + 1] != "" && currentBoard[i - 1, j + 1].IndexOf(humanColor) != -1) //atac diagonala sus
                {
                    prioritate = prio(i - 1, j + 1);
                    king_moves.Add(new Makruk.Move(j + 1, conversion(i - 1), piesa, prioritate));
                    king_attack = true;
                }
                if (currentBoard[i - 1, j + 1] == "" && king_attack != true)
                {
                    prioritate = prio(i - 1, j + 1);
                    king_moves.Add(new Makruk.Move(j + 1, conversion(i - 1), piesa, prioritate));

                }
            }

            //in fata
            if ((j - 1 >= 0))
            {
                if (currentBoard[i, j - 1] != "" && currentBoard[i, j - 1].IndexOf(humanColor) != -1)//atac inainte
                {
                    prioritate = prio(i, j - 1);
                    king_moves.Add(new Makruk.Move(j - 1, conversion(i), piesa, prioritate));
                    king_attack = true;
                }
                if (currentBoard[i, j - 1] == "" && king_attack != true)
                {
                    prioritate = prio(i, j - 1);
                    king_moves.Add(new Makruk.Move(j - 1, conversion(i), piesa, prioritate));

                }
            }
            //in spate
            if ((j + 1 < 8))
            {
                if (currentBoard[i, j + 1] != "" && currentBoard[i, j + 1].IndexOf(humanColor) != -1)//atac inainte
                {
                    prioritate = prio(i, j + 1);
                    king_moves.Add(new Makruk.Move(j + 1, conversion(i), piesa, prioritate));
                    king_attack = true;
                }
                if (currentBoard[i, j + 1] == "" && king_attack != true)
                {
                    prioritate = prio(i, j + 1);
                    king_moves.Add(new Makruk.Move(j + 1, conversion(i), piesa, prioritate));

                }
            }
            //in dreapta
            if (i + 1 < 8)
            {
                if (currentBoard[i + 1, j] != "" && currentBoard[i + 1, j].IndexOf(humanColor) != -1)
                {
                    prioritate = prio(i + 1, j);
                    king_moves.Add(new Makruk.Move(j, conversion(i + 1), piesa, prioritate));
                    king_attack = true;
                }
                if (currentBoard[i + 1, j] == "" && king_attack != true)
                {
                    prioritate = prio(i + 1, j);
                    king_moves.Add(new Makruk.Move(j, conversion(i + 1), piesa, prioritate));
                }
            }
            //in stanga
            if (i - 1 >= 0)
            {
                if (currentBoard[i - 1, j] != "" && currentBoard[i - 1, j].IndexOf(humanColor) != -1)
                {
                    prioritate = prio(i - 1, j);
                    king_moves.Add(new Makruk.Move(j, conversion(i - 1), piesa, prioritate));
                    king_attack = true;
                }
                if (currentBoard[i - 1, j] == "" && king_attack != true)
                {
                    prioritate = prio(i - 1, j);
                    king_moves.Add(new Makruk.Move(j, conversion(i - 1), piesa, prioritate));
                }
            }

            return king_moves;
        }

        private List<Move> checkForPromotedPawnMove(string[,] currentBoard, int i /* coloana */, int j, piece piesa, ref List<Move> promoted_pawn_moves)
        {

            bool promoted_pawn_attack = false;
            int prioritate = 0;
            //atac diagonala in fata
            if (i - 1 >= 0 && j - 1 >= 0)
            {
                if (currentBoard[i - 1, j - 1] != "" && currentBoard[i - 1, j - 1].IndexOf(humanColor) != -1)
                {
                    prioritate = prio(i - 1, j - 1);
                    promoted_pawn_moves.Add(new Makruk.Move(j - 1, conversion(i - 1), piesa, prioritate));
                    promoted_pawn_attack = true;

                }
                if (currentBoard[i - 1, j - 1] == "" && promoted_pawn_attack != true)
                {
                    prioritate = prio(i - 1, j - 1);
                    promoted_pawn_moves.Add(new Makruk.Move(j - 1, conversion(i - 1), piesa, prioritate));

                }
            }
            if (i + 1 < 8 && j - 1 >= 0)
            {
                if (currentBoard[i + 1, j - 1] != "" && currentBoard[i + 1, j - 1].IndexOf(humanColor) != -1)
                {
                    prioritate = prio(i + 1, j - 1);
                    promoted_pawn_moves.Add(new Makruk.Move(j - 1, conversion(i + 1), piesa, prioritate));
                    promoted_pawn_attack = true;

                }
                if (currentBoard[i + 1, j - 1] == "" && promoted_pawn_attack != true)
                {
                    prioritate = prio(i + 1, j - 1);
                    promoted_pawn_moves.Add(new Makruk.Move(j - 1, conversion(i + 1), piesa, prioritate));

                }
            }
            //atac diagonala inapoi
            if (i + 1 < 8 && j + 1 < 8)
            {
                if (currentBoard[i + 1, j + 1] != "" && currentBoard[i + 1, j + 1].IndexOf(humanColor) != -1)
                {
                    prioritate = prio(i + 1, j + 1);
                    promoted_pawn_moves.Add(new Makruk.Move(j + 1, conversion(i + 1), piesa, prioritate));
                    promoted_pawn_attack = true;
                }
                if (currentBoard[i + 1, j + 1] == "" && promoted_pawn_attack != true)
                {
                    prioritate = prio(i + 1, j + 1);
                    promoted_pawn_moves.Add(new Makruk.Move(j + 1, conversion(i + 1), piesa, prioritate));
                }
            }

            if (i - 1 >= 0 && j + 1 < 8)
            {
                if (currentBoard[i - 1, j + 1] != "" && currentBoard[i - 1, j + 1].IndexOf(humanColor) != -1)
                {
                    prioritate = prio(i - 1, j + 1);
                    promoted_pawn_moves.Add(new Makruk.Move(j + 1, conversion(i - 1), piesa, prioritate));
                    promoted_pawn_attack = true;
                }
                if (currentBoard[i - 1, j + 1] == "" && promoted_pawn_attack != true)
                {
                    prioritate = prio(i - 1, j + 1);
                    promoted_pawn_moves.Add(new Makruk.Move(j + 1, conversion(i - 1), piesa, prioritate));
                }
            }

            return promoted_pawn_moves;

        }

        //**** NOTATII PENTRU TABLA ****

        private void pictureBoxA8_Click(object sender, EventArgs e)
        {
            selectedRow = 8;
            selectedColumn = "A";
            action();
        }

        private void pictureBoxB8_Click(object sender, EventArgs e)
        {
            selectedRow = 8;
            selectedColumn = "B";
            action();
        }

        private void pictureBoxC8_Click(object sender, EventArgs e)
        {
            selectedRow = 8;
            selectedColumn = "C";
            action();
        }

        private void pictureBoxD8_Click(object sender, EventArgs e)
        {
            selectedRow = 8;
            selectedColumn = "D";
            action();
        }
        private void pictureBoxE8_Click(object sender, EventArgs e)
        {
            selectedRow = 8;
            selectedColumn = "E";
            action();
        }
        private void pictureBoxF8_Click(object sender, EventArgs e)
        {
            selectedRow = 8;
            selectedColumn = "F";
            action();
        }
        private void pictureBoxG8_Click(object sender, EventArgs e)
        {
            selectedRow = 8;
            selectedColumn = "G";
            action();
        }
        private void pictureBoxH8_Click(object sender, EventArgs e)
        {
            selectedRow = 8;
            selectedColumn = "H";
            action();
        }

        private void pictureBoxA7_Click(object sender, EventArgs e)
        {
            selectedRow = 7;
            selectedColumn = "A";
            action();
        }

        private void pictureBoxB7_Click(object sender, EventArgs e)
        {
            selectedRow = 7;
            selectedColumn = "B";
            action();
        }

        private void pictureBoxC7_Click(object sender, EventArgs e)
        {
            selectedRow = 7;
            selectedColumn = "C";
            action();
        }

        private void pictureBoxD7_Click(object sender, EventArgs e)
        {
            selectedRow = 7;
            selectedColumn = "D";
            action();
        }
        private void pictureBoxE7_Click(object sender, EventArgs e)
        {
            selectedRow = 7;
            selectedColumn = "E";
            action();
        }
        private void pictureBoxF7_Click(object sender, EventArgs e)
        {
            selectedRow = 7;
            selectedColumn = "F";
            action();
        }
        private void pictureBoxG7_Click(object sender, EventArgs e)
        {
            selectedRow = 7;
            selectedColumn = "G";
            action();
        }
        private void pictureBoxH7_Click(object sender, EventArgs e)
        {
            selectedRow = 7;
            selectedColumn = "H";
            action();
        }

        private void pictureBoxA6_Click(object sender, EventArgs e)
        {
            selectedRow = 6;
            selectedColumn = "A";
            action();
        }

        private void pictureBoxB6_Click(object sender, EventArgs e)
        {
            selectedRow = 6;
            selectedColumn = "B";
            action();
        }

        private void pictureBoxC6_Click(object sender, EventArgs e)
        {
            selectedRow = 6;
            selectedColumn = "C";
            action();
        }

        private void pictureBoxD6_Click(object sender, EventArgs e)
        {
            selectedRow = 6;
            selectedColumn = "D";
            action();
        }
        private void pictureBoxE6_Click(object sender, EventArgs e)
        {
            selectedRow = 6;
            selectedColumn = "E";
            action();
        }
        private void pictureBoxF6_Click(object sender, EventArgs e)
        {
            selectedRow = 6;
            selectedColumn = "F";
            action();
        }
        private void pictureBoxG6_Click(object sender, EventArgs e)
        {
            selectedRow = 6;
            selectedColumn = "G";
            action();
        }
        private void pictureBoxH6_Click(object sender, EventArgs e)
        {
            selectedRow = 6;
            selectedColumn = "H";
            action();
        }

        private void pictureBoxA5_Click(object sender, EventArgs e)
        {
            selectedRow = 5;
            selectedColumn = "A";
            action();
        }

        private void pictureBoxB5_Click(object sender, EventArgs e)
        {
            selectedRow = 5;
            selectedColumn = "B";
            action();
        }

        private void pictureBoxC5_Click(object sender, EventArgs e)
        {
            selectedRow = 5;
            selectedColumn = "C";
            action();
        }

        private void pictureBoxD5_Click(object sender, EventArgs e)
        {
            selectedRow = 5;
            selectedColumn = "D";
            action();
        }
        private void pictureBoxE5_Click(object sender, EventArgs e)
        {
            selectedRow = 5;
            selectedColumn = "E";
            action();
        }
        private void pictureBoxF5_Click(object sender, EventArgs e)
        {
            selectedRow = 5;
            selectedColumn = "F";
            action();
        }
        private void pictureBoxG5_Click(object sender, EventArgs e)
        {
            selectedRow = 5;
            selectedColumn = "G";
            action();
        }
        private void pictureBoxH5_Click(object sender, EventArgs e)
        {
            selectedRow = 5;
            selectedColumn = "H";
            action();
        }

        private void pictureBoxA4_Click(object sender, EventArgs e)
        {
            selectedRow = 4;
            selectedColumn = "A";
            action();
        }

        private void pictureBoxB4_Click(object sender, EventArgs e)
        {
            selectedRow = 4;
            selectedColumn = "B";
            action();
        }

        private void pictureBoxC4_Click(object sender, EventArgs e)
        {
            selectedRow = 4;
            selectedColumn = "C";
            action();
        }

        private void pictureBoxD4_Click(object sender, EventArgs e)
        {
            selectedRow = 4;
            selectedColumn = "D";
            action();
        }
        private void pictureBoxE4_Click(object sender, EventArgs e)
        {
            selectedRow = 4;
            selectedColumn = "E";
            action();
        }
        private void pictureBoxF4_Click(object sender, EventArgs e)
        {
            selectedRow = 4;
            selectedColumn = "F";
            action();
        }
        private void pictureBoxG4_Click(object sender, EventArgs e)
        {
            selectedRow = 4;
            selectedColumn = "G";
            action();
        }
        private void pictureBoxH4_Click(object sender, EventArgs e)
        {
            selectedRow = 4;
            selectedColumn = "H";
            action();
        }

        private void pictureBoxA3_Click(object sender, EventArgs e)
        {
            selectedRow = 3;
            selectedColumn = "A";
            action();
        }
        private void pictureBoxB3_Click(object sender, EventArgs e)
        {
            selectedRow = 3;
            selectedColumn = "B";
            action();
        }

        private void pictureBoxC3_Click(object sender, EventArgs e)
        {
            selectedRow = 3;
            selectedColumn = "C";
            action();
        }

        private void pictureBoxD3_Click(object sender, EventArgs e)
        {
            selectedRow = 3;
            selectedColumn = "D";
            action();
        }
        private void pictureBoxE3_Click(object sender, EventArgs e)
        {
            selectedRow = 3;
            selectedColumn = "E";
            action();
        }
        private void pictureBoxF3_Click(object sender, EventArgs e)
        {
            selectedRow = 3;
            selectedColumn = "F";
            action();
        }
        private void pictureBoxG3_Click(object sender, EventArgs e)
        {
            selectedRow = 3;
            selectedColumn = "G";
            action();
        }
        private void pictureBoxH3_Click(object sender, EventArgs e)
        {
            selectedRow = 3;
            selectedColumn = "H";
            action();
        }

        private void pictureBoxB2_Click(object sender, EventArgs e)
        {
            selectedRow = 2;
            selectedColumn = "B";
            action();
        }

        private void pictureBoxC2_Click(object sender, EventArgs e)
        {
            selectedRow = 2;
            selectedColumn = "C";
            action();
        }

        private void pictureBoxD2_Click(object sender, EventArgs e)
        {
            selectedRow = 2;
            selectedColumn = "D";
            action();
        }
        private void pictureBoxE2_Click(object sender, EventArgs e)
        {
            selectedRow = 2;
            selectedColumn = "E";
            action();
        }
        private void pictureBoxF2_Click(object sender, EventArgs e)
        {
            selectedRow = 2;
            selectedColumn = "F";
            action();
        }
        private void pictureBoxG2_Click(object sender, EventArgs e)
        {
            selectedRow = 2;
            selectedColumn = "G";
            action();
        }
        private void pictureBoxH2_Click(object sender, EventArgs e)
        {
            selectedRow = 2;
            selectedColumn = "H";
            action();
        }

        private void pictureBoxA1_Click(object sender, EventArgs e)
        {
            selectedRow = 1;
            selectedColumn = "A";
            action();

        }

        private void pictureBoxB1_Click(object sender, EventArgs e)
        {
            selectedRow = 1;
            selectedColumn = "B";
            action();
        }

        private void pictureBoxC1_Click(object sender, EventArgs e)
        {
            selectedRow = 1;
            selectedColumn = "C";
            action();
        }

        private void pictureBoxD1_Click(object sender, EventArgs e)
        {
            selectedRow = 1;
            selectedColumn = "D";
            action();
        }
        private void pictureBoxE1_Click(object sender, EventArgs e)
        {
            selectedRow = 1;
            selectedColumn = "E";
            action();
        }
        private void pictureBoxF1_Click(object sender, EventArgs e)
        {
            selectedRow = 1;
            selectedColumn = "F";
            action();
        }
        private void pictureBoxG1_Click(object sender, EventArgs e)
        {
            selectedRow = 1;
            selectedColumn = "G";
            action();
        }
        private void pictureBoxH1_Click(object sender, EventArgs e)
        {
            selectedRow = 1;
            selectedColumn = "H";
            action();
        }



        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            sw.Close();
        }

        private void pictureBoxA2_Click(object sender, EventArgs e)
        {
            selectedRow = 2;
            selectedColumn = "A";
            action();
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
