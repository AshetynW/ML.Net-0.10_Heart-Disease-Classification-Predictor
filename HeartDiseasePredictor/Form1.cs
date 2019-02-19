using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.Data.DataView;


namespace HeartDiseasePredictor
{
    public partial class Form1 : Form
    {
        public Label ThinkingLbl { get; set; }
        public Label predictionDesc { get; set; }
        public Label predictionSeverity { get; set; }
        public PictureBox PictureBoxGif { get; set; }
        public CardiacPrediction PredictionVar { get; set; }
        public Timer _Timer = new Timer();
        public float Age { get; set; }
        public float Sex { get; set; }
        public float ChestPainType { get; set; }
        public float RestingBloodPressure { get; set; }
        public float SerumCholesterol { get; set; }
        public float FastingBloodSugar { get; set; }
        public float RestECGResults { get; set; }
        public float Thalach { get; set; }
        public float Exang { get; set; }
        public float OldPeak { get; set; }
        public float Slope { get; set; }
        public float CA { get; set; }
        public float Thal { get; set; }
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

            //***SET UP A TIMER TO CHECK IF THE WORKER IS BUSY, IF NOT, KILL THE LOADING SCREEN*********
            ThinkingLabel.Visible = false;
            pictureBox1.Visible = false;

            ThinkingLbl = ThinkingLabel;
            PictureBoxGif = pictureBox1;
            predictionDesc = PredictionLabel;
            predictionSeverity = SeverityLabel;

