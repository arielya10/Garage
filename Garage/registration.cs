using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Garage_V1;
using Airplanes;
using Boats;
using Vehicles;
using Cars;
using Motorcycles;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Final
{
    public partial class registration : Form
    {
        Graphics graphics; Pen pen; Point cursor;
        Point []points = new Point [5];
        List<Garage> _list = new List<Garage>();
        List<PictureBox> items = new List<PictureBox> ();
        public registration()
        {
            InitializeComponent();
            pen = new Pen(Color.Red, 3);
            graphics=this.CreateGraphics();
        }

    private void registration_Load(object sender, EventArgs e)    // startup
        {
            panel1.Hide();
            hiding();
            uerror.Hide();
            uKM.Hide();
            uBox.Hide();
            l11.Hide(); 
        }
    private void hiding() 
        {
            label7.Hide();
            label8.Hide();
            textBox1.Hide();
            radioButton1.Hide(); 
            radioButton2.Hide();
            label9.Hide();
            textBox2.Hide();
            
        }
        private void clear()                  //clear the data from New_Vehicle
        {
            comboBox1.SelectedItem = null;
            comboBox1.Items.Clear();
            year.Text = "";
            max_speed.Text = "";
            km_passed.Text = "";
            error.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textName.Text = "";
            wheelSize.Text = "";
            hiding();
        }
        private void clear_menu()                // clear all the obj data from menu
        {
            uBox.Hide();
            uKM.Hide();
            uerror.Hide();
            l1.Text = "";
            l2.Text = "";
            l3.Text = "";
            l4.Text = "";
            l5.Text = "";
            l6.Text = "";
            l7.Text = "";
            l8.Text = "";
            l9.Text = "";
            l12.Text = "";
            textBox6.Text = "";
            pictureBox1.Image = null;
        }
        private void showing()
        {
            label7.Show();
            label8.Show();
            textBox1.Show();
            radioButton1.Show();
            radioButton2.Show();
            label24.Show();
            wheelSize.Show();
            if (selection.SelectedItem == "Airplane")
            {
                label8.Text = "Wings Size:";
                label7.Text = "Maximum people:";
                radioButton1.Text = "10";
                radioButton2.Text = "30";
            }
            else if (selection.SelectedItem == "Car")
            {
                label7.Text = "Color:";
                label8.Text = "Gear:";
                radioButton1.Text = "Automatic";
                radioButton2.Text = "Manual";
                label9.Show();
                textBox2.Show();
                label9.Text = "Safety Level:";
            }
            else if(selection.SelectedItem == "Boat")
            {
                label7.Text = "Propelor Size:";
                label8.Text = "Has Kitchen:";
                radioButton1.Text = "True";
                radioButton2.Text = "False";
                wheelSize.Hide();
                label24.Hide();
            }
            else if (selection.SelectedItem == "Motorcycle")
            {
                label7.Text = "Color:";
                label8.Text = "Gear:";
                radioButton1.Text = "Automatic";
                radioButton2.Text = "Manual";
                label9.Show();
                textBox2.Show();
                label9.Text = "Horse Power:";
            }
            else
            {
                label7.Text = "Color:";
                label8.Text = "Gear:";
                radioButton1.Text = "Automatic";
                radioButton2.Text = "Manual";
            }
        }
        private void selection_SelectedIndexChanged(object sender, EventArgs e)                  //adding to the right obj all of his Brands
        {
            string[] cars = { "Audi", "Cadillac", "Chevrolet", "Citroen", "Ford", "KIA" , "Mitsubishi", "Nissan", "Porsche", "Tesla", "Toyota", "Volvo" };
            string[] Airplanes = { "Airbus", "Boeing" };
            string[] Boats = { "Aviara", "Carver","Gala","Pearl", "X-Yachts" };
            string[] Motorcycles = { "Honda", "Yamaha", "Suzuki", "BMW", "KTM", "HARLEY-DAVIDSON", "Ducati"};
            string[] Vehicles = { "Buick", "Chevrolet", "GMC", "Jeep", "Land Rover","Lexus"  };
            if (selection.SelectedItem == "Car")
            {
                clear();
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(cars);
                showing();
            }
            else if (selection.SelectedItem == "Airplane")
            {
                clear();
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(Airplanes);
                showing();
            }
            else if (selection.SelectedItem == "Boat")
            {
                clear();
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(Boats);
                showing();
            }
            else if (selection.SelectedItem == "Motorcycle")
            {
                clear();
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(Motorcycles);
                showing();
            }
            else if (selection.SelectedItem == "Vehicle")
            {
                clear();
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(Vehicles);
                showing();
            }
        }

        private void add_Click(object sender, EventArgs e)                     //adding new Vehicle
        {
            if (selection.Text == "")
                MessageBox.Show("Invalid Vehicle Type");
            else if (comboBox1.Text == "")
                MessageBox.Show("Invalid Manufacturer");
            else if (year.Text == "" || int.Parse(year.Text) < 1970 || int.Parse(year.Text) > DateTime.Now.Year)
                MessageBox.Show("Invalid Year");
            else if (max_speed.Text == "" || int.Parse(max_speed.Text) > 1000)
                MessageBox.Show("Invalid Speed");
            else if (km_passed.Text == "")
                MessageBox.Show("Invalid Kilometers");
            else if (error.Text == "")
                MessageBox.Show("Invalid Text");
            else if (selection.SelectedItem == "Airplane" && (textBox1.Text == "" || int.Parse(textBox1.Text) < 1 || int.Parse(textBox1.Text) > 1000))
                MessageBox.Show("Invalid Maximum People");
            else if (selection.SelectedItem == "Boat" && textBox1.Text == "")
                MessageBox.Show("Invalid Propelor Size");
            else if (selection.SelectedItem == "Vehicle" && textBox1.Text=="")
                MessageBox.Show("Invalid Color");
            else if (selection.SelectedItem == "Car" && (textBox1.Text == "" || textBox2.Text==""))
                MessageBox.Show("Invalid");
            else if (selection.SelectedItem == "Motorcycle" && (textBox1.Text == "" || textBox2.Text == ""))
                MessageBox.Show("Invalid");
            else if (radioButton1.Checked == false && radioButton2.Checked == false) 
                MessageBox.Show("You Need To Select");
            else if (wheelSize.Text =="" && selection.SelectedItem  != "Boat" && (int.Parse(wheelSize.Text)>25 || int.Parse(wheelSize.Text)<1) )
                MessageBox.Show("Invalid Wheel Size");
            else if (textName.Text=="")
                MessageBox.Show("You Need To Enter Name");
            else
            {
                string value;
                Garage item;
                if (radioButton1.Checked)
                    value = radioButton1.Text;
                else
                    value = radioButton2.Text;
                if (selection.Text== "Airplane")
                     item = new Airplane(textName.Text,comboBox1.Text, int.Parse(year.Text),error.Text, int.Parse(max_speed.Text), int.Parse(km_passed.Text),int.Parse(wheelSize.Text),int.Parse(textBox1.Text),double.Parse(value));
                else if (selection.Text == "Boat")
                     item = new Boat(textName.Text,comboBox1.Text, int.Parse(year.Text), error.Text, int.Parse(max_speed.Text), int.Parse(km_passed.Text), 0, int.Parse(textBox1.Text), bool.Parse(value));
                else if (selection.Text == "Vehicle")
                     item = new Vehicle(textName.Text,comboBox1.Text, int.Parse(year.Text), error.Text, int.Parse(max_speed.Text), int.Parse(km_passed.Text), int.Parse(wheelSize.Text), textBox1.Text, value);
                else if (selection.Text == "Motorcycle")
                     item = new Motorcycle(textName.Text,comboBox1.Text, int.Parse(year.Text), error.Text, int.Parse(max_speed.Text), int.Parse(km_passed.Text), int.Parse(wheelSize.Text), textBox1.Text, value,int.Parse(textBox2.Text));
                else
                    item = new Car(textName.Text,comboBox1.Text, int.Parse(year.Text), error.Text, int.Parse(max_speed.Text), int.Parse(km_passed.Text), int.Parse(wheelSize.Text), textBox1.Text, value, int.Parse(textBox2.Text));
                MessageBox.Show($"{selection.Text} added ");
                selection.SelectedItem = null;
                _list.Add(item);
                comboBox2.Items.Add(item.Name);
                makePictureBox(item);
                clear();
            }
        }
        private void clear_button_Click(object sender, EventArgs e)           //     clear button 
        {
            selection.SelectedItem = null;
            clear();
        }

        private void menuButton_Click(object sender, EventArgs e)               // Menu button, showing p1 and hiding p3
        {
            panel3.Show();
            panel1.Hide(); 
        }

        private void button1_Click(object sender, EventArgs e)                  // New_Vehicle button, showing p3 and hiding p1
        {
            panel1.Show();
            panel3.Hide();
        }

        private void text(Garage g)    // showing all the info of the obj' on labels 
        {
            l8.Hide();
            label12.Hide();
            l2.Text = g.Manufacturer;
            l3.Text = g.Year.ToString();
            l4.Text = g.Max_speed.ToString();
            l5.Text = g.KM.ToString();
            l9.Text=g.Name.ToString();
            textBox6.Text=g.Error.ToString();
            l12.Text = g.Next_visit().ToString();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)              // selecting the obj to get info about
        {
            string name;
            name = comboBox2.SelectedItem.ToString();
            uerror.Show();
            uKM.Show();
            uBox.Show();
            panel3.Show();
            panel1.Hide();
            l11.Show();
            foreach(Garage g in _list)
            {
                if(g.Name == name)
                {
                    if (g is Airplane)
                    {
                        Airplane a1 = (Airplane)g;
                        l1.Text = "Airplane";
                        text(a1);
                        label13.Text = "Wings Size:";
                        label14.Text = "Maximum People:";
                        l6.Text = a1.Max_People.ToString();
                        l7.Text= a1.Wings_Size.ToString();
                    }
                    else if (g is Boat)
                    {
                        Boat b1 = (Boat)g;
                        l1.Text = "Boat";
                        text(b1);
                        label13.Text = "Propelor Size:";
                        label14.Text = "Has Kitchen:";
                        l7.Text = b1.PropelorSize.ToString();
                        l6.Text=b1.HasKitchen.ToString();
                    }
                    else if ( g is Car)
                    {
                        Car c = (Car)g;
                        l1.Text = "Car";
                        text(c);
                        label13.Text = "Color:";
                        label14.Text = "Gear:";
                        l6.Text = c.Color.ToString();
                        l7.Text = c.Gear.ToString();
                        l8.Show();
                        label12.Show();
                        label12.Text = "Safety Level:";
                        l8.Text=c.Safe_level.ToString();
                    }
                    else if (g is Motorcycle)
                    {
                        Motorcycle m = (Motorcycle)g;
                        l1.Text = "Motorcycle";
                        text(m);
                        label13.Text = "Color:";
                        label14.Text = "Gear:";
                        l6.Text = m.Color.ToString();
                        l7.Text = m.Gear.ToString();
                        l8.Show();
                        label12.Show();
                        label12.Text = "Horse Power:";
                        l8.Text = m.HP.ToString();
                    }
                    else if (g is Vehicle)
                    {
                        Vehicle v1 = (Vehicle)g;
                        l1.Text = "Vehicle";
                        text(v1);
                        label13.Text = "Color:";
                        label14.Text = "Gear:";
                        l6.Text = v1.Color.ToString();
                        l7.Text = v1.Gear.ToString();
                    }
                    pictureBox1.Invalidate();
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)       // save all data
        {
            try
            {
                using (Stream stream = File.Open("data.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, _list);
                }
            }
            catch (IOException)
            {
            }

        }
        private void loadButton_Click(object sender, EventArgs e)           // load all  data
        {
            try
            {
                using (Stream stream = File.Open("data.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    _list.Clear();
                    comboBox2.Items.Clear();
                    clear_menu();
                    var _list2 = (List<Garage>)bin.Deserialize(stream);
                    foreach (Garage g in _list2)
                    {
                        _list.Add(g);
                        comboBox2.Items.Add(g.Name);
                    }
                    pictureBox2.Invalidate();
                }
            }
            catch (IOException)
            {
            }
            if (items.Count > 0)
                foreach(PictureBox p in items.ToList())
                {
                    items.Remove(p);
                    p.Hide();
                }
            foreach(Garage g in _list)
            {
                makePictureBox(g);
            }
        }

        private void uerror_Click(object sender, EventArgs e)  // update error message of the obj'
        {
            foreach(Garage g in _list)
            {
                if (l9.Text == g.Name)
                    g.Error = textBox6.Text;
            }
        }

        private void uKM_Click(object sender, EventArgs e)    // update KM of the obj'
        {
            if (uBox.Text == "")
                MessageBox.Show("You Need To Enter Value");
            else
            {
                foreach (Garage g in _list)
                {
                    if (l9.Text == g.Name)
                    {
                        g.KM = int.Parse(uBox.Text);
                        l5.Text = uBox.Text;
                        l12.Text = g.Next_visit().ToString();
                        uBox.Text = "";
                        break;
                    }
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)       // remove the obj' from list
        {
            if (l9.Text == "" || comboBox2.Items.Count == 0)
                MessageBox.Show("There Is Nothing To Remove");
            else
            {
                foreach (Garage g in _list)
                {
                    if (l9.Text == g.Name)
                    {
                        foreach (PictureBox p in items)
                        {
                            if (g is Airplane && p.Width == 25)
                            {
                                p.Hide();
                                items.Remove(p);
                                break;
                            }
                            else if (g is Boat && p.Width == 22)
                            {
                                p.Hide();
                                items.Remove(p);
                                break;
                            }
                            else if (g is Car && p.Width == 40)
                            {
                                p.Hide();
                                items.Remove(p);
                                break;
                            }
                            else if (g is Motorcycle && p.Width == 20)
                            {
                                p.Hide();
                                items.Remove(p);
                                break;
                            }
                            else
                            {
                                p.Hide();
                                items.Remove(p);
                                break;
                            }
                        }
                        _list.Remove(g);
                        clear_menu();
                        comboBox2.Items.Remove(g.Name);
                        break;
                    }
                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            string flag = l1.Text.ToString();
            foreach (Garage g in _list)
            {
                if (comboBox2.SelectedItem == g.Name)
                {
                    e.Graphics.DrawEllipse(new Pen(Color.DarkRed, 15f), 20, 20, g.wheelSize,g.wheelSize);
                    break;
                }
            }
        }
        private void makePictureBox(Garage g)
        {
            PictureBox newPic = new PictureBox();
            if (g is Airplane)
            {
                newPic.BackColor = Color.Black;
                newPic.Width = 25;
                newPic.Height = 80;
            }
            else if (g is Boat)
            {
                newPic.BackColor = Color.Brown;
                newPic.Width = 22;
                newPic.Height = 68;
            }
            else if (g is Motorcycle)
            {
                newPic.BackColor = Color.DarkGreen;
                newPic.Width = 20;
                newPic.Height = 40;
            }
            else if (g is Car)
            {
                newPic.BackColor = Color.DarkRed;
                newPic.Width = 40;
                newPic.Height = 40;
            }
            else
            {
                newPic.BackColor = Color.Blue;
                newPic.Width = 50;
                newPic.Height = 50;
            }
            int x = this.ClientSize.Width/2;
            int y = this.ClientSize.Height-60;
            newPic.Location = new Point(x,y);
            this.Controls.Add(newPic);
            items.Add(newPic);
            newPic.BringToFront();
            newPic.Click += NewPic_Click;
            newPic.MouseDown += NewPic_MouseDown;
            newPic.MouseUp += NewPic_MouseUp;

        }

        private void NewPic_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox temPic = sender as PictureBox;
            temPic.Left = e.X - Location.X;
            temPic.Top = e.Y - Location.Y;
        }

        private void NewPic_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox temPic = sender as PictureBox;
            temPic.Left = e.X - Location.X;
            temPic.Top = e.Y - Location.Y;
        }

        private void NewPic_Click(object sender, EventArgs e)
        {
          
        }

        private void year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void max_speed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void km_passed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void wheelSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
