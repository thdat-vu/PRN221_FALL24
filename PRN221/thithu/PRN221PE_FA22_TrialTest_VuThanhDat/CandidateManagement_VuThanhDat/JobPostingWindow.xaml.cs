using Candidate_BusinessObjects.Models;
using Candidate_Daos;
using Candidate_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CandidateManagement_VuThanhDat
{
    /// <summary>
    /// Interaction logic for JobPosting.xaml
    /// </summary>
    public partial class JobPostingWindow : Window
    {
        private IHRAccountService acccountService;
        private IJobPostingService jobPostingService;
        public JobPostingWindow()
        {
            InitializeComponent();
            acccountService = new HRAccountService();
            jobPostingService = new JobPosingService();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadInitData();
        }

        private void LoadInitData()
        {
            dtgJobPosting.ItemsSource = jobPostingService.GetJobPostings();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            JobPosting job = new JobPosting();
            job.PostingId = txtPostingID.Text;
            job.Description = txtDescription.Text;
            job.JobPostingTitle = txtTitle.Text;
            job.PostedDate = DateTime.Parse(dataPostDate.Text);
            if (jobPostingService.AddJobPosting(job))
            {
                LoadInitData();
                MessageBox.Show("Added successfully");
            }
            else
            {
                MessageBox.Show("There is some error. Try again!");
            }            

        }

        private void dgData_SelectionChanged(object sender, RoutedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataGridRow row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromItem(dataGrid.SelectedItem);
            DataGridCell RowColumn = dataGrid.Columns[0].GetCellContent(row).Parent as DataGridCell;
            string id = ((TextBlock)RowColumn.Content).Text;
            JobPosting jobPosting = jobPostingService.GetJobPosting(id);
            txtPostingID.Text = jobPosting.PostingId.ToString();
            txtTitle.Text = jobPosting.JobPostingTitle.ToString();
            dataPostDate.Text = jobPosting.PostedDate.ToString();
            txtDescription.Text = jobPosting.Description.ToString();
        }
    }
}
