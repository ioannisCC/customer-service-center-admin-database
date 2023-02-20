using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.SqlServer;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using ComboBox = System.Windows.Forms.ComboBox;

namespace KEP
{
    public partial class MainApp : Form
    {
        String connectionString = "Data source=kep2023_1.db;Version=3";
        public SQLiteConnection connection;
        public MainApp(string name)
        {
            InitializeComponent();
            label1.Text = "Welcome, " + name + "!";
        }

        private void MainApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            connection.Close();
        }
        Ticket ticket = new Ticket();
        RichTextBox box = new RichTextBox();
        //string opeartion needed for submit button
        private string operation;

        private string nameOld;
        private string idNumberOld;
        private string emailOld;
        private string phoneNumberOld;
        private string birthOld;
        private string addressOld;
        private string requestOld;
      
        private void clearTextBox()
        {
            textBoxName.Clear();
            textBoxIDnumber.Clear();
            textBoxEmail.Clear();
            textBoxPhone.Clear();
            textBoxPhone.Text = "+30";
            textBoxAddress.Clear();
        }
        private void hideAllControls() {
            labelName.Hide();
            textBoxName.Hide();
            labelIDnumber.Hide();
            textBoxIDnumber.Hide();
            labelEmail.Hide();
            textBoxEmail.Hide();
            labelPhone.Hide();
            textBoxPhone.Hide();
            labelBirth.Hide();
            dateTimePickerBirth.Hide();
            labelAddress.Hide();
            textBoxAddress.Hide();
            labelType.Hide();
            comboBoxType.Hide();
            buttonSubmitInsert.Hide();
            buttonSubmitUpdate.Hide();
            box.Clear();

        }

        private void showEssenetialControls()
        {
            labelName.Show();
            textBoxName.Show();
            labelIDnumber.Show();
            textBoxIDnumber.Show();
            labelEmail.Show();
            textBoxEmail.Show();
            labelPhone.Show();
            textBoxPhone.Show();
            textBoxPhone.Text = "+30";
            labelBirth.Show();
            dateTimePickerBirth.Show();
            labelAddress.Show();
            textBoxAddress.Show();
            labelType.Hide();
            comboBoxType.Hide();
            buttonSubmitInsert.Show();
            box.Hide();
            box.Clear();
        }
        private void MainApp_Load(object sender, EventArgs e)
        {
            
            connection = new SQLiteConnection(connectionString);

            hideAllControls();

            connection.Open();
            String createSQL = "Create table if not exists Request(Request_ID integer auto increment primary key," + "FullName Text,IDnumber Text,Email Text,PhoneNumber Text,DateOfBirth Text,TypeOfRequest Text,HomeAddress Text,DateOfRequest Text)";
            SQLiteCommand command = new SQLiteCommand(createSQL, connection);
            command.ExecuteNonQuery();
            
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            operation = "Insert";
            label1.Text = "INSERT";
            label2.Text = "Fill out the form to add a request in the database";

            showEssenetialControls();
            clearTextBox();
            labelType.Show();
            comboBoxType.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            operation = "Edit";
            label1.Text = "MODIFY";
            label2.Text = "Fill out the form to edit a request from the database";

            showEssenetialControls();
            clearTextBox();
            comboBoxType.Show();
            labelType.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            operation = "Delete";
            label1.Text = "DELETE";
            label2.Text = "Fill out the form to delete a request from the database";

            showEssenetialControls();
            clearTextBox();
            comboBoxType.Show();
            labelType.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            operation = "Search";
            label1.Text = "SEARCH";
            label2.Text = "Fill out the form to search for a request in the database";

            hideAllControls();
            clearTextBox();
            dateTimePickerBirth.Show();
            labelBirth.Show();
            comboBoxType.Show();
            labelType.Show();
            buttonSubmitInsert.Show();
            box.Hide();
        }

        private void buttonViewRequestsPerCitizen_Click(object sender, EventArgs e)
        {
            operation = "ViewRequestsPerCitizen";
            label1.Text = "VIEW";
            label2.Text = "Fill out the form to view the requests of a specific citizen in the database";
            
            showEssenetialControls();
            clearTextBox();

        }

