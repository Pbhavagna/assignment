using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_asp
{
    public partial class Chocolate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void btnShowCost_Click(object sender, EventArgs e)
        {
            string selectedItem = ddlItems.SelectedValue;
            string cost = string.Empty;
            if (selectedItem == "1")
            {
                cost = "100";
            }
            else if (selectedItem == "2")
            {
                cost = "20";
            }
            else if (selectedItem == "3")
            {
                cost = "30";
            }
            else if (selectedItem == "4")
            {
                cost = "40";
            }
            string Item = ddlItems.SelectedItem.Text;
            lblCost.Text = $"Cost of {Item}: {cost}";

        }
        protected void ddlItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = ddlItems.SelectedValue;
            string cost = string.Empty;
            if (selectedItem == "1")
            {
                imgItem.ImageUrl = $"Images/dairymilk.jpg";
            }
            else if (selectedItem == "2")
            {
                imgItem.ImageUrl = $"Images/5star.jpg";
            }
            else if (selectedItem == "3")
            {
                imgItem.ImageUrl = $"Images/kitkat.jpg";
            }
            else if (selectedItem == "4")
            {
                imgItem.ImageUrl = $"Images/snickers.jpg";
            }
            else
            {
               
            }
        }
    }
}