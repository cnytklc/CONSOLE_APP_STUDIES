namespace RecapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button[,] button = new Button[8,8];
            int top = 0;
            int left = 0;
            for (int i = 0; i <= button.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= button.GetUpperBound(1); j++)
                {
                    button[i,j] = new Button();
                    button[i,j].Width = 50;
                    button[i,j].Height = 50;
                    button[i,j].Top = top;
                    button[i, j].Left = left;
                    this.Controls.Add(button[i,j]);
                    left += 50;
                    if ((i+j) % 2 == 0)
                    {
                        button[i, j].BackColor = Color.Black;
                    }
                }
                left = 0;
                top += 50;
                
            }
            

        }
        
    }
}