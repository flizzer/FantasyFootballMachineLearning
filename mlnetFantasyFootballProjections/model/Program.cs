using System;
using System.IO;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Models;
using Microsoft.ML.Trainers;
using Microsoft.ML.Transforms;
using System.Threading.Tasks;

namespace model
{
    class Program
    {
        static readonly string _trainingDataPath = "../../QBFantasyGameDataTraining.csv";
        static readonly string _testDataPath = "../../QBFantasyGameDataTesting.csv";
        static readonly string _modelDataPath = "../../Model.zip";

        static void Main(string[] args)
        {
            PredictionModel<QBFantasyGame, QBFantasyGamePointsPrediction> model =  Train();
            var prediction = model.Predict(TestQBFantasyGame.QBFantasyGame1);
            Console.WriteLine($"Predicted FantPt: {prediction.FantPt:0.####}" +
                              ", actual FantPt: 32.46");
            Evaluate(model);
            Console.WriteLine("Press any key to exit..");
            Console.ReadLine();
        }

        public static PredictionModel<QBFantasyGame, QBFantasyGamePointsPrediction> Train()
        {
            var pipeline = new LearningPipeline();
            pipeline.Add(new TextLoader(_trainingDataPath)
                .CreateFrom<QBFantasyGame>(useHeader:true, separator:','));
            pipeline.Add(new ColumnCopier(("FantPt", "Label")));
            pipeline.Add(new CategoricalOneHotVectorizer("GameNumber",
                                                        "Team",
                                                        "Opponent",
                                                        "Result",
                                                        "Position",
                                                        "OffensiveSnapPercentage",
                                                        "DefensiveSnapPercentage",
                                                        "SpecialTeamsSnapPercentage"));
            pipeline.Add(new ColumnConcatenator("Features",
                                               "GameNumber",
                                               //"Date",
                                               "Team",
                                               "Opponent",
                                               "Result",
                                               "Position",
                                               "Inside20PassCompletions",
                                               "Inside20PassAttempts",
                                               "Inside20PassYards",
                                               "Inside20PassTouchdowns",
                                               "Inside20RushAttempts",
                                               "Inside20RushYards",
                                               "Inside20RushTouchdowns",
                                               "Inside10PassCompletions",
                                               "Inside10PassAttempts",
                                               "Inside10PassYards",
                                               "Inside10PassTouchdowns",
                                               "Inside10RushAttempts",
                                               "Inside10RushYards",
                                               "Inside10RushTouchdowns",
                                               "OffensiveSnapNumber",
                                               "OffensiveSnapPercentage",
                                               "DefensiveSnapNumber",
                                               "DefensiveSnapPercentage",
                                               "SpecialTeamsSnapNumber",
                                               "SpecialTeamsSnapPercentage"));
            pipeline.Add(new FastTreeRegressor());
            PredictionModel<QBFantasyGame, QBFantasyGamePointsPrediction> model =
                pipeline.Train<QBFantasyGame, QBFantasyGamePointsPrediction>();
            model.WriteAsync(_modelDataPath);
            return model;
        }

        static void Evaluate(PredictionModel<QBFantasyGame, QBFantasyGamePointsPrediction> model)
        {
            var testData = new TextLoader(_testDataPath)
                 .CreateFrom<QBFantasyGame>(useHeader: true, separator: ',');
            var evaluator = new RegressionEvaluator();
            RegressionMetrics metrics = evaluator.Evaluate(model, testData);
            Console.WriteLine($"Rms = {metrics.Rms}");
            Console.WriteLine($"RSquared = {metrics.RSquared}");
        }
    }
}
