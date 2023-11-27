using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MlDotNetDemo.Session_20_LoadDataFromDatabase
{
    class Demo
    { 
        public static void Execute()
        {
            MLContext context = new MLContext();
            var databaseLoader = context.Data.CreateDatabaseLoader<InputModel>();
            string connectionString = "Data Source=AMANFDEV316\\SQLEXPRESS;Initial Catalog=MLDemoData;Integrated Security=True";
            string commandText = "Select sd.YearsOfExperience,sd.Salary From dbo.SalaryData sd";
            var databaseSource = new DatabaseSource(SqlClientFactory.Instance, connectionString, commandText);
            IDataView dataview = databaseLoader.Load(databaseSource);
            var preview = dataview.Preview();
        }
    }
}
