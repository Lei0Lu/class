

using _27._09._2022;


Filel[] files = new Filel[]
{
    new Filel("HHf", FileExtension.pdf, 50084, new DateTime(2009, 05, 30) ),
    new Filel("file", FileExtension.rar, 5342, new DateTime(2021, 07, 27) ),
    new Filel("fileua(1)", FileExtension.pdf, 1282337, new DateTime(2001, 03, 1) ),
    new Filel("filefile", FileExtension.txt, 16, new DateTime(2015, 12, 29) ),
    new Filel("newfileua", FileExtension.pdf, 2281337, new DateTime(2022, 01, 5) )

};
Console.WriteLine("Вывести только файлы с расширением txt:");
foreach (Filel item in files)
{
    if (item.Extension == FileExtension.txt)
    {
        item.ToString();

    }

}
Console.WriteLine("\nФайлы, в названиях которых есть буквосочетание ua:");

foreach (Filel item in files)
{
    if (item.Name.Contains("ua"))
    {
        item.ToString();

    }

}
Console.WriteLine("\nФайлы, созданные раньше 17.09.2022:");

foreach (Filel item in files)
{
   if (item.Datetime <= new DateTime(2022, 09, 17))
    {
        item.ToString();

    }
}

//foreach (File item in files)
//{
//    if (item.Datetime <= new DateTime(2022, 09, 17))
//    {


//    }
//}




enum FileExtension
{

    txt,
    rar,
    pdf,
    docx


}
