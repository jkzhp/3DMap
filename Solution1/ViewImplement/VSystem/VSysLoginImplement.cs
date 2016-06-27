using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewImplement.VSystem
{
    public partial class VSysLoginImplement : Form, ViewInterface.VSystem.VSysLoginInterface
    {
        private VSysLoginImplement vLogin;
        public VSysLoginImplement()
        {
            InitializeComponent();
        }


        public Form getInstance()
        {
            return vLogin;
        }
    }
}
