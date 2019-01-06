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
            var rectangleArray = new Rectangle2D[100];
            var tmpArr = new Rectangle2D[100];
            for (int i = 0; i < rectangleArray.Length; i++)
            {
                int randSideSize = random.Next(10);
                rectangleArray[i] = new Rectangle2D(randSideSize, randSideSize, random.Next(10),
                random.Next(10));
            }

            Console.WriteLine($"{rectangleArray.Length - rectangleArray.Distinct().Count()} дупликатов\n");
            //Посмотреть бы как оно всё внутри реализовано, но перебирать 100 элементов руками
            // проверки ради - лень:)
        }


        /// <summary>
        /// BL8-P3/3.Anonymous. Создать метод GetSongData, 
        /// который принимает обьекта типа Song и возвращает анонимный тип, 
        /// который содержит Title, Minutes, Seconds и AlbumYear. 
        /// </summary>
        public static void Lb8_P3_3_Anonymous()
        {
            var newSong = new Song()
            {
                name = "Никто вместо нас",
                duration = 280,
                artist = "Павел Пламенев",
                album = "Крадущая сны",
                albumYear = 2018
            };

            var (title, minutes, seconds, albumYear) = GetSongsData(newSong);

            var anon = new
            {
                Title = title,
                Minutes = minutes,
                Seconds = seconds,
                Year = albumYear
            };
            Console.WriteLine($"Название: {anon.Title}\n" +
            $"Длительность: {anon.Minutes}м {anon.Seconds}с\n{anon.Year} год");
            //Довольно странный пример придумал. Если делать всё по методичке, то как вернуть
            //анонимный тип у которого имя появляется только после компиляции - без понятия
        }

        public static (string title, int minutes, int seconds, int albumYear) GetSongsData(Song tmpSong)
        {
            return 
            (
                tmpSong.name,
                tmpSong.duration / 60,
                tmpSong.duration % 60,
                tmpSong.albumYear
            );
        }

        public class Song
        {
            public string name;
            public int duration;
            public string artist;
            public string album;
            public int albumYear;
        }
    }
}
