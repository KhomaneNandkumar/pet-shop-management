using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NK_PET_SHOP
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"].Equals(""))
                {
                    LinkButton1.Visible = true; //user signup link button
                    LinkButton2.Visible = true; //user login link button
                    LinkButton3.Visible = false; //logout link button
                    LinkButton7.Visible = false; //hello user link button

                    LinkButton6.Visible = true;  //admin login link button
                    LinkButton8.Visible = false; //pets inventory link button
                    LinkButton9.Visible = false; //food products inventory link button
                    LinkButton16.Visible = false; //pet selling management link button
                    LinkButton17.Visible = false; //food product selling management link button
                    LinkButton10.Visible = false; //customer management link button
                    LinkButton5.Visible = false; // Billing management link button

                }
                else if (Session["role"].Equals("user"))
                {
                    LinkButton1.Visible = false; //user signup link button
                    LinkButton2.Visible = false; //user login link button
                    LinkButton3.Visible = true; //logout link button
                    LinkButton7.Visible = true; //hello user link button
                    LinkButton7.Text = "Hello " + Session["username"].ToString();

                    LinkButton6.Visible = true;  //admin login link button
                    LinkButton8.Visible = false; //pets inventory link button
                    LinkButton9.Visible = false; //food products inventory link button
                    LinkButton16.Visible = false; //pet selling management link button
                    LinkButton17.Visible = false; //food product selling management link button
                    LinkButton10.Visible = false; //customer management link button
                    LinkButton5.Visible = false; // Billing management link button 


                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false; //user signup link button
                    LinkButton2.Visible = false; //user login link button
                    LinkButton3.Visible = true; //logout link button
                    LinkButton7.Visible = true; //hello user link button
                    LinkButton7.Text = "Hello Admin";

                    LinkButton6.Visible = false;  //admin login link button
                    LinkButton8.Visible = true; //pets inventory link button
                    LinkButton9.Visible = true; //food products inventory link button
                    LinkButton16.Visible = true; //pet selling management link button
                    LinkButton17.Visible = true; //food product selling management link button
                    LinkButton10.Visible = true; //customer management link button
                    LinkButton5.Visible = true; // Billing management link button 

                }

            }

            catch (Exception ex)
            {

            }

        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }
        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminpetselling.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminfoodselling.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("admincustomermanagement.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbilling.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewpets.aspx");
        }

        protected void LinkButton13_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewfoodproducts.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            LinkButton1.Visible = true; //user signup link button
            LinkButton2.Visible = true; //user login link button
            LinkButton3.Visible = false; //logout link button
            LinkButton7.Visible = false; //hello user link button

            LinkButton6.Visible = true;  //admin login link button
            LinkButton8.Visible = false; //pets inventory link button
            LinkButton9.Visible = false; //food products inventory link button
            LinkButton16.Visible = false; //pet selling management link button
            LinkButton17.Visible = false; //food product selling management link button
            LinkButton10.Visible = false; //customer management link button
            LinkButton5.Visible = false; // Billing management link button
            Response.Redirect("homepage.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminpetmanagement.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("foodproductmanagement.aspx");
        }

        protected void LinkButton14_Click(object sender, EventArgs e)
        {
            Response.Redirect("petinventory.aspx");
        }

        protected void LinkButton15_Click(object sender, EventArgs e)
        {
            Response.Redirect("foodproductinventory.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("userprofile.aspx");
        }
    }
}

