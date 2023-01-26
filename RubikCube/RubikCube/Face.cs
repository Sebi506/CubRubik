using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubikCube
{
    public class Face
    {
         public List<color> TopRow { get; set; } = new List<color>(3);
         public List<color> MiddleRow { get; set; } = new List<color>(3);
         public List<color> BottomRow { get; set; } = new List<color>(3);

        //public void AddRow(List<color> row,string colorToAdd)
        //{
        //    color tempColor;
        //    tempColor.colorcode = colorToAdd;
        //    tmepColor.name
        //}
        public void AddToFace(color Color)
        { 
            if (this.TopRow.Count() < 3)
                this.TopRow.Add(Color);
               else if (this.MiddleRow.Count() < 3)
                this.MiddleRow.Add(Color);
               else if (this.BottomRow.Count() < 3)
                this.BottomRow.Add(Color);

        }
        public void setColor(color Color, int line, int column)
        {
            switch (line)
            {
                case 0:
                    this.TopRow[column] = Color;
                    break;
                case 1:
                    this.MiddleRow[column] = Color;
                    break;
                case 2:
                    this.BottomRow[column] = Color;
                    break;

            }
        }
 
        
        public void SwapRowsLR(List<color> SecondRow,string Row) // update,use adress of selected row instead of 3 big switch cases
        {
            color temp;
            switch (Row) { 
            case "Top": ///closest face to rotate
                    for (int i = 0; i < 3; i++)
                    {
                        temp = this.TopRow[i];
                        this.TopRow[i] = SecondRow[i];
                        SecondRow[i] = temp;
                    }
                break;
            case "Middle":
                    for (int i = 0; i < 3; i++)
                    {
                        temp = this.MiddleRow[i];
                        this.MiddleRow[i] = SecondRow[i];
                        SecondRow[i] = temp;
                    }
                    break;
            case "Bottom":
                    for (int i = 0; i < 3; i++)
                    {
                        temp = this.BottomRow[i];
                        this.BottomRow[i] = SecondRow[i];
                        SecondRow[i] = temp;
                    }
                    break;
            }
        }
        public void turnLeft() //update use for
        {
            Face TempFace;
            TempFace = this;
            
                this.TopRow[0] = TempFace.TopRow[2];
                this.TopRow[1] = TempFace.MiddleRow[2];
                this.TopRow[2] = TempFace.BottomRow[2];
                this.MiddleRow[0] = TempFace.TopRow[1];
                this.MiddleRow[1] = TempFace.MiddleRow[1];
                this.MiddleRow[2] = TempFace.BottomRow[1];
                this.BottomRow[0] = TempFace.TopRow[0];
                this.BottomRow[1] = TempFace.MiddleRow[0];
                this.BottomRow[2] = TempFace.BottomRow[0];
        }
        public void turnRight()
        {
            Face TempFace;
            TempFace = this;
            
            this.TopRow[0] = TempFace.BottomRow[0];
            this.TopRow[1] = TempFace.MiddleRow[0];
            this.TopRow[2] = TempFace.TopRow[0];
            this.MiddleRow[0] = TempFace.BottomRow[1];
            this.MiddleRow[1] = TempFace.MiddleRow[1];
            this.MiddleRow[2] = TempFace.TopRow[1];
            this.BottomRow[0] = TempFace.BottomRow[2];
            this.BottomRow[1] = TempFace.MiddleRow[2];
            this.BottomRow[2] = TempFace.TopRow[2];
        }
        public List<color> getVerticalRow(string side)
        {
            List<color> temp= new List<color>(4);
            switch(side)
            {
                case "Left":
                    temp.Add(this.BottomRow[0]);
                    temp.Add(this.MiddleRow[0]);
                    temp.Add(this.TopRow[0]);
                    break;
                case "Middle":
                    temp.Add(this.BottomRow[1]);
                    temp.Add(this.MiddleRow[1]);
                    temp.Add(this.TopRow[1]);
                    break;
                case "Right":
                    temp.Add(this.BottomRow[2]);
                    temp.Add(this.MiddleRow[2]);
                    temp.Add(this.TopRow[2]);
                    break;
            }
            return temp;
        }

    }
}
