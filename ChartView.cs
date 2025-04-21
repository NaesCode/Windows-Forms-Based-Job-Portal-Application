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
using SkiaSharp;
using System.Windows.Media;
using LiveChartsCore.SkiaSharpView.Painting;

namespace Job_Application_Manager
{
    public partial class ChartView : BaseControl
    {
        private int TargetYear = DateTime.Now.Year;

        public ChartView(int companyID)
        {
            InitializeComponent();
            CompanyID = companyID;
        }

        public override async void DisplayDetails()
        {
            imageData = await Task.Run(() => dbSupport.DisplayCompanyLogo(CompanyID));

            if (imageData != null)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    companyLogo2.Image = Image.FromStream(ms);
                }
            }

            var stackedBarData = await Task.Run(() => dbSupport.GetJobPostAnalytics(CompanyID));
            var linegraphData = await Task.Run(() => dbSupport.GetTotalMonthlyApplicants(CompanyID));

            var acceptedSeries = new StackedColumnSeries<int>
            {
                Values = stackedBarData.Select(a => a.NumOfAccepted).ToArray(),
                Name = "Accepted",
                StackGroup = 1,
                Stroke = null
            };

            var rejectedSeries = new StackedColumnSeries<int>
            {
                Values = stackedBarData.Select(a => a.NumOfRejected).ToArray(),
                Name = "Rejected",
                StackGroup = 1,
                Stroke = null
            };

            var cancelledSeries = new StackedColumnSeries<int>
            {
                Values = stackedBarData.Select(a => a.NumOfCancelled).ToArray(),
                Name = "Cancelled",
                StackGroup = 1,
                Stroke = null
            };

            var targetHiresSeries = new StackedColumnSeries<int>
            {
                Values = stackedBarData.Select(a => a.TargetHires).ToArray(),
                Name = "Target Hires",
                StackGroup = 2,
                Stroke = null
            };

            var totalApplicantsSeries = new StackedColumnSeries<int>
            {
                Values = stackedBarData.Select(a => a.TotalApplicants).ToArray(),
                Name = "Total Applicants",
                StackGroup = 3,
                Stroke = null
            };

            JobPostAnalyticsChart.Series = new ISeries[]
            {
                acceptedSeries,
                rejectedSeries,
                cancelledSeries,
                targetHiresSeries,
                totalApplicantsSeries
            };

            JobPostAnalyticsChart.XAxes = new Axis[]
            {
                new Axis
                {
                    Name = "Job Posts",
                    Labels = stackedBarData.Select(x => x.JobTitle).ToArray(),
                }
            };

            JobPostAnalyticsChart.YAxes = new Axis[]
            {
                new Axis
                {
                    Name = "Applicants Count",
                    Labeler = value => ((int)value).ToString(),
                    MinStep = 1,
                    MinLimit = 0
                }
            };


            var allMonths = Enumerable.Range(1, 12).Select(m => new DateTime(TargetYear, m, 1)).ToList();
            List<string> allMonthsString = allMonths.Select(m => m.ToString("MMM-yyyy")).ToList();

            var completedLineGraphData = allMonthsString.Select(month =>
            {
                var existing = linegraphData.FirstOrDefault(d => d.Month == month);
                return new TotalMonthlyApplicants
                {
                    Month = month,
                    TotalApplicants = existing?.TotalApplicants ?? 0
                };
            }).ToList();

            var monthlyTotalApplicantsSeries = new LineSeries<int>
            {
                Values = completedLineGraphData.Select(a => a.TotalApplicants).ToArray(),
                Name = "Total Applicants",
                LineSmoothness = 0,
                Stroke = new SolidColorPaint(SKColors.Blue) { StrokeThickness = 3},
                Fill = null,
                GeometryFill = new SolidColorPaint(SKColors.AliceBlue),
                GeometryStroke = new SolidColorPaint(SKColors.Gray) { StrokeThickness = 4 }
            };

            ApplicationsOverTimeChart.Series = new ISeries[]{ monthlyTotalApplicantsSeries };

            ApplicationsOverTimeChart.XAxes = new Axis[]
            {
                new Axis
                {
                    Name = "Months",
                    Labels = completedLineGraphData.Select(x => x.Month).ToArray(),
                }
            };

            ApplicationsOverTimeChart.YAxes = new Axis[]
            {
                new Axis
                {
                    Name = "Applicants Count",
                    Labeler = value => ((int)value).ToString(),
                    MinStep = 1,
                    MinLimit = 0
                }
            };
        }
    }
}
