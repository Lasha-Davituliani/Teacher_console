using System.Data.SqlClient;

namespace ConsoleApp6
{
    public class DataAccess
    {
        public void GetData()
        {
            using (SqlConnection connection = new(Helper.Connect()))
            {
                SqlCommand command = new();
                command.Connection = connection;
                command.CommandText = "SELECT\r\n    T.first_name AS teacher_first_name,\r\n    T.last_name AS teacher_last_name,\r\n    T.subject\r\nFROM\r\n    Teacher AS T\r\nJOIN\r\n    TeacherPupil AS TP ON T.teacher_id = TP.teacher_id\r\nJOIN\r\n    Pupil AS P ON TP.pupil_id = P.pupil_id\r\nWHERE\r\n    P.first_name = 'George';";

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string? firsName = reader[0].ToString();
                        string? lastName = reader[1].ToString();
                        string? subject = reader[2].ToString();

                        Console.WriteLine($"First Name = {firsName}, Last Name = {lastName}, Subject = {subject}");
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
