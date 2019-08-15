using Autofac;
using FIAS.Archives;
using FIAS.Archives.RarArchive;
using FIAS.Archives.ZipArchive;
using FIAS.ExtractDownloadFiles;
using FIAS.ExtractedFiles;
using FIAS.Log;
using FIAS.Model.DownloadRegions;
using FIAS.ReadEntityFromFile;
using FIAS.ReadEntityFromFile.ReaderEntityFromFiFile;
using FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadAdditionalAddressInfoEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadAddressObjectEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadAddressStatusEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadArchiveObjectEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadHouseEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadLinkEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadRegulatoryDocEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.RedSteadEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile;
using FIAS.WebRequests.DownloadFile;
using FIAS.WebRequests.Fias;
using FIAS.WebRequests.Its;
using FIAS.WebRequests.WebPage;

namespace FIAS
{

    public class Builder
    {
        static public IContainer Buid()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<DownloadFile>().As<IDownloadFile>();
            builder.RegisterType<Loger>().As<ILoger>();
            builder.RegisterType<WebPage>().As<IWebPage>();

            builder.RegisterType<Its>().As<IIts>();
            builder.RegisterType<Fias>().As<IFias>();
            builder.RegisterType<UnzippingRarFile>().As<IUnzippingRarFile>();

            builder.RegisterType<UnzippingZipFile>().As<IUnzippingZipFile>();
            builder.RegisterType<UnzippingFile>().As<IUnzippingFile>();
            builder.RegisterType<DownloadRegions>().As<IDownloadRegions>();

            builder.RegisterType<ExtractDownloadFiles.ExtractDownloadFiles>().As<IExtractDownloadFiles>();
            builder.RegisterType<ExtractedFiles.ExtractedFiles>().As<IExtractedFiles>();
            builder.RegisterType<ReaderEntityFromFile>().As<IReaderEntityFromFile>();

            builder.RegisterType<ReaderEntityFromFiFile>().As<IReaderEntityFromFiFile>();
            builder.RegisterType<ReaderEntityFromXmlFile>().As<IReaderEntityFromXmlFile>();
            builder.RegisterType<ReaderAddressObjectEntity>().As<IReaderAddressObjectEntity>();

            builder.RegisterType<ReaderAdditionalAddressInfoEntity>().As<IReaderAdditionalAddressInfoEntity>();
            builder.RegisterType<ReaderRegulatoryDocEntity>().As<IReaderRegulatoryDocEntity>();
            builder.RegisterType<ReaderHouseEntity>().As<IReaderHouseEntity>();

            builder.RegisterType<ReaderLinkEntity>().As<IReaderLinkEntity>();
            builder.RegisterType<ReaderSteadEntity>().As<IReaderSteadEntity>();
            builder.RegisterType<ReaderAddressStatusEnity>().As<IReaderAddressStatusEnity>();

            builder.RegisterType<ReaderArchiveObjectEntity>().As<IReaderArchiveObjectEntity>();


            return builder.Build();
        }
    }
}
