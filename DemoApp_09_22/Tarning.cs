using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace DemoApp_09_22
{
    internal class Tarning
    {
        static class Tarning
        {
            private Random random = new Random();

            public int Kasta()
            {
                return random.Next(1, 7);
            }
        }
    }
}
