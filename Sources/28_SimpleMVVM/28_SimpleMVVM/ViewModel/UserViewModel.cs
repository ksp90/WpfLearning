using _28_SimpleMVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _28_SimpleMVVM.ViewModel
{
    public class UserViewModel : ViewModelBase
    {
        private User _user;
        private ObservableCollection<User> _users;
        private ICommand _SubmitCommand;
        public User User
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
                NotifyPropertyChanged("User");
            }
        }
        public ObservableCollection<User> Users
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value;
                NotifyPropertyChanged("Users");
            }
        }
        public ICommand SubmitCommand
        {
            get
            {
                if (_SubmitCommand == null)
                {
                    _SubmitCommand = new RelayCommand(param => this.Submit(),
                        null);
                }
                return _SubmitCommand;
            }
        }
        public UserViewModel()
        {
            User = new User();
            Users = new ObservableCollection<User>();
            Users.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(Students_CollectionChanged);
        }
        //Whenever new item is added to the collection, am explicitly calling notify property changed
        void Students_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            NotifyPropertyChanged("Users");
        }
        private void Submit()
        {
            User.EntryDate = DateTime.Today.Date;
            Users.Add(User);
            User = new User();
        }
    }
}
