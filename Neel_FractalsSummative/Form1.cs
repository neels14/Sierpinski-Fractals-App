using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Neel_FractalsSummative
{
    public partial class SierpinskiFractalsForm : Form
    {
        #region Fields
        //Static Field
        private const double ONE_THIRD = 0.3333333333333333;

        //Instance Field
        private Bitmap SierpinskiFractalsBitmap = new Bitmap(643, 480);

        private Stack<int> LastRecursionDepth = new Stack<int>(); //used to change recursionDepth value to previous recursionDepth value if a value outside the bounds is entered
        private Stack<int> LastRedValue = new Stack<int>(); //used to change red value to previous red value if a value outside the bounds is entered
        private Stack<int> LastGreenValue = new Stack<int>(); //used to change green value to previous green value if a value outside the bounds is entered
        private Stack<int> LastBlueValue = new Stack<int>(); //used to change blue value to previous blue value if a value outside the bounds is entered

        #endregion

        public SierpinskiFractalsForm()
        {
            InitializeComponent();
        }

        //PictureBox Refresh Event
        private void SierpinskiFractalsPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(SierpinskiFractalsBitmap, 0, 0);
        }

        //Clear Button Click
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Graphics fractalDrawing = Graphics.FromImage(SierpinskiFractalsBitmap);
            fractalDrawing.Clear(SierpinskiFractalsPictureBox.BackColor);

            SierpinskiFractalsPictureBox.Refresh();
        }

        //Quit Button Click
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Sierpinski Triangle Event Handler
        private void DrawSierpinskiTriangleButton_Click(object sender, EventArgs e)
        {
            Graphics FractalTriangleImage = Graphics.FromImage(SierpinskiFractalsBitmap);
            FractalTriangleImage.Clear(SierpinskiFractalsPictureBox.BackColor);

            //Begin with an equilateral triangle "ABC"
            int triangleHeight = (int)(250 * Math.Sqrt(3));
            Point A = new Point(320, 0);
            Point B = new Point(70, triangleHeight);
            Point C = new Point(570, triangleHeight);

            //Get user's recursion depth value from UserRecursionDepth Method
            int recursionDepth = UserRecursionDepth();

            //Create a new SolidBrush with rgb values
            int red = UserRedValue(); //gets user's red rgb value from UserRedValue Method
            int green = UserGreenValue(); //gets user's green rgb value from UserGreenValue Method
            int blue = UserBlueValue(); //gets user's blue rgb value from UserBlueValue Method
            SolidBrush colorBrush = new SolidBrush(Color.FromArgb(red, green, blue));

            //Call DrawTriangle Method
            DrawTriangle(FractalTriangleImage, recursionDepth, A, B, C, colorBrush);

            //Fire the Paint Event
            SierpinskiFractalsPictureBox.Refresh();
        }

        //Sierpinski Carpet Event Handler
        private void DrawSierpinskiCarpetButton_Click(object sender, EventArgs e)
        {
            Graphics FractalCarpetImage = Graphics.FromImage(SierpinskiFractalsBitmap);
            FractalCarpetImage.Clear(SierpinskiFractalsPictureBox.BackColor);

            // Begin with a square
            Point location = new Point(80, 0);
            Size size = new Size(480, 480);
            Rectangle baseSqaure = new Rectangle(location, size);

            //Get user's recursion depth value from UserRecursionDepth Method
            int recursionDepth = UserRecursionDepth();

            //Create a new SolidBrush with rgb values
            int red = UserRedValue(); //gets user's red rgb value from UserRedValue Method
            int green = UserGreenValue(); //gets user's green rgb value from UserGreenValue Method
            int blue = UserBlueValue(); //gets user's blue rgb value from UserBlueValue Method
            SolidBrush colorBrush = new SolidBrush(Color.FromArgb(red, green, blue));

            //Call DrawCarpet Method
            DrawCarpet(FractalCarpetImage, recursionDepth, baseSqaure, colorBrush);

            //Fire the Paint Event
            SierpinskiFractalsPictureBox.Refresh();
        }

        //Sierpinski Triangle Method
        private void DrawTriangle(Graphics drawingSurface, int recursionDepth, Point topPoint, Point leftPoint, Point rightPoint, SolidBrush colorBrush)
        {
            //Check to see if recursion depth is 0 and stop if it is
            if(recursionDepth == 0)
            {
                //Fill the triangle
                Point[] pointsArray = { topPoint, leftPoint, rightPoint };
                drawingSurface.FillPolygon(colorBrush, pointsArray);

                //Gradient Color
                //LinearGradientBrush gradientBrush = new LinearGradientBrush(topPoint, rightPoint, Color.FromArgb(255, 0, 0), Color.FromArgb(255, 0, 0, 255));
                //drawingSurface.FillPolygon(gradientBrush, pointsArray);
            }
            else
            {
                //Find the edge midpoints
                Point leftMid = new Point((topPoint.X + leftPoint.X) / 2, (topPoint.Y + leftPoint.Y) / 2);
                Point rightMid = new Point((topPoint.X + rightPoint.X) / 2, (topPoint.Y + rightPoint.Y) / 2);
                Point bottomMid = new Point((leftPoint.X + rightPoint.X) / 2, (leftPoint.Y + rightPoint.Y) / 2);

                //Recursively draw smaller triangles
                DrawTriangle(drawingSurface, recursionDepth - 1, topPoint, leftMid, rightMid, colorBrush);
                DrawTriangle(drawingSurface, recursionDepth - 1, leftMid, leftPoint, bottomMid, colorBrush);
                DrawTriangle(drawingSurface, recursionDepth - 1, rightMid, bottomMid, rightPoint, colorBrush);
            }
        }

        //Sierpinski Carpet Method
        private void DrawCarpet(Graphics drawingSurface, int recursionDepth, Rectangle originalSquare, SolidBrush colorBrush)
        {
            //Check to see if recursion depth is 0 and stop if it is
            if(recursionDepth == 0)
            {
                //Fill the rectangle
                drawingSurface.FillRectangle(colorBrush, originalSquare);
            }
            else
            {
                //Divide the rectangle into 9 pieces
                int width = originalSquare.Width / 3;
                int x0 = originalSquare.Left;
                int x1 = x0 + width;
                int x2 = x0 + width * 2;

                int height = originalSquare.Height / 3;
                int y0 = originalSquare.Top;
                int y1 = y0 + height;
                int y2 = y0 + height * 2;

                //Recursively draw smaller carpets
                DrawCarpet(drawingSurface, recursionDepth - 1, new Rectangle(x0, y0, width, height), colorBrush);
                DrawCarpet(drawingSurface, recursionDepth - 1, new Rectangle(x1, y0, width, height), colorBrush);
                DrawCarpet(drawingSurface, recursionDepth - 1, new Rectangle(x2, y0, width, height), colorBrush);
                DrawCarpet(drawingSurface, recursionDepth - 1, new Rectangle(x0, y1, width, height), colorBrush);
                DrawCarpet(drawingSurface, recursionDepth - 1, new Rectangle(x2, y1, width, height), colorBrush);
                DrawCarpet(drawingSurface, recursionDepth - 1, new Rectangle(x0, y2, width, height), colorBrush);
                DrawCarpet(drawingSurface, recursionDepth - 1, new Rectangle(x1, y2, width, height), colorBrush);
                DrawCarpet(drawingSurface, recursionDepth - 1, new Rectangle(x2, y2, width, height), colorBrush);
            }
        }

        //User Recursion Depth Method
        private int UserRecursionDepth()
        {
            int recursionDepth = 0;
            int number;
            bool isNumeric = Int32.TryParse(UserRecursionDepthTextbox.Text, out number);

            if (number > 0 && number <= 5)
            {
                if (isNumeric)
                {
                    recursionDepth = number;
                    LastRecursionDepth.Push(recursionDepth);
                }
                else
                {
                    MessageBox.Show("You may only enter numbers!", "Recursion Depth Error");
                }
            }
            else
            {
                if(LastRecursionDepth.Count>0)
                {
                    recursionDepth = LastRecursionDepth.Pop();
                    UserRecursionDepthTextbox.Text = recursionDepth.ToString();
                }
                else
                {
                    recursionDepth = 0;
                    UserRecursionDepthTextbox.Text = recursionDepth.ToString();
                }
                MessageBox.Show("You may only enter a value greater than 0 and less than 5, 5 inclusive!", "Recursion Depth Error");
            }
            return recursionDepth;
        }

        //Generate Random Recursion Depth
        private void RandomRecursionDepthButton_Click(object sender, EventArgs e)
        {
            //Generate a random number from 1-5, 5 inclusive
            Random rnd = new Random();
            int recursionDepth = rnd.Next(1, 6);

            //Clear the textbox
            UserRecursionDepthTextbox.Clear();

            //Convert the new random recursion depth value to a string and display in the textbox
            UserRecursionDepthTextbox.Text = recursionDepth.ToString();
        }

        //User RGB Red Value Method
        private int UserRedValue()
        {
            int redValue = 0;
            int number;
            bool isNumeric = Int32.TryParse(UserRedTextbox.Text, out number);

            if (number >= 0 && number <= 255)
            {
                if (isNumeric)
                {
                    redValue = number;
                    LastRedValue.Push(redValue);
                }
                else
                {
                    MessageBox.Show("You may only enter numbers!", "Red RGB Value Error");
                }
            }
            else
            {
                if (LastRedValue.Count > 0)
                {
                    redValue = LastRedValue.Pop();
                    UserRedTextbox.Text = redValue.ToString();
                }
                else
                {
                    redValue = 0;
                    UserRedTextbox.Text = redValue.ToString();
                }
                MessageBox.Show("You may only enter a value between 0 and 255, both inclusive!", "Red RGB Value Error");
            }
            return redValue;
        }

        //User RGB Green Value Method
        private int UserGreenValue()
        {
            int greenValue = 0;
            int number;
            bool isNumeric = Int32.TryParse(UserGreenTextbox.Text, out number);

            if (number >= 0 && number <= 255)
            {
                if (isNumeric)
                {
                    greenValue = number;
                    LastGreenValue.Push(greenValue);
                }
                else
                {
                    MessageBox.Show("You may only enter numbers!", "Green RGB Value Error");
                }
            }
            else
            {
                if (LastGreenValue.Count > 0)
                {
                    greenValue = LastGreenValue.Pop();
                    UserGreenTextbox.Text = greenValue.ToString();
                }
                else
                {
                    greenValue = 0;
                    UserGreenTextbox.Text = greenValue.ToString();
                }
                MessageBox.Show("You may only enter a value between 0 and 255, both inclusive!", "Green RGB Value Error");
            }
            return greenValue;
        }

        //User RGB Blue Value Method
        private int UserBlueValue()
        {
            int blueValue = 0;
            int number;
            bool isNumeric = Int32.TryParse(UserBlueTextbox.Text, out number);

            if (number >= 0 && number <= 255)
            {
                if (isNumeric)
                {
                    blueValue = number;
                    LastBlueValue.Push(blueValue);
                }
                else
                {
                    MessageBox.Show("You may only enter numbers!", "Blue RGB Value Error");
                }
            }
            else
            {
                if (LastBlueValue.Count > 0)
                {
                    blueValue = LastBlueValue.Pop();
                    UserBlueTextbox.Text = blueValue.ToString();
                }
                else
                {
                    blueValue = 0;
                    UserBlueTextbox.Text = blueValue.ToString();
                }
                MessageBox.Show("You may only enter a value between 0 and 255, both inclusive!", "Red RGB Value Error");
            }
            return blueValue;
        }

        //Generate Random RGB Values
        private void RandomRGBValuesButton_Click(object sender, EventArgs e)
        {
            //Generate a random number from 0-255, both inclusive for the different rgb values
            Random rnd = new Random();
            int redValue = rnd.Next(0, 256);
            int greenValue = rnd.Next(0, 256);
            int blueValue = rnd.Next(0, 256);

            //Clear each textbox
            UserRedTextbox.Clear();
            UserGreenTextbox.Clear();
            UserBlueTextbox.Clear();

            //Convert the new random rgb values to a string and display each in their respective textbox
            UserRedTextbox.Text = redValue.ToString();
            UserGreenTextbox.Text = greenValue.ToString();
            UserBlueTextbox.Text = blueValue.ToString();
        }

    }
}
