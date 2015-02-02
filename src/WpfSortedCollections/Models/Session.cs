using Microsoft.ConnectedServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSortedCollections.Models {
    
    public class Session : INotifyPropertyChanged{
        public Session(string title, string @abstract) {
            this.Title = title;
            this.Abstract= @abstract;
            this.RelatedLinks = new ObservableCollection<LinkItem>();
        }
        private string _title;
        public string Title {
            get { return _title; }
            set {
                if (value != _title) {
                    _title = value;
                    NotifyPropertyChanged("Title");
                }
            }
        }

        private string _abstract;
        public string Abstract {
            get { return _abstract; }
            set {
                if (value != _abstract) {
                    _abstract = value;
                    NotifyPropertyChanged("Abstract");
                }
            }
        }

        private ObservableCollection<LinkItem> _relatedLinks;
        public ObservableCollection<LinkItem> RelatedLinks {
            get {
                return _relatedLinks;
            }
            set { _relatedLinks = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName) {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
