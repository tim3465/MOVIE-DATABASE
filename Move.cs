using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVIE_DATABASE
{
    internal class Move
    {
        //properties 
        public string Title { get; set; }
        public string Category  { get; set; }

        //constructor
        public Move(string _title, string _category)
        {
            Title = _title;
            Category = _category;
        }

        //methds
        public string GetDetails()
        {
            return $"\"{Title}\" is a {Category}";
        }



    }
}
