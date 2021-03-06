﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Logger
{
    public partial class _Default : Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        protected void Page_Load(object sender, EventArgs e)
        {
            
            try
            {
                throw new DivideByZeroException();
            }
            catch(DivideByZeroException ex)
            {
                log.Error("Caought Exception " + ex);
            }
        }
    }
}