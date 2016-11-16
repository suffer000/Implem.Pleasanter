﻿using Implem.Libraries.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace Implem.Pleasanter.Libraries.Html
{
    public class HtmlAttributes : List<string>
    {
        public HtmlAttributes()
        {
        }

        public HtmlAttributes Add(string name, string value, bool _using = true)
        {
            if (value != null && _using)
            {
                Add(name);
                Add(value);
            }
            return this;
        }

        public HtmlAttributes Add(Dictionary<string, string> attributes, bool _using = true)
        {
            if (attributes != null && _using)
            {
                attributes.ForEach(attribute =>
                {
                    Add(attribute.Key);
                    Add(attribute.Value);
                });
            }
            return this;
        }

        public HtmlAttributes Id(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("id");
                Add(value);
                Add("name");
                Add(value);
            }
            return this;
        }

        public HtmlAttributes Class(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("class");
                Add(value);
            }
            return this;
        }

        public HtmlAttributes Style(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("style");
                Add(value);
            }
            return this;
        }

        public HtmlAttributes Type(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("type");
                Add(value);
            }
            return this;
        }

        public HtmlAttributes Src(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("src");
                Add(value);
            }
            return this;
        }

        public HtmlAttributes Value(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("value");
                Add(HttpUtility.HtmlEncode(value));
            }
            return this;
        }

        public HtmlAttributes RawValue(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("value");
                Add(value);
            }
            return this;
        }

        public HtmlAttributes DataMax(decimal value, bool _using = true)
        {
            if (_using)
            {
                Add("data-max");
                Add(value.ToString());
            }
            return this;
        }

        public HtmlAttributes DataMin(decimal value, bool _using = true)
        {
            if (_using)
            {
                Add("data-min");
                Add(value.ToString());
            }
            return this;
        }

        public HtmlAttributes DataStep(decimal value, bool _using = true)
        {
            if (_using)
            {
                Add("data-step");
                Add(value.ToString());
            }
            return this;
        }

        public HtmlAttributes Checked(bool value, bool _using = true)
        {
            if (value && _using)
            {
                Add("checked");
            }
            return this;
        }

        public HtmlAttributes Selected(bool value, bool _using = true)
        {
            if (value && _using)
            {
                Add("selected");
            }
            return this;
        }

        public HtmlAttributes Multiple(bool value, bool _using = true)
        {
            if (value && _using)
            {
                Add("multiple");
                Add("multiple");
            }
            return this;
        }

        public HtmlAttributes Action(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("action");
                Add(value);
            }
            return this;
        }

        public HtmlAttributes For(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("for");
                Add(value);
            }
            return this;
        }

        public HtmlAttributes Href(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("href");
                Add(value);
            }
            return this;
        }

        public HtmlAttributes Title(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("title");
                Add(value);
            }
            return this;
        }

        public HtmlAttributes Placeholder(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("placeholder");
                Add(value);
            }
            return this;
        }

        public HtmlAttributes AccessKey(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("accesskey");
                Add(value);
            }
            return this;
        }

        public HtmlAttributes OnClick(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("onclick");
                Add(value);
            }
            return this;
        }

        public HtmlAttributes OnDblClick(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("ondblclick");
                Add(value);
            }
            return this;
        }

        public HtmlAttributes OnChange(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("onchange");
                Add(value);
            }
            return this;
        }

        public HtmlAttributes Disabled(bool value = false, bool _using = true)
        {
            if (value && _using)
            {
                Add("disabled");
                Add("disabled");
            }
            return this;
        }

        public HtmlAttributes Colspan(int value, bool _using = true)
        {
            if (value != 0 && _using)
            {
                Add("colspan");
                Add(value.ToString());
            }
            return this;
        }

        public HtmlAttributes DateTime(DateTime value, bool _using = true)
        {
            if (value.InRange() && _using)
            {
                Add("datetime");
                Add(value.ToString("s"));
            }
            return this;
        }

        public HtmlAttributes DataId(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("data-id");
                Add(value);
            }
            return this;
        }

        public HtmlAttributes DataType(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("data-type");
                Add(value);
            }
            return this;
        }

        public HtmlAttributes DataMethod(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("data-method");
                Add(value);
            }
            return this;
        }

        public HtmlAttributes DataAction(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("data-action");
                Add(value);
            }
            return this;
        }

        public HtmlAttributes DataIcon(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("data-icon");
                Add(value);
            }
            return this;
        }

        public HtmlAttributes DataSelector(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("data-selector");
                Add(value);
            }
            return this;
        }

        public HtmlAttributes DataValue(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("data-value");
                Add(value);
            }
            return this;
        }

        public HtmlAttributes DataVer(int value, bool _using = true)
        {
            if (_using)
            {
                Add("data-ver");
                Add(value.ToString());
            }
            return this;
        }

        public HtmlAttributes DataLatest(int value, bool _using = true)
        {
            if (_using)
            {
                Add("data-latest");
                Add(value.ToString());
            }
            return this;
        }

        public HtmlAttributes DataConfirm(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("data-confirm");
                Add(value);
            }
            return this;
        }

        public HtmlAttributes DataClass(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("data-class");
                Add(value);
            }
            return this;
        }

        public HtmlAttributes DataStyle(string value, bool _using = true)
        {
            if (!value.IsNullOrEmpty() && _using)
            {
                Add("data-style");
                Add(value);
            }
            return this;
        }

        public HtmlAttributes DataWidth(int value, bool _using = true)
        {
            if (_using)
            {
                Add("data-width");
                Add(value.ToString());
            }
            return this;
        }
    }
}