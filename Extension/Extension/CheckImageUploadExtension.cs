﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension.Extension
{
    public static class CheckImageUploadExtension
    {
        public static bool CheckImagePath(string imageName)
        {
            if (Path.GetExtension(imageName).ToLower() == ".jpg" ||
                Path.GetExtension(imageName).ToLower() == ".png" ||
                Path.GetExtension(imageName).ToLower() == ".gif" ||
                Path.GetExtension(imageName).ToLower() == ".jpeg")
            {
                return true;
            }

            return false;
        }
    }
}
