using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;    //import DatabaseLayer namespace
using EntityLayer;

namespace LogicTier
{
    public class LTCategory
    {
        public DLCategory objDataLayer = new DLCategory();  //create a DataLayer object

        //create, select, update, delete functions to update from presentation layer to database layer
        public void AddCategory(Category category)
        {
            objDataLayer.AddCategoryDB(category);
        }

        public void UpdateCategory(Category category)
        {
            objDataLayer.UpdateCategoryDB(category);
        }

        public void DeleteCategory(Category category)
        {
            objDataLayer.DeleteCategoryDB(category);
        }

        public object RetrieveCategory()
        {
            return objDataLayer.RetrieveCategoryDB();
        }
    }
}
