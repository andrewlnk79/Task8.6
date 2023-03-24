//Напишите программу, которая считает размер папки на диске (вместе со всеми вложенными папками и файлами).
//На вход метод принимает URL директории, в ответ — размер в байтах.
GetDirectoryInfo(@"D:\Texpress",out long Size);
Console.WriteLine(Size);
Console.ReadKey();


static void GetDirectoryInfo(string path, out long Size)
{
    Size = 0;
    DirectoryInfo directoryInfo = new DirectoryInfo(path);
    if( Directory.Exists(path)){
        var subDirectories = directoryInfo.GetDirectories();
        var files = directoryInfo.GetFiles();
        foreach (var file in files)
        {
            Size += file.Length;
        }
        long DirSize = 0;
        foreach (var dir in subDirectories)
        {
            GetDirectoryInfo(dir.FullName, out DirSize);
            Size += DirSize;
        }
    }



}

