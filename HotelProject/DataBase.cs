using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace HotelProject
{
   public class DataBase
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DataBase()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "myHotel";
            uid = "root";
            password = "12345";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + 
		    database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                //MessageBox.Show("Done Open ");
                return true;
            }
            catch (MySqlException ex)
            {
                
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }

        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert(string quary1)
        {
            string query=quary1;
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Execute command
                cmd.ExecuteNonQuery();
                //close connection
                this.CloseConnection();
            }
        }
        //Delete statement
        public void Delete(string quary1)
        {
            string query ;
            query = quary1;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select Login Info
        public List<LoginInfo> SelectLoginInfo()
        {
            string query = "SELECT * FROM staff";

            //Create a list to store the result
            List<LoginInfo> allacounts1 = new List<LoginInfo>();
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    LoginInfo ac = new LoginInfo();
                    ac.id=Convert.ToInt32(dataReader["id"] + "");
                    ac.username = (dataReader["user_name"] + "");
                    ac.password = (dataReader["password"] + "");
                    string other = (dataReader["role_id"] + "");
                    if (other == "1") {
                        ac.role = "manager";
                    }
                    else
                    {
                        ac.role = "recp";
                    }
                    allacounts1.Add(ac);
                }
                //close Data Reader
                dataReader.Close();
                //close Connection
                this.CloseConnection();
                //return list to be displayed
                return allacounts1;
            }
            else
            {
                return allacounts1;
            }
        }
        public List<Services> SelectServicesInfo()
        {
            string query = "SELECT * FROM services";

            //Create a list to store the result
            List<Services> Servc = new List<Services>();
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    Services b = new Services();
                    b.id = Convert.ToInt32(dataReader["id"] + "");
                    b.name = (dataReader["name"] + "");
                    b.price = Convert.ToDouble(dataReader["price"] + "");
                    string other = (dataReader["type"] + "");
                    if (other == "1")
                    {
                        b.type = 1; // laudary 
                    }
                    else if(other=="2")
                    {
                        b.type = 2; //meal
                    }
                    else
                    {
                        b.type = 3; //Drink
                    }
                   Servc.Add(b);
                }
                //close Data Reader
                dataReader.Close();
                //close Connection
                this.CloseConnection();
                //return list to be displayed
                return Servc;
            }
            else
            {
                return Servc;
            }
        }
        public List<Room> SelectRoomsInfo()
        {
            string query = "SELECT * FROM rooms";
            //Create a list to store the result
            List<Room> Rooms = new List<Room>();
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    Room room1 = new Room();
                    room1.id = Convert.ToInt32(dataReader["id"] + "");
                    room1.price = Convert.ToDouble(dataReader["price"] + "");
                    room1.type = Convert.ToInt32(dataReader["type_id"] + "");
                    
                    Rooms.Add(room1);
                }
                //close Data Reader
                dataReader.Close();
                //close Connection
                this.CloseConnection();
                //return list to be displayed
                return Rooms;
            }
            else
            {
                return Rooms;
            }
        }

        public List<Guest> SelectGuestsInfo()
        {
            string query = "SELECT * FROM customers";
            //Create a list to store the result
            List<Guest> Guests = new List<Guest>();
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    Guest b = new Guest();
                    b.id = Convert.ToInt64(dataReader["customer_id"] + "");
                    b.name = (dataReader["customer_name"] + "");
                    b.address = (dataReader["address"] + "");
                    if ((dataReader["gender"] + "") == "male")
                    {
                        b.Gender = true; // male
                    } 
                    else b.Gender= false; // famale

                    b.city= ((dataReader["city"] + ""));
                    b.nationality= ((dataReader["nationality"] + ""));
                    b.email = (dataReader["email"] + "");
                    b.mobile = Convert.ToInt32(dataReader["mobile"] + "");
                    Guests.Add(b);
                }
                //close Data Reader
                dataReader.Close();
                //close Connection
                this.CloseConnection();
                //return list to be displayed
                return Guests;
            }
            else
            {
                return Guests;
            }
        }
        public List<Booking> SelectBookingInfo()
        {
            string query = "SELECT * FROM booking";
            //Create a list to store the result
            List<Booking> Reserves = new List<Booking>();
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    Booking b = new Booking();
                    b.id = Convert.ToInt64(dataReader["id"] + "");
                    b.start = (dataReader["start_date"] + "");
                    b.end = (dataReader["end_date"] + "");
                    if ((dataReader["have_launch"] + "") == "true")
                    {
                        b.havelunch = true;
                    }
                    else b.havelunch = false;

                    b.room_id = Convert.ToInt32((dataReader["room_id"] + ""));
                    b.offer_id = Convert.ToInt32((dataReader["offer_id"] + ""));
                    b.servis_id = Convert.ToInt32((dataReader["service_id"] + ""));
                    Reserves.Add(b);
                }
                //close Data Reader
                dataReader.Close();
                //close Connection
                this.CloseConnection();
                //return list to be displayed
                return Reserves;
            }
            else
            {
                return Reserves;
            }
        }
        
        public void Update(string query1)
        {
            string query ;

            query = query1;
            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
    }
}
