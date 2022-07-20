// работа с директориями

string path = "C:/Users/Пользователь/Desktop/C_sharp_seminar8new";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
// рекурсия, которая ходит попапкам и смотрит что внутри

void CatalogInfo(string path, string indent = "") // string indent = "" - отступы, чтобы видеть структуру папки
{
    DirectoryInfo catalog = new DirectoryInfo(path); // получаем информацию о той директории в которую зашли

    DirectoryInfo[] catalogs = catalog.GetDirectories(); // получаем массив всех файлов, находящихся в этой папке
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");  
        CatalogInfo(catalogs[i].FullName, indent + " "); // смотрим все папки 
    }


    FileInfo[] files = catalog.GetFiles(); // получили весь список папок текущей директории 
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
//string path = @"C:/Users/Пользователь/Desktop/C_sharp_seminar8new";
CatalogInfo(path);