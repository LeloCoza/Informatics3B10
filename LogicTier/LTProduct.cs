using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;    //import DatabaseLayer namespace
using EntityLayer;

namespace LogicTier
{
    public class LTProduct
    {
        public DLProduct objDataLayer = new DLProduct();  //create a DatabaseLayer object

        //create, select, update, delete functions to update from presentation layer to database layer
        public void AddProduct(Product product)
        {
            objDataLayer.AddProductDB(product);
        }

        public void UpdateProduct(Product product)
        {
            objDataLayer.UpdateProductDB(product);
        }

        public void DeleteProduct(Product product)
        {
            objDataLayer.DeleteProductDB(product);
        }

        public object RetrieveProduct()
        {
            return objDataLayer.RetrieveProductDB();
        }
    }
}
