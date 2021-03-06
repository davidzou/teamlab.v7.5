/* 
 * 
 * (c) Copyright Ascensio System Limited 2010-2014
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 * 
 * http://www.gnu.org/licenses/agpl.html 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASC.Web.Studio.UserControls.Common.HelpCenter;

namespace ASC.Web.Studio.UserControls.Management.HelpBlock
{
    public partial class Help : System.Web.UI.UserControl
    {
        public static string Location
        {
            get { return "~/UserControls/Management/HelpBlock/Help.ascx"; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            HelpHolder.Controls.Add(LoadControl(HelpCenter.Location));
        }
    }
}