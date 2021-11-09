using System;
using System.Configuration;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Converter
    {
        
        private int Get2Dim(int x)
        {
            int result = 0;

            
            if (x >= 2) Get2Dim(x/2);
            result += x%2;
            return result;
        }

    }
}


