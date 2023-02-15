using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumerSurveySystem.classes
{
    class Survey
    {
        database db = new database();
        int Id, productId;
        private string title, openDate, closeDate, description;

        public Survey(int productId, string title, string openDate, string closeDate, string description)
        {
            this.title = title;
            this.productId = productId;
            this.openDate = openDate;
            this.closeDate = closeDate;
            this.description = description;
        }
        public void createSurvey()
        {
            Id = db.codeGenerator("survey");
            string query = " INSERT INTO survey(id,productId,title,openDate,closeDate,description) VALUES(" + Id + "," + productId + ",'" + title + "','" + openDate + "','" + closeDate + "','" + description + "')";
            bool result = db.insert(query);
            if (result)
            {
                MessageBox.Show("'" + title + "' survey added successfully", "Register info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to add new survey", "Register error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
