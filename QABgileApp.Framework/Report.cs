using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
namespace QABgileApp.Framework
{
    #region
    public class SelectDropDowns
    {
        public string Project { get; set; }
        public string WorkingYear { get; set; }
        public string Quarter { get; set; }
        public SelectDropDowns(string project, string workingyear, string quarter)
        {
            Project = project;
            WorkingYear = workingyear;
            Quarter = quarter;
        }
    }
    public class Analytics
    {
        public SelectDropDowns SelectDropDowns { get; set; }
        public bool PrintPDF { get; set; }
        public Analytics(SelectDropDowns selectdropdowns, bool printpdf)
        {
            SelectDropDowns = selectdropdowns;
            PrintPDF = printpdf;
        }
    }
    public class SearchFeaturesDelivered
    {        
        public SelectDropDowns SelectDropDowns { get; set; }
        public string People { get; set; }
        public bool PrintPDF { get; set; }
        public SearchFeaturesDelivered(SelectDropDowns selectdropdowns, string people, bool printpdf)
        {
            SelectDropDowns = selectdropdowns;
            People = people;
            PrintPDF = printpdf;
        }
    }
    public class SearchUtilization
    {
        public string Project { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string People { get; set; }
        public bool PrintPDF { get; set; }
        public SearchUtilization(string project, string fromdate, string todate, string people, bool printpdf)
        {
            Project = project;
            FromDate = fromdate;
            ToDate = todate;
            People = people;
            PrintPDF = printpdf;
        }
    }
    #endregion
    public static class Report
    {
        public static ReportPage ReportPage
        {
            get
            {
                ReportPage reportpage = new ReportPage();
                PageFactory.InitElements(Browser.Driver, reportpage);
                return reportpage;
            }
        }
            
    }
    public class ReportPage
    {
        public string Url = "Report/Analytics";
        #region
        [FindsBy(How = How.Id, Using ="Projects")]
        public IWebElement ProjectsDropDown { get; set; }
        [FindsBy(How = How.Id, Using ="WorkingYear")]
        public IWebElement WorkingYearDropDown { get; set; }
        [FindsBy(How = How.Id, Using ="Quarter")]
        public IWebElement QuarterDropDown { get; set; }
        [FindsBy(How = How.Id, Using ="txtSearch")]
        public IWebElement SearchTextBox { get; set; }
        [FindsBy(How = How.Id, Using ="lblSearch")]
        public IWebElement SearchLink { get; set; }
        [FindsBy(How = How.ClassName, Using = "bicon-icon-pdf")]
        public IWebElement PrintPDF { get; set; }
        [FindsBy(How = How.Id, Using = "txtFromDate")]
        public IWebElement FromDateTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "txtToDate")]
        public IWebElement ToDateTextBox { get; set; }
        #endregion
        public void MenuSelect(int n)
        {
            try
            {
                IList<IWebElement> ReportMenu = Browser.Driver.FindElements(By.ClassName("sf-menu"));
                IList<IWebElement> MenuList = ReportMenu[2].FindElements(By.TagName("li"));
                IWebElement Menu = MenuList[n].FindElement(By.TagName("a"));
                Menu.Click();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void ReportMenu(string Report)
        {
            try
            {            
                switch (Report)
                {
                    case "Analytics" :  
                        {
                            MenuSelect(0);
                            break;
                        }
                    case "Features Delivered":
                        {
                            MenuSelect(1);
                            break;
                        }
                    case "Utilization":
                        {
                            MenuSelect(2); 
                            break;
                        }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void PDFPrint(bool PrintPdf)
        {
            if (PrintPdf)
            {
                try
                {
                    PrintPDF.Click();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public void Analytics(Analytics Analytics)
        {
            try
            {
                ReportMenu("Analytics");
                SelectDropDowns(Analytics.SelectDropDowns);
                PDFPrint(Analytics.PrintPDF);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void SelectDropDowns(SelectDropDowns SelectDropDowns)
        {
            try
            {
                DropDownSelect DropDownProject = new DropDownSelect(SelectDropDowns.Project, ProjectsDropDown);
                DropDownSelect DropDownWorkingYear = new DropDownSelect(SelectDropDowns.WorkingYear, WorkingYearDropDown);
                DropDownSelect DropDownQuarter = new DropDownSelect(SelectDropDowns.Quarter, QuarterDropDown);
                Browser.SelectDropdown(DropDownProject);
                Browser.SelectDropdown(DropDownWorkingYear);
                Browser.SelectDropdown(DropDownQuarter);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void SearchFeaturesDeliverd(SearchFeaturesDelivered SearchFeaturesDelivered)
        {
            try
            {
                ReportMenu("Features Delivered");
                SelectDropDowns(SearchFeaturesDelivered.SelectDropDowns); 
                ClearAndFillTextBox SearchClearNFill = new ClearAndFillTextBox(SearchTextBox, SearchFeaturesDelivered.People);
                Browser.ClearAndFillTextBox(SearchClearNFill);
                SearchLink.Click();
                PDFPrint(SearchFeaturesDelivered.PrintPDF);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void SearchUtilization(SearchUtilization SearchUtilization)
        {
            try
            {
                ReportMenu("Utilization");
                DropDownSelect DropDownProject = new DropDownSelect(SearchUtilization.Project, ProjectsDropDown);
                ClearAndFillTextBox FromDateClearNFill = new ClearAndFillTextBox(FromDateTextBox, SearchUtilization.FromDate);
                ClearAndFillTextBox ToDateClearNFill = new ClearAndFillTextBox(ToDateTextBox, SearchUtilization.ToDate);
                ClearAndFillTextBox SearchClearNFill = new ClearAndFillTextBox(SearchTextBox, SearchUtilization.People);
                Browser.SelectDropdown(DropDownProject);
                Browser.ClearAndFillTextBox(FromDateClearNFill);
                Browser.ClearAndFillTextBox(ToDateClearNFill);
                Browser.ClearAndFillTextBox(SearchClearNFill);
                SearchLink.Click();
                PDFPrint(SearchUtilization.PrintPDF);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CheckMet()
        {
            try
            {
                IList<IWebElement> Rows = Browser.Driver.FindElements(By.ClassName("row"));
                foreach (IWebElement Row in Rows)
                {
                    IList<IWebElement> Spans = Row.FindElements(By.TagName("span"));
                    IWebElement Span = Spans[Spans.Count - 1].FindElement(By.TagName("span"));
                    string Met = Span.GetAttribute("class");
                    switch (Met)    
                    {
                        case "Met":
                            {

                                break;
                            }
                        default:
                            {

                                break;
                            }
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
