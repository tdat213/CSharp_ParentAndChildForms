namespace CSharp_ParentAndChildForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void childFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Child1 cf1 = new Child1();
            cf1.MdiParent = this;
            cf1.Show();
        }
    }
}
