using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management.GUI
{
    public class Food
    {
        public Food(Food selectedFood)
        {
            this.Id = selectedFood.Id;
            this.Number = selectedFood.Number;
            this.Price = selectedFood.Price;
            this.Image = selectedFood.Image;
            this.Num = selectedFood.Num;
            this.Name = selectedFood.Name;
        }
        public Food()
        {

        }
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Number { get; set; }
        public TextBox Num { get; set; }
        public Image Image { get; set; }
    }
}
