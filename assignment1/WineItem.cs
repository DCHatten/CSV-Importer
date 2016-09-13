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
        private Int32 _id;
        private string _pack;

        /*Properties*/
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public Int32 ID
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
        public WineItem(Int32 id, string description, string pack)
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
            return this._id + " " + this._description + " " + this._pack;
        }
    }
}

