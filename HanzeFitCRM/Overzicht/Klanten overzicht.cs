using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HanzeFitCRM
{
    public partial class Klanten_overzicht : Form
    {
        TableClass AlgemeneFunctiesObject;

        public Klanten_overzicht(TableClass AlgemeneFunctiesObject)
        {
            this.AlgemeneFunctiesObject = AlgemeneFunctiesObject;
            InitializeComponent();
        }
    }
}
