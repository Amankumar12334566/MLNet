//using Microsoft.ML;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MlDotNetDemo.MlP
//{
//    class Demo
//    {
//        public static void Execute()
//        {
//            MLContext context = new MLContext();
//            List<InputModel> data = new List<InputModel>
//        {
//                new InputModel { YearsOfExperience = 1, Salary= 39000 },
//                new InputModel { YearsOfExperience = 1.3F, Salary= 46200 },
//                new InputModel { YearsOfExperience = 1.5F, Salary= 37700 },
//                new InputModel { YearsOfExperience = 2, Salary= 43500 },
//                new InputModel { YearsOfExperience = 2.2F, Salary= 40000 },
//                new InputModel { YearsOfExperience = 2.9F, Salary= 56000 },
//                new InputModel { YearsOfExperience = 3, Salary= 60000 },
//                new InputModel { YearsOfExperience = 3.2F, Salary= 54000 },
//                new InputModel { YearsOfExperience = 3.3F, Salary= 64000 },
//                new InputModel { YearsOfExperience = 3.7F, Salary= 57000 },
//                new InputModel { YearsOfExperience = 3.9F, Salary= 63000 },
//                new InputModel { YearsOfExperience = 4, Salary= 55000 },
//                new InputModel { YearsOfExperience = 4, Salary= 58000 },
//                new InputModel { YearsOfExperience = 4.1F, Salary= 57000 },
//                new InputModel { YearsOfExperience = 4.5F, Salary= 61000 },
//                new InputModel { YearsOfExperience = 4.9F, Salary= 68000 },
//                new InputModel { YearsOfExperience = 5.3F, Salary= 83000 },
//                new InputModel { YearsOfExperience = 5.9F, Salary= 82000 },
//                new InputModel { YearsOfExperience = 6, Salary= 94000 },
//                new InputModel { YearsOfExperience = 6.8F, Salary= 91000 },
//                new InputModel { YearsOfExperience = 7.1F, Salary= 98000 },
//                new InputModel { YearsOfExperience = 7.9F, Salary= 101000 },
//                new InputModel { YearsOfExperience = 8.2F, Salary= 114000 },
//                new InputModel { YearsOfExperience = 8.9F, Salary= 109000 },
//        };
//            IDataView trainingData = context.Data.LoadFromEnumerable(data);//IDtaView is a format suitable for Ml.net;
//            var estimator = context.Transforms.Concatenate("Features", new[] { "YearsOfExperience" });
//            var pipeline = estimator.Append(context.Regression.Trainers.Sdca(labelColumnName: "Salary", maximumNumberOfIterations: 100));// In this line of code
//            //we have to append The trainer algorithm name and the data types which is targeted;
//            var model = pipeline.Fit(trainingData);// Here pipeline is trained base don trainingData
//            var predictionEngine = context.Model.CreatePredictionEngine<InputModel, ResultModel>(model);//This method is used to create a prediction engine for making predictions using the trained machine learning model. The <InputModel, ResultModel>
//            //generic parameters specify the input and output types expected by the prediction engine.
//            //var experience = new InputModel { YearsOfExperience = 5 };
//            var experience = new InputModel { YearsOfExperience = 10 };
//            var result = predictionEngine.Predict(experience);//The Predict method is used to make predictions with the prediction engine. In this case, it's being called with a single input parameter, experience.
//            Console.WriteLine($"Approx salary {experience.YearsOfExperience}will be {result.Salary}");

//        }

//    }
//}
