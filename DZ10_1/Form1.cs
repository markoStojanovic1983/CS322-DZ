using System;
using System.Collections;
using System.Windows.Forms;

namespace DZ10_1
{
    public partial class Form1 : Form
    {
        private ArrayList numberList;
        private Stack numberStack;
        private Queue numberQueue;
        private Random random;

        public Form1()
        {
            InitializeComponent();
            numberList = new ArrayList();
            numberStack = new Stack();
            numberQueue = new Queue();
            random = new Random();
            InitializeData();
        }

        private void InitializeData()
        {
            // Initialize with 100 random numbers
            for (int i = 0; i < 100; i++)
            {
                int number = random.Next(1000);
                numberList.Add(number);
                numberStack.Push(number);
                numberQueue.Enqueue(number);
            }
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBoxNumbers.DataSource = null;
            listBoxNumbers.DataSource = numberList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int newNumber = random.Next(1000);
            numberList.Add(newNumber);
            numberStack.Push(newNumber);
            numberQueue.Enqueue(newNumber);
            UpdateListBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxNumbers.SelectedIndex != -1)
            {
                object selectedItem = listBoxNumbers.SelectedItem;
                numberList.Remove(selectedItem);
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("Please select an item to delete.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            if (numberStack.Count > 0)
            {
                object item = numberStack.Pop();
                // Remove the popped item from ArrayList as well
                numberList.Remove(item);
                UpdateListBox();
                MessageBox.Show($"Popped item from stack: {item}", "Stack Operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Stack is empty!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            if (numberQueue.Count > 0)
            {
                object item = numberQueue.Dequeue();
                // Remove the dequeued item from ArrayList as well
                numberList.Remove(item);
                UpdateListBox();
                MessageBox.Show($"Dequeued item from queue: {item}", "Queue Operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Queue is empty!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}