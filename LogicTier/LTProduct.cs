using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;    //import DatabaseLayer namespace

namespace LogicTier
{
    public class LTProduct
    {
        public DLProduct objDataLayer = new DLProduct();  //create a DatabaseLayer object

        //create, select, update, delete functions to update from presentation layer to database layer
        public void AddProduct(string prod_name, string prod_descript, string prod_price, string prod_pic)
        {
            objDataLayer.AddProductDB(prod_name, prod_descript, prod_price, prod_pic);
        }

        public void UpdateProduct(int prod_id, string prod_name, string prod_descript, string prod_price, string prod_pic)
        {
            objDataLayer.UpdateProductDB(prod_id, prod_name, prod_descript, prod_price, prod_pic);
        }

        public void DeleteProduct(int prod_id)
        {
            objDataLayer.DeleteProductDB(prod_id);
        }

        public object RetrieveProduct()
        {
            return objDataLayer.RetrieveProductDB();
        }
    }
}
