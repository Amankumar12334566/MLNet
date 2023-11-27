//using Microsoft.ML;
//using Microsoft.ML.Data;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Text;

//namespace MlDotNetDemo.Session_16
//{
//    class Demo
//    { 
//        public static void Execute()
//        {
//            MLContext context = new MLContext();

//            //It is used to define the structure and then show the daat
//            //var columnsToLoad = new TextLoader.Column[]
//            //{
//            //    new TextLoader.Column("YearsOfExperience",DataKind.Single,0),
//            //    new TextLoader.Column("Salary",DataKind.Single,1)
//            //};
//            //string filePath = @"C:\Users\FB\Desktop\ASp.netML\MlDotNetDemo\Session_16\train-dataset.csv";

//            ////Preview method is used to view the data by assigning break point .By default it shows 100 data but we have 
//            ////a property maxRow
//            //IDataView trainingData = context.Data.LoadFromTextFile(path: filePath, hasHeader: true, separatorChar: ',', columns: columnsToLoad);

//            //It is used to show databased on model
//            //var trainingData = context.Data.LoadFromTextFile<InputModel>(
//            //    path: filePath, hasHeader: true, separatorChar: ',');

//            //It is used to show tsv data 
//            //string filePath = @"C:\Users\FB\Desktop\ASp.netML\MlDotNetDemo\Session_16\train-dataset.tsv";
//            //var trainingData = context.Data.LoadFromTextFile<InputModel>(
//            //    path: filePath, hasHeader: false);

//            //var preview = trainingData.Preview();

//        }
//    }
//}
