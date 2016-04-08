using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
namespace QABgileApp.Framework
{   
    #region
    public class LoginData
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public LoginData(string name, string email, string password, bool rememberme)
        {
            Name = name;
            Email = email;
            Password = password;
            RememberMe = rememberme;
        }
    }
    public class ChangePassword
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
        public ChangePassword(string oldpassword, string newpassword, string confirmpassword)
        {
            OldPassword = oldpassword;
            NewPassword = newpassword;
            ConfirmPassword = confirmpassword;
        }
    }
    public class ProfileOperations
    {
        public string Operation { get; set; }
        public ChangePassword ChangePassword { get; set; }
        public ProfileOperations(string operation, ChangePassword changepassword)
        {
            Operation = operation;
            ChangePassword = changepassword;

        }
    }
    public class DashboardOperation
    {
        public string PrimaryProject { get; set; }
        public string Release { get; set; }
        public string Sprint { get; set; }
        public DashboardOperation(string primaryproject, string release, string sprint)
        {
            PrimaryProject = primaryproject;
            Release = release;
            Sprint = sprint;
        }
    }
    #endregion
    public static class Login
    {
        public static LoginPage LoginPage
        {
            get
            {
                LoginPage loginpage = new LoginPage();
                PageFactory.InitElements(Browser.Driver, loginpage);
                return loginpage;
            }
        }
    }
    public class LoginPage
    {
        public string Url = "Bgile/Login";
        #region
        [FindsBy(How = How.Id, Using = "Email")]
        [CacheLookup]
        public IWebElement EmailTextBox { get; set; }		
        [FindsBy(How = How.Id, Using = "Password")]
        [CacheLookup]
        public IWebElement PasswordTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "RememberMe")]
        [CacheLookup]
        public IWebElement RememberMeCheckBox { get; set; }
        [FindsBy(How = How.ClassName, Using = "ForgotPassword")]
        [CacheLookup]
        public IWebElement ForgotPasswordDiv { get; set; }
        [FindsBy(How = How.ClassName, Using = "sfBtn")]
        [CacheLookup]
        public IWebElement SignInButton { get; set; }
        [FindsBy(How = How.TagName, Using = "title")]
        [CacheLookup]
        public IWebElement Title { get; set; }
        [FindsBy(How = How.TagName, Using = "h1")]
        [CacheLookup]
        public IWebElement Header { get; set; }
        [FindsBy(How = How.ClassName, Using = "tooltip")]
        public IWebElement ToolTip { get; set; }
        //[FindsBy(How = How.Id, Using = "liAccount")]
        //public IWebElement AccountList { get; set; }
        [FindsBy(How = How.ClassName, Using = "userDetail-inner")]
        public IWebElement ProfileOperationList { get; set; }
        //Dashboard
        [FindsBy(How = How.Id, Using = "PrimaryProject")]
        public IWebElement PrimaryProjectDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "ReleaseID")]
        public IWebElement ReleaseDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "SprintID")]
        public IWebElement SprintDropDown { get; set; }
        #endregion
        public void LoginOperation(LoginData LoginData)
        {
            LoginData logindata = new LoginData("Super Superuser", "super@braindigit.com", "superuser", false);
            try
            {
                //Browser.CheckBrokenImages();
                ClearAndFillTextBox EmailClearNFillTextBox = new ClearAndFillTextBox(EmailTextBox, LoginData.Email);
                ClearAndFillTextBox PasswordClearNFillTextBox = new ClearAndFillTextBox(PasswordTextBox, LoginData.Password);
                Browser.ClearAndFillTextBox(EmailClearNFillTextBox);
                Browser.ClearAndFillTextBox(PasswordClearNFillTextBox);
                //ChkBox RememberMeChkBox = new ChkBox(LoginData.RememberMe, RememberMeCheckBox);
                //Browser.CheckBox(RememberMeChkBox); 
SignIn:         SignInButton.Click();
                IList<IWebElement> InvalidData = Browser.Driver.FindElements(By.ClassName("sf"));
                if (InvalidData.Count != 0)
                {
                    switch (InvalidData[1].Text)
                    {
                        case "ErrorUser doesnot exists":
                            {
                                LoginOperation(logindata);
                                break;
                            }
                        case "UserName or Password is not matched":
                            {
                                PasswordClearNFillTextBox = new ClearAndFillTextBox(PasswordTextBox, "superuser");
                                Browser.ClearAndFillTextBox(PasswordClearNFillTextBox);
                                goto SignIn;
                            }
                    }
                }
                IList<IWebElement> InvalidData1 = Browser.Driver.FindElements(By.ClassName("field-validation-error"));
                if (InvalidData1.Count != 0)
                {
                    foreach (IWebElement invalidData in InvalidData1)
                    {
                        IList<IWebElement> MessageSpan = invalidData.FindElements(By.TagName("span"));
                        switch (MessageSpan[0].Text)
                        {
                            case "Please enter a valid email address.":
                            case "Email is not valid":
                                {
                                    EmailClearNFillTextBox = new ClearAndFillTextBox(EmailTextBox, "super@braindigit.com");
                                    Browser.ClearAndFillTextBox(EmailClearNFillTextBox);
                                    break;
                                }
                        }
                        goto SignIn;
                        //MessageBox.Show("Description is Required");
                        //Browser.SwitchToAlert(true);                     
                    }
                }
                IWebElement AccountList = Browser.Driver.FindElement(By.Id("liAccount"));
                IWebElement UserLabel = AccountList.FindElement(By.TagName("label"));
                //IsAt Settings = new IsAt(Header.Text, "Settings");
                //IsAt LoginName = new IsAt(UserLabel.Text, logindata.Name);
                //Assert.IsTrue(Browser.IsAt(Settings));
                //Assert.IsTrue(Browser.IsAt(LoginName));
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[3] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void ProfileOperations(ProfileOperations ProfileOperations)
        {
            try
            {
                IWebElement UL = ProfileOperationList.FindElement(By.TagName("ul"));
                IList<IWebElement> OperationLinks = UL.FindElements(By.TagName("li"));
                MouseMovement Mouse = new MouseMovement(ToolTip, false);
                Browser.MouseMovement(Mouse);
                switch (ProfileOperations.Operation)
                {
                    case "My Profile":
                        {
                            IWebElement ProfileLink = OperationLinks[0].FindElement(By.TagName("a"));
                            ProfileLink.Click();
                            break;
                        }
                    case "Change Password":
                        {
                            IWebElement ChangePasswordLink = OperationLinks[1].FindElement(By.TagName("a"));
                            ChangePasswordLink.Click();
                            ChangePassword(ProfileOperations.ChangePassword);
                            break;
                        }
                    case "Logout":
                        {
                            IWebElement LogoutLink = OperationLinks[2].FindElement(By.TagName("a"));
                            LogoutLink.Click();
                            break;
                        }
                }
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[3] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void ChangePassword(ChangePassword ChangePassword)
        {
            try
            {
                IWebElement OldPasswordTextBox = Browser.Driver.FindElement(By.Id("ExistingPassword"));
                IWebElement NewPasswordTextBox = Browser.Driver.FindElement(By.Id("Password"));
                IWebElement ConfirmPasswordTextBox = Browser.Driver.FindElement(By.Id("ConfirmPassword"));
                IWebElement ChangePasswordButton = Browser.Driver.FindElement(By.ClassName("sfBtn"));
                ClearAndFillTextBox OldPasswodClearNFill = new ClearAndFillTextBox(OldPasswordTextBox, ChangePassword.OldPassword);
                ClearAndFillTextBox NewPasswordClearNFill = new ClearAndFillTextBox(NewPasswordTextBox, ChangePassword.NewPassword);
                ClearAndFillTextBox ConfirmPasswordClearNFill = new ClearAndFillTextBox(ConfirmPasswordTextBox, ChangePassword.ConfirmPassword);
                Browser.ClearAndFillTextBox(OldPasswodClearNFill);
                Browser.ClearAndFillTextBox(NewPasswordClearNFill);
                Browser.ClearAndFillTextBox(ConfirmPasswordClearNFill);
                ChangePasswordButton.Click(); 
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void DashboardOperation(DashboardOperation DashboardOperation)
        {
            try
            {
                DropDownSelect DropDownPrimaryProject = new DropDownSelect(DashboardOperation.PrimaryProject, PrimaryProjectDropDown);
                DropDownSelect DropDownRelease = new DropDownSelect(DashboardOperation.Release, ReleaseDropDown);
                DropDownSelect DropDownSprint = new DropDownSelect(DashboardOperation.Sprint, SprintDropDown);
                Browser.SelectDropdown(DropDownPrimaryProject);
                Browser.SelectDropdown(DropDownRelease);
                Browser.SelectDropdown(DropDownSprint);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
