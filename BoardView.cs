using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;

namespace Job_Application_Manager
{
    public partial class BoardView : BaseControl
    {
        private DataTable? rejectedApps;
        private DataTable? acceptedApps;
        private DataTable? pendingApps;

        private int NumOfAccepted;
        private int NumOfRejected;
        private int NumOfOngoing;
        private int TotalDecidedApplications;
        private double AcceptanceRating;

        public BoardView(int hunterId)
        {
            InitializeComponent();
            HunterID = hunterId;
        }

        public override async void DisplayDetails()
        {
            RejectedApplications.DataSource = null;
            AcceptedApplications.DataSource = null;
            OnGoingApplications.DataSource = null;

            rejectedApps = await Task.Run(() => dbSupport.GetRejectedApplications(HunterID));
            acceptedApps = await Task.Run(() => dbSupport.GetAcceptedApplications(HunterID));
            pendingApps = await Task.Run(() => dbSupport.GetPendingApplications(HunterID));

            RejectedApplications.DataSource = rejectedApps;
            AcceptedApplications.DataSource = acceptedApps;
            OnGoingApplications.DataSource = pendingApps;

            imageData = await Task.Run(() => dbSupport.DisplayProfilePicture(HunterID));
            if (imageData != null)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    profilePicture.Image = Image.FromStream(ms);
                }
            }

            LoadDataGrid();
        }

        public override void LoadDataGrid()
        {
            NumOfAccepted = AcceptedApplications.RowCount;
            NumOfRejected = RejectedApplications.RowCount;
            NumOfOngoing = OnGoingApplications.RowCount;
            TotalDecidedApplications = NumOfAccepted + NumOfRejected;
            AcceptanceRating = (double) NumOfAccepted / TotalDecidedApplications * 100;

            percentage.Text = AcceptanceRating.ToString("0.0") + " %";

            pieChart1.Series = new ISeries[]
            {
                new PieSeries<int>
                {
                    Values = new int[] {NumOfAccepted},
                    Name = "Accepted",
                    Fill = new SolidColorPaint(new SKColor(5, 229, 148)),
                    DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                    DataLabelsSize = 16,
                    DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Outer,
                    DataLabelsFormatter = point => point.Coordinate.PrimaryValue.ToString(),
                },
                new PieSeries<int>
                {
                    Values = new int[] {NumOfRejected},
                    Name = "Rejected",
                    Fill = new SolidColorPaint(SKColors.Firebrick),
                    DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                    DataLabelsSize = 16,
                    DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Outer,
                    DataLabelsFormatter = point => point.Coordinate.PrimaryValue.ToString(),
                },
                new PieSeries<int>
                {
                    Values = new int[] {NumOfOngoing},
                    Name = "Ongoing",
                    Fill = new SolidColorPaint(new SKColor(13, 59, 141)),
                    DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                    DataLabelsSize = 16,
                    DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Outer,
                    DataLabelsFormatter = point => point.Coordinate.PrimaryValue.ToString(),
                }
            };

            PureSuccessRating.Series = new ISeries[]
            {
                new PieSeries<double>
                {
                    Values = new double[] {AcceptanceRating},
                    Name = "Acceptance Rating",
                    Fill = new SolidColorPaint(new SKColor(5, 229, 148)),
                    MaxRadialColumnWidth = 35,
                    InnerRadius = 5
                },
                new PieSeries<double>
                {
                    Values = new double[] {100-AcceptanceRating},
                    Fill = new SolidColorPaint(SKColors.LightGray),
                    MaxRadialColumnWidth = 35,
                    InnerRadius = 5
                }
            };
        }

    }
}
