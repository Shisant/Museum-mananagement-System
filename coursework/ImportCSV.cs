using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace coursework
{
    public partial class ImportCSV : Form
    {
        DataTable visitorData = new DataTable();
        DataGridViewButtonColumn exitButtonColumn = new DataGridViewButtonColumn();
        CultureInfo cul = CultureInfo.CurrentCulture;
        Dictionary<string, int> totalVisitor = new Dictionary<string, int>();
        Dictionary<string, int> sortedDict = new Dictionary<string, int>();
        Dictionary<string, int> totalDuration = new Dictionary<string, int>();
        public ImportCSV()
        {
            InitializeComponent();
            bar.Series.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = ".csv";
            openFileDialog.Filter = "Separated by comma ( *.csv)|*.csv";
           if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
     
                filepathTxt.Text = openFileDialog.FileName;
                visitorData.Reset();
                visitorData = new DataTable();
                getCSV(filepathTxt.Text);
            }
            else
            {
                openFileDialog.Dispose();
            }

        }

        private void getCSV(string filetext)
        {
            visitorData.Columns.Add(new DataColumn("Card Number"));
            visitorData.Columns.Add(new DataColumn("Name"));
            visitorData.Columns.Add(new DataColumn("Address"));
            visitorData.Columns.Add(new DataColumn("Contact Number"));
            visitorData.Columns.Add(new DataColumn("Gender"));
            visitorData.Columns.Add(new DataColumn("Occupation"));
            visitorData.Columns.Add(new DataColumn("Day"));
            visitorData.Columns.Add(new DataColumn("Date"));
            visitorData.Columns.Add(new DataColumn("EntryTime"));
            visitorData.Columns.Add(new DataColumn("ExitTime"));
            visitorData.Columns.Add(new DataColumn("Time Spent"));

            string[] record = File.ReadAllLines(filepathTxt.Text);

            for (int j = 0; j < record.Length; j++)
            {
                DataRow DataR = visitorData.NewRow();
                string[] row = record[j].Split(',');
                int y = 0;
                foreach (string r in row)
                {
                    DataR[y++] = r;
                }
                visitorData.Rows.Add(DataR);
            }
            dataGridView1.DataSource = visitorData;



            exitButtonColumn.Name = "Check Out";
            exitButtonColumn.Text = "Check Out";
            exitButtonColumn.UseColumnTextForButtonValue = true;
            int columnIndexes = 11;
            if (dataGridView1.Columns["Check Out"] == null)
            {
                dataGridView1.Columns.Insert(columnIndexes, exitButtonColumn);

            }

            dataGridView1.CellClick += GridView_CellClick;
            dataGridView1.AllowUserToAddRows = false;
        }



        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dataGridView1.Columns["Check Out"].Index)
                {
                    if (visitorData.Rows[e.RowIndex][10].ToString() == "")
                    {
                        string checkOutTime = System.DateTime.Now.ToString("hh:mm tt");
                        visitorData.Rows[e.RowIndex].SetField(9, checkOutTime);

                        string EntryTime = visitorData.Rows[e.RowIndex][8].ToString();
                        DateTime InTime = DateTime.Parse(EntryTime);
                        string Time_Spent = Math.Round((DateTime.Parse(checkOutTime)).Subtract(InTime).TotalMinutes).ToString();

                        visitorData.Rows[e.RowIndex].SetField(10, Time_Spent);

                        string[] lines = File.ReadAllLines(filepathTxt.Text);
                        lines[e.RowIndex] = visitorData.Rows[e.RowIndex][0] + "," + visitorData.Rows[e.RowIndex][1] + "," + visitorData.Rows[e.RowIndex][2] + "," +
                            visitorData.Rows[e.RowIndex][3] + "," + visitorData.Rows[e.RowIndex][4] + "," + visitorData.Rows[e.RowIndex][5] + "," 
                            + visitorData.Rows[e.RowIndex][6] + "," + visitorData.Rows[e.RowIndex][7] + "," + visitorData.Rows[e.RowIndex][8] + ","
                            + visitorData.Rows[e.RowIndex][9] + "," + visitorData.Rows[e.RowIndex][10];
                        File.WriteAllLines(filepathTxt.Text, lines);
                    }
                    else
                    {
                        MessageBox.Show("Visitor Left", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {

            }
        }
            
  
    

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ImportCSV_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            string getDate = dateTimePicker1.Value.ToString("yyyy-MMM-dd");

            List<string> TotalRecords = new List<string>();
            int counter = 0;
            int timeSpent = 0;
            foreach (DataGridViewRow rows in dataGridView1.Rows)
            {
                if (getDate == dataGridView1.Rows[rows.Index].Cells[7].Value.ToString())
                {
                    try
                    {
                        TotalRecords.Insert(counter, "");
                        timeSpent = timeSpent + int.Parse(dataGridView1.Rows[rows.Index].Cells[10].Value.ToString());
                        TotalRecords[counter] = TotalRecords[counter];
                        counter++;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Still left to Check out Some Visitors.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
                totalVistorTxt.Text = TotalRecords.Count.ToString();
                durationTxt.Text = timeSpent.ToString();
        }
           
        

        private void button1_Click_2(object sender, EventArgs e)
        {
           
            DateTime date = dateTimePicker2.Value; //get current datetime 
                                          
            int year = date.Date.Year; //get year from the date
            //set the first day of the year
            DateTime firstDay = new DateTime(year, 1, 1);
            //get Day of the week 
            DayOfWeek day = date.DayOfWeek;
            //get no of week for the date
            int weekNo = cul.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
            //get no of day
            int days = (weekNo - 1) * 7;
            DateTime dt1 = firstDay.AddDays(days);
            DayOfWeek dow = dt1.DayOfWeek;
            DateTime startDateOfWeek = dt1.AddDays(-(int)dow);
            DateTime endDateOfWeek = startDateOfWeek.AddDays(6);
            textBoxFrom.Text = startDateOfWeek.ToString("yyyy - MMM - dd");
            textBoxTo.Text = endDateOfWeek.ToString("yyyy - MMM - dd");
            generateReport();
            generateWeeklyReport.Enabled = false;
        }


        /*
         This method allows to generate weekly report. It shows the total working days with number of visitors.
             */

        private void generateReport()
        {
            try
            {
                DateTime beginDate1 = DateTime.Parse(textBoxFrom.Text);
                int dateWeek = cul.Calendar.GetWeekOfYear(beginDate1, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
                List<string> dates = new List<string>();
                List<int> timespent = new List<int>();
                foreach (DataGridViewRow allRows in dataGridView1.Rows)
                {
                    try
                    {
                        dates.Add(dataGridView1.Rows[allRows.Index].Cells[7].Value.ToString());
                        timespent.Add(Int32.Parse(dataGridView1.Rows[allRows.Index].Cells[10].Value.ToString()));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Still left to Check out Some Visitors.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                timespent.ToList().ForEach(i => Console.WriteLine(i.ToString()));

                List<string> checkDates = new List<string>();

                for (int i = 0; i < dates.Count; i++)
                {
                    DateTime dates1 = DateTime.Parse(dates[i]);
                    int dates1Week = cul.Calendar.GetWeekOfYear(dates1, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
                    if (dates1Week == dateWeek)
                    {
                        checkDates.Add(dates1.ToString());
                    }
                }

                List<string> daysList = new List<string>();

                for (int i = 0; i < checkDates.Count; i++)
                {
                    DateTime days = DateTime.Parse(checkDates[i]);
                    String daysName = days.DayOfWeek.ToString();
                    daysList.Add(daysName);
                }



                foreach (string days in daysList)
                {
                    if (!totalVisitor.ContainsKey(days))
                    {
                        totalVisitor.Add(days, 1);
                    }
                    else
                    {
                        int x = 0;
                        totalVisitor.TryGetValue(days, out x);
                        totalVisitor.Remove(days);
                        totalVisitor.Add(days, x + 1);

                    }


                }

                int count = 0;

                foreach (string days in daysList)
                {

                    if (!totalDuration.ContainsKey(days))
                    {
                        totalDuration.Add(days, timespent[count]);
                    }
                    else
                    {
                        int x = 0;
                        totalDuration.TryGetValue(days, out x);
                        totalDuration.Remove(days);
                        totalDuration.Add(days, x + timespent[count]);

                    }

                    count++;
                }

                bar.Series.Clear();
                bar.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
                bar.Titles.Add("Weekly Report according to Total Time Spent");


                foreach (KeyValuePair<string, int> keyvalue in totalDuration)
                {
                    Series series = new Series();
                    series = bar.Series.Add(keyvalue.Key);
                    series.Points.Add(keyvalue.Value);

                }


                dataGridView2.DataSource = (from days in totalVisitor select new { days.Key, days.Value }).ToList();
            }
            catch(Exception)
            {
                MessageBox.Show("Error in Report Generation. Please Re-Load the CSV File.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // Clear textBox 
        private void buttonClear_Click(object sender, EventArgs e)
        {
            totalVistorTxt.Clear();
            durationTxt.Clear();
        }

        private void textBoxFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*
           This method sorts the data from the weekly report. The sorting algorithm used is Bubble Sort. The data is sorted by total number of visitor.

         */

        private void sort_report_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> sortingarray = new List<int>();
                foreach (KeyValuePair<string, int> each in totalVisitor)
                {
                    int value = each.Value;
                    sortingarray.Add(value);
                }
                // Bubble Sort for sorting lisr called sortingarray.
                for (int i = sortingarray.Count - 1; i > 0; i--)
                {
                    for (int j = 0; j <= i - 1; j++)
                    {
                        if (sortingarray[j] > sortingarray[j + 1])

                        {
                            int big = sortingarray[j];
                            sortingarray[j] = sortingarray[j + 1];
                            sortingarray[j + 1] = big;
                        }
                    }
                }
                //Using loop to get value from sorted array to dictionary.
                foreach (int value in sortingarray)
                {
                    string key = totalVisitor.FirstOrDefault(x => x.Value == value).Key;
                    sortedDict.Add(key, value);
                }
                // Displays sorted and updated value in DataGrid.
                dataGridView2.DataSource = (from days in sortedDict select new { days.Key, days.Value }).ToList();
                MessageBox.Show("Data is Sorted", "Hello !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                dataGridView2.DataSource = (from days in totalVisitor orderby days.Value select new { days.Key, days.Value }).ToList();
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }


}