        private void buttonViewRequestsInTotal_Click(object sender, EventArgs e)
        {
            label1.Text = "VIEW";
            label2.Text = "Viewing all the requests";

            hideAllControls();

            box.Size = new Size(461, 300);
            box.Location = new Point(280, 120);
            this.Controls.Add(box);
            box.ReadOnly = true;
            box.Show();

            
            String selectSQL = "Select * from Request";
            SQLiteCommand commnad = new SQLiteCommand(selectSQL, connection);
            SQLiteDataReader reader = commnad.ExecuteReader();
            while (reader.Read())
            {
                box.AppendText(reader.GetString(1)); //epistrefei 1h sthlh apo ton pinaka
                box.AppendText(", ");
                box.AppendText(reader.GetString(2));
                box.AppendText(", ");
                box.AppendText(reader.GetString(3));
                box.AppendText(", ");
                box.AppendText(reader.GetString(4));
                box.AppendText(", ");
                box.AppendText(reader.GetString(5));
                box.AppendText(", ");
                box.AppendText(reader.GetString(6));
                box.AppendText(", ");
                box.AppendText(reader.GetString(7));
                box.AppendText(", ");
                box.AppendText(reader.GetString(8));
                box.AppendText(Environment.NewLine);
                box.AppendText(Environment.NewLine);

            }
            box.AppendText(Environment.NewLine);

        }



        private void buttonSubmitInsert_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string idNumber = textBoxIDnumber.Text;
            string email = textBoxEmail.Text;
            string phoneNumber = textBoxPhone.Text;
            string birth = dateTimePickerBirth.Value.ToShortDateString();
            string address = textBoxAddress.Text;
            string request = comboBoxType.Text;

