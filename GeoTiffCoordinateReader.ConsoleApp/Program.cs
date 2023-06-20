/*
 Code was shamelessly taken from  https://github.com/fabric-io-rodrigues/GeoTiffElevationReader to create the nuget package
 */


using GeoTiffElevationReader;

namespace GeoTiffCoordinateReader.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var asm = System.Reflection.Assembly.GetExecutingAssembly();
            string directoryApp = Path.GetDirectoryName(asm.Location);
            Console.WriteLine("GeoTiff COG - version: 0.1");
            Console.WriteLine("--------------------------");

            if (args.Length >= 3)
            {
                string url = args[0];
                double lat = Convert.ToDouble(args[1]);
                double lon = Convert.ToDouble(args[2]);

                string directoryTemp = Path.Combine(directoryApp, "CacheChk");
                GeoTiff geoTiff = new GeoTiff(new Uri(url), directoryTemp);

                double value = geoTiff.GetElevationAtLatLon(lat, lon);

                Console.WriteLine("Latitude {0};\n Longitude{1};\n Value: {2}", lat, lon, value);
            }
            else
            {
                double lat = 42.4242;
                double lon = 42.4242;

                GeoTiff geoTiffFile = new GeoTiff("C:\\data\\geotiff\\elevationsGeorgia.tif");
                double valueFromFile = geoTiffFile.GetElevationAtLatLon(lat, lon);
                

                Console.WriteLine("Latitude {0};\n Longitude{1};\n Value: {2}", lat, lon, valueFromFile);
            }           

        }
    }
}