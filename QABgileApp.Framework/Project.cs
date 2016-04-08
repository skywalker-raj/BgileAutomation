using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
namespace QABgileApp.Framework
{
    #region
    public class GetStatus
    {
        public IWebElement Color { get; set; }
        public string Status { get; set; }
        public GetStatus(IWebElement color, string status)
        {
            Color = color;
            Status = status;
        }
    }
    public class SearchProject
    {
        public string ProjectType { get; set; }
        public string ProjectStatus { get; set; }
        public string ProjectName { get; set; }
        public SearchProject(string projectType, string projectStatus, string projectName)
        {
            ProjectType = projectType;
            ProjectStatus = projectStatus;
            ProjectName = projectName;
        }
    }
    public class SearchTeamMember
    {
        public string Member { get; set; }
        public string MemberStatus { get; set; }
        public SearchTeamMember(string member, string memberstatus)
        {
            Member = member;
            MemberStatus = memberstatus;
        }
    }
    public class TeamMemberDetails
    {
        public string Designation { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string AllotedHours { get; set; }
        public bool IsActive { get; set; }
        public bool IsPrimary { get; set; }
        public bool Save { get; set; }
        public TeamMemberDetails(string designation, string startdate, string enddate, string allotedhours, bool isacitve, bool isprimary, bool save)
        {
            Designation = designation;
            StartDate = startdate;
            EndDate = enddate;
            AllotedHours = allotedhours;
            IsActive = isacitve;
            IsPrimary = isprimary;
            Save = save;
        }
    }
    public class AddTeamMember
    {
        public string TeamMember { get; set; }
        public TeamMemberDetails TeamMemberDetails { get; set; }
        public AddTeamMember(string teamMember, TeamMemberDetails teammemberdetails)
        {
            TeamMember = teamMember;
            TeamMemberDetails = teammemberdetails;
        }
    }
    public class EditProjectTeam
    {
        public SearchTeamMember SearchTeamMember { get; set; }
        public TeamMemberDetails TeamMemberDetails { get; set; }
        public EditProjectTeam(SearchTeamMember searchteammember, TeamMemberDetails teammemberdetails)
        {
            SearchTeamMember = searchteammember;
            TeamMemberDetails = teammemberdetails;
        }
    }
    public class DeleteProjectTeam
    {
        public SearchTeamMember SearchTeamMember { get; set; }
        public bool ConfirmDelete { get; set; }
        public DeleteProjectTeam(SearchTeamMember searchteammember, bool confirmdelete)
        {
            SearchTeamMember = searchteammember;
            ConfirmDelete = confirmdelete;
        }
    }
    public class ProjectClosure
    {
        public string[] Task { get; set; }
        public string[] Owner { get; set; }
        public string[] DueDate { get; set; }
        public string FutureRecommendation { get; set; }
        public ProjectClosure(string[] task, string[] owner, string[] dueDate, string futureRecommendation)
        {
            Task = task;
            Owner = owner;
            DueDate = dueDate;
            FutureRecommendation = futureRecommendation;
        }
    }
    public class ProductPlan
    {
        public string ProductName { get; set; }
        public string ProductVision { get; set; }
        public string DevelopmentScope { get; set; }
        public string OutOfScope { get; set; }
        public ProductPlan(string productname, string productvision, string developmentscope, string outofscope)
        {
            ProductName = productname;
            ProductVision = productvision;
            DevelopmentScope = developmentscope;
            OutOfScope = outofscope;
        }
    }
    public class DOD
    {
        public string DODselect { get; set; }
        public string Owner { get; set; }
        public DOD(string dODselect, string owner)
        {
            Owner = owner;
            DODselect = dODselect;
        }
    }
    public class ReleaseDOD
    {
        public DOD[] SDOD { get; set; }
        public DOD[] RDOD { get; set; }
        public bool SaveDOD { get; set; }
        public ReleaseDOD(DOD[] sDOD, DOD[] rDOD, bool saveDOD)
        {
            SDOD = sDOD;
            RDOD = rDOD;
            SaveDOD = saveDOD;
        }
    }
    public class ReleaseTimeLines
    {
        public string DevelopmentStartDate { get; set; }
        public string DevelopmentEndDate { get; set; }
        public bool HardeningRequired { get; set; }
        public string HardeningStartDate { get; set; }
        public string HardeningEndDate { get; set; }
        public string PlanReleaseDate { get; set; }
        public string StoriesNo { get; set; }
        public string StoryPoint { get; set; }
        public string EstimatedVelocity { get; set; }
        public string PlannedsprintNo { get; set; }
        public bool SaveReleaseTimeline { get; set; }
        public ReleaseTimeLines(string developmentStartDate, string developmentEndDate, bool hardeningRequired, string hardeningStartDate, string hardeningEndDate, string planReleaseDate, string storiesNo, string storyPoint, string estimatedVelocity, string plannedsprintNo, bool saveReleaseTimeline)
        {
            DevelopmentStartDate = developmentStartDate;
            DevelopmentEndDate = developmentEndDate;
            HardeningRequired = hardeningRequired;
            HardeningStartDate = hardeningStartDate;
            HardeningEndDate = hardeningEndDate;
            PlanReleaseDate = planReleaseDate;
            StoriesNo = storiesNo;
            StoryPoint = storyPoint;
            EstimatedVelocity = estimatedVelocity;
            PlannedsprintNo = plannedsprintNo;
            SaveReleaseTimeline = saveReleaseTimeline;
        }
    }
    public class ReleaseGoal
    {
        public string Name { get; set; }
        public string Goal { get; set; }
        public string Note { get; set; }
        public bool SaveGoal { get; set; }
        public ReleaseGoal(string name, string goal, string note, bool saveGoal)
        {
            Name = name;
            Goal = goal;
            Note = note;
            SaveGoal = saveGoal;
        }
    }
    public class ReleaseDetails
    {
        public ReleaseGoal ReleaseGoal { get; set; }
        public ReleaseTimeLines ReleaseTimeLines { get; set; }
        public ReleaseDOD ReleaseDOD { get; set; }
        public Activity Activity { get; set; }
        public ReleaseDetails(ReleaseGoal releasegoal, ReleaseTimeLines releasetimelines, ReleaseDOD releasedod, Activity activity)
        {
            ReleaseGoal = releasegoal;
            ReleaseTimeLines = releasetimelines;
            ReleaseDOD = releasedod;
            Activity = activity;
        }
    }
    public class AddRelease
    {
        public bool ReleaseCheck { get; set; }
        public ReleaseDetails ReleaseDetails { get; set; }
        public AddRelease(bool releasecheck, ReleaseDetails releasedetails)
        {
            ReleaseCheck = releasecheck;
            ReleaseDetails = releasedetails;
        }
    }
    public class EditRelease
    {
        public int rowno { get; set; }
        public AddRelease AddRelease { get; set; }
        public EditRelease(int Rowno, AddRelease addrelease)
        {
            rowno = Rowno;
            AddRelease = addrelease;
        }
    }
    public class Sprint
    {
        public string SprintName { get; set; }
        public string Release { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string StandUpMeetingTime { get; set; }
        public string BackUpScrumMaster { get; set; }
        public string SprintGoal { get; set; }
        public bool Save { get; set; }
        public int[] N { get; set; }
        public int M { get; set; }
        public Sprint(string sprintname, string release, string startdate, string enddate, string standupmeeting, string backupscrummaster, string sprintgoal, bool save, int[] n, int m)
        {
            SprintName = sprintname;
            Release = release;
            StartDate = startdate;
            EndDate = enddate;
            StandUpMeetingTime = standupmeeting;
            BackUpScrumMaster = backupscrummaster;
            SprintGoal = sprintgoal;
            Save = save;
            N = n;
            M = m;
        }
    }
    public class EditSprint
    {
        public string[] Release { get; set; }
        public int[] rowno { get; set; }
        public Sprint[] Sprint { get; set; }
        
