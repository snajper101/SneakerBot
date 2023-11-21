using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SneakerBot.AuthLib.Functions.Realeses;


#pragma warning disable CS0618
namespace SneakerBot
{
    public partial class Form1 : Form
    {
        #region Variables
        List<string> model_name_list = new List<string>();
        List<string> day = new List<string>();
        List<string> month = new List<string>();
        List<string> color_way = new List<string>();
        List<Image> images = new List<Image>();
        List<Image> images_with_background = new List<Image>();
        List<API.Websites> website = new List<API.Websites>();

        List<bool> cop_clicked = new List<bool>();
        List<bool> drop_clicked = new List<bool>();
        #endregion

        public Form1()
        {
            InitializeComponent();

            Avaible_realeses_box.DrawMode = DrawMode.OwnerDrawVariable;
            Avaible_realeses_box.MeasureItem += new MeasureItemEventHandler(Avaible_realeses_box_MeasureItem);
            Avaible_realeses_box.DrawItem += new DrawItemEventHandler(Avaible_realeses_box_DrawItem);

            waitForm1.Visible = true;
            LoadItemsWork.RunWorkerAsync();
            gui3.button1.Enabled = false;
        }

        #region Other Functions
        void Check_Update()
        {
            string server_version = HandleVersion.QueryVersion();
            if (server_version != Program.version)
            {
                new UpdateBox(server_version).Show();
            }
        }
        #endregion

        #region Custom Drawing
        private void Avaible_realeses_box_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 250;

            if (e.Index < 0 || DesignMode)
                return;
        }

