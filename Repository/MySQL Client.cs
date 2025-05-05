using Attendance_System.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_System.Repository
{
    public class MySQL_Client
    {
        private readonly string _connectionString= "Data Source=DEWSPC\\SQLEXPRESS;Initial Catalog=at_db;Integrated Security=True;TrustServerCertificate=True";

        public List<Student> GetStudents()
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
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Student student = new Student();
                                student.StudentId = reader.GetInt32(0);
                                student.Name = reader.GetString(1);
                                student.Telephone = reader.GetString(2);
                                student.Rfid = reader.GetString(3);

                                students.Add(student);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine("Exception: "+ex.Message);
            }


            return students;
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


        public void CreateStudent(Student student)
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
                }
            }catch (Exception ex)
            {
                Console.WriteLine("Exception: "+ex.Message);
            }
        }
    }
}
