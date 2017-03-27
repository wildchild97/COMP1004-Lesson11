using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_Lesson11
{
    public partial class DataForm : Form
    {
        //SchoolContext SchoolDB = new SchoolContext();

        public DataForm()
        {
            InitializeComponent();

            /*
             * try
             * {
            selects all the users in the Users table of the Name DB
             var UsersList = (from user in NamesDB.Users
                                Select user).FirstOrDefault();

                UsersDataGridView.DataSource = UsersList;

                UsersDataGridView.
               }
               catch (Exception exception)
               {
                Debug.WriteLine(.exception);
               }
            
            foreach (var user in UserList)
            {
                Debug.WriteLine(user.FirstName);
            }
           
             var CourseList = (from course in SchoolDb.Courses
                                select course).ToList();

            foreach(var course in CourseList)
            {
                Debug.WriteLine(course.CourseShortdescription);
            }
             */
        }

        private void UsersDataGridView_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            var rowindex = UsersDataGridView.CurrentRow.Index;
            var currentId = UsersDataGridView.Rows[rowindex].Cells[0].Value;

            try
            {
                var SelectedName = (from name in NamesDb.Users
                                    where name.Id == currentId
                                    select name).FirstOrDefault();

                Debug.WriteLine(selectedName.FirstName);
            }
        }
    }
}
