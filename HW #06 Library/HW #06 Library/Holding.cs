using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW__06_Library
{
    abstract class Holding
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCheckedOut { get; set; }

        public Holding() 
        { 
            ID = 0;
            Title = "";
            Description = "";
            IsCheckedOut = false;
        }    

        public Holding(int id, string title, string description)
        {
            ID = id;
            Title = title;
            Description = description;
            IsCheckedOut = false;
        }

        public void CheckOut() 
        { 
            IsCheckedOut = true; 
        }
        public void CheckIn()
        {
            IsCheckedOut = false;
        }

        public abstract string HoldingType();

        public override string ToString()
        {
            return $"{ID}\n{HoldingType()}\n{Title}\n{Description}\n{(IsCheckedOut ? "Checked Out" : "Available")}";
        }
    }
}
