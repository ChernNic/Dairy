using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dairy.Models
{
    class NoteModel
    {
        private string _Title;
        private string _Text;

        public DateTime date { get; set; } 

        public string Title 
        {
            get { return _Title; }
            set { _Title = value;  }
        }

        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
        }
    }
}
