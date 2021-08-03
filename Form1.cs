using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Any2Base64_Converter
{
    public partial class Form1 : Form
    {
        //Создаем строковые переменные
        string StringBase64 = "";
        string StringRecovered = "";
        string ChosenFileName = "";
        string ChosenFileExtension = "";
        string ChosenFileName2 = "";
        string ChosenFileExtension2 = "";

        public Form1()
        {
            InitializeComponent();
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            if (e.Exception as System.FormatException != null)
            {     
            MessageBox.Show("Файл поврежден, либо не является действительной строкой Base64!");
            }
        }

        //Кнопка "Открыть файл" на 1 вкладке
        private void Button_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog(); //Создаем новый диалог
            openFileDialog1.Title = "Выберите файл для конвертирования"; //Присваиваем ему заголовок
            openFileDialog1.InitialDirectory = "c:\\"; //Открываем по умолчанию c:\
            openFileDialog1.Filter = "Все файлы (*.*)|*.*"; //Ставим фильтр на любой тип файлов

            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Если в диалоговом окне выбран файл и нажата кнопка "OK"
            {   
                string PathToFile = openFileDialog1.FileName; //Записываем в переменную полный путь к выбранному файлу
                ChosenFileName = Path.GetFileNameWithoutExtension(PathToFile); //Записываем в переменную только имя выбранного файла
                ChosenFileExtension = Path.GetExtension(PathToFile); //Записываем в переменную только расширение выбранного файла
                TextBox_PathToFile.Text = PathToFile.ToString(); //Прописываем полный путь в TextBox_PathToFile

                byte[] FileToConvert = File.ReadAllBytes(PathToFile); //Считываем выбранный файл в массив

                StringBase64 = Convert.ToBase64String(FileToConvert); //Конвертируем массив в строку в формате Base64

                TextBox_FileToBase64.Text = StringBase64; //Заполняем TextBox_FileToBase64 получившейся строкой в формате Base64
            }
        }

        //Кнопка "Копировать в буфер обмена" на 1 вкладке
        private void Button_CopyToClipboard_Click(object sender, EventArgs e)
        {
            if (StringBase64 != "") //Если строковая переменная под Base64 не пустая
            { 
                Clipboard.SetText(StringBase64); //Копируем в буфер обмена строку в формате Base64
                MessageBox.Show("Файл " + ChosenFileName + " скопирован в буфер обмена в формате Base64."); //Сообщение, что все готово
            }
            else MessageBox.Show("Сначала выберите файл!"); //Если переменная пустая, значит не был открыт файл
        }



        //Кнопка "Сохранить в формате Base64" на 1 вкладке
        private void Button_SaveToBase64_Click(object sender, EventArgs e)
        {
            if (StringBase64 != "") //Если строковая переменная под Base64 не пустая
            {
                SaveFileDialog saveFileDialogToBase64 = new SaveFileDialog(); //Создаем новый диалог
                saveFileDialogToBase64.Title = "Выберите место сохранения файла в формате Base64"; //Присваиваем ему заголовок
                saveFileDialogToBase64.InitialDirectory = "c:\\"; //Открываем по умолчанию c:\
                saveFileDialogToBase64.FileName = "Base64_" + ChosenFileName + ChosenFileExtension; //Прибавляем к оригинальному имени файла приставку Base64_ и оригинальное расширение
                saveFileDialogToBase64.DefaultExt = ChosenFileExtension;
                saveFileDialogToBase64.AddExtension = true;
                saveFileDialogToBase64.Filter = "Все файлы (*.*)|*.*"; //Ставим фильтр на все типы файлов

                if (saveFileDialogToBase64.ShowDialog() == DialogResult.OK) //Если в диалоговом окне нажата кнопка "OK"
                {
                    using (FileStream fs = File.Create(saveFileDialogToBase64.FileName)) //Создаем новый файл
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(StringBase64); //Создаем массив
                        fs.Write(info, 0, info.Length); //Пишем массив в наш файл 
                        MessageBox.Show("Файл \"" + saveFileDialogToBase64.FileName + "\" успешно сохранен!"); //Сообщение, что все готово
                    }
                }            
            }
            else MessageBox.Show("Сначала выберите файл!"); //Если переменная пустая, значит не был открыт файл
        }
        
        //Кнопка "Открыть файл" на 2 вкладке
        private void Button_OpenFile2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog(); //Создаем новый диалог
            openFileDialog2.Title = "Выберите файл для восстановления"; //Присваиваем ему заголовок
            openFileDialog2.InitialDirectory = "c:\\"; //Открываем по умолчанию c:\
            openFileDialog2.Filter = "Все файлы (*.*)|*.*"; //Ставим фильтр на любой тип файлов

            if (openFileDialog2.ShowDialog() == DialogResult.OK) //Если в диалоговом окне выбран файл и нажата кнопка "OK"
            {
                string PathToFile2 = openFileDialog2.FileName; //Записываем в переменную полный путь к выбранному файлу
                ChosenFileName2 = Path.GetFileNameWithoutExtension(PathToFile2); //Записываем в переменную только имя выбранного файла
                ChosenFileExtension2 = Path.GetExtension(PathToFile2); //Записываем в переменную только расширение выбранного файла
                TextBox_PathToFile2.Text = PathToFile2.ToString(); //Прописываем полный путь в TextBox_PathToFile2

                using (FileStream fs2 = File.OpenRead(PathToFile2)) //Создаем файловый поток и считываем выбранный файл
                {
                    byte[] b = new byte[2147483591]; //Создаем массив размером 2ГБ (позже надо ограничить мегабайт до 100)
                    int c;
                    while ((c = fs2.Read(b, 0, b.Length)) > 0) 
                    {
                        StringRecovered = Encoding.UTF8.GetString(b, 0, c); //Заполняем переменную StringRecovered считанной строкой в формате Base64          
                    }
                }
                TextBox_Base64ToFile.Text = StringRecovered; //Заполняем TextBox_Base64ToFile считанной строкой в формате Base64
            }
        }

        //Кнопка "Восстановить файл" на 2 вкладке
        private void Button_RecoverFromBase64_Click(object sender, EventArgs e)
        {
            if (StringRecovered != "") //Если строковая переменная под Base64 не пустая
            {
                
                SaveFileDialog saveFileDialogFromBase64 = new SaveFileDialog(); //Создаем новый диалог
                saveFileDialogFromBase64.Title = "Выберите место сохранения восстановленного файла"; //Присваиваем ему заголовок
                saveFileDialogFromBase64.InitialDirectory = "c:\\"; //Открываем по умолчанию c:\
                saveFileDialogFromBase64.FileName = "Recovered_" + ChosenFileName2 + ChosenFileExtension2;//Прибавляем к оригинальному имени файла приставку Recovered_ и оригинальное расширение
                saveFileDialogFromBase64.DefaultExt = ChosenFileExtension2;
                saveFileDialogFromBase64.AddExtension = true;
                saveFileDialogFromBase64.Filter = "Все файлы (*.*)|*.*"; //Ставим фильтр на любой тип файлов

                if (saveFileDialogFromBase64.ShowDialog() == DialogResult.OK) //Если в диалоговом окне нажата кнопка "OK"
                {
                    File.WriteAllBytes(saveFileDialogFromBase64.FileName, Convert.FromBase64String(StringRecovered)); //Декодируем строку из Base64 и пишем результат в файл

                    MessageBox.Show("Файл \""+ saveFileDialogFromBase64.FileName + "\" успешно восстановлен!"); //Сообщение, что все готово
                }
            }
            else MessageBox.Show("Сначала выберите файл!"); //Если переменная пустая, значит не был открыт файл
        }

        //Кнопка "Закрыть" на 1 вкладке
        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Кнопка "Закрыть" на 2 вкладке
        private void Button_Close2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Кнопка "Закрыть" на 3 вкладке
        private void Button_Close3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
