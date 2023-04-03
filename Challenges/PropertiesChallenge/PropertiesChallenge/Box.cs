using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesChallenge
{
    internal class Box
    {
        private int length;
        private int height;
        private int width;

        public Box (int length, int height, int width)
        {
            Length = length;
            Height = height;
            Width = width;
        }

        public int Length {
            get {
                return this.length;
            }
            set { 
                this.length = Math.Abs(value);
            }
        }
        public int Width {
            get
            {
                return this.width;
            }
            set
            {
                this.width = Math.Abs(value);
            }
        }
        public int Height {
            get
            {
                return this.height;
            }
            set
            {
                this.height = Math.Abs(value);
            }
        }
        public int Volumen {
            get { 
                return Length * Width * Height;
            }
        }

        public int FrontSurface {
            get {
                return Height * Length;
            }
        }

        public void DisplayInfo() {
            Console.WriteLine("Length is {0}, height is {1}, and width is {2} so the volumen is: {3}", Length, Height, Width, Volumen);
        }
    }
}
