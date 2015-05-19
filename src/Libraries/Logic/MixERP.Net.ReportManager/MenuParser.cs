﻿using System;
using System.Xml;
using MixERP.Net.Common.Helpers;
using MixERP.Net.WebControls.ReportEngine.Helpers;

namespace MixERP.Net.ReportManager
{
    internal class MenuParser
    {
        internal MenuParser(string content)
        {
            this.Content = content;
        }

        internal string Content { get; set; }

        internal ReportMenu Parse()
        {
            XmlDocument xml = new XmlDocument();
            xml.PreserveWhitespace = true;
            xml.LoadXml(this.Content);

            ReportMenu menu = new ReportMenu();
            menu.Text = this.ParseTitle(xml);
            menu.MenuCode = this.ParseMenuCode(xml);
            menu.ParentMenuCode = this.ParseParentMenuCode(xml);

            return menu;
        }

        private string ParseTitle(XmlDocument xml)
        {
            XmlNode title = xml.GetElementsByTagName("Title")[0];

            if (title != null)
            {
                string value = title.InnerText;

                if (value.StartsWith("{Resources", StringComparison.OrdinalIgnoreCase))
                {
                    value = ReportParser.ParseExpression(value, null);
                }

                return value;
            }

            return string.Empty;
        }

        private string ParseMenuCode(XmlDocument xml)
        {
            XmlNode menu = xml.GetElementsByTagName("Menu")[0];

            if (menu != null)
            {
                if (menu.Attributes != null && menu.Attributes["MenuCode"] != null)
                {
                    return menu.Attributes["MenuCode"].Value;
                }
            }

            return string.Empty;
        }

        private string ParseParentMenuCode(XmlDocument xml)
        {
            XmlNode menu = xml.GetElementsByTagName("Menu")[0];

            if (menu != null)
            {
                if (menu.Attributes != null && menu.Attributes["ParentMenuCode"] != null)
                {
                    return menu.Attributes["ParentMenuCode"].Value;
                }
            }

            return string.Empty;
        }

    }
}