using System;
using System.Collections.Generic;
using System.Text;

namespace RecrangleApplication
{
    public class Rectangle

    {
        int defaultLength, defaultWidth,area,perimeter;
        public Rectangle()
        {
            defaultLength = 1;
            defaultWidth = 1;
        }
        public int GetLength()
        {
            return defaultLength;
        }
        public int SetLength(int length)
        {
            defaultLength = length;
            return defaultLength;
        }
        public int GetWidth()
        {
            return defaultWidth;
        }
        public int SetWidth(int width)
        {
            defaultWidth = width;
            return defaultWidth;
        }
        public int GetPerimeter()
        {
            perimeter = (defaultWidth * 2) + (defaultLength * 2);
            return perimeter;
        }
        public int GetArea()
        {
            area = defaultLength * defaultWidth;
            return area;
        }
    }
 
}
