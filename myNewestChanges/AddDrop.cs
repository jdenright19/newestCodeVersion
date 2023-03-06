
using Login_GUI;
using Overload_Warning;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warning_Form;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Form
{
    public partial class AddDrop : System.Windows.Forms.Form
    {
        string time;
        //Global variables
        List<String> currentSchedNames = new List<String>(); //this is a internal list of what classes the student is enrolled into
        List<String> currentSchedTimes = new List<String>(); // and the time those classes occur
        float creditTot = 0; // This allows us to know the credit total in this form.
        



        public AddDrop(string user)
        {
            InitializeComponent();
            List<String> Coursedatabase = new List<String>();
            string[] lines2 = System.IO.File.ReadAllLines(@"C:\SE Repos\SE Forms\CourseDatabase.txt");
            this.user = user;

            //Katie's Pathway : C:\Users\katie\Downloads\main-master\main-master\CourseDatabase.txt
            //Jimmy's Pathway : C:\Users\turtl\Desktop\CourseDatabase.txt


            System.Console.WriteLine("Contents of Course database");
            foreach (string line in lines2)
            {
                // Use a tab to indent each line of the file.
                Coursedatabase.Add(line);
                Console.WriteLine("\n" + line);
            }
            for (int i = 0; i < Coursedatabase.Count; i++)
            {
                checkedListBox1.Items.Add(Coursedatabase[i]);
            }
        }


        public string user { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach (int indexChecked in checkedListBox1.CheckedIndices)
            //{
            //    checkedListBox2.Items.Add(checkedListBox1.Items[indexChecked]);
            //}
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Drop_btn_Click(object sender, EventArgs e)
        {
            //foreach (int indexChecked in checkedListBox2.CheckedIndices)
            //{
            //    checkedListBox2.Items.Remove(checkedListBox2.Items[indexChecked]);
            //}

            // in this button going to add the function to delete things from the global lists and the table
            //Conditions to think about: 
            // *what if there are two time blocks?
            // *should I add a seperate clear all function?
            // *how should i delete teh corresponding time block (they should have the same idexs as the course name)?
            // *how do i pull data from the actual cells before i delete the row?

            // decided to pursue rebuilding the entire table instead of deleting a row


           /* foreach (Control c in this.tbl_courseSched.Controls)
            {
                if (Control c is CheckBox && DirectCast(c, CheckBox).Checked)
                {
                    int rowToDelete = tbl_courseSched.GetPositionFromControl(c).Row;
                    tbl_courseSched.Controls.RemoveAt(rowToDelete);
                    tbl_courseSched.RowStyles.RemoveAt(rowToDelete);
                    tbl_courseSched.RowCount -= 1;

                }
            }*/
                List<String> removedItems = new List<String>();

               /* foreach (type SystemWindowsFormsCheckBox in tbl_courseSched.Controls)
                {
                    warningForm error = new warningForm(); // show error window WILL REPLACE WITH ACTUAL GUI EVENTUALLY
                    error.ShowDialog();

                }
               */
                RowStyle temp = tbl_courseSched.RowStyles[tbl_courseSched.RowCount - 1];

            tbl_courseSched.Controls.Clear();
            tbl_courseSched.RowStyles.Clear();
            //Making template
           
            // remaking the header
            tbl_courseSched.RowCount++;
            tbl_courseSched.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
            //Adding the things in the desired places
            tbl_courseSched.Controls.Add(new Label() { Text = "Course Number" }, 0, tbl_courseSched.RowCount - 1);
            tbl_courseSched.Controls.Add(new Label() { Text = "Course Name" }, 1, tbl_courseSched.RowCount - 1);
            tbl_courseSched.Controls.Add(new Label() { Text = "Instructor" }, 2, tbl_courseSched.RowCount - 1);
            tbl_courseSched.Controls.Add(new Label() { Text = "Credit(s)" }, 3, tbl_courseSched.RowCount - 1);
            tbl_courseSched.Controls.Add(new Label() { Text = "Number of Seats" }, 4, tbl_courseSched.RowCount - 1);
            tbl_courseSched.Controls.Add(new Label() { Text = "Number of Time Blocks" }, 5, tbl_courseSched.RowCount - 1);

            tbl_courseSched.Controls.Add(new Label() { Text = "Days" }, 6, tbl_courseSched.RowCount - 1);
            tbl_courseSched.Controls.Add(new Label() { Text = "Start Time" }, 7, tbl_courseSched.RowCount - 1);
            tbl_courseSched.Controls.Add(new Label() { Text = "End Time" }, 8, tbl_courseSched.RowCount - 1);
            tbl_courseSched.Controls.Add(new Label() { Text = "Select"}, 9, tbl_courseSched.RowCount - 1);

        }

        private void tbl_courseSched_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_submit_Click(object sender, EventArgs e)
        {

            List<string> courses = new List<string>(); // this is used to keep track of what courses have been selected in the select menu
            bool nameCheck = false; // this name check that we will use later to make sure we aren't adding any of the same courses twice
            bool timeCheck = false; // this is a time check that we will use later to make sure we aren't adding any courses to the schedule that have time conflicts
            bool credCheck = false;


            foreach (string item in checkedListBox1.CheckedItems) // for each course that was checked...
            {

                courses.Add(item); // we will add the string to the course list

            }

            RowStyle temp = tbl_courseSched.RowStyles[tbl_courseSched.RowCount - 1]; // this is setting the template for the new rows I am going to make later



            for (int i = 0; i < courses.Capacity - 3; i++) // we are now going to look through the course list

            {
                //Splitting everything up in the course descriptions
                string[] courseInfo = courses[i].Split(' ');


                string courseNumber = courseInfo[0]; // course number
                string courseName = courseInfo[1]; // course name
                //we need to add these to the global variables if they aren't already on there

                //course history check
                List<String> historyData = new List<String>();
                var history = new Dictionary<String, List<String>>();
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\turtl\Desktop\CourseHistoryDatabase.txt");
                System.Console.WriteLine("Contents of Course History:");
                foreach (string line in lines)
                {
                    historyData.Add(line);
                    //Debug.WriteLine("\n" + line);
                }
                for (int k = 0; k < historyData.Capacity - 1; k++)
                {
                    dynamic[] classInfo = historyData[k].Split(' ');
                    string username = classInfo[0];
                    history.Add(username, new List<String>());
                    int numCourses = int.Parse(classInfo[1]);
                    // iterate through numClasses, add courses to list, add to dictionary
                    int spot = 2;
                    for (int j = 0; j < numCourses; j++)
                    {
                        history[username].Add(classInfo[spot]);
                        spot += 3;

                    }
                }

                if (history[user].Contains(courseNumber))
                {
                    warningForm error = new warningForm();
                    error.ShowDialog();
                }

                if (currentSchedNames.Count == 0) // if there is nothing in our global list then we can just add the class straight away and pass the check
                {
                    currentSchedNames.Add(courseName);
                    nameCheck = true;
                }


                else
                {
                    foreach (string item in currentSchedNames) // checking the global variable that has access to all of the courses the student has just enrolled in
                    {
                        if (item == courseNumber) // if the course is already been added
                        {
                            nameCheck = false; //it fails the name check 
                            warningForm error = new warningForm(); // show error window WILL REPLACE WITH ACTUAL GUI EVENTUALLY
                            error.ShowDialog(); //Show error
                            break; // break from the loop so we don't do anything crazy
                        }
                        else // if the item and course name aren't the same
                        {
                            nameCheck = true; // it is passing the namecheck as of now

                        }

                    }

                    if (nameCheck) { currentSchedNames.Add(courseName); } // if it did pass the name check we are going to add it to are global list
                }



                string instructor = courseInfo[2]; // instructor info
                string credit = courseInfo[3]; // credit info

                creditTot = (float)(creditTot + float.Parse(credit));

                if (creditTot >= 5) // CHECK LATER THIS IS SCREWED UP
                {
                    credCheck = false;

                }
                else
                {
                    credCheck = true;
                }

                if (credCheck == false)
                {
                    OverloadForm overloaderror = new OverloadForm();
                    overloaderror.ShowDialog();
                    break;
                }

                string numSeats = courseInfo[4]; // number of seats info

                //Need to translate these into actual times
                string timeBlocks = courseInfo[5]; // how many time blocks this course has
                string days = courseInfo[6]; // this is the time code that later has to be translated accordingly 

                if (nameCheck == true) // here we are doing a time check only if it passes the first name check (we don't want two error windows popping up if you try to enroll in the exact same class)
                {
                    if (currentSchedTimes.Count == 0) // if there is nothing in the global list we can just add it and pass the check
                    {
                        currentSchedTimes.Add(days);
                        timeCheck = true;
                    }

                    else
                    {
                        foreach (string item in currentSchedTimes) // for each item in the list
                        {
                            if (item == days) // if it is the EXACT same as the course number I NEED TO FIGURE OUT HOW TO DO CONFLICTING TIMES BETTER 
                            {

                                timeCheck = false; // fails the check
                                OverloadForm overloaderror = new OverloadForm();
                                overloaderror.ShowDialog(); //shows the error dialog THAT NEEDS TO BE ADDED 
                                break; // Breaks out of this loop no need to keep checking


                            }
                            else
                            {
                                timeCheck = true;

                            }
                        }
                        if (timeCheck == true) { currentSchedTimes.Add(days); } // only adds if we yield a passed check



                    }
                }

                if (nameCheck && timeCheck && credCheck)
                {  //Making my new row
                    tbl_courseSched.RowCount++;
                    tbl_courseSched.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));

                    //Adding the things in the desired places
                    tbl_courseSched.Controls.Add(new Label() { Text = courseNumber }, 0, tbl_courseSched.RowCount - 1);
                    tbl_courseSched.Controls.Add(new Label() { Text = courseName }, 1, tbl_courseSched.RowCount - 1);
                    tbl_courseSched.Controls.Add(new Label() { Text = instructor }, 2, tbl_courseSched.RowCount - 1);
                    tbl_courseSched.Controls.Add(new Label() { Text = credit }, 3, tbl_courseSched.RowCount - 1);
                    tbl_courseSched.Controls.Add(new Label() { Text = numSeats }, 4, tbl_courseSched.RowCount - 1);
                    tbl_courseSched.Controls.Add(new Label() { Text = timeBlocks }, 5, tbl_courseSched.RowCount - 1);

                    tbl_courseSched.Controls.Add(new Label() { Text = dayTranslation(days) }, 6, tbl_courseSched.RowCount - 1);
                    tbl_courseSched.Controls.Add(new Label() { Text = timeStartTranslation(days) }, 7, tbl_courseSched.RowCount - 1);
                    tbl_courseSched.Controls.Add(new Label() { Text = timeEndTranslation(days, time) }, 8, tbl_courseSched.RowCount - 1);
                    tbl_courseSched.Controls.Add(new CheckBox(), 9, tbl_courseSched.RowCount - 1);

                    //only happens if there are two time blocks
                    if (courseInfo.Count() == 8)
                    {
                        string extraTimeBlock = courseInfo[7];
                        tbl_courseSched.RowCount++;
                        tbl_courseSched.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
                        tbl_courseSched.Controls.Add(new Label() { Text = dayTranslation(extraTimeBlock) }, 6, tbl_courseSched.RowCount - 1);
                        tbl_courseSched.Controls.Add(new Label() { Text = timeStartTranslation(extraTimeBlock) }, 7, tbl_courseSched.RowCount - 1);
                        tbl_courseSched.Controls.Add(new Label() { Text = timeEndTranslation(extraTimeBlock, time) }, 8, tbl_courseSched.RowCount - 1);
                    }


                    // resetting my bool statements to false to then re iterate through more courses
                    timeCheck = false;
                    nameCheck = false;
                    credCheck = false;




                }



            }








            string dayTranslation(string timeReadIn)
            {
                int x = int.Parse(timeReadIn);

                if (x / 1000 == 21)
                {
                    return "MWF";
                }
                else if (x / 1000 == 8)
                {
                    return "R";
                }
                else if (x / 1000 == 15) { return "MTWR"; }
                else if (x / 1000 == 12) { return "WR"; }
                else if (x / 1000 == 1) { return "M"; }
                else if (x / 1000 == 2) { return "T"; }
                else if (x / 1000 == 4) { return "W"; }

                else
                {
                    return "F";
                }

            }

            //This is a dumb way to do this. Maybe coming back and fixing this may be good
            string timeStartTranslation(string timeReadIn)
            {
                int x = int.Parse(timeReadIn);
                float finalTime = 0;
                bool not12 = true;
                bool isPM = false;
                int y;
                float milTime = ((x / 10) % 100) / 2f;
               
                //These next conditional Statements are finding out the start time of the course
                if ((milTime / 12) <= 1) //AM
                {
                    if (milTime % 0.5 == 1) // If we have a 30 minute start time
                    {
                        finalTime = (int)(milTime - 0.5);
                        time = finalTime.ToString();
                        time = time + ":30 A.M.";

                    }
                    else
                    {
                        time = milTime.ToString();
                        time = time + ":00 A.M.";
                    }

                    
                    
                }
                // NEED TO MAKE AN IF ELSE IF THERE IS AN EXACT 12

                else //PM
                {
                    finalTime = (int)(milTime - 12); // Subtracting 12 hours from military time because it is in the PM // IT IS NOT SUBTRACTING BY 12 WTF

                    if (finalTime % 0.5 == 1) // If we have a 30 minute start time
                    {
                        finalTime = (int)(milTime - 0.5);

                        time = finalTime.ToString();
                        time = time + ":30 P.M.";

                    }
                    else
                    {
                        time = finalTime.ToString();
                        time = time + ":00 P.M.";
                    }

                    isPM = true;

                }
                string[] tempVal1 = time.Split(":");
                string firstNum1 = tempVal1[0];
                y = int.Parse(firstNum1);
                tempVal1[0] += ":";
                tempVal1[0] += tempVal1[1];


                string[] tempVal = time.Split(":");
                string firstNum = tempVal[0];
                y = int.Parse(firstNum);
                if (y == 0)
                {
                    tempVal[0] = "";
                    tempVal[0] += 12;
                    tempVal[0] += ":";
                    tempVal[0] += tempVal[1];
                    not12 = false;
                }
                if (not12 == true)
                {
                    return tempVal1[0];
                }
                else 
                {
                    return tempVal[0];
                }
            }

            // this block of conditional statements is going to add the end time of the course to the time string
            //This code isn't working for some reason
            string timeEndTranslation(string timeReadIn, string timeval)
            {

                int x = int.Parse(timeReadIn);
                float finalTime;
                string[] time = timeval.Split(':');
                string firstNum = time[0];
                string SecNum = time[1];
                bool isPM = false;
                finalTime = (x % 10);
                double timeComp = float.Parse(time[0]);
                if (time[1] == "30")
                {
                    timeComp += .5;
                }
                if (timeComp == 0)
                {
                    timeComp += 12;
                }

                for (int i = 0; i < finalTime; i++)
                {
                    timeComp += .5;
                }
                if (timeComp > 12)
                {
                    timeComp -= 12;
                    isPM = true;
                }
                if (timeComp % 1 != 0)
                {
                    timeComp -= .5;
                    time[0] = timeComp.ToString();
                    time[0] += ":30";
                }
                else
                {
                    time[0] = timeComp.ToString();
                    time[0] += ":00";
                }
                if (isPM == true)
                {
                    time[0] += " P.M.";
                }
                else 
                {
                    time[0] += " A.M.";
                }
                return time[0];
                /* bool isPM = false;

                 float milTime = ((x / 10) % 100) / 2f;
                 int endTime = (int)(x % 10);
                 finalTime = (int)(milTime - 0.5);
                 //string y; 
                 if (endTime == 3)
                 {
                     finalTime = finalTime + 1;

                     if (finalTime > 12)
                     {
                         finalTime = finalTime - 12;
                         time2 += " - ";
                         time2 += finalTime.ToString();

                         time2 += ":30 P.M.";
                     }
                     else
                     {
                         time2 += " - ";
                         time2 += finalTime.ToString();

                         time2 += ":30 ";
                         if (isPM == true) { time2 += "P.M."; }
                         else { time2 += "A.M."; }

                     }


                 }
                 else
                 {
                     finalTime = finalTime + 1;
                     time2 += " - ";

                     time2 += finalTime.ToString();  // here is the issue

                     time2 += ":00";
                     if (isPM == true) { time2 += "P.M."; }
                     else { time2 += "A.M."; }

                 }

                 endTime = (int)(x % 10);
                 //string y; 
                 if (endTime == 3)
                 {
                     finalTime = finalTime + 1;

                     if (finalTime > 12)
                     {
                         finalTime = finalTime - 12;

                         time2 += " - ";
                         time2 += finalTime.ToString();

                         time2 += ":30 P.M.";
                     }
                     else
                     {
                         time2 += " - ";
                         time2 += finalTime.ToString();

                         time2 += ":30 ";
                         if (isPM == true) { time2 += "P.M."; }
                         else { time2 += "A.M."; }

                     }


                 }
                 else
                 {
                     finalTime = finalTime + 1;
                     time2 += " - ";

                     time2 += finalTime.ToString();  // here is the issue

                     time2 += ":00";
                     if (isPM == true) { time2 += "P.M."; }
                     else { time2 += "A.M."; }

                 }

                */


            }


        }

    }

    internal class type
    {
    }
}