        public EditSprint(string[] release, int[] Rowno, Sprint[] sprint)
        {
            Release = release;
            rowno = Rowno;
            Sprint = sprint;
        }

    }
    public class Activities
    {
        public string Category { get; set; }
        public string Activity { get; set; }
        public string Owner { get; set; }
        public string DueDate { get; set; }
        public Activities(string category, string activity, string owner, string duedate)
        {
            Category = category;
            Activity = activity;
            Owner = owner;
            DueDate = duedate;
        }
    }
    public class Activity
    {
        public Activities[] Activities { get; set; }
        public bool SaveActivity { get; set; }
        public Activity(Activities[] activities, bool saveActivity)
        {
            Activities = activities;
            SaveActivity = saveActivity;
        }
    }
    public class ProjectData
    {
        public string ProjectName { get; set; }
        public string ProjectID { get; set; }
        public string ProjectType { get; set; }
        public string ProjectKey { get; set; }
        public string ProjectOwner { get; set; }
        public string ProjectManager { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string ProjectDescription { get; set; }
        public bool CreateProject { get; set; }
        public ProjectData(string projectName, string projectID, string projectType, string projectKey, string projectOwner, string projectManager, string startDate, string endDate, string projectDescription, bool createProject)
        {
            ProjectName = projectName;
            ProjectID = projectID;
            ProjectType = projectType;
            ProjectKey = projectKey;
            ProjectOwner = projectOwner;
            ProjectManager = projectManager;
            StartDate = startDate;
            EndDate = endDate;
            ProjectDescription = projectDescription;
            CreateProject = createProject;
        }
    }
    public class Group
    {
        public string GroupName { get; set; }
        public string GroupDescription { get; set; }
        public string[] ProjectNameList { get; set; }
        public bool CreateGroup { get; set; }
        public Group(string groupName, string groupDescription, string[] projectNameList, bool createGroup)
        {
            GroupName = groupName;
            GroupDescription = groupDescription;
            ProjectNameList = projectNameList;
            CreateGroup = createGroup;
        }
    }
    public class AddGroup
    {
        public bool Add { get; set; }
        public Group Group { get; set; }
        public AddGroup(bool add, Group group)
        {
            Add = add;
            Group = group;
        }
    }
    public class EditDeleteGroup
    {
        public int n { get; set; }
        public AddGroup AddGroup { get; set; }
        public bool ConfirmDelete { get; set; }
        public EditDeleteGroup(int no, AddGroup addgroup, bool confirmdelete)
        {
            n = no;
            AddGroup = addgroup;
            ConfirmDelete = confirmdelete;
        }
    }
    public class FilterTasks
    {
        public string TaskView { get; set; }
        public bool ShowMine { get; set; }
        public string TaskStatus { get; set; }
        public FilterTasks(string taskview, bool showmine, string taskstatus)
        {
            TaskView = taskview;
            ShowMine = showmine;
            TaskStatus = taskstatus;
        }
    }
    public class CloseSprint
    {
        public string SprintEndDate { get; set; }
        public bool Close { get; set; }
        public CloseSprint(string sprintenddate, bool close)
        {
            SprintEndDate = sprintenddate;
            Close = close;
        }
    }
    public class AddStory
    {
        public bool Epic { get; set; }
        public string StoryName { get; set; }
        public string ConditionOfSatisfaction { get; set; }
        public string StoryPoints { get; set; }
        public string Priority { get; set; }
        public string Theme { get; set; }
        public string StoryType { get; set; }
        public string Release { get; set; }
        public string Assign { get; set; }
        public string DueDate { get; set; }
        public string Dependencies { get; set; }
        public string Tag { get; set; }
        public bool AddNewStory { get; set; }
        public AddStory(bool epic, string storyname, string conditionofsatisfaction, string storypoints, string priority, string theme, string storytype, string release, string assign, string duedate, string dependencies, string tag, bool addnewstory)
        {
            Epic = epic;
            StoryName = storyname;
            ConditionOfSatisfaction = conditionofsatisfaction;
            StoryPoints = storypoints;
            Priority = priority;
            Theme = theme;
            StoryType = storytype;
            Release = release;
            Assign = assign;
            DueDate = duedate;
            Dependencies = dependencies;
            Tag = tag;
            AddNewStory = addnewstory;
        }
    }
    public class StoryOperations
    {
        public int StoryNo { get; set; }
        public string Operation { get; set; }
        public StoryOperations(int storyno, string operation)
        {
            StoryNo = storyno;
            Operation = operation;
        }
    }
    public class FillTaskDetails
    {
        public string TaskSummary { get; set; }
        public string TaskDescription { get; set; }
        public string TaskEstimate { get; set; }
        public string TaskCategory { get; set; }
        public string TaskAssigne { get; set; }
        public string TaskDueDate { get; set; }
        public string TaskActualHour { get; set; }
        public string BugFixingHours { get; set; }
        public string TaskStatus { get; set; }
        public string SaveSettings { get; set; }
        public FillTaskDetails(string tasksummary, string taskdescription, string taskestimate, string taskcategory, string taskassigne, string taskduedate, string taskactualhour, string bugfixinghours, string taskstatus, string savesettings)
        {
            TaskSummary = tasksummary;
            TaskDescription = taskdescription;
            TaskEstimate = taskestimate;
            TaskCategory = taskcategory;
            TaskAssigne = taskassigne;
            TaskDueDate = taskduedate;
            TaskActualHour = taskactualhour;
            BugFixingHours = bugfixinghours;
            TaskStatus = taskstatus;
            SaveSettings = savesettings;
        }
    }
    public class TaskOperation
    {
        public int Storyno { get; set; }
        public bool TaskAdd { get; set; }
        public int Taskno { get; set; }
        public FillTaskDetails FillTaskDetails { get; set; }
        public bool TaskDelete { get; set; }
        public TaskOperation(int storyno, bool taskadd, int taskno, FillTaskDetails filltaskdetails, bool taskdelete)
        {
            Storyno = storyno;
            TaskAdd = taskadd;
            Taskno = taskno;
            FillTaskDetails = filltaskdetails;
            TaskDelete = taskdelete;
        }
    }
    public class SearchStory
    {
        public string Story { get; set; }
        public bool Epic { get; set; }
        public bool MyStory { get; set; }
        public SearchStory(string story, bool epic, bool mystory)
        {
            Story = story;
            Epic = epic;
            MyStory = mystory;
        }
    }
    public class GetEditDelete
    {
        public int No { get; set; }
        public string Action { get; set; }
        public GetEditDelete(int no, string action)
        {
            No = no;
            Action = action;
        }
    }
    public class EditDeleteTheme
    {
        public GetEditDelete GetEditDelete { get; set; }
        public string Theme { get; set; }
        public bool UpdateDelete { get; set; }
        public EditDeleteTheme(GetEditDelete geteditdelete, string theme, bool updatedelete)
        {
            GetEditDelete = geteditdelete;
            Theme = theme;
            UpdateDelete = updatedelete;
        }
    }
    public class CreateSprint
    {
        public int[] N { get; set; }
        public Sprint Sprint { get; set; }
        public CreateSprint(int[] n, Sprint sprint)
        {
            N = n;
            Sprint = sprint;
        }
    }
    //public class EditStories
    //{
    //    public int StoryNo { get; set; }
    //    public AddStory NewStory { get; set; }
    //    public EditStories(int storyno, AddStory newstory)
    //    {
    //        StoryNo = storyno;
    //        NewStory = newstory;
    //    }
    //}
    public class InProgressTo
    {
        public string TaskHours { get; set; }
        public string BugFixingHours { get; set; }
        public InProgressTo(string taskhours, string bugfixinghours)
        {
            TaskHours = taskhours;
            BugFixingHours = bugfixinghours;
        }
    }
    public class TaskProcess
    {
        public string Movement { get; set; }
        public int StoryNo { get; set; }
        public int TaskNo { get; set; }
        public string TestHours { get; set; }
        public InProgressTo InProgressTo { get; set; }
        public string SprintCloseDate { get; set; }
        public TaskProcess(string movement, int storyno, int taskno, string testhours, InProgressTo inprogressto, string sprintclosedate)
        {
            Movement = movement;
            StoryNo = storyno;
            TaskNo = taskno;
            TestHours = testhours;
            InProgressTo = inprogressto;
            SprintCloseDate = sprintclosedate;
        }
    }
    public class MergeRelease
    {
        public string Release1 { get; set; }
        public string Release2 { get; set; }
        public bool ReleaseMerge { get; set; }
        public MergeRelease(string release1, string release2, bool releasemerge)
        {
            Release1 = release1;
            Release2 = release2;
            ReleaseMerge = releasemerge;
        }
    }
    public class StorySideMenu
    {
        public string Action { get; set; }
        public TaskOperation TaskOperation { get; set; }
        public string FilePath { get; set; }
        public string Comment { get; set; }
        public StorySideMenu(string action, TaskOperation taskoperation, string filepath, string comment)
        {
            Action = action;
            TaskOperation = taskoperation;
            FilePath = filepath;
            Comment = comment;
        }
    }
    public class ReleaseOperation
    {
        public int RowNo { get; set; }
        public string Action { get; set; }
        public ReleaseOperation(int rowno, string action)
        {
            RowNo = rowno;
            Action = action;
        }
    }
    public class MemberOnLeave
    {
        public string MemberName { get; set; }
        public string LeaveDate { get; set; }
        public string Day { get; set; }
        public MemberOnLeave(string membername, string leavedate, string day)
        {
            MemberName = membername;
            LeaveDate = leavedate;
            Day = day;
        }
    }
    #endregion
    public static class Project
    {
        public static ProjectPage ProjectPage
        {
            get
            {
                ProjectPage projectpage = new ProjectPage();
                PageFactory.InitElements(Browser.Driver, projectpage);
                return projectpage;
            }
        }
    }
    public class ProjectPage
    {
        public string Url = "Project/";
        public string Title = "Projects";
        public string TeamSubHeader = "Project Team";
        #region
        [FindsBy(How = How.TagName, Using = "h1")]
        public IWebElement Header { get; set; }
        [FindsBy(How = How.ClassName, Using = "AddProject")]
        public IWebElement AddProjectButton { get; set; }
        [FindsBy(How = How.Id, Using = "GroupPopUp")]
        public IWebElement CreateGroupButton { get; set; }
        [FindsBy(How = How.Id, Using = "txtGropuSearch")]
        public IWebElement SearchGroupTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "searchGroup")]
        public IWebElement SearchDiv { get; set; }
        [FindsBy(How = How.Id, Using = "viewGrp")]
        public IWebElement GroupDiv { get; set; }
        [FindsBy(How = How.Id, Using = "Type")]
        public IWebElement ProjectTypeDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "Status")]
        public IWebElement ProjectStatusDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "txtSearch")]
        public IWebElement ProjectSearchTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ProjectSearch")]
        public IWebElement ProjectSearchDiv { get; set; }
        [FindsBy(How = How.Id, Using = "divPaging")]
        public IWebElement PagingDiv { get; set; }
        //Add New Project
        [FindsBy(How = How.Id, Using = "txtProjectName")]
        public IWebElement ProjectNameTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "txtProjectID")]
        public IWebElement ProjectIDTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "selProjectType")]
        public IWebElement NewProjectTypeDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "ProjectKey")]
        public IWebElement ProjectKeyTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "txtProjectOwner")]
        public IWebElement ProjectOwnerTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "txtProjectMananger")]
        public IWebElement ProjectManagerTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "txtStartDate")]
        public IWebElement StartDateTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "txtEndDate")]
        public IWebElement EndDateTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "Description")]
        public IWebElement ProjectDescriptionTextBox { get; set; }
        [FindsBy(How = How.ClassName, Using = "sfSave")]
        public IWebElement CreateProjectButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "sfCancel")]
        public IWebElement CancelButton { get; set; }
        //Add Group
        [FindsBy(How = How.Id, Using = "Name")]
        public IWebElement GroupNameTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "Description")]
        public IWebElement GroupDescriptionTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "Project")]
        public IWebElement ProjectTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "btnGroupSave")]
        public IWebElement SaveGroupButton { get; set; }
        [FindsBy(How = How.Id, Using = "ProjectTable")]
        public IWebElement ProjectTableDiv { get; set; }
        //Plan
        //[FindsBy(How = How.Id, Using = "AddProjectMember")]
        //public IWebElement AddProjectMemberButton { get; set; }
        [FindsBy(How = How.Id, Using = "MemberActive")]
        public IWebElement MemberStatusDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "txtMemberSearch")]
        public IWebElement MemberSearchTextBox { get; set; }
        [FindsBy(How = How.ClassName, Using = "searchProject")]
        public IWebElement SearchProjectButton { get; set; }
        [FindsBy(How = How.Id, Using = "planMenu")]
        public IWebElement PlanMenuList { get; set; }
        [FindsBy(How = How.ClassName, Using = "PrjActualStatus")]
        public IWebElement ProjectActualStatusLink { get; set; }
        [FindsBy(How = How.ClassName, Using = "closeColor")]
        public IWebElement CloseColorLink { get; set; }
        [FindsBy(How = How.ClassName, Using = "grayColour")]
        public IWebElement GrayColorLink { get; set; }
        [FindsBy(How = How.ClassName, Using = "greenColour")]
        public IWebElement GreenColorLink { get; set; }
        [FindsBy(How = How.ClassName, Using = "orangeColour")]
        public IWebElement OrangeColorLink { get; set; }
        [FindsBy(How = How.ClassName, Using = "redColour")]
        public IWebElement RedColorLink { get; set; }
        [FindsBy(How = How.ClassName, Using = "blueColour")]
        public IWebElement BlueColorLink { get; set; }
        [FindsBy(How = How.Id, Using = "grayColour")]
        public IWebElement GrayColor { get; set; }
        [FindsBy(How = How.Id, Using = "greenColour")]
        public IWebElement GreenColor { get; set; }
        [FindsBy(How = How.Id, Using = "orangeColour")]
        public IWebElement OrangeColor { get; set; }
        [FindsBy(How = How.Id, Using = "redColour")]
        public IWebElement RedColor { get; set; }
        [FindsBy(How = How.Id, Using = "blueColour")]
        public IWebElement BlueColor { get; set; }
        [FindsBy(How = How.Id, Using = "txtTeamMember")]
        public IWebElement TeamMemberTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "selProjectType")]
        public IWebElement DesignationDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "txtMemberStartDate")]
        public IWebElement MemberStartDateTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "txtMemberEndDate")]
        public IWebElement MemberEndDateTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "AllotedHours")]
        public IWebElement AllotedHoursTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "IsPrimaryProject")]
        public IWebElement PrimaryProjectCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "IsActive")]
        public IWebElement ActiveCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "Membersave")]
        public IWebElement MemberSaveButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "editMember")]
        public IWebElement EditMemberLink { get; set; }
        [FindsBy(How = How.ClassName, Using = "deletemember")]
        public IWebElement DeleteMember { get; set; }
        [FindsBy(How = How.Id, Using = "TeamMemberList")]
        public IWebElement TeamMemberListSpan { get; set; }
        //ProjectClosure
        [FindsBy(How = How.ClassName, Using = "taskList")]
        public IWebElement TaskList { get; set; }
        [FindsBy(How = How.Id, Using = "FutureRecommendation")]
        public IWebElement FutureRecommendationTextArea { get; set; }
        [FindsBy(How = How.Id, Using = "btnProjectClose")]
        public IWebElement ArchiveProjectButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "addTasks")]
        public IWebElement AddTasksLink { get; set; }
        //ProductPlan
        [FindsBy(How = How.Id, Using = "ProductName")]
        public IWebElement ProductNameTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ProductVision")]
        public IWebElement ProductVisionTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "DevelopmentScope")]
        public IWebElement DevelopmentScopeTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "OutOfScope")]
        public IWebElement OutOfScopeTextBox { get; set; }
        [FindsBy(How = How.ClassName, Using = "sfBtn")]
        public IWebElement SaveProductPlanButon { get; set; }
        //ProductRelease
        [FindsBy(How = How.Id, Using = "chkUnreleased")]
        public IWebElement ShowReleaseCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "chkReleased")]
        public IWebElement ShowUnReleasedCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "btnAddStories")]
        public IWebElement AddStoriesButton { get; set; }
        [FindsBy(How = How.Id, Using = "btnAddRelease")]
        public IWebElement AddReleaseButton { get; set; }
        [FindsBy(How = How.Id, Using = "btnMergeStories")]
        public IWebElement MergeStoriesButton { get; set; }
        [FindsBy(How = How.Id, Using = "tabs")]
        public IWebElement ReleaseTabs { get; set; }
        //ReleaseGoal
        [FindsBy(How = How.Id, Using = "Name")]
        public IWebElement ReleaseNameTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "Goal")]
        public IWebElement ReleaseGoalTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "Note")]
        public IWebElement NoteTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "btnsaverelease")]
        public IWebElement SaveReleaseButton { get; set; }
        [FindsBy(How = How.Id, Using = "closeReleasePlanCreate")]
        public IWebElement BackToReleaseList { get; set; }
        //ReleaseTimelines
        [FindsBy(How = How.Id, Using = "txtDevStartDate")]
        public IWebElement DevelopmentStartDateTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "txtDevEndDate")]
        public IWebElement DevelopmentEndDateTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "radio-yes")]
        public IWebElement HardeningRequiredYesRadioButton { get; set; }
        [FindsBy(How = How.Id, Using = "radio-no")]
        public IWebElement HardeningRequiredNoRadioButton { get; set; }
        [FindsBy(How = How.Id, Using = "txtHardStartDate")]
        public IWebElement HardeningStartDateTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "txtHardEndDate")]
        public IWebElement HardeningEndDateTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "txtPlanReleaseDate")]
        public IWebElement PlanReleaseDateTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "StoriesNo")]
        public IWebElement StoriesNoTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "StoryPoint")]
        public IWebElement StoryPointTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "EstimatedVelocity")]
        public IWebElement EstimatedVelocityTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "PlannedsprintNo")]
        public IWebElement PlannedsprintNoTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "btnTimelines")]
        public IWebElement SubmitQueryButton { get; set; }
        //DOD
        [FindsBy(How = How.ClassName, Using = "DODReleaseadd")]
        public IWebElement AddDODReleaseButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "DODSprintadd")]
        public IWebElement AddDODSprintButton { get; set; }
        [FindsBy(How = How.Id, Using = "btnSaveDOD")]
        public IWebElement SaveDODButton { get; set; }
        //Release Status
        [FindsBy(How = How.ClassName, Using = "releasegrayColour")]
        public IWebElement ReleaseGrayColorLink { get; set; }
        [FindsBy(How = How.ClassName, Using = "releasegreenColour")]
        public IWebElement ReleaseGreenColorLink { get; set; }
        [FindsBy(How = How.ClassName, Using = "releaseorangeColour")]
        public IWebElement ReleaseOrangeColorLink { get; set; }
        [FindsBy(How = How.ClassName, Using = "releaseredColour")]
        public IWebElement ReleaseRedColorLink { get; set; }
        [FindsBy(How = How.ClassName, Using = "releaseblueColour")]
        public IWebElement ReleaseBlueColorLink { get; set; }
        [FindsBy(How = How.Id, Using = "releasegrayColour")]
        public IWebElement ReleaseGrayColor { get; set; }
        [FindsBy(How = How.Id, Using = "releasegreenColour")]
        public IWebElement ReleaseGreenColor { get; set; }
        [FindsBy(How = How.Id, Using = "releaseorangeColour")]
        public IWebElement ReleaseOrangeColor { get; set; }
        [FindsBy(How = How.Id, Using = "releaseredColour")]
        public IWebElement ReleaseRedColor { get; set; }
        [FindsBy(How = How.Id, Using = "releaseblueColour")]
        public IWebElement ReleaseBlueColor { get; set; }
        //Activites
        [FindsBy(How = How.ClassName, Using = "addActivities")]
        public IWebElement AddActivities { get; set; }
        [FindsBy(How = How.Id, Using = "btnSaveActivities")]
        public IWebElement SaveActivites { get; set; }
        //Sprint
        //[FindsBy(How = How.Id, Using = "btnAddSprint")]
        //public IWebElement AddSprintButton { get; set; }
        [FindsBy(How = How.Id, Using = "SprintName")]
        public IWebElement SprintNameTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ReleaseID")]
        public IWebElement ReleaseDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "StartDate")]
        public IWebElement SprintStartDateTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "EndDate")]
        public IWebElement SprintEndDateTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "StandUpMeetingTime")]
        public IWebElement StandUpMeetingTimeTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "BackupScrumMaster")]
        public IWebElement BackupScrumMasterTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "SprintGoal")]
        public IWebElement SprintGoalTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "SaveSprint")]
        public IWebElement SaveSprintButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "sfPopupCancel")]
        public IWebElement CancelSprintButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "divSprintListClass")]
        public IWebElement SprintListDiv { get; set; }
        //Backlog
        [FindsBy(How = How.Id, Using = "spnCreateSprint")]
        public IWebElement CreateSprintLink { get; set; }
        [FindsBy(How = How.Id, Using = "spnAddStory")]
        public IWebElement AddStoryLink { get; set; }
        #endregion
        public void SelectFromList(string Id)
        {
            try
            {
                IWebElement ProjectList = Browser.Driver.FindElement(By.Id(Id));
                IWebElement Project = ProjectList.FindElement(By.TagName("ul"));
                IList<IWebElement> ProductList = Project.FindElements(By.TagName("li"));
                if (ProductList.Count != 0)
                {
                    Browser.ClickOnInvisibleElement(ProductList[0]);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        //Project
        public void FillProjectDetails(ProjectData Project)
        {
            try
            {
                ClearAndFillTextBox ProjectNameClearNFillTextBox = new ClearAndFillTextBox(ProjectNameTextBox, Project.ProjectName);
                Browser.ClearAndFillTextBox(ProjectNameClearNFillTextBox);
                //ClearAndFillTextBox ProjectIDClearNFillTextBox = new ClearAndFillTextBox(ProjectIDTextBox, Project.ProjectID);
                //Browser.ClearAndFillTextBox(ProjectIDClearNFillTextBox);
                //IWebElement ProjectIDExists = Browser.Driver.FindElement(By.ClassName("sfIDDuplicate"));
                //if (ProjectIDExists.Text == "Project ID: " + Project.ProjectID + " already exists!")
                //{
                //    //MessageBox.Show("Project ID Already Exists!");
                //    //Browser.SwitchToAlert(true);
                //    ProjectIDClearNFillTextBox = new ClearAndFillTextBox(ProjectIDTextBox, Browser.RandomStringGenerator());
                //    Browser.ClearAndFillTextBox(ProjectIDClearNFillTextBox);
                //}
                DropDownSelect DropDownSelect = new DropDownSelect(Project.ProjectType, NewProjectTypeDropDown);
                Browser.SelectDropdown(DropDownSelect);
                ClearAndFillTextBox ProjectKeyClearNFillTextBox = new ClearAndFillTextBox(ProjectKeyTextBox, Project.ProjectKey);
                Browser.ClearAndFillTextBox(ProjectKeyClearNFillTextBox);
                ClearAndFillTextBox ProjectOwnerClearNFillTextBox = new ClearAndFillTextBox(ProjectOwnerTextBox, Project.ProjectOwner);
                Browser.ClearAndFillTextBox(ProjectOwnerClearNFillTextBox);
                SelectFromList("ProjectOwnerList");
                //IWebElement ProjectOwnerList = Browser.Driver.FindElement(By.Id("ProjectOwnerList"));
                //IWebElement ProjectOwner = ProjectOwnerList.FindElement(By.TagName("ul"));
                //IList<IWebElement> ProductOwnerList = ProjectOwner.FindElements(By.TagName("li"));
                //if (ProductOwnerList.Count != 0)
                //{
                //    Browser.ClickOnInvisibleElement(ProductOwnerList[0]);
                //}
                ClearAndFillTextBox ProjectManagerClearNFillTextBox = new ClearAndFillTextBox(ProjectManagerTextBox, Project.ProjectManager);
                Browser.ClearAndFillTextBox(ProjectManagerClearNFillTextBox);
                SelectFromList("ProjectMangerList");
                //IWebElement ProjectMangerList = Browser.Driver.FindElement(By.Id("ProjectMangerList"));
                //IWebElement ProjectManger = ProjectMangerList.FindElement(By.TagName("ul"));
                //IList<IWebElement> ProductMangerList = ProjectManger.FindElements(By.TagName("li"));
                //if (ProductMangerList.Count != 0)
                //{
                //    ProductMangerList[0].Click();
                //}
                IWebElement UserExists = Browser.Driver.FindElement(By.ClassName("sfNameDuplicate"));
                if (UserExists.Text == "Project Name: " + Project.ProjectName + " already exists!")
                {
                    //MessageBox.Show("User Already Exists!");
                    //Browser.SwitchToAlert(true);
                    ProjectNameClearNFillTextBox = new ClearAndFillTextBox(ProjectNameTextBox, Browser.RandomStringGenerator());
                    Browser.ClearAndFillTextBox(ProjectNameClearNFillTextBox);
                }
                IWebElement ProjectKeyExists = Browser.Driver.FindElement(By.ClassName("sfKeyDuplicate"));
                if (ProjectKeyExists.Text == "Project Key: " + Project.ProjectKey + " already exists!")
                {
                    //MessageBox.Show("Project Key Already Exists!");
                    //Browser.SwitchToAlert(true);
                    ProjectKeyClearNFillTextBox = new ClearAndFillTextBox(ProjectKeyTextBox, Browser.RandomStringGenerator());
                    Browser.ClearAndFillTextBox(ProjectKeyClearNFillTextBox);
                }
                ClearAndFillTextBox StartDateClearNFillTextBox = new ClearAndFillTextBox(StartDateTextBox, Project.StartDate);
                Browser.ClearAndFillTextBox(StartDateClearNFillTextBox);
                ClearAndFillTextBox EndDateClearNFillTextBox = new ClearAndFillTextBox(EndDateTextBox, Project.EndDate);
                Browser.ClearAndFillTextBox(EndDateClearNFillTextBox);
                ClearAndFillTextBox ProjectDescriptionClearNFillTextBox = new ClearAndFillTextBox(ProjectDescriptionTextBox, Project.ProjectDescription);
                Browser.ClearAndFillTextBox(ProjectDescriptionClearNFillTextBox);
                SaveCancel ProjectSaveCancel = new SaveCancel(CreateProjectButton, CancelButton, Project.CreateProject);
            Save: Browser.SaveCancel(ProjectSaveCancel);
                IList<IWebElement> InvalidData = Browser.Driver.FindElements(By.ClassName("field-validation-error"));
                if (InvalidData.Count != 0)
                {
                    foreach (IWebElement invalidData in InvalidData)
                    {
                        IList<IWebElement> MessageSpan = invalidData.FindElements(By.TagName("span"));
                        switch (MessageSpan[0].Text)
                        {
                            case "The Name field is required.":
                                {
                                    ProjectNameClearNFillTextBox = new ClearAndFillTextBox(ProjectNameTextBox, Browser.RandomStringGenerator());
                                    Browser.ClearAndFillTextBox(ProjectNameClearNFillTextBox);
                                    break;
                                }
                            //case "ProjectID is Required":
                            //    {
                            //        ProjectIDClearNFillTextBox = new ClearAndFillTextBox(ProjectIDTextBox, Browser.RandomStringGenerator());
                            //        Browser.ClearAndFillTextBox(ProjectIDClearNFillTextBox);
                            //        break;
                            //    }
                            case "The ProjectKey field is required.":
                                {
                                    ProjectKeyClearNFillTextBox = new ClearAndFillTextBox(ProjectKeyTextBox, Browser.RandomStringGenerator());
                                    Browser.ClearAndFillTextBox(ProjectKeyClearNFillTextBox);
                                    break;
                                }
                            case "The Owner field is required.":
                                {
                                    ProjectOwnerClearNFillTextBox = new ClearAndFillTextBox(ProjectOwnerTextBox, Browser.RandomStringGenerator());
                                    Browser.ClearAndFillTextBox(ProjectOwnerClearNFillTextBox);
                                    break;
                                }
                            case "The Manager field is required.":
                                {
                                    ProjectManagerClearNFillTextBox = new ClearAndFillTextBox(ProjectManagerTextBox, Browser.RandomStringGenerator());
                                    Browser.ClearAndFillTextBox(ProjectManagerClearNFillTextBox);
                                    break;
                                }
                            case "The field StartDate must be a date.":
                            case "The StartDate field is required.":
                                {
                                    StartDateClearNFillTextBox = new ClearAndFillTextBox(StartDateTextBox, "12/14/2015");
                                    Browser.ClearAndFillTextBox(StartDateClearNFillTextBox);
                                    break;
                                }
                            case "The field ActualEndDate must be a date.":
                            case "The ActualEndDate field is required.":
                                {
                                    EndDateClearNFillTextBox = new ClearAndFillTextBox(EndDateTextBox, "12/14/2016");
                                    Browser.ClearAndFillTextBox(EndDateClearNFillTextBox);
                                    break;
                                }
                        }
                        goto Save;
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void AddProject(ProjectData[] project)
        {
            try
            {
                foreach (ProjectData Project in project)
                {
                    IsAt AtTitle = new IsAt(Header.Text, Title);
                    //Assert.IsTrue(Browser.IsAt(AtTitle));
                    AddProjectButton.Click();
                    FillProjectDetails(Project);
                    Browser.Wait();
                    Browser.GoTo(Url);
                }
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[1] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void AddGroup(AddGroup AddGroup)
        {
            try
            {
                IsAt AtTitle = new IsAt(Header.Text, Title);
                //Assert.IsTrue(Browser.IsAt(AtTitle));
                if (AddGroup.Add == true)
                {
                    CreateGroupButton.Click();
                }
                ClearAndFillTextBox GroupNameClearNFillTextBox = new ClearAndFillTextBox(GroupNameTextBox, AddGroup.Group.GroupName);
                Browser.ClearAndFillTextBox(GroupNameClearNFillTextBox);
                ClearAndFillTextBox GroupDescriptionClearNFillTextBox = new ClearAndFillTextBox(GroupDescriptionTextBox, AddGroup.Group.GroupDescription);
                Browser.ClearAndFillTextBox(GroupDescriptionClearNFillTextBox);
                foreach (string ProjectName in AddGroup.Group.ProjectNameList)
                {
                    ClearAndFillTextBox ProjectNameClearNFillTextBox = new ClearAndFillTextBox(ProjectTextBox, ProjectName);
                    Browser.ClearAndFillTextBox(ProjectNameClearNFillTextBox);
                    SelectFromList("ProjectList");
                    //IWebElement ProjectListSpan = Browser.Driver.FindElement(By.Id("ProjectList"));
                    //IWebElement ProjectListUL = ProjectListSpan.FindElement(By.TagName("ul"));
                    //IList<IWebElement> ProjectList = ProjectListUL.FindElements(By.TagName("li"));
                    //if (ProjectList.Count != 0)
                    //{
                    //    ProjectList[0].Click();
                    //}
                }
                SaveCancel GroupSaveCancel = new SaveCancel(SaveGroupButton, CancelButton, AddGroup.Group.CreateGroup);
                IList<IWebElement> GroupExists = Browser.Driver.FindElements(By.ClassName("field-validation-valid"));
                GroupNameClearNFillTextBox = new ClearAndFillTextBox(GroupNameTextBox, Browser.RandomStringGenerator());
                if (GroupExists.Count != 0)
                {
                    if (GroupExists[0].Text == "Group Name " + AddGroup.Group.GroupName + " already exists!")
                    {
                        Browser.ClearAndFillTextBox(GroupNameClearNFillTextBox);
                        goto AddGroup;
                    }
                }
                IList<IWebElement> InvalidData = Browser.Driver.FindElements(By.ClassName("field-validation-error"));
                if (InvalidData.Count != 0)
                {
                    foreach (IWebElement invalidData in InvalidData)
                    {
                        IList<IWebElement> MessageSpan = invalidData.FindElements(By.TagName("span"));
                        switch (MessageSpan[0].Text)
                        {
                            case "The Name field is required.":
                                {
                                    Browser.ClearAndFillTextBox(GroupNameClearNFillTextBox);
                                    break;
                                }
                            case "The Description field is required.":
                                {
                                    GroupDescriptionClearNFillTextBox = new ClearAndFillTextBox(GroupDescriptionTextBox, Browser.RandomStringGenerator());
                                    Browser.ClearAndFillTextBox(GroupDescriptionClearNFillTextBox);
                                    break;
                                }
                        }
                        goto AddGroup;
                        //MessageBox.Show("Description is Required");
                        //Browser.SwitchToAlert(true);                     
                    }
                }
AddGroup:       Browser.SaveCancel(GroupSaveCancel);               
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[2] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public IList<IWebElement> ReturnGroup()
        {
            try
            {
                IWebElement GroupList = GroupDiv.FindElement(By.TagName("ul"));
                IList<IWebElement> Group = GroupList.FindElements(By.TagName("li"));
                return Group;
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
                //Browser.TestResults.ErrorException[2] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void SearchGroup(string GroupName)
        {
            try
            {
                ClearAndFillTextBox GroupNameClearNFillTextBox = new ClearAndFillTextBox(SearchGroupTextBox, GroupName);
                Browser.ClearAndFillTextBox(GroupNameClearNFillTextBox);
                IWebElement GroupSearchButton = SearchDiv.FindElement(By.TagName("span"));
                Browser.ClickOnInvisibleElement(GroupSearchButton);
                IList<IWebElement> Group = ReturnGroup();
                if (Group[0].Text == "Group not found")
                {
                    //MessageBox.Show("Group Doesn't Exist!");
                    //Browser.SwitchToAlert(true);
                }
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[2] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void EditDeleteGroup(EditDeleteGroup Editdeletegroup)
        {
            //n :2 for edit n:3 for delete
            try
            {
                IList<IWebElement> Group = ReturnGroup();
                if (Group.Count != 0)
                {
                    IWebElement EditDeleteSpan = Group[0].FindElements(By.TagName("span"))[Editdeletegroup.n];
                    Browser.ClickOnInvisibleElement(EditDeleteSpan);
                    switch (Editdeletegroup.n)
                    {
                        case 2:
                            {
                                AddGroup(Editdeletegroup.AddGroup);
                                break;
                            }
                        case 3:
                            {
                                Browser.Confirm(Editdeletegroup.ConfirmDelete);
                                break;
                            }
                    }
                }
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[2] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void SearchProject(SearchProject SearchProject)
        {
            try
            {
                IsAt AtTitle = new IsAt(Header.Text, Title);
                //Assert.IsTrue(Browser.IsAt(AtTitle));
                DropDownSelect ProjectTypeDropDownSelect = new DropDownSelect(SearchProject.ProjectType, ProjectTypeDropDown);
                DropDownSelect ProjectStatusDropDownSelect = new DropDownSelect(SearchProject.ProjectStatus, ProjectStatusDropDown);
                Browser.SelectDropdown(ProjectTypeDropDownSelect);
                Browser.SelectDropdown(ProjectStatusDropDownSelect);
                ClearAndFillTextBox ProjectNameClearNFillTextBox = new ClearAndFillTextBox(ProjectSearchTextBox, SearchProject.ProjectName);
                Browser.ClearAndFillTextBox(ProjectNameClearNFillTextBox);
                IWebElement SearchProjectButton = ProjectSearchDiv.FindElement(By.TagName("span"));
                Browser.ClickOnInvisibleElement(SearchProjectButton);
                IList<IWebElement> EmptyMsg = Browser.Driver.FindElements(By.ClassName("sfEmpty"));
                if (EmptyMsg.Count != 0)
                {
                    //MessageBox.Show("No Projects Are Found Of your requirement!");
                    //Browser.SwitchToAlert(true);
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
        public void ProjectSettings(string Action)
        {
            try
            {
                IWebElement ProjectSettingDiv = Browser.Driver.FindElement(By.ClassName("pjctSetting"));
                IWebElement ProjectSettingsIcon = ProjectSettingDiv.FindElement(By.ClassName("bicon-icon-settings"));
                Browser.ClickOnInvisibleElement(ProjectSettingsIcon);
                IWebElement ProjectEditDiv = ProjectSettingDiv.FindElement(By.ClassName("projectEdit"));
                IWebElement ProjectOuterDiv = ProjectEditDiv.FindElement(By.ClassName("prjctOuter"));
                IWebElement ProjectBorder = ProjectOuterDiv.FindElement(By.ClassName("border"));
                IWebElement ProjectText = ProjectBorder.FindElement(By.ClassName("text"));
                IWebElement ProjectSettingList = ProjectText.FindElement(By.ClassName("animates"));
                switch (Action)
                {
                    case "Edit" :
                        {
                            IWebElement EditProject = ProjectSettingList.FindElement(By.ClassName("editProject"));
                            IWebElement EditProjectLink = EditProject.FindElement(By.TagName("span"));
                            EditProjectLink.Click();
                            break;
                        }
                    case "Close":
                        {
                            IWebElement CloseProject = ProjectSettingList.FindElement(By.ClassName("closeProject"));
                            IWebElement CloseProjectLink = CloseProject.FindElement(By.TagName("span"));
                            CloseProjectLink.Click();
                            break;
                        }
                    case "Deactivate":
                        {
                            IWebElement DeactivateProject = ProjectSettingList.FindElement(By.ClassName("deactivateProject"));
                            IWebElement DeactivateProjectLink = DeactivateProject.FindElement(By.TagName("span"));
                            DeactivateProjectLink.Click();
                            break;
                        }
                    case "Delete":
                        {
                            IWebElement DeleteProject = ProjectSettingList.FindElement(By.ClassName("deleteProject"));
                            IWebElement DeleteProjectLink = DeleteProject.FindElement(By.TagName("span"));
                            DeleteProjectLink.Click();
                            break;
                        }
                    default :
                        {
                            IWebElement ProjectSettingsCloseIcon = ProjectText.FindElement(By.ClassName("projectActionClose"));
                            ProjectSettingsCloseIcon.Click();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ClickProjectLink(string Action)
        {
            try
            {
                IList<IWebElement> ProjectsList = ProjectTableDiv.FindElements(By.TagName("div"));
                IList<IWebElement> ProjectSpan = ProjectsList[1].FindElements(By.TagName("span"));
                IList<IWebElement> ProjectUserAction = ProjectSpan[8].FindElements(By.TagName("a"));
                IWebElement ProjectPlan = ProjectUserAction[0].FindElement(By.TagName("span"));
                IWebElement ProjectBackLog = ProjectUserAction[1].FindElement(By.TagName("span"));
                IWebElement ProjectReport = ProjectUserAction[2].FindElement(By.TagName("span"));
                switch (Action)
                {
                    case "Plan":
                        {
                            Browser.ClickOnInvisibleElement(ProjectPlan);
                            break;
                        }
                    case "BackLog":
                        {
                            Browser.ClickOnInvisibleElement(ProjectBackLog);
                            break;
                        }
                    case "Report":
                        {
                            Browser.ClickOnInvisibleElement(ProjectReport);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EditProject(ProjectData EditProject)
        {
            try
            {
                ClickProjectLink("Plan"); 
                //Assert.IsTrue(Browser.IsAt(Header.Text, Title));               
                Browser.SwitchWindow();
                IList<IWebElement> SubHeader = Browser.Driver.FindElements(By.TagName("h2"));
                IsAt AtTeam = new IsAt(SubHeader[1].Text, TeamSubHeader);
                ProjectSettings("Edit");
                FillProjectDetails(EditProject);
                //Assert.IsTrue(Browser.IsAt(AtTeam));
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[4] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void ProjectClosure(ProjectClosure ProjectClosure)
        {
            int i;
            try
            {
                //IList<IWebElement> TaskLi = TaskList.FindElements(By.ClassName("tasks"));
                //int TaskCount = TaskLi.Count;
                //IWebElement ULTask = TaskLi[0].FindElement(By.TagName("ul"));
                //IList<IWebElement> TaskDesc = ULTask.FindElements(By.TagName("li"));
                ClickProjectLink("Plan");
                Browser.SwitchWindow();
                ProjectSettings("Close");
                for (i = 0; i < ProjectClosure.Task.Count(); i++)
                {
                    IList<IWebElement> TaskTextBox = Browser.Driver.FindElements(By.ClassName("task"));
                    IList<IWebElement> OwnerTextBox = Browser.Driver.FindElements(By.Id("txtOwner_" + (i).ToString()));
                    IList<IWebElement> DueDateTextBox = Browser.Driver.FindElements(By.Id("dueDates_" + (i).ToString()));
                    ClearAndFillTextBox TaskClearNFillTextBox = new ClearAndFillTextBox(TaskTextBox[i], ProjectClosure.Task[i]);
                    Browser.ClearAndFillTextBox(TaskClearNFillTextBox);
                    ClearAndFillTextBox OwnerClearNFillTextBox = new ClearAndFillTextBox(OwnerTextBox[0], ProjectClosure.Owner[i]);
                    Browser.ClearAndFillTextBox(OwnerClearNFillTextBox);
                    SelectFromList("TeamMemberList_" + (i).ToString());
                    //IList<IWebElement> TeamMemberListSpan = Browser.Driver.FindElements(By.Id("TeamMemberList_" + (i + 1).ToString()));
                    //IWebElement TeamMemberList = TeamMemberListSpan[0].FindElement(By.TagName("ul"));
                    //IList<IWebElement> TeamMember = TeamMemberList.FindElements(By.LinkText(ProjectClosure.Owner[i]));
                    //if (TeamMember.Count != 0)
                    //{
                    //    TeamMember[0].Click();
                    //}
                    ClearAndFillTextBox DueDateClearNFillTextBox = new ClearAndFillTextBox(DueDateTextBox[0], ProjectClosure.DueDate[i]);
                    Browser.ClearAndFillTextBox(DueDateClearNFillTextBox);
                    if (TaskTextBox.Count() != ProjectClosure.Task.Count())
                    {
                        AddTasksLink.Click();
                    }
                }
                ClearAndFillTextBox FutureRecommendationClearNFillTextBox = new ClearAndFillTextBox(FutureRecommendationTextArea, ProjectClosure.FutureRecommendation);
                Browser.ClearAndFillTextBox(FutureRecommendationClearNFillTextBox);
Archive:        ArchiveProjectButton.Click();
                IList<IWebElement> FieldValidation = Browser.Driver.FindElements(By.ClassName("field-validation-error"));
                if (FieldValidation.Count != 0)
                {
                    IWebElement MessageSpan = FieldValidation[0].FindElement(By.TagName("span"));
                    if (MessageSpan.Text == "The FutureRecommendation field is required.")
                    {
                        FutureRecommendationClearNFillTextBox = new ClearAndFillTextBox(FutureRecommendationTextArea, Browser.RandomStringGenerator());
                        Browser.ClearAndFillTextBox(FutureRecommendationClearNFillTextBox);
                        goto Archive;
                    }
                }
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[1] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void ClickProjectMenu(string ProjectMenu)
        {
            try
            {
                IList<IWebElement> ProjectMenuUL = Browser.Driver.FindElements(By.ClassName("sf-menu"));
                IList<IWebElement> ProjectMenuList = ProjectMenuUL[1].FindElements(By.TagName("li"));
                IWebElement SubHeader;
                switch (ProjectMenu)
                {
                    case "Plan":
                        {
                            IWebElement PlanMenu = ProjectMenuList[0].FindElement(By.TagName("a"));
                            PlanMenu.Click();
                            SubHeader = Browser.Driver.FindElements(By.TagName("h2"))[1];
                            //Assert.IsTrue(SubHeader.Text.Contains("Project Team"));
                            break;
                        }
                    case "BackLog":
                        {
                            IWebElement BackLogMenu = ProjectMenuList[1].FindElement(By.TagName("a"));
                            BackLogMenu.Click();
                            SubHeader = Browser.Driver.FindElements(By.TagName("h2"))[1];
                            //Assert.IsTrue(SubHeader.Text.Contains("Backlog"));
                            break;
                        }
                    case "Board":
                        {
                            IWebElement BoardMenu = ProjectMenuList[2].FindElement(By.TagName("a"));
                            BoardMenu.Click();
                            SubHeader = Browser.Driver.FindElements(By.TagName("h2"))[1];
                            //Assert.IsTrue(SubHeader.Text.Contains("Board"));
                            break;
                        }
                    case "Retrospectives":
                        {
                            IWebElement RetrospectivesMenu = ProjectMenuList[3].FindElement(By.TagName("a"));
                            RetrospectivesMenu.Click();
                            SubHeader = Browser.Driver.FindElements(By.TagName("h2"))[1];
                            //Assert.IsTrue(SubHeader.Text.Contains("Retrospective"));
                            break;
                        }
                    case "Reports":
                        {
                            IWebElement ReportsMenu = ProjectMenuList[4].FindElement(By.TagName("a"));
                            ReportsMenu.Click();
                            SubHeader = Browser.Driver.FindElements(By.TagName("h2"))[1];
                            //Assert.IsTrue(SubHeader.Text.Contains("Reports"));
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Project Plan
        public void ClickPlanMenu(string PlanMenu)
        {
            try
            {
                IList<IWebElement> MenuLink = PlanMenuList.FindElements(By.TagName("li"));
                switch (PlanMenu)
                {
                    case "Team":
                        {
                            MenuLink[0].Click();
                            break;
                        }
                    case "Product":
                        {
                            MenuLink[1].Click();
                            break;
                        }
                    case "Release":
                        {
                            MenuLink[2].Click();
                            break;
                        }
                    case "Sprint":
                        {
                            MenuLink[3].Click();
                            break;
                        }
                }
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[1] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }      
        public void GetStatus(GetStatus GetStatus)
        {
            try
            {
                IWebElement StatusLink = GetStatus.Color.FindElement(By.TagName("ul"));
                IList<IWebElement> StatusList = StatusLink.FindElements(By.TagName("li"));
                switch (GetStatus.Status)
                {
                    case "Not Started":
                    case "In Planning":
                    case "Delayed":
                    case "On Hold":
                    case "Released":
                    case "Completed":
                        {
                            StatusList[0].Click(); 
                            break;
                        }
                    case "In Development":
                    case "Inactive":
                    case "Delivered":
                        {
                            StatusList[1].Click(); 
                            break;
                        }
                    case "In Hardening":
                    case "Cancelled":
                    case "Live":
                        {
                            StatusList[2].Click(); 
                            break;
                        }
                    case "UAT":
                        {
                            StatusList[3].Click(); 
                            break;
                        }
                    case "Active":
                        {
                            StatusList[4].Click(); 
                            break;
                        }
                }
                //IWebElement StatusSpan = StatusLink.FindElement(By.LinkText(GetStatus.Status));
                //StatusSpan.Click();
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[1] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void SetProjectStatus(string Status)
        {
            try
            {
                GetStatus GrayStatus = new GetStatus(GrayColor, Status);
                GetStatus GreenStatus = new GetStatus(GreenColor, Status);
                GetStatus OrangeStatus = new GetStatus(OrangeColor, Status);
                GetStatus RedStatus = new GetStatus(RedColor, Status);
                GetStatus BlueStatus = new GetStatus(BlueColor, Status);
                ClickProjectLink("Plan");
                Browser.SwitchWindow();
                ProjectActualStatusLink.Click();
                switch (Status)
                {
                    case "Not Started":
                        {
                            GrayColorLink.Click();
                            GetStatus(GrayStatus);
                            break;
                        }
                    case "In Planning":
                    case "In Development":
                    case "In Hardening":
                    case "UAT":
                    case "Active":
                        {
                            GreenColorLink.Click();
                            GetStatus(GreenStatus);
                            break;
                        }
                    case "Delayed":
                        {
                            OrangeColorLink.Click();
                            GetStatus(OrangeStatus);
                            break;
                        }
                    case "On Hold":
                    case "Inactive":
                    case "Cancelled":
                        {
                            RedColorLink.Click();
                            GetStatus(RedStatus);
                            break;
                        }
                    case "Completed":
                    case "Delivered":
                    case "Live":
                        {
                            BlueColorLink.Click();
                            GetStatus(BlueStatus);
                            break;
                        }
                }
                IList<IWebElement> ColourfulStatus = Browser.Driver.FindElements(By.ClassName("colourfulStatus"));
                if (ColourfulStatus.Count != 0)
                {
                    CloseColorLink.Click();
                }
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[1] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        //Team
        public void FillMemberDetails(TeamMemberDetails TeamMemberDetails)
        {
            try
            {
                DropDownSelect DesignationDropDownSelect = new DropDownSelect(TeamMemberDetails.Designation, DesignationDropDown);
                Browser.SelectDropdown(DesignationDropDownSelect);
                ClearAndFillTextBox MemberStartDateClearNFillTextBox = new ClearAndFillTextBox(MemberStartDateTextBox, TeamMemberDetails.StartDate);
                Browser.ClearAndFillTextBox(MemberStartDateClearNFillTextBox);
                ClearAndFillTextBox MemberEndDateClearNFillTextBox = new ClearAndFillTextBox(MemberEndDateTextBox, TeamMemberDetails.EndDate);
                Browser.ClearAndFillTextBox(MemberEndDateClearNFillTextBox);
                ClearAndFillTextBox AllotedHoursClearNFillTextBox = new ClearAndFillTextBox(AllotedHoursTextBox, TeamMemberDetails.AllotedHours);
                Browser.ClearAndFillTextBox(AllotedHoursClearNFillTextBox);
                IWebElement AllocatedHoursSpan = Browser.Driver.FindElement(By.ClassName("allocatedTime"));
                if (AllocatedHoursSpan.Text.Contains("Allocated hour can't be more than"))
                {
                    AllotedHoursClearNFillTextBox = new ClearAndFillTextBox(AllotedHoursTextBox, "1");
                    Browser.ClearAndFillTextBox(AllotedHoursClearNFillTextBox);
                }
                ChkBox ActiveChkBox = new ChkBox(TeamMemberDetails.IsActive, ActiveCheckBox);
                ChkBox PrimaryProjectChkBox = new ChkBox(TeamMemberDetails.IsPrimary, PrimaryProjectCheckBox);
                Browser.CheckBox(PrimaryProjectChkBox);
                SaveCancel MemberSaveCancel = new SaveCancel(MemberSaveButton, CancelButton, TeamMemberDetails.Save);
                Browser.SaveCancel(MemberSaveCancel);
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[1] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void AddProjectTeam(AddTeamMember[] addteammember)
        {
            try
            {
                ClickProjectLink("Plan");
                Browser.SwitchWindow(); 
                foreach (AddTeamMember AddTeamMember in addteammember)
                {
                    IWebElement AddProjectMemberDiv = Browser.Driver.FindElement(By.Id("AddProjectMember"));
                    IWebElement AddProjectMemberButton = AddProjectMemberDiv.FindElement(By.TagName("span")); 
                    AddProjectMemberButton.Click();
                    ClearAndFillTextBox TeamMemberClearNFillTextBox = new ClearAndFillTextBox(TeamMemberTextBox, AddTeamMember.TeamMember);
                    Browser.ClearAndFillTextBox(TeamMemberClearNFillTextBox);
                    SelectFromList("TeamMemberList"); 
                    //IWebElement TeamMemberList = TeamMemberListSpan.FindElement(By.TagName("ul"));
                    ////IList<IWebElement> TeamMemberSelect = TeamMemberList.FindElements(By.LinkText(AddTeamMember.TeamMember));
                    //IList<IWebElement> TeamMemberSelect = TeamMemberList.FindElements(By.TagName("li"));
                    //if (TeamMemberSelect.Count != 0)
                    //{
                    //    TeamMemberSelect[0].Click();
                    //}
                    FillMemberDetails(AddTeamMember.TeamMemberDetails);
                }
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[1] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void SearchTeamMember(SearchTeamMember SearchTeamMember)
        {
            try
            {
                DropDownSelect MemberStatusDropDownSelect = new DropDownSelect(SearchTeamMember.MemberStatus, MemberStatusDropdown);
                Browser.SelectDropdown(MemberStatusDropDownSelect);
                ClearAndFillTextBox MemberClearNFillNTextBox = new ClearAndFillTextBox(MemberSearchTextBox, SearchTeamMember.Member);
                Browser.ClearAndFillTextBox(MemberClearNFillNTextBox);
                SearchProjectButton.Click();
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[1] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void EditProjectTeam(EditProjectTeam EditProjectTeam)
        {
            try
            {
                SearchTeamMember(EditProjectTeam.SearchTeamMember);
                IList<IWebElement> ProjectTeamEditLink = Browser.Driver.FindElements(By.ClassName("editMember"));
                if (ProjectTeamEditLink.Count != 0)
                {
                    ProjectTeamEditLink[0].Click();
                }
                FillMemberDetails(EditProjectTeam.TeamMemberDetails);
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[1] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void DeleteProjectTeam(DeleteProjectTeam DeleteProjectTeam)
        {
            try
            {
                SearchTeamMember(DeleteProjectTeam.SearchTeamMember);
                IList<IWebElement> ProjectTeamDeleteLink = Browser.Driver.FindElements(By.ClassName("deletemember"));
                if (ProjectTeamDeleteLink.Count != 0)
                {
                    ProjectTeamDeleteLink[0].Click();
                }
                Browser.Confirm(DeleteProjectTeam.ConfirmDelete);
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[1] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        //Product
        public void ProductPlan(ProductPlan ProductPlan)
        {
            try
            {
                ClearAndFillTextBox ProductNameClearNFillTextBox = new ClearAndFillTextBox(ProductNameTextBox, ProductPlan.ProductName);
                ClearAndFillTextBox ProductVisionClearNFillTextBox = new ClearAndFillTextBox(ProductVisionTextBox, ProductPlan.ProductVision);
                ClearAndFillTextBox ProductDevelopmentScopeClearNFillTextBox = new ClearAndFillTextBox(DevelopmentScopeTextBox, ProductPlan.DevelopmentScope);
                ClearAndFillTextBox ProductOutOfScopeClearNFillTextBox = new ClearAndFillTextBox(OutOfScopeTextBox, ProductPlan.OutOfScope);
                Browser.ClearAndFillTextBox(ProductNameClearNFillTextBox);
                Browser.ClearAndFillTextBox(ProductVisionClearNFillTextBox);
                Browser.ClearAndFillTextBox(ProductDevelopmentScopeClearNFillTextBox);
                Browser.ClearAndFillTextBox(ProductOutOfScopeClearNFillTextBox);
                SaveProductPlanButon.Click();
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[1] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        //Release
        public void ChangeReleaseSubMenu(string SubMenu)
        {
            try
            {
                IList<IWebElement> Tabs = ReleaseTabs.FindElements(By.TagName("li"));
                switch (SubMenu)
                {
                    case "Goal":
                        {
                            Tabs[0].Click();
                            break;
                        }
                    case "Timelines":
                        {
                            Tabs[1].Click();
                            break;
                        }
                    case "DOD":
                        {
                            Tabs[2].Click();
                            break;
                        }
                    case "Activities":
                        {
                            Tabs[3].Click();
                            break;
                        }
                }
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[1] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void CheckRelease(bool ReleaseCheck)
        {
            try
            {
                switch (ReleaseCheck)
                {
                    case true:
                        {
                            ChkBox ShowReleaseChkBox = new ChkBox(true, ShowReleaseCheckBox);
                            Browser.CheckBox(ShowReleaseChkBox);
                            break;
                        }
                    case false:
                        {
                            ChkBox ShowUnReleaseChkBox = new ChkBox(true, ShowUnReleasedCheckBox);
                            Browser.CheckBox(ShowUnReleaseChkBox);
                            break;
                        }
                }
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[1] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void AddRelease(AddRelease AddRelease)
        {
            try
            {
                CheckRelease(AddRelease.ReleaseCheck);
                AddReleaseButton.Click();
                FillReleaseDetails(AddRelease.ReleaseDetails);
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[1] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void SetReleaseStatus(string Status)
        {
            try
            {
                //IWebElement ReleaseStatusDiv = Browser.Driver.FindElement(By.ClassName("releasedStatus"));
                //IWebElement ReleaseColourfulStatusDiv = ReleaseStatusDiv.FindElement(By.ClassName("releasecolourfulStatus"));
                //IList<IWebElement> ReleaseColourHeader = ReleaseColourfulStatusDiv.FindElements(By.TagName("ul"));
                //IList<IWebElement> ReleaseColor = ReleaseColourHeader[0].FindElements(By.TagName("li"));

                GetStatus ReleaseGrayStatus = new GetStatus(ReleaseGrayColor, Status);
                GetStatus ReleaseGreenStatus = new GetStatus(ReleaseGreenColor, Status);
                GetStatus ReleaseOrangeStatus = new GetStatus(ReleaseOrangeColor, Status);
                GetStatus ReleaseRedStatus = new GetStatus(ReleaseRedColor, Status);
                GetStatus ReleaseBlueStatus = new GetStatus(ReleaseBlueColor, Status);
                switch (Status)
                {
                    case "Not Started":
                        {
                            ReleaseGrayColorLink.Click();
                            GetStatus(ReleaseGrayStatus);
                            break;
                        }
                    case "In Planning":
                    case "In Development":
                    case "In Hardening":
                    case "UAT":
                    case "Active":
                        {
                            ReleaseGreenColorLink.Click();
                            GetStatus(ReleaseGreenStatus);
                            break;
                        }
                    case "Delayed":
                        {
                            ReleaseOrangeColorLink.Click();
                            GetStatus(ReleaseOrangeStatus);
                            break;
                        }
                    case "On Hold":
                    case "Inactive":
                    case "Cancelled":
                        {
                            ReleaseRedColorLink.Click();
                            GetStatus(ReleaseRedStatus);
                            break;
                        }
                    case "Released":
                        {
                            ReleaseBlueColorLink.Click();
                            GetStatus(ReleaseBlueStatus);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ReleaseOperation(ReleaseOperation ReleaseOperation)
        {
            try
            {
                IWebElement ReleaseTable = Browser.Driver.FindElement(By.ClassName("releaseTable"));
                IList<IWebElement> Rows = ReleaseTable.FindElements(By.ClassName("row"));
                IWebElement UserAction = Rows[ReleaseOperation.RowNo].FindElement(By.ClassName("userAction"));
                switch (ReleaseOperation.Action)
                {
                    case "Edit Releases":
                        {
                            IWebElement EditReleaseLink = UserAction.FindElement(By.ClassName("editRelease"));
                            Browser.ClickOnInvisibleElement(EditReleaseLink);
                            break;
                        }
                    case "View Stories":
                        {
                            IWebElement ViewStoriesLink = UserAction.FindElement(By.ClassName("viewStories"));
                            Browser.ClickOnInvisibleElement(ViewStoriesLink);
                            break;
                        }
                    case "Release Note":
                        {
                            IWebElement ReleaseNoteLink = UserAction.FindElement(By.ClassName("releaseNote"));
                            Browser.ClickOnInvisibleElement(ReleaseNoteLink);
                            break;
                        }
                    case "Status Release":
                        {
                            IWebElement StatusReleaseLink = UserAction.FindElement(By.ClassName("statusRelease"));
                            Browser.ClickOnInvisibleElement(StatusReleaseLink);
                            break;
                        }
                    case "Delete Release":
                        {
                            IWebElement DeleteReleaseLink = UserAction.FindElement(By.ClassName("DeleteRelease"));
                            Browser.ClickOnInvisibleElement(DeleteReleaseLink);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EditReleaseDetails(EditRelease EditRelease)
        {
            try
            {
                CheckRelease(EditRelease.AddRelease.ReleaseCheck);
                ReleaseOperation ReleaseOperationI = new ReleaseOperation(EditRelease.rowno, "Edit Releases");
                ReleaseOperation(ReleaseOperationI);
                FillReleaseDetails(EditRelease.AddRelease.ReleaseDetails);
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[1] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void FillReleaseDetails(ReleaseDetails ReleaseDetails)
        {
            try
            {
                SetReleaseGoal(ReleaseDetails.ReleaseGoal);
                Browser.ClickOnFade();
                ChangeReleaseSubMenu("Timelines");
                ReleaseTimeLines(ReleaseDetails.ReleaseTimeLines);
                //Browser.ClickOnFade();
                ChangeReleaseSubMenu("DOD");
                SetReleaseDOD(ReleaseDetails.ReleaseDOD);
                //Browser.ClickOnFade();
                ChangeReleaseSubMenu("Activities");
                SetReleaseActivities(ReleaseDetails.Activity);
                //Browser.ClickOnFade();
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[1] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void SetReleaseGoal(ReleaseGoal releaseGoal)
        {
            try
            {
                ClearAndFillTextBox NameClearNFillTextBox = new ClearAndFillTextBox(ReleaseNameTextBox, releaseGoal.Name);
                ClearAndFillTextBox GoalClearNFillTextBox = new ClearAndFillTextBox(ReleaseGoalTextBox, releaseGoal.Goal);
                ClearAndFillTextBox NoteClearNFillTextBox = new ClearAndFillTextBox(NoteTextBox, releaseGoal.Note);
                Browser.ClearAndFillTextBox(NameClearNFillTextBox);
                Browser.ClearAndFillTextBox(GoalClearNFillTextBox);
                Browser.ClearAndFillTextBox(NoteClearNFillTextBox);
                SaveCancel ReleaseSaveCancel = new SaveCancel(SaveReleaseButton, BackToReleaseList, releaseGoal.SaveGoal);
                Browser.SaveCancel(ReleaseSaveCancel);
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[1] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void ReleaseTimeLines(ReleaseTimeLines releaseTimelines)
        {
            try
            {
                ClearAndFillTextBox DevStartDateClearNFillTextBox = new ClearAndFillTextBox(DevelopmentStartDateTextBox, releaseTimelines.DevelopmentStartDate);
                ClearAndFillTextBox DevEndDateClearNFillTextBox = new ClearAndFillTextBox(DevelopmentEndDateTextBox, releaseTimelines.DevelopmentEndDate);
                Browser.ClearAndFillTextBox(DevStartDateClearNFillTextBox);
                Browser.ClearAndFillTextBox(DevEndDateClearNFillTextBox);
                switch (releaseTimelines.HardeningRequired)
                {
                    case true:
                        {
                            HardeningRequiredYesRadioButton.Click();
                            ClearAndFillTextBox HardeningStartDateClearNFillTextBox = new ClearAndFillTextBox(HardeningStartDateTextBox, releaseTimelines.HardeningStartDate);
                            ClearAndFillTextBox HardeningEndDateClearNFillTextBox = new ClearAndFillTextBox(HardeningEndDateTextBox, releaseTimelines.HardeningEndDate);
                            Browser.ClearAndFillTextBox(HardeningStartDateClearNFillTextBox);
                            Browser.ClearAndFillTextBox(HardeningEndDateClearNFillTextBox);
                            break;
                        }
                    case false:
                        {
                            HardeningRequiredNoRadioButton.Click();
                            break;
                        }
                }
                ClearAndFillTextBox PlanReleaseDateClearNFillTextBox = new ClearAndFillTextBox(PlanReleaseDateTextBox, releaseTimelines.PlanReleaseDate);
                ClearAndFillTextBox StoriesNoClearNFillTextBox = new ClearAndFillTextBox(StoriesNoTextBox, releaseTimelines.StoriesNo);
                ClearAndFillTextBox StoryPointClearNFillTextBox = new ClearAndFillTextBox(StoryPointTextBox, releaseTimelines.StoryPoint);
                ClearAndFillTextBox EstimatedVelocityClearNFillTextBox = new ClearAndFillTextBox(EstimatedVelocityTextBox, releaseTimelines.EstimatedVelocity);
                ClearAndFillTextBox PlannedsprintNoClearNFillTextBox = new ClearAndFillTextBox(PlannedsprintNoTextBox, releaseTimelines.PlannedsprintNo);
                Browser.ClearAndFillTextBox(PlanReleaseDateClearNFillTextBox);
                Browser.ClearAndFillTextBox(StoriesNoClearNFillTextBox);
                Browser.ClearAndFillTextBox(StoryPointClearNFillTextBox);
                Browser.ClearAndFillTextBox(EstimatedVelocityClearNFillTextBox);
                Browser.ClearAndFillTextBox(PlannedsprintNoClearNFillTextBox);
                SaveCancel ReleaseTimeLinesSaveCancel = new SaveCancel(SubmitQueryButton, BackToReleaseList, releaseTimelines.SaveReleaseTimeline);
                Browser.SaveCancel(ReleaseTimeLinesSaveCancel);
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[1] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void SetReleaseDOD(ReleaseDOD releaseDOD)
        {
            try
            {
                int i = 0;
                foreach (DOD sprint in releaseDOD.SDOD)
                {
                    IList<IWebElement> DODDropDown = Browser.Driver.FindElements(By.Id("DOD"));
                    IList<IWebElement> OwnerTextBox = Browser.Driver.FindElements(By.ClassName("Owner"));
                    DropDownSelect SprintDODSelectDropDown = new DropDownSelect(sprint.DODselect, DODDropDown[i]);
                    Browser.SelectDropdown(SprintDODSelectDropDown);
                    ClearAndFillTextBox OwnerClearNFillTextBox = new ClearAndFillTextBox(OwnerTextBox[i], sprint.Owner);
                    Browser.ClearAndFillTextBox(OwnerClearNFillTextBox);
                    i++;
                    if (i < releaseDOD.SDOD.Count())
                    {
                        AddDODSprintButton.Click();
                    }
                }
                int j = 0;
                foreach (DOD release in releaseDOD.RDOD)
                {
                    IList<IWebElement> DODDropDown = Browser.Driver.FindElements(By.Id("DOD"));
                    IList<IWebElement> OwnerTextBox = Browser.Driver.FindElements(By.ClassName("Owner"));
                    DropDownSelect ReleaseDODSelectDropDown = new DropDownSelect(release.DODselect, DODDropDown[j + releaseDOD.SDOD.Count()]);
                    Browser.SelectDropdown(ReleaseDODSelectDropDown);
                    ClearAndFillTextBox ReleaseOwnerClearNFillTextBox = new ClearAndFillTextBox(OwnerTextBox[j + releaseDOD.SDOD.Count()], release.Owner);
                    Browser.ClearAndFillTextBox(ReleaseOwnerClearNFillTextBox);
                    j++;
                    if (j < releaseDOD.SDOD.Count())
                    {
                        AddDODReleaseButton.Click();
                    }
                }
                SaveCancel ReleaseDODSaveCancel = new SaveCancel(SaveDODButton, BackToReleaseList, releaseDOD.SaveDOD);
                Browser.SaveCancel(ReleaseDODSaveCancel);
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[1] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void SetReleaseActivities(Activity Activity)
        {
            try
            {
                int i = 1;
                IWebElement OwnerTextBox = Browser.Driver.FindElements(By.Id("Owner"))[i];
                IWebElement DueDateTextBox = Browser.Driver.FindElements(By.Id("ValidDueDate"))[i];
                foreach (Activities activity in Activity.Activities)
                {
                    IList<IWebElement> CategoryDropDown = Browser.Driver.FindElements(By.Id("Category"));
                    IList<IWebElement> ActivityDropDown = Browser.Driver.FindElements(By.Id("Activity"));
                    DropDownSelect CategoryDropDownSelect = new DropDownSelect(activity.Category, CategoryDropDown[i]);
                    DropDownSelect ActivityDropDownSelect = new DropDownSelect(activity.Activity, ActivityDropDown[i]);
                    Browser.SelectDropdown(CategoryDropDownSelect);
                    Browser.SelectDropdown(ActivityDropDownSelect);
                    ClearAndFillTextBox OwnerClearNFillTextBox = new ClearAndFillTextBox(OwnerTextBox, activity.Owner);
                    ClearAndFillTextBox DueDateClearNFillTextBox = new ClearAndFillTextBox(DueDateTextBox, activity.DueDate);
                    Browser.ClearAndFillTextBox(OwnerClearNFillTextBox);
                    Browser.ClearAndFillTextBox(DueDateClearNFillTextBox);
                    if (i < Activity.Activities.Length)
                    {
                        AddActivities.Click();
                        OwnerTextBox = Browser.Driver.FindElement(By.Id("Owner_" + i.ToString()));
                        DueDateTextBox = Browser.Driver.FindElement(By.Id("ValidDueDate_" + i.ToString()));
                    }
                    i++;
                }
                SaveCancel ActivitySaveCancel = new SaveCancel(SaveActivites, BackToReleaseList, Activity.SaveActivity);
                Browser.SaveCancel(ActivitySaveCancel);
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[1] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void MergeRelease(MergeRelease MergeRelease)
        {
            try
            {
                IWebElement MergeReleaseBtn = Browser.Driver.FindElement(By.Id("btnMergeReleases"));
                MergeReleaseBtn.Click();
                IWebElement MergeReleaseTextBox = Browser.Driver.FindElement(By.Id("merges"));
                IWebElement DropDownRelease = Browser.Driver.FindElement(By.Id("ddlRelases"));
                IWebElement MergeBtn = Browser.Driver.FindElement(By.Id("mergeReleases"));
                IWebElement CancelBtn = Browser.Driver.FindElement(By.ClassName("sfCancel"));
                ClearAndFillTextBox MergeReleaseClearNFill = new ClearAndFillTextBox(MergeReleaseTextBox, MergeRelease.Release1);
                Browser.ClearAndFillTextBox(MergeReleaseClearNFill);
                IWebElement ReleaseListSpan = Browser.Driver.FindElement(By.Id("ReleaseList"));
                IWebElement ReleaseListUL = ReleaseListSpan.FindElement(By.TagName("ul"));
                IList<IWebElement> ReleaseList = ReleaseListUL.FindElements(By.TagName("li"));
                if (ReleaseList.Count != 0)
                {
                    ReleaseList[0].Click();
                }
                DropDownSelect ReleaseDropDown = new DropDownSelect(MergeRelease.Release2, DropDownRelease);
                Browser.SelectDropdown(ReleaseDropDown);
                SaveCancel Merge = new SaveCancel(MergeBtn, CancelBtn, MergeRelease.ReleaseMerge);
                Browser.SaveCancel(Merge);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Sprint
        public void AddMemberOnLeave(MemberOnLeave[] MemberOnLeave)
        {
            try
            {
                IWebElement AddMemberOnLeaveBtn = Browser.Driver.FindElement(By.ClassName("addLeaveDate"));
                int i = 0;
                foreach(MemberOnLeave LeaveMember in MemberOnLeave)
                {
                    IList<IWebElement> LeaveMembersList = Browser.Driver.FindElements(By.ClassName("memberlist"));
                    if(LeaveMembersList.Count < MemberOnLeave.Count())
                    {
                        AddMemberOnLeaveBtn.Click();
                    }
                    IWebElement LeaveDateTextBox = LeaveMembersList[i].FindElement(By.ClassName("dateLeave"));
                    IWebElement LeaveMemberTextBox = LeaveMembersList[i].FindElement(By.ClassName("memberName"));
                    IWebElement LeaveMemberSpan = LeaveMembersList[i].FindElement(By.TagName("span"));
                    IWebElement LeaveMemberUL = LeaveMembersList[i].FindElement(By.TagName("ul"));
                    IList<IWebElement> LeaveMemberSelect = LeaveMembersList[i].FindElements(By.TagName("li"));
                    IList<IWebElement> LeaveDayLabel = LeaveMembersList[i].FindElements(By.TagName("label"));
                    ClearAndFillTextBox LeaveMemberClearNFill = new ClearAndFillTextBox(LeaveMemberTextBox, LeaveMember.MemberName);
                    ClearAndFillTextBox LeaveDateClearNFill = new ClearAndFillTextBox(LeaveDateTextBox, LeaveMember.LeaveDate);
                    Browser.ClearAndFillTextBox(LeaveMemberClearNFill);
                    if(LeaveMemberSelect.Count != 0)
                    {
                        LeaveMemberSelect[0].Click();
                    }
                    switch (LeaveMember.Day)
                    {
                        case "Full":
                            {
                                IWebElement FullDayRadioBtn = LeaveDayLabel[0].FindElement(By.TagName("input"));
                                FullDayRadioBtn.Click();
                                break;
                            }
                        case "Half":
                            {
                                IWebElement HalfDayRadioBtn = LeaveDayLabel[1].FindElement(By.TagName("input"));
                                HalfDayRadioBtn.Click();
                                break;
                            }
                    }
                    i++;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void FillSprintDetails(Sprint sprint)
        {
            try
            {
                ClearAndFillTextBox SprintNameClearNFillTextBox = new ClearAndFillTextBox(SprintNameTextBox, sprint.SprintName);
                ClearAndFillTextBox SprintStartDateClearNFillTextBox = new ClearAndFillTextBox(SprintStartDateTextBox, sprint.StartDate);
                ClearAndFillTextBox SprintEndDateClearNFillTextBox = new ClearAndFillTextBox(SprintEndDateTextBox, sprint.EndDate);
                ClearAndFillTextBox StandUpMeetingTimeClearNFillTextBox = new ClearAndFillTextBox(StandUpMeetingTimeTextBox, sprint.StandUpMeetingTime);
                ClearAndFillTextBox BackUpScrumMasterClearNFillTextBox = new ClearAndFillTextBox(BackupScrumMasterTextBox, sprint.BackUpScrumMaster);
                ClearAndFillTextBox SprintGoalClearNFillTextBox = new ClearAndFillTextBox(SprintGoalTextBox, sprint.SprintGoal);
                Browser.ClearAndFillTextBox(SprintNameClearNFillTextBox);
                DropDownSelect ReleaseDropDownSelect = new DropDownSelect(sprint.Release, ReleaseDropDown);
                Browser.SelectDropdown(ReleaseDropDownSelect);
                Browser.ClearAndFillTextBox(SprintStartDateClearNFillTextBox);
                Browser.ClearAndFillTextBox(SprintEndDateClearNFillTextBox);
                Browser.ClearAndFillTextBox(StandUpMeetingTimeClearNFillTextBox);
                Browser.ClearAndFillTextBox(BackUpScrumMasterClearNFillTextBox);
                Browser.ClearAndFillTextBox(SprintGoalClearNFillTextBox);
                SaveCancel SprintSaveCancel = new SaveCancel(SaveSprintButton, CancelSprintButton, sprint.Save);
                Browser.SaveCancel(SprintSaveCancel);
                //IWebElement Fade = Browser.Driver.FindElement(By.ClassName("fade"));
                //Browser.MouseClick(Fade);
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[1] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void AddSprint(Sprint[] sprint)
        {
            try
            {
                foreach (Sprint Sprint in sprint)
                {
                    //AddSprintButton.Click();
                    IWebElement CreateSprintBtn = Browser.Driver.FindElement(By.Id("spCreateSprint"));
                    CreateSprintBtn.Click();
                    int i = 0;
                    IWebElement DynamicSprint = Browser.Driver.FindElement(By.Id("divCreateDynamicSprint"));
                    IList<IWebElement> UL = DynamicSprint.FindElements(By.TagName("ul"));
                    IWebElement DivSummary = UL[Sprint.M].FindElement(By.Id("divSummary"));
                    foreach (int n in Sprint.N)
                    {
                        IWebElement UnassignedStory = Browser.Driver.FindElement(By.ClassName("B-backlog-backlog-Unassigned"));
                        IWebElement SprintAccordion = UnassignedStory.FindElement(By.Id("sprintAccordion"));
                        IWebElement Accordion = SprintAccordion.FindElement(By.Id("accordion"));
                        IList<IWebElement> StoryList = Accordion.FindElements(By.TagName("li"));
                        DragNDrop MoveStoryToSprint = new DragNDrop(StoryList[n - i], DivSummary);
                        Browser.DragAndDrop(MoveStoryToSprint);
                        i++;
                    }
                    //FillSprintDetails(Sprint);
                }
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[1] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        public void EditSprint(EditSprint EditSprint)
        {
            try
            {
                int i = 0;
                foreach (Sprint sprint in EditSprint.Sprint)
                {
                    DropDownSelect ReleaseDropDownSelect = new DropDownSelect(EditSprint.Release[i], ReleaseDropDown);
                    Browser.SelectDropdown(ReleaseDropDownSelect);
                    IList<IWebElement> SprintRows = SprintListDiv.FindElements(By.ClassName("row"));
                    IWebElement UserAction = SprintRows[EditSprint.rowno[i]].FindElement(By.ClassName("userAction"));
                    IWebElement EditSprintLink = UserAction.FindElement(By.ClassName("bicon-icon-edit"));
                    Browser.ClickOnInvisibleElement(EditSprintLink);
                    FillSprintDetails(sprint);
                    i++;
                }
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[1] = ex.Message;
                //Browser.TestResults.Fail++;
            }
        }
        //Board
        public void FilterTask(FilterTasks FilterTask)
        {
            try
            {
                ClickProjectMenu("Board");
                IWebElement AllTaskBtn = Browser.Driver.FindElement(By.Id("btnAllTasks"));
                IWebElement TodaysTaskBtn = Browser.Driver.FindElement(By.Id("btnTodaysTask"));
                IWebElement OverDueTaskBtn = Browser.Driver.FindElement(By.Id("OverdueTask"));
                IWebElement ShowMineChkBox = Browser.Driver.FindElement(By.Id("showMine"));
                IWebElement TaskStatusDropDown = Browser.Driver.FindElement(By.ClassName("ddlStatus"));
                ChkBox ShowMineChk = new ChkBox(FilterTask.ShowMine, ShowMineChkBox);
                Browser.CheckBox(ShowMineChk);
                DropDownSelect DropDownTaskStatus = new DropDownSelect(FilterTask.TaskStatus, TaskStatusDropDown);
                Browser.SelectDropdown(DropDownTaskStatus);
                switch (FilterTask.TaskView)
                {
                    case "All Task":
                        {
                            AllTaskBtn.Click();
                            break;
                        }
                    case "Todays Task":
                        {
                            TodaysTaskBtn.Click();
                            break;
                        }
                    case "OverDue Task":
                        {
                            OverDueTaskBtn.Click();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CloseSprint(CloseSprint CloseSprint)
        {
            try
            {
                IWebElement CloseSprintBtn = Browser.Driver.FindElement(By.Id("btnCloseSprint"));
                CloseSprintBtn.Click();
                IWebElement SprintEndDateTextBox = Browser.Driver.FindElement(By.Id("sprintCloseDate"));
                ClearAndFillTextBox SprintEndDateClearNFill = new ClearAndFillTextBox(SprintEndDateTextBox, CloseSprint.SprintEndDate);
                Browser.ClearAndFillTextBox(SprintEndDateClearNFill);
                IWebElement ButtonCloseSprint = Browser.Driver.FindElement(By.Id("CloseSprint"));
                SaveCancel SprintClose = new SaveCancel(ButtonCloseSprint, CancelSprintButton, CloseSprint.Close);
                Browser.SaveCancel(SprintClose);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void InProgress(InProgressTo InProgressTo)
        {
            try
            {
                IWebElement ActualTaskHoursTextBox = Browser.Driver.FindElement(By.Id("actualTaskHours"));
                IWebElement BugFixingHoursTextBox = Browser.Driver.FindElement(By.Id("actualBugFixingHours"));
                IWebElement SaveProgress = Browser.Driver.FindElement(By.Id("btnSaveToVerify"));
                IWebElement CancelProgress = Browser.Driver.FindElement(By.Id("btnCancelVerify"));
                ClearAndFillTextBox TaskHoursClearNFill = new ClearAndFillTextBox(ActualTaskHoursTextBox, InProgressTo.TaskHours);
                ClearAndFillTextBox BugFixingHoursClearNFill = new ClearAndFillTextBox(BugFixingHoursTextBox, InProgressTo.BugFixingHours);
                Browser.ClearAndFillTextBox(TaskHoursClearNFill);
                Browser.ClearAndFillTextBox(BugFixingHoursClearNFill);
                SaveCancel SaveProgressToVerify = new SaveCancel(SaveProgress, CancelProgress, true);
                Browser.SaveCancel(SaveProgressToVerify);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void TaskProcess(TaskProcess TaskProcess)
        {
            try
            {
                IList<IWebElement> StoriesTaskList = Browser.Driver.FindElements(By.ClassName("all-task-list"));
                IList<IWebElement> ToDoDiv = StoriesTaskList[TaskProcess.StoryNo].FindElements(By.ClassName("task-to-do"));
                IList<IWebElement> InProgressDiv = StoriesTaskList[TaskProcess.StoryNo].FindElements(By.ClassName("task-in-progress"));
                IList<IWebElement> ToVerifyDiv = StoriesTaskList[TaskProcess.StoryNo].FindElements(By.ClassName("task-to-verify"));
                IList<IWebElement> DoneDiv = StoriesTaskList[TaskProcess.StoryNo].FindElements(By.ClassName("task-done"));
                switch (TaskProcess.Movement)
                {
                    case "To-Do:In-Progress":
                        {
                            IList<IWebElement> TaskList = ToDoDiv[0].FindElements(By.ClassName("task-detail"));
                            DragNDrop ToDoTaskToProgress = new DragNDrop(TaskList[TaskProcess.TaskNo], InProgressDiv[0]);
                            Browser.DragAndDrop(ToDoTaskToProgress);
                            break;
                        }
                    case "In-Progress:To-Verify":
                        {
                            IList<IWebElement> TaskList = InProgressDiv[0].FindElements(By.ClassName("task-detail"));
                            DragNDrop InProgressTaskToVerify = new DragNDrop(TaskList[TaskProcess.TaskNo], ToVerifyDiv[0]);
                            Browser.DragAndDrop(InProgressTaskToVerify);
                            InProgress(TaskProcess.InProgressTo);
                            break;
                        }
                    case "In-Progress:Done":
                        {
                            IList<IWebElement> TaskList = InProgressDiv[0].FindElements(By.ClassName("task-detail"));
                            DragNDrop InProgressTaskToDone = new DragNDrop(TaskList[TaskProcess.TaskNo], DoneDiv[0]);
                            Browser.DragAndDrop(InProgressTaskToDone);
                            InProgress(TaskProcess.InProgressTo);
                            break;
                        }
                    case "To-Verify:Done":
                        {
                            IList<IWebElement> TaskList = ToVerifyDiv[0].FindElements(By.ClassName("task-detail"));
                            DragNDrop ToVerifyTaskToDone = new DragNDrop(TaskList[TaskProcess.TaskNo], DoneDiv[0]);
                            Browser.DragAndDrop(ToVerifyTaskToDone);
                            IWebElement TestHoursTextBox = Browser.Driver.FindElement(By.Id("actualTestHours"));
                            ClearAndFillTextBox TestHoursClearNFill = new ClearAndFillTextBox(TestHoursTextBox, TaskProcess.TestHours);
                            Browser.ClearAndFillTextBox(TestHoursClearNFill);
                            IWebElement SaveTestHours = Browser.Driver.FindElement(By.Id("btnSaveToDone"));
                            IWebElement CancelTestHours = Browser.Driver.FindElement(By.Id("btnCancelDone"));
                            SaveCancel Save = new SaveCancel(SaveTestHours, CancelTestHours, true);
                            Browser.SaveCancel(Save);
                            IWebElement SprintCloseDateTextBox = Browser.Driver.FindElement(By.Id("sprintCloseDate"));
                            ClearAndFillTextBox SprintCloseDateClearNFill = new ClearAndFillTextBox(SprintCloseDateTextBox, TaskProcess.SprintCloseDate);
                            Browser.ClearAndFillTextBox(SprintCloseDateClearNFill);
                            IWebElement CloseSprintBtn = Browser.Driver.FindElement(By.Id("CloseSprint"));
                            IWebElement CancelCloseSprintBtn = Browser.Driver.FindElement(By.Id("sfPopUpCancel"));
                            SaveCancel CloseSprint = new SaveCancel(CloseSprintBtn, CancelCloseSprintBtn, true);
                            Browser.SaveCancel(CloseSprint);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //BackLog
        public void AddStory(AddStory AddStory)
        {
            try
            {
                if (AddStory.AddNewStory)
                {
                    IWebElement AddStoryBtn = Browser.Driver.FindElement(By.Id("spnCreateStory"));
                    AddStoryBtn.Click();
                    IWebElement StoryDiv = Browser.Driver.FindElement(By.Id("divContainEditable"));
                    ClearAndFillTextBox StoryClearNFill = new ClearAndFillTextBox(StoryDiv, AddStory.StoryName);
                    Browser.ClearAndFillTextBox(StoryClearNFill);
                    StoryDiv.SendKeys(Keys.Enter);
                }
                IWebElement SprintStories = Browser.Driver.FindElement(By.ClassName("B-backlog-backlog-Unassigned"));
                IWebElement SprintAccordionDiv = SprintStories.FindElement(By.TagName("div"));
                IWebElement Accordion = SprintAccordionDiv.FindElement(By.Id("accordion"));
                IList<IWebElement> AccordionList = Accordion.FindElements(By.TagName("li"));
                IWebElement List = AccordionList[0].FindElement(By.TagName("ul"));
                IWebElement EditStoryBtn = List.FindElement(By.ClassName("sfEditStory"));
                Browser.ClickOnInvisibleElement(EditStoryBtn);
                IWebElement EpicCheckBox = Browser.Driver.FindElement(By.Id("chkEpic"));
                IWebElement StoryNameTextBox = Browser.Driver.FindElement(By.Id("Story"));
                IWebElement ConditionOfSatisfactionTextBox = Browser.Driver.FindElement(By.Id("txtConditionOfSatisfaction"));
                IWebElement StoryPointsDropDown = Browser.Driver.FindElement(By.Id("ddlStoryPoint"));
                IWebElement PriorityDropDown = Browser.Driver.FindElement(By.Id("ddlPriority"));
                IWebElement ThemeDropDown = Browser.Driver.FindElement(By.Id("ddlTheme"));
                IWebElement StoryTypeDropDown = Browser.Driver.FindElement(By.Id("ddlStoryType"));
                IWebElement ReleaseDropDown = Browser.Driver.FindElement(By.Id("ddlRelease"));
                IWebElement AssignTextBox = Browser.Driver.FindElement(By.Id("txtAssign"));
                IWebElement DueDateTextBox = Browser.Driver.FindElement(By.Id("txtDueDate"));
                IWebElement DependenciesTextBox = Browser.Driver.FindElement(By.Id("txtDependencies"));
                IWebElement TagTextBox = Browser.Driver.FindElement(By.Id("txtTag"));
                IWebElement AddTheme = Browser.Driver.FindElement(By.Id("AddTheme1"));
                IWebElement AddStoryType = Browser.Driver.FindElement(By.Id("AddStoryType"));
                IWebElement SaveStory = Browser.Driver.FindElement(By.Id("spnSaveStory"));
                ChkBox EpicChkBox = new ChkBox(AddStory.Epic, EpicCheckBox);
                ClearAndFillTextBox StoryNameClearNFill = new ClearAndFillTextBox(StoryNameTextBox, AddStory.StoryName);
                ClearAndFillTextBox ConditionOfSatisfactionClearNFill = new ClearAndFillTextBox(ConditionOfSatisfactionTextBox, AddStory.ConditionOfSatisfaction);
                DropDownSelect DropDownStoryPoints = new DropDownSelect(AddStory.StoryPoints, StoryPointsDropDown);
                DropDownSelect DropDownPriority = new DropDownSelect(AddStory.Priority, PriorityDropDown);
                DropDownSelect DropDownTheme = new DropDownSelect(AddStory.Theme, ThemeDropDown);
                DropDownSelect DropDownStoryType = new DropDownSelect(AddStory.StoryType, StoryTypeDropDown);
                DropDownSelect DropDownRelease = new DropDownSelect(AddStory.Release, ReleaseDropDown);
                ClearAndFillTextBox AssignClearNFill = new ClearAndFillTextBox(AssignTextBox, AddStory.Assign);
                ClearAndFillTextBox DueDateClearNFill = new ClearAndFillTextBox(DueDateTextBox, AddStory.DueDate);
                ClearAndFillTextBox DependenciesClearNFill = new ClearAndFillTextBox(DependenciesTextBox, AddStory.Dependencies);
                ClearAndFillTextBox TagClearNFill = new ClearAndFillTextBox(TagTextBox, AddStory.Tag);
                Browser.CheckBox(EpicChkBox);
                Browser.ClearAndFillTextBox(StoryNameClearNFill);
                Browser.ClearAndFillTextBox(ConditionOfSatisfactionClearNFill);
                Browser.SelectDropdown(DropDownStoryPoints);
                Browser.SelectDropdown(DropDownPriority);
                try
                {
                    Browser.SelectDropdown(DropDownTheme);
                }
                catch (Exception)
                {
                    Browser.ClickOnInvisibleElement(AddTheme);
                    IWebElement ThemeTextBox = Browser.Driver.FindElement(By.Id("txtTheme"));
                    IWebElement SaveTheme = Browser.Driver.FindElement(By.Id("spnSaveTheme"));
                    IWebElement CancelTheme = Browser.Driver.FindElement(By.Id("spnClose"));
                    ClearAndFillTextBox ThemeClearNFill = new ClearAndFillTextBox(ThemeTextBox, AddStory.Theme);
                    Browser.ClearAndFillTextBox(ThemeClearNFill);
                    SaveCancel ThemeSave = new SaveCancel(SaveTheme, CancelTheme, true);
                    Browser.SaveCancel(ThemeSave);
                    CancelTheme.Click();
                    Browser.SelectDropdown(DropDownTheme);
                }
                try
                {
                    Browser.SelectDropdown(DropDownStoryType);
                }
                catch (Exception)
                {
                    Browser.ClickOnInvisibleElement(AddStoryType);
                    IWebElement AddStoryTypeTextBox = Browser.Driver.FindElement(By.Id("txtAddStoryType"));
                    IWebElement SaveStoryTypeBtn = Browser.Driver.FindElement(By.Id("spnSaveStoryType"));
                    IWebElement CancelStoryType = Browser.Driver.FindElement(By.Id("spnClose"));
                    ClearAndFillTextBox StoryTypeClearNFill = new ClearAndFillTextBox(AddStoryTypeTextBox, AddStory.StoryType);
                    Browser.ClearAndFillTextBox(StoryTypeClearNFill);
                    SaveCancel SaveStoryType = new SaveCancel(SaveStoryTypeBtn, CancelStoryType, true);
                    Browser.SaveCancel(SaveStoryType);
                    CancelStoryType.Click();
                    Browser.SelectDropdown(DropDownStoryType);
                }
                Browser.SelectDropdown(DropDownRelease);
                Browser.ClearAndFillTextBox(AssignClearNFill);
                IWebElement AssigneeSpan = Browser.Driver.FindElement(By.Id("TeamMemberList"));
                IWebElement Asignee = AssigneeSpan.FindElement(By.TagName("ul"));
                IList<IWebElement> AssigneeList = Asignee.FindElements(By.TagName("li"));
                if (AssigneeList.Count != 0)
                {
                    AssigneeList[0].Click();
                }
                Browser.ClearAndFillTextBox(DueDateClearNFill);
                DueDateTextBox.SendKeys(Keys.Enter);
                Browser.ClearAndFillTextBox(DependenciesClearNFill);
                Browser.ClearAndFillTextBox(TagClearNFill);
                SaveStory.Click();
                IWebElement Fade = Browser.Driver.FindElement(By.ClassName("fade"));
                Browser.MouseClick(Fade);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IWebElement StoryOperations(StoryOperations StoryOperations)
        {
            try
            {
                //IWebElement StoryUL = Browser.Driver.FindElement(By.Id("accordion"));
                IList<IWebElement> StoriesList = Browser.Driver.FindElements(By.ClassName("sprintDrpdwn"));
                //IWebElement ShowTask = StoriesList[StoryOperations.StoryNo].FindElement(By.TagName("span"));
                //IWebElement TaskCreate = StoriesList[StoryOperations.StoryNo].FindElement(By.ClassName("sTarget"));
                IWebElement StoryEdit = StoriesList[StoryOperations.StoryNo].FindElements(By.TagName("li"))[7];
                switch (StoryOperations.Operation)
                {
                    case "Edit":
                        {
                            return StoryEdit;
                        }
                    //case "CreateTask":
                    //    {
                    //        return TaskCreate;
                    //    }
                    //case "ShowTask":
                    //    {
                    //        return ShowTask;
                    //    }
                    default:
                        {
                            return null;
                        }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EditStories(int StoryNo)
        {
            try
            {
                StoryOperations EditStory = new StoryOperations(StoryNo, "Edit");
                IWebElement StoryEdit = StoryOperations(EditStory);
                Browser.ClickOnInvisibleElement(StoryEdit);              
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void StorySideMenu(StorySideMenu StorySideMenu)
        {
            try
            {
                StoryOperations EditStory = new StoryOperations(1, "Edit");
                IWebElement StoryEdit = StoryOperations(EditStory);
                Browser.ClickOnInvisibleElement(StoryEdit);
                IWebElement StoriesBtn = Browser.Driver.FindElement(By.ClassName("bicon-icon-stories"));
                IWebElement TaskBtn = Browser.Driver.FindElement(By.ClassName("bicon-icon-task"));
                IWebElement AttachmentBtn = Browser.Driver.FindElement(By.ClassName("bicon-icon-attachment"));
                IWebElement CommentBtn = Browser.Driver.FindElement(By.ClassName("bicon-icon-comment"));
                switch (StorySideMenu.Action)
                {
                    case "Story":
                        {
                            Browser.ClickOnInvisibleElement(StoriesBtn);
                            break;
                        }
                    case "Task":
                        {
                            Browser.ClickOnInvisibleElement(TaskBtn);
                            Project.ProjectPage.TaskOperation(StorySideMenu.TaskOperation);
                            break;
                        }
                    case "Attachment":
                        {
                            Browser.ClickOnInvisibleElement(AttachmentBtn);
                            IWebElement FileUpload = Browser.Driver.FindElement(By.Id("fupUploadDocument"));
                            IWebElement SaveDocument = Browser.Driver.FindElement(By.ClassName("sfSaveDocument"));
                            FileUpload.SendKeys(StorySideMenu.FilePath);
                            SaveDocument.Click();
                            break;
                        }
                    case "Comment":
                        {
                            Browser.ClickOnInvisibleElement(CommentBtn);
                            IWebElement CommentTextBox = Browser.Driver.FindElement(By.Id("txtComment"));
                            IWebElement SaveComment = Browser.Driver.FindElement(By.ClassName("sfSaveComment"));
                            ClearAndFillTextBox CommentClearNFill = new ClearAndFillTextBox(CommentTextBox, StorySideMenu.Comment);
                            Browser.ClearAndFillTextBox(CommentClearNFill);
                            SaveComment.Click();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void FillTaskDetails(FillTaskDetails FillTaskDetails)
        {
            try
            {
                IWebElement TaskCategoryAdd = Browser.Driver.FindElement(By.Id("spnAddCategory"));
                IWebElement TaskSummaryTextBox = Browser.Driver.FindElement(By.Id("txtTaskSummary"));
                IWebElement TaskDescriptionTextBox = Browser.Driver.FindElement(By.Id("txtTaskDescription"));
                IWebElement TaskEstimateTextBox = Browser.Driver.FindElement(By.Id("txtTaskEstimate"));
                IWebElement TaskCategoryDropDown = Browser.Driver.FindElement(By.Id("ddltaskCategory"));
                IWebElement AssigneeTaskTextBox = Browser.Driver.FindElement(By.Id("txtAssigneeTask"));
                IWebElement DueDateTextBox = Browser.Driver.FindElement(By.Id("txtDueDateTask"));
                IWebElement TaskActualHourTextBox = Browser.Driver.FindElement(By.Id("txtTaskActualHour"));
                IWebElement BugFixingHourTextBox = Browser.Driver.FindElement(By.Id("txtBugFixingHour"));
                IWebElement TaskStatusDropDown = Browser.Driver.FindElement(By.Id("ddltaskStatus"));
                IWebElement SaveTask = Browser.Driver.FindElement(By.Id("spnSaveTask"));
                IWebElement SaveAndAddTask = Browser.Driver.FindElement(By.Id("spnSaveAndAddAnotherTask"));
                IWebElement CancelTask = Browser.Driver.FindElement(By.Id("spnCancelTask"));
                ClearAndFillTextBox TaskSummaryClearNFill = new ClearAndFillTextBox(TaskSummaryTextBox, FillTaskDetails.TaskSummary);
                ClearAndFillTextBox TaskDescriptinClearNFill = new ClearAndFillTextBox(TaskDescriptionTextBox, FillTaskDetails.TaskDescription);
                ClearAndFillTextBox TaskEstimateClearNFill = new ClearAndFillTextBox(TaskEstimateTextBox, FillTaskDetails.TaskEstimate);
                ClearAndFillTextBox AssigneeTaskClearNFill = new ClearAndFillTextBox(AssigneeTaskTextBox, FillTaskDetails.TaskAssigne);
                ClearAndFillTextBox DueDateClearNFill = new ClearAndFillTextBox(DueDateTextBox, FillTaskDetails.TaskDueDate);
                ClearAndFillTextBox TaskActualHourClearNFill = new ClearAndFillTextBox(TaskActualHourTextBox, FillTaskDetails.TaskActualHour);
                ClearAndFillTextBox BugFixingHourClearNFill = new ClearAndFillTextBox(BugFixingHourTextBox, FillTaskDetails.BugFixingHours);
                DropDownSelect DropDownTaskCategory = new DropDownSelect(FillTaskDetails.TaskCategory, TaskCategoryDropDown);
                DropDownSelect DropDownTaskStatus = new DropDownSelect(FillTaskDetails.TaskStatus, TaskStatusDropDown);
                Browser.ClearAndFillTextBox(TaskSummaryClearNFill);
                Browser.ClearAndFillTextBox(TaskDescriptinClearNFill);
                Browser.ClearAndFillTextBox(TaskEstimateClearNFill);
                Browser.ClearAndFillTextBox(AssigneeTaskClearNFill);
                IWebElement TaskAssigneSpan = Browser.Driver.FindElement(By.Id("TeamMemberList"));
                IWebElement UL = TaskAssigneSpan.FindElement(By.TagName("ul"));
                IList<IWebElement> TaskAssigneeList = UL.FindElements(By.LinkText(FillTaskDetails.TaskAssigne));
                if (TaskAssigneeList.Count != 0)
                {
                    TaskAssigneeList[0].Click();
                }
                Browser.ClearAndFillTextBox(DueDateClearNFill);
                try
                {
                    Browser.SelectDropdown(DropDownTaskCategory);
                }
                catch (Exception)
                {
                    Browser.ClickOnInvisibleElement(TaskCategoryAdd);
                    IWebElement TaskCategoryTextBox = Browser.Driver.FindElement(By.Id("txtTaskCategory"));
                    ClearAndFillTextBox TaskCategoryClearNFill = new ClearAndFillTextBox(TaskCategoryTextBox, FillTaskDetails.TaskCategory);
                    Browser.ClearAndFillTextBox(TaskCategoryClearNFill);
                    IWebElement SaveCategory = Browser.Driver.FindElement(By.Id("spnSaveTaskCategory"));
                    IWebElement CancelCategory = Browser.Driver.FindElement(By.Id("spnClose"));
                    SaveCancel Category = new SaveCancel(SaveCategory, CancelCategory, true);
                    Browser.SaveCancel(Category);
                    CancelCategory.Click();
                    Browser.SelectDropdown(DropDownTaskCategory);
                }
                Browser.ClearAndFillTextBox(TaskActualHourClearNFill);
                Browser.ClearAndFillTextBox(BugFixingHourClearNFill);
                Browser.SelectDropdown(DropDownTaskStatus);
                switch (FillTaskDetails.SaveSettings)
                {
                    case "Save":
                        {
                            SaveTask.Click();
                            break;
                        }
                    case "Cancel":
                        {
                            CancelTask.Click();
                            break;
                        }
                    default:
                        {
                            SaveAndAddTask.Click();
                            //Do Something for the loop
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void TaskOperation(TaskOperation TaskOperation)
        {
            try
            {                
                //StoryOperations AddTaskOperation = new StoryOperations(TaskOperation.Storyno, "CreateTask");
                //IWebElement TaskCreate = StoryOperations(AddTaskOperation);
                //Browser.ClickOnInvisibleElement(TaskCreate);
                IWebElement CancelTask = Browser.Driver.FindElement(By.Id("spnTaskCancel"));
                IWebElement CreateTask = Browser.Driver.FindElement(By.Id("spnCreateTask"));
                IList<IWebElement> EditTaskList = Browser.Driver.FindElements(By.Id("spnEditTask"));
                IList<IWebElement> DeleteTaskList = Browser.Driver.FindElements(By.Id("spnDeleteTask"));
                switch (TaskOperation.TaskAdd)
                {
                    case true:
                        {
                            CreateTask.Click();
                            FillTaskDetails(TaskOperation.FillTaskDetails);
                            break;
                        }
                    case false:
                        {
                            DeleteTaskList[TaskOperation.Taskno].Click();
                            IWebElement ConfirmYes = Browser.Driver.FindElement(By.Id("ConfirmYes"));
                            IWebElement ConfirmNo = Browser.Driver.FindElement(By.Id("ConfirmNo"));
                            SaveCancel DeleteConfirm = new SaveCancel(ConfirmYes, ConfirmNo, TaskOperation.TaskDelete);
                            Browser.SaveCancel(DeleteConfirm);
                            break;
                        }
                    default:
                        {
                            EditTaskList[TaskOperation.Taskno].Click();
                            FillTaskDetails(TaskOperation.FillTaskDetails);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SearchStories(SearchStory SearchStory)
        {
            try
            {
                IWebElement StorySearchTextBox = Browser.Driver.FindElement(By.Id("txtSearchStories"));
                IWebElement EpicCheckBox = Browser.Driver.FindElement(By.Id("chkOnlyEpics"));
                IWebElement ShowMyStoriesCheckBox = Browser.Driver.FindElement(By.Id("chkOnlyMyStory"));
                ClearAndFillTextBox SearchStoryClearNFill = new ClearAndFillTextBox(StorySearchTextBox, SearchStory.Story);
                ChkBox EpicChkBox = new ChkBox(SearchStory.Epic, EpicCheckBox);
                ChkBox MyStoryChkBox = new ChkBox(SearchStory.MyStory, ShowMyStoriesCheckBox);
                Browser.ClearAndFillTextBox(SearchStoryClearNFill);
                Browser.CheckBox(EpicChkBox);
                Browser.CheckBox(MyStoryChkBox);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IWebElement GetEditDeleteLink(GetEditDelete GetEditDelete)
        {
            try
            {
                IWebElement ThemeDiv = Browser.Driver.FindElement(By.Id("b-backlog-themes-content"));
                IWebElement ThemeList = ThemeDiv.FindElement(By.TagName("ul"));
                IList<IWebElement> Theme = ThemeList.FindElements(By.TagName("li"));
                switch (GetEditDelete.Action)
                {
                    case "Edit":
                        {
                            IWebElement Edit = Theme[GetEditDelete.No].FindElement(By.ClassName("sfEditTheme"));
                            return Edit;
                        }
                    case "Delete":
                        {
                            IWebElement Delete = Theme[GetEditDelete.No].FindElement(By.ClassName("sfDeleteTheme"));
                            return Delete;
                        }
                    default:
                        {
                            return null;
                        }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EditDeleteTheme(EditDeleteTheme EditDeleteTheme)
        {
            try
            {
                IWebElement EditDeleteLink = GetEditDeleteLink(EditDeleteTheme.GetEditDelete);
                EditDeleteLink.Click();
                switch (EditDeleteTheme.GetEditDelete.Action)
                {
                    case "Edit":
                        {
                            IWebElement EditThemeTextBox = Browser.Driver.FindElement(By.ClassName("sftxtEditTheme"));
                            IWebElement UpdateThemeBtn = Browser.Driver.FindElement(By.ClassName("spnUpdateTheme"));
                            IWebElement CancelThemeBtn = Browser.Driver.FindElement(By.ClassName("spnCancelUpdateTheme"));
                            ClearAndFillTextBox ThemeClearNFill = new ClearAndFillTextBox(EditThemeTextBox, EditDeleteTheme.Theme);
                            SaveCancel UpdateTheme = new SaveCancel(UpdateThemeBtn, CancelThemeBtn, EditDeleteTheme.UpdateDelete);
                            Browser.ClearAndFillTextBox(ThemeClearNFill);
                            Browser.SaveCancel(UpdateTheme);
                            break;
                        }
                    case "Delete":
                        {
                            IWebElement DeleteThemeBtn = Browser.Driver.FindElement(By.ClassName("ConfirmYes"));
                            IWebElement DeleteCancelThemeBtn = Browser.Driver.FindElement(By.ClassName("ConfirmNo"));
                            SaveCancel DeleteCancel = new SaveCancel(DeleteThemeBtn, DeleteCancelThemeBtn, EditDeleteTheme.UpdateDelete);
                            Browser.SaveCancel(DeleteCancel);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AddStories(int[] n)
        {
            try
            {
                IWebElement AddMoreStoriesBtn = Browser.Driver.FindElement(By.Id("AddMoreStories"));
                AddMoreStoriesBtn.Click();
                IWebElement StoriesDiv = Browser.Driver.FindElement(By.ClassName("Accordian_story"));
                IWebElement StoriesUl = StoriesDiv.FindElement(By.TagName("ul"));
                IList<IWebElement> Story = StoriesUl.FindElements(By.TagName("li"));
                IWebElement AddStory = Browser.Driver.FindElement(By.Id("spnAddMoreStories"));
                foreach (int m in n)
                {
                    IWebElement StoryList = Story[m].FindElement(By.ClassName("sprintDrpdwn"));
                    string Storyclass = StoryList.GetAttribute("class");
                    if (!Storyclass.Contains("selected"))
                    {
                        StoryList.Click();
                    }
                }
                Browser.ScrollDown(true);
                AddStory.Click();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CreateSprint(CreateSprint CreateSprint)
        {
            try
            {
                //CreateSprintLink.Click();
                IWebElement DropStory = Browser.Driver.FindElement(By.Id("sortable2"));
                IWebElement SprintAccordian = Browser.Driver.FindElement(By.Id("sprintAccordion"));
                IWebElement SprintUL = SprintAccordian.FindElement(By.Id("accordion"));
                IList<IWebElement> StoryList = SprintUL.FindElements(By.TagName("li"));
                foreach (int m in CreateSprint.N)
                {
                    IWebElement Story = StoryList[m].FindElement(By.TagName("ul"));
                    DragNDrop MoveStory = new DragNDrop(Story, DropStory);
                    Browser.DragAndDrop(MoveStory);
                }
                IWebElement StartSprintBtn = Browser.Driver.FindElement(By.Id("btnStartSprint"));
                StartSprintBtn.Click();
                FillSprintDetails(CreateSprint.Sprint);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
