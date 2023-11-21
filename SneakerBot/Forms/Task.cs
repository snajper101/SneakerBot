using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SneakerBot.AuthLib.Types;
namespace SneakerBot
{
    public partial class Task : Form
    {
        public List<SneakerBot.AuthLib.Types.Task> tasks = new List<AuthLib.Types.Task>();
        public List<IWebDriver> tasks_drivers = new List<IWebDriver>();

        public List<Label> id_lbl_list = new List<Label>();
        public List<Label> name_lbl_list = new List<Label>();
        public List<Label> website_lbl_list = new List<Label>();
        public List<Label> link_lbl_list = new List<Label>();
        public List<Label> profile_lbl_list = new List<Label>();
        public List<Label> product_lbl_list = new List<Label>();
        public List<Label> status_lbl_list = new List<Label>();
        public List<Label> size_lbl_list = new List<Label>();
        public List<PictureBox> status_image_list = new List<PictureBox>();
        public List<Thread> task_thread = new List<Thread>();
        public List<Button> start_btn_list = new List<Button>();
        public List<Button> delate_btn_list = new List<Button>();

        int last_index = 0;
        public Task()
        {
            InitializeComponent();
            gui1.parentForm = this;
            gui1.button2.Enabled = false;
            tasks = Program.tasks;
            foreach (SneakerBot.AuthLib.Types.Task task in tasks)
            {
                IWebDriver webDriver = null;
                tasks_drivers.Add(webDriver);
                Load_Task_UI();
                if (task.Status != "Idle")
                {
                    int i = tasks.Count - 1;
                    start_btn_list[i].Image = SneakerBot.Properties.Resources.pause_20px;
                    last_index = i;
                    task_thread.Add(new Thread(new ThreadStart(startTask)));
                    task_thread[task_thread.Count - 1].Start();
                }
            }
        }
        int selected_page = 1;

        public void Add_New_Task(string _task_Name, string _task_website, string _task_link, string size, bool user_need_to_confirm, Account account, List<string> Tags, BillingProfile billingProfile, Proxy proxy)
        {
            int last_index_in_db = HandleTasks.MaxId();

            string tags_name = "";
            foreach (string local in Tags)
            {
                tags_name += local + ",";
            }

            HandleTasks.InsertTask(new SneakerBot.AuthLib.Types.Task(_task_Name, _task_website, Tags.Count == 0 ? _task_link : tags_name, account, "Getting", "Idle", size, last_index_in_db+1, billingProfile, proxy));
            tasks.Add(new SneakerBot.AuthLib.Types.Task(_task_Name, _task_website, Tags.Count == 0 ? _task_link : tags_name, account, "Getting", "Idle", size, last_index_in_db+1, billingProfile,proxy));
            Load_Task_UI();
            IWebDriver webDriver = null;
            tasks_drivers.Add(webDriver);
        }

