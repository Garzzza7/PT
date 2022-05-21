using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DataBase;

namespace Service
{
    internal class ClientCRUD
    {
        public ClientCRUD()
        {

        }
        static public bool AddClient(int ID , string name , string surname)
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {//lolo
                Clients__ newCustomer = new Clients__
                {
                    customer_id = id,
                    customer_f_name = name,
                    customer_l_name = surname

                };
                context.customer.InsertOnSubmit(newCustomer);
                context.SubmitChanges();

                return true;
            }
        }
    }
}
