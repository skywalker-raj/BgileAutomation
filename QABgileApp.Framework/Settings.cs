using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using NUnit.Framework;
namespace QABgileApp.Framework
{
    #region
    public class Holiday
    {
        public string HolidayTitle { get; set; }
        public string HolidayDate { get; set; }
        public string Gender { get; set; }
        public string HalfFull { get; set; }
        public Holiday(string holidayTitle, string holidayDate, string gender, string halfFull)
        {
            HolidayTitle = holidayTitle;
            HolidayDate = holidayDate;
            Gender = gender;
            HalfFull = halfFull;
        }
    }
    public class Target
    {
        public string WorkYear { get; set; }
        public string IncreaseFeature { get; set; }
        public string PerIncreaseFeature { get; set; }
        public string FeatureDrop { get; set; }
        public string PerDropFeature { get; set; }
        public string SchedulePredictability { get; set; }
        public string PerSchedulePredictability { get; set; }
        public string EffortDeviation { get; set; }
        public string PerEffortDeviation { get; set; }
        public string Utilization { get; set; }
        public string PerUtilization { get; set; }
        public string Hardening { get; set; }
        public string PerHardening { get; set; }
        public string OnTimeContentDelivery { get; set; }
        public string PerOnTimeContentDelivery { get; set; }
        public bool ConfirmSave { get; set; }
        public Target(string workYear, string increaseFeature, string perIncreaseFeature, string featureDrop, string perDropFeature, string schedulePredictability, string perSchedulePredictability, string effortDeviation, string perEffortDeviation, string utilization, string perUtilization, string hardening, string perHardening, string onTimeContentDelivery, string perOnTimeContentDelivery, bool confirmSave)
        {
            WorkYear = workYear;
            IncreaseFeature = increaseFeature;
            PerIncreaseFeature = perIncreaseFeature;
            FeatureDrop = featureDrop;
            PerDropFeature = perDropFeature;
            SchedulePredictability = schedulePredictability;
            PerSchedulePredictability = perSchedulePredictability;
            EffortDeviation = effortDeviation;
            PerEffortDeviation = perEffortDeviation;
            Utilization = utilization;
            PerUtilization = perUtilization;
            Hardening = hardening;
            PerHardening = perHardening;
            OnTimeContentDelivery = onTimeContentDelivery;
            PerOnTimeContentDelivery = perOnTimeContentDelivery;
            ConfirmSave = confirmSave;
        }
    }
    public class People
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }
        public string ImgPath { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }
        public People(string firstName, string lastName, string designation, string imgPath, string role, bool isActive)
        {
            FirstName = firstName;
            LastName = lastName;
            Designation = designation;
            ImgPath = imgPath;
            Role = role;
            IsActive = isActive;
        }
    }
    public class EditPeople
    {
        public string Action { get; set; }
        public bool ConfirmDelete { get; set; }
        public People People { get; set; }
        public string ProfileSummary { get; set; }
        public bool Update { get; set; }
        public EditPeople(string action, bool confirmdelete, People people, string profileSummary, bool update)
        {
            Action = action;
            ConfirmDelete = confirmdelete;
            People = people;
            ProfileSummary = profileSummary;
            Update = update;
        }
    }
    public class AddPeople
    {
        public People People { get; set; }
        public string Email { get; set; }       
        public string Password { get; set; }
        public bool Save { get; set; }
        public AddPeople(People people, string email, string password, bool save)
        {
            People = people;
            Email = email;            
            Password = password;
            Save = save;
        }
    }
    public class Work
    {
        public bool AddYear { get; set; }
        public string StartYear { get; set; }
        public string EndYear { get; set; }
        public bool ConfirmAddYear { get; set; }
        public string SelectYear { get; set; }
        public string[] WorkDays { get; set; }
        public string WorkHours { get; set; }
        public Holiday[] Holidays { get; set; }
        public string Q1StartDate { get; set; }
        public string Q1EndDate { get; set; }
        public string Q2StartDate { get; set; }
        public string Q2EndDate { get; set; }
        public string Q3StartDate { get; set; }
        public string Q3EndDate { get; set; }
        public string Q4StartDate { get; set; }
        public string Q4EndDate { get; set; }
        public Work(bool addYear, string startYear, string endYear, bool confirmAddYear, string selectYear, string[] workDays, string workHours, Holiday[] holidays, string q1StartDate, string q1EndDate, string q2StartDate, string q2EndDate, string q3StartDate, string q3EndDate, string q4StartDate, string q4EndDate)
        {
            AddYear = addYear;
            StartYear = startYear;
            EndYear = endYear;
            ConfirmAddYear = confirmAddYear;
            SelectYear = selectYear;
            WorkDays = workDays;
            WorkHours = workHours;
            Holidays = holidays;
            Q1StartDate = q1StartDate;
            Q1EndDate = q1EndDate;
            Q2StartDate = q2StartDate;
            Q2EndDate = q2EndDate;
            Q3StartDate = q3StartDate;
            Q3EndDate = q3EndDate;
            Q4StartDate = q4StartDate;
            Q4EndDate = q4EndDate;
        }
    }
    public class SearchPeople
    {
        public string status { get; set; }
        public string user { get; set; }
        public SearchPeople(string Status, string User)
        {
            status = Status;
            user = User;
        }
    }
    #endregion
    public static class Settings
    {
        public static SettingsPage SettingsPage
        {
            get
            {
                SettingsPage settingspage = new SettingsPage();
                PageFactory.InitElements(Browser.Driver, settingspage);
                return settingspage;
            }
        }
    }
    public class SettingsPage
    {
        public string Url = "Settings/Peoples";
        public string Title = "Settings";
        public string People = "People()";
        public string Work = "Work";
        public string Target = "Target";
        #region
        [FindsBy(How = How.Id, Using = "settingsMenu")]
        public IWebElement SettingsMenuDiv { get; set; }
        [FindsBy(How = How.Id, Using = "divPaging")]
        public IWebElement PagingDiv { get; set; }
        //Peoples
        [FindsBy(How = How.ClassName, Using = "AddUser")]
        public IWebElement AddUserButton { get; set; }
        [FindsBy(How = How.Id, Using = "Status")]
        public IWebElement StatusDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "txtSearch")]
        public IWebElement SearchPeopleTextBox { get; set; }
        [FindsBy(How = How.ClassName, Using = "icon-search")]
        public IWebElement SearchBtn { get; set; }
        //Add People
        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement FirstNameTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "LastName")]
        public IWebElement LastNameTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement EmailTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "Designation")]
        public IWebElement DesignationDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement PasswordTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "fupUploadImage")]
        public IWebElement ImageUploader { get; set; }
        [FindsBy(How = How.Id, Using = "IsActive")]
        public IWebElement IsActiveCheckBox { get; set; }
        [FindsBy(How = How.ClassName, Using = "permissionName")]
        public IWebElement PermissionNameList { get; set; }
        [FindsBy(How = How.Id, Using = "btnSaveUser")]
        public IWebElement SaveUserButton { get; set; }
        [FindsBy(How = How.Id, Using = "btnCancelUser")]
        public IWebElement CancelUserButton { get; set; }
        [FindsBy(How = How.Id, Using = "Btable")]
        public IWebElement UsersTableDiv { get; set; }
        [FindsBy(How = How.ClassName, Using = "btnUpdate")]
        public IWebElement UpdateButton { get; set; }
        [FindsBy(How = How.Id, Using = "ProfileSummary")]
        public IWebElement SummaryTexBox { get; set; }
        [FindsBy(How = How.Id, Using = "btnUploadImage")]
        public IWebElement UploadImageButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "editPeopleImage")]
        public IWebElement EditImageButton { get; set; }
        [FindsBy(How = How.TagName, Using = "h2")]
        public IWebElement SubHeader { get; set; }
        //Target
        //[FindsBy(How = How.Id, Using = "")]
        //public IWebElement IncreaseFeature { get; set; }
        [FindsBy(How = How.Id, Using = "WorkYearID")]
        public IWebElement TargetWorkYearDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "IncreaseFeature")]
        public IWebElement IncreaseFeatureTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "PerIncreaseFeature")]
        public IWebElement PerIncreaseFeatureDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "DropFeature")]
        public IWebElement FeatureDropTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "PerDropFeature")]
        public IWebElement PerDropFeatureDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "SchedulePredictability")]
        public IWebElement SchedulePredictabilityTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "PerSchedulePredictability")]
        public IWebElement PerSchedulePredictabilityDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "EffortDeviation")]
        public IWebElement EffortDeviationTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "PerEffortDeviation")]
        public IWebElement PerEffortDeviationDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "Utilization")]
        public IWebElement UtilizationTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "PerUtilization")]
        public IWebElement PerUtilizationDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "Hardening")]
        public IWebElement HardeningTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "PerHardening")]
        public IWebElement PerHardeningDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "OnTimeContentDelivery")]
        public IWebElement OnTimeContentDeliveryTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "PerOnTimeContentDelivery")]
        public IWebElement PerOnTimeContentDeliveryDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "btnSaveTarget")]
        public IWebElement SaveTargetButton { get; set; }
        //Work
        [FindsBy(How = How.ClassName, Using = "BAddyear")]
        public IWebElement AddYearLink { get; set; }
        [FindsBy(How = How.Id, Using = "SEDate")]
        public IWebElement WorkYearDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "Q1Start")]
        public IWebElement Quarter1Start { get; set; }
        [FindsBy(How = How.Id, Using = "Q1End")]
        public IWebElement Quarter1End { get; set; }
        [FindsBy(How = How.Id, Using = "Q2Start")]
        public IWebElement Quarter2Start { get; set; }
        [FindsBy(How = How.Id, Using = "Q2End")]
        public IWebElement Quarter2End { get; set; }
        [FindsBy(How = How.Id, Using = "Q3Start")]
        public IWebElement Quarter3Start { get; set; }
        [FindsBy(How = How.Id, Using = "Q3End")]
        public IWebElement Quarter3End { get; set; }
        [FindsBy(How = How.Id, Using = "Q4Start")]
        public IWebElement Quarter4Start { get; set; }
        [FindsBy(How = How.Id, Using = "Q4End")]
        public IWebElement Quarter4End { get; set; }
        [FindsBy(How = How.Id, Using = "WorkHour")]
        public IWebElement AvailableWorkHours { get; set; }
        [FindsBy(How = How.Name, Using = "WDay")]
        public IList<IWebElement> WorkingDays { get; set; }
        public IWebElement WorkingDaysSunday { get; set; }
        [FindsBy(How = How.Id, Using = "btnSaveWork")]
        public IWebElement SaveWorkButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "sfAddMore")]
        public IWebElement AddMoreHolidayButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "sfHolidayGroup")]
        public IWebElement HolidayGroupDiv { get; set; }
        [FindsBy(How = How.Id, Using = "YearStart")]
        public IWebElement YearStartTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "YearEnd")]
        public IWebElement YearEndTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "btnSaveWorkDate")]
        public IWebElement SaveWorkDate { get; set; }
        [FindsBy(How = How.Id, Using = "btnCancelDate")]
        public IWebElement CancelWorkDate { get; set; }
        [FindsBy(How = How.ClassName, Using = "sfHolidayGroup")]
        public IList<IWebElement> HolidayRow { get; set; }
        #endregion
        public void SearchPeople(SearchPeople SearchPeople)
        {
            try
            {
                IsAt AtPeople = new IsAt(SubHeader.Text, People);
                Assert.IsTrue(Browser.IsAt(AtPeople));
                DropDownSelect StatusDropDownSelect = new DropDownSelect(SearchPeople.status, StatusDropDown);
                Browser.SelectDropdown(StatusDropDownSelect);
                ClearAndFillTextBox UserClearNFillTextBox = new ClearAndFillTextBox(SearchPeopleTextBox, SearchPeople.user);
                Browser.ClearAndFillTextBox(UserClearNFillTextBox);
                //Browser.ClickOnInvisibleElement(SearchBtn);
                SearchPeopleTextBox.SendKeys(Keys.Enter);
                IList<IWebElement> ErrorMessage = Browser.Driver.FindElements(By.ClassName("errorSearchmsg"));
                if (ErrorMessage.Count != 0)
                {
                    if (ErrorMessage[0].Text == "No user found.Please choose another key word.")
                    {
                        //MessageBox.Show("No User Found, Please Enter Valid Name!");         
                    }
                }
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[4] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void SelectRole(int n)
        {
            try
            {
                IList<IWebElement> PermissionList = PermissionNameList.FindElements(By.TagName("li"));
                IWebElement RolePermission = PermissionList[n].FindElement(By.TagName("input"));
                RolePermission.Click();
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[4] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void FillDetails(People People)
        {
            try
            {
                ClearAndFillTextBox FirstNameClearNFillTextBox = new ClearAndFillTextBox(FirstNameTextBox, People.FirstName);
                ClearAndFillTextBox LastNameClearNFillTextBox = new ClearAndFillTextBox(LastNameTextBox, People.LastName);
                Browser.ClearAndFillTextBox(FirstNameClearNFillTextBox);
                Browser.ClearAndFillTextBox(LastNameClearNFillTextBox);
                DropDownSelect DesignationDropDownSelect = new DropDownSelect(People.Designation, DesignationDropDown);
                Browser.SelectDropdown(DesignationDropDownSelect);
                ImageUploader.SendKeys(People.ImgPath);
                ChkBox IsActiveChkBox = new ChkBox(People.IsActive, IsActiveCheckBox);
                Browser.CheckBox(IsActiveChkBox);
                //ImageUploader.Click();
                //SendKeys.SendWait(ImgPath);
                //SendKeys.SendWait(@"{Enter}");
                switch (People.Role)
                {
                    case "Admin":
                        {
                            SelectRole(0);
                            break;
                        }
                    case "Report Viewer":
                        {
                            SelectRole(1);
                            break;
                        }
                    case "Project Lead":
                        {
                            SelectRole(2);
                            break;
                        }
                    case "Collaborator":
                        {
                            SelectRole(3);
                            break;
                        }
                    case "Member":
                        {
                            SelectRole(4);
                            break;
                        }
                }
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[4] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void AddPeople(AddPeople[] PeopleData)
        {
            try
            {
                foreach (AddPeople people in PeopleData)
                {
                    //IsAt AtPeople = new IsAt(SubHeader.Text, People);
                    //Assert.IsTrue(Browser.IsAt(AtPeople));
                    AddUserButton.Click();
                    FillDetails(people.People);
                    ClearAndFillTextBox EmailClearNFillTextBox = new ClearAndFillTextBox(EmailTextBox, people.Email);
                    ClearAndFillTextBox PasswordClearNFillTextBox = new ClearAndFillTextBox(PasswordTextBox, people.Password);
                    Browser.ClearAndFillTextBox(EmailClearNFillTextBox);
                    Browser.ClearAndFillTextBox(PasswordClearNFillTextBox);                   
                    SaveCancel UserSaveCancel = new SaveCancel(SaveUserButton, CancelUserButton, people.Save);
                    Browser.SaveCancel(UserSaveCancel); 
                }
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[4] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void ClickMenu(int n)
        {
            try
            {
                IWebElement PageTable = SettingsMenuDiv.FindElement(By.TagName("ul"));
                IList<IWebElement> PageList = PageTable.FindElements(By.TagName("li"));
                string classvalue = PageList[n].GetAttribute("class");
                if (classvalue == "")
                {
                    IWebElement PageMenu = PageList[n].FindElement(By.TagName("a"));
                    IWebElement PageLink = PageMenu.FindElement(By.TagName("span"));
                    PageLink.Click();
                }
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[4] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void SettingsMenuChange(string Page)
        {
            try
            {
                switch (Page)
                {
                    case "Peoples":
                        {
                            ClickMenu(0);
                            break;
                        }
                    case "Work":
                        {
                            ClickMenu(1);
                            break;
                        }
                    case "Targets":
                        {
                            ClickMenu(2);
                            break;
                        }
                }
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[4] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void EditDelete(EditPeople[] PeopleData)
        {
            try
            {
                foreach (EditPeople peopleData in PeopleData)
                {
                    IsAt AtPeople = new IsAt(SubHeader.Text, People);
                    Assert.IsTrue(Browser.IsAt(AtPeople));
                    //IList<IWebElement> Row = UsersTableDiv.FindElements(By.ClassName("row"));
                    //IList<IWebElement> Span = Row[0].FindElements(By.TagName("span"));
                    //IWebElement EditDeleteButton;
                    switch (peopleData.Action)
                    {
                        case "Edit":
                            {
                                IList<IWebElement> EditPeopleLink = Browser.Driver.FindElements(By.ClassName("editPeople"));
                                EditPeopleLink[0].Click();
                                //Browser.ClickOnInvisibleElement(EditPeopleLink[1]);
                                ClearAndFillTextBox SummaryClearNFillTextBox = new ClearAndFillTextBox(SummaryTexBox, peopleData.ProfileSummary);
                                Browser.ClearAndFillTextBox(SummaryClearNFillTextBox);
                                EditImageButton.Click();
                                FillDetails(peopleData.People);
                                UploadImageButton.Click();
                                SaveCancel UserUpdateCancel = new SaveCancel(UpdateButton, CancelUserButton, peopleData.Update);
                                Browser.SaveCancel(UserUpdateCancel);
                                break;
                            }
                        case "Delete":
                            {
                                IWebElement DeletePeopleLink = Browser.Driver.FindElement(By.ClassName("deletePeople"));
                                DeletePeopleLink.Click();
                                //Browser.ClickOnInvisibleElement(DeletePeopleLink); 
                                Browser.SwitchToAlert(peopleData.ConfirmDelete);
                                break;
                            }
                    }
                }
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[4] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void TargetOperations(Target[] TargetData)
        {
            try
            {
                SettingsMenuChange("Targets");
                foreach (Target target in TargetData)
                {
                    //IsAt AtTarget = new IsAt(SubHeader.Text, Target);
                    //Assert.IsTrue(Browser.IsAt(AtTarget));
                    DropDownSelect WorkYearDropDownSelect = new DropDownSelect(target.WorkYear, TargetWorkYearDropDown);
                    Browser.SelectDropdown(WorkYearDropDownSelect);
                    //Browser.SwitchToAlert(true);
                    ClearAndFillTextBox IncreaseFeatureClearNFillTextBox = new ClearAndFillTextBox(IncreaseFeatureTextBox, target.IncreaseFeature);
                    ClearAndFillTextBox FeatureDropClearNFillTextBox = new ClearAndFillTextBox(FeatureDropTextBox, target.FeatureDrop);
                    ClearAndFillTextBox SchedulePredictabilityClearNFillTextBox = new ClearAndFillTextBox(SchedulePredictabilityTextBox, target.SchedulePredictability);
                    ClearAndFillTextBox EffortDeviationClearNFillTextBox = new ClearAndFillTextBox(EffortDeviationTextBox, target.EffortDeviation);
                    ClearAndFillTextBox UtilizationClearNFillTextBox = new ClearAndFillTextBox(UtilizationTextBox, target.Utilization);
                    ClearAndFillTextBox HardeningClearNFillTextBox = new ClearAndFillTextBox(HardeningTextBox, target.Hardening);
                    ClearAndFillTextBox OnTimeContentDeliveryClearNFillTextBox = new ClearAndFillTextBox(OnTimeContentDeliveryTextBox, target.OnTimeContentDelivery);
                    Browser.ClearAndFillTextBox(IncreaseFeatureClearNFillTextBox);
                    DropDownSelect PerIncreaseFeatureDropDownSelect = new DropDownSelect(target.PerIncreaseFeature, PerIncreaseFeatureDropDown);
                    Browser.SelectDropdown(PerIncreaseFeatureDropDownSelect);
                    Browser.ClearAndFillTextBox(FeatureDropClearNFillTextBox);
                    DropDownSelect PerDropFeatureDropDownSelect = new DropDownSelect(target.PerDropFeature, PerDropFeatureDropDown);
                    Browser.SelectDropdown(PerDropFeatureDropDownSelect);
                    Browser.ClearAndFillTextBox(SchedulePredictabilityClearNFillTextBox);
                    DropDownSelect PerSchedulePredictabilityDropDownSelect = new DropDownSelect(target.PerSchedulePredictability, PerSchedulePredictabilityDropDown);
                    Browser.SelectDropdown(PerSchedulePredictabilityDropDownSelect);
                    Browser.ClearAndFillTextBox(EffortDeviationClearNFillTextBox);
                    DropDownSelect PerEffortDeviationDropDownSelect = new DropDownSelect(target.PerEffortDeviation, PerEffortDeviationDropDown);
                    Browser.SelectDropdown(PerEffortDeviationDropDownSelect);
                    Browser.ClearAndFillTextBox(UtilizationClearNFillTextBox);
                    DropDownSelect PerUtilizationDropDownSelect = new DropDownSelect(target.PerUtilization, PerUtilizationDropDown);
                    Browser.SelectDropdown(PerUtilizationDropDownSelect);
                    Browser.ClearAndFillTextBox(HardeningClearNFillTextBox);
                    DropDownSelect PerHardeningDropDownSelect = new DropDownSelect(target.PerHardening, PerHardeningDropDown);
                    Browser.SelectDropdown(PerHardeningDropDownSelect);
                    Browser.ClearAndFillTextBox(OnTimeContentDeliveryClearNFillTextBox);
                    DropDownSelect PerOnTimeContentDeliveryDropDownSelect = new DropDownSelect(target.PerOnTimeContentDelivery, PerOnTimeContentDeliveryDropDown);
                    Browser.SelectDropdown(PerOnTimeContentDeliveryDropDownSelect);
                    if (target.ConfirmSave == true)
                    {
                        SaveTargetButton.Click();
                        IList<IWebElement> RequiredMessage = Browser.Driver.FindElements(By.LinkText("*"));
                        if (RequiredMessage.Count != 0)
                        {

                        }
                        IList<IWebElement> ErrorMessage = Browser.Driver.FindElements(By.LinkText("Please enter valid Number."));
                        if (ErrorMessage.Count != 0)
                        {

                        }
                    }
                }
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[4] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void WorkOperations(Work Work)
        {
            try
            {
                SettingsMenuChange("Work");
                //if (Work.AddYear == true)
                //{
                //    AddYearLink.Click();
                //    ClearAndFillTextBox StartYearClearNFillTextBox = new ClearAndFillTextBox(YearStartTextBox, Work.StartYear);
                //    ClearAndFillTextBox EndYearClearNFillTextBox = new ClearAndFillTextBox(YearEndTextBox, Work.EndYear);
                //    Browser.ClearAndFillTextBox(EndYearClearNFillTextBox);
                //    Browser.ClearAndFillTextBox(StartYearClearNFillTextBox);
                //    SaveCancel WorkYearSaveCancel = new SaveCancel(SaveWorkDate, CancelWorkDate, Work.ConfirmAddYear);
                //    Browser.SaveCancel(WorkYearSaveCancel);
                //}
                DropDownSelect SelectYearDropDownSelect = new DropDownSelect(Work.SelectYear, WorkYearDropDown);
                Browser.SelectDropdown(SelectYearDropDownSelect);
                ClearAndFillTextBox Q1StartDateClearNFillTextBox = new ClearAndFillTextBox(Quarter1Start, Work.Q1StartDate);
                ClearAndFillTextBox Q1EndDateClearNFillTextBox = new ClearAndFillTextBox(Quarter1End, Work.Q1EndDate);
                ClearAndFillTextBox Q2StartDateClearNFillTextBox = new ClearAndFillTextBox(Quarter2Start, Work.Q2StartDate);
                ClearAndFillTextBox Q2EndDateClearNFillTextBox = new ClearAndFillTextBox(Quarter2End, Work.Q2EndDate);
                ClearAndFillTextBox Q3StartDateClearNFillTextBox = new ClearAndFillTextBox(Quarter3Start, Work.Q3StartDate);
                ClearAndFillTextBox Q3EndDateClearNFillTextBox = new ClearAndFillTextBox(Quarter3End, Work.Q3EndDate);
                ClearAndFillTextBox Q4StartDateClearNFillTextBox = new ClearAndFillTextBox(Quarter4Start, Work.Q4StartDate);
                ClearAndFillTextBox Q4EndDateClearNFillTextBox = new ClearAndFillTextBox(Quarter4End, Work.Q4EndDate);
                ClearAndFillTextBox WorkHoursClearNFillTextBox = new ClearAndFillTextBox(AvailableWorkHours, Work.WorkHours);
                Browser.ClearAndFillTextBox(Q1StartDateClearNFillTextBox);
                Browser.ClearAndFillTextBox(Q1EndDateClearNFillTextBox);
                Browser.ClearAndFillTextBox(Q2StartDateClearNFillTextBox);
                Browser.ClearAndFillTextBox(Q2EndDateClearNFillTextBox);
                Browser.ClearAndFillTextBox(Q3StartDateClearNFillTextBox);
                Browser.ClearAndFillTextBox(Q3EndDateClearNFillTextBox);
                Browser.ClearAndFillTextBox(Q4StartDateClearNFillTextBox);
                Browser.ClearAndFillTextBox(Q4EndDateClearNFillTextBox);
                Browser.ClearAndFillTextBox(WorkHoursClearNFillTextBox);
                foreach (string WorkDay in Work.WorkDays)
                {
                    switch (WorkDay)
                    {
                        case "Monday":
                            {
                                ChkBox MondayChkBox = new ChkBox(true, WorkingDays[0]);
                                Browser.CheckBox(MondayChkBox);
                                break;
                            }
                        case "Tuesday":
                            {
                                ChkBox TuesdayChkBox = new ChkBox(true, WorkingDays[1]);
                                Browser.CheckBox(TuesdayChkBox);
                                break;
                            }
                        case "Wednesday":
                            {
                                ChkBox WednesdayChkBox = new ChkBox(true, WorkingDays[2]);
                                Browser.CheckBox(WednesdayChkBox);
                                break;
                            }
                        case "Thursday":
                            {
                                ChkBox ThursdayChkBox = new ChkBox(true, WorkingDays[3]);
                                Browser.CheckBox(ThursdayChkBox);
                                break;
                            }
                        case "Friday":
                            {
                                ChkBox FridayChkBox = new ChkBox(true, WorkingDays[4]);
                                Browser.CheckBox(FridayChkBox);
                                break;
                            }
                        case "Saturday":
                            {
                                ChkBox SaturdayChkBox = new ChkBox(true, WorkingDays[5]);
                                Browser.CheckBox(SaturdayChkBox);
                                break;
                            }
                        case "Sunday":
                            {
                                ChkBox SundayChkBox = new ChkBox(true, WorkingDays[6]);
                                Browser.CheckBox(SundayChkBox);
                                break;
                            }
                    }
                }
                int i = 0;
                IWebElement HolidayTitleTextBox = Browser.Driver.FindElement(By.Id("LstHoliday_" + i.ToString() + "__Title"));
                IWebElement HolidayDateTextBox = Browser.Driver.FindElement(By.Id("LstHoliday_" + i.ToString() + "__HolidayDate"));
                IList<IWebElement> GenderRadio = Browser.Driver.FindElements(By.Id("LstHoliday_" + i.ToString() + "__Gender"));
                IList<IWebElement> Day = Browser.Driver.FindElements(By.Id("LstHoliday_" + i.ToString() + "__IsFullDay"));
                foreach (Holiday holiday in Work.Holidays)
                {
                    ClearAndFillTextBox HolidayTitleClearNFillTextBox = new ClearAndFillTextBox(HolidayTitleTextBox, holiday.HolidayTitle);
                    ClearAndFillTextBox HolidayDateClearNFillTextBox = new ClearAndFillTextBox(HolidayDateTextBox, holiday.HolidayDate);
                    Browser.ClearAndFillTextBox(HolidayTitleClearNFillTextBox);
                    Browser.ClearAndFillTextBox(HolidayDateClearNFillTextBox);
                    switch (holiday.Gender)
                    {
                        case "Male":
                            {
                                GenderRadio[0].Click();
                                break;
                            }
                        case "Female":
                            {
                                GenderRadio[1].Click();
                                break;
                            }
                        default:
                            {
                                GenderRadio[2].Click();
                                break;
                            }
                    }
                    switch (holiday.HalfFull)
                    {
                        case "Full":
                            {
                                Day[0].Click();
                                break;
                            }
                        case "Half":
                            {
                                Day[1].Click();
                                break;
                            }
                    }
                    i++;
                    if (Work.Holidays.Length > HolidayRow.Count - 1)
                    {
                        AddMoreHolidayButton.Click();
                        HolidayTitleTextBox = Browser.Driver.FindElement(By.Id("Title" + (i + 2).ToString()));
                        HolidayDateTextBox = Browser.Driver.FindElement(By.Id("HolidayDate" + (i + 2).ToString()));
                        GenderRadio = Browser.Driver.FindElements(By.Id("Gender" + (i + 2).ToString()));
                        Day = Browser.Driver.FindElements(By.Id("IsFullDay" + (i + 2).ToString()));
                    }
                }
                SaveWorkButton.Click();
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[4] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void DatePicker(DateTime Date)
        {
            try
            {
                IWebElement DateHeader = Browser.Driver.FindElement(By.ClassName("ui-datepicker-header"));
                IWebElement DateTitle = DateHeader.FindElement(By.ClassName("ui-datepicker-title"));
                IWebElement DateCalendar = Browser.Driver.FindElement(By.ClassName("ui-datepicker-calendar"));

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
