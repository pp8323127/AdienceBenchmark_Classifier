using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.IO;

namespace AGE
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("fold_0_data.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    //String line = sr.ReadToEnd();

                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] strs = line.Split('\t');
                        //for (int i = 0; i < strs.Length; i++)        //透過迴圈將陣列值取出 也可用foreach
                        //{
                        //    textBox.Text += strs[i].ToString();
                        //}

                        //textBox.Text += strs[0].ToString() + " " + strs[1].ToString() + " " + strs[3].ToString() + "\n";

                        string path = System.IO.Directory.GetCurrentDirectory();
                        path += "\\aligned\\" + strs[0].ToString() + "\\";
                        DirectoryInfo di = new DirectoryInfo(@"D:\Documents\Visual Studio 2015\Projects\AGE\AGE\bin\Debug\aligned\" + strs[0].ToString() + "\\");


                        //string[] files = Directory.GetFiles(path, "*.jpg");
                        //MessageBox.Show(files[0]);

                        string search = "landmark_aligned_face." + strs[2].ToString() + "." + strs[1].ToString();
                        
                        //landmark_aligned_face.2282.11597935265_29bcdfa4a5_o
                        //MessageBox.Show(search);
                        foreach (var fi in di.GetFiles(search))
                        {
                            //Console.WriteLine(fi.Name);
                            //textBox.Text += fi.Name;
                            //MessageBox.Show(strs[3].ToString());

                            //labels: 8 (0-2, 4-6, 8-13, 15-20, 25-32, 38-43, 48-53, 60-)
                            if (strs[3].ToString() == "(0, 2)")
                            {
                                string pathS = path + fi.Name;
                                string pathD = path + "..\\(0, 2)\\" + fi.Name;
                                File.Copy(pathS, pathD, true);
                            }
                            if (strs[3].ToString() == "(4, 6)")
                            {
                                string pathS = path + fi.Name;
                                string pathD = path + "..\\(4, 6)\\" + fi.Name;
                                File.Copy(pathS, pathD, true);
                            }
                            if (strs[3].ToString() == "(8, 13)")
                            {
                                string pathS = path + fi.Name;
                                string pathD = path + "..\\(8, 13)\\" + fi.Name;
                                File.Copy(pathS, pathD, true);
                            }
                            if (strs[3].ToString() == "(15, 20)")
                            {
                                string pathS = path + fi.Name;
                                string pathD = path + "..\\(15, 20)\\" + fi.Name;
                                File.Copy(pathS, pathD, true);
                            }
                            if (strs[3].ToString() == "(25, 32)")
                            {
                                string pathS = path + fi.Name;
                                string pathD = path + "..\\(25, 32)\\" + fi.Name;
                                File.Copy(pathS, pathD, true);
                            }
                            if (strs[3].ToString() == "(38, 43)")
                            {
                                string pathS = path + fi.Name;
                                string pathD = path + "..\\(38, 43)\\" + fi.Name;
                                File.Copy(pathS, pathD, true);
                            }
                            if (strs[3].ToString() == "(48, 53)")
                            {
                                string pathS = path + fi.Name;
                                string pathD = path + "..\\(48, 53)\\" + fi.Name;
                                File.Copy(pathS, pathD, true);
                            }
                            if (strs[3].ToString() == "(60, 100)")
                            {
                                string pathS = path + fi.Name;
                                string pathD = path + "..\\(60, 100)\\" + fi.Name;
                                File.Copy(pathS, pathD, true);
                            }


                        }


                        //MessageBox.Show(path.ToString());
                    }

                    //string line2 = sr.ReadLine();
                    //string[] strs = line2.Split('\t');
                    //Console.WriteLine(line);
                    //textBox.Text += strs;

                }
            }
            catch (Exception e)
            {
                //Console.WriteLine("The file could not be read:");
                //Console.WriteLine(e.Message);
            }
        }
    }
}
