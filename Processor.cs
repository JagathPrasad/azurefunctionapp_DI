using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureFunction_DI
{

    public class Processor : IProcessor
    {
        void IProcessor.Process()
        {
            throw new NotImplementedException();
        }
    }

    public interface IProcessor
    {
        void Process();
    }


}
