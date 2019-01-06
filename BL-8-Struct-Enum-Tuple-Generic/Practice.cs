using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_8_Struct_Enum_Tuple_Generic
{
    partial class Practice
    {
        public static Random random = new Random();


        /// <summary>
        /// BL8-P1/3. Cоздать структуру 2DRectangle, которая будет содержать ширину, высоту и координату.
        /// </summary>
        public static void Lb8_P1_3()
        {
            var newRectangle = new Rectangle2D(10, 20, 30, 40);
            Console.WriteLine(newRectangle);
        }

        struct Rectangle2D
        {
            int width;
            int height;
            Coordinate coord;

            public Rectangle2D(int w, int h, int x, int y)
            {
                width = w;
                height = h;
                coord = new Coordinate(x, y);
            }

            public override string ToString()
            {
                return $"width:\t{width}\nheight:\t{height}\nx:\t{coord.x}\ny:\t{coord.y}\n";
            }
        }


        /// <summary>
        /// BL8-P2/3. Cоздать случайный массив квадратов с количеством элементов 100. 
        /// Используйте класс Random(10), чтоб установить значения сторон. 
        /// </summary>
        public static void Lb8_P2_3()
        {
        }

        /// <summary>
        /// BL8-P3/3.Anonymous. Создать метод GetSongData, 
        /// который принимает обьекта типа Song и возвращает анонимный тип, 
        /// который содержит Title, Minutes, Seconds и AlbumYear. 
        /// </summary>
        public static void Lb8_P3_3_Anonymous()
        {
        }
    }
}