        void startTask()
        {
            int i = last_index;
            if (this.status_lbl_list[i].InvokeRequired)
            {
                this.status_lbl_list[i].BeginInvoke((MethodInvoker)delegate () { tasks[i].Status = "Collecting data"; status_lbl_list[i].Text = tasks[i].Status; status_lbl_list[i].ForeColor = Color.FromArgb(255, 255, 255); status_image_list[i].Image = Properties.Resources.filled_circle_20px_white; });
                HandleTasks.EditStatus(tasks[i].Status, tasks[i], tasks[i].ID);
            }
            else
            {
                status_lbl_list[i].ForeColor = Color.FromArgb(255, 255, 255);
                tasks[i].Status = "Collecting data";
                status_lbl_list[i].Text = tasks[i].Status;
                status_image_list[i].Image = Properties.Resources.filled_circle_20px_white;
                HandleTasks.EditStatus(tasks[i].Status, tasks[i],tasks[i].ID);
            }


            if (tasks[i].Website.ToLower() == "nike")
            {
                ChromeOptions options = new ChromeOptions();
                //options.AddArgument("--headless");
                options.AddUserProfilePreference("profile.default_content_setting_values.images", 2);
                ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true;

                IWebDriver driver = new ChromeDriver(service, options);

                driver.Navigate().GoToUrl(tasks[i].Link);

                tasks_drivers[i] = driver;

                NikeAPI.NikeCheckOut(i, this, tasks[i], driver);

            }
            else if (tasks[i].Website.ToLower() == "Supreme")
            {
                SupremeAPI.SupremeCheckOut(i, this, tasks[i]);
            }
        }

        
        void Load_Task_UI()
        {
            if (id_lbl_list.Count < 1)
            {
                for (int i = 0; i < 18;i++)
                {
                    #region DrawString
                    //Create id lbl
                    Label label = new Label();
                    this.TaskPanel.Controls.Add(label);
                    label.TextAlign = ContentAlignment.MiddleLeft;
                    label.AutoSize = true;
                    label.Left = 6;
                    label.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
                    label.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                    label.Top = 50 + i * 30;
                    id_lbl_list.Add(label);

                    //Create task name lbl
                    Label label1 = new Label();
                    this.TaskPanel.Controls.Add(label1);
                    label1.TextAlign = ContentAlignment.MiddleLeft;
                    label1.AutoSize = true;
                    label1.Left = 57;
                    label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
                    label1.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                    label1.Top = 50 + i * 30;
                    name_lbl_list.Add(label1);

                    //Create wabsite label 
                    Label label2 = new Label();
                    this.TaskPanel.Controls.Add(label2);
                    label2.TextAlign = ContentAlignment.MiddleLeft;
                    label2.AutoSize = true;
                    label2.Left = 148;
                    label2.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
                    label2.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                    label2.Top = 50 + i * 30;
                    website_lbl_list.Add(label2);

                    //Create link label 288
                    Label label3 = new Label();
                    this.TaskPanel.Controls.Add(label3);
                    label3.TextAlign = ContentAlignment.MiddleLeft;
                    label3.AutoSize = false;
                    label3.Left = 258;
                    label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
                    label3.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                    label3.Top = 50 + i * 30;
                    label3.Size = new System.Drawing.Size(264, 33);
                    label3.AutoEllipsis = true;
                    link_lbl_list.Add(label3);

                    //Create profile label
                    Label label4 = new Label();
                    this.TaskPanel.Controls.Add(label4);
                    label4.TextAlign = ContentAlignment.MiddleLeft;
                    label4.AutoSize = true;
                    label4.Left = 542;
                    label4.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
                    label4.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                    label4.Top = 50 + i * 30;
                    profile_lbl_list.Add(label4);

                    //Create product label 661
                    Label label5 = new Label();
                    this.TaskPanel.Controls.Add(label5);
                    label5.TextAlign = ContentAlignment.MiddleLeft;
                    label5.AutoSize = true;
                    label5.Left = 661;
                    label5.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
                    label5.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                    label5.Top = 50 + i * 30;
                    product_lbl_list.Add(label5);


                    //Create product size
                    Label label6 = new Label();
                    this.TaskPanel.Controls.Add(label6);
                    label6.TextAlign = ContentAlignment.MiddleLeft;
                    label6.AutoSize = true;
                    label6.Left = 787;
                    label6.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
                    label6.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                    label6.Top = 50 + i * 30;
                    size_lbl_list.Add(label6);

                    //Create status lbl 
                    Label label7 = new Label();
                    this.TaskPanel.Controls.Add(label7);
                    label7.TextAlign = ContentAlignment.MiddleLeft;
                    label7.AutoSize = true;
                    label7.Left = 925;
                    label7.Font = new Font("Segoe UI Black", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
                    label7.ForeColor = Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
                    label7.Top = 50 + i * 30;
                    status_lbl_list.Add(label7);

                    PictureBox image = new PictureBox();
                    this.TaskPanel.Controls.Add(image);
                    image.Image = Properties.Resources.filled_circle_20px;
                    image.Top = (50 + i * 30) + 5;
                    image.Left = 900;
                    status_image_list.Add(image);

                    Button button = new Button();
                    this.TaskPanel.Controls.Add(button);
                    button.FlatAppearance.BorderSize = 0;
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    button.Image = SneakerBot.Properties.Resources.play_20px;
                    button.Top = 50 + i * 30;
                    button.Left = 1070;
                    button.ImageAlign = ContentAlignment.MiddleCenter;
                    button.Size = new System.Drawing.Size(30, 30);
                    button.Click += play_pause;
                    button.Visible = false;
                    start_btn_list.Add(button);

                    Button button1 = new Button();
                    this.TaskPanel.Controls.Add(button1);
                    button1.FlatAppearance.BorderSize = 0;
                    button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    button1.Image = SneakerBot.Properties.Resources.delete_20px;
                    button1.Top = 50 + i * 30;
                    button1.Left = 1110;
                    button1.ImageAlign = ContentAlignment.MiddleCenter;
                    button1.Size = new System.Drawing.Size(30, 30);
                    button1.Click += delate_btn;
                    button1.Visible = false;
                    delate_btn_list.Add(button1);
                    #endregion
                }
            }
            else
            {
                for (int i = 0;i < 18; i++)
                {
                    id_lbl_list[i].Visible = false;
                    id_lbl_list[i].Update();
                    name_lbl_list[i].Visible = false;
                    name_lbl_list[i].Update();
                    website_lbl_list[i].Visible = false;
                    website_lbl_list[i].Update();
                    link_lbl_list[i].Visible = false;
                    link_lbl_list[i].Update();
                    profile_lbl_list[i].Visible = false;
                    profile_lbl_list[i].Update();
                    product_lbl_list[i].Visible = false;
                    product_lbl_list[i].Update();
                    status_lbl_list[i].Visible = false;
                    status_lbl_list[i].Update();
                    size_lbl_list[i].Visible = false;
                    size_lbl_list[i].Update();
                    status_image_list[i].Visible = false;
                    status_image_list[i].Update();
                    start_btn_list[i].Visible = false;
                    start_btn_list[i].Update();
                    delate_btn_list[i].Visible = false;
                    delate_btn_list[i].Update();
                }
            }

            if (tasks.Count > 0)
            {
                for (int i = (selected_page - 1) * 18; i < tasks.Count && i < ((selected_page)*18); i++)
                {
                    int c = i - ((selected_page - 1) * 18);

                    //Update id

                    if (i < tasks.Count)
                    {
                        //Update id
                        id_lbl_list[c].Visible = true;
                        id_lbl_list[c].Text = (i + 1).ToString();
                        id_lbl_list[c].Update();

                        //Update task name
                        name_lbl_list[c].Visible = true;
                        name_lbl_list[c].Text = tasks[i].Name;
                        name_lbl_list[c].Update();

                        //Update Website
                        website_lbl_list[c].Visible = true;
                        website_lbl_list[c].Text = tasks[i].Website;
                        website_lbl_list[c].Update();

                        //Update link
                        link_lbl_list[c].Visible = true;
                        link_lbl_list[c].Text = tasks[i].Link.Replace("https://www.nike.com/pl/", "").Replace("t/","").Replace("launch/","");
                        link_lbl_list[c].Update();

                        //Update profile
                        profile_lbl_list[c].Visible = true;
                        profile_lbl_list[c].Text = "ERROR";
                        profile_lbl_list[c].Update();

                        //Update Product
                        product_lbl_list[c].Visible = true;
                        product_lbl_list[c].Text = tasks[i].Product;
                        product_lbl_list[c].Update();

                        //Size product
                        size_lbl_list[c].Visible = true;
                        size_lbl_list[c].Text = tasks[i].Size + " EU";
                        size_lbl_list[c].Update();

                        //Update Status
                        status_lbl_list[c].Visible = true;
                        status_lbl_list[c].Text = tasks[i].Status;
                        status_lbl_list[c].Update();
                        //Update
                        start_btn_list[i].Visible = true;
                        start_btn_list[i].Update();
                        delate_btn_list[i].Visible = true;
                        delate_btn_list[i].Update();
                    }
                }
            }
        }

        private void play_pause(object sender, EventArgs e)
        {
            int i = start_btn_list.IndexOf((Button)sender);

            if (status_lbl_list[i].Text == "Idle")
            {
                start_btn_list[i].Image = SneakerBot.Properties.Resources.pause_20px;
                last_index = i;
                task_thread.Add(new Thread(new ThreadStart(startTask)));
                task_thread[task_thread.Count - 1].Start();
            }
            else
            { 
                status_lbl_list[i].ForeColor = Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
                status_lbl_list[i].Text = "Idle";
                status_image_list[i].Image = Properties.Resources.filled_circle_20px;
                status_lbl_list[i].Update();
                start_btn_list[i].Image = SneakerBot.Properties.Resources.play_20px;
                start_btn_list[i].Update();
                tasks_drivers[i].Close();
                task_thread[i].Abort();
            }
        }

        private void delate_btn(object sender, EventArgs e)
        {
            int i = delate_btn_list.IndexOf((Button)sender);

            tasks_drivers[i].Close();
            tasks_drivers.RemoveAt(i);

            HandleTasks.DeleteTask(tasks[i].ID);

            tasks.RemoveAt(i);

            Load_Task_UI();
        }

        private void NextPageBtn_Click(object sender, EventArgs e)
        {
            if (selected_page < Math.Ceiling((float)tasks.Count / 18F))
            {
                selected_page++;
            }
            Load_Task_UI();
        }

        private void PreviousPageBtn_Click(object sender, EventArgs e)
        {
            if (selected_page > 1)
            {
                selected_page--;
            }
            Load_Task_UI();
        }

        private void Add_Task_Click(object sender, EventArgs e)
        {
            new Add_Task(this).Show();
        }
    }
}
