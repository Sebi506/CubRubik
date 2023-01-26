using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubikCube
{
    public class ColorConversion
    {
        public string getColorName(string hexcode)
        {
            switch(hexcode)
            {
                case "#FF0000":
                return "Red";
                case "#0000FF":
                    return "Blue";
                case "#00FF00":
                    return "Green";
                case "#FFFF00":
                    return "Yellow";
                case "#FFA500":
                    return "Orange";
                case "#FFFFFF":
                    return "White";
            }
            return "";
        }
            
    }
}
