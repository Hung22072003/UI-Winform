using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using UI_Winform.View;
using UI_Winform.DTO;

namespace UI_Winform
{
    public partial class AdminForm : Form
    {
        private string ID_User;
        private string typeAccount;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public AdminForm(string iD_User, string typeAccount)
        {
            this.typeAccount = typeAccount;
            ID_User = iD_User;
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    if (currentButton != null)
                    {
                        DisableButton(currentButton);
                    }
                    
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitle.BackColor = color;
                    Lb_Title.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null) 
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            Lb_Title.Text = childForm.Text;
        }
        private void DisableButton(Button currentButton)
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(23, 195, 178);
                currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            
        }

        private void Btn_Revenue_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRevenue(), sender);
        }

        private void Btn_Staff_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormStaff(), sender);
        }

        private void Btn_Storage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormStorage(ID_User, typeAccount), sender);
        }

        private void Btn_TradeHistory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Btn_Report(), sender);
        }

        private void Btn_Setting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RevenueTimeForm(), sender); 
        }

        private void panelLogo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton(currentButton);
            Lb_Title.Text = "Trang chủ";
            Lb_Title.BackColor = Color.FromArgb(23, 195, 178);
            panelTitle.BackColor = Color.FromArgb(23, 195, 178);
            panelLogo.BackColor = Color.FromArgb(23, 195, 178);
            currentButton = null;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            } else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Discount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDiscount(), sender);
        }

        private void Btn_Customer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCustomer(), sender);
        }
    }
}
