using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TapThis.Model
{
    public class Week
    {
        public List<Item> Right_Now { get; set; } = new List<Item>(10);
        public List<Item> Sunday { get; set; } = new List<Item>(10);
        public List<Item> Monday { get; set; } = new List<Item>(10);
        public List<Item> Tuesday { get; set; } = new List<Item>(10);
        public List<Item> Wednesday { get; set; } = new List<Item>(10);
        public List<Item> Thursday { get; set; } = new List<Item>(10);
        public List<Item> Friday { get; set; } = new List<Item>(10);
        public List<Item> Saturday { get; set; } = new List<Item>(10);

        public Week()
        {

        }

        public void Get_Now()
        {
            Right_Now.Clear();

            double Now_Time = System.DateTime.Now.TimeOfDay.TotalHours;
            string Current_Day = System.DateTime.Now.DayOfWeek.ToString();

            //This applies for all days.
            //The first loop handles grabbing the items from the day before the bleed over.
            //The 2nd loop handles grabbing the items of the day itself 
            //Loops were 148 lines
            //Lambda is 30 lines
            if (Current_Day == "Sunday")
            {
                Right_Now.AddRange(Saturday.Where(item => item.Bleeds && Now_Time < item.End));
                Right_Now.AddRange(Sunday.Where(item => (item.Bleeds && item.Start <= Now_Time) || (item.Start <= Now_Time && Now_Time <= item.End)));
            }
            else if (Current_Day == "Monday")
            {
                Right_Now.AddRange(Sunday.Where(item => item.Bleeds && Now_Time < item.End));
                Right_Now.AddRange(Monday.Where(item => (item.Bleeds && item.Start <= Now_Time) || (item.Start <= Now_Time && Now_Time <= item.End)));
            }
            else if (Current_Day == "Tuesday")
            {
                Right_Now.AddRange(Monday.Where(item => item.Bleeds && Now_Time < item.End));
                Right_Now.AddRange(Tuesday.Where(item => (item.Bleeds && item.Start <= Now_Time) || (item.Start <= Now_Time && Now_Time <= item.End)));
            }
            else if (Current_Day == "Wednesday")
            {
                Right_Now.AddRange(Tuesday.Where(item => item.Bleeds && Now_Time < item.End));
                Right_Now.AddRange(Wednesday.Where(item => (item.Bleeds && item.Start <= Now_Time) || (item.Start <= Now_Time && Now_Time <= item.End)));
            }
            else if (Current_Day == "Thursday")
            {
                Right_Now.AddRange(Wednesday.Where(item => item.Bleeds && Now_Time < item.End));
                Right_Now.AddRange(Thursday.Where(item => (item.Bleeds && item.Start <= Now_Time) || (item.Start <= Now_Time && Now_Time <= item.End)));
            }
            else if (Current_Day == "Friday")
            {
                Right_Now.AddRange(Thursday.Where(item => item.Bleeds && Now_Time < item.End));
                Right_Now.AddRange(Friday.Where(item => (item.Bleeds && item.Start <= Now_Time) || (item.Start <= Now_Time && Now_Time <= item.End)));
            }
            else if (Current_Day == "Saturday")
            {
                Right_Now.AddRange(Friday.Where(item => item.Bleeds && Now_Time < item.End));
                Right_Now.AddRange(Saturday.Where(item => (item.Bleeds && item.Start <= Now_Time) || (item.Start <= Now_Time && Now_Time <= item.End)));
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
