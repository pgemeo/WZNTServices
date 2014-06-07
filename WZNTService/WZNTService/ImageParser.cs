/*
 * Created by SharpDevelop.
 * User: tmsantos
 * Date: 26-05-2014
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using EyeOpen.Imaging.Processing;

namespace WZNTService
{
    public class ImageParser
    {
        static int MAX = 200;

        public static double ParsePixels(string File1, string File2)
        {
            string Pixel1, Pixel2;
            double Total = 0, NotMatch = 0;
            Bitmap Image1 = new Bitmap(File1);
            Bitmap Image2 = new Bitmap(File2);
            // diferent size
            if (!(Image1.Size.Equals(Image2.Size)) || Image1.Width > MAX || Image2.Width > MAX)
            {
                // resize images
                Image1 = ResizeImage(File1, MAX, MAX);
                Image2 = ResizeImage(File2, MAX, MAX);
            }
            // compare pixel by pixel
            for (int i = 0; i < Image1.Width; i++)
            {
                for (int j = 0; j < Image1.Height; j++)
                {
                    Pixel1 = Image1.GetPixel(i, j).ToString();
                    Pixel2 = Image2.GetPixel(i, j).ToString();
                    if (!Pixel1.Equals(Pixel2))
                    {
                        NotMatch++;
                    }
                    Total++;
                }
            }
            double Similarity = (Total > 0) ? (double) 1-NotMatch/Total : 0;
            return Similarity;
        }
        public static double ParseSimilarity(string File1, string File2)
        {
            FileInfo FileInfo1 = new FileInfo(File1);
            FileInfo FileInfo2 = new FileInfo(File2);
            ComparableImage Img1 = new ComparableImage(FileInfo1);
            ComparableImage Img2 = new ComparableImage(FileInfo2);
            double Similarity = Img1.CalculateSimilarity(Img2);
            return Similarity;
        }
        private static Bitmap ResizeImage(string File, int Width, int Height)
        {
            Bitmap Image = new Bitmap(File);
            Image = ImageUtility.ResizeBitmap(Image, Width, Height);
            return Image;
        }
    }
}
