using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GeoVizuality
{
    public partial class InputForm : Form //дочерняя форма
    {
        OpenFileDialog ofd;
        string[,] file_arr;
        int ind_x;
        int ind_y;
        int ind_z;

        public InputForm()
        {
            InitializeComponent();
        }


        private void tb_path_MouseClick(object sender, MouseEventArgs e) //событие нажатия кнопки мыши
        {
            comboxX.SelectedIndex = -1; //пустое значение комбобокс
            comboxY.SelectedIndex = -1;
            comboxZ.SelectedIndex = -1;
            comboxX.Items.Clear(); //очистить значения комбобокс
            comboxY.Items.Clear();
            comboxZ.Items.Clear();
            tb_path.ForeColor = Color.Black; //цвет текста в текстовом поле выбора файла
            lbl_state.Text = "Открыть?";
            ofd = new OpenFileDialog(); //новый экземпляр диалогового окна
            ofd.Title = "Выберите файл"; //название диалогового окна
            ofd.FileName = "";
            ofd.Filter = "Текстовые файлы|*.txt;*.XYZ"; //фильтр по выбору файлов
            if (ofd.ShowDialog() == DialogResult.OK) //если нажата кнопка "ОК"
            {
                tb_path.Text = ofd.FileName; //путь файла в текстовом поле
            }
            else
            {
                ofd.FileName = null; //обнулить путь файла
                tb_path.Text = "Выбрать файл...";//подсказка в текстовом поле 
                tb_path.ForeColor = Color.Gray;
            }
        }

        private void InputForm_Load(object sender, EventArgs e) //при загрузке формы
        {
            tb_path.Text = "Выбрать файл...";//подсказка
            tb_path.ForeColor = Color.Gray;
            lbl_state.Text = "Укажите файл";
        }

        private void Open_File_Click(object sender, EventArgs e) //кнопка открытия файла
        {
            if (ofd != null) //если не пустой путь файла
            {
                if (ofd.FileName != "") //если путь файла не пустая строка
                {
                    lbl_state.Text = "Необходимо выбрать столбцы:";
                    char[] splitchar = { ' ' }; //массив разделителей (можно задать другие)
                    int count_line = 0;
                    string[] str_arr = null;
                    StreamReader sr = new StreamReader(ofd.FileName); //новый поток чтения файла
                    string line;
                    comboxX.SelectedIndex = -1; //пустое значение комбобокс
                    comboxY.SelectedIndex = -1;
                    comboxZ.SelectedIndex = -1;
                    DataGridView.Columns.Clear(); //очистить таблицу
                    if (sr != null) //если не пустая строка
                    {
                        line = sr.ReadLine(); //считать одну строку
                        str_arr = line.Split(splitchar, StringSplitOptions.RemoveEmptyEntries); //получить массив строк путём разделения одной строки
                        for (int i = 0; i < str_arr.Length; i++) //цикл по разделённой строке
                        {
                            DataGridView.Columns.Add("i", "Столбец " + (i + 1)); //добавить колонку в таблицу
                        }
                        DataGridView.RowCount = 5; //количество строк в таблицу
                        sr.BaseStream.Position = 0; //сбросить номер считываемой строки
                        while (!sr.EndOfStream) //цикл пока не конец файла
                        {
                            line = sr.ReadLine(); //считать одно стоку
                            count_line++; //счётчик
                        }
                        info_lb.Text = "Файл содержит: " + count_line + " строк"; //подпись с информацией
                        file_arr = new string[count_line, str_arr.Length]; //новый двумерный массив строк из файла
                        sr.BaseStream.Position = 0;
                        for (int i = 0; i < count_line && !sr.EndOfStream; i++) //цикл до конца файла и количества строк
                        {
                            line = sr.ReadLine();
                            str_arr = line.Split(splitchar, StringSplitOptions.RemoveEmptyEntries);//получили массив строк
                            for (int j = 0; j < str_arr.Length; j++) //цикл по строкам массива
                            {
                                file_arr[i, j] = str_arr[j];
                            }
                        }
                        sr.Close(); //закрыть файл
                        for (int i = 0; i < DataGridView.RowCount; i++) //цикл по строкам таблицы --
                        {
                            for (int j = 0; j < DataGridView.ColumnCount; j++) //цикл по столбцам таблицы ||
                            {
                                DataGridView.Rows[i].Cells[j].Value = file_arr[i, j]; //присвоить j-й ячейке i-й строки значение из массива строк файла
                            }
                        }
                        foreach (DataGridViewColumn col in DataGridView.Columns)
                        {
                            comboxX.Items.Add(col.HeaderCell.Value); //добавить в комбобокс новый заголовок
                            comboxY.Items.Add(col.HeaderCell.Value);
                            comboxZ.Items.Add(col.HeaderCell.Value);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Файл не содержит данных", "Ошибка");
                    }
                }
                else
                {
                    lbl_state.Text = "Файл не выбран";
                }
            }
        }

        private void Start_btn_Click(object sender, EventArgs e) //кнопка "Применить"
        {
            Form1 form1 = new Form1();
            if (comboxX.SelectedIndex >= 0 & comboxY.SelectedIndex >= 0 & comboxZ.SelectedIndex >= 0) //если выбран элемент списка (комбобокс)
            {
                ind_x = comboxX.SelectedIndex; //присвоить переменной индекс выбранного элемента комбобокса
                ind_y = comboxY.SelectedIndex;
                ind_z = comboxZ.SelectedIndex;
                string tmpx, tmpy, tmpz;
                for (int i = 0; i < file_arr.GetLength(0); i++) //цикл по массиву значений из файла
                {
                    if (form1.IsNumeric(file_arr[i, ind_x], out tmpx) & form1.IsNumeric(file_arr[i, ind_y], out tmpy) & form1.IsNumeric(file_arr[i, ind_z], out tmpz)) //если значения — числа
                    {
                        DB.X.Add(Convert.ToDouble(tmpx)); //передать значение в класс-накопитель
                        DB.Y.Add(Convert.ToDouble(tmpy));
                        DB.Z.Add(Convert.ToDouble(tmpz));
                    }
                }
                DB.el_count = DB.Z.Count;
                this.DialogResult = DialogResult.OK; //вернуть значение диалогового окна как "ОК"
            }
            else
            {
                MessageBox.Show("Необходимо выбрать столбцы с данными", "Ошибка");
            }
        }

        private void combox_SelectedValueChanged(object sender, EventArgs e) //Событие на изменение значения в списке
        {
            if (comboxX.SelectedIndex >= 0 & comboxY.SelectedIndex >= 0 & comboxZ.SelectedIndex >= 0)
            {
                lbl_state.Text = "Применить?";
            }
            else
            {
                lbl_state.Text = "Необходимо выбрать столбцы:";
            }
        }
    }
}
