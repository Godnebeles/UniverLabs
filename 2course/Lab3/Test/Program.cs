using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());

            Regex regexExtForImage = new Regex("^((.bmp)|(.gif)|(.tiff?)|(.jpe?g)|(.png)|(.jpg))$", RegexOptions.IgnoreCase);

            foreach(var file in files)
            {
                if(regexExtForImage.IsMatch(Path.GetExtension(file)))
                {
                    string name = file.Substring(0, file.LastIndexOf('.'));
                    try
                    {
                        Bitmap picture = new Bitmap(file);
                        picture.RotateFlip(RotateFlipType.Rotate180FlipY);
                        MessageBox.Show(file + " is a picture!");
                        Console.WriteLine(file);
                        picture.Save(name + "-mirrored.gif");
                    }
                    catch
                    {
                        MessageBox.Show(file + " is not a picture");
                    }                  
                }
            }
            
        }
    }
}
