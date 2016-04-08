using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using QABgileApp.Framework;
namespace QABgileApp.Test
{
    [TestFixture]
    public class ExcelimportTest
    {
        [Test]
        public void ImportDataFromExcel()
        {
            string FilePath = @"C:\Users\Raj\Documents\Visual Studio 2013\Projects\QABgileApp\User-Report_Duplicate_SomeIdentical.csv";
            string[] testdata = ExcelImports.ExcelImport(FilePath);
            int i = 0;
            string test;
            try
            {
                foreach (string s in testdata)
                {
                    test = testdata[i];
                    test = s;
                    i++;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
