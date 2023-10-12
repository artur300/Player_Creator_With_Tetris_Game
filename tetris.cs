using System;
using System.Drawing;
using System.Windows.Forms;
using Tetris_Game.classes;
using Tetris_Game.Tertris_classes;
using System.Media;
using System.IO;
using Tetris_Game.management;

namespace Tetris_Game
{
    public partial class tetris : Form
    {

        public Player SelectedPlayer { get; set; }
        private bool isGameOver = false;
        private const int CellSize = 20;
        private const int GridLinesWidth = 1;
        private ClassShape currentShape;
        Timer timer = new Timer();

        Bitmap canvasBitmap;
        Graphics canvasGraphics;

        Bitmap workingbitmap;
        Graphics workinggraphics;


        int canvasWidth = 15;
        int canvasHeight = 20;
        int[,] canvasDotArray;
        int dotSize = 20;
        int currx;
        int curry;
        int count = 0;
        private SoundManager soundPlayer;

        public tetris()
        {

            timer.Tick += Timer_Tick;
            timer.Interval = 200;
            timer.Start();
            currentShape = GetRandomShapeAndCenter();
            InitializeComponent();
            loadCanvas();
            MoveShapeIfPossible();
            this.KeyDown += KeyboardControl;
            soundPlayer = new SoundManager();

        }


        private void loadCanvas()
        {

            pictureBox1.Width = canvasWidth * dotSize;
            pictureBox1.Height = canvasHeight * dotSize;
            canvasBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            canvasGraphics.FillRectangle(Brushes.LightSkyBlue, 0, 0, canvasBitmap.Width, canvasBitmap.Height);
            pictureBox1.Image = canvasBitmap;
            canvasDotArray = new int[canvasWidth, canvasHeight];
        }
        private void DrawGridLines(object sender, PaintEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                using (Pen pen = new Pen(Color.White, GridLinesWidth))
                {
                    for (int x = 0; x < pictureBox.Width; x += CellSize)
                    {
                        e.Graphics.DrawLine(pen, x, 0, x, pictureBox.Height);
                    }

                    for (int y = 0; y < pictureBox.Height; y += CellSize)
                    {
                        e.Graphics.DrawLine(pen, 0, y, pictureBox.Width, y);
                    }
                }
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            var isMoveSuccess = MoveShapeIfPossible(movedown: 1);

            if (!isMoveSuccess)
            {
                canvasBitmap = new Bitmap(workingbitmap);
                UpdateCanvasDotArrayWithCurrentShape();
                currentShape = GetRandomShapeAndCenter();
                clearFilledRowsAndUpdateScore();
                isGameOver = false;
            }
        }
        private ClassShape GetRandomShapeAndCenter()
        {
            var shape = ShapeCreator.get_random_shape();
            currx = 7;
            curry = -shape.Height;
            return shape;
        }
        private bool MoveShapeIfPossible(int movedown = 0, int movesides = 0)
        {
            var newX = currx + movesides;
            var newY = curry + movedown;

            if (newX < 0 || newX + currentShape.Width > canvasWidth || newX < 0 || newY + currentShape.Height > canvasHeight)
            {
                return false;
            }

            for (int i = 0; i < currentShape.Width; i++)
            {
                for (int j = 0; j < currentShape.Height; j++)
                {
                    if (newY + j > 0 && canvasDotArray[newX + i, newY + j] == 1 && currentShape.Dots[j, i] == 1)
                    {
                        return false;
                    }
                }
            }

            currx = newX;
            curry = newY;
            drawshape();
            return true;
        }
        private void drawshape()
        {

            workingbitmap = new Bitmap(canvasBitmap);
            workinggraphics = Graphics.FromImage(workingbitmap);


            for (int i = 0; i < currentShape.Width; i++)
            {
                for (int j = 0; j < currentShape.Height; j++)
                {
                    if (currentShape.Dots[j, i] == 1)
                    {

                        switch (currentShape.id)
                        {
                            case "yellow":
                                workinggraphics.FillRectangle(Brushes.YellowGreen, (currx + i) * dotSize, (curry + j) * dotSize, dotSize, dotSize);
                                break;
                            case "cyan":
                                workinggraphics.FillRectangle(Brushes.Cyan, (currx + i) * dotSize, (curry + j) * dotSize, dotSize, dotSize);
                                break;
                            case "magenta":
                                workinggraphics.FillRectangle(Brushes.Magenta, (currx + i) * dotSize, (curry + j) * dotSize, dotSize, dotSize);
                                break;
                            case "blue":
                                workinggraphics.FillRectangle(Brushes.Blue, (currx + i) * dotSize, (curry + j) * dotSize, dotSize, dotSize);
                                break;
                            case "orange":
                                workinggraphics.FillRectangle(Brushes.Orange, (currx + i) * dotSize, (curry + j) * dotSize, dotSize, dotSize);
                                break;
                            case "red":
                                workinggraphics.FillRectangle(Brushes.Red, (currx + i) * dotSize, (curry + j) * dotSize, dotSize, dotSize);
                                break;
                            case "green":
                                workinggraphics.FillRectangle(Brushes.LimeGreen, (currx + i) * dotSize, (curry + j) * dotSize, dotSize, dotSize);
                                break;
                        }


                    }
                }
            }

            pictureBox1.Image = workingbitmap;
            pictureBox1.Refresh();
        }
        private void UpdateCanvasDotArrayWithCurrentShape()
        {
            for (int i = 0; i < currentShape.Width; i++)
            {
                for (int j = 0; j < currentShape.Height; j++)
                {
                    if (currentShape.Dots[j, i] == 1)
                    {
                        int x = currx + i;
                        int y = curry + j;

                        if (x >= 0 && x < canvasWidth && y >= 0 && y < canvasHeight)
                        {
                            canvasDotArray[x, y] = 1;
                        }
                        else
                        {
                            checkIfGameOver();
                        }
                    }
                }
            }
        }
        private void KeyboardControl(object sender, KeyEventArgs e)
        {

            var verticalMove = 0;
            var horizontalMove = 0;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    verticalMove--;
                    break;
                case Keys.Right:
                    verticalMove++;
                    break;
                case Keys.Down:
                    horizontalMove++;
                    break;
                case Keys.Up:
                    soundPlayer.PlaySound("clickSound.wav");
                    currentShape.turn();

                    break;
                default:
                    return;
            }

