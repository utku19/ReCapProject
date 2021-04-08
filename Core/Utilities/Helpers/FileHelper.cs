using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
        public static string AddAsync(IFormFile file)
        {
            var result = newPath(file);
            try
            {
                var sourcepath = Path.GetTempFileName(); //geçici bir dosya yolu oluşturur.almış olduğun ilk görselin dosya yolunu sourcepath adlı değişkenime ata.
                if (file.Length > 0) //içinde bir dosya varsa bu işlemlei gerçekleştir.
                {
                    //file stream ile yeni bir dosya açabilir veya var olan dosya üzerinde okuma yazma işlemi yapaniliriz.
                    //(sourcepath, FileMode.Create.) parametrelerini alıyor,sourcepath=Dosyanın tam yolunu almaktadır. Örn: “C:\deneme.txt”  
                    //(FileMode)Dosya açılacak mı oluşturulacak mı bunu belirtmek için kullanılır.Create yapılırsayeni bir dosya oluşturulsun varsa eğer aynı isimde dosya varsa üzerine yazılsın
                    //dosya adı ve uzantısı verilir.
                    using (var stream = new FileStream(sourcepath, FileMode.Create)) 
                    {
                        file.CopyTo(stream);  //sourcepath kaynağından stream hedefine dosya kopyalar.
                    }
                }
                File.Move(sourcepath, result.newPath); //Belirtilen bir kaynaktan belirli bir hedefe dosyayı taşır. Yani kes yapıştır işlemini gerçekleştirir.
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
            return result.Path2;
        }

        public static string UpdateAsync(string sourcePath, IFormFile file)
        {
            var result = newPath(file);

            try
            {
                //File.Copy(sourcePath,result);
                if (sourcePath.Length > 0)
                {
                    using (var stream = new FileStream(result.newPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                }
                File.Delete(sourcePath);
            }
            catch (Exception excepiton)
            {
                return excepiton.Message;
            }
            return result.Path2;
        }

        public static IResult DeleteAsync(string path)
        {
            File.Delete(path);
            return new SuccessResult();
        }

        public static (string newPath, string Path2) newPath(IFormFile file)
        {
            FileInfo ff = new FileInfo(file.FileName); //FileInfo sınıfı da tek bir dosya için bilgi almak amacı ile kullanılmaktadır.
            string fileExtension = ff.Extension; //Oluşturulan dosyanın uzantısını alır. Dosyanın uzantı bölümünü temsil eden kısmı verir. örnek .txt, .jpg

            //Guid.NewGuid() metodu ile yeni bir guid oluşturulabilir ve bununla ilgili işlemler yapılabilir. Guid yapısı ise bize benzersiz değerler üretir
            var creatingUniqueFilename = Guid.NewGuid().ToString("N") + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + fileExtension;


            string path = Environment.CurrentDirectory + @"\wwwroot\Images";

            string result = $@"{path}\{creatingUniqueFilename}";

            return (result, $"\\Images\\{creatingUniqueFilename}");


        }
    }
}
