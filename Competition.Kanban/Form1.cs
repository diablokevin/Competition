using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Competition.EF.Models;
using Competition.Kanban.Model;
namespace Competition.Kanban
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        CompetitionDbContext db = new CompetitionDbContext();
        public Form1()
        {
            InitializeComponent();
        }
        List<EventKanbanViewModel> kanban;
        private void Form1_Load(object sender, EventArgs e)
        {
            kanban = GetEventKanbanData(db);
            gridControl1.DataSource = kanban;

        }

        private static List<EventKanbanViewModel> GetEventKanbanData(CompetitionDbContext db)
        {
            List<EventKanbanViewModel> kanban = new List<EventKanbanViewModel>();
           
            int id = 0;
            foreach (Event item in db.Events.ToList())
            {

                EventKanbanViewModel kanbanitem = new EventKanbanViewModel();
                kanbanitem.Id = id;
                kanbanitem.EventId = item.Id;
                kanbanitem.Event = item;
                kanbanitem.Name = item.Name;
                kanbanitem.Schedules_Registered = db.Schedules.Where(s => s.EventId == kanbanitem.EventId && s.Status == SchedulStatus.Registered).OrderBy(o => o.PlanBeginTime).ToList();
                kanbanitem.Schedules_Waiting = db.Schedules.Where(s => s.EventId == kanbanitem.EventId && s.Status == SchedulStatus.Waiting).OrderBy(o => o.PlanBeginTime).Take(4).ToList();
                kanbanitem.Schedules_Calling = db.Schedules.Where(s => s.EventId == kanbanitem.EventId && s.Status == SchedulStatus.Calling).OrderBy(o => o.PlanBeginTime).ToList();
                kanbanitem.Schedules_InProgress = db.Schedules.Where(s => s.EventId == kanbanitem.EventId && s.Status == SchedulStatus.Inprogress).OrderBy(o => o.PlanBeginTime).ToList();

                kanban.Add(kanbanitem);
                id++;
            }

            return kanban;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kanban = GetEventKanbanData(db);
            gridControl1.DataSource = kanban;
            gridControl1.RefreshDataSource();            
            KanbanView.RefreshData();
            LastRefressTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }


    }
}
