using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyBases1C
{

    //class FolderOutputDefault
    //{
    //    private string inputPath;
    //    public string resultPath;
    //    public FolderOutputDefault(string path) 
    //    {
    //        //  D:\Sibgroup\Arhive
    //        inputPath = path;
    //        SetDatePath();
    //    }
    //public void SetDatePath()
    //{
    //    DateTime currentDate = DateTime.Now;
    //    string year = currentDate.Year.ToString();
    //    string month = currentDate.Month.ToString().PadLeft(2, '0');
    //    string day = currentDate.Day.ToString().PadLeft(2, '0');
    //    string path = $"\\{year}\\{year}.{month}.{day}\\";
    //    resultPath = inputPath + path;
    //}

//    //public bool CheckAndCreateDirectory(string path)
    //{
    //    if (path==null)
    //    {
    //    path = resultPath;

//    //    }
    //    bool directoryExists = Directory.Exists(path);

//    //    if (directoryExists)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        try
    //        {
    //            Directory.CreateDirectory(path);
    //            return true;
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine($"Failed to create directory: {ex.Message}");
    //            return false;
    //        }
    //    }
    //}
    //}
}
