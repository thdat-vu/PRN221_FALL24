using Candidate_BusinessObjects.Models;
using Candidate_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
    /// Interaction logic for CandidateProfileWindow.xaml
    /// </summary>
    public partial class CandidateProfileWindow : Window
    {
        private IJobPostingService jobPostingService;
        private ICandidateProfileService candidateProfileService;
        public CandidateProfileWindow()
        {
            InitializeComponent();
            jobPostingService = new JobPosingService();
            candidateProfileService = new CandidateProfileService();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InitData();
            LoadJobPosting();
        }
        
        private void InitData()
        {
            this.dataCandidateProfile.ItemsSource = candidateProfileService.GetCandidateProfiles();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            CandidateProfile candidateProfile = new CandidateProfile();
            candidateProfile.CandidateId = this.txtCandidateID.Text;
            candidateProfile.Fullname = this.txtFullName.Text;
            candidateProfile.ProfileUrl = this.txtImageURL.Text;
            candidateProfile.ProfileShortDescription = this.txtDescription.Text;
            candidateProfile.Birthday = DateTime.Parse(this.dpBirthDate.Text);  
            candidateProfile.PostingId = cboJobPosting.SelectedValue.ToString();

            if (candidateProfileService.CreateCandidateProfile(candidateProfile))
            {
                MessageBox.Show("Added successfully");
                InitData();

            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        // Loading job posting list combo box
        public void LoadJobPosting()    
        {
            try
            {
                // get the job posting list the pass to cboJobPosting's item source
                var jobPostingList = jobPostingService.GetJobPostings();
                cboJobPosting.ItemsSource = jobPostingList;
                // define display member path and selected value path
                cboJobPosting.DisplayMemberPath = "JobPostingTitle";
                cboJobPosting.SelectedValuePath = "PostingId";

            }
            catch (Exception ex)
            {
                // write log
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
