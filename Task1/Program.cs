
//Напишите программу, которая чистит нужную нам папку от файлов  и папок,которые не использовались более 30 минут
// TODO:  переопределить вычетание или??
// @"D:\\TestDir"
GetCatalogs(@"D:\\TestDir");

static void GetCatalogs(string dirPath)
{

    TimeSpan time = TimeSpan.FromMinutes(30);
    DateTime dt;
    dt = Convert.ToDateTime(time.ToString());

    if (Directory.Exists(dirPath))
    {

        string[] dates = Directory.GetDirectories(dirPath);



        // TODO исправить
        foreach (var t in dates)
        {
            var access = Directory.GetLastAccessTime(t);

            if (dt != access );

            {
                Directory.Delete(t, true);
            }








        }





    }







}