            var isMoveSuccess = MoveShapeIfPossible(horizontalMove, verticalMove);
            if (!isMoveSuccess && e.KeyCode == Keys.Up)
                currentShape.rollback();
        }
        private void clearFilledRowsAndUpdateScore()
        {

            for (int i = 0; i < canvasHeight; i++)
            {
                int j;
                for (j = canvasWidth - 1; j >= 0; j--)
                {
                    if (canvasDotArray[j, i] == 0)
                        break;
                }

                if (j == -1)
                {

                    count++;
                    score.Text = "Score: " + count;

                    for (j = 0; j < canvasWidth; j++)
                    {
                        for (int k = i; k > 0; k--)
                        {
                            canvasDotArray[j, k] = canvasDotArray[j, k - 1];
                        }

                        canvasDotArray[j, 0] = 0;
                    }

                    soundPlayer.PlaySound("clearrows.wav");
                }
            }

            for (int i = 0; i < canvasWidth; i++)
            {
                for (int j = 0; j < canvasHeight; j++)
                {
                    canvasGraphics = Graphics.FromImage(canvasBitmap);

                    if (canvasDotArray[i, j] != 1)
                    {
                        canvasGraphics.FillRectangle(Brushes.LightSkyBlue, i * dotSize, j * dotSize, dotSize, dotSize);
                    }

                }

            }

            pictureBox1.Image = canvasBitmap;
            pictureBox1.Refresh();

        }


        private void checkIfGameOver()
        {
            if (curry < 0 && !isGameOver)
            {
                isGameOver = true;
                timer.Stop();

                if (SelectedPlayer != null && SelectedPlayer is Payment_Player)
                {
                    Payment_Player selectedPlayer = SelectedPlayer as Payment_Player;
                    selectedPlayer.score = count;
                }

                MessageBox.Show("Game Over");
                this.Dispose();
                main tomain = new main();
                tomain.Show();
                this.Hide();
            }
        }

    }
}
