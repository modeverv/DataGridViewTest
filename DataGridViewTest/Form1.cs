using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewTest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = getUserList();
        }

        private List<User> getUserList()
        {
            List<User> list = new List<User>();
            for(int i = 0; i < 100; i++)
            {
                list.Add(new User(i, "name" + i.ToString()));
            }
            return list;
        }
    }

    public class User
    {
        public int id
        {
            get; set;
        }
        public string name
        {
            get; set;
        }

        public User(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
