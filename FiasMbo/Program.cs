using Autofac;
using FIAS.ExtractDownloadFiles;
using FIAS.ExtractedFiles;
using FIAS.Model.DownloadRegions;
using FIAS.ReadEntityFromFile;
using FiasOffSite.FI;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace FIAS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Builder.Buid().Resolve<IDownloadRegions>().SelectAndDownloadRegions();

            //Builder.Buid().Resolve<IExtractDownloadFiles>().ExtractFiles();

            //var filePaths = Builder.Buid().Resolve<IExtractedFiles>().SelectExtractedFiles();

            //Parallel.ForEach(filePaths,
            //    path => Builder.Buid().Resolve<IReaderEntityFromFile>().ReadEntityFromFile(path));


            string dasd = @"C:\FiasMbo\FiasMbo\bin\Debug\Files\Республика Саха Якутия.zip\ADDRSTATUS.FI";
            Builder.Buid().Resolve<IReaderEntityFromFile>().ReadEntityFromFile(dasd);

            //XmlReader fiReader1 = XmlReader.Create(new FIReader(filePaths[filePaths.Count - 1]), null);
            //{
            //    //XmlRootAttribute xRoot = new XmlRootAttribute();
            //    //xRoot.ElementName = "Houses";
            //    //xRoot.Namespace = "http://www.v8.1c.ru/ssl/AddressSystem";
            //    //xRoot.IsNullable = true;
            //    XmlSerializer serializer = new XmlSerializer(typeof(Houses)/*, xRoot*/);
            //    Houses result = (Houses)serializer.Deserialize(fiReader1);

            //    int y = 0;
            //}


            /*
             * 
             * 5) парсим файлики в сущности
             * 
             * 6) заливаем в базу
             * 
             */
        }
    }
}
