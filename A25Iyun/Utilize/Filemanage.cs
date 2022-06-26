using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace A25Iyun.Utilize
{
    public static class Filemanage
    {
        public static bool CheckSize(this IFormFile file , int kb)
        {
            if (file.Length / 1024 > kb) return true;
            return false;
        }
        public static bool CheckType(this IFormFile file , string check)
        { 
            if (file.ContentType.Contains(check)) return true;

            return false;
        }
        public static string SaveImage(this IFormFile file , string SavePath)
        {
            string fileName = Guid.NewGuid().ToString() + file.FileName;
            string fullPath = Path.Combine(SavePath, fileName);
            using (FileStream fs = new FileStream(fullPath,FileMode.Create))
            {
                file.CopyTo(fs);
            }
            return fileName;
        }
        public static void DeleteImg(string path)
        {
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
        }
    }
}
