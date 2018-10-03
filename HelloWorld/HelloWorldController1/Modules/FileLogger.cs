using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using System.Reflection;

namespace HelloWorldController.Modules
{
    public class FileLogger : IFileLog
    {
        /// <summary>
        /// Write to a file 
        /// </summary>
        /// <param name="errorMessage"></param>
        public void WriteToFile(string errorMessage)
        {
            try
            {
                //Get file path
                Assembly me = Assembly.GetExecutingAssembly();
                Configuration config = ConfigurationManager.OpenExeConfiguration(me.ManifestModule.Assembly.Location);

                string filePath = config.AppSettings.Settings["FilePath"].Value;

                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Dispose();

                    using (TextWriter tw = new StreamWriter(filePath))
                    {
                        tw.WriteLine(errorMessage);
                    }

                }
                else if (File.Exists(filePath))
                {
                    using (TextWriter tw = new StreamWriter(filePath))
                    {
                        tw.WriteLine(errorMessage);
                    }
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }

            

        }   
        
    /// <summary>
    /// Read contents of a file
    /// </summary>
    /// <param name="filePath"></param>
    /// <returns></returns>
        public string ReadFile(string filePath)
        {
            try
            {
                string content;
                content = System.IO.File.ReadAllText(filePath);
                return content.ToString();
            }
            catch(Exception ex)
            {
                throw ex;             
            }
        }

    }
}
