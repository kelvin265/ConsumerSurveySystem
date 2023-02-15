using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumerSurveySystem.classes
{
    class Product
    {
        database db = new database();
        int Id;
        private string name, description, type;

        public Product(string Name, string Decription, string Type)
        {
            this.name = Name;
            this.description = Decription;
            this.type = Type;
        }
        public void registerProduct()
        {
            
            Id = db.codeGenerator("product");
            string query = " INSERT INTO product(id,name,description,type) VALUES(" + Id + ",'" + name + "','" + description + "','" + type + "')";
            bool result = db.insert(query);
            if (result)
            {
                MessageBox.Show("Product registered successfully as '" + type + "'", "Register info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to register the product !", "Register error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


    }
}
