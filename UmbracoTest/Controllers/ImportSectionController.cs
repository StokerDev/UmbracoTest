using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;
using umbraco.businesslogic;
using umbraco.BusinessLogic.Actions;
using umbraco.interfaces;
using Umbraco.Web.Models.Trees;
using Umbraco.Web.Mvc;
using Umbraco.Web.Trees;

// http://www.enkelmedia.se/blogg/2013/11/22/creating-custom-sections-in-umbraco-7-part-1.aspx
namespace UmbracoTest.Controllers
{
    [Application("import", "Import", "icon-files", 15)]
    public class ImportSectionController : IApplication
    {
    }

    [PluginController("import")]
    [Umbraco.Web.Trees.Tree("import", "importTree", "Import", iconClosed: "icon-doc")]
    public class ImportSectionTreeController : TreeController
    {
        protected override TreeNodeCollection GetTreeNodes(string id, FormDataCollection queryStrings)
        {
            var nodes = new TreeNodeCollection();
            var item = this.CreateTreeNode("dashboard", id, queryStrings, "Import Data", "icon-files", true);
            if (id == "-1") // root
            {
                nodes.Add(item);
            }
            return nodes;
        }

        protected override MenuItemCollection GetMenuForNode(string id, FormDataCollection queryStrings)
        {
            var menu = new MenuItemCollection
            {
                DefaultMenuAlias = ActionNew.Instance.Alias
            };
            menu.Items.Add<ActionNew>("Create");
            return menu;
        }
    }
}