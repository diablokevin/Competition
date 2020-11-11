using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Competition.EF.Models;

namespace Competition.Web.Models
{
    public class ScoreDetailViewModel
    {

        public Score Score { get; set; } = new Score();
        public string SetName { get; set; } 
        public List<ScoreDetail> ScoreDetails { get; set; } = new List<ScoreDetail>();
    }
}