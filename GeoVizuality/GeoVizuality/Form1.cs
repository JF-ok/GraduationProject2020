using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GeoVizuality
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics g;
        int wdth;
        int hgth;
        //Color[] Zcolor;
        Point[,] grid_point; PointF[,] z_grid; PointF[,] grid_arr; //массивы для регулярной сети
        int pro_counter = 0; int scrl_value = 1;
        List<Color> list_Z_colors = new List<Color>();

        Bitmap bm;
        Bitmap bmlbl;
        double deltX;
        double deltY;
        //int pic_x, pic_y; //координаты picturebox
        Pen Pen = new Pen(Color.Black);
        List<Bitmap> bitmaps_orig = new List<Bitmap>();
        Label[] lb;
        Button[] bt;
        Color[] colors, pal_colors;
        List<int> pic_X_cord = new List<int>();
        List<int> pic_Y_cord = new List<int>();

        List<double> pic_Z = new List<double>();

        //Point[] pic_X_Y_cord;
        List<double> X_cord = new List<double>();
        List<double> Y_cord = new List<double>();
        double X_min, X_max, Y_min, Y_max, Z_min, Z_max;
        int step;
        bool ready = false; bool option = false; bool pic_ready = false; //Флаг готовности
        private bool grid_ready;


        internal bool IsNumeric(string str, out string num_str) //Проверка на число, если не тот разделитель, поменять, если не число, вернуть ложь
        {
            double tmp;
            string sss = str;
            if (str != null)
            {
                if (!double.TryParse(str, out tmp)) //если не получилось преобразовать в число
                {
                    if (str.Contains(".") || str.Contains(",")) //если содержит точку или запятую
                    {
                        if (str.Contains("."))
                        {
                            sss = str.Replace(".", ",");
                        }
                        else if (str.Contains(","))
                        {
                            sss = str.Replace(",", ".");
                        }
                        num_str = sss;
                        return true;
                    }
                    else
                    {
                        num_str = str;
                        return false;
                    }
                }
                else
                {
                    num_str = str;
                    return true;
                }
            }
            else
            {
                num_str = str;
                return false;
            }
        } //Преобразование в число

        private Color[] Color_palette(Color[] color_on_pan, out Color[] colors) //создать RGB цветовую палитру
        {
            byte step = 25;
            byte r = 0, g = 0, b = 0;
            for (int i = 0; i < 48; i++)
            {
                if (i == 0)
                {
                    color_on_pan[i] = Color.FromArgb(255, 0, 0, 255);
                }
                if (i > 0 && i <= 10)
                {
                    g += step;
                    r = 255;
                    color_on_pan[i] = Color.FromArgb(255, 0, g, 255);
                }
                if (i >= 10 && i <= 20)
                {
                    g = 255;
                    r = 0;
                    b -= step;
                    color_on_pan[i] = Color.FromArgb(255, r, g, b);
                }
                if (i >= 20 && i <= 30)
                {
                    r += step;
                    g = 255;
                    b = 0;
                    color_on_pan[i] = Color.FromArgb(255, r, g, b);
                }
                if (i >= 30 && i <= 40)
                {
                    r = 255;
                    g -= step;
                    b = 0;
                    color_on_pan[i] = Color.FromArgb(255, r, g, b);
                }
                if (i >= 40 && i <= 46)
                {
                    b = 255;
                    g += step;
                    color_on_pan[i] = Color.FromArgb(255, r, g, b);
                }
                if (i == 47)
                {
                    color_on_pan[i] = Color.FromArgb(255, 255, 255, 255);
                }
            }
            Array.Reverse(color_on_pan, 0, color_on_pan.Length); //обратный порядок
            colors = color_on_pan;
            return colors;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void tb_step_MouseClick(object sender, EventArgs e) //шаг для цветовой шкалы
        {
            tb_step.ForeColor = Color.Black;
            tb_step.Text = null;
            
        }

        private void tb_step_KeyDown(object sender, KeyEventArgs e) //событие для отслеживания нажатия в поле шага цветовой шкалы
        {
            string str;
            if (e.KeyCode == Keys.Enter) //если энтер
            {
                if (IsNumeric(tb_step.Text, out str)) //если строка — это число
                {
                    if (Convert.ToInt32(str) > 0)
                    {
                        e.SuppressKeyPress = true;
                        tb_step.Text = str;
                        option = true; //флаг для использования шага в цветовой шкале
                        Labels_Values(true); //флаг для других подписей к шкале
                        Counter.Focus();
                    }
                    else
                    {
                        tb_step.Text = null;
                        option = false;
                    }
                }
                else
                {
                    tb_step.Text = null;
                    option = false;
                }
            }
            if (e.KeyCode == Keys.Escape) //если нажата кнопка эскейп
            {
                option = false; 
                Labels_Values(false);
                Counter.Focus();
                tb_step.ForeColor = Color.Gray;
                tb_step.Text = "Шаг Δ...";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wdth = p.Width;
            hgth = p.Height;
            checkedListBox1.SetItemChecked(2, true); //выбран последний элемент ("Всё")
            bitmap = new Bitmap(p_for_label.Width, p_for_label.Height);
            g = Graphics.FromImage(bitmap);
            p_for_label.Controls.Add(p);
            pal_colors = new Color[48];
            Color_palette(pal_colors, out pal_colors); //функция: цвета из палитры
            Color_Panel_Maker(); //функция: нарисовать цветовую шкалу
            tb_step.ForeColor = Color.Gray;
            tb_step.Text = "Шаг Δ...";
        }

        private void Rastr_btn_Click(object sender, EventArgs e) //кнопка "Отобразить"
        {
            if (ready)
            {
                chart1.Series.Clear(); //очистить график
                grid_ready = false;
                p.Refresh(); //очистить пикчебокс
                int count = DB.el_count;
                wdth = p.Width;
                hgth = p.Height;
                pic_X_cord.Clear(); pic_Y_cord.Clear(); X_cord.Clear(); Y_cord.Clear(); list_Z_colors.Clear(); pic_Z.Clear(); //обнулить массивы
                double deltXi;
                double deltYi;

                bm = new Bitmap(p.Width, p.Height);
                Graphics gr;
                gr = Graphics.FromImage(bm);
                List<int> piccordx = new List<int>(); //создать список для экранных координат
                List<int> piccordy = new List<int>();
                int pixX0; int pixY0; int pixX1 = 0; int pixY1 = 0; int jjj = 0;
                double sumx = 0; double sumy = 0; int re_count = 0; double sumz = 0;
                double pixZ0;
                if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked) //если выбраны рядовые маршруты
                {
                    for (int i = 0; i < count; i++)
                    {
                        deltXi = Math.Round(DB.X[i] - X_min, 2);
                        deltYi = Math.Round(DB.Y[i] - Y_min, 2);
                        pixX0 = (Convert.ToInt32(Math.Round(deltXi / deltX * p.Width, 0)));
                        pixY0 = (Convert.ToInt32(Math.Round(deltYi / deltY * p.Height, 0)));
                        pic_Z.Add(DB.Z[i]);
                        if (pixX0 != pixX1) //без опорных маршрутов полёта
                        {
                            pic_X_cord.Add(pixX0);
                            pic_Y_cord.Add(pixY0);
                            X_cord.Add(DB.X[i]);
                            Y_cord.Add(DB.Y[i]);
                            list_Z_colors.Add(Color.Transparent);
                            pixX1 = pixX0;
                            pixY1 = pixY0;
                            for (int cnt = 0; cnt < bt.Length; cnt++)
                            {
                                if (DB.Z[i] <= Convert.ToDouble(bt[cnt].Tag))
                                {
                                    list_Z_colors[jjj] = bt[cnt].BackColor;
                                }
                            }
                            gr.FillRectangle(new SolidBrush(list_Z_colors[jjj]), new Rectangle(pic_X_cord[jjj], pic_Y_cord[jjj], scrl_value, scrl_value));
                            jjj++;
                        }
                    }
                }
                if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked) //опорные маршруты
                {
                    for (int i = 0; i < count; i++)
                    {
                        deltXi = Math.Round(DB.X[i] - X_min, 2); //размах по X
                        deltYi = Math.Round(DB.Y[i] - Y_min, 2);
                        pixX0 = (Convert.ToInt32(Math.Round(deltXi / deltX * p.Width, 0))); //пересчёт координат
                        pixY0 = (Convert.ToInt32(Math.Round(deltYi / deltY * p.Height, 0)));
                        pixZ0 = DB.Z[i];
                        if (pixY0 != pixY1) //без опорных маршрутов полёта
                        {
                            piccordx.Add(pixX0);
                            piccordy.Add(pixY0);
                            X_cord.Add(DB.X[i]);
                            Y_cord.Add(DB.Y[i]);
                            pixX1 = pixX0;
                            pixY1 = pixY0;
                        }
                    }
                    for (int i = 0; i < piccordx.Count-1; i++)
                    {
                        if (piccordx[i] == piccordx[i + 1] && piccordy[i] == piccordy[i + 1])
                        {
                            sumx += DB.X[i];
                            sumy += DB.Y[i];
                            sumz += DB.Z[i];
                            re_count++;
                        }
                        else
                        {
                            sumx += DB.X[i];
                            sumy += DB.Y[i];
                            sumz += DB.Z[i];
                            re_count++;
                            pic_Z.Add(Math.Round(sumz / re_count, 2)); //значение поля
                            X_cord.Add(Math.Round(sumx / re_count, 2));
                            Y_cord.Add(Math.Round(sumy / re_count, 2));
                            pic_X_cord.Add(piccordx[i]);
                            pic_Y_cord.Add(piccordy[i]);
                            sumx = 0; sumy = 0; sumz = 0; re_count = 0;
                            list_Z_colors.Add(Color.Transparent);
                            for (int cnt = 0; cnt < bt.Length; cnt++)
                            {
                                if (pic_Z[pic_Z.Count - 1] <= Convert.ToDouble(bt[cnt].Tag))
                                {
                                    list_Z_colors[pic_Z.Count - 1] = bt[cnt].BackColor;
                                }
                            }
                            gr.FillRectangle(new SolidBrush(list_Z_colors[pic_Z.Count - 1]), new Rectangle(pic_X_cord[pic_X_cord.Count - 1], pic_Y_cord[pic_Y_cord.Count - 1], scrl_value, scrl_value)); //закрасить пиксель в соответствии с вычисленной координатой и цветом из массива
                        }
                    }
                } 
                if (checkedListBox1.GetItemCheckState(2) == CheckState.Checked) //все маршруты
                {
                    for (int i = 0; i < count; i++)
                    {
                        deltXi = Math.Round(DB.X[i] - X_min, 2);
                        deltYi = Math.Round(DB.Y[i] - Y_min, 2);
                        pixX0 = (Convert.ToInt32(Math.Round(deltXi / deltX * p.Width, 0)));
                        pixY0 = (Convert.ToInt32(Math.Round(deltYi / deltY * p.Height, 0)));
                        piccordx.Add(pixX0);
                        piccordy.Add(pixY0);
                    }
                    for (int i = 0; i < piccordx.Count - 1; i++)
                    {
                        if (piccordx[i] == piccordx[i + 1] && piccordy[i] == piccordy[i + 1])
                        {
                            sumx += DB.X[i];
                            sumy += DB.Y[i];
                            sumz += DB.Z[i];
                            re_count++;
                        }
                        else
                        {
                            sumx += DB.X[i];
                            sumy += DB.Y[i];
                            sumz += DB.Z[i];
                            re_count++;
                            pic_Z.Add(Math.Round(sumz / re_count, 2)); //значение
                            X_cord.Add(Math.Round(sumx / re_count, 2));
                            Y_cord.Add(Math.Round(sumy / re_count, 2));
                            pic_X_cord.Add(piccordx[i]);
                            pic_Y_cord.Add(piccordy[i]);
                            sumx = 0; sumy = 0; sumz = 0; re_count = 0;
                            list_Z_colors.Add(Color.Transparent);
                            for (int cnt = 0; cnt < bt.Length; cnt++)
                            {
                                if (pic_Z[pic_Z.Count - 1] <= Convert.ToDouble(bt[cnt].Tag))
                                {
                                    list_Z_colors[pic_Z.Count - 1] = bt[cnt].BackColor;
                                }
                            }
                            gr.FillRectangle(new SolidBrush(list_Z_colors[pic_Z.Count - 1]), new Rectangle(pic_X_cord[pic_X_cord.Count - 1], pic_Y_cord[pic_Y_cord.Count - 1], scrl_value, scrl_value));
                        }
                    }
                }

                //bitmaps_orig.Add(bm); //список битмапов
                bm.RotateFlip(RotateFlipType.RotateNoneFlipY); //перевернуть изображение на битмапе
                p.BackgroundImage = bm;
                pic_ready = true;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e) //изменение размера формы
        {
            if (this.WindowState == FormWindowState.Normal || this.WindowState == FormWindowState.Maximized) //если развернуто окно
            {
                main_splitContainer.SplitterDistance = main_splitContainer.ClientSize.Height - main_splitContainer.ClientSize.Height / 100 * 15; //15% положение сплиттера
                p.Height = p_for_label.Height - 2 * p.Location.Y;
                p.Width = p_for_label.Width - 2 * p.Location.X;
                bitmap = new Bitmap(p_for_label.Width, p_for_label.Height);
                g = Graphics.FromImage(bitmap);
                if (bm != null)
                {
                    Bitmap bitmap_max_size = new Bitmap(bm, new Size(p.Width, p.Height));
                    p.BackgroundImage = bitmap_max_size;
                    //p_for_label.BackgroundImage = label_bitmap_max_size;
                }
            }
        }

        private void p_MouseMove(object sender, MouseEventArgs e) //передвидение курсора по центральной области рисования
        {
            if (pic_ready && !grid_ready)
            {
                string strX, strY, strZ;
                int xx = 0;
                if (pic_X_cord.Contains(e.X) || pic_Y_cord.Contains(e.Y))
                {
                    for (int i = 0; i < pic_X_cord.Count; i++)
                    {
                        if (pic_X_cord[i] == e.X && pic_Y_cord[i] == (p.Height - e.Y))
                        {
                            xx = i;
                        }
                    }
                    strX = (X_cord[xx]).ToString();
                    strY = (Y_cord[xx]).ToString();
                    g.Clear(Color.Transparent);
                    p_for_label.Refresh();
                    g.DrawLine(new Pen(Color.Black), e.X + p.Location.X, 0, e.X + p.Location.X, p_for_label.Height);
                    g.DrawLine(new Pen(Color.Black), 0, e.Y + p.Location.Y, p_for_label.Width, e.Y + p.Location.Y);
                    g.DrawString(strY, new Font("Arial", 10), new SolidBrush(Color.Black), e.X + (p_for_label.Width - e.X - 62), e.Y + 45); //подпись координаты Y
                    g.DrawString(strX, new Font("Arial", 10), new SolidBrush(Color.Black), e.X + 62, e.Y + (p_for_label.Height - e.Y - 45));//подпись координаты X
                    strZ = (pic_Z[xx]).ToString();
                    g.DrawString(strZ, new Font("Arial", 11), new SolidBrush(list_Z_colors[xx]), e.X + 62, 25);
                    p_for_label.Image = bitmap;
                }
                else
                {
                    this.Text = "Отсутствует";
                    p_for_label.Refresh();
                }
            }
        }

        private void p_MouseLeave(object sender, EventArgs e) //курсор за пределами области
        {
            g.Clear(Color.Transparent);
            p_for_label.Refresh();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var list = sender as CheckedListBox;
            if (e.NewValue == CheckState.Checked)
            {
                foreach (int index in list.CheckedIndices)
                    if (index != e.Index)
                    {
                        list.SetItemChecked(index, false);
                    }
            }

        }

        private void tb_KeyDown(object sender, KeyEventArgs e) //нажатие кнопки в текстовом поле
        {
            string str;
            string tag;
            str = (sender as TextBox).Text;
            double step_X, step_Y, lines_X, lines_Y;
            if (e.KeyCode == Keys.Enter)
            {
                tag = (sender as TextBox).Tag.ToString();
                if (IsNumeric((sender as TextBox).Text, out str))
                {
                    if (Convert.ToDouble(str) > 0)
                    {
                        e.SuppressKeyPress = true;
                        (sender as TextBox).Text = str;
                        if (tag == "sx" || tag == "lx")
                        {
                            if (tag == "lx")
                            {
                                lines_X = Convert.ToDouble(str);
                                step_X = deltX / (lines_X - 1);
                                tb_step_X.Text = step_X.ToString("F4"); //четыре знака после запятой
                            }
                            else
                            {
                                step_X = Convert.ToDouble(str);
                                lines_X = Math.Ceiling((deltX / step_X)+1);
                                step_X = deltX / (lines_X - 1.0);
                                tb_step_X.Text = step_X.ToString("F4");
                                tb_lines_X.Text = Math.Ceiling(lines_X).ToString();
                            }
                        }
                        if (tag == "sy" || tag == "ly")
                        {
                            if (tag == "ly") //ввод количества точек
                            {
                                lines_Y = Convert.ToDouble(str);
                                step_Y = deltY / (lines_Y - 1);
                                tb_step_Y.Text = step_Y.ToString("F4");
                            }
                            else
                            {
                                step_Y = Convert.ToDouble(str);
                                lines_Y = Math.Ceiling((deltY / step_Y)+1);
                                step_Y = deltY / (lines_Y - 1.0);
                                tb_step_Y.Text = step_Y.ToString("F4");
                                tb_lines_Y.Text = Math.Ceiling(lines_Y).ToString();
                            }
                        }
                    }
                    else
                    {
                        (sender as TextBox).Text = str;
                    }
                }
                else
                {
                    (sender as TextBox).Text = str;
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                (sender as TextBox).Text = "";
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //нажатая кнопка
        {
            if (chart1.Focused && grid_ready) 
            {
                if (keyData == Keys.Up) //ось инвертирована
                {
                    if (pro_counter != 0)
                    {
                        pro_counter--;
                    }
                    else
                    {
                        pro_counter = grid_arr.GetLength(0) - 1;
                    }
                }
                if (keyData == Keys.Down) 
                {
                    if (pro_counter != (grid_arr.GetLength(0) - 1)) //ось инвертирована
                    {
                        pro_counter++;
                    }
                    else
                    {
                        pro_counter = 0;
                    }
                }
                if (keyData == Keys.Enter)
                {
                    chart1.Series.Clear();
                    chart1.Series.Add("Series1");
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chart1.Series["Series1"].LegendText = "Z, линия №: "+ (pro_counter+1) + " " + grid_arr[pro_counter, 0].Y;
                    for (int j = 0; j < z_grid.GetLength(1); j++)
                    {
                        chart1.Series["Series1"].Points.AddXY(grid_arr[pro_counter, j].X, z_grid[pro_counter, j].X);
                    }
                    chart1.ChartAreas[0].AxisX.Minimum = grid_arr[pro_counter, 0].X;
                    chart1.ChartAreas[0].AxisX.Maximum = grid_arr[pro_counter, grid_arr.GetLength(1)-1].X;
                }
                if (grid_ready)
                {
                    g.Clear(Color.Transparent);
                    p_for_label.Refresh();
                    g.DrawLine(new Pen(Color.Black), 0, grid_point[pro_counter, 0].Y + p.Location.Y, p_for_label.Width, grid_point[pro_counter, 0].Y + p.Location.Y);
                    g.DrawString(grid_arr[pro_counter, 0].Y.ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), 0, grid_point[pro_counter, 0].Y + p.Location.Y); //подпись координаты Y
                    p_for_label.Image = bitmap;
                }
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
            return true;
        }

        private void chart1_Click(object sender, EventArgs e) //клик по графику, включение фокуса
        {
            chart1.Focus();
            chart1.BorderlineColor = Color.Blue;
        }

        private void tb_Click(object sender, EventArgs e)
        {
            (sender as TextBox).Focus();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            scrl_value = trackBar1.Value;
        }

        private void Inter_btn_Click(object sender, EventArgs e) //создание регулярной сети
        {
            if (ready)
            {
                pro_counter = 0;
                chart1.Focus();
                bm = new Bitmap(p.Width, p.Height);
                Graphics gr;
                gr = Graphics.FromImage(bm);
                float sumX = (float)X_min; //начало отсчёта — приращение
                float sumY = (float)Y_min;
                double step_X = Convert.ToDouble(tb_step_X.Text);
                double step_Y = Convert.ToDouble(tb_step_Y.Text);
                int lines_X = Convert.ToInt32(tb_lines_X.Text);
                int lines_Y = Convert.ToInt32(tb_lines_Y.Text);
                grid_arr = new PointF[lines_Y, lines_X]; //регулярная сеть координат
                for (int i = 0; i < lines_Y; i++) //цикл для приращения координа двумерного массива
                {
                    for (int j = 0; j < lines_X; j++)
                    {
                        if (i == 0 && j == 0)
                        {
                            grid_arr[0, 0] = new PointF((float)X_min, (float)Y_min);
                        }
                        grid_arr[i, j] = new PointF(sumX, sumY);
                        sumX += (float)step_X;
                    }
                    sumX = (float)X_min;
                    sumY += (float)step_Y;
                }

                z_grid = new PointF[lines_Y, lines_X];

                for (int i = 0; i < z_grid.GetLength(0); i++)
                {
                    for (int j = 0; j < z_grid.GetLength(1); j++)
                    {
                        z_grid[i, j].X = 0;
                        z_grid[i, j].Y = 0;
                    }
                }

                #region MyRegion
                for (int k = 0; k < DB.Z.Count; k++) //цикл по основному массиву
                {
                    int jy = Convert.ToInt32(Math.Floor((DB.X[k] - grid_arr[0, 0].X) / step_X)); //индекс по X
                    int ix = Convert.ToInt32(Math.Floor((DB.Y[k] - grid_arr[0, 0].Y) / step_Y)); //индекс по Y
                    if (jy < 0)
                    {
                        jy = 0;
                    }
                    if (ix < 0)
                    {
                        ix = 0;
                    }
                    for (int i = ix; i <= ix + 1; i++) //счётчик по строкам
                    {
                        if (i < 0 || i >= z_grid.GetLength(0))
                        {
                            break;
                        }
                        else
                        {
                            for (int j = jy; j <= jy + 1; j++) //счётчик по столбцам
                            {
                                if (j < 0 || j >= z_grid.GetLength(1))
                                {
                                    break;
                                }
                                else
                                {
                                    z_grid[i, j].X += (float)DB.Z[k]; //суммарное значение
                                    z_grid[i, j].Y += 1; //счётчик количества
                                }
                            }
                        }
                    }
                }
                #endregion

                for (int i = 0; i < z_grid.GetLength(0); i++) //цикл деления суммы на количество в каждой точке (массив поинтов состоит из двух координат в одном элементе)
                {
                    for (int j = 0; j < z_grid.GetLength(1); j++)
                    {
                        z_grid[i, j].X = z_grid[i, j].X / z_grid[i, j].Y;
                    }
                }

                /////////////////////////
                Color[,] Zcolor_grid = new Color[lines_Y, lines_X];
                grid_point = new Point[lines_Y, lines_X];
                for (int i = 0; i < grid_arr.GetLength(0); i++)
                {
                    for (int j = 0; j < grid_arr.GetLength(1); j++)
                    {
                        grid_point[i, j].X = Convert.ToInt32((grid_arr[i, j].X - grid_arr[0, 0].X) / (grid_arr[grid_arr.GetLength(0) - 1, grid_arr.GetLength(1) - 1].X - grid_arr[0, 0].X) * (p.Width)); //пересчёт координат
                        grid_point[i, j].Y = Convert.ToInt32((grid_arr[i, j].Y - grid_arr[0, 0].Y) / (grid_arr[grid_arr.GetLength(0) - 1, grid_arr.GetLength(1) - 1].Y - grid_arr[0, 0].Y) * (p.Height));
                        for (int cnt = 1; cnt < bt.Length-1; cnt++)
                        {
                            if (z_grid[i, j].X <= Convert.ToDouble(bt[cnt].Tag))
                            {
                                Zcolor_grid[i, j] = bt[cnt].BackColor;
                            }
                        }
                        gr.FillRectangle(new SolidBrush(Zcolor_grid[i, j]), new Rectangle(grid_point[i, j].X, grid_point[i, j].Y, scrl_value, scrl_value));
                    }
                }
                bm.RotateFlip(RotateFlipType.RotateNoneFlipY);
                p.SizeMode = PictureBoxSizeMode.AutoSize;
                p.BackgroundImage = bm;
                grid_ready = true;
            }
        }

        private void ms_File_Open_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm();
            inputForm.ShowDialog(); //Отрыть форму
            //p_for_label.Controls.Add(p); //задать родительский элемент
            if (inputForm.DialogResult == DialogResult.OK)
            {
                X_min = DB.X.Min(); Y_min = DB.Y.Min(); Z_min = DB.Z.Min();
                X_max = DB.X.Max(); Y_max = DB.Y.Max(); Z_max = DB.Z.Max();
                deltX = Math.Round(X_max - X_min, 2);
                deltY = Math.Round(Y_max - Y_min, 2);
                lbl_min_X.Text = "Min: " + X_min.ToString(); lbl_max_X.Text = "Max: " + X_max.ToString();
                lbl_min_Y.Text = "Min: " + Y_min.ToString(); lbl_max_Y.Text = "Max: " + Y_max.ToString();
                ready = true;
                if (true)
                {
                    int lines_X = Convert.ToInt32(tb_lines_X.Text);
                    int lines_Y = Convert.ToInt32(tb_lines_Y.Text);
                    double step_X, step_Y;
                    step_X = deltX / (lines_X - 1);
                    step_Y = deltY / (lines_Y - 1);
                    tb_step_X.Text = step_X.ToString("F4");
                    tb_step_Y.Text = step_Y.ToString("F4");
                }
            }
            Labels_Values(false);
        }

        internal void IsNumeric()
        {
            throw new NotImplementedException();
        }

        private void main_splitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            tableLayoutPanel2.RowStyles[0].Height = main_splitContainer.SplitterDistance;
        }

        private void Counter_ValueChanged(object sender, EventArgs e)
        {
            Color_Panel_Maker();
            if (option == false)
            {
                Labels_Values(false);
            }
            else
            {
                Labels_Values(true);
            }
        }

        private void Labels_Values(bool option)
        {
            if (ready == true) ////Значения шкалы
            {
                if (option == false)
                {
                    var dlt = (Z_max - Z_min) / bt.Count() - 2; //Шаг
                    for (int cnt = bt.Count() - 1; cnt > 0; cnt--)
                    {
                        lb[0].Text = Math.Round(Z_max, 1).ToString(); //Первый элемент
                        bt[0].Tag = lb[0].Text;
                        lb[bt.Count() - 1].Text = Math.Round(Z_min, 1).ToString(); //Последний элемент
                        bt[bt.Count() - 1].Tag = lb[bt.Count() - 1].Text;
                        lb[cnt].Text = Math.Round((Z_max - (dlt * cnt)), 1).ToString();//Формула счёта
                        bt[cnt].Tag = lb[cnt].Text;
                    }
                }
                else
                {
                    step = Convert.ToInt32(tb_step.Text);
                    for (int cnt = bt.Count() - 1; cnt > 0; cnt--)
                    {
                        lb[0].Text = Math.Round(Z_max, 1).ToString(); //Первый элемент
                        bt[0].Tag = lb[0].Text;
                        lb[cnt].Text = Math.Round((Z_max - (step * cnt)), 1).ToString();//Формула счёта
                        bt[cnt].Tag = lb[cnt].Text;
                    }
                }
            }
        } // Добавить подписи к шкале

        private void Color_Panel_Maker() //Заполнение шкалы цветом
        {
            int rows_on_pan = Convert.ToInt32(Counter.Value); //Счётчик панели
            int coff = (48 / rows_on_pan);
            Array.Resize(ref colors, rows_on_pan);
            lb = new Label[rows_on_pan];
            bt = new Button[rows_on_pan];
            color_panel.Controls.Clear();
            color_panel.RowCount = 0;
            for (int i = 0; i < rows_on_pan; i++)
            {
                bt[i] = new Button();
                bt[i].Name = "Color_bt" + i.ToString();
                bt[i].FlatAppearance.BorderSize = 0;
                bt[i].FlatStyle = FlatStyle.Flat;
                bt[i].Dock = DockStyle.Fill;
                if (48 % rows_on_pan == 0)
                {
                    bt[i].BackColor = pal_colors[i * coff];
                }
                else
                {
                    bt[i].BackColor = pal_colors[i];
                }
                bt[i].Margin = new Padding(0);
                lb[i] = new Label();
                lb[i].Name = "Color_lb" + i.ToString();
                lb[i].TextAlign = ContentAlignment.MiddleRight;
                lb[i].Dock = DockStyle.Fill;
                color_panel.Controls.Add(bt[i], 1, i);
                color_panel.Controls.Add(lb[i], 0, i);
                colors[i] = bt[i].BackColor;
                color_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
                color_panel.RowCount += 1;
            }
        }
    }
}
