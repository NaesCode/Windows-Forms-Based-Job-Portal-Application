using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Manager
{
    public partial class AdminAnalytics : BaseControl
    {
        public AdminAnalytics()
        {
            InitializeComponent();
        }

        public override async void DisplayDetails()
        {
            int TotalNumberOfCompanies = await Task.Run(() => dbSupport.GetTotalNumberOfCompanies());
            int TotalNumberOfJobHunters = await Task.Run(() => dbSupport.GetTotalNumberOfJobHunters());
            int TotalNumberOfUsers = TotalNumberOfCompanies + TotalNumberOfJobHunters;

            double percentCompanies = ((double)TotalNumberOfCompanies / TotalNumberOfUsers) * 100;
            double percentJobHunters = ((double)TotalNumberOfJobHunters / TotalNumberOfUsers) * 100;

            CompaniesOverHunters.Series = new ISeries[]
            {
                new PieSeries<double>
                {
                    Values = new double[] {percentCompanies},
                    Name = "Registered Companies",
                    Fill = new SolidColorPaint(new SKColor(5, 229, 148)),
                    DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                    DataLabelsSize = 16,
                    DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Outer,
                    DataLabelsFormatter = point => ((int)point.Coordinate.PrimaryValue).ToString() + " %",
                    ToolTipLabelFormatter = point => $"{(int)point.Coordinate.PrimaryValue} %"
                },
                new PieSeries<double>
                {
                    Values = new double[] {percentJobHunters},
                    Name = "Job-Hunters",
                    Fill = new SolidColorPaint(SKColors.Firebrick),
                    DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                    DataLabelsSize = 16,
                    DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Outer,
                    DataLabelsFormatter = point => ((int)point.Coordinate.PrimaryValue).ToString() + " %",
                    ToolTipLabelFormatter = point => $"{(int)point.Coordinate.PrimaryValue} %"
                },
            };

            NumOfUsersChart.Series = new ISeries[]
            {
                new StackedColumnSeries<int>
                {
                Values = new int[] { TotalNumberOfCompanies },
                Name = "Registered Companies",
                StackGroup = 1,
                Stroke = null
                },

                new StackedColumnSeries<int>
                {
                    Values = new int[] { TotalNumberOfJobHunters },
                    Name = "Job-Hunters",
                    StackGroup = 1,
                    Stroke = null
                },

                new StackedColumnSeries<int>
                {
                    Values = new int[] { TotalNumberOfUsers },
                    Name = "Total Users",
                    StackGroup = 2,
                    Stroke = null
                }
            };

            NumOfUsersChart.XAxes = new Axis[]
            {
                new Axis
                {
                    Name = "Users",
                    LabelsPaint = null
                }
            };

            NumOfUsersChart.YAxes = new Axis[]
            {
                new Axis
                {
                    Name = "Number of Users",
                    Labeler = value => ((int)value).ToString(),
                    MinStep = 1,
                    MinLimit = 0
                }
            };
        }
    }
}
