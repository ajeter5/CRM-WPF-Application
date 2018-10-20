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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Odbc;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Customer_Relationship_Management_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            //This method calls the CreateDatabase method to create the database and tables
            Database.CreateDatabase();

            //The below code loads the values and default values for the 
            //age, gender, customer status, and communication channel (how you found us) drop downs
            for (int i = 18; i <= 100; i++)
            {
                AgeComboBox.Items.Add(i);
                
            }

            AgeComboBox.SelectedItem = 18;

            GenderComboBox.Items.Add("Male");
            GenderComboBox.Items.Add("Female");
            GenderComboBox.Items.Add("Select");
            GenderComboBox.SelectedItem = "Select";

            CustomerStatusComboBox.Items.Add("Silver");
            CustomerStatusComboBox.Items.Add("Gold");
            CustomerStatusComboBox.Items.Add("Platinum");
            CustomerStatusComboBox.Items.Add("Select");
            CustomerStatusComboBox.SelectedItem = "Select";

            CommunicationChannelComboBox.Items.Add("Internet Search Engine");
            CommunicationChannelComboBox.Items.Add("Email");
            CommunicationChannelComboBox.Items.Add("Mail Flyer");
            CommunicationChannelComboBox.Items.Add("Friend");
            CommunicationChannelComboBox.Items.Add("Other");
            CommunicationChannelComboBox.Items.Add("Select");
            CommunicationChannelComboBox.SelectedItem = "Select";
        }

        //Hide the Communication Channel (how you found us) field if Customer Radio button is checked
        private void CustomerRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            CommunicationChannelComboBox.Visibility = Visibility.Hidden;
            CommunicationChannelLabel.Visibility = Visibility.Hidden;
            CustomerStatusLabel.Visibility = Visibility.Visible;
            CustomerStatusComboBox.Visibility = Visibility.Visible;
        }

        //Hide the Customer Status field if Prospective Radio button is checked
        private void ProspectiveCustomerRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            CustomerStatusLabel.Visibility = Visibility.Hidden;
            CustomerStatusComboBox.Visibility = Visibility.Hidden;
            CommunicationChannelComboBox.Visibility = Visibility.Visible;
            CommunicationChannelLabel.Visibility = Visibility.Visible;
        }

        //The event handler for when the Submit button is clicked
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            //Test if either radio button is checked and the Name and Email textboxes contain values
            if ((CustomerRadioButton.IsChecked == true || ProspectiveCustomerRadioButton.IsChecked == true)  && (NameTextBox.Text.Length > 0 && EmailTextBox.Text.Length > 0))
            {
                SqlConnection connection = new SqlConnection("Server=localhost;Database=;Trusted_Connection=True;");
                connection.Open();
                string name = NameTextBox.Text.ToString();
                int age = (int)AgeComboBox.SelectedValue;
                string gender = (string)GenderComboBox.SelectedValue;
                string email = (string)EmailTextBox.Text;

                //If the Customer Radio Button is checked submit the input data to the database
                if (CustomerRadioButton.IsChecked == true)
                {
                    string customerStatus = (string)CustomerStatusComboBox.SelectedValue;
                        
                    using (connection)
                    {
                        string createPerson = @"INSERT INTO [CRMDatabase].[dbo].[Person]" +
                            "([Name]," +
                            "[AGE]," +
                            "[Gender]," +
                            "[Email])" + 
                            "VALUES('" + name + "', '" + age + "', '" + gender + "', '" + email + "' ); " +
                            "INSERT INTO [CRMDatabase].[dbo].[Customer] " +
                            "([Name]," +
                            "[AGE]," +
                            "[Gender]," +
                            "[Email]," +
                            "[CustomerStatus])" +
                            "VALUES('" + name + "', '" + age + "', '" + gender + "', '" + email + "', '" +   customerStatus + "' );";

                        SqlCommand customerSqlCommand = new SqlCommand(createPerson, connection);

                        if ((string)CustomerStatusComboBox.SelectedItem == "Select" || (string)GenderComboBox.SelectedItem == "Select")
                        {
                            MessageBox.Show("Please select a Gender and Customer Status.", "Customer Relationship Management", MessageBoxButton.OK);
                        }
                        else
                        {
                            customerSqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Success! You have created a Customer.", "Customer Relationship Management", MessageBoxButton.OK);
                            ClearAllFields();
                        }
                    }
                }

                //If the Prospective Radio Button is checked submit the input data to the database
                else if (ProspectiveCustomerRadioButton.IsChecked == true)
                {
                    string communicationChannel = (string)CommunicationChannelComboBox.SelectedValue;
                        
                    using (connection)
                    {
                        string createProspectiveCustomer = @"INSERT INTO [CRMDatabase].[dbo].[Person]" +
                            "([Name]," +
                            "[AGE]," +
                            "[Gender]," +
                            "[Email])" +
                            "VALUES('" + name + "', '" + age + "', '" + gender + "', '" + email + "' ); " +
                            "INSERT INTO [CRMDatabase].[dbo].[Prospect] " +
                            "([Name]," +
                            "[AGE]," +
                            "[Gender]," +
                            "[Email]," +
                            "[CommunicationChannel])" +
                            "VALUES('" + name + "', '" + age + "', '" + gender + "', '" + email + "', '" +   communicationChannel + "' );";
                        SqlCommand prospectiveCustomerSqlCommand = new SqlCommand(createProspectiveCustomer, connection);

                        if ((string)CommunicationChannelComboBox.SelectedItem == "Select" || (string)GenderComboBox.SelectedItem == "Select")
                        {
                            MessageBox.Show("Please select a Gender and how you found us.", "Customer Relationship Management", MessageBoxButton.OK);
                        }
                        else
                        {
                            prospectiveCustomerSqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Success! You have created a Prospective Customer.", "Customer Relationship Management", MessageBoxButton.OK);
                            ClearAllFields();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Customer or Prospective Customer and enter Name and an Email.", "Customer Relationship Management", MessageBoxButton.OK);
            }
        }

        //The event handler for when the Clear Button is clicked
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearAllFields();
        }

        //This method clears all textboxes and reset drop downs to default values
        private void ClearAllFields()
        {
            NameTextBox.Clear();
            AgeComboBox.SelectedItem = 18;
            GenderComboBox.SelectedItem = "Select";
            EmailTextBox.Clear();
            CustomerStatusComboBox.SelectedItem = "Select";
            CommunicationChannelComboBox.SelectedItem = "Select";
        }
    }
}