            if (operation == "Insert")
            {
                if (String.IsNullOrEmpty(textBoxName.Text) || String.IsNullOrEmpty(textBoxIDnumber.Text) || String.IsNullOrEmpty(textBoxEmail.Text) || String.IsNullOrEmpty(textBoxPhone.Text) || String.IsNullOrEmpty(textBoxAddress.Text) || String.IsNullOrEmpty(comboBoxType.Text))
                {
                    MessageBox.Show("You have not filled all the information");
                }
                else
                {
                   
                    string currentDate = DateTime.Now.ToString();

                    //new Request(name, idNumber, email, phoneNumber, birth, address, request,currentDate);

                    String insertSQL = "Insert into Request(FullName,IDnumber,Email,PhoneNumber,DateOfBirth,TypeOfRequest,HomeAddress,DateOfRequest) values($name,$idNumber,$email,$phoneNumber,$birth,$request,$address,$currentDate)";

                    SQLiteCommand command = new SQLiteCommand(insertSQL, connection);
                    command.Parameters.AddWithValue("name", name);
                    command.Parameters.AddWithValue("idNumber", idNumber);
                    command.Parameters.AddWithValue("email", email);
                    command.Parameters.AddWithValue("phoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("birth", birth);
                    command.Parameters.AddWithValue("address", address);
                    command.Parameters.AddWithValue("request", request);
                    command.Parameters.AddWithValue("currentDate", currentDate);
                    command.ExecuteNonQuery();

                    clearTextBox();
                    box.Clear();
                    MessageBox.Show(name + "'s request has been succesfuly inserted");
                }
            }
            else if (operation == "ViewRequestsPerCitizen")
            {
                if (String.IsNullOrEmpty(textBoxName.Text) || String.IsNullOrEmpty(textBoxIDnumber.Text) || String.IsNullOrEmpty(textBoxEmail.Text) || String.IsNullOrEmpty(textBoxPhone.Text) || String.IsNullOrEmpty(textBoxAddress.Text))
                {
                    MessageBox.Show("You have not filled all the information");
                }
                else
                {
                    bool found = false;


                    box.Clear();
                    this.Controls.Add(box);
                    box.Location = new Point(400, 320);
                    box.Size = new Size(261, 150);
                    box.ReadOnly = true;
                    box.Show();


                    String selectSQL = "Select * from Request";
                    SQLiteCommand commnad = new SQLiteCommand(selectSQL, connection);
                    SQLiteDataReader reader = commnad.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader.GetString(1).Equals(name) && reader.GetString(2).Equals(idNumber) && reader.GetString(3).Equals(email) && reader.GetString(4).Equals(phoneNumber) && reader.GetString(5).Equals(birth) && reader.GetString(7).Equals(address))
                        {
                            found = true;
                            box.AppendText(reader.GetString(6));
                            box.AppendText(Environment.NewLine);

                        }

                    }

                    if (!found)
                    {
                        MessageBox.Show("This citizen does not exist, try again!");
                    }
                }
            }
            else if (operation == "Delete")
            {
                if (String.IsNullOrEmpty(textBoxName.Text) || String.IsNullOrEmpty(textBoxIDnumber.Text) || String.IsNullOrEmpty(textBoxEmail.Text) || String.IsNullOrEmpty(textBoxPhone.Text) || String.IsNullOrEmpty(textBoxAddress.Text) || String.IsNullOrEmpty(comboBoxType.Text))
                {
                    MessageBox.Show("You have not filled all the information");
                }
                else
                {
                    bool found = false;


                    String selectSQL = "Select * from Request";
                    SQLiteCommand commnad = new SQLiteCommand(selectSQL, connection);
                    SQLiteDataReader reader = commnad.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader.GetString(1).Equals(name) && reader.GetString(2).Equals(idNumber) && reader.GetString(3).Equals(email) && reader.GetString(4).Equals(phoneNumber) && reader.GetString(5).Equals(birth) && reader.GetString(6).Equals(request) && reader.GetString(7).Equals(address))
                        {
                            found = true;

                            string insertSQL = "DELETE FROM Request Where Fullname = $name And IDnumber = $idNumber And Email = $email And PhoneNumber = $phoneNumber And DateOfBirth = $birth And TypeOfRequest = $request And HomeAddress = $address";

                            SQLiteCommand command = new SQLiteCommand(insertSQL, connection);
                            command.Parameters.AddWithValue("$name", name);
                            command.Parameters.AddWithValue("$idNumber", idNumber);
                            command.Parameters.AddWithValue("$email", email);
                            command.Parameters.AddWithValue("$phoneNumber", phoneNumber);
                            command.Parameters.AddWithValue("$birth", birth);
                            command.Parameters.AddWithValue("$request", request);
                            command.Parameters.AddWithValue("$address", address);

                            command.ExecuteNonQuery();

                            MessageBox.Show(name + "'s request has been succesuly deleted");

                            break;
                        }

                    }

                    if (!found)
                    {
                        MessageBox.Show("This citizen does not exist, try again!");
                    }

                    clearTextBox();
                }
            }
            else if (operation == "Edit")
            {

                if (String.IsNullOrEmpty(textBoxName.Text) || String.IsNullOrEmpty(textBoxIDnumber.Text) || String.IsNullOrEmpty(textBoxEmail.Text) || String.IsNullOrEmpty(textBoxPhone.Text) || String.IsNullOrEmpty(textBoxAddress.Text) || String.IsNullOrEmpty(comboBoxType.Text))
                {
                    MessageBox.Show("You have not filled all information");
                }
                else
                {
                    bool found = false;


                    String selectSQL = "Select * from Request";
                    SQLiteCommand commnad = new SQLiteCommand(selectSQL, connection);
                    SQLiteDataReader reader = commnad.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader.GetString(1).Equals(name) && reader.GetString(2).Equals(idNumber) && reader.GetString(3).Equals(email) && reader.GetString(4).Equals(phoneNumber) && reader.GetString(5).Equals(birth) && reader.GetString(7).Equals(address))
                        {
                            found = true;
                            MessageBox.Show("We found the registration, edit the form and click Update, to update the information");
                            nameOld = name;
                            idNumberOld = idNumber;
                            emailOld = email;
                            phoneNumberOld = phoneNumber;
                            birthOld = birth;
                            addressOld = address;
                            requestOld = request;

                            buttonSubmitUpdate.Show();
                            buttonSubmitInsert.Hide();
                            break;
                        }

                    }
                    if (!found)
                    {
                        MessageBox.Show("This citizen does not exist, try again!");
                    }


                }
            }
            else if (operation == "Search")
            {

                if  (String.IsNullOrEmpty(comboBoxType.Text))
                {
                    MessageBox.Show("You have not filled all the information");
                }
                else
                {
                    bool found = false;

                    box.Clear();
                    this.Controls.Add(box);
                    box.Location = new Point(400, 320);
                    box.Size = new Size(261, 150);
                    box.ReadOnly = true;
                    box.Show();

                    String selectSQL = "Select * from Request";
                    SQLiteCommand commnad = new SQLiteCommand(selectSQL, connection);
                    SQLiteDataReader reader = commnad.ExecuteReader();

                    while (reader.Read())
                    {
                            
                        if (reader.GetString(5).Equals(birth) && reader.GetString(6).Equals(request))
                        {
                            
                            found = true;
                            
                            box.AppendText(reader.GetString(1));
                            box.AppendText(", ");
                            box.AppendText(reader.GetString(2));
                            box.AppendText(", ");
                            box.AppendText(reader.GetString(3));
                            box.AppendText(", ");
                            box.AppendText(reader.GetString(4));
                            box.AppendText(", ");
                            box.AppendText(reader.GetString(5));
                            box.AppendText(", ");
                            box.AppendText(reader.GetString(6));
                            box.AppendText(", ");
                            box.AppendText(reader.GetString(7));
                            box.AppendText(", ");
                            box.AppendText(reader.GetString(8));
                            box.AppendText(Environment.NewLine);
                            box.AppendText(Environment.NewLine);

                        }
                    }
                    if (!found)
                    {
                        MessageBox.Show("We did not find any registrations with the criterias you entered, try again!");
                        box.Hide();
                    }

                }
            }

        }

        private void buttonSubmitUpdate_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string idNumber = textBoxIDnumber.Text;
            string email = textBoxEmail.Text;
            string phoneNumber = textBoxPhone.Text;
            string birth = dateTimePickerBirth.Value.ToShortDateString();
            string address = textBoxAddress.Text;
            string request = comboBoxType.Text;

            if (String.IsNullOrEmpty(textBoxName.Text) || String.IsNullOrEmpty(textBoxIDnumber.Text) || String.IsNullOrEmpty(textBoxEmail.Text) || String.IsNullOrEmpty(textBoxPhone.Text) || String.IsNullOrEmpty(textBoxAddress.Text) || String.IsNullOrEmpty(comboBoxType.Text))
            {
                MessageBox.Show("You have not filled all the information");
            }
            else
            {

                MessageBox.Show("The request has been updated");
                
                string insertSQL = "UPDATE Request SET Fullname = $name,IDnumber = $idNumber,Email = $email,PhoneNumber = $phoneNumber,DateOfBirth = $birth,TypeOfRequest = $request,HomeAddress = $address Where Fullname = $nameOld And IDnumber = $idNumberOld And Email = $emailOld And PhoneNumber = $phoneNumberOld And DateOfBirth = $birthOld And TypeOfRequest = $requestOld And HomeAddress = $addressOld";

                SQLiteCommand command = new SQLiteCommand(insertSQL, connection);
                command.Parameters.AddWithValue("$nameOld", nameOld);
                command.Parameters.AddWithValue("$idNumberOld", idNumberOld);
                command.Parameters.AddWithValue("$emailOld", emailOld);
                command.Parameters.AddWithValue("$phoneNumberold", phoneNumberOld);
                command.Parameters.AddWithValue("$birthOld", birthOld);
                command.Parameters.AddWithValue("$requestOld", requestOld);
                command.Parameters.AddWithValue("$addressOld", addressOld);
                command.Parameters.AddWithValue("$name", name);
                command.Parameters.AddWithValue("$idNumber", idNumber);
                command.Parameters.AddWithValue("$email", email);
                command.Parameters.AddWithValue("$phoneNumber", phoneNumber);
                command.Parameters.AddWithValue("$birth", birth);
                command.Parameters.AddWithValue("$request", request);
                command.Parameters.AddWithValue("$address", address);
                command.ExecuteNonQuery();

                clearTextBox();
                buttonSubmitInsert.Show();
                buttonSubmitUpdate.Hide();
                
            }
        }

        private void buttonTicket_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tell the next citizen with ticket number: " + ticket.NextTicket() + ", to come for support");
        }
    }
}
