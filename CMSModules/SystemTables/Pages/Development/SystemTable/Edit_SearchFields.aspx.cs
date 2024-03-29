﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CMS.GlobalHelper;
using CMS.SettingsProvider;
using CMS.SiteProvider;
using CMS.UIControls;

public partial class CMSModules_SystemTables_Pages_Development_SystemTable_Edit_SearchFields : SiteManagerPage
{
    private string className = QueryHelper.GetString("classname", String.Empty);

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!RequestHelper.IsPostBack())
        {
            DataClassInfo dci = DataClassInfoProvider.GetDataClass(className);
            if (dci != null)
            {
                searchFields.ItemID = dci.ClassID;
                searchFields.LoadActualValues = true;
                //searchFields.ReloadSearch(false);
            }
        }
    }
}
