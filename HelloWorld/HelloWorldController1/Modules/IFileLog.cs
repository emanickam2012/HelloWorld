using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldController.Modules
{
    public interface IFileLog
    {
        void WriteToFile(string errorMsg);

        string ReadFile(string FilePath);

    }
}
