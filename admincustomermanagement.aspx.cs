﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace NK_PET_SHOP
{
    public partial class admincustomermanagement : System.Web.UI.Page
    { 
    string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
       // GridView1.DataBind();
    }
    // Go button
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        getMemberByID();
    }
  
    // delete button
    protected void Button2_Click(object sender, EventArgs e)
    {
        deleteMemberByID();
    }
     // user defined function

    bool checkIfMemberExists()
    {
        try
        {
            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("SELECT * from member_master where memberid='" + TextBox1.Text.Trim() + "';", con);
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

    void deleteMemberByID()
    {
        if (checkIfMemberExists())
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE from member_master WHERE memberid='" + TextBox1.Text.Trim() + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Member Deleted Successfully');</script>");
                clearForm();
                //GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

        }
        else
        {
            Response.Write("<script>alert('Invalid Member ID');</script>");
        }
    }

    void getMemberByID()
    {
        try
        {
            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            SqlCommand cmd = new SqlCommand("select * from member_master where memberid='" + TextBox1.Text.Trim() + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    TextBox2.Text = dr.GetValue(0).ToString();
                   // TextBox7.Text = dr.GetValue(10).ToString();
                    TextBox8.Text = dr.GetValue(1).ToString();
                    TextBox3.Text = dr.GetValue(2).ToString();
                    TextBox4.Text = dr.GetValue(3).ToString();
                    TextBox9.Text = dr.GetValue(4).ToString();
                    TextBox10.Text = dr.GetValue(5).ToString();
                    TextBox11.Text = dr.GetValue(6).ToString();
                    TextBox6.Text = dr.GetValue(7).ToString();

                }

            }
            else
            {
                Response.Write("<script>alert('Invalid credentials');</script>");
            }

        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex.Message + "');</script>");
        }
    }

   

    void clearForm()
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        //TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox9.Text = "";
        TextBox10.Text = "";
        TextBox11.Text = "";
        TextBox6.Text = "";
    }

}
}