using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._09._2022
{
    internal class File
    {
        public string Name { get; set; }
        public FileExtension Extension { get; set; }
        public double Size { get; set; }
        public DateTime Datetime { get; set; }

        public File(string name, FileExtension extension, double size, DateTime dateTime)
        {
            Name = name;
            Extension = extension;
            Size = size;
            Datetime = dateTime;
        }

        public override string ToString()
        {
            return $"{Name}.{Extension}  {Size}  {Datetime}";
        }



        public string Sizeselection()
        {

            if (Size < 1000)
            {
                return $"{Size} байт";
            }
            if (Size >= 1000 || Size < 1000000)
            {

                return $"{Size / 1024} килобайт";
            }
            if (Size >= 1000000)
            {

                return $"{Size / 1048576} мегабайт";
            }
            else
            {
                return "ошибка";
            }

        }
        public enum FileExtension
        {

            txt,
            rar,
            pdf,
            docx,


        }
    }
















}


}
