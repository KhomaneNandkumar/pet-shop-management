using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;



namespace NK_PET_SHOP
{
    public partial class foodproductinventory : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Go
        protected void Button4_Click(object sender, EventArgs e)
        {
            getFoodProductByID();
        }
        //Add
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checkIfFoodProductExists())
            {
                Response.Write("<script>alert('Food Product Already Exists, try some other Food Product ID');</script>");
            }
            else
            {
                addNewFoodProduct();
            }

        }
        //Update
        protected void Button3_Click(object sender, EventArgs e)
        {
            updateFoodProductByID();
        }
        //Delete
        protected void Button2_Click(object sender, EventArgs e)
        {
            deleteFoodProductByID();
        }

        // user defined functions

        void deleteFoodProductByID()
        {
            if (checkIfFoodProductExists())
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("DELETE from food_inventory WHERE food_product_id='" + TextBox1.Text.Trim() + "'", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('Food Product Deleted Successfully');</script>");

                    // GridView1.DataBind();

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('Invalid Food Product ID');</script>");
            }
        }

        void updateFoodProductByID()
        {

            if (checkIfFoodProductExists())
            {
                try
                {



                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("UPDATE food_inventory SET food_product_name=@food_product_name, manufacturing_company_name=@manufacturing_company_name, manufacturing_date=@manufacturing_date, expiry_date=@expiry_date, better_for=@better_for, price=@price, food_product_description=@food_product_description where food_product_id = '" + TextBox1.Text.Trim() + "'", con);
                    cmd.Parameters.AddWithValue("@food_product_name", TextBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@manufacturing_company_name", TextBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@manufacturing_date]", TextBox8.Text.Trim());
                    cmd.Parameters.AddWithValue("@expiry_date", TextBox12.Text.Trim());
                    cmd.Parameters.AddWithValue("@better_for", DropDownList.SelectedItem.Value);
                    cmd.Parameters.AddWithValue("@price", TextBox10.Text.Trim());
                    cmd.Parameters.AddWithValue("@food_product_description", TextBox6.Text.Trim());
                    //cmd.Parameters.AddWithValue("@food_product_img_link", filepath);


                    cmd.ExecuteNonQuery();
                    con.Close();
                    // GridView1.DataBind();
                    Response.Write("<script>alert('Food Product Updated Successfully');</script>");


                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid Food  Product ID');</script>");
            }
        }


        void getFoodProductByID()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from food_inventory WHERE food_product_id='" + TextBox1.Text.Trim() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0]["food_product_name"].ToString();
                    TextBox3.Text = dt.Rows[0]["manufacturing_company_name"].ToString().Trim();
                    TextBox8.Text = dt.Rows[0]["manufacturing_date"].ToString().Trim();
                    TextBox8.Text = dt.Rows[0]["expiry_date"].ToString().Trim();
                    DropDownList.SelectedValue = dt.Rows[0]["better_for"].ToString();
                    TextBox10.Text = dt.Rows[0]["price"].ToString().Trim();
                    TextBox6.Text = dt.Rows[0]["food_product_description"].ToString().Trim();
                    // global_filepath = dt.Rows[0]["food_product_img_link"].ToString();

                }
                else
                {
                    Response.Write("<script>alert('Invalid Food Product ID');</script>");
                }

            }
            catch (Exception ex)
            {

            }
        }


        bool checkIfFoodProductExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from food_inventory where food_product_id='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }
        void addNewFoodProduct()
        {
            try
            {



                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("insert into food_inventory(food_product_id, food_product_name,manufacturing_company_name,manufacturing_date,expiry_date,better_for,price,food_product_description) values (@food_product_id,@food_product_name,@manufacturing_company_name,@manufacturing_date,@expiry_date,@better_for,@price,@food_product_description)", con);

                cmd.Parameters.AddWithValue("@food_product_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@food_product_name", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@manufacturing_company_name", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@manufacturing_date", TextBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@expiry_date", TextBox12.Text.Trim());
                cmd.Parameters.AddWithValue("@better_for", DropDownList.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@price", TextBox10.Text.Trim());
                cmd.Parameters.AddWithValue("@food_product_description", TextBox6.Text.Trim());
                //cmd.Parameters.AddWithValue("@food_product_img_link", filepath);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Food Product added successfully.');</script>");
                //GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}