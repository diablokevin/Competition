using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Competition.Web.Models
{
    public class PersonalRank
    {
        [Display(Name="排名")]
        public int Rank { get; set; }
        [Display(Name = "姓名")]
        public string Name { get; set; }
        [Display(Name = "员工号")]
        public string Staffid { get; set; }
        [Display(Name = "专业")]
        public string Pro { get; set; }
        [Display(Name = "公司")]
        public string Company { get; set; }
        [Display(Name = "完成数量")]
        public int Count { get; set; }
        [Display(Name = "笔试")]
        public double? Bishi { get; set; }
        [Display(Name = "部件拆装(ME)")]
        public double? ReplaceME { get; set; }
        [Display(Name = "部件拆装(AV)")]
        public double? ReplaceAV { get; set; }
      
        [Display(Name = "气象雷达")]
        public double? Radar { get; set; }
        [Display(Name = "天线拆装")]
        public double? Seal { get; set; }
       
        [Display(Name = "保险")]
        public double? Lockwire { get; set; }
       
        [Display(Name = "量具紧固件")]
        public double? Jingujian { get; set; }
        [Display(Name = "飞行操纵")]
        public double? Caozong { get; set; }
        [Display(Name = "标线综合")]
        public double? Biaoxian { get; set; }
        [Display(Name = "技术资料")]
        public double? Shouce { get; set; }
        [Display(Name = "水平安定面")]
        public double? THS { get; set; }
        [Display(Name = "CVR")]
        public double? CVR { get; set; }
        [Display(Name = "呼叫系统")]
        public double? Call { get; set; }
        [Display(Name = "总分")]
        public double? TotalScore {
            get
            {
                if(Pro=="AV")
                {
                    double result = ((Bishi ?? 0) * 0.3 + (((ReplaceAV ?? 0) + (Radar ?? 0) + (Seal ?? 0) + (Lockwire ?? 0) + (Biaoxian ?? 0) + ((Shouce ?? 0) + (CVR ?? 0) + (Call ?? 0))  / 3) / 6 * 0.7));
                    return Math.Round(result,3);
                }
                else if(Pro=="ME")
                {
                    double result = ((Bishi ?? 0) * 0.3 + ((ReplaceME ?? 0) + (Lockwire ?? 0) + (Jingujian ?? 0) + (Caozong ?? 0) + (Biaoxian ?? 0) + ((Shouce ?? 0) + (THS ?? 0) + (Call ?? 0)) / 3) / 6 * 0.7);

                    return Math.Round(result, 3);
                }
                else
                {
                    return null;
                }
               
            }
        }
    }

    public class EventRank
    {
        public int Rank { get; set; }
        public string EventName { get; set; }
        public string Competitor_Name { get; set; }
        public string Competitor_Staffid { get; set; }
        public string Competitor_Pro { get; set; }
        public string Competitor_Company { get; set; }
        public double? Score { get; set; }
    }

    public class CompanyRank
    {
        [Display(Name = "排名")]
        public int Rank { get; set; }
        [Display(Name = "公司")]
        public string CompanyName { get; set; }
        [Display(Name = "完成数量")]
        public int Count { get; set; }
        [Display(Name = "总分")]        
        public double? Score { get ; set; }
    }

}