namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var fn = Outer();   // fn = Inner, ��� ��� ����� Outer ���������� ������� Inner
                                // �������� ���������� ������� Inner
            fn();   // 6
               // 7
               // 8

            Action Outer()  // ����� ��� ������� �������
            {
                int x, c = 11;
                void Inner()    // ��������� �������
                {
                    for (x=1; x<c; x++)     // �������� � ����������� ����������
                        Console.WriteLine(x);
                }
                return Inner;   // ���������� ��������� �������
            }
        }
    }
}