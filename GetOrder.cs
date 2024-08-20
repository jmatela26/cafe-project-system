using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BintanaSystem
{
    public class GetOrder
    {
        public static void placeOrder(int thisordNo, string thisitemID)
        {
            string checker;
            SqlConnection con = new SqlConnection(DBConnection.getAddress());

            SqlCommand refresh = new SqlCommand("EXECUTE updateOrder", con);
            SqlCommand update = new SqlCommand("EXECUTE updateAmount", con);
            SqlCommand com = new SqlCommand("EXECUTE getUser", con);
            SqlCommand add = new SqlCommand("EXECUTE addItem '" + thisitemID.ToString() + "', " + thisordNo.ToString(), con);
            SqlCommand check = new SqlCommand("EXECUTE checkItem '" + thisitemID.ToString() + "', " + thisordNo.ToString(), con);
            con.Open();
            checker = (String)check.ExecuteScalar();

            if (checker == thisitemID)
                add.ExecuteNonQuery();
            else
            {
                SqlDataAdapter ad = new SqlDataAdapter();
                ad.InsertCommand = new SqlCommand("INSERT INTO Orders(Order_No, Item_No, Item_ID, User_Assigned) VALUES (@ordNumber, @itemNumber, @itemID, @user)", con);
                ad.InsertCommand.Parameters.Add("@ordNumber", SqlDbType.Int).Value = thisordNo;
                ad.InsertCommand.Parameters.Add("@itemNumber", SqlDbType.Int).Value = getLastOrder(thisordNo);
                ad.InsertCommand.Parameters.Add("@itemID", SqlDbType.VarChar).Value = thisitemID;
                ad.InsertCommand.Parameters.Add("@user", SqlDbType.VarChar).Value = getUser();

                ad.InsertCommand.ExecuteNonQuery();
            }

            refresh.ExecuteNonQuery();
            update.ExecuteNonQuery();
            con.Close();
        }

        public static int getLastOrder(int orderNo)
        {
            int test;
            SqlConnection con = new SqlConnection(DBConnection.getAddress());
            SqlCommand ad = new SqlCommand("SELECT Item_No FROM Orders WHERE Order_No = " + orderNo.ToString() + " ORDER BY Item_No DESC", con);

            con.Open();

            try
            {
                test = (Int32)ad.ExecuteScalar();
                con.Close();
                return test + 1;
            }
            catch (Exception)
            {
                return 1;
            }
        }

        public static int getQuantity()
        {
            SqlConnection con = new SqlConnection(DBConnection.getAddress());
            SqlCommand ad = new SqlCommand("SELECT Quantity FROM Orders", con);

            try
            {
                int test;
                test = (Int32)ad.ExecuteScalar();
                return test + 1;
            }
            catch (Exception)
            {
                return 1;
            }
        }

        public static string getUser()
        {
            string ret;
            SqlConnection con = new SqlConnection(DBConnection.getAddress());
            SqlCommand com = new SqlCommand("EXECUTE getUser", con);

            con.Open();
            ret = (String)com.ExecuteScalar();
            con.Close();

            return ret;
        }
    }
}
