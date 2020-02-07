using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Agenda : Form
    {
        public DataTable tblContatos;
        public DataRowState sttContato;
        public int Counter;
        public Agenda()
        {
            InitializeComponent();
            Load += ApplicationLoad;
            KeyDown += ApplicationKeyDown;
        }
    }
}
