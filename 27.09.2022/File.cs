using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._09._2022
{
    internal class Filel
    {
        public string Name { get; set; }
        public FileExtension Extension { get; set; }
        public double Size { get; set; }
        public DateTime Datetime { get; set; }

        public Filel(string name, FileExtension extension, double size, DateTime dateTime)
        {
            Name = name;
            Extension = extension;
            Size = size;
            Datetime = dateTime;
        }

        public void ToString()
        {

            Console.WriteLine( $"{Name}.{Extension}  {Size}  {Datetime}");
        }



        public string Sizeselection()
        {

            if (Size < 1000)
            {
                return $"{Size} байт";
            }
            else if (Size >= 1000 || Size < 1000000)
            {

                return $"{Size / 1024} килобайт";
            }
            else if (Size >= 1000000)
            {

                return $"{Size / 1048576} мегабайт";
            }
            else
            {
                return "ошибка";
            }

        }
     
    }
















}



