namespace vanocniStromecek
{
    public partial class Form1 : Form
    {
        Pen myPen = new Pen(Color.Plum, 7);
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int centerX = this.ClientSize.Width / 2;

            Point[] triangle1 = { new Point(centerX, 100), new Point(centerX - 60, 200), new Point(centerX + 60, 200) };
            Point[] triangle2 = { new Point(centerX, 150), new Point(centerX - 90, 275), new Point(centerX + 90, 275) };
            Point[] triangle3 = { new Point(centerX, 210), new Point(centerX - 110, 350), new Point(centerX + 110, 350) };
            Point[] hvezda = { new Point(10, 10), new Point(15, 0), new Point(20, 10), new Point(30, 15), new Point(20, 20), new Point(25, 30), new Point(15, 20), new Point(10, 30), new Point(10, 20), new Point(0, 15) };

            Brush greenBrush = new SolidBrush(Color.Green);
            Brush brownBrush = new SolidBrush(Color.SaddleBrown);
            Brush yellowBrush = new SolidBrush(Color.Yellow);
            Brush redBrush = new SolidBrush(Color.Red);

            g.FillPolygon(greenBrush, triangle1);
            g.FillPolygon(greenBrush, triangle2);
            g.FillPolygon(greenBrush, triangle3);
            g.FillPolygon(yellowBrush,hvezda);

            g.FillRectangle(brownBrush, centerX - 20, 350, 40, 100);

            g.FillEllipse(redBrush, centerX - 40, 190, 15, 15);
            g.FillEllipse(redBrush, centerX - 75, 285, 15, 15);
            g.FillEllipse(redBrush, centerX + 40, 245, 15, 15);
            g.FillEllipse(redBrush, centerX + 60, 300, 15, 15);

            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            g.DrawLine(myPen, centerX + 35, 160, centerX - 80, 270);
            g.DrawLine(myPen, centerX - 54, 225, centerX + 65, 347);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int barvaC = rnd.Next(1, 6);

            for (int i = 0; i < 10; i++)

                if (barvaC == 1)
                { myPen.Color = Color.White; }
                if (barvaC == 2)
                { myPen.Color = Color.Blue; }
                if (barvaC == 3)
                { myPen.Color = Color.Red; }
                if (barvaC == 4)
                { myPen.Color = Color.Yellow; }
                if (barvaC == 5)
                { myPen.Color = Color.GreenYellow; }


            this.Refresh();
        }
    }
}
