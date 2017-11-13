using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using StudentInformationSystem;

namespace BBProject
{
    class DB_Access
    {
        SqlConnection conn;
        public DB_Access()
        {
            conn = DB_Connection.GetConnection();
        }
        //START DELETE SECTION***************************************
        public bool DeleteStudent(string StudentID)
        {
            bool status = false;
            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }
                SqlCommand newCmd = conn.CreateCommand();
                newCmd.Connection = conn;
                newCmd.CommandType = CommandType.Text;
                newCmd.CommandText = "DELETE FROM Student WHERE Student_ID  + ',' + Student_First_Name + ',' + Student_Last_Name = '" + StudentID + "'";
                newCmd.ExecuteNonQuery();
                status = true;
            }
            catch
            {
                status = false;
            }
            return status;
        }
        public bool DeleteClass(string CourseID)
        {
            bool status = false;
            try
            {
                if(conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }
                SqlCommand newCmd = conn.CreateCommand();
                newCmd.Connection = conn;
                newCmd.CommandType = CommandType.Text;
                newCmd.CommandText = "DELETE FROM Class WHERE Course_ID + ',' + Course_Number = '" + CourseID + "'";
                newCmd.ExecuteReader();
                status = true;
            }
            catch
            {
                status = false;
            }
            return status;
        }
        public bool DeleteGrade(string AssignmentName)
        {
            bool status = false;
            try
            {
                if(conn.State.ToString()=="Closed")
                {
                    conn.Open();
                }
                SqlCommand newCmd = conn.CreateCommand();
                newCmd.Connection = conn;
                newCmd.CommandType = CommandType.Text;
                newCmd.CommandText = "DELETE FROM Grade WHERE Assigment_Name + ',' + Assignment_Grade = '" + AssignmentName + "'";
                newCmd.ExecuteReader();
                status = true;
            }
            catch
            {
                status = false;
            }
            return status;
        }
        //END DELETE SECTION***************************************

        //START FILL SECTION***************************************
        public DataTable FillGradeList()
        {
            DataTable tb1 = new DataTable();
            tb1.Columns.Add("Assignment_Name + ',' + Assignment_Grade", typeof(string));
            if(conn.State.ToString()=="Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();          
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "SELECT Assignment_Name + ',' + Assignment_Grade AS AssignmentName FROM Grade";
            SqlDataReader dr = newCmd.ExecuteReader();
            while(dr.Read())
            {
                tb1.Rows.Add(dr["AssignmentName"]);
            }
            conn.Close();
            return tb1;
        }
        public DataTable FillClassList()
        {
            DataTable tb1 = new DataTable();
            tb1.Columns.Add("Course_ID + ',' + Course_Number", typeof(string));
            if(conn.State.ToString()=="Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "SELECT Course_ID + ',' + Course_Number AS ClassID FROM Class";
            SqlDataReader dr = newCmd.ExecuteReader();
            while(dr.Read())
            {
                tb1.Rows.Add(dr["ClassID"]);
            }
            conn.Close();
            return tb1;
        }
        public DataTable FillStudentList()
        {
            DataTable tb1 = new DataTable();
            tb1.Columns.Add("Student_ID + ',' + Student_First_Name + ',' + Student_Last_Name", typeof(string));
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "SELECT Student_ID + ',' + Student_First_Name + ',' + Student_Last_Name AS StudentID FROM Student";
            SqlDataReader dr = newCmd.ExecuteReader();
            while (dr.Read())
            {
                tb1.Rows.Add(dr["StudentID"]);
            }
            conn.Close();
            return tb1;
        }
        //END Fill SECTION***************************************

        //START UPDATE SECTION*************************************
        public void update_grade(string AssignmentName, string AssignmentGrade, string AssignmentWeight, string AssignmentDueDate)
        {
            if(conn.State.ToString()=="Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "UPDATE Grade SET Assignment_Weight = '" + AssignmentWeight 
                + "' ,Assignment_Grade = '" + AssignmentGrade 
                + "' ,Assignment_Due_Date = '" + AssignmentDueDate 
                + "' where Assignment_Name = '" + AssignmentName + "'";
            newCmd.ExecuteNonQuery();
        }
        public void update_class(string ClassID, string ClassNumber, string Semester, string Instructor)
        {
            if(conn.State.ToString()=="Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "UPDATE Class SET Course_Number = '" + ClassNumber 
                + "',Semester = '" + Semester
                + "',Instructor = '" + Instructor
                + "' where Course_ID = '" + ClassID + "'";
            newCmd.ExecuteNonQuery();
        }
        public void update_student(string StudentID, string StudentFirstName, string StudentLastName, string StudentMobilePhone)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "UPDATE Student SET Student_First_Name = '" + StudentFirstName 
                + "' ,Student_Last_Name = '" + StudentLastName 
                + "' ,Mobile_Phone = '" + StudentMobilePhone 
                + "' where Student_ID = '" + StudentID + "'";
            newCmd.ExecuteNonQuery();
        }
        //END UPDATE SECTION***************************************

        //START RETURN SECTION*************************************

        public string ReturnData(string primaryKey, string tableName, string tableID, string column)
        {
            string temp = "";
            if(conn.State.ToString()=="Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "SELECT " + column + " FROM " + tableName + " WHERE " + primaryKey + " = " + tableID + "";
            SqlDataReader dr = newCmd.ExecuteReader();
            while(dr.Read())
            {
                temp = dr[column].ToString();
            }
            dr.Close();
            conn.Close();
            return temp;
        }

        //public string ReturnGradeData(string Primary_key, string Table_Name, string AssignmentName, string Column)
        //{
        //    string temp = "";
        //    if (conn.State.ToString() == "Closed")
        //    {
        //        conn.Open();
        //    }
        //    SqlCommand newCmd = conn.CreateCommand();
        //    newCmd.CommandType = CommandType.Text;
        //    newCmd.CommandText = "SELECT " +  Column + " FROM " + Table_Name + " WHERE " + Primary_key + " = " + AssignmentName + "";
        //    SqlDataReader dr = newCmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        temp = dr[Column].ToString();
        //    }
        //    dr.Close();
        //    conn.Close();
        //    return temp;
        //}
        //public string ReturnClassData(string Primary_Key, string Table_Name, string CID, string Column)
        //{
        //    string temp = "";
        //    if(conn.State.ToString()=="Closed")
        //    {
        //        conn.Open();
        //    }
        //    SqlCommand newCmd = conn.CreateCommand();
        //    newCmd.CommandType = CommandType.Text;
        //    newCmd.CommandText = "SELECT " + Column + " FROM " + Table_Name + " WHERE " + Primary_Key + " = " + CID + "";
        //    SqlDataReader dr = newCmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        temp = dr[Column].ToString();
        //    }
        //    dr.Close();
        //    conn.Close();
        //    return temp;
        //}
        //public string ReturnStudentData(string Primary_key, string Table_Name, string Student_ID, string Column)
        //{
        //    string temp = "";
        //    if (conn.State.ToString() == "Closed")
        //    {
        //        conn.Open();
        //    }
        //    SqlCommand newCmd = conn.CreateCommand();
        //    newCmd.CommandType = CommandType.Text;
        //    newCmd.CommandText = "SELECT " + Column + " FROM " + Table_Name + " WHERE " + Primary_key + " = " + Student_ID + "";
        //    SqlDataReader dr = newCmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        temp = dr[Column].ToString();
        //    }
        //    dr.Close();
        //    conn.Close();
        //    return temp;
        //}

        //END RETURN SECTION*************************************

        //START ADD SECTION**************************************
        public void add_grade(string AName,
           string AGrade,
           string AWeight,
           string ADueDate)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "INSERT INTO Grade VALUES('" + AName + "','"
                + AGrade + "','"
                + AWeight + "','"
                + ADueDate + "')";
            newCmd.ExecuteNonQuery();
        }
        public void add_class(string CID, 
            string CNumber, 
            string Semester, 
            string Instructor)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "INSERT INTO Class VALUES('" + CID + "','"
                + CNumber + "','"
                + Semester + "','"
                + Instructor + "')";
            newCmd.ExecuteNonQuery();
        }
        public void add_student(string Student_ID, 
            string Student_First_Name, 
            string Student_Last_Name, 
            string Mobile_Phone)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "INSERT INTO Student VALUES('" + Student_ID + "','"
                + Student_First_Name + "','"
                + Student_Last_Name + "','"
                + Mobile_Phone + "')";
            newCmd.ExecuteNonQuery();
        }
        //END ADD SECTION**************************************

        //START FILL GRID SECTION******************************
        public DataSet FillDataGrid(string query, string table)
        {
            if(conn.State.ToString()=="Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, table);
            conn.Close();
            return ds;
        }
        //END FILL GRID SECTION
        //public DataSet FillClassGrid(string Query, string Table)
        //{
        //    if (conn.State.ToString() =="Closed")
        //    {
        //        conn.Open();
        //    }
        //    SqlCommand newCmd = conn.CreateCommand();
        //    newCmd.Connection = conn;
        //    newCmd.CommandType = CommandType.Text;
        //    newCmd.CommandText = Query;
        //    SqlDataAdapter da = new SqlDataAdapter(newCmd);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds, Table);
        //    conn.Close();
        //    return ds;
        //}
        //public DataSet FillGradeGrid(string Query, string Table)
        //{
        //    if(conn.State.ToString() == "Closed")
        //    {
        //        conn.Open();
        //    }
        //    SqlCommand newCmd = conn.CreateCommand();
        //    newCmd.Connection = conn;
        //    newCmd.CommandType = CommandType.Text;
        //    newCmd.CommandText = Query;
        //    SqlDataAdapter da = new SqlDataAdapter(newCmd);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds, Table);
        //    conn.Close();
        //    return ds;
        //}
        //public DataSet FillStudentGrid(string Query, string Table)
        //{
        //    if (conn.State.ToString() == "Closed")
        //    {
        //        conn.Open();
        //    }
        //    SqlCommand newCmd = conn.CreateCommand();
        //    newCmd.Connection = conn;
        //    newCmd.CommandType = CommandType.Text;
        //    newCmd.CommandText = Query;
        //    SqlDataAdapter da = new SqlDataAdapter(newCmd);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds, Table);
        //    conn.Close();
        //    return ds;
        //}
        //END FILL SECTION***********************************

    }
}
