﻿using System.IO;
using NuGet;

namespace NuGet
{
    public class EmptyFolderFile : PackageFileBase
    {
        public EmptyFolderFile(string folderPath)
            : base(System.IO.Path.Combine(folderPath, NuGet.Constants.PackageEmptyFileName))
        {
        }

        public override Stream GetStream()
        {
            return new MemoryStream(new byte[0]);
        }
    }
}