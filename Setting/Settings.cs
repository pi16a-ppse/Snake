using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public enum Directions {        //Объявление направлений движения змейки
        Left, Right, Up, Down
    }
    class Settings
    {
        public static int Height { get; set; }
        public static int Widht { get; set; }
        public static int Speed { get; set; }
        public static int Point { get; set; }
        public static int Score { get; set; }
        public static bool EndGame { get; set; }
        public static Directions direction { get; set; }


        public Settings() {

            Widht = 56;
            Height = 35;
            Speed = 45;
            Score = 133;
            Point = 80;
            EndGame = false;
            direction = Directions.Down;
      


        }   
    }

    
}
