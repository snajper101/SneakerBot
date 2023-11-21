using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakerBot
{
    public class NikeAPI
    {
        public static void NikeCheckOut(int i, Task task, SneakerBot.AuthLib.Types.Task current_task, IWebDriver driver)
        {
            bool up_coming = true;

            try
            {
                driver.FindElement(By.ClassName("test-available-date"));

            }
            catch
            {
                up_coming = false;
            }

            if (up_coming == true)
            {
                string date_string = driver.FindElement(By.ClassName("test-available-date")).Text;

                string[] date_string_d = date_string.Split(' ');

                int day = 0;
                int month = 0;
                string time = "";
                string form = "0";

                foreach (string local in date_string_d)
                {
                    if ((local.Contains(".") || local.Contains("/")) && API.containsDigit(local))
                    {
                        if (local.Contains("."))
                        {
                            string[] local1 = local.Split('.');
                            day = Convert.ToInt32(local1[0]);
                            month = Convert.ToInt32(local1[1]);
                        }
                        else if (local.Contains("/"))
                        {
                            string[] local1 = local.Split('/');
                            month = Convert.ToInt32(local1[0]);
                            day = Convert.ToInt32(local1[1]);
                        }
                    }
                    else if (local.Contains(':'))
                    {
                        time = local;
                    }
                    else if (local == "AM")
                    {
                        form = "AM";
                    }
                    else if (local == "PM")
                    {
                        form = "PM";
                    }
                }

                string[] time2 = time.Split(':');

                DateTime realese_time;
                DateTime realese_time2;
                realese_time = new DateTime(DateTime.Now.Year, month, day,(form == "0" ? Convert.ToInt32(time2[0]) : form == "AM" ? Convert.ToInt32(time2[0]) : (Convert.ToInt32(time2[0]) + 12)), 0, 0);
                realese_time2 = new DateTime(DateTime.Now.Year, month, day, (form == "0" ? Convert.ToInt32(time2[0]) : form == "AM" ? Convert.ToInt32(time2[0]) : (Convert.ToInt32(time2[0]) + 12)) - 1, 59, 45);

                driver.Close();

                TimeSpan timeSpan = realese_time.Subtract(realese_time2);

                if (task.status_lbl_list[i].InvokeRequired)
                {
                    task.status_lbl_list[i].BeginInvoke((MethodInvoker)delegate ()
                    {
                        task.status_lbl_list[i].ForeColor = Color.FromArgb(45, 183, 45);
                        current_task.Status = "Waiting To Realese";
                        task.status_lbl_list[i].Text = current_task.Status;
                        task.status_image_list[i].Image = Properties.Resources.filled_circle_20px_green;
                        HandleTasks.EditStatus(current_task.Status, current_task, current_task.ID);
                    });
                }
                else
                {
                    task.status_lbl_list[i].ForeColor = Color.FromArgb(45, 183, 45);
                    current_task.Status = "Waiting To Realese";
                    task.status_lbl_list[i].Text = current_task.Status;
                    task.status_image_list[i].Image = Properties.Resources.filled_circle_20px_green;
                    HandleTasks.EditStatus(current_task.Status, current_task, current_task.ID);
                }

                API.Wait((int)timeSpan.TotalMilliseconds);

                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--headless");
                options.AddUserProfilePreference("profile.default_content_setting_values.images", 2);
                ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true;

                driver = new ChromeDriver(service,options);
                driver.Navigate().GoToUrl(current_task.Link);

                driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/header/div[1]/section/ul/li[1]/button")).Click();

                timeSpan = realese_time.Subtract(realese_time);
                API.Wait((int)timeSpan.TotalMilliseconds);
                MessageBox.Show(DateTime.Now.ToString());

                //Select Size

                int whileindex = 1;
                bool _break = false;

                while (!_break)
                {
                    try
                    {
                        IWebElement element = driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[3]/div[2]/div/section[1]/div[2]/aside/div/div[2]/div/div[2]/ul/li[" + whileindex + "]/button"));
                        if (element.Text == "EU " + current_task.Size && element.Enabled == true)
                        {
                            element.Click();
                            _break = true;
                        }
                        whileindex++;
                    }
                    catch
                    {
                        _break = true;
                    }
                }


                driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[3]/div[2]/div/section[1]/div[2]/aside/div/div[2]/div/button")).Click();

                driver.FindElement(By.XPath("//*[@id='checkout - sections']/div[3]/div/div/div[5]/button")).Click();

            }
            else
            {
                bool inStock = true;
                string pay_btn_string = "";
                try
                {
                    try
                    {
                        driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[3]/div[2]/div/section[1]/div[2]/aside/div/div[2]/div/div[2]/div/button"));
                        pay_btn_string = "//*[@id='root']/div/div/div[1]/div/div[3]/div[2]/div/section[1]/div[2]/aside/div/div[2]/div/div[2]/div/button";
                    }
                    catch
                    {
                        driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[3]/div[2]/div/section[1]/div[2]/aside/div/div[2]/div/button"));
                        pay_btn_string = "//*[@id='root']/div/div/div[1]/div/div[3]/div[2]/div/section[1]/div[2]/aside/div/div[2]/div/button";
                    }
                    //*[@id="root"]/div/div/div[1]/div/div[3]/div[2]/div/section[1]/div[2]/aside/div/div[2]/div/button
                    //*[@id="root"]/div/div/div[1]/div/div[3]/div[2]/div/section[1]/div[2]/aside/div/div[2]/div/button

                }
                catch
                {
                    inStock = false;
                    if (task.status_lbl_list[i].InvokeRequired)
                    {
                        task.status_lbl_list[i].BeginInvoke((MethodInvoker)delegate ()
                        {
                            task.status_lbl_list[i].ForeColor = Color.Red;
                            current_task.Status = "Product unvaible";
                            task.status_lbl_list[i].Text = current_task.Status;
                            task.status_image_list[i].Image = Properties.Resources.filled_circle_20px_red;
                        });
                        HandleTasks.EditStatus(current_task.Status, current_task, current_task.ID);
                    }
                    else
                    {
                        task.status_lbl_list[i].ForeColor = Color.Red;
                        current_task.Status = "Product unvaible";
                        task.status_lbl_list[i].Text = current_task.Status;
                        task.status_image_list[i].Image = Properties.Resources.filled_circle_20px_red;
                        HandleTasks.EditStatus(current_task.Status, current_task, current_task.ID);
                    }
                    driver.Close();
                }

                if (inStock == true)
                {
                    int whileindex = 1;
                    bool _break = false;
                    IWebElement add_to_basket = driver.FindElement(By.XPath(pay_btn_string));
                    Actions action = new Actions(driver);
                    action.MoveToElement(add_to_basket);
                    action.Perform();

                    while (!_break)
                    {
                        try
                        {
                            IWebElement element = driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[3]/div[2]/div/section[1]/div[2]/aside/div/div[2]/div/div[2]/ul/li[" + whileindex + "]/button"));
                            if (element.Text == "EU " + current_task.Size && element.Enabled == true)
                            {
                                element.Click();
                                _break = true;
                            }
                            whileindex++;
                        }
                        catch
                        {
                            _break = true;
                        }
                    }

                    if (task.status_lbl_list[i].InvokeRequired)
                    {
                        task.status_lbl_list[i].BeginInvoke((MethodInvoker)delegate ()
                        {
                            task.status_lbl_list[i].ForeColor = Color.FromArgb(45, 183, 45);
                            current_task.Status = "Checking Out";
                            task.status_lbl_list[i].Text = current_task.Status;
                            task.status_image_list[i].Image = Properties.Resources.filled_circle_20px_green;
                            HandleTasks.EditStatus(current_task.Status, current_task, current_task.ID);
                        });
                    }
                    else
                    {
                        task.status_lbl_list[i].ForeColor = Color.FromArgb(45, 183, 45);
                        current_task.Status = "Checking Out";
                        task.status_lbl_list[i].Text = current_task.Status;
                        task.status_image_list[i].Image = Properties.Resources.filled_circle_20px_green;
                        HandleTasks.EditStatus(current_task.Status, current_task, current_task.ID);
                    }

                    bool avaible_size = false;
                    add_to_basket.Click();

                    try
                    {
                        IWebElement element = driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[3]/div[2]/div/section[1]/div[2]/aside/div/div[2]/div/div[2]/p/text()[1]"));
                    }
                    catch
                    {
                        avaible_size = true;
                    }

                    if (avaible_size == true)
                    {
                        var koszyk = new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='root']/div/div/div[2]/div/div/div/div/div[3]/button[2]")));
                        koszyk.Click();

                        if (current_task.Account == null)
                        {
                            driver.FindElement(By.Id("qa-guest-checkout")).Click();


                        }
                        else
                        {
                            driver.FindElement(By.XPath("/html/body/div[1]/div/div[3]/div[2]/div/div/div[1]/div[1]/div/div[1]/form/div[2]/input")).SendKeys(current_task.Account.Email);
                            driver.FindElement(By.XPath("/html/body/div[1]/div/div[3]/div[2]/div/div/div[1]/div[1]/div/div[1]/form/div[3]/input")).SendKeys(current_task.Account.Password);
                            driver.FindElement(By.XPath("/html/body/div[1]/div/div[3]/div[2]/div/div/div[1]/div[1]/div/div[1]/form/div[7]/input")).Click();
                            bool succes = false;
                            try
                            {
                                IWebElement element = driver.FindElement(By.XPath("/html/body/div[1]/div/div[3]/div[2]/div/div/div[1]/div[1]/div/div[1]/form/div[1]/ul/li/text()"));
                            }
                            catch
                            {
                                succes = true;
                            }

                            if (succes == true)
                            {
                                var buy = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='place-order']/div/button")));
                                buy.Click();
                                succes = false;
                                try
                                {
                                    IWebElement element = driver.FindElement(By.XPath("//*[@id='checkout - wrapper']/div/div/div/div/div/div/div/div/div/p/span"));
                                }
                                catch
                                {
                                    succes = true;
                                }
                                if (succes == true)
                                {
                                    if (task.status_lbl_list[i].InvokeRequired)
                                    {
                                        task.status_lbl_list[i].BeginInvoke((MethodInvoker)delegate ()
                                        {
                                            current_task.Status = "Purchased";
                                            task.status_lbl_list[i].Text = current_task.Status;
                                            task.status_image_list[i].Image = Properties.Resources.filled_circle_20px_red;
                                            HandleTasks.EditStatus(current_task.Status, current_task, current_task.ID);
                                        });
                                    }
                                    else
                                    {
                                        current_task.Status = "Purchased";
                                        task.status_lbl_list[i].Text = current_task.Status;
                                        task.status_image_list[i].Image = Properties.Resources.filled_circle_20px_red;
                                        HandleTasks.EditStatus(current_task.Status, current_task, current_task.ID);
                                    }
                                }
                                else
                                {
                                    if (task.status_lbl_list[i].InvokeRequired)
                                    {
                                        task.status_lbl_list[i].BeginInvoke((MethodInvoker)delegate ()
                                        {
                                            task.status_lbl_list[i].ForeColor = Color.Red;
                                            current_task.Status = "Payment Declined";
                                            task.status_lbl_list[i].Text = current_task.Status;
                                            task.status_image_list[i].Image = Properties.Resources.filled_circle_20px_red;
                                            HandleTasks.EditStatus(current_task.Status, current_task, current_task.ID);
                                        });
                                    }
                                    else
                                    {
                                        task.status_lbl_list[i].ForeColor = Color.Red;
                                        current_task.Status = "Payment Declined";
                                        task.status_lbl_list[i].Text = current_task.Status;
                                        task.status_image_list[i].Image = Properties.Resources.filled_circle_20px_red;
                                        HandleTasks.EditStatus(current_task.Status, current_task, current_task.ID);
                                    }
                                }
                                driver.Close();
                            }
                            else
                            {
                                if (task.status_lbl_list[i].InvokeRequired)
                                {
                                    task.status_lbl_list[i].BeginInvoke((MethodInvoker)delegate ()
                                    {
                                        task.status_lbl_list[i].ForeColor = Color.Red;
                                        current_task.Status = "Wrong Account";
                                        task.status_lbl_list[i].Text = current_task.Status;
                                        task.status_image_list[i].Image = Properties.Resources.filled_circle_20px_red;
                                        HandleTasks.EditStatus(current_task.Status, current_task, current_task.ID);
                                    });
                                }
                                else
                                {
                                    task.status_lbl_list[i].ForeColor = Color.Red;
                                    current_task.Status = "Wrong Out";
                                    task.status_lbl_list[i].Text = current_task.Status;
                                    task.status_image_list[i].Image = Properties.Resources.filled_circle_20px_red;
                                    HandleTasks.EditStatus(current_task.Status, current_task, current_task.ID);
                                }
                                driver.Close();
                            }
                        }
                    }
                    else
                    {
                        if (task.status_lbl_list[i].InvokeRequired)
                        {
                            task.status_lbl_list[i].BeginInvoke((MethodInvoker)delegate ()
                            {
                                task.status_lbl_list[i].ForeColor = Color.Red;
                                current_task.Status = "Unvaible size";
                                task.status_lbl_list[i].Text = current_task.Status;
                                task.status_image_list[i].Image = Properties.Resources.filled_circle_20px_red;
                                HandleTasks.EditStatus(current_task.Status, current_task, current_task.ID);
                            });
                        }
                        else
                        {
                            task.status_lbl_list[i].ForeColor = Color.Red;
                            current_task.Status = "Unvaible size";
                            task.status_lbl_list[i].Text = current_task.Status;
                            task.status_image_list[i].Image = Properties.Resources.filled_circle_20px_red;
                            HandleTasks.EditStatus(current_task.Status, current_task, current_task.ID);
                        }
                        driver.Close();
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
        }
    }
}
