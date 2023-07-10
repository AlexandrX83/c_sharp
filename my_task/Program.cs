// 
double[]  myRndmArr(int Length, double min, double max)
          {
            Random rnd = new Random();
            double[] locArr = new double[Length];
            return locArr;
          }

double[] ResArr = myRndmArr(5,10,15);
for (int i=0; i<5;i++)
      { if (i<4) 
         System.Console.Write($"{ResArr[i]} , ");
         else 
         System.Console.WriteLine($"{ResArr[i]} . ");
      }







