﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMapExport
{
    public class TileFetcherEventArgs : EventArgs
    {
        public int ProgressValue { set; get; }

        public ulong TileAllNum { set; get; }

        public ulong TileCompleteNum { set; get; }

        public int CurrentDownloadZoom { set; get; }

        public TileFetcherEventArgs(int value)
        {
            ProgressValue = value;
        }

        public TileFetcherEventArgs(ulong allNum, ulong comNum, int zoom)
        {
            TileAllNum = allNum;
            TileCompleteNum = comNum;
            CurrentDownloadZoom = zoom;
            ProgressValue = Convert.ToInt32(TileCompleteNum * 100 / TileAllNum); ;
        }
    }
}