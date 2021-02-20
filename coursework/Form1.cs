using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework
{
    public partial class Form1 : Form
    {
        List<Visitor> _visitorList = new List<Visitor>();
        private const string _filePath = @"./../../CsvFile/VisitorRecord.csv";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(fNameTxt.Text)|| String.IsNullOrWhiteSpace(addressTxt.Text)||String.IsNullOrWhiteSpace(contactTxt.Text) 
                || String.IsNullOrWhiteSpace(genderTxt.Text)|| String.IsNullOrWhiteSpace(occupationTxt.Text))
            {
                MessageBox.Show("Insert In All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Random r = new Random();
                    int CardNo = r.Next(1000, 9999);

                    DateTime entryTime = dateTimePicker1.Value;
                    string entryDay = entryTime.DayOfWeek.ToString();
                    Visitor visitor = new Visitor(CardNo, fNameTxt.Text.Trim(), addressTxt.Text.Trim(),
                        long.Parse(contactTxt.Text.Trim()), genderTxt.Text.Trim(), occupationTxt.Text.Trim(),
                      entryDay, entryTime.Date.ToString("yyyy-MMM-dd"), entryTime);

                
                    if (!entryDay.Equals("Sunday") && !entryDay.Equals("Saturday"))//checks it is sunday or saturday
                    {
                        var sysHours = int.Parse(entryTime.TimeOfDay.Hours.ToString());

                        if ((10<=sysHours) && (17>=sysHours))//checks opening time before adding visitor
                        {
                            saveToCsv(visitor);
                            clear();
                        }
                        else
                        {
                            MessageBox.Show("Museum is closed before 10 and after 5", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
                        }
                    }
                    else
                    {
                        MessageBox.Show("Museum is closed @( sunday & saturday )", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Insert valid Informations", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
         
            }
            
        }

        private void clear()
        {
            fNameTxt.Clear();
            addressTxt.Clear();
            contactTxt.Clear();
            occupationTxt.Clear();
            genderTxt.Clear();
        }

        private void saveToCsv(Visitor visitor)
        {
            if (!File.Exists(_filePath))
            {
             
                using (var streamWriter = new StreamWriter(_filePath, true))
                {
                   
                    streamWriter.WriteLine(visitor.CardNo + "," + visitor.Name + "," + visitor.Address + "," + visitor.ContactNo + "," + visitor.Gender + "," + visitor.Occupation + "," + visitor.Day + "," + visitor.EntryTime.Date.ToString("yyyy-MMM-dd") +","+visitor.EntryTime.ToString("hh:mm tt"));
                    MessageBox.Show("Visitor added : " + visitor.Name, "Added To Record");
                }
            }
            else if (File.Exists(_filePath))
            {
                using (var streamWriter = new StreamWriter(_filePath, true))
                {
                    streamWriter.WriteLine(visitor.CardNo + "," + visitor.Name + "," + visitor.Address + "," + visitor.ContactNo + "," + visitor.Gender + "," + visitor.Occupation + "," + visitor.Day + "," + visitor.EntryTime.Date.ToString("yyyy-MMM-dd") + "," +visitor.EntryTime.ToString("hh:mm tt"));
                    MessageBox.Show("Visitor added : " + visitor.Name, "Added To Record");
                }
            }
        }


        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void fNameTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}