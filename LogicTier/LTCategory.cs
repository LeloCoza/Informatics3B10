using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;    //import DatabaseLayer namespace

namespace LogicTier
{
    public class LTCategory
    {
        public DLCategory objDataLayer = new DLCategory();  //create a DataLayer object

        //create, select, update, delete functions to update from presentation layer to database layer
        public void AddCategory(string category_name)
        {
            objDataLayer.AddCategoryDB(category_name);
        }

        public void UpdateCategory(int category_id, string category_name)
        {
            objDataLayer.UpdateCategoryDB(category_id, category_name);
        }

        public void DeleteCategory(int category_id)
        {
            objDataLayer.DeleteCategoryDB(category_id);
        }

        public object RetrieveCategory()
        {
            return objDataLayer.RetrieveCategoryDB();
        }
    }
}