            _Timer.Interval = 100;
            _Timer.Tick += CheckBGWorker; 
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void SubmitBtn_Click(object sender, EventArgs e)
        {
            ThinkingLabel.Visible = true;
            pictureBox1.Visible = true;

            Age = Convert.ToInt32(AgeTxt.Text);
            Sex = SexCmbo.SelectedIndex;
            ChestPainType = CPTCmbo.SelectedIndex;
            RestingBloodPressure = Convert.ToInt32(RestBPTxt.Text);
            SerumCholesterol = Convert.ToInt32(SerumCholTxt.Text);
            FastingBloodSugar = FBSCmbo.SelectedIndex;
            RestECGResults = RestECGCmbo.SelectedIndex;
            Thalach = Convert.ToInt32(MaxHRTxt.Text);
            Exang = ExerciseInducedAnginaCmbo.SelectedIndex;
            OldPeak = Convert.ToInt32(STDepressionTxt.Text);
            Slope = SlopeCmbo.SelectedIndex;
            CA = NoOfVesselsColouredCmbo.SelectedIndex;
            Thal = ThalCmbo.SelectedIndex;

        _Timer.Enabled = true;
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }            
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                backgroundWorker1.CancelAsync();
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {            
            // STEP 2: Create a ML.NET environment  
            MLContext mlContext = new MLContext();

            // If working in Visual Studio, make sure the 'Copy to Output Directory'
            // property of iris-data.txt is set to 'Copy always'
            IDataView trainingDataView = mlContext.Data.ReadFromTextFile<CardiacData>(path: "cardiac-data.txt", hasHeader: false, separatorChar: ',');

            // STEP 3: Transform your data and add a learner
            // Assign numeric values to text in the "Label" column, because only
            // numbers can be processed during model training.
            // Add a learning algorithm to the pipeline. e.g.(What type of iris is this?)
            // Convert the Label back into original text (after converting to number in step 3)
            var pipeline = mlContext.Transforms.Conversion.MapValueToKey("Label")
                .Append(mlContext.Transforms.Concatenate("Features", "Age", "Sex", "ChestPainType", "RestingBloodPressure",
                "SerumCholesterol", "FastingBloodSugar", "RestECGResults", "Thalach", "Exang", "OldPeak", "Slope", "CA", "Thal"))
                .AppendCacheCheckpoint(mlContext)
                .Append(mlContext.MulticlassClassification.Trainers.StochasticDualCoordinateAscent(labelColumn: "Label", featureColumn: "Features"))
                .Append(mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

            // STEP 4: Train your model based on the data set  
            var model = pipeline.Fit(trainingDataView);

            // STEP 5: Use your model to make a prediction
            // You can change these numbers to test different predictions
            var prediction = model.CreatePredictionEngine<CardiacData, CardiacPrediction>(mlContext).Predict(
                new CardiacData()
                {
                    Age = 45f,
                    Sex = 1f,
                    ChestPainType = 2f,
                    RestingBloodPressure = 145,
                    SerumCholesterol = 344f,
                    FastingBloodSugar = 1f,
                    RestECGResults = 2f,
                    Thalach = 175f,
                    Exang = 0f,
                    OldPeak = 2f,
                    Slope = 2f,
                    CA = 2f,
                    Thal = 1f
                });
            PredictionVar = prediction;
            Console.WriteLine($"Predicted Risk is type is: {prediction.PredictedLabels}");
            
            Console.WriteLine("Press any key to exit....");
            Console.ReadLine();

            mlContext = null;
            trainingDataView = null;
            pipeline = null;
            model = null;
            prediction = null;

            /*
            +++++++++++++++++++++++++++++++++++++++++++++++++++++ BEGIN IRIS DATASET+++++++++++++++++++++++++++++++++++++++++++++++++++++++
            // STEP 2: Create a ML.NET environment  
            MLContext mlContext = new MLContext();

            // If working in Visual Studio, make sure the 'Copy to Output Directory'
            // property of iris-data.txt is set to 'Copy always'
            IDataView trainingDataView = mlContext.Data.ReadFromTextFile<IrisData>(path: "iris-data.txt", hasHeader: false, separatorChar: ',');

            // STEP 3: Transform your data and add a learner
            // Assign numeric values to text in the "Label" column, because only
            // numbers can be processed during model training.
            // Add a learning algorithm to the pipeline. e.g.(What type of iris is this?)
            // Convert the Label back into original text (after converting to number in step 3)
            var pipeline = mlContext.Transforms.Conversion.MapValueToKey("Label")
                .Append(mlContext.Transforms.Concatenate("Features", "SepalLength", "SepalWidth", "PetalLength", "PetalWidth"))
                .AppendCacheCheckpoint(mlContext)
                .Append(mlContext.MulticlassClassification.Trainers.StochasticDualCoordinateAscent(labelColumn: "Label", featureColumn: "Features"))
                .Append(mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

            // STEP 4: Train your model based on the data set  
            var model = pipeline.Fit(trainingDataView);

            // STEP 5: Use your model to make a prediction
            // You can change these numbers to test different predictions
            var Newprediction = model.CreatePredictionEngine<IrisData, IrisPrediction>(mlContext).Predict(
                new IrisData()
                {
                    SepalLength = 3.3f,
                    SepalWidth = 1.6f,
                    PetalLength = 0.2f,
                    PetalWidth = 5.1f,
                });

            Console.WriteLine($"Predicted flower type is: {Newprediction.PredictedLabels}");

            Console.WriteLine("Press any key to exit....");
            Console.ReadLine();            
            */
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                // resultLabel.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                // resultLabel.Text = "Error: " + e.Error.Message;
            }
            else
            {
                // resultLabel.Text = "Done!";
            }
        }
        void CheckBGWorker(object sender, EventArgs e)
        {
            if(backgroundWorker1.IsBusy != true)
            {
                //MessageBox.Show("BW is not busy");
                string[] PredictionValueDescriptions = new string[] { "0-10% Diameter Narrowing",
                "10-49% Diameter Narrowing",
                ">= 50% Diameter Narrowing"};

                string[] PredictionValueSeverity = new string[] { "No Disease", "Mild Disease", "Significant Disease" };
                ThinkingLabel.Visible = false;
                pictureBox1.Visible = false;

                int PredictionValue = Convert.ToInt32(PredictionVar.PredictedLabels);

                predictionDesc.Text = PredictionValueDescriptions[PredictionValue];
                predictionSeverity.Text = PredictionValueSeverity[PredictionValue];

                if (PredictionValue == 1) { predictionSeverity.ForeColor = Color.Orange; }
                if (PredictionValue == 2) { predictionSeverity.ForeColor = Color.Red; }

                PredictionValueDescriptions = null;
                PredictionValueSeverity = null;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PredictionLabel.Text = "";
            SeverityLabel.Text = "";

            SexCmbo.Items.Add("Male");
            SexCmbo.Items.Add("Female");

            CPTCmbo.Items.Add("Typical Angina");
            CPTCmbo.Items.Add("Atypical Angina");
            CPTCmbo.Items.Add("Non-anginal Pain");
            CPTCmbo.Items.Add("Asymptomatic");

            FBSCmbo.Items.Add("True");
            FBSCmbo.Items.Add("False");

            RestECGCmbo.Items.Add("Normal");
            RestECGCmbo.Items.Add("ST-T wave abnormality");
            RestECGCmbo.Items.Add("Showing probable or definite left ventricular hypertrophy");

            ExerciseInducedAnginaCmbo.Items.Add("Yes");
            ExerciseInducedAnginaCmbo.Items.Add("No");

            SlopeCmbo.Items.Add("Upsloping");
            SlopeCmbo.Items.Add("Flat");
            SlopeCmbo.Items.Add("Downsloping");

            NoOfVesselsColouredCmbo.Items.Add("1");
            NoOfVesselsColouredCmbo.Items.Add("2");
            NoOfVesselsColouredCmbo.Items.Add("3");

            ThalCmbo.Items.Add("Normal");
            ThalCmbo.Items.Add("Fixed Defect");
            ThalCmbo.Items.Add("Reversible Defect");

            AgeTxt.Text = "45";
            SexCmbo.SelectedIndex = 1;
            CPTCmbo.SelectedIndex = 2;
            RestBPTxt.Text = "145";
            SerumCholTxt.Text = "344";
            FBSCmbo.SelectedIndex = 1;
            RestECGCmbo.SelectedIndex = 2;
            MaxHRTxt.Text = "175";
            ExerciseInducedAnginaCmbo.SelectedIndex = 0;
            STDepressionTxt.Text = "2";
            SlopeCmbo.SelectedIndex = 2;
            NoOfVesselsColouredCmbo.SelectedIndex = 2;
            ThalCmbo.SelectedIndex = 1;
        }
    }
    public class IrisData
    {
        [LoadColumn(0)]
        public float SepalLength;

