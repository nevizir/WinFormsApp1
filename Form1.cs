namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public string copy { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new();

            if (dialog.ShowDialog() == DialogResult.OK)
                textBox1.ForeColor = dialog.Color;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new() { Filter = "Text Files|*.txt" };
            dialog.DefaultExt = ".txt";

            if (dialog.ShowDialog() == DialogResult.OK)
                File.WriteAllText(dialog.FileName, textBox1.Text);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new() { Filter = "Text Files|*.txt" };

            if (dialog.ShowDialog() == DialogResult.OK)
                textBox1.Text = File.ReadAllText(dialog.FileName);
        }

        private void baToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new();

            if (dialog.ShowDialog() == DialogResult.OK)
                textBox1.BackColor = dialog.Color;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new();
            dialog.Font = textBox1.Font;

            if (dialog.ShowDialog() == DialogResult.OK)
                textBox1.Font = dialog.Font;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.Length.ToString();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copy = textBox1.Text;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = copy;
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void deselectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.DeselectAll();
        }
    }
}