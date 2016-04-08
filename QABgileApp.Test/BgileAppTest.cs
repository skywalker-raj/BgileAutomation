using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit.Framework;
using QABgileApp.Framework;
namespace QABgileApp.Test
{
    [TestClass]
    public class BgileAppTestMethod
    {
        [TestMethod]
        public void Can_Login()
        {
            LoginData logindata = new LoginData("Super Superuser", "super@braindigit.com", "superuser", false);
            //LoginData logindata = new LoginData("Report Viewer", "report@gmail.com", "report", false);
            //LoginData logindata = new LoginData("Project Lead", "project@gmail.com", "project", false);
            //LoginData logindata = new LoginData("Collaborator Collaborator", "collaborator@gmail.com", "collaborator", false);
            //LoginData logindata = new LoginData("Member member", "member@gmail.com", "member", false);
            try
            {
                Browser.GoTo(Login.LoginPage.Url);
                //Browser.eyes.CheckWindow("Login");
                //Assert.IsTrue(Browser.Is_At());
                Login.LoginPage.LoginOperation(logindata);
                //Browser.eyes.CheckWindow("Dashboard");
                //Assert.IsTrue(Browser.IsAt(Login.LoginPage.Header.Text, "Settings"));
                //TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //TestResults.ErrorException[4] = ex.ToString();
                //TestResults.Fail++;
            }
        }
        [TestMethod]
        public void Can_Add_Project()
        {
            ProjectData[] ProjectData = {
                                          new ProjectData("SageCMS", "", "Inhouse", "SC", "Alok Pandey", "Shree Khanal", "1/15/2016", "03/15/2016", "LightWeight CMS", true),
                                          new ProjectData("Ncell", "", "Client", "NC", "Shree Khanal", "Sujan Amatya", "1/15/2016", "03/15/2016", "Connecting People", true),
                                          new ProjectData("Aspx Commerce", "", "Inhouse", "AC", "Alok Pandey", "Shree Khanal", "1/15/2016", "03/15/2016", "Online Shopping", true),
                                          new ProjectData("Nepali Paisa", "", "Client", "NP", "Nischal Man Pradhan", "Sujan Amatya", "1/15/2016", "03/15/2016", "Mobile App For Stock Market", true),
                                          new ProjectData("Dofe", "", "Client", "DO", "Nitesh Gorkhali", "Pawan Nepal", "1/15/2016", "03/15/2016", "Web and Desktop Application for DOFE", true),
                                          new ProjectData("SmartShopy", "", "Inhouse", "SS", "Alok Pandey", "Ishwor Dangol", "1/28/2016", "03/15/2016", "Aspx Commerce provides SAAS Feature", true),
                                          new ProjectData("SageFrame", "", "Inhouse", "SF", "Alok Pandey", "Shree Khanal", "1/28/2016", "10/15/2016", "Open Source CMS for .NET", true),
                                          new ProjectData("ListBingo", "", "Inhouse", "LB", "Narendra Maharjan", "Narendra Maharjan", "1/15/2016", "10/15/2016", "An Extension for Joomla", true),
                                          new ProjectData("EEC", "", "Client", "EEC", "Alok Pandey", "Shree Khanal", "1/15/2016", "3/15/2016", "WebApp for Environmental Emergencies Center", true),
                                          new ProjectData("Templating", "", "Inhouse", "SFT", "Alok Pandey", "Shree Khanal", "1/15/2016", "5/15/2016", "Template Designs for Sageframe, Sagever and SageCMS", true),
                                          new ProjectData("Sagever", "", "Inhouse", "SE", "Alok Pandey", "Shree Khanal", "1/15/2016", "11/15/2016", "Paid and Extended version of SageFrame", true),
                                          new ProjectData("BgileApp", "", "Inhouse", "BA", "Harihar Pradhan", "Shree Khanal", "1/15/2016", "11/15/2016", "App for Bgile Methodologies", true)
                                      };
            try
            {
                //Can_Login(Username, Password, RememberMe);
                Can_Login();
                Browser.GoTo(Project.ProjectPage.Url);
                //Assert.IsTrue(Browser.IsAt(Project.ProjectPage.Header.Text, Project.ProjectPage.Title));
                Project.ProjectPage.AddProject(ProjectData);
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //TestResults.ErrorException[5] = ex.ToString();
                //TestResults.Fail++;
            }
        }
        [TestMethod]
        public void Can_Add_ProjectTeamMember()
        {
            //AddTeamMember
            TeamMemberDetails[] TeamMemberDetails = {
                                                      new TeamMemberDetails("Developer", "1/15/2016", "2/15/2016", "2", true, false, true),
                                                      new TeamMemberDetails("Scrummaster", "1/15/2016", "3/15/2016", "3", true, false, true),
                                                      new TeamMemberDetails("Designer", "1/15/2016", "2/15/2016", "4", true, false, true),
                                                      new TeamMemberDetails("Team Lead", "1/15/2016", "3/15/2016", "2", true, false, true),
                                                      new TeamMemberDetails("Quality assistance", "1/15/2016", "3/15/2016", "3", true, false, true),
                                                  };
            AddTeamMember[] AddTeamMember = {
                                                //new AddTeamMember("Ankit Chaudhary", TeamMemberDetails[0]),
                                                //new AddTeamMember("Ishwor Dangol", TeamMemberDetails[1]),
                                                //new AddTeamMember("Dipendra Timilsina", TeamMemberDetails[2]),                  
                                                //new AddTeamMember("Bishal Nepal", TeamMemberDetails[3]),
                                                //new AddTeamMember("Sunil Godar", TeamMemberDetails[4]),                              
                                                new AddTeamMember("Alina Khadka", TeamMemberDetails[0]),
                                                //new AddTeamMember("Shree Khanal", TeamMemberDetails[1]),
                                                new AddTeamMember("Manjushree Ranjitkar", TeamMemberDetails[2]),
                                                new AddTeamMember("Bijay Baniya", TeamMemberDetails[3]),
                                                new AddTeamMember("Raj Thapa", TeamMemberDetails[4]),
                                                
                                                //new AddTeamMember("Ankit Chaudhary", TeamMemberDetails[0]),
                                                //new AddTeamMember("Ishwor Dangol", TeamMemberDetails[1]),
                                                //new AddTeamMember("Dipendra Timilsinar", TeamMemberDetails[2]),
                                                //new AddTeamMember("Bijay Baniya", TeamMemberDetails[3]),
                                                //new AddTeamMember("Raj Thapa", TeamMemberDetails[4]), 
                                            };
            try
            {
                //Can_Add_Project(Username, Password, RememberMe, ProjectName, ProjectID, ProjectType, ProjectKey, ProjectOwner, ProjectManager, StartDate, EndDate, ProjectDescription, CreateProject);
                //Can_Add_Project();
                Can_Search_Project();
                Project.ProjectPage.AddProjectTeam(AddTeamMember);
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //TestResults.ErrorException[7] = ex.ToString();
                //TestResults.Fail++;
            }
        }
        [TestMethod]
        public void Can_Add_Group()
        {
            string[] ProjectNameList = { "Ncell", "Nepali Paisa", "EEC", "Dofe" };
            Group Group = new Group("Services", "Client Products", ProjectNameList, true);
            //string[] ProjectNameList = { "SageFrame", "SageCMS", "Sagever", "Templating", "ListBingo", "Aspx Commerce", "SmartShopy", "BgileApp" };
            //Group Group = new Group("Products", "Inhouse Projects", ProjectNameList, true);
            AddGroup AddGroup = new AddGroup(true, Group);
            try
            {
                //Can_Login(Username, Password, RememberMe);
                Can_Login();
                Browser.GoTo(Project.ProjectPage.Url);
                //Assert.IsTrue(Browser.IsAt(Project.ProjectPage.Header.Text, Project.ProjectPage.Title));
                Project.ProjectPage.AddGroup(AddGroup);
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //TestResults.ErrorException[5] = ex.ToString();
                //TestResults.Fail++;
            }
        }
        [TestMethod]
        public void Can_Search_Project()
        {
            //SearchProject SearchProject = new SearchProject("Inhouse", "All Projects", "SageCMS");
            //SearchProject SearchProject = new SearchProject("Inhouse", "All Projects", "Aspx Commerce");
            SearchProject SearchProject = new SearchProject("Inhouse", "All Projects", "SageFrame");
            //SearchProject SearchProject = new SearchProject("Inhouse", "All Projects", "Sagever");
            //SearchProject SearchProject = new SearchProject("Inhouse", "All Projects", "List Bingo");
            //SearchProject SearchProject = new SearchProject("Inhouse", "All Projects", "BgileApp");
            //SearchProject SearchProject = new SearchProject("Inhouse", "All Projects", "Templating");
            //SearchProject SearchProject = new SearchProject("Inhouse", "All Projects", "SmartShopy");
            //SearchProject SearchProject = new SearchProject("Client", "All Projects", "Ncell");
            //SearchProject SearchProject = new SearchProject("Client", "All Projects", "Nepali Paisa");
            //SearchProject SearchProject = new SearchProject("Client", "All Projects", "Dofe");
            //SearchProject SearchProject = new SearchProject("Client", "All Projects", "EEC");
            try
            {
                //Can_Login(Username, Password, RememberMe);
                Can_Login();
                Browser.GoTo(Project.ProjectPage.Url);
                Project.ProjectPage.SearchProject(SearchProject);
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //TestResults.ErrorException[5] = ex.ToString();
                //TestResults.Fail++;
            }
        }
        [TestMethod]
        public void Can_Set_ProjectStatus()
        {
            string Status = "Live";
            try
            {
                Can_Search_Project();
                Project.ProjectPage.SetProjectStatus(Status);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void Can_Close_Project()
        {
            string[] Task = { "Update Framework", "Archive Session Tracker", "Online Payment" };
            string[] Owner = { "Shree Khanal", "Bijay Baniya", "Ankit Chaudhary" };
            string[] DueDate = { "03/15/2016", "03/25/2016", "03/10/2016" };
            ProjectClosure ProjectClosure = new ProjectClosure(Task, Owner, DueDate, "Future Recommendations");
            try
            {
                Can_Search_Project();
                Project.ProjectPage.ProjectClosure(ProjectClosure); 
            }
            catch( Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void Can_Edit_Project()
        {
            ProjectData EditProject = new ProjectData("SageCMS", "", "Inhouse", "SC", "Alok Pandey", "Shree Khanal", "1/15/2016", "03/15/2016", "LightWeight CMS", true);
            try
            {
                //Can_Search_Project(Username, Password, RememberMe, ProjectType, ProjectStatus, ProjectName);
                Can_Search_Project();
                Project.ProjectPage.EditProject(EditProject);
                //TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //TestResults.ErrorException[5] = ex.ToString();
                //TestResults.Fail++;
            }
        }
        [TestMethod]
        public void Can_Search_Group()
        {
            string GroupName = "Products";
            try
            {
                //Can_Login(Username, Password, RememberMe);
                Can_Login();
                Browser.GoTo(Project.ProjectPage.Url);
                Project.ProjectPage.SearchGroup(GroupName);
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //TestResults.ErrorException[6] = ex.ToString();
                //TestResults.Fail++;
            }
        }
        [TestMethod]
        public void Can_Edit_Group()
        {
            int[] n = { 2, 3 };
            string[] ProjectNameList = { "Templating", "ListBingo" };
            Group Group = new Group("Inhouse Projects", "Inhouse Products", ProjectNameList, true);
            AddGroup addGroup = new AddGroup(false, Group);
            bool[] ConfirmDelete = { false, false, false };
            EditDeleteGroup EditdeleteGroup = new EditDeleteGroup(n[0], addGroup, ConfirmDelete[0]);
            try
            {
                //Can_Search_Group(Username, Password, RememberMe, GroupName);
                Can_Search_Group();
                Project.ProjectPage.EditDeleteGroup(EditdeleteGroup);
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //TestResults.ErrorException[7] = ex.ToString();
                //TestResults.Fail++;
            }
        }
        [TestMethod]
        public void Can_Delete_Group()
        {
            int[] n = { 2, 3 };
            string[] ProjectNameList = { "SageCMS", "Templating" };
            Group Group = new Group("Products", "Inhouse Projects", ProjectNameList, true);
            AddGroup addGroup = new AddGroup(false, Group);
            bool[] ConfirmDelete = { false, false, false };
            EditDeleteGroup EditDeleteGroup = new EditDeleteGroup(n[1], addGroup, ConfirmDelete[0]);
            try
            {
                //Can_Search_Group(Username, Password, RememberMe, GroupName);
                Can_Search_Group();
                Project.ProjectPage.EditDeleteGroup(EditDeleteGroup);
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //TestResults.ErrorException[7] = ex.ToString();
                //TestResults.Fail++;
            }
        }
        [TestMethod]
        public void Can_Add_People()
        {                                 
            People[] people = {
                                  new People( "Alok", "Pandey", "PM", @"‪D:\Personnel\New folder\Photo\alok.jpg", "Report Viewer", true ) ,
                                  new People( "Shree", "Khanal", "PM", @"‪D:\Personnel\New folder\Photo\shree.jpg", "Report Viewer", true ),
                                  new People( "Raj", "Thapa", "QA", @"‪D:\Personnel\New folder\Photo\raj.jpg", "Collaborator", true ),
                                  new People( "Bijay", "Baniya", "TeamLead", @"‪D:\Personnel\New folder\Photo\bijay.jpg", "Project Lead", true ),
                                  new People( "Sheela", "Sharma", "HR", @"‪D:\Personnel\New folder\Photo\sheela.jpg", "Report Viewer", true ),
                                  new People( "ManjuShree", "Ranjitkar", "QA", @"‪D:\Personnel\New folder\Photo\manju.jpg", "Collaborator", true ),
                                  new People( "Alina", "Khadka", "TeamLead", @"‪D:\Personnel\New folder\Photo\alina.jpg", "Collaborator", true ),
                                  new People( "Nischal Man", "Pradhan", "PM", @"‪D:\Personnel\New folder\Photo\nischal.jpg", "Admin", true ),
                                  new People( "Nitesh", "Gorkhali", "PM", @"‪D:\Personnel\New folder\Photo\nitesh.jpg", "Report Viewer", true ),
                                  new People( "Pawan", "Nepal", "PM", @"‪D:\Personnel\New folder\Photo\pawan.jpg", "Project Lead", true ),
                                  new People( "Narendra", "Maharjan", "PM", @"‪D:\Personnel\New folder\Photo\narendra.jpg", "Project Lead", true ),
                                  new People( "Ankit", "Chaudhary", "TeamLead", @"‪D:\Personnel\New folder\Photo\ankit.jpg", "Collaborator", true ),
                                  new People( "Dipendra", "Timilsina", "TeamLead", @"‪D:\Personnel\New folder\Photo\dipendra.jpg", "Collaborator", true ),
                                  new People( "Sunil", "Godar", "QA", @"‪D:\Personnel\New folder\Photo\sunil.jpg", "Member", true ),
                                  new People( "Sujan", "Amatya", "PM", @"‪D:\Personnel\New folder\Photo\sujan.jpg", "Report Viewer", true ),
                                  new People( "Bishal", "Nepal", "TeamLead", @"‪D:\Personnel\New folder\Photo\bishal.jpg", "Project Lead", true ),
                                  new People( "Ishwor", "Dangol", "PM", @"‪D:\Personnel\New folder\Photo\ishwor.jpg", "Report Viewer", true ),
                                  new People("Santosh", "Gupta", "PM", @"‪D:\Personnel\New folder\Photo\santosh.jpg", "Report Viewer", true ),
                                  new People("Harihar", "Pradhan", "PM", @"‪D:\Personnel\New folder\Photo\harihar.jpg", "Report Viewer", true ),
                                  new People("Pritika", "Shrestha", "QA", @"‪D:\Personnel\New folder\Photo\pritika.jpg", "Member", true )
                              };
            AddPeople[] People = {
                                  new AddPeople( people[0], "alok@braindigit.com", "alok", true),
                                  new AddPeople( people[1], "shree@braindigit.com", "shree", true),
                                  new AddPeople( people[2], "raj@braindigit.com", "raj", true),
                                  new AddPeople( people[3], "bijay@braindigit.com", "bijay", true),
                                  new AddPeople( people[4], "sheela@braindigit.com", "sheela", true),
                                  new AddPeople( people[5], "manju@braindigit.com", "manju", true),
                                  new AddPeople( people[6], "alina@braindigit.com", "alina", true),
                                  new AddPeople( people[7], "nischal@braindigit.com", "nischal", true),
                                  new AddPeople( people[8], "nitesh@braindigit.com", "nitesh", true),
                                  new AddPeople( people[9], "pawan@braindigit.com", "pawan", true),
                                  new AddPeople( people[10], "narendra@braindigit.com", "narendra", true),
                                  new AddPeople( people[11], "ankit@braindigit.com", "ankit", true),
                                  new AddPeople( people[12], "dipendra@braindigit.com", "dipendra", true),
                                  new AddPeople( people[13], "sunil@braindigit.com", "sunil", true),
                                  new AddPeople( people[14], "sujan@braindigit.com", "sujan", true),
                                  new AddPeople( people[15], "bishal@braindigit.com", "bishal", true),
                                  new AddPeople( people[16], "ishwor@braindigit.com", "ishwor", true),
                                  new AddPeople( people[17], "santosh@braindigit.com", "sanotsh", true),
                                  new AddPeople( people[18], "harihar@braindigit.com", "harihar", true),
                                  new AddPeople( people[19], "pritika@braindigit.com", "pritika", true) 
                              };
            try
            {
                //Can_Login(Username, Password, RememberMe);
                Can_Login();
                Browser.GoTo(Settings.SettingsPage.Url);              
                Settings.SettingsPage.AddPeople(People);
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //TestResults.ErrorException[7] = ex.ToString();
                //TestResults.Fail++;
            }
        }
        [TestMethod]
        public void Can_Search_People()
        {
            SearchPeople SearchPeople = new SearchPeople("Active", "Bijay");
            try
            {
                //Can_Login(Username, Password, RememberMe);
                Can_Login();
                Browser.GoTo(Settings.SettingsPage.Url);
                Settings.SettingsPage.SearchPeople(SearchPeople);
                //TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //TestResults.ErrorException[7] = ex.ToString();
                //TestResults.Fail++;
            }
        }
        [TestMethod]
        public void Can_Edit_People()
        {
            People[] people = {
                                  new People("Bijay", "Baniya", "Project Lead", @"C:\Users\RajKumar-PC\Documents\Downloads\goat tatto.png", "Report Viewer", true),
                                  new People("Shree", "Khanal", "Report Viewer", @"C:\Users\RajKumar-PC\Documents\Downloads\goat tatto.png", "Report Viewer", true),
                                  new People("Alok", "Pandey", "Report Viewer", @"C:\Users\RajKumar-PC\Documents\Downloads\goat tatto.png", "Report Viewer", true)
                              };
            EditPeople[] PeopleData = {
                                          new EditPeople( "Edit", true, people[0], "TestMethodProfileSummary1", true),
                                          new EditPeople( "Delete", false, people[1], "TestMethodProfileSummary2", true),
                                          new EditPeople( "Edit", true, people[2], "TestMethodProfileSummary3", true)
                                      };
            try
            {
                //Can_Search_People(Username, Password, RememberMe, status, user);
                //Can_Search_People();
                Can_Login();
                Browser.GoTo(Settings.SettingsPage.Url);
                Settings.SettingsPage.EditDelete(PeopleData);
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //TestResults.ErrorException[7] = ex.ToString();
                //TestResults.Fail++;
            }
        }
        [TestMethod]
        public void Can_Set_Targets()
        {
            Target[] Target = 
            {
                new Target("04/01/2017 To 04/01/2018", "5", "Quarter", "3", "Release", "50", "Year", "4", "Release", "30", "Month", "10", "Year", "80", "Quarter", true),
                //new Target("01/01/2017 To 01/01/2018", "6", "Semi Year", "2", "Year", "40", "Release", "5", "Year", "60", "Quarter", "30", "Year", "80", "Year", true),
                //new Target("01/01/2018 To 01/01/2019", "2", "Quarter", "4", "Release", "30", "Year", "8", "Release", "40", "Year", "20", "Release", "80", "Quarter", true),
            };

            try
            {
                //Can_Login(Username, Password, RememberMe);
                Can_Login();
                Browser.GoTo(Settings.SettingsPage.Url);
                Settings.SettingsPage.TargetOperations(Target);
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //TestResults.ErrorException[7] = ex.ToString();
                //TestResults.Fail++;
            }
        }
        [TestMethod]
        public void Can_Do_Work_Operations()
        {
            string[] WorkDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            Holiday[] Holidays = {
                                 new Holiday("Dashain", "11/01/2016", "All", "Full"),
                                 new Holiday("Teej", "08/01/2016", "Female", "Full"),
                                 new Holiday("Tihar", "11/28/2016", "All", "Full") 
                                 };
            Work Work = new Work(true, "01/01/2016", "01/01/2017", true, "01/01/2016 To 01/01/2017", WorkDays, "8", Holidays, "01/01/2016", "04/01/2016", "04/01/2016", "07/01/2016", "07/01/2016", "10/01/2016", "10/01/2016", "01/01/2017");
            try
            {
                //Can_Login(Username, Password, RememberMe);
                Can_Login();
                Browser.GoTo(Settings.SettingsPage.Url);
                Settings.SettingsPage.WorkOperations(Work);
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //TestResults.ErrorException[7] = ex.ToString();
                //TestResults.Fail++;
            }
        }
        [TestMethod]
        public void Can_Do_Product_Plan()
        {
            //ProductPlan ProductPlan = new ProductPlan("Aspx Commerce", "Ecommerce Made Easy", "Magento", "BgileApp");
            //ProductPlan ProductPlan = new ProductPlan("SageCMS", "Flexible LightWeight CMS", "WordPress", "BgileApp");
            //ProductPlan ProductPlan = new ProductPlan("SmartShopy", "Ecommerce with SaaS", "Ebay", "BgileApp");
            //ProductPlan ProductPlan = new ProductPlan("SageFrame", "OpenSource .NET CMS", "Sagever", "BgileApp");
            ProductPlan ProductPlan = new ProductPlan("NCell", "Connecting People", "NTC", "BgileApp");
            //ProductPlan ProductPlan = new ProductPlan("Nepali Paisa", "Stock Market Exchange App", "Nepse", "BgileApp");
            //ProductPlan ProductPlan = new ProductPlan("Sagever", "Paid Version Of SageFrame with Extra Features and Support Available", "SageCMS", "BgileApp");
            //ProductPlan ProductPlan = new ProductPlan("Dofe", "Web and Desktop App for Department of Foreign Employement", "HMG", "BgileApp");
            //ProductPlan ProductPlan = new ProductPlan("Templating", "Themes for SageFrame", "WordPress Themes", "BgileApp");
            //ProductPlan ProductPlan = new ProductPlan("List Bingo", "Joomla Extension", "Magento", "BgileApp");
            //ProductPlan ProductPlan = new ProductPlan("EEC", "Environmental Emergencies Center", "WHO", "BgileApp");
            //ProductPlan ProductPlan = new ProductPlan("BgileApp", "App For Bgile Methodologies", "Hrision", "SageFrame");
            try
            {
                Can_Search_Project();
                Project.ProjectPage.ClickProjectLink("Plan");
                Browser.SwitchWindow();
                Project.ProjectPage.ClickPlanMenu("Product");
                Project.ProjectPage.ProductPlan(ProductPlan);
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //TestResults.ErrorException[7] = ex.ToString();
                //TestResults.Fail++;
            }
        }
        [TestMethod]
        public void Can_Add_ReleasePlan()
        {
            //ReleaseGoal ReleaseGoal = new ReleaseGoal("Aspx Commerce 3.0", "Online Payment", "E-sewa added", true);
            //ReleaseTimeLines ReleaseTimeLines = new ReleaseTimeLines("01/16/2016", "02/16/2016", true, "02/17/2016", "02/30/2016", "03/01/2016", "5", "100", "20", "10", true);
            //DOD[] SprintDOD = {
            //                      new DOD("Counter Updated", "Ishwor Dangol"),
            //                      new DOD("Functionality", "Raj Thapa"),                                 
            //                      new DOD("Design Reviewed", "Bishal Nepal")
            //                  };
            //DOD[] DODRelease = {
            //                      new DOD("Functionality", "Raj Thapa"),
            //                      new DOD("Code Reviewed", "Alok Pandey"),                                 
            //                      new DOD("Developer", "Ankit Chaudhary")
            //                   };
            //ReleaseDOD ReleaseDOD = new ReleaseDOD(SprintDOD, DODRelease, true);
            //Activities[] activities = {
            //                              new Activities("Content", "Content", "Pritika Shrestha", "02/25/2016"),
            //                              new Activities("Design", "Design", "Manjushree Ranjitkar", "02/27/2016")                                        
            //                          };
            //Activity Activity = new Activity(activities, true);
            //ReleaseDetails ReleaseDetails = new ReleaseDetails(ReleaseGoal, ReleaseTimeLines, ReleaseDOD, Activity);
            //AddRelease AddRelease = new AddRelease(true, ReleaseDetails);

            //ReleaseGoal ReleaseGoal = new ReleaseGoal("SageFrame 3.6", "Optimized CSS and JS with Role based Permission and Session Tracker", "Upgraded Framework", true);
            //ReleaseTimeLines ReleaseTimeLines = new ReleaseTimeLines("08/01/2016", "09/10/2016", true, "09/10/2016", "09/30/2016", "12/28/2016", "5", "100", "20", "10", true);
            //DOD[] SprintDOD = {
            //                      new DOD("Counter Updated", "Shree Khanal"),
            //                      new DOD("Functionality", "Raj Thapa"),                                 
            //                      new DOD("Design Reviewed", "Manjushree Ranjitkar")
            //                  };
            //DOD[] DODRelease = {
            //                      new DOD("Functionality", "Raj Thapa"),
            //                      new DOD("Code Reviewed", "Alok Pandey"),                                 
            //                      new DOD("Developer", "Bijay Baniya")
            //                   };
            //ReleaseDOD ReleaseDOD = new ReleaseDOD(SprintDOD, DODRelease, true);
            //Activities[] activities = {
            //                              new Activities("Content", "GuideLines", "Pritika Shrestha", "12/28/2016"),
            //                              new Activities("Content", "Product Requirement", "Pritika Shrestha", "12/28/2016")                                        
            //                          };
            //Activity Activity = new Activity(activities, true);
            //ReleaseDetails ReleaseDetails = new ReleaseDetails(ReleaseGoal, ReleaseTimeLines, ReleaseDOD, Activity);
            //AddRelease AddRelease = new AddRelease(true, ReleaseDetails);

            ReleaseGoal ReleaseGoal = new ReleaseGoal("NCell", "FromBuilder Upgraded", "Upgraded Framework", true);
            ReleaseTimeLines ReleaseTimeLines = new ReleaseTimeLines("01/29/2016", "02/29/2016", true, "03/1/2016", "03/08/2016", "03/09/2016", "6", "50", "5", "2", true);
            DOD[] SprintDOD = {
                                  new DOD("Counter Updated", "Shree Khanal"),
                                  new DOD("Functionality", "Raj Thapa"),                                 
                                  new DOD("Design Reviewed", "Manjushree Ranjitkar")
                              };
            DOD[] DODRelease = {
                                  new DOD("Functionality", "Raj Thapa"),
                                  new DOD("Code Reviewed", "Alok Pandey"),                                 
                                  new DOD("Developer", "Bijay Baniya")
                               };
            ReleaseDOD ReleaseDOD = new ReleaseDOD(SprintDOD, DODRelease, true);
            Activities[] activities = {
                                          new Activities("Content", "GuideLines", "Pritika Shrestha", "12/28/2016"),
                                          new Activities("Content", "Project Description", "Pritika Shrestha", "12/28/2016")                                        
                                      };
            Activity Activity = new Activity(activities, true);
            ReleaseDetails ReleaseDetails = new ReleaseDetails(ReleaseGoal, ReleaseTimeLines, ReleaseDOD, Activity);
            AddRelease AddRelease = new AddRelease(true, ReleaseDetails);
            try
            {
                Can_Search_Project();
                Project.ProjectPage.ClickProjectLink("Plan");
                Browser.SwitchWindow();
                Project.ProjectPage.ClickPlanMenu("Release");
                Project.ProjectPage.AddRelease(AddRelease);
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //TestResults.ErrorException[7] = ex.ToString();
                //TestResults.Fail++;
            }
        }
        [TestMethod]
        public void Can_Edit_ReleasePlan()
        {
            ReleaseGoal ReleaseGoal = new ReleaseGoal("NCell", "FromBuilder Upgraded", "Upgraded Framework", true);
            ReleaseTimeLines ReleaseTimeLines = new ReleaseTimeLines("01/29/2016", "02/29/2016", true, "03/1/2016", "03/08/2016", "03/09/2016", "6", "50", "5", "2", true);
            DOD[] SprintDOD = {
                                  new DOD("Counter Updated", "Shree Khanal"),
                                  new DOD("Functionality", "Raj Thapa"),                                 
                                  new DOD("Design Reviewed", "Manjushree Ranjitkar")
                              };
            DOD[] DODRelease = {
                                  new DOD("Functionality", "Raj Thapa"),
                                  new DOD("Code Reviewed", "Alok Pandey"),                                 
                                  new DOD("Developer", "Bijay Baniya")
                               };
            ReleaseDOD ReleaseDOD = new ReleaseDOD(SprintDOD, DODRelease, true);
            Activities[] activities = {
                                          new Activities("Content", "GuideLines", "Pritika Shrestha", "12/28/2016"),
                                          new Activities("Content", "Product Requirement", "Pritika Shrestha", "12/28/2016")                                        
                                      };
            Activity Activity = new Activity(activities, true);
            ReleaseDetails ReleaseDetails = new ReleaseDetails(ReleaseGoal, ReleaseTimeLines, ReleaseDOD, Activity);
            AddRelease AddRelease = new AddRelease(true, ReleaseDetails);
            EditRelease EditRelease = new EditRelease(1, AddRelease);
            try
            {
                Can_Search_Project(); 
                Project.ProjectPage.ClickProjectLink("Plan");
                Browser.SwitchWindow();
                Project.ProjectPage.ClickPlanMenu("Release");
                Project.ProjectPage.EditReleaseDetails(EditRelease);
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //TestResults.ErrorException[7] = ex.ToString();
                //TestResults.Fail++;
            }
        }
        [TestMethod]
        public void Can_Set_ReleaseStatus()
        {
            string Status = "In Development";
            ReleaseOperation ReleaseOperation = new ReleaseOperation(0, "Release Note");
            try
            {
                Can_Search_Project();
                Project.ProjectPage.ClickProjectLink("Plan");
                Browser.SwitchWindow(); 
                Project.ProjectPage.ClickPlanMenu("Release");
                Project.ProjectPage.ReleaseOperation(ReleaseOperation);
                Project.ProjectPage.SetReleaseStatus(Status);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void Can_Add_Sprint()
        {
            int[] N = { 1, 2, 3 };
            Sprint[] sprint = {
                                  new Sprint("Sprint 1", "Aspx Commerce 3.0", "01/10/2016", "01/24/2016", "09:00", "Bijay Baniya", "Login And Register", true, N, 0),
                                  new Sprint("Sprint2", "Aspx Commerce 3.0", "01/25/2016", "02/09/2016", "09:00", "Bijay Baniya", "Upgrade Framework", true, N, 0),
                                  new Sprint("Sprint 3", "Aspx Commerce 3.0", "02/09/2016", "02/23/2016", "09:00", "Bijay Baniya", "Online Payment Included", true, N, 0)
                              };
            try
            {
                Can_Add_Story();
                Project.ProjectPage.AddSprint(sprint);
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //TestResults.ErrorException[7] = ex.ToString();
                //TestResults.Fail++;
            }
        }
        [TestMethod]
        public void Can_Edit_Sprint()
        {
            string[] Release = { "Aspx Commerce 2.7", "Aspx Commerce 2.7", "Aspx Commerce 2.7" };
            int[] rowno = { 0, 2, 3 };
            int[] n = { 1, 2, 3 };
            MemberOnLeave[] MemberOnLeave = {
                                                new MemberOnLeave("Bijay Baniya", "09/10/2016", "Full"),
                                                new MemberOnLeave("Ankit Chaudhary", "10/10/2016", "Full"),
                                                new MemberOnLeave("Dipendra Timilsina", "09/15/2016", "Full"),
                                            };
            Sprint[] sprint = {
                                  new Sprint("SprintName1", "Aspx Commerce 2.7", "09/10/2016", "09/30/2016", "09:00", "Bijay Baniya", "SprintGoal1", true, n, 0),
                                  new Sprint("SprintName2", "Aspx Commerce 2.7", "10/00/2016", "10/20/2016", "09:00", "Bishal Nepal", "SprintGoal2", true, n, 0),
                                  new Sprint("SprintName3", "Aspx Commerce 2.7", "10/20/2016", "11/10/2016", "09:00", "Shree Khanal", "SprintGoal3", false, n, 0)
                              };
            EditSprint EditSprint = new EditSprint(Release, rowno, sprint);
            try
            {
                Can_Search_Project();
                Project.ProjectPage.ClickProjectLink("Plan");
                Browser.SwitchWindow();
                Project.ProjectPage.ClickPlanMenu("Sprint");
                Project.ProjectPage.EditSprint(EditSprint);
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //TestResults.ErrorException[7] = ex.ToString();
                //TestResults.Fail++;
            }
        }
        [TestMethod]
        public void Can_Add_Story()
        {
            //AddStory AddStory = new AddStory(false, "Login and Register", "Can create users", "5", "Medium", "As a User", "Feature", "SageFrame 3.6", "Alina Khadka", "12/12/2016", "1", "Tag", true);
            //AddStory AddStory = new AddStory(false, "Online Payment", "Perform Online Transactions", "8", "High", "As a User", "Feature", "SageFrame 3.6", "Sunil Godar", "12/12/2016", "1", "Tag", true);
            AddStory AddStory = new AddStory(false, "JS and CSS Optimization", "Optimized JS and CSS", "8", "High", "As a User", "Feature", "SageFrame 3.6", "Bijay Baniya", "12/12/2016", "1", "Tag", true);
            //AddStory AddStory = new AddStory(false, "CMS Upgrader", "Upgrade CMS", "8", "Medium", "As a User", "Feature", "SageFrame 3.6", "Shree Khanal", "12/12/2016", "1", "Tag", true);
            //AddStory AddStory = new AddStory(false, "Archive Session Tracker", "Perform Session Archived", "5", "Medium", "As a User", "Feature", "SageFrame 3.6", "Bijay Baniya", "12/12/2016", "1", "Tag", true);
            //AddStory AddStory = new AddStory(false, "CleanUp Script", "Clean Unwanted Data", "3", "Low", "As a User", "Feature", "SageFrame 3.6", "Raj Thapa", "12/12/2016", "1", "Tag", true);
            //AddStory AddStory = new AddStory(false, "Role Based Permission", "Permission Based On Roles", "3", "Low", "As a User", "Feature", "SageFrame 3.6", "Alina Khadka", "12/12/2016", "1", "Tag", true);
            //AddStory AddStory = new AddStory(false, "License Implementation", "License Features", "5", "Medium", "As a User", "Feature", "SageFrame 3.6", "Bijay Baniya", "12/12/2016", "1", "Tag", true);
            try
            {
                Can_Search_Project();
                Project.ProjectPage.ClickProjectLink("Plan");
                Browser.SwitchWindow();
                Project.ProjectPage.ClickProjectMenu("BackLog");
                Project.ProjectPage.AddStory(AddStory);
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //TestResults.ErrorException[8] = ex.ToString();
                //TestResults.Fail++;
            }
        }
        [TestMethod]
        public void Can_Edit_Story()
        {
            AddStory AddStory = new AddStory(true, "Login and Register", "Can create users", "2", "Medium", "As a QA", "Feature", "Aspx Commerce3.0", "Ankit Chaudhary", "12/12/2016", "1", "Tag", false);
            //EditStories EditStories = new EditStories(2, AddStory);
            int EditStoryNo = 2;
            SearchStory SearchStory = new SearchStory("Online Payment", false, false);
            try
            {
                Can_Search_Project();
                Project.ProjectPage.ClickProjectLink("Plan"); 
                Project.ProjectPage.ClickProjectMenu("BackLog");
                Project.ProjectPage.SearchStories(SearchStory);
                Project.ProjectPage.EditStories(EditStoryNo);
                Project.ProjectPage.AddStory(AddStory);
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //TestResults.ErrorException[9] = ex.ToString();
                //TestResults.Fail++;
            }
        }
        [TestMethod]
        public void Story_SideMenu()
        {
            //SearchStory SearchStory = new SearchStory("TestMethod", false, false);
            FillTaskDetails FillTaskDetails = new FillTaskDetails("Online Payment", "Online Payment Integrated", "10", "Develop", "Ankit Chaudhary", "12/12/2016", "8", "4", "To-Do", "Save");
            //FillTaskDetails FillTaskDetails = new FillTaskDetails("Registration", "Registration Functionality", "10", "Develop", "Alina Khadka", "12/12/2016", "8", "4", "To-Do", "Save");
            TaskOperation TaskOperation = new TaskOperation(1, true, 2, FillTaskDetails, false);
            StorySideMenu StorySideMenu = new StorySideMenu("Task", TaskOperation, @"D:\Personnel\New folder\Photo\shakti.jpg", "TestMethodComment");
            try
            {
                Can_Search_Project();
                Project.ProjectPage.ClickProjectLink("Plan"); 
                Project.ProjectPage.ClickProjectMenu("BackLog");
                //Project.ProjectPage.SearchStories(SearchStory);
                Project.ProjectPage.StorySideMenu(StorySideMenu);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void Board_TaskOperation()
        {
            InProgressTo inprogressto = new InProgressTo("15", "5");
            TaskProcess taskprocess = new TaskProcess("To-Do:In-Progress", 0, 1, "10", inprogressto, "12/12/2016");
            try
            {
                Can_Search_Project();
                Project.ProjectPage.ClickProjectLink("Plan"); 
                Project.ProjectPage.ClickProjectMenu("Board");
                Project.ProjectPage.TaskProcess(taskprocess);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        public void Can_AssignTask()
        {
            FillTaskDetails FillTaskDetails = new FillTaskDetails("Registration", "Registration Functionality", "10", "Develop", "Raj Thapa", "12/12/2016", "8", "4", "To-Do", "Save");
            TaskOperation TaskOperation = new TaskOperation(1, true, 2, FillTaskDetails, false);
            try
            {
                Can_Search_Project();
                Project.ProjectPage.ClickProjectLink("Plan"); 
                Project.ProjectPage.ClickProjectMenu("BackLog");
                
                //Project.ProjectPage.TaskOperation(TaskOperation); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestCleanup]
        public void TearDown()
        {
            Browser.Teardown();
        }
    }
}
