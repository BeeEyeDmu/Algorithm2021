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

namespace A003_fibo
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
      int n = int.Parse(txtNo.Text);
      listBox.Items.Clear();

      listBox.Items.Add("Recursive Fibonacci");

      // 시간 측정
      var watch = System.Diagnostics.Stopwatch.StartNew();
      for (int i = 1; i <= n; i++)
      {
        listBox.Items.Add(Fibonacci(i));
      }
      watch.Stop();
      var elap = watch.ElapsedTicks;
      listBox.Items.Add("Ticks = " + elap + ", ms = " + watch.ElapsedMilliseconds);

      // 반복문으로 계산
      int[] fibo = new int[101];

      watch = System.Diagnostics.Stopwatch.StartNew();
      for (int i = 1; i <= n; i++)
      {
        if (i == 1 || i == 2)
          fibo[i] = 1;
        else
          fibo[i] = fibo[i - 1] + fibo[i - 2];
      }
      watch.Stop();
      elap = watch.ElapsedTicks;
      
      listBox.Items.Add("Loop Fibonacci");
      for (int i = 1; i <= n; i++)
      {
        listBox.Items.Add(fibo[i]);
      }
      listBox.Items.Add("Ticks = " + elap + ", ms = " + watch.ElapsedMilliseconds);
    }

    private int Fibonacci(int i)
    {
      if (i == 1 || i == 2)
        return 1;
      else
        return Fibonacci(i - 1) + Fibonacci(i - 2);
    }
  }
}
