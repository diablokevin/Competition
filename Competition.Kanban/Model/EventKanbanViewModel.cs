using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Competition.EF.Models;
namespace Competition.Kanban.Model
{
    public class EventKanbanViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public string Waiting
        {    
            get
            {
                string s = "";
                foreach (Schedule schedule in Schedules_Waiting)
                {
                    s += string.Format("{0}{1}\n", schedule.Competitor.Race_num, schedule.Competitor.Name);

                }
                return s;
            }
        }
       
        public string Registered
        {
            get
            {
                string s = "";
                foreach (Schedule schedule in Schedules_Registered)
                {
                    s += string.Format("{0}{1}\n", schedule.Competitor.Race_num, schedule.Competitor.Name);

                }
                return s;
            }
        }
        public string Calling
        {
            get
            {
                string s = "";
                foreach (Schedule schedule in Schedules_Calling)
                {
                    s += string.Format("{0}{1}\n", schedule.Competitor.Race_num, schedule.Competitor.Name);

                }
                return s;
            }
        }
        public string InProgress
        {
            get
            {
                string s = "";
                foreach (Schedule schedule in Schedules_InProgress)
                {
                    s += string.Format("{0}{1}\n", schedule.Competitor.Race_num, schedule.Competitor.Name);

                }
                return s;
            }
        }
        public List<Schedule> Schedules_Waiting { get; set; }
        public List<Schedule> Schedules_Registered { get; set; }
        public List<Schedule> Schedules_Calling { get; set; }
        public List<Schedule> Schedules_InProgress { get; set; }
        
        
        

    }
}
