using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Windows.Forms;

namespace Компоновщик
{
    abstract class Component
    {
        protected string name;
        public Bitmap image;

        public void ChangeSize(int width, int height)
        {
            image = new Bitmap(image, width, height);
        }

        public void GetInfo()
        {
            MessageBox.Show(name + ", має ширину " + image.Width + " і висоту " + image.Height);
        }
    }

    class Body : Component
    {
        public Body()
        {
            name = "Кузов";
            image = new Bitmap(Image.FromFile("кузов.jpg"), 70, 30);
        }
    }
    class Engine : Component
    {
        public Engine()
        {
            name = "Двигун";
            image = new Bitmap(Image.FromFile("двигун.jpg"), 60, 50);
        }
    }
    class Chassis : Component
    {
        public Chassis()
        {
            name = "Шасі";
            image = new Bitmap(Image.FromFile("шасi.jpg"), 70, 30);
        }
    }
}
