using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace NK_PET_SHOP
{
    public partial class petinventory : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        static string global_filepath;
       

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        // go button click
        protected void Button4_Click(object sender, EventArgs e)
        {
            getPetByID();
        }


        // update button click
        protected void Button3_Click(object sender, EventArgs e)
        {
            updatePetByID();
        }
        // delete button click
        protected void Button2_Click(object sender, EventArgs e)
        {
            deletePetByID();
        }
        // add button click
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checkIfPetExists())
            {
                Response.Write("<script>alert('Pet Already Exists, try some other Pet ID');</script>");
            }
            else
            {
                addNewPet();
            }
        }



        // user defined functions

        void deletePetByID()
        {
            if (checkIfPetExists())
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("DELETE from pets_inventory WHERE pet_id='" + TextBox1.Text.Trim() + "'", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('Pet Deleted Successfully');</script>");

                   // GridView1.DataBind();

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('Invalid Pet ID');</script>");
            }
        }

        void updatePetByID()
        {

            if (checkIfPetExists())
            {
                try
                {

                   

                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("UPDATE pets_inventory set pet_name=@pet_name, category=@category, gender=@gender, bread=@bread, age=@age, vaccinated=@vaccinated, no_of_prev_owners=@no_of_prev_owners, surgery_done=@surgery_done, price=@price, pet_description=@pet_description where pet_id='" + TextBox1.Text.Trim() + "'", con);

                    cmd.Parameters.AddWithValue("@pet_name", TextBox2.Text.Trim());

                    cmd.Parameters.AddWithValue("@category", DropDownList.SelectedItem.Value);
                    cmd.Parameters.AddWithValue("@gender", DropDownList1.SelectedItem.Value);
                    cmd.Parameters.AddWithValue("@bread", TextBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@age", TextBox8.Text.Trim());
                    cmd.Parameters.AddWithValue("@vaccinated", DropDownList2.SelectedItem.Value);
                    cmd.Parameters.AddWithValue("@no_of_prev_owners", TextBox13.Text.Trim());
                    cmd.Parameters.AddWithValue("@surgery_done", DropDownList3.SelectedItem.Value);
                    cmd.Parameters.AddWithValue("@price", TextBox10.Text.Trim());
                    cmd.Parameters.AddWithValue("@pet_description", TextBox6.Text.Trim());
                    //cmd.Parameters.AddWithValue("@pet_img_link", filepath);


                    cmd.ExecuteNonQuery();
                    con.Close();
                   // GridView1.DataBind();
                    Response.Write("<script>alert('Pet Updated Successfully');</script>");


                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid Pet ID');</script>");
            }
        }


        void getPetByID()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from pets_inventory WHERE pet_id='" + TextBox1.Text.Trim() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0]["pet_name"].ToString();
                    DropDownList.SelectedValue = dt.Rows[0]["category"].ToString();
                    DropDownList1.SelectedValue = dt.Rows[0]["gender"].ToString();
                    TextBox3.Text = dt.Rows[0]["bread"].ToString().Trim();
                    TextBox8.Text = dt.Rows[0]["age"].ToString().Trim();
                    DropDownList2.SelectedValue = dt.Rows[0]["vaccinated"].ToString();
                    TextBox13.Text = dt.Rows[0]["no_of_prev_owners"].ToString().Trim();
                    DropDownList3.SelectedValue = dt.Rows[0]["surgery_done"].ToString().Trim();
                    TextBox10.Text = dt.Rows[0]["price"].ToString().Trim();
                    TextBox6.Text = dt.Rows[0]["pet_description"].ToString().Trim();
                   // global_filepath = dt.Rows[0]["pet_img_link"].ToString();

                }
                else
                {
                    Response.Write("<script>alert('Invalid Pet ID');</script>");
                }

            }
            catch (Exception ex)
            {

            }
        }


        bool checkIfPetExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from pets_inventory where pet_id='" + TextBox1.Text.Trim() + "';", con);
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
        void addNewPet()
        {
            try
            {
             
            


                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("insert into pets_inventory(pet_id,pet_name,category,gender,bread,age,vaccinated,no_of_prev_owners,surgery_done,price,pet_description) values (@pet_id,@pet_name,@category,@gender,@bread,@age,@vaccinated,@no_of_prev_owners,@surgery_done,@price,@pet_description)" , con);

                cmd.Parameters.AddWithValue("@pet_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@pet_name", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@category", DropDownList.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@gender", DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@bread", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@age", TextBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@vaccinated", DropDownList2.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@no_of_prev_owners", TextBox13.Text.Trim());
                cmd.Parameters.AddWithValue("@surgery_done", DropDownList3.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@price", TextBox10.Text.Trim());
                cmd.Parameters.AddWithValue("@pet_description", TextBox6.Text.Trim());
                //cmd.Parameters.AddWithValue("@pet_img_link", filepath);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Pet added successfully.');</script>");
                //GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
    
}