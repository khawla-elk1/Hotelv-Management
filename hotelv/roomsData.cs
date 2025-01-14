using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

public class roomsData
{
    private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kh\OneDrive\Documents\Hotelkv.mdf;Integrated Security=True;Connect Timeout=30";

    public int ID { get; set; }
    public string RoomID { get; set; }
    public string RoomType { get; set; }
    public string RoomName { get; set; }
    public string Price { get; set; }
    public string ImagePath { get; set; }
    public string Status { get; set; }
    public string DateRegister { get; set; }

    public List<roomsData> roomsDataList()
    {
        List<roomsData> listData = new List<roomsData>();
        
        using (SqlConnection connect = new SqlConnection(conn))
        {
            
                connect.Open();
                string selectData = "SELECT * FROM rooms WHERE date_delete IS NULL";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        roomsData rData = new roomsData();

                        rData.ID = (int)reader["id"];
                        rData.RoomID = reader["room_id"].ToString();
                        rData.RoomType = reader["type"].ToString();
                        rData.RoomName = reader["room_name"].ToString();
                        rData.Price = reader["price"].ToString();
                        rData.ImagePath = reader["image_path"].ToString();
                        rData.Status = reader["status"].ToString();
                        rData.DateRegister = reader["date_register"].ToString();
                        
                        listData.Add(rData);
                    }
                }
            
        }

        return listData;
    }
}
