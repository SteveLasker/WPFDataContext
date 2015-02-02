using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ConnectedServices{
    /// <summary>
    /// A hyperlink used in the Connected Services Configuration UIs
    /// </summary>
    public class LinkItem {
        public string Text { get; set; }
        public Uri Uri { get; set; }
        public LinkItem(string text, Uri uri) {
            this.Text = text;
            this.Uri = uri;
        }
    }
}
