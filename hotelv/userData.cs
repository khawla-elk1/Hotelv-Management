using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace hotelManagementSystem
{
    class usersData
    {
        // Chaîne de connexion
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kh\OneDrive\Documents\Hotelkv.mdf;Integrated Security=True;Connect Timeout=30";

        // Propriétés des utilisateurs
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public string DateReg { get; set; }

        // Méthode pour récupérer la liste des utilisateurs
        public List<usersData> listUsersData()
        {
            // Liste pour stocker les données des utilisateurs
            List<usersData> listData = new List<usersData>();

            // Chaîne de requête SQL

            using (SqlConnection connect = new SqlConnection(conn))
            {
                    connect.Open();
                string selectData = "SELECT * FROM users";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        // Lecture des données ligne par ligne
                        while (reader.Read())
                        {
                        usersData uData = new usersData();

                        uData.ID = (int)reader["id"];
                        uData.Username = reader["username"].ToString();
                        uData.Password = reader["password"].ToString();
                        uData.Role = reader["role"].ToString();
                        uData.Status = reader["status"].ToString();
                        uData.DateReg = reader["date_register"].ToString();
                            

                            // Ajout de l'utilisateur à la liste
                            listData.Add(uData);
                        }
                    }
            
              
            }

            return listData;
        }

    }
}
