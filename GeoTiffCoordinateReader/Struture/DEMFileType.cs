﻿namespace GeoTiffElevationReader.Struture
{
    public enum DEMFileType
    {
        /// <summary>
        /// Shuttle Radar Topography Mission (SRTM) Data file
        /// </summary>
        SRTM_HGT,
        /// <summary>
        /// Georeferenced TIFF file
        /// </summary>
        GEOTIFF,
        /// <summary>
        /// Network Common Data Form (Climat and Forecast)
        /// </summary>
        CF_NetCDF,
        /// <summary>
        /// ESRI ARC/INFO ASCII GRID
        /// </summary>
        /// <remarks>See https://en.wikipedia.org/wiki/Esri_grid</remarks>
        ASCIIGrid,
    }
}
