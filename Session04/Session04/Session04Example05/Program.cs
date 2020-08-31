using System;
using System.Runtime.CompilerServices;

namespace Session04Example05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multidimensionella arrayer
            int[,] chessboard = new int[8, 8];

            // Svartvit bild 2D
            int width = 128;
            int height = 128;
            byte[,] blackWhiteImage = new byte[128, 128];

            for (var y = 0; y < height; y++)
            {
                for(var x = 0; x < width; x++)
                {
                    byte  currentPixelValue = blackWhiteImage[x, y];
                }
            }

            // 3D
            int size = 128;
            int[,,] voxelData = new int[size, size, size];

            for (var z = 0; z < size; z++)
            {
                for (var y = 0; y < size; y++)
                {
                    for (var x = 0; x < size; x++)
                    {
                        int currentVoxelValue = voxelData[x, y, z];
                    }
                }
            }

            // Udda sidiga (Jagged) arrayer
            int[][] jaggedArray = new int[3][];
            { new int[] {1,3,5}, new int[] {1,4,5}, new int[] {9,8,7,5,6}};
        }
    }
}