        [LoadColumn(1)]
        public float SepalWidth;

        [LoadColumn(2)]
        public float PetalLength;

        [LoadColumn(3)]
        public float PetalWidth;

        [LoadColumn(4)]
        public string Label;
    }
    // IrisPrediction is the result returned from prediction operations
    public class IrisPrediction
    {
        [ColumnName("PredictedLabel")]
        public string PredictedLabels;
    }
    public class CardiacData
    {
        [LoadColumn(0)]
        public float Age;

        [LoadColumn(1)]
        public float Sex;

        [LoadColumn(2)]
        public float ChestPainType;

        [LoadColumn(3)]
        public float RestingBloodPressure;

        [LoadColumn(4)]
        public float SerumCholesterol;

        [LoadColumn(5)]
        public float FastingBloodSugar;

        [LoadColumn(6)]
        public float RestECGResults;

        [LoadColumn(7)]
        public float Thalach;

        [LoadColumn(8)]
        public float Exang;

        [LoadColumn(9)]
        public float OldPeak;

        [LoadColumn(10)]
        public float Slope;

        [LoadColumn(11)]
        public float CA;

        [LoadColumn(12)]
        public float Thal;

        [LoadColumn(13)]
        public string Label;
    }
    public class CardiacPrediction
    {
        [ColumnName("PredictedLabel")]
        public string PredictedLabels;

        [ColumnName("Score")]
        public float[] Score;
    }
}
