using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MyMVVMProject.Model;

namespace MyMVVMProject.ViewModel
{
    // Implements INotifyPropertyChanged interface to support bindings
    public class HelloWorldViewModel : INotifyPropertyChanged
    {
        private string helloString;

        public event PropertyChangedEventHandler? PropertyChanged;

        public HelloWorldViewModel()
        {
            HelloWorldModel helloWorldModel = new HelloWorldModel();
            helloString = helloWorldModel.ImportantInfo;
        }

        public string HelloString
        {
            get
            {
                return helloString;
            }
            set
            {
                helloString = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Raises OnPropertychangedEvent when property changes
        /// </summary>
        /// <param name="name">String representing the property name</param>
        protected void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}