        private void Avaible_realeses_box_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || DesignMode)
                return;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State ^ DrawItemState.Selected, e.ForeColor, Color.FromArgb(62, 114, 196));

            e.DrawBackground();

            Font model_font = new Font(new FontFamily("Arial"), 15, FontStyle.Regular, GraphicsUnit.Pixel);

            e.Graphics.DrawString(Avaible_realeses_box.Items[e.Index].ToString(), model_font, Brushes.Gray, (e.Bounds.Left + 240 / 2) - ((e.Graphics.MeasureString(Avaible_realeses_box.Items[e.Index].ToString(), model_font).Width) / 2), e.Bounds.Top + 210, StringFormat.GenericDefault);

            Font color_way_font = new Font(new FontFamily("Arial"), 20, FontStyle.Bold, GraphicsUnit.Pixel);

            e.Graphics.DrawString(month[e.Index], e.Font, Brushes.White, e.Bounds.Left + 7, e.Bounds.Top + 7);

            e.Graphics.DrawString(website[e.Index].ToString(), e.Font, Brushes.White, e.Bounds.Left + 160, e.Bounds.Top + 7);

            e.Graphics.DrawString(day[e.Index], e.Font, Brushes.White, e.Bounds.Left + 7, e.Bounds.Top + 30);

            e.Graphics.DrawString(color_way[e.Index], color_way_font, Brushes.White, (e.Bounds.Left + 240 / 2) - ((e.Graphics.MeasureString(color_way[e.Index], color_way_font).Width) / 2), e.Bounds.Top + 225, StringFormat.GenericDefault);

            if (images.Count > 0)
            {
                e.Graphics.DrawImage(images[e.Index], e.Bounds.Left, e.Bounds.Top, 200, 200);
            }
        }
        #endregion

        #region UI Functions
        private void Form1_Load(object sender, EventArgs e)
        {
            gui3.parentForm = this;
            Check_Update();
            foreach (Notification notification in Program.notifications)
            {
                if (notification.Read == false)
                {
                    new Notifications().Show();
                    break;
                }
            }
        }

        private void Show_Notifications_Click(object sender, EventArgs e)
        {
            new Notifications().Show();
        }
        #endregion

        #region Avaible Realeses
        private void Load_Avaible_Products_List()
        {
            bool local = true;
            int local_int = 1;
            try
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--headless");
                ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true;
                IWebDriver webDriver = new ChromeDriver(service, options);

                webDriver.Navigate().GoToUrl("https://www.nike.com/pl/launch/?s=upcoming");
                #region NikeUpcoming
                //Nike upcoming
                while (local == true)
                {
                    try
                    {
                        //Get model name

                        string model_name_xpath = "//*[@id='root']/div/div/div[1]/div/div[3]/div[2]/div/section/figure[" + local_int + "]/div/div/figcaption/div/div/div[1]/h3";

                        new WebDriverWait(webDriver, TimeSpan.FromSeconds(3)).Until(ExpectedConditions.ElementExists((By.XPath(model_name_xpath)))); // Typ lub składowa jest przestarzała

                        IWebElement model_name = webDriver.FindElement(By.XPath(model_name_xpath));

                        model_name_list.Add(model_name.Text);

                        //Get model color way

                        string model_color_way_xpath = "//*[@id='root']/div/div/div[1]/div/div[3]/div[2]/div/section/figure[" + local_int + "]/div/div/figcaption/div/div/div[1]/h6";

                        new WebDriverWait(webDriver, TimeSpan.FromSeconds(3)).Until(ExpectedConditions.ElementExists((By.XPath(model_color_way_xpath))));

                        IWebElement model_color_way = webDriver.FindElement(By.XPath(model_color_way_xpath));

                        color_way.Add(model_color_way.Text);

                        //*[@id="root"]/div/div/div[1]/div/div[3]/div[2]/div/section/figure[3]
                        //Get realese month

                        string model_realese_month_xpath = "//*[@id='root']/div/div/div[1]/div/div[3]/div[2]/div/section/figure[" + local_int + "]/div/div/a/div/div/p[1]";

                        new WebDriverWait(webDriver, TimeSpan.FromSeconds(3)).Until(ExpectedConditions.ElementExists((By.XPath(model_realese_month_xpath))));

                        IWebElement model_realese_month = webDriver.FindElement(By.XPath(model_realese_month_xpath));

                        month.Add(model_realese_month.Text);

                        //Get realese day

                        string model_realese_day_xpath = "//*[@id='root']/div/div/div[1]/div/div[3]/div[2]/div/section/figure[" + local_int + "]/div/div/a/div/div/p[2]";

                        new WebDriverWait(webDriver, TimeSpan.FromSeconds(3)).Until(ExpectedConditions.ElementExists((By.XPath(model_realese_month_xpath))));

                        IWebElement model_realese_day = webDriver.FindElement(By.XPath(model_realese_day_xpath));

                        day.Add(model_realese_day.Text);

                        //Load image
                        Actions action = new Actions(webDriver);
                        action.MoveToElement(webDriver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[3]/div[2]/div/section/figure[" + local_int + "]")));
                        action.Perform();
                        IWebElement model_image = webDriver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[3]/div[2]/div/section/figure[" + local_int + "]/div/div/a/img"));
                        byte[] imageData = API.downloadData(model_image.GetAttribute("src"));
                        MemoryStream stream = new MemoryStream(imageData);
                        Bitmap bitmap = new Bitmap(Image.FromStream(stream));
                        images_with_background.Add(Image.FromStream(stream));
                        for (int j = 220; j < 256; j++)
                        {
                            bitmap.MakeTransparent(Color.FromArgb(j,j,j));
                        }
                        images.Add(bitmap);
                        stream.Close();

                        //Add website
                        website.Add(API.Websites.Nike);

                        string resp = HandleRealese.RealeseInDataBase(model_name.Text, "Nike");

                        cop_clicked.Add(false);
                        drop_clicked.Add(false);

                        if (resp == "false")
                        {
                            HandleRealese.InsertIntoDataBase(model_name.Text, model_color_way.Text, model_realese_day.Text, model_realese_month.Text, "Nike");
                        }

                    }
                    catch
                    {
                        local = false;
                    }
                    local_int++;
                }
                #endregion

                #region Addidas
                /*webDriver.Navigate().GoToUrl("https://www.adidas.pl/yeezy");

                local = true;
                local_int = 1;

                while (local)
                {
                    try
                    {

                        Actions actions = new Actions(webDriver);
                        actions.MoveToElement(webDriver.FindElement(By.XPath("//*[@id='app']/div/div[1]/div/div[" + local_int + "]")));
                        actions.Perform();
                        bool local1 = true;
                        int temp_int = 1;
                        while (local1)
                        {
                            try
                            {
                                IWebElement model_name = webDriver.FindElement(By.XPath("//*[@id='app']/div/div[1]/div/div[" + local_int + "]/div[" + temp_int + "]/div[2]/h1"));

                                IWebElement model_color_way = webDriver.FindElement(By.XPath("//*[@id='app']/div/div[1]/div/div[" + local_int + "]/div[" + temp_int + "]/div[2]/p[1]"));

                                color_way.Add(model_color_way.Text);

                                IWebElement realese_date = webDriver.FindElement(By.XPath("//*[@id='app']/div/div[1]/div/div[" + local_int + "]/div[" + temp_int + "]/div[2]/p[3]"));

                                month.Add(realese_date.Text);
                                day.Add("");

                                website.Add(API.Websites.Addidas);

                                IWebElement model_image = webDriver.FindElement(By.XPath("//*[@id='app']/div/div[1]/div/div[" + local_int + "]/div[" + temp_int + "]/div[1]/div/ul/li[2]/img"));
                                byte[] imageData = API.downloadData(model_image.GetAttribute("src"));
                                MemoryStream stream = new MemoryStream(imageData);
                                Bitmap bitmap = new Bitmap(Image.FromStream(stream));
                                bitmap.MakeTransparent(Color.FromArgb(236, 236, 226));
                                images.Add(bitmap);
                                stream.Close();

                                Avaible_realeses_box.Items.Add(model_name.Text);
                            }
                            catch
                            {
                                local1 = false;
                            }
                            temp_int++;
                        }
                    }
                    catch
                    {
                        local = false;
                    }
                    local_int++;
                }

                Main.t.Abort();*/

                #endregion
                webDriver.Quit();
            }
            catch
            {
                Application.Exit();
            }
        }

        private void LoadItemsWork_DoWork(object sender, DoWorkEventArgs e)
        {
            Load_Avaible_Products_List();
        }

        private void LoadItemsWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach(string name in model_name_list)
            {
                Avaible_realeses_box.Items.Add(name);
            }
            Avaible_realeses_box.Visible = true;
            waitForm1.Visible = false;
            Avaible_realeses_box.Refresh();
        }
  

        private void Avaible_realeses_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CopBtn.Enabled == false)
            {
                CopBtn.Enabled = true;
            }
            else
            {
                CopBtn.Enabled = !cop_clicked[Avaible_realeses_box.SelectedIndex];
            }
            if (DropBtn.Enabled == false)
            {
                DropBtn.Enabled = true;
            }
            else
            {
                DropBtn.Enabled = !drop_clicked[Avaible_realeses_box.SelectedIndex];
            }
            DetailLbl.Visible = true;
            DetailLbl.Text = DetailLbl.Text.Replace("Name",model_name_list[Avaible_realeses_box.SelectedIndex]).Replace("Color", color_way[Avaible_realeses_box.SelectedIndex]);
            pictureBox1.Image = images_with_background[Avaible_realeses_box.SelectedIndex];
            Update_Realese_Profit_Detailis();
        }

        void Update_Realese_Profit_Detailis()
        {
            string resp1;
            float cop_votes = HandleRealese.GetCopVotes(model_name_list[Avaible_realeses_box.SelectedIndex], website[Avaible_realeses_box.SelectedIndex].ToString(), out resp1);

            string resp2;
            float drop_votes = HandleRealese.GetDropVotes(model_name_list[Avaible_realeses_box.SelectedIndex], website[Avaible_realeses_box.SelectedIndex].ToString(), out resp2);



            if (resp1 != "error" && resp2 != "error" && cop_votes != 0 && cop_votes != 0)
            {
                float profitability = cop_votes / drop_votes;

                if (profitability < 1)
                {
                    ResellStatus.Text = "Under Retail";
                    ResellStatus.ForeColor = Color.FromArgb(192, 57, 43);
                    float total_count = cop_votes + drop_votes;

                    propabilyty_text.Text = propabilyty_text.Text.Replace("--", (Math.Ceiling(total_count * (float)0.099)).ToString());
                    propabilyty_text.Visible = true;
                }
                else if (profitability > 1 && profitability < 3)
                {
                    ResellStatus.Text = "Near Retail";
                    ResellStatus.ForeColor = Color.FromArgb(241, 196, 15);
                    float total_count = cop_votes + drop_votes;

                    propabilyty_text.Text = propabilyty_text.Text.Replace("--", (Math.Ceiling(total_count * (float)0.099)).ToString());
                    propabilyty_text.Visible = true;
                }
                else if (profitability >= 3)
                {
                    ResellStatus.Text = "Over Retail";
                    ResellStatus.ForeColor = Color.FromArgb(46, 204, 113);
                    float total_count = cop_votes + drop_votes;

                    propabilyty_text.Text = propabilyty_text.Text.Replace("--", (Math.Ceiling(total_count * (float)0.099)).ToString());
                    propabilyty_text.Visible = true;
                }
                else
                {
                    ResellStatus.Text = "No Data";
                    ResellStatus.ForeColor = Color.FromArgb(45, 47, 49);
                    propabilyty_text.Visible = false;
                }

            }
            else
            {
                ResellStatus.Text = "No Data";
                ResellStatus.ForeColor = Color.FromArgb(45, 47, 49);
                propabilyty_text.Visible = false;
            }
        }

        private void DropBtn_Click(object sender, EventArgs e)
        {
            if (!drop_clicked[Avaible_realeses_box.SelectedIndex])
            {
                HandleRealese.AddDrop(model_name_list[Avaible_realeses_box.SelectedIndex], website[Avaible_realeses_box.SelectedIndex].ToString());
                drop_clicked[Avaible_realeses_box.SelectedIndex] = true;
                Update_Realese_Profit_Detailis();
                DropBtn.Enabled = !drop_clicked[Avaible_realeses_box.SelectedIndex];
            }
        }

        private void CopBtn_Click(object sender, EventArgs e)
        {
            if (!cop_clicked[Avaible_realeses_box.SelectedIndex])
            {
                HandleRealese.AddCop(model_name_list[Avaible_realeses_box.SelectedIndex], website[Avaible_realeses_box.SelectedIndex].ToString());
                cop_clicked[Avaible_realeses_box.SelectedIndex] = true;
                Update_Realese_Profit_Detailis();
                CopBtn.Enabled = !cop_clicked[Avaible_realeses_box.SelectedIndex];
            }
        }
        #endregion
    }
}
#pragma warning restore CS0618
