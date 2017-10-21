using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TapThis.Model
{
    public class Week
    {
        public List<Item> Right_Now { get; set; }
        public List<Item> Sunday { get; set; }
        public List<Item> Monday { get; set; }
        public List<Item> Tuesday { get; set; }
        public List<Item> Wednesday { get; set; }
        public List<Item> Thursday { get; set; }
        public List<Item> Friday { get; set; }
        public List<Item> Saturday { get; set; }

        public Week()
        {
            Right_Now = new List<Item>(10);
            Sunday = new List<Item>(10);
            Monday = new List<Item>(10);
            Tuesday = new List<Item>(10);
            Wednesday = new List<Item>(10);
            Thursday = new List<Item>(10);
            Friday = new List<Item>(10);
            Saturday = new List<Item>(10);
        }

        public void Get_Now()
        {
            Right_Now.Clear();

            double Now_Time = System.DateTime.Now.TimeOfDay.TotalHours;
            string Current_Day = System.DateTime.Now.DayOfWeek.ToString();

            //This applies for all days.
            //The first loop handles grabbing the items from the day before the bleed over.
            //The 2nd loop handles grabbing the items of the day itself
            if (Current_Day == "Sunday")
            {
                //Right_Now.AddRange(Saturday.Where(item => item.Bleeds && Now_Time < item.End));
                //Right_Now.AddRange(Sunday.Where(item => (item.Bleeds && item.Start <= Now_Time) || (item.Start <= Now_Time && Now_Time <= item.End)));

                foreach (Item item in Saturday)
                {
                    if (item.Bleeds && Now_Time < item.End)
                    {
                        Right_Now.Add(item);
                    }
                }
                foreach (Item item in Sunday)
                {
                    if (item.Bleeds && item.Start <= Now_Time)
                    {
                        Right_Now.Add(item);
                    }
                    else if (item.Start <= Now_Time && Now_Time <= item.End)
                    {
                        Right_Now.Add(item);
                    }
                }

            }
            else if (Current_Day == "Monday")
            {
                foreach (Item item in Sunday)
                {
                    if (item.Bleeds && Now_Time < item.End)
                    {
                        Right_Now.Add(item);
                    }
                }
                foreach (Item item in Monday)
                {
                    if (item.Bleeds && item.Start <= Now_Time)
                    {
                        Right_Now.Add(item);
                    }
                    else if (item.Start <= Now_Time && Now_Time <= item.End)
                    {
                        Right_Now.Add(item);
                    }
                }
            }
            else if (Current_Day == "Tuesday")
            {
                foreach (Item item in Monday)
                {
                    if (item.Bleeds && Now_Time < item.End)
                    {
                        Right_Now.Add(item);
                    }
                }
                foreach (Item item in Tuesday)
                {
                    if (item.Bleeds && item.Start <= Now_Time)
                    {
                        Right_Now.Add(item);
                    }
                    else if (item.Start <= Now_Time && Now_Time <= item.End)
                    {
                        Right_Now.Add(item);
                    }
                }
            }
            else if (Current_Day == "Wednesday")
            {
                foreach (Item item in Tuesday)
                {
                    if (item.Bleeds && Now_Time < item.End)
                    {
                        Right_Now.Add(item);
                    }
                }
                foreach (Item item in Wednesday)
                {
                    if (item.Bleeds && item.Start <= Now_Time)
                    {
                        Right_Now.Add(item);
                    }
                    else if (item.Start <= Now_Time && Now_Time <= item.End)
                    {
                        Right_Now.Add(item);
                    }
                }
            }
            else if (Current_Day == "Thursday")
            {
                foreach (Item item in Wednesday)
                {
                    if (item.Bleeds && Now_Time < item.End)
                    {
                        Right_Now.Add(item);
                    }
                }
                foreach (Item item in Thursday)
                {
                    if (item.Bleeds && item.Start <= Now_Time)
                    {
                        Right_Now.Add(item);
                    }
                    else if (item.Start <= Now_Time && Now_Time <= item.End)
                    {
                        Right_Now.Add(item);
                    }
                }
            }
            else if (Current_Day == "Friday")
            {
                foreach (Item item in Thursday)
                {
                    if (item.Bleeds && Now_Time < item.End)
                    {
                        Right_Now.Add(item);
                    }
                }
                foreach (Item item in Friday)
                {
                    if (item.Bleeds && item.Start <= Now_Time)
                    {
                        Right_Now.Add(item);
                    }
                    else if (item.Start <= Now_Time && Now_Time <= item.End)
                    {
                        Right_Now.Add(item);
                    }
                }
            }
            else if (Current_Day == "Saturday")
            {
                foreach (Item item in Friday)
                {
                    if (item.Bleeds && Now_Time < item.End)
                    {
                        Right_Now.Add(item);
                    }
                }
                foreach (Item item in Saturday)
                {
                    if (item.Bleeds && item.Start <= Now_Time)
                    {
                        Right_Now.Add(item);
                    }
                    else if (item.Start <= Now_Time && Now_Time <= item.End)
                    {
                        Right_Now.Add(item);
                    }
                }
            }
        }

        public void Clean_Up()
        {
            Right_Now.Clear();
            Sunday.Clear();
            Monday.Clear();
            Tuesday.Clear();
            Wednesday.Clear();
            Thursday.Clear();
            Friday.Clear();
            Saturday.Clear();
        }

    }
}
