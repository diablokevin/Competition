﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;


namespace Competition.EF.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Display(Name = "名称")]
        public string Name { get; set; }
        [Display(Name = "专业")]
        public string Pro { get; set; }
        [Display(Name = "菜单排序")]
        public int MenuOrder { get; set; }
        [Display(Name = "限时")]
        public TimeSpan TimeLimit { get; set; }
        [Display(Name = "数量")]
        public int Amount { get; set; } = 1;
        [Display(Name = "时间分")]
        public bool HasTimeScore { get; set; } = true;
        public bool MultiScoreDetailSet { get; set; } = false;
        [Display(Name = "主板ID")]
        public virtual ICollection<Chip> Chips { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }

        public virtual ICollection<EventCriteria> EventCriterias { get; set; }

    }

    public class Chip
    {
        public int Id { get; set; }
        public int Serial { get; set; }
        public string Name { get; set; }
        public int EventId { get; set; }
        public virtual Event Event { get; set; }
    }
    public class Company
    {
        public int Id { get; set; }
        [Display(Name = "公司名称")]
        public string Name { get; set; }

        public virtual ICollection<Competitor> Competitors { get; set; }
    }

    public class Competitor
    {
        public int Id { get; set; }
        [Display(Name = "姓名")]
        public string Name { get; set; }
        [Display(Name = "专业")]
        public string Pro { get; set; }
        [Display(Name = "员工号")]
        public string StaffId { get; set; }
        [Display(Name = "比赛编号")]
        public string Race_num { get; set; }
        [Display(Name = "公司")]
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }

    public enum SchedulStatus
    {
        [Description("等待中")]
        Waiting,
        [Description("已报到")]
        Registered,
        [Description("呼叫中")]
        Calling,
        [Description("进行中")]
        Inprogress,
        [Description("已完成")]
        Complete
    }
    public class Schedule
    {
        public int Id { get; set; }
        [Display(Name = "项目名称")]
        public int EventId { get; set; }
        [Display(Name = "选手")]
        public int? CompetitorId { get; set; }

        public string Subject
        {
            get
            {
                return Event.Name + "|" + Competitor.Name;
            }
        }
        [Display(Name = "开始时间")]
        public DateTime? PlanBeginTime { get; set; }
        [Display(Name = "结束时间")]
        public DateTime? PlanEndTime { get; set; }
        [Display(Name = "用时")]
        public TimeSpan? TimeCosumeAVG
        {
            get
            {

                TimeSpan t = new TimeSpan();
                int count = 0;
                foreach (Score s in Scores)
                {
                    if (s.TimeConsume != null)
                    {
                        t += s.TimeConsume.Value;
                        count++;
                    }

                }
                if (count != 0)
                {
                    return new TimeSpan(0, 0, (int)t.TotalSeconds / count);
                }
                else
                {
                    return null;
                }



            }
        }
        [Display(Name = "平均得分")]
        public double? MarkAVG
        {
            get
            {              
                double total = 0.0;
                foreach (Score s in Scores)
                {
                    total += s.Mark ?? 0;
                }
                if (Scores.Count > 0)
                {
                    return total / Scores.Count;
                }
                else
                {
                    return null;
                }

            }
        }

        public SchedulStatus Status { get; set; } = SchedulStatus.Waiting;
        public virtual Competitor Competitor { get; set; }
        public virtual Event Event { get; set; }

        public virtual ICollection<Score> Scores { get; set; }
    }

    public class Score
    {
        public int Id { get; set; }
        [Display(Name = "用时")]
        public TimeSpan? TimeConsume { get; set; }
        [Display(Name = "得分")]
        public double? Mark { get; set; }
        [Display(Name = "提交时间")]
        public Nullable<System.DateTime> JudgeTime { get; set; }
        [Display(Name = "修改时间")]
        public Nullable<System.DateTime> ModifyTime { get; set; }

        public int ScheduleId { get; set; }

        [Display(Name = "裁判")]
        public int? JudgeId { get; set; }

      

        [NotMapped]
        public int? TimeConsume_hour
        {
            get
            {
                if (TimeConsume.HasValue)
                {
                    return TimeConsume.Value.Hours;
                }
                return null;
            }
            set
            {
                if (TimeConsume.HasValue)
                {
                    TimeConsume = new TimeSpan(value ?? 0, TimeConsume.Value.Minutes, TimeConsume.Value.Seconds); ;
                }
                else
                {
                    TimeConsume = new TimeSpan(value ?? 0, 0, 0);
                }
            }
        }
        [NotMapped]
        public int? TimeConsume_minute
        {
            get
            {
                if (TimeConsume.HasValue)
                {
                    return TimeConsume.Value.Minutes;
                }
                return null;
            }
            set
            {
                if (TimeConsume.HasValue)
                {
                    TimeConsume = new TimeSpan(TimeConsume.Value.Hours, value ?? 0, TimeConsume.Value.Seconds); ;
                }
                else
                {
                    TimeConsume = new TimeSpan(0, value ?? 0, 0);
                }


            }
        }
        [NotMapped]
        public int? TimeConsume_second
        {
            get
            {
                if (TimeConsume.HasValue)
                {
                    return TimeConsume.Value.Seconds;
                }
                return null;
            }
            set
            {
                if (TimeConsume.HasValue)
                {
                    TimeConsume = new TimeSpan(TimeConsume.Value.Hours, TimeConsume.Value.Minutes, value ?? 0); ;
                }
                else
                {
                    TimeConsume = new TimeSpan(0, 0, value ?? 0);
                }


            }
        }
        [DataType(DataType.MultilineText)]
        public string Note { get; set; }
        public virtual Judge Judge { get; set; }
        public virtual Schedule Schedule { get; set; }
      
        public virtual List<ScoreDetail> ScoreDetail { get; set; }
    }
    public class EventCriteria
    {
        public int Id { get; set; }
        public string SetName { get; set; } 
        [DataType(DataType.MultilineText)]
        public string Title { get; set; }
        public int MinScore { get; set; } = 0;
        public int MaxScore { get; set; }
        public string Note { get; set; }
        public int EventId { get; set; }
        public virtual Event Event { get; set; }
        public virtual ICollection<ScoreDetail> ScoreDetail { get; set; }
    }
    public class ScoreDetail
    {
        public int Id { get; set; }
        public double Mark { get; set; } = 0.0;
        
        public int EventCriteriaId { get; set; }
        
        public int ScoreId { get; set; }
        public string Note { get; set; }
        public virtual EventCriteria EventCriteria { get; set; }
        public virtual Score Score { get; set; }

            

    }
    public class Judge
    {
        public int Id { get; set; }
        [Display(Name = "姓名")]
        public string Name { get; set; }
        // public string UserId { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<int> EventId { get; set; }
        [Display(Name = "员工号")]
        public string StaffId { get; set; }

        public virtual Company Company { get; set; }
        public virtual Event Event { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }

 


}
