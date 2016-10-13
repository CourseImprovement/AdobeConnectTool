using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdobeConnectTool
{
    /// 
    /// The Excel class has the methods to parse the excel 
    /// spreadsheets that contain instructor and course 
    /// information.
    /// 
    class Excel
    {
        private static SLDocument _excelDocument;
        private static SLWorksheetStatistics _stats;

        /// 
        /// RETURN A LIST OF INSTRUCTORS FROM A SPECIFIED EXCEL WORKBOOK
        /// 
        public static List<Instructor> GetInstructorListFromExcelSpreadsheet(string file)
        {
            if (!ValidExcelDocument(file))
            {
                return null;
            }

            List<Instructor> listOfInstructors = new List<Instructor>();

            _excelDocument = new SLDocument(file);
            _stats = _excelDocument.GetWorksheetStatistics();

            string columnOne = _excelDocument.GetCellValueAsString(1, 1).ToLower();
            string columnTwo = _excelDocument.GetCellValueAsString(1, 2).ToLower();
            string columnThree = _excelDocument.GetCellValueAsString(1, 3).ToLower();

            if (columnOne != "first name" || columnTwo != "last name" || columnThree != "email")
            {
                LogInformation.AddLineToLogInformation("Error", "The first row of the spreadsheet must have the following columns: first name | last name | email");
                return null;
            }

            int end = _stats.EndRowIndex + 1;

            for (int i = 2; i < end; i++)
            {
                string first = _excelDocument.GetCellValueAsString(i, 1);
                string last = _excelDocument.GetCellValueAsString(i, 2);
                string email = _excelDocument.GetCellValueAsString(i, 3);
                if (first != "" && last != "" && email != "")
                {
                    Instructor inst = new Instructor(first, last, email);
                    listOfInstructors.Add(inst);
                }
                else
                {
                    LogInformation.AddLineToLogInformation("Error", "Row " + i + " is missing information and was skipped.");
                }
            }

            return listOfInstructors;
        }

        /// 
        /// RETURN A LIST OF COURSES FROM A SPECIFIED EXCEL WORKBOOK
        /// 
        public static List<Course> GetCourseListFromExcelSpreadsheet(string file)
        {
            if (!ValidExcelDocument(file))
            {
                LogInformation.AddLineToLogInformation("Error", "The file must be an Excel file with the extension .xlsx");
                return null;
            }

            _excelDocument = new SLDocument(file);
            _stats = _excelDocument.GetWorksheetStatistics();

            string columnOne = _excelDocument.GetCellValueAsString(1, 1).ToLower();
            string columnTwo = _excelDocument.GetCellValueAsString(1, 2).ToLower();
            string columnThree = _excelDocument.GetCellValueAsString(1, 3).ToLower();

            if (columnOne != "course name" || columnTwo != "section" || columnThree != "number of meetings")
            {
                LogInformation.AddLineToLogInformation("Error", "The first row of the spreadsheet must have the following columns: course name | section | number of meetings");
                return null;
            }

            List<Course> listOfCourses = new List<Course>();

            int end = _stats.EndRowIndex + 1;

            for (int i = 2; i < end; i++)
            {
                bool valid = true;
                string name = _excelDocument.GetCellValueAsString(i, 1).ToUpper();
                string section = _excelDocument.GetCellValueAsString(i, 2);
                int numberOfMeetings = _excelDocument.GetCellValueAsInt32(i, 3);

                if (name == "")
                {
                    LogInformation.AddLineToLogInformation("Error", "Row " + i + " is missing the name of the course and was skipped.");
                    valid = false;
                }

                if (section == "")
                {
                    LogInformation.AddLineToLogInformation("Error", "Row " + i + " is missing the section and was skipped.");
                    valid = false;
                }

                if (valid)
                {
                    List<Section> sections = new List<Section>();
                    Section s = new Section(section, numberOfMeetings);
                    sections.Add(s);
                    Course c = new Course(name, sections, numberOfMeetings);
                    if (listOfCourses.Contains(c))
                    {
                        int idx = listOfCourses.IndexOf(c);
                        listOfCourses[idx].AddSections(sections);
                    }
                    else
                    {
                        listOfCourses.Add(c);
                    }
                }
            }

            return listOfCourses;
        }

        /// 
        /// CHECK THAT THE EXCEL DOCUMENT HAS NON EMPTY COLUMN VALUES
        /// 
        private static bool ValidExcelDocument(string file)
        {
            SLDocument temp_excel_document = new SLDocument(file);
            if (temp_excel_document.GetCellValueAsString(1, 1) == "")
            {
                return false;
            }
            else if (temp_excel_document.GetCellValueAsString(2, 1) == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// 
        /// SAVE THE CURRENT LOOKUP TABLE AS AN EXCEL WORKBOOK
        /// 
        public static void LookupTableToExcel(List<Course> courses, string path)
        {
            SLDocument newDoc = new SLDocument();

            newDoc.SetCellValue(1, 1, "Coruse Name");
            newDoc.SetCellValue(1, 2, "Number of Meetings");

            for (int i = 0; i < courses.Count; i++)
            {
                newDoc.SetCellValue(i + 2, 1, courses[i].GetName());
                newDoc.SetCellValue(i + 2, 2, courses[i].GetNumberOfMeetings());
            }

            newDoc.SaveAs(path);
        }
    }
}
