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
            var fn = Outer();   // fn = Inner, так как метод Outer возвращает функцию Inner
                                // вызываем внутреннюю функцию Inner
            fn();   // 6
               // 7
               // 8

            Action Outer()  // метод или внешн€€ функци€
            {
                int x, c = 11;
                void Inner()    // локальна€ функци€
                {
                    for (x=1; x<c; x++)     // операции с лексическим окружением
                        Console.WriteLine(x);
                }
                return Inner;   // возвращаем локальную функцию
            }
        }
    }
}