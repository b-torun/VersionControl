using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Catalog;
using Hotcakes.CommerceDTO.v1.Client;
using Hotcakes.CommerceDTO.v1.Contacts;
using Hotcakes.CommerceDTO.v1.Orders;
using Newtonsoft.Json;

namespace kliens_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string url = "http://20.234.113.211:8104/";
            string key = "1-a214f5dc-33f7-4ceb-b1cc-9b742b132458";

            Api proxy = new Api(url, key);

            var product = new ProductDTO();


            // populate the product object with minimal information
            product.ProductName = textBoxName.Text;
            product.ManufacturerId = textBoxMan.Text;
            product.SitePrice = Int32.Parse(textBoxPrice.Text);
            product.MetaDescription = textBoxDesc.Text;
            product.MetaKeywords = "Vevő által feltöltött termék";

            ApiResponse<ProductDTO> response = proxy.ProductsCreate(product, null);

            textBoxName.Clear();
            textBoxPrice.Clear();
            textBoxMan.Clear();
            textBoxDesc.Clear();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxPrice.Clear();
            textBoxMan.Clear();
            textBoxDesc.Clear();
        }
    }
}
