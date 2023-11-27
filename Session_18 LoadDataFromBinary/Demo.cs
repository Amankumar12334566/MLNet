using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Text;

namespace MlDotNetDemo.Session_18_LoadDataFromBinary
{
    class Demo
    { 
        public static void Execute()
        {
            MLContext context = new MLContext();
            IDataView dataView = context.Data.LoadFromBinary(@"C:\Users\FB\Desktop\ASp.netML\MlDotNetDemo\Session_18 LoadDataFromBinary\train-dataset.bin");
            var preview = dataView.Preview();
        }
    }
}
