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

namespace A002_Factorial
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void button_Click(object sender, RoutedEventArgs e)
    {
      int x = int.Parse(txtNo.Text);

      var watch = System.Diagnostics.Stopwatch.StartNew();
      long rfact = rFactorial(x); // 재귀함수
      watch.Stop();
      // 수행시간을 Ticks 단위로 알려준다
      var elap = watch.ElapsedTicks;
      string result = " Ticks = " + elap;
      listBox.Items.Add(result);

      watch = System.Diagnostics.Stopwatch.StartNew();
      long fact = Factorial(x);   // 반복문
      watch.Stop();
      elap = watch.ElapsedTicks;
      result = " Ticks = " + elap;
      listBox.Items.Add(result);

      listBox.Items.Add("Recursive : " + rfact);
      listBox.Items.Add("반복문 : " + fact);
    }

    private long Factorial(int x)
    {
      long f = 1;
      for (int i = 2; i <= x; i++)
        f *= i;
      return f;
    }

    private long rFactorial(long x)
    {
      if (x == 1)
        return 1;
      else
        return rFactorial(x - 1) * x;
    }
  }
}
