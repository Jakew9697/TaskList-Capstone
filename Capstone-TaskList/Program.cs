using System;
using System.Collections.Generic;

namespace Capstone_TaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> newTaskList = new List<Task>();
            
            newTaskList.Add(new Task(1, " David", "Task is to clean the bathroom by", DateTime.Parse("09/09/2020 "), false));
            newTaskList.Add(new Task(2, " James", "Task is to vaccuum, sweep, and dust by", DateTime.Parse("09/11/2020 "), false));
            newTaskList.Add(new Task(3, " Wilfred", "Task is to pick up dog poo by", DateTime.Parse("09/06/2020 "), false));
            newTaskList.Add(new Task(4, " Louis", "Task is to do all laundry by", DateTime.Parse("09/13/2020 "), false));
            newTaskList.Add(new Task(5, " Rufus", "Task is to disinfect all hands on surfaces by", DateTime.Parse("09/12/2020 "), false));

            bool cont = true;

            while (cont)
            {
                Console.WriteLine();
                Console.WriteLine("What would you like to do? Press 1, 2, 3, 4 or 5. ");

                Console.WriteLine(" \n 1. List Tasks \n 2. Add task \n 3. Delete Task \n 4. Mark Task As Complete \n 5. Quit");

                //new list method called here (only if you create the list in the independent Class)


                //getting user input
                #region 1. List Tasks options                
                int menuSelection = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (menuSelection == 1)
                {
                    int i = 1;
                    foreach (Task task in newTaskList)
                    {
                        Console.WriteLine(task.TaskNumber + task.MembersName + "'s " + task.MembersDescription + " " + task.DueDate.ToShortDateString() + "." + " " + "Completion status: " + task.Completion);
                        i++;
                        Console.WriteLine();
                    }
                }
                #endregion

                #region 2. Adding Task
                else if (menuSelection == 2)
                {
                    AddTask(newTaskList);
                }
                #endregion

                #region 3. Delete Task
                else if (menuSelection == 3)
                {
                    while (true)
                    {
                        Console.WriteLine("what task would you like to delete: 1, 2, 3, 4, or 5? ");

                        int deleteInput = int.Parse(Console.ReadLine());

                        if (deleteInput >= 1 && deleteInput <= newTaskList.Count)
                        {
                            try
                            {
                                newTaskList.RemoveAt(deleteInput - 1);
                                Console.WriteLine();
                                Console.WriteLine($"Task {deleteInput} has been deleted ");
                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Sorry that number does not correlate to a task. ");
                            }
                            catch (IndexOutOfRangeException)
                            {
                                Console.WriteLine("Sorry that number does not correlate to a task. ");
                            }
                        }

                    }
                }
                #endregion

                #region 4. Mark Task as complete
                else if (menuSelection == 4)
                {
                    while (true)
                    {
                        Console.WriteLine("Which task would you like to mark as complete? ");

                        int taskComplete = int.Parse(Console.ReadLine());

                        if (taskComplete >= 1 && taskComplete <= newTaskList.Count)
                        {
                            try
                            {
                                newTaskList[taskComplete - 1].Completion = true;
                                Console.WriteLine();
                                Console.WriteLine($"Task {taskComplete} Has been marked as complete.");
                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Sorry that number does not correlate to a task. ");
                            }
                            catch (IndexOutOfRangeException)
                            {
                                Console.WriteLine("Sorry that number does not correlate to a task. ");
                            }
                        }

                    }
                }
                #endregion

                #region 5. Quit menu selection
                else if (menuSelection == 5)
                {
                    break;
                }
                #endregion
            }
        }



    //Methods
    public static void AddTask(List<Task> taskList)
    {
        Task newTask = new Task();

        Console.WriteLine("Who will be completing this task? ");
        newTask.MembersName = Console.ReadLine();

        Console.WriteLine("What is their task description? ");
        newTask.MembersDescription = Console.ReadLine();

        Console.WriteLine("When is the due date for this task? ");
        newTask.DueDate = DateTime.Parse(Console.ReadLine());

        newTask.Completion = false;

        Console.WriteLine("Task added to the task list. Thank you! ");

        taskList.Add(newTask);
    }


    public static bool UserContinue(string message)
    {
        Console.WriteLine(message);
        String Response = Console.ReadLine().ToLower();
        while (Response != "n" && Response != "y")
        {
            Console.WriteLine("What was that?  Would you like to learn more? y/n");
            Response = Console.ReadLine();
        }
        if (Response == "y")
        {
            Console.WriteLine("Okay!  See you next time.");
            return false;
        }
        else
            return true;
    }
    }






    //public static void DeleteTask(List<Task> deleteTaskFromList)
    //{
    //    Task newTask = new Task();

    //    Console.WriteLine("Which task would you like to delete? 1, 2, 3, 4 or 5? ");

    //    int input = int.Parse(Console.ReadLine());

    //}
}

