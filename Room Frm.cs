using DavidRoomReservation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DavidRoomreservation
{
   
    public partial class Room_Frm : Form
    {
        private readonly DavidRoomReservationContext _reservationContext;
        public Room_Frm(DavidRoomReservationContext davidRoomReservationContext)
        {

            InitializeComponent();
            _reservationContext= davidRoomReservationContext;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String txtAddName = this.txtAddName.Text;


        }

        private void Room_Frm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
