using Attendance_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attendance_System.Repository
{
    public class MySQL_Client
    {
        private readonly string _connectionString= "Data Source=DEWSPC\\SQLEXPRESS;Initial Catalog=at_db;Integrated Security=True;TrustServerCertificate=True";

        public DataSet GetStudents()
        {
            var students = new List<Student>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                { 
                    connection.Open();

                    string sql = "SELECT * FROM STUDENTS ORDER BY StudentId DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        return ds;

                        //using (SqlDataReader reader = command.ExecuteReader())
                        //{
                        //    while (reader.Read())
                        //    {
                        //        Student student = new Student();
                        //        student.StudentId = reader.GetInt32(0);
                        //        student.Name = reader.GetString(1);
                        //        student.Telephone = reader.GetString(2);
                        //        student.Rfid = reader.GetString(3);

                        //        students.Add(student);
                        //    }
                        //}
                    }
                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine("Exception: "+ex.Message);
            }
            return null;
        }

        public DataSet SearchStudent(string std_ID)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM Students where StudentID=@rfid";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@rfid", std_ID);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        return ds;

                        //using (SqlDataReader reader = command.ExecuteReader())
                        //{
                        //    while (reader.Read())
                        //    {
                        //        Student student = new Student();
                        //        student.StudentId = reader.GetInt32(0);
                        //        student.Name = reader.GetString(1);
                        //        student.Telephone = reader.GetString(2);
                        //        student.Rfid = reader.GetString(3);

                        //        //student.StudentId = 1;
                        //        //student.Name = "Shehara";
                        //        //student.Telephone = "0764247796";
                        //        //student.Rfid = "tost";


                        //        return student;
                        //    }
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                return null;
            }
        }


        public Boolean DeleteStudent(string rfid)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM Students WHERE Rfid = @rfid";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@rfid", rfid);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);

                return false;
            }


        }


        public Student GetStudent(string rfid)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM Students where Rfid=@rfid";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@rfid", rfid);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Student student = new Student();
                                student.StudentId = reader.GetInt32(0);
                                student.Name = reader.GetString(1);
                                student.Telephone = reader.GetString(2);
                                student.Rfid = reader.GetString(3);

                                //student.StudentId = 1;
                                //student.Name = "Shehara";
                                //student.Telephone = "0764247796";
                                //student.Rfid = "tost";


                                return student;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
               
                return null;
            }

            return null;

        }


        public Boolean CreateStudent(Student student)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString)) 
                {
                    connection.Open ();
                    string sql = "INSERT INTO Students " +
                        "(StudentId,Name,Telephone,Rfid) VALUES " +
                        "(@id,@name,@telephone,@rfid);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", student.StudentId);
                        command.Parameters.AddWithValue("@name", student.Name);
                        command.Parameters.AddWithValue("@telephone", student.Telephone);
                        command.Parameters.AddWithValue("@rfid", student.Rfid);

                        command.ExecuteNonQuery();

                    }
                    return true;
                }
            }catch (Exception ex)
            {
                Console.WriteLine("Exception: "+ex.Message);
                return false;
            }
        }


        public Attendance GetAttendance(String rfid)
        {
            Attendance attendance = new Attendance();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    DateTime currentDate = DateTime.Now;

                    int year = currentDate.Year;
                    int month = currentDate.Month;
                    int day = currentDate.Day;
                    string sql = "SELECT * FROM Attendance where RFID=@rfid AND Year=@year AND Month=@month AND Day=@day";
                    //string sql = "SELECT * FROM Attendance where RFID=@rfid";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {

                        command.Parameters.AddWithValue("@rfid", rfid);
                        command.Parameters.AddWithValue("@year",year.ToString());
                        command.Parameters.AddWithValue("@month", month.ToString());
                        command.Parameters.AddWithValue("@day", day.ToString());


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            
                                if (reader.Read())
                                {
                                    attendance.RFID = reader.GetString(0);
                                    attendance.Month = reader.GetString(1);
                                    attendance.Year = reader.GetString(2);
                                    attendance.Day = reader.GetString(3);
                                    attendance.IN_TIME = reader.GetString(4);
                                    if(reader.IsDBNull(5)) 
                                    {
                                        attendance.OUT_TIME = "";
                                    }
                                    else
                                    {
                                        attendance.OUT_TIME = reader.GetString(5);
                                    }
                                    
                                }


                                return attendance;
                            
                            

                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: catch null" + ex.Message);

                return null;
            }
        }


        public Boolean SetAttendance(Attendance attendance)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO Attendance " +
                        "(RFID,Month,Year,Day,IN_TIME) VALUES " +
                        "(@rfid,@month,@year,@day,@intime);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@rfid", attendance.RFID);
                        command.Parameters.AddWithValue("@month", attendance.Month);
                        command.Parameters.AddWithValue("@year", attendance.Year);
                        command.Parameters.AddWithValue("@day", attendance.Day);
                        command.Parameters.AddWithValue("@intime", attendance.IN_TIME);
                        //command.Parameters.AddWithValue("@outtime", attendance.OUT_TIME);


                        command.ExecuteNonQuery();
                        return true;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                return false;
            }
        }


        public Boolean UpdateAttendance(String outtime,String rfid)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE Attendance " +
                        "SET OUT_TIME = @outtime " +
                        "WHERE RFID = @rfid;";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@outtime", outtime);
                        command.Parameters.AddWithValue("@rfid", rfid);                 
                        command.ExecuteNonQuery();

                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                return false;
            }
        }
    }
}
