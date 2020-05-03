using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone_TaskList
{
    class Task
    {
        //created fields
        #region fields
        private int taskNumber;
        private string membersName;
        private string memberDescription;
        private DateTime dueDate;
        private bool completion;
        #endregion

        //created properties -- getters and setters
        #region properties
        public int TaskNumber
        {
            get
            {
                return taskNumber;
            }
            set
            {
                taskNumber = value;
            }

        }
        public string MembersName
        {
            get
            {
                return membersName;
            }
            set
            {
                membersName = value;
            }
        }

        public string MembersDescription
        {
            get
            {
                return memberDescription;
            }
            set
            {
                memberDescription = value;
            }
        }

        public DateTime DueDate
        {
            get
            {
                return dueDate;
            }
            set
            {
                dueDate = value;
            }
        }

        public bool Completion
        {
            get
            {
                return completion;
            }
            set
            {
                completion = value;
            }
        }
        #endregion

        //created constructors
        #region constructors
        public Task() { }

        public Task(int _taskNumber, string _membersName, string _memberDescription, DateTime _dueDate, bool _completion)
        {
            taskNumber = _taskNumber;
            membersName = _membersName;
            memberDescription = _memberDescription;
            dueDate = _dueDate;
            completion = _completion;
        }
        #endregion

        //created List
        #region List
        //public static List<Task> GetTaskList()
        //{
        //    List<Task> taskList = new List<Task>
        //    {
        //        new Task("David", "Task is to clean the bathroom by", DateTime.Parse("09/09/2020 "), false),
        //        new Task("James", "Task is to vaccuum, sweep, and dust by", DateTime.Parse("09/11/2020 "), false),
        //        new Task("Wilfred", "Task is to pick up dog poo by", DateTime.Parse("09/06/2020 "), false),
        //        new Task("Louis", "Task is to do all laundry by", DateTime.Parse("09/13/2020 "), false),
        //        new Task("Rufus", "Task is disinfect all hands on surfaces by", DateTime.Parse("09/12/2020 "), false),
        //    };           
        //    return taskList;           
            #endregion

        //}
        //Call the new list method in the Main method of program.
    }
}
