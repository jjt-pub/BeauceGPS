using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgOpenGPS.Forms
{
    public partial class FormFreeDrive : Form
    {
        private readonly FormGPS mf = null;

        public FormFreeDrive(Form callingForm)
        {
            mf = callingForm as FormGPS;
            InitializeComponent();
        }

        private void btnSteerAngleUp_MouseDown(object sender, MouseEventArgs e)
        {
            System.Int16 angle = getSteerAngle();
            angle ++;
            setSteerAngle(angle);
        }

        private void btnSteerAngleDown_MouseDown(object sender, MouseEventArgs e)
        {
            System.Int16 angle = getSteerAngle();
            angle--;
            setSteerAngle(angle);
        }

        private void btnFreeDrive_Click(object sender, EventArgs e)
        {
            if (mf.ast.isInFreeDriveMode)
            {
                freeDriveOff();
            }
            else
            {
                freeDriveOn();
            }
        }

        private void FormFreeDrive_Load(object sender, EventArgs e)
        {
            freeDriveOff();
        }

        private void btnNeutral_MouseDown(object sender, MouseEventArgs e)
        {
            toNeutral();
        }

        private void setSteerAngle(System.Int16 angle)
        {
            if (angle > 40) angle = 40;
            else if (angle < -40) angle = -40;

            mf.ast.driveFreeSteerAngle = angle;
            mf.sim.steerAngleScrollBar = angle;
            tbSteer.Value = angle;
            btnResetSteerAngle.Text = angle.ToString("N0");
        }

        private void setAccel(System.Int16 accel)
        {
            if (accel > 40) accel = 40;
            else if (accel < -0) accel = 0;
            tbAccel.Value = accel;
        }

        private System.Int16 getAccel()
        {
            return (short)tbAccel.Value;
        }

        private System.Int16 getSteerAngle()
        {
            return mf.ast.driveFreeSteerAngle;
        }

        private void toNeutral()
        {
            btnNeutral.BackColor = Color.LimeGreen;
            btnForward.BackColor = SystemColors.ControlLight;
        }

        private void toForward()
        {
            btnNeutral.BackColor = SystemColors.ControlLight;
            btnForward.BackColor = Color.LimeGreen;
        }

        private void freeDriveOff()
        {
            //turn OFF free drive mode
            btnFreeDrive.BackColor = Color.Red;
            mf.ast.isInFreeDriveMode = false;
            btnSteerAngleDown.Enabled = false;
            btnSteerAngleUp.Enabled = false;
            btnNeutral.Enabled = false;
            btnForward.Enabled = false;
            btnResetSteerAngle.Enabled = false;
            btnMach1.Enabled = false;
            setMachineOff(btnMach1);
            btnMach2.Enabled = false;
            setMachineOff(btnMach2);
            btnMach3.Enabled = false;
            setMachineOff(btnMach3);
            btnMach4.Enabled = false;
            setMachineOff(btnMach4);
            btnMach5.Enabled = false;
            setMachineOff(btnMach5);
            btnMach6.Enabled = false;
            setMachineOff(btnMach6);
            btnUp.Enabled = false;
            btnDn.Enabled = false;
            //hSBarFreeDrive.Value = 0;
            setSteerAngle(0);
            toNeutral();
        }

        private void freeDriveOn()
        {
            //turn ON free drive mode
            btnFreeDrive.BackColor = Color.LimeGreen;
            mf.ast.isInFreeDriveMode = true;
            btnSteerAngleDown.Enabled = true;
            btnSteerAngleUp.Enabled = true;
            btnNeutral.Enabled = true;
            btnForward.Enabled = true;
            btnResetSteerAngle.Enabled = true;
            btnMach1.Enabled = true;
            setMachineOff(btnMach1);
            btnMach2.Enabled = true;
            setMachineOff(btnMach2);
            btnMach3.Enabled = true;
            setMachineOff(btnMach3);
            btnMach4.Enabled = true;
            setMachineOff(btnMach4);
            btnMach5.Enabled = true;
            setMachineOff(btnMach5);
            btnMach6.Enabled = true;
            setMachineOff(btnMach6);
            btnUp.Enabled = true;
            btnDn.Enabled = true;
            //hSBarFreeDrive.Value = 0;
            setSteerAngle(0);
            //lblSteerAngle.Text = "0";
        }

        private void FormFreeDrive_Leave(object sender, EventArgs e)
        {
            freeDriveOff();
        }

        private void btnResetSteerAngle_MouseDown(object sender, MouseEventArgs e)
        {
            setSteerAngle(0);
        }

        private void btnForward_MouseDown(object sender, MouseEventArgs e)
        {
            toForward();
        }

        private void tbSteer_Scroll(object sender, EventArgs e)
        {

        }

        private void btnSteerAngleUp_Click(object sender, EventArgs e)
        {

        }

        private void btnUp_MouseDown(object sender, MouseEventArgs e)
        {
            System.Int16 accel = getAccel();
            accel++;
            setAccel(accel);
        }

        private void btnDn_MouseDown(object sender, MouseEventArgs e)
        {
            System.Int16 accel = getAccel();
            accel--;
            setAccel(accel);
        }


        private void btnMach_click(Button btnMach)
        {
            if (btnMach.Tag.Equals("ON")) setMachineOff(btnMach);
            else setMachineOn(btnMach);
        }

        private void setMachineOff(Button btnMach)
        {
            btnMach.BackColor = SystemColors.ControlLight; ;
            btnMach.Tag = "OFF";
        }

        private void setMachineOn(Button btn)
        {
            btn.BackColor = Color.LimeGreen;
            btn.Tag = "ON";
        }

        private void btnMach1_MouseDown(object sender, MouseEventArgs e)
        {
            btnMach_click(btnMach1);
        }

        private void btnMach2_MouseDown(object sender, MouseEventArgs e)
        {
            btnMach_click(btnMach2);
        }

        private void btnMach3_MouseDown(object sender, MouseEventArgs e)
        {
            btnMach_click(btnMach3);
        }

        private void btnMach4_MouseDown(object sender, MouseEventArgs e)
        {
            btnMach_click(btnMach4);
        }

        private void btnMach5_MouseDown(object sender, MouseEventArgs e)
        {
            btnMach_click(btnMach5);
        }

        private void btnMach6_MouseDown(object sender, MouseEventArgs e)
        {
            btnMach_click(btnMach6);
        }
    }
}
