using System;
using System.Collections;
using System.Windows.Forms;

namespace ListArrayListExample
{
    public partial class Form1 : Form
    {
        private List<string> dataList = new List<string>();
        private ArrayList arrayList = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            string newItem = DateTime.Now.ToString("hh:mm:ss");
            dataList.Add(newItem);
            UpdateListBox();
        }

        private void btnAddToArrayList_Click(object sender, EventArgs e)
        {
            string newItem = DateTime.Now.ToString("hh:mm:ss");
            arrayList.Add(newItem);
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBoxData.Items.Clear();
            listBoxData.Items.AddRange(dataList.ToArray());
            listBoxData.Items.AddRange(arrayList.ToArray());
        }

        private void listBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxData.SelectedIndex;
            if (selectedIndex >= 0)
            {
                if (selectedIndex < dataList.Count)
                {
                    dataList.RemoveAt(selectedIndex);
                }
                else
                {
                    arrayList.RemoveAt(selectedIndex - dataList.Count);
                }
                UpdateListBox();
            }
        }
    }
}

