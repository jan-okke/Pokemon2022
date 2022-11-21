using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Pokemon2022.Game
{
    public class BitmapLoader
    {
        private static BitmapImage LoadBitmap(string path)
        {
            return new BitmapImage(); // IGNORE
            try
            {
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri($"{projectDirectory}\\Data\\Graphics\\{path}");
                bitmap.EndInit();
                return bitmap;
            }
            catch
            {
                return new BitmapImage();
            }
        }
        public static BitmapImage GetFrontSprite(string pokemonName)
        {
            return LoadBitmap($"Pokemon\\Front\\{pokemonName}.png");
        }
        public static BitmapImage GetBackSprite(string pokemonName)
        {
            return LoadBitmap($"Pokemon\\Back\\{pokemonName}.png");
        }
        public static BitmapImage GetBattleBGSprite(string bgName)
        {
            return LoadBitmap($"Battlebacks\\{bgName}.png");
        }
        public static BitmapImage LoadImage(string path)
        {
            return LoadBitmap(path);
        }
    }
}
