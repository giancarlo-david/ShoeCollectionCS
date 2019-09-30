using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeCollectionCS
{
    public class shoe
    {
        private string brand = null;
        private string model = null;
        private string colorway = null;

        public shoe()
        {
        }

        public string Brand
        {
            get
            {
                return brand;
            }

            set
            {
                brand = value;
            }
        }
        
        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public string Color
        {
            get
            {
                return colorway;
            }

            set
            {
                colorway = value;
            }
        }

    }
}
