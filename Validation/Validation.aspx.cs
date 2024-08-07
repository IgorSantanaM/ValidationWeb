﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validation
{
    public partial class Validation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = 
                System.Web.UI.UnobtrusiveValidationMode.None;

            if(IsPostBack)
            {
                Validate();
                if(IsValid)
                {
                    string name = nameTextBox.Text;
                    string email = emailTextBox.Text;
                    string phone = phoneTextBox.Text;

                    outputLabel.Text = "Thank you for your submission<br/>" + "We received the following information<br/>";
                    outputLabel.Text +=
                        String.Format("Name: {0}{1}E-mail:{2}{1}Phone{3}", name, "<br/>", email, phone);
                    outputLabel.Visible = true;
                }
            }

        }
    }
}