using Candidate_BusinessObjects.Models;
using Candidate_Services;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CandidateManagement_VuThanhDat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IHRAccountService iaccountService;
        public MainWindow()
        {
            InitializeComponent();
            iaccountService = new HRAccountService();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            Hraccount hraccount = iaccountService.GetHraccount(txtEmail.Text);
            if (hraccount != null && txtPassword.Password.Equals(hraccount.Password) && hraccount.MemberRole == 1)
            {
                JobPostingWindow jobPosting = new JobPostingWindow();
                jobPosting.Show();
            }
            else 
            {
                MessageBox.Show("Login failed!");
            }
        }
    }
}