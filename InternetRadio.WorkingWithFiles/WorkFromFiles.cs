﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Xml.Linq;
using InternetRadio;
using System.Xml;

namespace InternetRadio.WorkingWithFiles
{
    public class WorkFromFiles
    {
        public static XDocument LoadDocument(string fileName)
        {
            return XDocument.Load(fileName);
        }

        public static void SaveDocument(XDocument document, string fileName)
        {
            document.Save(fileName);
        }
     
    }
}
