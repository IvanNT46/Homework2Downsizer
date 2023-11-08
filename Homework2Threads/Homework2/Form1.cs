namespace Homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int percentScale;

        Bitmap originalImage;

        int newWidth;
        int newHeight;

        Bitmap newImage;

        //Всички ThreadWorker методи съдържат в себе си еднакви мащабиращи формули, разпределени за различни части от снимката

        //Тоест съм разделил снимката на 8 части и 8 ядра бачкат яко,
        //за да компенсират бавната работа на GetPixel() и SetPixel(),
        //които не успях да заменя с по-ефикасни методи, за съжаление :(

        void ThreadWOrker1(int from, int to)
        {

            for (int x = from; x < to; x++)
            {
                for (int y = 0; y < newHeight; y++)
                {
                    int red = 0, green = 0, blue = 0, pixelCount = 0;

                    for (int newX = 0; newX < originalImage.Width / 8; newX++)
                    {

                        for (int newY = 0; newY < originalImage.Height; newY++)
                        {
                            int finalX = x * originalImage.Width / newWidth;
                            int finalY = y * originalImage.Height / newHeight;

                            Color color = originalImage.GetPixel(finalX, finalY);
                            red += color.R;
                            green += color.G;
                            blue += color.B;
                            pixelCount++;
                        }
                    }

                    Color averageColor = Color.FromArgb(red / pixelCount, green / pixelCount, blue / pixelCount);
                    newImage.SetPixel(x, y, averageColor);
                }
            }
        }
        void ThreadWOrker2(int from, int to)
        {

            for (int x = from; x < to; x++)
            {
                for (int y = 0; y < newHeight; y++)
                {
                    int red = 0, green = 0, blue = 0, pixelCount = 0;

                    for (int newX = originalImage.Width / 8; newX < 2 * originalImage.Width / 8; newX++)
                    {

                        for (int newY = 0; newY < originalImage.Height; newY++)
                        {
                            int finalX = x * originalImage.Width / newWidth;
                            int finalY = y * originalImage.Height / newHeight;

                            Color color = originalImage.GetPixel(finalX, finalY);
                            red += color.R;
                            green += color.G;
                            blue += color.B;
                            pixelCount++;
                        }
                    }

                    Color averageColor = Color.FromArgb(red / pixelCount, green / pixelCount, blue / pixelCount);
                    newImage.SetPixel(x, y, averageColor);
                }
            }
        }
        void ThreadWOrker3(int from, int to)
        {

            for (int x = from; x < to; x++)
            {
                for (int y = 0; y < newHeight; y++)
                {
                    int red = 0, green = 0, blue = 0, pixelCount = 0;

                    for (int newX = 2 * originalImage.Width / 8; newX < 3 * originalImage.Width / 8; newX++)
                    {

                        for (int newY = 0; newY < originalImage.Height; newY++)
                        {
                            int finalX = x * originalImage.Width / newWidth;
                            int finalY = y * originalImage.Height / newHeight;

                            Color color = originalImage.GetPixel(finalX, finalY);
                            red += color.R;
                            green += color.G;
                            blue += color.B;
                            pixelCount++;
                        }
                    }

                    Color averageColor = Color.FromArgb(red / pixelCount, green / pixelCount, blue / pixelCount);
                    newImage.SetPixel(x, y, averageColor);
                }
            }
        }
        void ThreadWOrker4(int from, int to)
        {

            for (int x = from; x < to; x++)
            {
                for (int y = 0; y < newHeight; y++)
                {
                    int red = 0, green = 0, blue = 0, pixelCount = 0;

                    for (int newX = 3 * originalImage.Width / 8; newX < 4 * originalImage.Width / 8; newX++)
                    {

                        for (int newY = 0; newY < originalImage.Height; newY++)
                        {
                            int finalX = x * originalImage.Width / newWidth;
                            int finalY = y * originalImage.Height / newHeight;

                            Color color = originalImage.GetPixel(finalX, finalY);
                            red += color.R;
                            green += color.G;
                            blue += color.B;
                            pixelCount++;
                        }
                    }

                    Color averageColor = Color.FromArgb(red / pixelCount, green / pixelCount, blue / pixelCount);
                    newImage.SetPixel(x, y, averageColor);
                }
            }
        }
        void ThreadWOrker5(int from, int to)
        {

            for (int x = from; x < to; x++)
            {
                for (int y = 0; y < newHeight; y++)
                {
                    int red = 0, green = 0, blue = 0, pixelCount = 0;

                    for (int newX = 4 * originalImage.Width / 8; newX < 5 * originalImage.Width / 8; newX++)
                    {

                        for (int newY = 0; newY < originalImage.Height; newY++)
                        {
                            int finalX = x * originalImage.Width / newWidth;
                            int finalY = y * originalImage.Height / newHeight;

                            Color color = originalImage.GetPixel(finalX, finalY);
                            red += color.R;
                            green += color.G;
                            blue += color.B;
                            pixelCount++;
                        }
                    }

                    Color averageColor = Color.FromArgb(red / pixelCount, green / pixelCount, blue / pixelCount);
                    newImage.SetPixel(x, y, averageColor);
                }
            }
        }
        void ThreadWOrker6(int from, int to)
        {

            for (int x = from; x < to; x++)
            {
                for (int y = 0; y < newHeight; y++)
                {
                    int red = 0, green = 0, blue = 0, pixelCount = 0;

                    for (int newX = 5 * originalImage.Width / 8; newX < 6 * originalImage.Width / 8; newX++)
                    {

                        for (int newY = 0; newY < originalImage.Height; newY++)
                        {
                            int finalX = x * originalImage.Width / newWidth;
                            int finalY = y * originalImage.Height / newHeight;

                            Color color = originalImage.GetPixel(finalX, finalY);
                            red += color.R;
                            green += color.G;
                            blue += color.B;
                            pixelCount++;
                        }
                    }

                    Color averageColor = Color.FromArgb(red / pixelCount, green / pixelCount, blue / pixelCount);
                    newImage.SetPixel(x, y, averageColor);
                }
            }
        }
        void ThreadWOrker7(int from, int to)
        {

            for (int x = from; x < to; x++)
            {
                for (int y = 0; y < newHeight; y++)
                {
                    int red = 0, green = 0, blue = 0, pixelCount = 0;

                    for (int newX = 6 * originalImage.Width / 8; newX < 7 * originalImage.Width / 8; newX++)
                    {

                        for (int newY = 0; newY < originalImage.Height; newY++)
                        {
                            int finalX = x * originalImage.Width / newWidth;
                            int finalY = y * originalImage.Height / newHeight;

                            Color color = originalImage.GetPixel(finalX, finalY);
                            red += color.R;
                            green += color.G;
                            blue += color.B;
                            pixelCount++;
                        }
                    }

                    Color averageColor = Color.FromArgb(red / pixelCount, green / pixelCount, blue / pixelCount);
                    newImage.SetPixel(x, y, averageColor);
                }
            }
        }
        void ThreadWOrker8(int from, int to)
        {

            for (int x = from; x < to; x++)
            {
                for (int y = 0; y < newHeight; y++)
                {
                    int red = 0, green = 0, blue = 0, pixelCount = 0;

                    for (int newX = 7 * originalImage.Width / 8; newX < originalImage.Width; newX++)
                    {

                        for (int newY = 0; newY < originalImage.Height; newY++)
                        {
                            int finalX = x * originalImage.Width / newWidth;
                            int finalY = y * originalImage.Height / newHeight;

                            Color color = originalImage.GetPixel(finalX, finalY);
                            red += color.R;
                            green += color.G;
                            blue += color.B;
                            pixelCount++;
                        }
                    }

                    Color averageColor = Color.FromArgb(red / pixelCount, green / pixelCount, blue / pixelCount);
                    newImage.SetPixel(x, y, averageColor);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                percentScale = Int32.Parse(textBox1.Text);
                if (percentScale < 100)
                {
                    originalImage = new Bitmap(pictureBox1.Image);
                    newWidth = originalImage.Width * percentScale / 100;
                    newHeight = originalImage.Height * percentScale / 100;
                    newImage = new Bitmap(newWidth, newHeight);
                    label2.Text = "Задачата се изпълнява...";

                    Thread t1 = new Thread(p => ThreadWOrker1(0, newWidth / 8));
                    Thread t2 = new Thread(p => ThreadWOrker2(newWidth / 8, 2 * newWidth / 8));
                    Thread t3 = new Thread(p => ThreadWOrker3(2 * newWidth / 8, 3 * newWidth / 8));
                    Thread t4 = new Thread(p => ThreadWOrker4(3 * newWidth / 8, 4 * newWidth / 8));
                    Thread t5 = new Thread(p => ThreadWOrker5(4 * newWidth / 8, 5 * newWidth / 8));
                    Thread t6 = new Thread(p => ThreadWOrker6(5 * newWidth / 8, 6 * newWidth / 8));
                    Thread t7 = new Thread(p => ThreadWOrker7(6 * newWidth / 8, 7 * newWidth / 8));
                    Thread t8 = new Thread(p => ThreadWOrker8(7 * newWidth / 8, newWidth));
                    t1.Start();
                    t1.Join();
                    t2.Start();
                    t2.Join();
                    t3.Start();
                    t3.Join();
                    t4.Start();
                    t4.Join();
                    t5.Start();
                    t5.Join();
                    t6.Start();
                    t6.Join();
                    t7.Start();
                    t7.Join();
                    t8.Start();
                    t8.Join();

                    pictureBox1.Image = newImage;
                    label2.Text = "ЗАВЪРШЕНО!";
                }
                else
                {
                    MessageBox.Show("Трябва да е по-малко от 100%");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Възникна грешка: {ex.ToString}");
            }

        }
    }
}