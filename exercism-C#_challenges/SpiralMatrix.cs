using System;

public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        int[,] matrix = new int[size,size];
        int cell = 1; 

        var direction = "rigth";

        var i = 0;
        var j = 0;

        while(cell <= size * size){
            matrix[i, j] = cell;
            cell++;

            switch (direction){
                case "rigth":
                    if (j+1 < size && matrix[i,j+1] == 0) j++;
                    else {
                        i++; 
                        direction = "down";
                    } 
                break;
                case "down":
                    if (i+1 < size && matrix[i+1,j] == 0) i++;
                    else { 
                        j--; 
                        direction = "left";
                    }
                break;
                case "left":
                    if (j-1 >= 0 && matrix[i,j-1] == 0) j--;
                    else { 
                        i--; 
                        direction = "up";
                    }
                break;
                case "up":
                    if (i-1 >= 0 && matrix[i-1,j] == 0) i--;
                    else { 
                        j++; 
                        direction = "rigth";
                    }
                break;
            }
        }
        
        return matrix;
    }
    
}
