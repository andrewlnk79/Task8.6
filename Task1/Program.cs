﻿
using System.Data;
using System.IO;
//Напишите программу, которая чистит нужную нам папку от файлов  и папок,которые не использовались более 30 минут
// TODO:  переопределить вычетание в if или try.parce
GetCatalogs(@"D:\\TestDir");
static void GetCatalogs(string dirPath)
{

    TimeSpan time = TimeSpan.FromMinutes(30);

    if (Directory.Exists(dirPath))
    {

        string[] dates = Directory.GetDirectories(dirPath);




        foreach (var t in dates)
        {
            if (time - t=0)// TODO исправить
            {

            }







        }





    }






}
