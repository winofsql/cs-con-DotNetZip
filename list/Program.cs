using System;
using Ionic.Zip;

namespace cs_con_DotNetZip_list
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ZipFile zip = ZipFile.Read("cs-con-DotNetZip-main.zip")) {

                string text = "";

                foreach (ZipEntry zip_entry in zip) {
                    text = $"{zip_entry.FileName} : {zip_entry.UncompressedSize} : {zip_entry.CompressedSize}";
                    Console.WriteLine(text);
                }

            }
        }
    }
}
