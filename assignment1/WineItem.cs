using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        /*Backing Fields*/
        private string _description;
        private string _id;
        private string _pack;

        /*Properties*/
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Pack
        {
            get { return _pack; }
            set { _pack = value; }
        }

        /*Constructors*/
        public WineItem(string id, string description, string pack)
        {
            this._id = id;
            this._description = description;
            this._pack = pack;
        }
        public WineItem()
        {
            /*Default Constructor*/
        }

        /*Public Methods*/
        public override string ToString()
        {
            return this.ID + "  " + this.Description + "  " + this.Pack;
        }
    }
}

