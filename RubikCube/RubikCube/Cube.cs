using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubikCube
{
    class Cube : Face
    {
        public List<Face> FaceList = new List<Face>(7);
        ColorConversion converter;
        public void ReadCube(string fileName)
        {
            int  row = 0, column = 0 ;
            Face tempFace=new Face();
            string[] lines;
            color tempColor;
            string path= Path.Combine(Environment.CurrentDirectory, fileName);
            try
            {
               lines = File.ReadAllLines(path);
            }
            catch (FileNotFoundException e)
            {
                path = Path.Combine(Environment.CurrentDirectory, "CubeData.txt");
            }

            lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {

                tempColor.colorcode = line;
                tempColor.name =  converter.getColorName(line);


                tempFace.setColor(tempColor,row,column);
                if (row < 2)
                    if (column < 2)
                        column++;
                    else
                    { row++;column = 0; }
                else                   
                {
                    try
                    {
                    FaceList.Add(tempFace);
                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error:", ex.Message);
                    }
                    row = 0;column = 0;
                }

            }
        }
        public string getColor(int line, int column)
        {
            switch(line)
            {
             case 0:
             return this.FaceList[0].TopRow[column].colorcode;

             case 1:
             return this.FaceList[0].MiddleRow[column].colorcode;

             case 2:
            return this.FaceList[0].BottomRow[column].colorcode;

             }
             return "#FFFFFF";
            return "0";
        }
        public void defaultCube()
        {
            color tempColor;
            Face tempFace = new Face();
            Face tempFace2 = new Face();
            Face tempFace3 = new Face();
            Face tempFace4 = new Face();
            Face tempFace5 = new Face();
            Face tempFace6 = new Face();
            tempColor.colorcode = "#FF0000";
            tempColor.name = "";// converter.getColorName(line);
            tempFace.AddToFace(tempColor);
            tempFace.AddToFace(tempColor);
            tempFace.AddToFace(tempColor);
            tempFace.AddToFace(tempColor);
            tempFace.AddToFace(tempColor);
            tempFace.AddToFace(tempColor);
            tempFace.AddToFace(tempColor);
            tempFace.AddToFace(tempColor);
            tempFace.AddToFace(tempColor);
            this.FaceList.Add(tempFace);

            tempColor.colorcode = "#0000FF";
            tempColor.name = "";// converter.getColorName(line);
            tempFace2.AddToFace(tempColor);
            tempFace2.AddToFace(tempColor);
            tempFace2.AddToFace(tempColor);
            tempFace2.AddToFace(tempColor);
            tempFace2.AddToFace(tempColor);
            tempFace2.AddToFace(tempColor);
            tempFace2.AddToFace(tempColor);
            tempFace2.AddToFace(tempColor);
            tempFace2.AddToFace(tempColor);
            this.FaceList.Add(tempFace2);

            tempColor.colorcode = "#00FF00";
            tempColor.name = "";// converter.getColorName(line);
            tempFace3.AddToFace(tempColor);
            tempFace3.AddToFace(tempColor);
            tempFace3.AddToFace(tempColor);
            tempFace3.AddToFace(tempColor);
            tempFace3.AddToFace(tempColor);
            tempFace3.AddToFace(tempColor);
            tempFace3.AddToFace(tempColor);
            tempFace3.AddToFace(tempColor);
            tempFace3.AddToFace(tempColor);
            this.FaceList.Add(tempFace3);

            tempColor.colorcode = "#FFFF00";
            tempColor.name = "";// converter.getColorName(line);
            tempFace4.AddToFace(tempColor);
            tempFace4.AddToFace(tempColor);
            tempFace4.AddToFace(tempColor);
            tempFace4.AddToFace(tempColor);
            tempFace4.AddToFace(tempColor);
            tempFace4.AddToFace(tempColor);
            tempFace4.AddToFace(tempColor);
            tempFace4.AddToFace(tempColor);
            tempFace4.AddToFace(tempColor);
            this.FaceList.Add(tempFace4);

            tempColor.colorcode = "#FFA500";
            tempColor.name = "";// converter.getColorName(line);
            tempFace5.AddToFace(tempColor);
            tempFace5.AddToFace(tempColor);
            tempFace5.AddToFace(tempColor);
            tempFace5.AddToFace(tempColor);
            tempFace5.AddToFace(tempColor);
            tempFace5.AddToFace(tempColor);
            tempFace5.AddToFace(tempColor);
            tempFace5.AddToFace(tempColor);
            tempFace5.AddToFace(tempColor);
            this.FaceList.Add(tempFace5);

            tempColor.colorcode = "#FFFFFF";
            tempColor.name = "";// converter.getColorName(line);
            tempFace6.AddToFace(tempColor);
            tempFace6.AddToFace(tempColor);
            tempFace6.AddToFace(tempColor);
            tempFace6.AddToFace(tempColor);
            tempFace6.AddToFace(tempColor);
            tempFace6.AddToFace(tempColor);
            tempFace6.AddToFace(tempColor);
            tempFace6.AddToFace(tempColor);
            tempFace6.AddToFace(tempColor);
            this.FaceList.Add(tempFace6);

        }
        public void turnRow(string row, string direction)
        {
            if (direction == "Left")
            {
                if (row == "Top")
                {
                    FaceList[0].SwapRowsLR(FaceList[1].TopRow, "Top");
                    FaceList[1].SwapRowsLR(FaceList[2].TopRow, "Top");
                    FaceList[2].SwapRowsLR(FaceList[3].TopRow, "Top");
                    FaceList[4].turnRight();
                }
                else if (row == "Middle")
                {
                    FaceList[0].SwapRowsLR(FaceList[1].MiddleRow, "Middle");
                    FaceList[1].SwapRowsLR(FaceList[2].MiddleRow, "Middle");
                    FaceList[2].SwapRowsLR(FaceList[3].MiddleRow, "Middle");
                }
                else if (row == "Bottom")
                {
                    FaceList[0].SwapRowsLR(FaceList[1].BottomRow, "Bottom");
                    FaceList[1].SwapRowsLR(FaceList[2].BottomRow, "Bottom");
                    FaceList[2].SwapRowsLR(FaceList[3].BottomRow, "Bottom");
                    FaceList[5].turnLeft();
                }
            }
            else
            {
                if (row == "Top")
                {
                    FaceList[0].SwapRowsLR(FaceList[3].TopRow, "Top");
                    FaceList[3].SwapRowsLR(FaceList[2].TopRow, "Top");
                    FaceList[2].SwapRowsLR(FaceList[1].TopRow, "Top");
                    FaceList[4].turnLeft();
                }
                else if (row == "Middle")
                {
                    FaceList[0].SwapRowsLR(FaceList[3].MiddleRow, "Middle");
                    FaceList[3].SwapRowsLR(FaceList[2].MiddleRow, "Middle");
                    FaceList[2].SwapRowsLR(FaceList[1].MiddleRow, "Middle");
                }
                else if (row == "Bottom")
                {
                    FaceList[0].SwapRowsLR(FaceList[3].BottomRow, "Bottom");
                    FaceList[3].SwapRowsLR(FaceList[2].BottomRow, "Bottom");
                    FaceList[2].SwapRowsLR(FaceList[1].BottomRow, "Bottom");
                    FaceList[5].turnRight();
                }
            }
        }
        public void turnColumn(string column, string direction)
        {
            if (direction == "Up")
            {
                if (column == "Left")
                {
                    FaceList[0].turnRight();
                    FaceList[4].turnRight();
                    FaceList[2].turnRight();
                    FaceList[5].turnRight();
                    FaceList[0].SwapRowsLR(FaceList[4].TopRow, "Top");
                    FaceList[4].SwapRowsLR(FaceList[2].TopRow, "Top");
                    FaceList[2].SwapRowsLR(FaceList[5].TopRow, "Top");
                    FaceList[0].turnLeft();
                    FaceList[4].turnLeft();
                    FaceList[2].turnLeft();
                    FaceList[5].turnLeft();

                    FaceList[3].turnLeft();
                }
                else if (column == "Middle")
                {
                    FaceList[0].turnRight();
                    FaceList[4].turnRight();
                    FaceList[2].turnRight();
                    FaceList[5].turnRight();
                    FaceList[0].SwapRowsLR(FaceList[4].MiddleRow, "Middle");
                    FaceList[4].SwapRowsLR(FaceList[2].MiddleRow, "Middle");
                    FaceList[2].SwapRowsLR(FaceList[5].MiddleRow, "Middle");
                    FaceList[0].turnLeft();
                    FaceList[4].turnLeft();
                    FaceList[2].turnLeft();
                    FaceList[3].turnLeft();
                }
                else if (column == "Right")
                {
                    FaceList[0].turnRight();
                    FaceList[4].turnRight();
                    FaceList[2].turnRight();
                    FaceList[5].turnRight();
                    FaceList[0].SwapRowsLR(FaceList[4].BottomRow, "Bottom");
                    FaceList[4].SwapRowsLR(FaceList[2].BottomRow, "Bottom");
                    FaceList[2].SwapRowsLR(FaceList[5].BottomRow, "Bottom");
                    FaceList[0].turnLeft();
                    FaceList[4].turnLeft();
                    FaceList[2].turnLeft();
                    FaceList[5].turnLeft();

                    FaceList[1].turnRight();
                }
            }
            else
            {
                if (column == "Left")
                {
                    FaceList[0].turnRight();
                    FaceList[5].turnRight();
                    FaceList[2].turnRight();
                    FaceList[4].turnRight();
                    FaceList[0].SwapRowsLR(FaceList[5].TopRow, "Top");
                    FaceList[5].SwapRowsLR(FaceList[2].TopRow, "Top");
                    FaceList[2].SwapRowsLR(FaceList[4].TopRow, "Top");
                    FaceList[0].turnLeft();
                    FaceList[5].turnLeft();
                    FaceList[2].turnLeft();
                    FaceList[4].turnLeft();

                    FaceList[3].turnRight();
                }
                else if (column == "Middle")
                {
                    FaceList[0].turnRight();
                    FaceList[5].turnRight();
                    FaceList[2].turnRight();
                    FaceList[4].turnRight();
                    FaceList[0].SwapRowsLR(FaceList[5].MiddleRow, "Middle");
                    FaceList[5].SwapRowsLR(FaceList[2].MiddleRow, "Middle");
                    FaceList[2].SwapRowsLR(FaceList[4].MiddleRow, "Middle");
                    FaceList[0].turnLeft();
                    FaceList[5].turnLeft();
                    FaceList[2].turnLeft();
                    FaceList[4].turnLeft();
                }
                else if (column == "Right")
                {
                    FaceList[0].turnRight();
                    FaceList[5].turnRight();
                    FaceList[2].turnRight();
                    FaceList[4].turnRight();
                    FaceList[0].SwapRowsLR(FaceList[5].BottomRow, "Bottom");
                    FaceList[5].SwapRowsLR(FaceList[2].BottomRow, "Bottom");
                    FaceList[2].SwapRowsLR(FaceList[4].BottomRow, "Bottom");
                    FaceList[0].turnLeft();
                    FaceList[5].turnLeft();
                    FaceList[2].turnLeft();
                    FaceList[4].turnLeft();

                    FaceList[1].turnLeft();
                }
            }
        }
        public void switchFace(int faceNumber)
        {
            List<Face> TempCube;
            TempCube = this.FaceList;

            switch (faceNumber)
            {
                case 0:
                    break;
                case 1:
                    this.FaceList[0] = TempCube[1];
                    this.FaceList[1] = TempCube[2];
                    this.FaceList[2] = TempCube[3];
                    this.FaceList[4].turnRight();
                    this.FaceList[5].turnLeft();
                    break;
                case 2:
                    this.FaceList[0] = TempCube[2];
                    this.FaceList[1] = TempCube[3];
                    this.FaceList[2] = TempCube[0];
                    this.FaceList[4].turnRight();
                    this.FaceList[4].turnRight();
                    this.FaceList[5].turnLeft();
                    this.FaceList[5].turnLeft();
                    break;
                case 3:
                    this.FaceList[0] = TempCube[3];
                    this.FaceList[1] = TempCube[0];
                    this.FaceList[2] = TempCube[1];
                    this.FaceList[4].turnRight();
                    this.FaceList[4].turnRight();
                    this.FaceList[4].turnRight();
                    this.FaceList[5].turnLeft();
                    this.FaceList[5].turnLeft();
                    this.FaceList[5].turnLeft();
                    break;
                case 4:
                    this.FaceList[0] = TempCube[4];
                    this.FaceList[1].turnLeft();
                    this.FaceList[2] = TempCube[5];
                    this.FaceList[3].turnRight();
                    this.FaceList[4] = TempCube[2];
                    this.FaceList[5]=TempCube[0];
                    break;
                case 5:
                    this.FaceList[0] = TempCube[5];
                    this.FaceList[1].turnRight();
                    this.FaceList[2] = TempCube[4];
                    this.FaceList[3].turnLeft();
                    this.FaceList[4] = TempCube[0];
                    this.FaceList[5] = TempCube[2];
                    break;
            }
        }
    }

}
