using Microsoft.ConnectedServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSortedCollections.ViewModels {
    public class SessionsViewModel :INotifyPropertyChanged{
        public SessionsViewModel() {
            this.Session = new Models.Session("Doing Something New", "the long abstract");
            this.Session.RelatedLinks.Add(new LinkItem("LinkText", new Uri("http://foo.com")));
            this.Session.RelatedLinks.Add(new LinkItem("MoreLink", new Uri("http://foobar.com")));
            this.NewLinkTitle = "A New Link Title";
            this.NewUrl = "http://Somewhere.com";
        }

        private string _newLinkTitle;
        public string NewLinkTitle {
            get { return _newLinkTitle; }
            set {
                if (value != _newLinkTitle) {
                    _newLinkTitle = value;
                    NotifyPropertyChanged("NewLink");
                }
            }
        }

        private string _newUrl;
        public string NewUrl {
            get { return _newUrl; }
            set {
                if (value != _newUrl) {
                    _newUrl = value;
                    NotifyPropertyChanged("NewUrl");
                }
            }
        }


        private Models.Session _session;
        public Models.Session Session {
            get { return _session; }
            set {
                if (value != _session) {
                    _session = value;
                    NotifyPropertyChanged("Event");
                }
            }
        }

        public void AddNewRelatedSession() {
            this.Session.RelatedLinks.Add(new Microsoft.ConnectedServices.LinkItem(this.NewLinkTitle, new Uri(this.NewUrl)));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName) {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
