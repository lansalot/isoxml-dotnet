﻿using System.Collections.Generic;
using System.IO;
using XmlSchemaClassGenerator;


namespace Dev4Agriculture.ISO11783.ISOXML
{


    class Program
    {
        //TODO It's more save to move this Element to a common class. It's found in Generator and DotnetCore Library
        private static string ISOXMLClassName = "Dev4Agriculture.ISO11783.ISOXML";
        private static string outFolder = "./out/";
        private static string destinationFolder = "../../../../isoxml_dotnet_core/src/_generated/";

        static private void processNamespace(List<string> files, string targetNamespace)
        {
            var namespaceProvider = new NamespaceProvider
            {
                GenerateNamespace = key => targetNamespace
            };

            NamingScheme namingScheme = new NamingScheme();
            NamingProvider namingProvider = new ISOXMLNamingProvider(namingScheme);

            var generator = new Generator
            {
                OutputFolder = outFolder,
                // GenerateNullables = true,
                NamespaceProvider = namespaceProvider,
                NamingProvider = namingProvider,
                MemberVisitor = ISOXMLMemberVisitor.Visit,
            };

            generator.Generate(files);
        }


        static void Main(string[] args)
        {
            string folder = "./resources/xsd/";

            processNamespace(new List<string>() {
                folder + "ISO11783_TaskFile_V4-3.xsd",
                folder + "ISO11783_ExternalFile_V4-3.xsd",
            }, ISOXMLClassName + ".TaskFile");

            processNamespace(new List<string>() {
                folder + "ISO11783_LinkListFile_V4-3.xsd",
            }, ISOXMLClassName + ".LinkListFile");

            processNamespace(new List<string>() {
                folder + "ISO11783_TimeLog_V4-3.xsd",
            }, ISOXMLClassName + ".TimeLog");

            //Copy updated classes to main project
            string[] files = Directory.GetFiles(outFolder, "*.cs");
            if (Directory.Exists(destinationFolder))
            {
                Directory.Delete(destinationFolder, true);
            }
            Directory.CreateDirectory(destinationFolder);

            foreach (string file in files)
            {
                File.Copy(file, destinationFolder + Path.GetFileName(file));
            }

        }
    }
}
