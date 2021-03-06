﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using Competition.EF.Models;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using System.Configuration;

namespace Competition.Callout
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Competition.EF.Models.CompetitionDbContext dbContext = new Competition.EF.Models.CompetitionDbContext();
        public Form1()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
           
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.Schedules.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.Schedules.OrderBy(s=>s.PlanBeginTime).ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            
        }
        Form2 form2 = new Form2();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            form2.Show();
            string connsring = System.Configuration.ConfigurationManager.ConnectionStrings["CompetitionDbContext"].ConnectionString;
            Edit_ServeIP.EditValue = connsring.Split(';')[0].Split('=')[1];
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btn_Register_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int rowhandle = gridView1.FocusedRowHandle;
            if(rowhandle!=-1)
            {
                int scheduleId = (int)gridView1.GetRowCellValue(rowhandle, "Id");
                Schedule schedule = dbContext.Schedules.Find(scheduleId);
                schedule.Status = SchedulStatus.Registered;
                dbContext.SaveChanges();
                gridView1.RefreshRow(rowhandle);
            }
           
           
            
        }

        private void btn_Register_Cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int rowhandle = gridView1.FocusedRowHandle;
            if (rowhandle != -1)
            {
              

                int scheduleId = (int)gridView1.GetRowCellValue(rowhandle, "Id");
                Schedule schedule = dbContext.Schedules.Find(scheduleId);
                if (schedule.Status == SchedulStatus.Registered)
                {
                    schedule.Status = SchedulStatus.Waiting;
                    dbContext.SaveChanges();
                    gridView1.RefreshRow(rowhandle);
                }
                else
                {
                    MessageBox.Show("此选手未签到!");
                }
            }
        }

        private void btn_Callout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int rowhandle = gridView1.FocusedRowHandle;
            if (rowhandle != -1)
            {
                

                int scheduleId = (int)gridView1.GetRowCellValue(rowhandle, "Id");
                Schedule schedule = dbContext.Schedules.Find(scheduleId);
                if (schedule.Status == SchedulStatus.Registered)
                {
                    schedule.Status = SchedulStatus.Calling;
                    dbContext.SaveChanges();
                    gridView1.RefreshRow(rowhandle);
                }
                else
                {
                    MessageBox.Show("此选手未签到!");
                }
            }
        }

        private void btn_Callout_Cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int rowhandle = gridView1.FocusedRowHandle;
            if (rowhandle != -1)
            {
              

                int scheduleId = (int)gridView1.GetRowCellValue(rowhandle, "Id");
                Schedule schedule = dbContext.Schedules.Find(scheduleId);
                if (schedule.Status == SchedulStatus.Calling)
                {
                    schedule.Status = SchedulStatus.Registered;
                    dbContext.SaveChanges();
                    gridView1.RefreshRow(rowhandle);
                }
                else
                {
                    MessageBox.Show("此选手未被呼叫!");
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string racenum = txt_RaceNum.Text;
            Schedule next = dbContext.Schedules.Where(s =>s.Status==SchedulStatus.Waiting&&s.Competitor.Race_num == racenum).OrderBy(s => s.PlanBeginTime).FirstOrDefault();
            if(next!=null)
            {
                next.Status = SchedulStatus.Registered;
                lb_eventname.Text = next.Event.Name;
                
                lb_racenum.Text = next.Competitor.Race_num;
                lb_name.Text = next.Competitor.Name;
                lb_company.Text = next.Competitor.Company.Name;
                lb_begin.Text = next.PlanBeginTime.ToString();
                form2.lb_eventname.Text = next.Event.Name;
                form2.lb_racenum.Text = next.Competitor.Race_num;
                form2.lb_name.Text = next.Competitor.Name;
                form2.lb_company.Text = next.Competitor.Company.Name;
                form2.lb_begin.Text = next.PlanBeginTime.ToString();
                txt_RaceNum.Text = "";
                dbContext.SaveChanges();
                gridView1.RefreshData();
            }
            else
            {
                MessageBox.Show("无此选手的赛程信息!");
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeScheduleStatus(SchedulStatus.Waiting);
        }

        private void ChangeScheduleStatus(SchedulStatus status)
        {
            int rowhandle = gridView1.FocusedRowHandle;
            if (rowhandle != -1)
            {

                int scheduleId = (int)gridView1.GetRowCellValue(rowhandle, "Id");
                Schedule schedule = dbContext.Schedules.Find(scheduleId);

                schedule.Status = status;
                dbContext.SaveChanges();
                gridView1.RefreshRow(rowhandle);

            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeScheduleStatus(SchedulStatus.Registered);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeScheduleStatus(SchedulStatus.Calling);
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeScheduleStatus(SchedulStatus.Inprogress);
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeScheduleStatus(SchedulStatus.Complete);
        }

        private void txt_RaceNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                simpleButton1_Click(sender, e);
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string IP = Edit_ServeIP.EditValue.ToString();
           
            string conn = "Data Source="+IP+";Initial Catalog=CompetitonDbContext;Persist Security Info=True;User ID=sa;Password=sa@1234";
         

            //WinForm教程（一）App.config等配置文件 https://blog.csdn.net/yangwenxue1989/article/details/81707619
            Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.ConnectionStrings.ConnectionStrings["CompetitionDbContext"].ConnectionString = conn;//修改 


            config.Save(ConfigurationSaveMode.Modified);//只有加保存功能,*.vshost.exe.Config才会作改变

            ConfigurationManager.RefreshSection("ConnectionStrings");
        }
    }
}
