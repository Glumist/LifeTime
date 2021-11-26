using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LifeTime.Classes;

namespace LifeTime.Forms
{
    public partial class FormEventInfo : Form
    {
        public FormEventInfo(DateEvent dateEvent)
        {
            InitializeComponent();

            dtpEventDate.Value = dateEvent.Date;
            tbEventInfo.Text = dateEvent.Info;
            tbFio.Text = dateEvent.Contact.Fio;
            dtpBirthDate.Value = dateEvent.Contact.BirthDate;
            tbContactInfo.Text = dateEvent.Contact.Info;
        }
    }
}
