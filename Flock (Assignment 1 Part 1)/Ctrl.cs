using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Controls;

namespace AlgorithmsStage1
{
    class Ctrl
    {
        public static void Move(Image anImage, bool left, bool right, bool top, bool bottom, double speed)
        {
            double leftMargin = anImage.Margin.Left;
            double topMargin = anImage.Margin.Top;
            double rightMargin = anImage.Margin.Right;
            double bottomMargin = anImage.Margin.Bottom;


            if (left == true) leftMargin = leftMargin - speed;
            if (right == true) leftMargin = leftMargin + speed;
            if (top == true) topMargin = topMargin - speed;
            if (bottom == true) topMargin = topMargin + speed;

            anImage.Margin = new Thickness(leftMargin, topMargin, rightMargin, bottomMargin);
        }

        public static void Lock(Image anImage, Grid TestGrid)
        {
            double leftMargin = anImage.Margin.Left;
            double topMargin = anImage.Margin.Top;

            if ((leftMargin + anImage.Width) > TestGrid.Width) leftMargin = TestGrid.Width - anImage.Width;
            if ((leftMargin < 0)) leftMargin = 0;

            if ((topMargin + anImage.Height) > TestGrid.Height) topMargin = TestGrid.Height - anImage.Height;
            if ((topMargin < 0)) topMargin = 0;

        }

        public static void MoveLock(Image anImage, Grid TestGrid)
        {
            bool testFlag1X = true;
            bool testFlag1Y = true;

            double leftMargin = anImage.Margin.Left;
            double topMargin = anImage.Margin.Top;

            if ((leftMargin + anImage.Width) > TestGrid.Width) leftMargin = TestGrid.Width - anImage.Width;
            if ((leftMargin < 0)) leftMargin = 0;

            if ((topMargin + anImage.Height) > TestGrid.Height) topMargin = TestGrid.Height - anImage.Height;
            if ((topMargin < 0)) topMargin = 0;

            //move lock to grid
            if (testFlag1X == true) leftMargin = leftMargin - 2;
            if ((leftMargin + anImage.Width) > TestGrid.Width)
            {
                leftMargin = TestGrid.Width - anImage.Width;
                testFlag1X = true;
            }

            if ((leftMargin < 0))
            {

            }

            //move lock to grid
            if (testFlag1Y == true) topMargin = topMargin - 2;
            if ((topMargin + anImage.Height) > TestGrid.Height)
            {
                topMargin = TestGrid.Height - anImage.Height;
                testFlag1Y = true;
            }

            if ((topMargin < 0))
            {

            }
        }
    }
}

